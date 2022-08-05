using PowerfulSpace.PollingSystem.Entities;
using System;
using System.Collections.Generic;

public class PollBuilder
{
    private readonly List<Answer> _items = new List<Answer>();
    private readonly string _questionText;

    public PollBuilder(string questionText)
    {
        _questionText = questionText;
    }

    public PollBuilder AddAnswer(Guid id, string title)
    {
        _items.Add(new Answer(id, title));

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
