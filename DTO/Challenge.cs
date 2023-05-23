namespace DTO
{
    public class ChallengeDTO
    {
        public int ChallengeId { get; set; }
        public string Name { get; set; } = null;
        public string Description { get; set; } = null;
    }

    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string Email { get; set; } = null;
        public string Password { get; set; } = null;
        public bool IsAdmin { get; set; } = false;
    }
}