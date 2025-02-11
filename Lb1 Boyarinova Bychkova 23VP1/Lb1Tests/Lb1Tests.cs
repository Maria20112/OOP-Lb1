/*using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lb1_Boyarinova_Bychkova_23VP1;

namespace Lb1Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void setHeightTest()
        {
            Person person = new Person("Maria", "B", "�������", 2006, "�����", "������", 170.5);

            double new_height = 175.0;
            person.setHeight(new_height);
            Assert.AreEqual(new_height, person.getHeight());
        }
    }
}*/

using Lb1_Boyarinova_Bychkova_23VP1;

namespace Lb1_Boyarinova_Bychkova_23VP1
{
    //[TestClass]
    //public sealed class PersonTests
   // {
        [TestClass]
        public class PersonTests
        {
            [TestMethod]
            public void DefaultConstructor_InitializesFieldsCorrectly()
            {
                // Arrange & Act
                var person = new Person();

                // Assert
                Assert.AreEqual("����", person.name);
                Assert.AreEqual("������", person.surname);
                Assert.AreEqual("�������", person.getGender());
                Assert.AreEqual(2000, person.getYear_of_birth());
                Assert.AreEqual("������", person.getCity());
                Assert.AreEqual("������", person.getCountry());
                Assert.AreEqual(180.5, person.getHeight());
            }

            [DataTestMethod]
            //[DataRow("����,���", "������", "�������", 1990, "�����-���������",
              //      "������", 175.38)]
            [DataRow("�������", "������", "�������", 1990, "�����-���������",
                    "������", 175.38)]
            //[DataRow(0, 0, 0)]
            public void ParameterizedConstructor_CreationWithInvalidParameters(string name, string surname,
                string gender, int year, string city, string country, double hight)
            {
                // Arrange & Act
                var person = new Person("�������", "������", "�������", 1990, "�����-���������",
                    "������", 175.38);

                // Assert
                Assert.AreEqual("�������", person.name);
                Assert.AreEqual("������", person.surname);
                Assert.AreEqual("�������", person.getGender());
                Assert.AreEqual(1990, person.getYear_of_birth());
                Assert.AreEqual("�����-���������", person.getCity());
                Assert.AreEqual("������", person.getCountry());
                Assert.AreEqual(175.0, person.getHeight());
            }
        }
    //}
}