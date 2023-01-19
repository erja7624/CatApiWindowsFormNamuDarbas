using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatAPI;
using ApiClient;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CatModel cat1 = new CatModel();
            cat1.child_friendly = 4;
            CatModel cat2 = new CatModel();
            cat2.child_friendly = 2;
            CatModel cat3 = new CatModel();
            cat3.child_friendly = 5;
            int expectedCount = 2;
            List<CatModel> testList = new List<CatModel>();
            testList.Add(cat1);
            testList.Add(cat2);
            testList.Add(cat3);

            List<CatModel> checkList = new List<CatModel>();
            checkList = Helpers.FilteringByQuality(testList, "child_friendly");
            Assert.AreEqual(expectedCount, checkList.Count);
        }

        [TestMethod]
        public void TestMethod2()
        {
            CatModel cat1 = new CatModel();
            cat1.name = "TestName Test";

            int expectedCount = 2;
            List<CatModel> testList = new List<CatModel>();
            testList.Add(cat1);

            List<CatModel> checkList = new List<CatModel>();
            checkList = Helpers.MakeUpperCase(testList);
            foreach (var item in checkList)
            {
                Assert.AreEqual("TESTNAME TEST", item.name);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            CatModel cat1 = new CatModel();
            CatModel cat2 = new CatModel();
            CatModel cat3 = new CatModel();

            int expectedCount = 0;
            List<CatModel> testList = new List<CatModel>();
            testList.Add(cat1);
            testList.Add(cat2);
            testList.Add(cat3);

            List<CatModel> checkList = new List<CatModel>();
            checkList = Helpers.BackUpCats(testList);
            Assert.AreNotEqual(expectedCount, checkList.Count);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int expectedCount = 2;
            string jsonString = "[{\"weight\":{\"imperial\":\"7  -  10\",\"metric\":\"3 - 5\"},\"id\":\"abys\",\"name\":\"Abyssinian\",\"cfa_url\":\"\",\"vetstreet_url\":\"\",\"vcahospitals_url\":\"\",\"temperament\":\"Active, Energetic, Independent, Intelligent, Gentle\",\"origin\":\"Egypt\",\"country_codes\":\"EG\",\"country_code\":\"EG\",\"description\":\"The Abyssinian\",\"life_span\":\"14 - 15\",\"indoor\":0,\"lap\":1,\"alt_names\":\"\",\"adaptability\":5,\"affection_level\":5,\"child_friendly\":3,\"dog_friendly\":4,\"energy_level\":5,\"grooming\":1,\"health_issues\":2,\"intelligence\":5,\"shedding_level\":2,\"social_needs\":5,\"stranger_friendly\":5,\"vocalisation\":1,\"experimental\":0,\"hairless\":0,\"natural\":1,\"rare\":0,\"rex\":0,\"suppressed_tail\":0,\"short_legs\":0,\"wikipedia_url\":\"\",\"hypoallergenic\":0,\"reference_image_id\":\"0XYvRd7oD\"},{\"weight\":{\"imperial\":\"7 - 10\",\"metric\":\"3 - 5\"},\"id\":\"aege\",\"name\":\"Aegean\",\"vetstreet_url\":\"\",\"temperament\":\"Affectionate, Social, Intelligent, Playful, Active\",\"origin\":\"Greece\",\"country_codes\":\"GR\",\"country_code\":\"GR\",\"description\":\"Native to\",\"life_span\":\"9 - 12\",\"indoor\":0,\"alt_names\":\"\",\"adaptability\":5,\"affection_level\":4,\"child_friendly\":4,\"dog_friendly\":4,\"energy_level\":3,\"grooming\":3,\"health_issues\":1,\"intelligence\":3,\"shedding_level\":3,\"social_needs\":4,\"stranger_friendly\":4,\"vocalisation\":3,\"experimental\":0,\"hairless\":0,\"natural\":0,\"rare\":0,\"rex\":0,\"suppressed_tail\":0,\"short_legs\":0,\"wikipedia_url\":\"\",\"hypoallergenic\":0,\"reference_image_id\":\"ozEvzdVM-\"}]";
            List<CatModel> testList = ApiHelper.GetCats(jsonString);
            Assert.AreEqual(expectedCount, testList.Count);
        }
    }
}