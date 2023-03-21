namespace CmcApi
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public bool Check { get; set; }
    }
}
