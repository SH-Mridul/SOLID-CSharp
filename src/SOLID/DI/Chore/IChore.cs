namespace DI
{
    public interface IChore
    {
        string ChoreName { get; set; }
        double HoursWorked { get; }
        bool IsCompleted { get; }
        IPerson Owner { get; set; }

        void CompletedChore();
        void PerformWorked(double hours);
    }
}