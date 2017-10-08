using DataStoreOperations;
using DataStoreOperations.Factories;
using System;
using UnitTestingTraining.BusinessLogics;
using UnitTestingTraining.DataStoreOperations;

namespace SimpleDotNetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             NOTE:
             This method will throw exception as the methods in the data layer are not implemented.
             Please implement them by performing the required operations on Azure table storage.             
             */


            // Get the Data layer implementation details from the factory (without knowing how they are initialized)
            var studentOpertionsInDataSourceContainer = StudentOperationsInDataSourceFactory.GetInstance(UnitTestingTraining.Models.TechnicalDetails.DataSources.AzureTableStorage);
            var generalOperationsInDataSourceContainer = GeneralOperationsInDataSourceFactory.GetInstance(UnitTestingTraining.Models.TechnicalDetails.DataSources.AzureTableStorage);

            // Inject the dependencies to the Business Layer
            var studentOperationsContainer = new StudentOperationsContainer(generalOperationsInDataSourceContainer, studentOpertionsInDataSourceContainer);

            // Execute the business layer methods
            var studentPercent = studentOperationsContainer.GetCurrentPercentScoreOfStudent("1");

            Console.WriteLine(studentPercent + "%");
            Console.ReadKey();
        }
    }
}
