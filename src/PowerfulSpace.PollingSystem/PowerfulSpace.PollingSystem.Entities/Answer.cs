using PowerfulSpace.PollingSystem.Entities.Base;
using System;
using System.Diagnostics;

namespace PowerfulSpace.PollingSystem.Entities
{
    [DebuggerDisplay("{Title} {Votes} {Procents}")]
    public class Answer : Identity
    {
        public Answer(Guid id, string title)
        {
            Id = id;
            Title = title;
        }

        public string Title { get;}

        public int Votes { get; set; }

        public double Percents { get; set; }

        public void SetPercents(int totalVotes)
        {
            if(totalVotes > 0)
            {
                Percents = Votes * 100d / totalVotes;
            }            
        }

        public override string ToString()
        {
            return $"* {Title} - {Votes} ({Percents:F}%)";
        }
    }

}
