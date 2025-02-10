using Lb1_Boyarinova_Bychkova_23VP1;

namespace Lb1_Boyarinova_Bychkova_23VP1
{
    [TestClass]
    public sealed class PersonTests
    {
        [TestClass]
        public class PersonTests
        {
            [TestMethod]
            public void DefaultConstructor_InitializesFieldsCorrectly()
            {
                // Arrange & Act
                var person = new Person();

                // Assert
                Assert.AreEqual("Иван", person.name);
                Assert.AreEqual("Иванов", person.surname);
                Assert.AreEqual("мужской", person.getGender());
                Assert.AreEqual(2000, person.getYear_of_birth());
                Assert.AreEqual("Москва", person.getCity());
                Assert.AreEqual("Россия", person.getCountry());
                Assert.AreEqual(180.5, person.getHeight());
            }

            [DataTestMethod]
            [DataRow("Алек,сей", "Петров", "мужской", 1990, "Санкт-Петербург",
                    "Россия", 175.38)]
            [DataRow("Алексей", "Петров", "мужской", 1990, "Санкт-Петербург",
                    "Россия", 175.38)]
            [DataRow(0, 0, 0)]
            public void ParameterizedConstructor_CreationWithInvalidParameters(string name, string surname,
                string gender, int year, string city, string country, double hight)
            {
                // Arrange & Act
                var person = new Person("Алексей", "Петров", "мужской", 1990, "Санкт-Петербург",
                    "Россия", 175.38);

                // Assert
                Assert.AreEqual("Алексей", person.name);
                Assert.AreEqual("Петров", person.surname);
                Assert.AreEqual("мужской", person.getGender());
                Assert.AreEqual(1990, person.getYear_of_birth());
                Assert.AreEqual("Санкт-Петербург", person.getCity());
                Assert.AreEqual("Россия", person.getCountry());
                Assert.AreEqual(175.0, person.getHeight());
            }
        }
    }
}
