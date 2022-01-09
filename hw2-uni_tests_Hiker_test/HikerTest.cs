using hw2_uni_tests_Hiker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 

namespace hw2_uni_tests_Hiker_test
{
    //Given a list of integers find the closest to zero.
    //If there is a tie, choose the positive value.
    
        [TestClass]
    public class HikerTest
    {
        [TestMethod]
        public void ClosestToZero_CheckInCaseThatNullSended_TheListIsNull()
        {
            // check null value
            Assert.AreEqual("The list is null", Hiker.ClosestToZero(null));

        }

        [TestMethod]
        public void ClosestToZero_CheckCaseThatTheArraySizeIsOne_ReturnTheOneValueThatInTheArray()
        {
            // check case that the array with one size
            Assert.AreEqual(5, Hiker.ClosestToZero(new int[] { 5 }));
        }

        [DataRow(new int[]{-3,5,7,-10,3,4 },3)]
        [DataRow(new int[] { 1, 5, 7, -1, 3, 4 }, 1)]
        [DataRow(new int[] { 3, 5, 1, -1, 3, 4 }, 1)]
        [DataRow(new int[] { 3, 5, 6, -1, 3, 4 }, -1)]

        [DataTestMethod]
        public void ClosestToZero_DisanceIsEqualAndTheCurrentNumberBiggerThenTheClosestNumber_TheBiggerNumberIsTheResult(int[] list,int result)
        {
            // check case that Disance Is Equal And The Current Number Bigger Then The Closest Number
            Assert.AreEqual(result, Hiker.ClosestToZero(list));
        }

        [DataRow(new int[] { 5, 7, -1, 3, 4 }, -1)]
        [DataRow(new int[] { 3, 5, 1, 4 }, 1)]
        [DataRow(new int[] { 3, 5, 6, -1, 4 }, -1)]

        [DataTestMethod]
        public void ClosestToZero_CheckIfDistanceIsCloserToZeroWithNoDuplicated_TheSmallestDistanceShouldReturn(int[] list, int result)
        {
            // check case that Check If Distance IsCloser To Zero With No Duplicated
            Assert.AreEqual(result, Hiker.ClosestToZero(list));
        }
    }
}
