using Classes;
using LogicLibrary;
namespace UnitTests
{
    [TestClass]
    public class SearchEngineTests
    {
        [TestMethod]
        public void SearchForRepairShops_NoMatches_ReturnsEmptyList()
        {
            // Arrange
            var search = "keyword";
            var servicePoints = new List<ServicePoint>
        {
            new ServicePoint { Name = "Shop1", Address = "Address1" },
            new ServicePoint { Name = "Shop2", Address = "Address2" },
        };

            // Act
            var result = SearchEngine.SearchForRepairShops(search, servicePoints);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void SearchForRepairShops_SingleMatch_ReturnsListWithOneShop()
        {
            // Arrange
            var search = "keyword";
            var servicePoints = new List<ServicePoint>
        {
            new ServicePoint { Name = "Shop1", Address = "Address1" },
            new ServicePoint { Name = "Keyword Shop", Address = "Address2" },
            new ServicePoint { Name = "Shop3", Address = "Address3" },
        };

            // Act
            var result = SearchEngine.SearchForRepairShops(search, servicePoints);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);

            var shop = result[0];
            Assert.AreEqual("Keyword Shop", shop.Name);
        }

        [TestMethod]
        public void SearchForRepairShops_MultipleMatches_ReturnsListWithMultipleShops()
        {
            // Arrange
            var search = "keyword";
            var servicePoints = new List<ServicePoint>
        {
            new ServicePoint { Name = "Shop1", Address = "Keyword Address" },
            new ServicePoint { Name = "Keyword Shop", Address = "Address2" },
            new ServicePoint { Name = "Shop3", Address = "Keyword Address" },
            new ServicePoint { Name = "Keyword Shop", Address = "Keyword Address" },
        };

            // Act
            var result = SearchEngine.SearchForRepairShops(search, servicePoints);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);

            var shop1 = result[0];
            Assert.AreEqual("Shop1", shop1.Name);

            var shop2 = result[1];
            Assert.AreEqual("Keyword Shop", shop2.Name);

            var shop3 = result[2];
            Assert.AreEqual("Shop3", shop3.Name);
        }

        [TestMethod]
        public void SearchForMechanics_NoMatches_ReturnsEmptyList()
        {
            // Arrange
            var search = "keyword";
            var mechanics = new List<Mechanic>
        {
            new Mechanic { FirstName = "John", LastName = "Doe" },
            new Mechanic { FirstName = "Jane", LastName = "Smith" },
        };

            // Act
            var result = SearchEngine.SearchForMechanics(search, mechanics);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void SearchForMechanics_SingleMatch_ReturnsListWithOneMechanic()
        {
            // Arrange
            var search = "keyword";
            var mechanics = new List<Mechanic>
        {
            new Mechanic { FirstName = "John", LastName = "Doe" },
            new Mechanic { FirstName = "Keyword", LastName = "Mechanic" },
            new Mechanic { FirstName = "Jane", LastName = "Smith" },
        };

            // Act
            var result = SearchEngine.SearchForMechanics(search, mechanics);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);

            var mechanic = result[0];
            Assert.AreEqual("Keyword", mechanic.FirstName);
            Assert.AreEqual("Mechanic", mechanic.LastName);
        }

        [TestMethod]
        public void SearchForMechanics_MultipleMatches_ReturnsListWithMultipleMechanics()
        {
            // Arrange
            var search = "keyword";
            var mechanics = new List<Mechanic>
        {
            new Mechanic { FirstName = "John", LastName = "Doe" },
            new Mechanic { FirstName = "Keyword", LastName = "Mechanic" },
            new Mechanic { FirstName = "Jane", LastName = "Smith" },
            new Mechanic { FirstName = "Keyword", LastName = "Smith" },
        };

            // Act
            var result = SearchEngine.SearchForMechanics(search, mechanics);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);

            var mechanic1 = result[0];
            Assert.AreEqual("Keyword", mechanic1.FirstName);
            Assert.AreEqual("Mechanic", mechanic1.LastName);

            var mechanic2 = result[1];
            Assert.AreEqual("Keyword", mechanic2.FirstName);
            Assert.AreEqual("Smith", mechanic2.LastName);
        }
    }
}