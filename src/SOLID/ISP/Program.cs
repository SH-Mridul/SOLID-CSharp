using ISP;

namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------note for empty interface-----------
            //combine all interface in one or make a empty inaterface
            //wih implement couple of interface for access all
            //things at a time
            //or you can saparate to 

            IBorrowableDVD dvd = new DVD();
        }
    }
}
