using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingTraining.BusinessLogics;

namespace SimpleDotNetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentOperationsContainer = new StudentOperationsContainer();
            var studentPercent = studentOperationsContainer.GetCurrentPercentScoreOfStudent("1");
            Console.WriteLine(studentPercent + "%");
            Console.ReadKey();
        }
    }
}
