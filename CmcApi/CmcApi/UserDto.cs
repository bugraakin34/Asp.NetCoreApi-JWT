namespace CmcApi
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public bool Check { get; set; }
    }
}
