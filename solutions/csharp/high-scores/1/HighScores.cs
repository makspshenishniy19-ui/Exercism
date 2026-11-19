using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> _scores;

    public HighScores(List<int> list)
    {
        _scores = new List<int>(list ?? throw new ArgumentNullException(nameof(list)));
    }

    public List<int> Scores()
    {
        return new List<int>(_scores);
    }

    public int Latest()
    {
        if (_scores.Count == 0)
            throw new InvalidOperationException("No scores available.");

        return _scores[^1];
    }

    public int PersonalBest()
    {
        if (_scores.Count == 0)
            throw new InvalidOperationException("No scores available.");

        return _scores.Max();
    }

    public List<int> PersonalTopThree()
    {
        return _scores
            .OrderByDescending(score => score)
            .Take(3)
            .ToList();
    }
}