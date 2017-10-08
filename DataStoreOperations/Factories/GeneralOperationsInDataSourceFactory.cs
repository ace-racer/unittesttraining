using DataStoreOperations.Interfaces;
using UnitTestingTraining.Models.TechnicalDetails;

namespace DataStoreOperations.Factories
{
    public static class GeneralOperationsInDataSourceFactory
    {        
        public static IGeneralOperationsInDataSource GetInstance(DataSources dataSource)
        {            
            switch(dataSource)
            {
                case DataSources.AzureTableStorage: return new GeneralOperationsInAzureTableContainer();                    
                case DataSources.AzureSqlDatabase:
                default: 
                    return null;
            }            
        }
    }
}
