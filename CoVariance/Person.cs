#nullable disable
namespace CoVariance;
public interface IPerson<in T> where T : Mood
{
    //T GetMood();
    void SetMood(T mood);
}

public class Person<T>: IPerson<T> where T : Mood
{
    public T Mood { get; private set; }

    public T GetMood()
    {
        return Mood;
    }

    public double PayTherepist(TimeSpan timeSpan)
    {
        return timeSpan.TotalSeconds * 100.99;
    }

    public void SetMood(T mood)
    {
        if (mood.Level > 1000) throw new Exception();
        Mood = mood;
    }
}