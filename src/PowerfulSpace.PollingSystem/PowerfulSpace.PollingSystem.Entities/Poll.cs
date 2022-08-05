﻿using PowerfulSpace.PollingSystem.Entities.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PowerfulSpace.PollingSystem.Entities
{
    [DebuggerDisplay("{QuestionText}")]
    public class Poll : Identity
    {

        public string QuestionText { get; init; }

        public List<Answer>? Answers { get;}




        public Poll(string questionText, List<Answer> answers) : this(questionText)
        {
            //QuestionText = questionText;
            Answers = answers;
        }

        private Poll(string questionText)
        {
            QuestionText = questionText;
        }





        public void VoteTo(Guid id, int value = 1)
        {
            var item = Answers?.SingleOrDefault(x => x.Id == id);

            if(item == null) { return; }

            item.Votes += value;

            var totalVotes = Answers?.Sum(x => x.Votes) ?? 0;

            Answers?.ForEach(x => x.SetPercents(totalVotes));

        }

    }

}
