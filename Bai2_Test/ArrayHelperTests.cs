using Lab8_Bai2_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bai2_Test
{
    [TestClass]
    public sealed class ArrayHelperTests
    {
        [TestMethod]
        public void Test_FindMax_Returns_CorrectValue()
        {
            int[] arr = { 1, 5, 9, 3 };
            int result = ArrayHelper.FindMax(arr);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Test_FindMin_Returns_CorrectValue()
        {
            int[] arr = { 1, 5, 9, 3 };
            int result = ArrayHelper.FindMin(arr);
            Assert.AreEqual(1, result);
        }
    }
}
