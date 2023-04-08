using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loan
{
    internal class BankLoan
    {
        public double Price { get; set; }
        public double Month { get; set; }

        public BankLoan()
        {

        }
       public BankLoan(double price, double month)
        {
            Price= price;
            Month= month;
        }
        public void loan()
        {
            Console.WriteLine("write price");
            Price = double.Parse(Console.ReadLine());

            Console.WriteLine("write for how many month");
            Month = double.Parse(Console.ReadLine());

            double intrestrateFor3month = 0.12;
            double intrestrateFor6month = 0.14;
            double intrestrateFor9month = 0.16;
            double intrestrateFor12month = 0.18;
            
            
               
                if (Month == 3)
                {
                Console.WriteLine("payment per month: ");
                    int total =(int)(Price / Month * (1 + intrestrateFor3month));
                    Console.WriteLine(total);
                }
                else if (Month == 6)
                {
                Console.WriteLine("payment per month: ");
                int total = (int)(Price / Month * (1 + intrestrateFor6month));
                    Console.WriteLine(total);
                }
                else if (Month== 9)
                {
                Console.WriteLine("payment per month: ");
                int total = (int)(Price / Month * (1 + intrestrateFor9month));
                    Console.WriteLine(total);
                }
                else if (Month == 12)
                {
                Console.WriteLine("payment per month: ");
                int total = (int)(Price / Month * (1 + intrestrateFor12month));
                    Console.WriteLine(total);

                }
                
            
            
        }
        public  double Daysoverdue(int daysoverdue)
        {
           return  Price * 0.01 * daysoverdue;
        }
    }
}
