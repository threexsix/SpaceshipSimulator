using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;

public class Route
{
    private readonly List<Segment> _segments;

    public Route()
    {
        _segments = new List<Segment>();
    }

    public IReadOnlyCollection<Segment> Segments => _segments;

    public void AddSegment(Segment segment)
    {
        if (segment != null)
            _segments.Add(segment);
    }

    public void AddSegments(IReadOnlyCollection<Segment> segments)
    {
        if (segments != null)
        {
            foreach (Segment segment in segments)
            {
                AddSegment(segment);
            }
        }
    }
}