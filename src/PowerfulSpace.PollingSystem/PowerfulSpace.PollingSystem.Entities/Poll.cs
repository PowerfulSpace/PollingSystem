using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerfulSpace.PollingSystem.Entities
{
    [DebuggerDisplay("{QuestionText}")]
    public class Poll
    {

        public string QuestionText { get; }

        public List<PollAnswer>? Answers { get;}


        public Poll(string questionText, List<PollAnswer> answers)
        {
            QuestionText = questionText;
            Answers = answers;
        }


        public void VoteTo(int id, int value = 1)
        {
            var item = Answers?.SingleOrDefault(x => x.Id == id);

            if(item == null) { return; }

            item.Votes += value;

            var totalVotes = Answers?.Sum(x => x.Votes) ?? 0;

            Answers?.ForEach(x => x.SetPercents(totalVotes));

        }

    }

}
