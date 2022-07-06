namespace CoVariance;

public abstract class Mood
{
    public Mood(int level)
    {
        Level = level;
    }
    public int Level { get; }
    public abstract string Express { get; }
    public string Emote() => $"I Feel {(Level > 10 ? "So " : "")} {Express} Today";
}

public class Happy : Mood
{
    public Happy(int level) : base(level) { }
    public override string Express => "Light and Airy";
    public string Exult(int times) =>
        new List<int>(times).Aggregate(Express, (exprs, _) => exprs += $" {Express}");
}

public class Sad : Mood
{
    public Sad(int level) : base(level) { }
    public override string Express => "WAA WAA";
    public string Complaints(params string[] problems) =>
        $"I feel {Express} because {string.Join(" and because", problems)}";
}