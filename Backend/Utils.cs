using NekoKeep.Backend.Classes;
using System.Net.Mail;

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

        public static bool ValidateMpin(string mpin)
        {
            return !string.IsNullOrEmpty(mpin) && mpin.Length == 6 && int.TryParse(mpin, out _);
        }

        public static void ThrowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ThrowSuccess(string message)
        {
            MessageBox.Show(message, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
