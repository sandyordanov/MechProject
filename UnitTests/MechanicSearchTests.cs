using Classes;
using LogicLibrary;

namespace UnitTests
{
    [TestClass]
    public class MechanicSearchTests
    {
        [TestMethod]
        public void ScrapeRequest_ReturnsCorrectList()
        {
            // Arrange
            string make = "Car";
            string description = "This is a car description. It has four wheels.";

            // Act
            List<string> result = RequestShakedown.ScrapeRequest(make, description);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.Count);
            CollectionAssert.Contains(result, "this");
            CollectionAssert.Contains(result, "is");
            CollectionAssert.Contains(result, "a");
            CollectionAssert.Contains(result, "car");
            CollectionAssert.Contains(result, "description");
            CollectionAssert.Contains(result, "it");
            CollectionAssert.Contains(result, "Car");
        }
        [TestMethod]
        public void SearchForAMatch_NoMatches_ReturnsEmptyDictionary()
        {
            // Arrange
            var mechanics = new List<Mechanic>
        {
            new Mechanic { Skills = new List<string> { "Skill1", "Skill2", "Skill3" } },
            new Mechanic { Skills = new List<string> { "Skill4", "Skill5", "Skill6" } },
        };

            var keyWords = new List<string> { "Keyword1", "Keyword2", "Keyword3" };

            // Act
            var result = RequestShakedown.SearchForAMatch(mechanics, keyWords);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void SearchForAMatch_SingleMatch_ReturnsDictionaryWithOneEntry()
        {
            // Arrange
            var mechanics = new List<Mechanic>
        {
            new Mechanic { Skills = new List<string> { "Skill1", "Skill2", "Skill3" } },
            new Mechanic { Skills = new List<string> { "Skill4", "Skill5", "Skill6" } },
        };

            var keyWords = new List<string> { "Skill2" };

            // Act
            var result = RequestShakedown.SearchForAMatch(mechanics, keyWords);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);

            var mechanic = result.Keys.First();
            Assert.AreEqual("Skill2", result[mechanic][0]);
        }

        [TestMethod]
        public void SearchForAMatch_MultipleMatches_ReturnsDictionaryWithMultipleEntries()
        {
            // Arrange
            var mechanics = new List<Mechanic>
        {
            new Mechanic { Skills = new List<string> { "Skill1", "Skill2", "Skill3" } },
            new Mechanic { Skills = new List<string> { "Skill2", "Skill5", "Skill6" } },
            new Mechanic { Skills = new List<string> { "Skill3", "Skill4", "Skill6" } },
        };

            var keyWords = new List<string> { "Skill2", "Skill6" };

            // Act
            var result = RequestShakedown.SearchForAMatch(mechanics, keyWords);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);

            var mechanic1 = mechanics[0];
            Assert.AreEqual(1, result[mechanic1].Count);
            Assert.AreEqual("Skill2", result[mechanic1][0]);

            var mechanic2 = mechanics[1];
            Assert.AreEqual(1, result[mechanic2].Count);
            Assert.AreEqual("Skill2", result[mechanic2][0]);
        }
    }
}