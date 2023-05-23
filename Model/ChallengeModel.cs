namespace Model
{
    public class Challenge
    {
        public int ChallengeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Challenge(string name, string description)
        {
            Name = name;
            Description = description;
          
        }
       
    }

    public class ChallengeApplication
    {
        public Challenge Challenge { get; set; }
        public User Applicant { get; set; }
        public string RelevantExperience { get; set; }
        public string Reason { get; set; }
    }

    public class ChallengeResult
    {
        public Challenge Challenge { get; set; }
        public User Participant { get; set; }
        public int Score { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}