using System;
using DataStoreOperations.Interfaces;
using UnitTestingTraining.DataStoreOperations;
using UnitTestingTraining.Models.TechnicalDetails;

namespace DataStoreOperations.Factories
{
    public static class StudentOperationsInDataSourceFactory
    {
        public static IStudentOperationsInDataSource GetInstance(DataSources dataSource)
        {
            switch (dataSource)
            {
                case DataSources.AzureTableStorage: return new StudentOperationsInAzureTableContainer();
                case DataSources.AzureSqlDatabase:
                default:
                    return null;
            }
        }     
    }
}
