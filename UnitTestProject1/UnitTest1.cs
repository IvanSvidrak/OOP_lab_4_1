using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            OOP_lab_4_1.Student student = new OOP_lab_4_1.Student();
            int Rating = 70;
            int result = student.StudentRating(Rating);
            Assert.AreEqual(3,result);
        }
    }

}
