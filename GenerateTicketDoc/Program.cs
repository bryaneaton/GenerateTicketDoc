using System;
using System.Windows.Forms;

namespace GenerateTicketDoc
{
    class Program
    {
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TicketForm());
        }
    }
}
