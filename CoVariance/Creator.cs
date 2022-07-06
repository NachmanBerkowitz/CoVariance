namespace CoVariance;

public interface ICreator<T> where T : Mood
{
    T CreateMood(int creatorPower);
}

public class Wine : ICreator<Happy>
{
    public Happy CreateMood(int powerCreator)
    {
        return new Happy(powerCreator * 5);
    }
}

public class BadNews : ICreator<Sad>
{
    public Sad CreateMood(int creatorPower)
    {
        return new Sad(creatorPower * 2);
    }
}