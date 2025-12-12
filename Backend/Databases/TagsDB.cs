using MySql.Data.MySqlClient;
using NekoKeep.Backend.Classes;
using NekoKeep.Backend.Interfaces;

namespace NekoKeep.Backend.Databases
{
    // All Tags Database Queries
    public class TagsDB : MainDB
    {
        // Tag Creation
        public static void CreateTag(int userId, string tagName)
        {
            string sql = @"INSERT INTO Tags (user_id, display_name) VALUES (@user_id, @display_name);";

            using var cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@user_id", userId);
            cmd.Parameters.AddWithValue("@display_name", tagName);
            cmd.ExecuteNonQuery();
        }

        // Retrieve All tags from an account
        public static List<ITag> RetrieveAccountTags(int accountId)
        {
            string sql = @"SELECT tag_id FROM Filters WHERE account_id = @account_id;";

            using var cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@account_id", accountId);

            List<int> tagsIds = [];
            List<ITag> tags = [];

            using var reader = cmd.ExecuteReader();
            while (reader.Read()) tagsIds.Add(reader.GetInt32("tag_id"));
            reader.Close();

            foreach (int tagId in tagsIds) tags.Add(RetrieveTag(tagId)!);

            return tags;
        }

        // Get a tag's display name, returns null if not found
        public static ITag? RetrieveTag(int tagId)
        {
            string sql = "SELECT display_name FROM Tags WHERE tag_id = @tag_id;";

            using var cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@tag_id", tagId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ITag tag = new TagDto()
                {
                    DisplayName = reader.GetString("display_name"),
                    Id = tagId
                };
                reader.Close();
                return tag;
            }
            reader.Close();
            return null;
        }

        // Get all tags
        public static List<ITag> RetrieveTags(int userId)
        {
            List<ITag> tags = [];

            string sql = "SELECT * FROM Tags WHERE user_id = @user_id ORDER BY display_name;";

            using var cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@user_id", userId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ITag tag = new TagDto()
                {
                    Id = reader.GetInt32("tag_id"),
                    DisplayName = reader.GetString("display_name"),
                };
                tags.Add(tag);
            }
            reader.Close();

            return tags;
        }

        // Modify tag
        public static void UpdateTag(ITag tag)
        {
            string sql = @"UPDATE Tags SET display_name = @display_name WHERE tag_id = @tag_id;";

            using var cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@display_name", tag.DisplayName);
            cmd.Parameters.AddWithValue("@tag_id", tag.Id);
            cmd.ExecuteNonQuery();

            // Update tags in all current accounts
            User.Session!.Accounts!.ForEach(account =>
            {
                if (account.Data.Tags.Any(t => t.Id == tag.Id))
                {
                    var tagToUpdate = account.Data.Tags.First(t => t.Id == tag.Id);
                    tagToUpdate.DisplayName = tag.DisplayName;
                }
            });
        }

        // Delete tag
        public static void DeleteTag(int tagId)
        {
            string sql = @"DELETE FROM Tags WHERE tag_id = @tag_id;";

            using var cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@tag_id", tagId);
            cmd.ExecuteNonQuery();

            // Remove tag from all current accounts
            User.Session!.Accounts!.ForEach(account => account.Data.Tags.RemoveAll(t => t.Id == tagId));
        }

        // Resolve tag with tag names
        public static List<ITag> ResolveTags(List<string> tagNames)
        {
            int userId = User.Session!.Id;
            var tags = new List<ITag>();
            List<ITag> currentTags = RetrieveTags(userId);

            foreach (var name in tagNames)
            {
                if (string.IsNullOrWhiteSpace(name)) continue;
                ITag? existingTag = currentTags.FirstOrDefault(t => t.DisplayName!.Equals(name, StringComparison.OrdinalIgnoreCase));

                if (existingTag != null) tags.Add(existingTag);
                else
                {
                    CreateTag(userId, name);
                    ITag newTag = RetrieveTags(userId).FirstOrDefault(t => t.DisplayName!.Equals(name, StringComparison.OrdinalIgnoreCase))!;
                    tags.Add(newTag);
                }
            }

            return tags;
        }
    }
}
