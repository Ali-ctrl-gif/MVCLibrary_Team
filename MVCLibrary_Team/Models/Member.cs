namespace MVCLibrary_Team.Models
{
    public class Member
    {
        public int Id { get; set; }
        private static int _nextId { get; set; } = 1;
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public DateTime JoinDate { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDeleted { get; set; }
        public Member()
        {
            Id = _nextId++;
        }
    }
}
