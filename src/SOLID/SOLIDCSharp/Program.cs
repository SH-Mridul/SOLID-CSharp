using OCPLibrary;

namespace SOLIDCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>()
           {
               new PersonModel {FirstName = "Mridul", LastName = "Hossain"},
               new ManagerModel {FirstName = "Nazim", LastName = "Uddin"},
               new ExecutiveModel {FirstName = "Zakaria", LastName = "Bijoy"}
           };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }


            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} : {emp.EmailAddress} isManager:{emp.IsManager} isExecutive:{emp.IsExecutive}");
            }


            Console.ReadKey();
        }
    }
}
