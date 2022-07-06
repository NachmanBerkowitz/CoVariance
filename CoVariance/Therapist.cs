namespace CoVariance;

public class Therapist
{
    IPerson<Mood>? currentPatient;
    public void LitsenToPatient(IPerson<Mood> person)
    {
        currentPatient = person;
        person.SetMood(new Happy(20));
    }

    public void TalkToHappyPatient(IPerson<Happy> person)
    {
        person.SetMood(new Happy(20));
    }

    public string SpreadHappyMood(IPerson<Happy> person)
    {
        return "hi";
        //return person.GetMood().Exult(4); 
    }

    public string SpreadMood(IPerson<Mood> person)
    {
        return "hi";
        //return person.GetMood().Express;
    }

    public bool TestLevel(ICreator<Mood> creator)
    {
        return creator.CreateMood(10).Level < 40;
    }

    public bool PumpItUp(ICreator<Happy> creator)
    {
        return creator.CreateMood(10).Level < 40;
    }
}
//    person.SetMood(new Happy(20));

