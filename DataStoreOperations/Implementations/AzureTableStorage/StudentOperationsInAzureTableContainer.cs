using DataStoreOperations.Interfaces;
using System;
using System.Collections.Generic;
using UnitTestingTraining.Models;

namespace UnitTestingTraining.DataStoreOperations
{
    /// <summary>
    /// Refer here for details: https://docs.microsoft.com/en-us/azure/cosmos-db/table-storage-how-to-use-dotnet
    /// </summary>
    /// <seealso cref="DataStoreOperations.Interfaces.IStudentOperationsInDataSource" />
    public class StudentOperationsInAzureTableContainer : IStudentOperationsInDataSource
    {
        public List<StudentDetails>  GetStudentDetailsByClassDetailsId(string classDetailsId)
        {
            // get students with current class details Id as the value provided
            // TODO: Get the details from Azure table storage
            throw new NotImplementedException();
        }

        public List<StudentSubjectMapping> GetStudentSubjectMappingDetailsForStudentByStudentId(string studentId)
        {
            // TODO: Get the details from Azure table storage
            throw new NotImplementedException();
        }
    }
}
