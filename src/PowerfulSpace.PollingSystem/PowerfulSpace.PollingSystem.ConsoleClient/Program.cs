using PowerfulSpace.PollingSystem.Entities;
using System;
using System.Collections.Generic;



var builder = new PollBuilder("Какое расстояние до луны?")
    .AddAnswer(1, "589м")
    .AddAnswer(2, "140км")
    .AddAnswer(3, "384км")
    .AddAnswer(4, "573км")
    .AddAnswer(5, "984км")
    .AddAnswer(6, "1901км")
    .AddAnswer(7, "5872км");

var poll = builder.Build();

poll.VoteTo(1);
poll.VoteTo(3);
poll.VoteTo(3);
poll.VoteTo(2);
poll.VoteTo(7);


var result = builder.GetResults(poll);

Console.WriteLine(result.GetView());


