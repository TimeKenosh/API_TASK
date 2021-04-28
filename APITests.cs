using ConsoleApp1;
using NUnit.Framework;
using APITask;

namespace APITests
{
    public class Tests
    {
        [Test]
        public void VerifyGETMethod()
        {
            InfoDTO actualResult = MethodGET.MethodGet();
            int expectedUserId = 2;
            int expectedId = 20;
            string expectedTitle = "doloribus ad provident suscipit at";
            string expectedBody = "qui consequuntur ducimus possimus quisquam amet similique\nsuscipit porro ipsam amet\neos veritatis officiis exercitationem vel fugit aut necessitatibus totam\nomnis rerum consequatur expedita quidem cumque explicabo";
            InfoDTO expectedResult = new InfoDTO(expectedUserId, expectedId, expectedTitle, expectedBody);
            Assert.AreEqual(actualResult, expectedResult, $"Verifying that {expectedResult} object is equal to the {actualResult}");
        }

        [Test]
        public void VerifyPOSTMethod()
        {
            InfoDTO actualResult = MethodPOST.MethodPost();
            int expectedUserId = 42;
            int expectedId = 101;
            string expectedTitle = "Latine";
            string expectedBody = "Amat victoria curam";
            InfoDTO expectedResult = new InfoDTO(expectedUserId, expectedId, expectedTitle, expectedBody);
            Assert.AreEqual(actualResult, expectedResult, $"Verifying that {expectedResult} object is equal to the {actualResult}");
        }

        [Test]
        public void VerifyPUTMethod()
        {
            InfoDTO actualResult = MethodPUT.MethodPut();
            int expectedUserId = 51;
            int expectedId = actualResult.GetId();
            string expectedTitle = "Latine";
            string expectedBody = "Omnia transeunt";
            InfoDTO expectedResult = new InfoDTO(expectedUserId, expectedId, expectedTitle, expectedBody);
            Assert.AreEqual(actualResult, expectedResult, $"Verifying that {expectedResult} object is equal to the {actualResult}");

        }

        [Test]
        public void VerifyDELETEMethod()
        {
            string actualResult = MethodDELETE.MethodDelete();
            string expectedResult = "{}";
            Assert.AreEqual(actualResult, expectedResult, $"Verifying that MethodDelete works");
        }
    }
}