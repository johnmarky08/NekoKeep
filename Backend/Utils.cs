using NekoKeep.Backend.Classes;
using System.Net.Mail;
using System.Text;
using System.Text.Json;

namespace NekoKeep.Backend
{
    public class Utils
    {
        private static readonly HashSet<string> AllowedAccountTypes = ["OAuth", "Custom"];
        public static string BCryptEncrypt(string text) => BCrypt.Net.BCrypt.HashPassword(text);

        public static bool BCryptVerify(string text, string hash) => BCrypt.Net.BCrypt.Verify(text, hash);

        public static bool IsAuthenticated()
        {
            if (User.Session == null)
            {
                ThrowError("User is not authenticated.");
                return false;
            }

            return true;
        }

        public static bool ValidateType(string type)
        {
            if (!AllowedAccountTypes.Contains(type))
            {
                ThrowError("Invalid Type! Only accepts 'OAuth' or 'Custom'");
                return false;
            }

            return true;
        }

        public static bool ValidateEmail(string email)
        {
            string trimmed = email.Trim();

            try
            {
                var addr = new MailAddress(trimmed);

                if (addr.Address != trimmed) return false;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidatePassword(string password)
        {
            return password != null
                && password.Length >= 8
                && password.Any(char.IsUpper)
                && password.Any(char.IsLower)
                && password.Any(char.IsDigit)
                && password.Any(ch => !char.IsLetterOrDigit(ch));
        }

        public static bool ValidateMpin(string mpin) => !string.IsNullOrEmpty(mpin) && mpin.Length == 6 && int.TryParse(mpin, out _);

        public static void ThrowError(string message) => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void ThrowSuccess(string message) => MessageBox.Show(message, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public async static Task<string?> SendOtp(string email)
        {
            string otp = "";
            Random rand = new();
            for (int i = 0; i < 6; i++)
            {
                otp += rand.Next(0, 10).ToString();
            }

            var url = "https://api.emailjs.com/api/v1.0/email/send";

            var payload = new
            {
                service_id = "service_y3j890m",
                template_id = "template_rhyy79c",
                user_id = "wReHiWUtlbeZs0Rhh",
                accessToken = Environment.GetEnvironmentVariable("EMAILJS_ACCESS_TOKEN"),
                template_params = new
                {
                    to_email = email,
                    otp
                }
            };

            var json = JsonSerializer.Serialize(payload);
            using var client = new HttpClient();
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            using var response = await client.PostAsync(url, content);
            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                ThrowError("EmailJS error: " + result);
                return null;
            }

            return otp;
        }
    }
}
