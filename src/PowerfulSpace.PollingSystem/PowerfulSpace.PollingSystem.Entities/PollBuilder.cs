using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerfulSpace.PollingSystem.Entities
{
    public class PollBuilder
    {
        private readonly List<PollAnswer> _items = new List<PollAnswer>();
        private readonly string _questionText;

        public PollBuilder(string questionText)
        {
            _questionText = questionText;
        } 
        
        public PollBuilder AddAnswer(int id, string title)
        {
            _items.Add(new PollAnswer(id, title));

            return this;
        }

        public Poll Build()
        {
            return new Poll(_questionText, _items);
        }

        public PollResults GetResults(Poll poll)
        {
            return new PollResults(poll);
        }
    }
}
