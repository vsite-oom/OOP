using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID;

public class SingleResponsibilityPrinciple
{
    public class BadReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Report generated.");
        }
        public void SaveToPdf()
        {
            Console.WriteLine("Report saved to PDF.");
        }
        public void SendEmail()
        {
            Console.WriteLine("Report sent via email.");
        }
    }

    public class Report
    {
        public void GenerateReport()
        {
            Console.WriteLine("Report generated.");
        }
    }

    public class Pdf
    {
        public void SaveToPdf()
        {
            Console.WriteLine("Report saved to PDF.");
        }
    }

    public class EmailService
    {
        public void SendEmail()
        {
            Console.WriteLine("Report sent via email.");
        }
    }
}
