using System.Diagnostics;

namespace PowerfulSpace.PollingSystem.Entities
{
    [DebuggerDisplay("{Title} {Votes} {Procents}")]
    public class PollAnswer
    {
        public PollAnswer(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public int Id { get;}

        public string Title { get;}

        public int Votes { get; set; }

        public double Procents { get; set; }

        public void SetPercents(int totalVotes)
        {
            if(totalVotes > 0)
            {
                Procents = Votes * 100d / totalVotes;
            }            
        }

        public override string ToString()
        {
            return $"* {Title} ({Votes} {Procents:F})";
        }
    }

}
