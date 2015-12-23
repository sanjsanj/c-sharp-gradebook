using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookName(book2);
            Assert.AreEqual(book1.Name, "A grade book");
        }

        private void GiveBookName(GradeBook book)
        {
            book.Name = "A grade book";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Bob";
            string name2 = "Bob";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "User's grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
