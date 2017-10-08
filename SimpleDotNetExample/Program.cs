using DataStoreOperations;
using System;
using UnitTestingTraining.BusinessLogics;
using UnitTestingTraining.DataStoreOperations;

namespace SimpleDotNetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentOpertionsInDataSourceContainer = new StudentOperationsInAzureTableContainer();
            var generalOperationsInDataSourceContainer = new GeneralOperationsInAzureTableContainer();
            var studentOperationsContainer = new StudentOperationsContainer(generalOperationsInDataSourceContainer, studentOpertionsInDataSourceContainer);
            var studentPercent = studentOperationsContainer.GetCurrentPercentScoreOfStudent("1");
            Console.WriteLine(studentPercent + "%");
            Console.ReadKey();
        }
    }
}
