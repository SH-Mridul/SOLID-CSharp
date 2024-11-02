using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI;
using DI;

namespace DI
{
    public class Chore(ILogger logger, IMessageSender messageSender) : IChore
    {

        ILogger _logger = logger;
        IMessageSender _messageSender = messageSender;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsCompleted { get; private set; }

        public void PerformWorked(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");

        }

        public void CompletedChore()
        {
            IsCompleted = true;
            _logger.Log($"Completed {ChoreName}");
            _messageSender.SendMessage(Owner, $"The chore {ChoreName} is completed.");
        }
    }
}
