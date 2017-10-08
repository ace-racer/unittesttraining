using DataStoreOperations.Interfaces;
using System;
using UnitTestingTraining.Models;

namespace DataStoreOperations
{
    /// <summary>
    /// Refer here for details: https://docs.microsoft.com/en-us/azure/cosmos-db/table-storage-how-to-use-dotnet
    /// </summary>
    /// <seealso cref="DataStoreOperations.Interfaces.IStudentOperationsInDataSource" />
    public class GeneralOperationsInAzureTableContainer : IGeneralOperationsInDataSource
    {
        public StudentClassDetails GetStudentClassDetailsFromStandardAndSection(int standard, char section)
        {
            // TODO: Get the details from Azure table storage
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the subject details by subject identifier.
        /// </summary>
        /// <param name="subjectId">The subject identifier.</param>
        /// <returns>The student subject details</returns>
        public StudentSubject GetSubjectDetailsBySubjectId(string subjectId)
        {
            // TODO: Get the details from Azure table storage
            throw new NotImplementedException();
        }
    }
}
