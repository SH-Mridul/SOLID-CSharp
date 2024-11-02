namespace DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Mridul";
            owner.LastName = "Hossain";
            owner.PhoneNumber = "0190000000000";
            owner.EmailAddress = "mridul@gmail.com";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformWorked(3);
            chore.PerformWorked(1.5);
            chore.CompletedChore();
            Console.ReadKey();
        }
    }
}
