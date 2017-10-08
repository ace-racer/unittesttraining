using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingTraining.BusinessLogics;

namespace UnitTestingTraining.Tests
{
    [TestClass]    
    public class StudentOperationsUnitTests
    {
        [TestMethod]
        public void GetCurrentPercentScoreOfStudent_ReturnsCorrectPercentScoreForDifferentScoresAndMaximumMarks()
        {
            var studentOperationsContainer = new StudentOperationsContainer();
            var percentScored = studentOperationsContainer.GetCurrentPercentScoreOfStudent("100");
            
            // I do not know what is the data in the Data store, what do I assert??
        }
    }
}
