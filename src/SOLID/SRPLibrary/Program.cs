namespace SRPLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StandardMessages.WelcomeMessage();

            //ask for information
            Person user = PersonDataCapture.Capture();


            //check to valid name
            bool isUserValid = PersonValidator.Validate(user);
            if (!isUserValid) 
            {
                StandardMessages.EndApplication();
            }

            //create username for the person
            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();

        }
    }
}
