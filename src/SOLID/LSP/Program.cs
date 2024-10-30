namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVp = new Manager();
            accountingVp.FirstName = "Mridul";
            accountingVp.LastName = "Hossain";
            accountingVp.CalculatePerHourRate(4);

            IManaged emp = new Employee();
            emp.FirstName = "Sakib";
            emp.LastName = "Hasan";
            emp.AssignManager(accountingVp);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");
        }
    }
}
