#nullable disable
using CoVariance;

Console.WriteLine("Hello, World!");

Happy happy = new Happy(level: 1);
Therapist generalPractitioner = new Therapist();

Person<Happy> happyPerson = new Person<Happy>();
Person<Sad> sadPerson = new Person<Sad>();
Person<Mood> moodyPerson = new Person<Mood>();

generalPractitioner.LitsenToPatient(happyPerson);
generalPractitioner.LitsenToPatient(sadPerson);
sadPerson.Mood.Complaints("No Food");

var expr = moodyPerson.Mood.Express;
generalPractitioner.TalkToHappyPatient(moodyPerson);

//generalPractitioner.SpreadHappyMood(moodyPerson);
generalPractitioner.SpreadMood(happyPerson);


//ICreator<Happy> happyCreator = new Wine();
//ICreator<Sad> sadCreator = new BadNews();
//generalPractitioner.TestLevel(happyCreator);

//Person<Mood> moodyPerson = new Person<Mood>();
//generalPractitioner.TalkToHappyPatient(moodyPerson);