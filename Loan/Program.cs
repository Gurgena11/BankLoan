using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankLoan bankloan = new BankLoan();
            bankloan.loan();
            Console.WriteLine($"days overdue penalty + :{bankloan.Daysoverdue(3)}");
        }
    }
}
