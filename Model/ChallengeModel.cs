namespace Model
{
    public class Challenge
    {
        public int ChallengeId { get; set; }
        public string Name { get; set; }

        public Challenge(string name)
        {
            Name = name;
        }
    }
}