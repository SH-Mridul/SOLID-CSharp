using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Manager: Employee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;
            Salary = baseAmount + (rank * 2);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("i'm reviewing a direct report's performance");
        }
    }
}
