using Lb1_Boyarinova_Bychkova_23VP1;
using System.Xml.Linq;
using System;
using System.Reflection;

namespace Lb1_Boyarinova_Bychkova_23VP1.Test
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void DefaultConstructor_Initialization_InitializesFieldsCorrectly()
        {
            // Arrange & Act
            var person = new Person();

            // Assert
            Assert.AreEqual("Иван", person.name);
            Assert.AreEqual("Иванов", person.surname);
            Assert.AreEqual("мужской", person.Gender);
            Assert.AreEqual(2000, person.Year_of_birth);
            Assert.AreEqual("Москва", person.City);
            Assert.AreEqual("Россия", person.Country);
            Assert.AreEqual(180.5, person.Height);
        }

        [DataTestMethod]
        [DataRow("Николай")]
        [DataRow("Olga")]
        public void NameConstructor_CorrectInitialization_InitializesFieldsCorrectly(string _name)
        {
            var person = new Person(_name);

            // Assert
            Assert.AreEqual(_name, person.name);
            Assert.AreEqual("Иванов", person.surname);
            Assert.AreEqual("мужской", person.Gender);
            Assert.AreEqual(2000, person.Year_of_birth);
            Assert.AreEqual("Москва", person.City);
            Assert.AreEqual("Россия", person.Country);
            Assert.AreEqual(180.5, person.Height);
        }

        [DataTestMethod]
        [DataRow("Pостов-")]
        [DataRow("235")]
        [ExpectedException(typeof(PersonArgumentExeption))]
        public void NameConstructor_IncorrectInitialization_ThrowPersonArgumentExeption(string _name)
        {
            new Person(_name);
        }

        [DataTestMethod]
        [DataRow("Николай", "Петров")]
        [DataRow("Olga", "Vi")]
        public void NameAndSurnameConstructor_CorrectInitialization_InitializesFieldsCorrectly(string _name, string _surname)
        {
            var person = new Person(_name, _surname);

            // Assert
            Assert.AreEqual(_name, person.name);
            Assert.AreEqual(_surname, person.surname);
            Assert.AreEqual("мужской", person.Gender);
            Assert.AreEqual(2000, person.Year_of_birth);
            Assert.AreEqual("Москва", person.City);
            Assert.AreEqual("Россия", person.Country);
            Assert.AreEqual(180.5, person.Height);
        }

        [DataTestMethod]
        [DataRow("ни8колай", "Correct")]
        [DataRow("Correct", "o8lga")]
        [ExpectedException(typeof(PersonArgumentExeption))]
        public void NameAndSuranmeConstructor_IncorrectInitialization_ThrowPersonArgumentExeption(string _name, string _surname)
        {
            new Person(_name, _surname);
        }

        [DataTestMethod]
        [DataRow("Николай", "Петров", "мужской", "2007", "Пенза", "Россия", "170,6")]
        [DataRow("Olga", "Vi", "женский", "1986", "London", "UK", "145")]
        public void FullConstructor_CorrectInitialization_InitializesFieldsCorrectly(string _name, string _surname, string _gender,
            string _year_of_birth, string _city, string _country, string _height)
        {
            var person = new Person(_name, _surname, _gender, _year_of_birth, _city, _country, _height);

            // Assert
            Assert.AreEqual(_name, person.name);
            Assert.AreEqual(_surname, person.surname);
            Assert.AreEqual(_gender, person.Gender);
            Assert.AreEqual(_year_of_birth, person.Year_of_birth.ToString());
            Assert.AreEqual(_city, person.City);
            Assert.AreEqual(_country, person.Country);
            Assert.AreEqual(_height, person.Height.ToString());
        }

        [DataTestMethod]
        [DataRow("yико9лай", "Петров", "мужской", "2007", "Пенза", "Россия", "170,6")]
        [DataRow("Николай", "Петров86", "мужской", "2007", "Пенза", "Россия", "170,6")]
        [DataRow("Николай", "Петров", "мужской", "45", "Пенза", "Россия", "170,6")]
        [DataRow("Николай", "Петров", "мужской", "2007", "Пен6за", "Россия", "170,6")]
        [DataRow("Николай", "Петров", "мужской", "2007", "Пенза", "Росс23ия", "170,6")]
        [DataRow("Николай", "Петров", "мужской", "2007", "Пенза", "Россия", "7")]
        [ExpectedException(typeof(PersonArgumentExeption))]
        public void FullConstructor_IncorrectInitialization_ThrowPersonArgumentExeption(string _name, string _surname, string _gender,
            string _year_of_birth, string _city, string _country, string _height)
        {
            new Person(_name, _surname, _gender, _year_of_birth, _city, _country, _height);
        }

        [DataTestMethod]
        [DataRow("145")]
        [DataRow("168,7")]
        [DataRow("46")]
        [DataRow("249")]
        public void IsRightHeight_StringCheck_ReturnTrue(string number)
        {
            Assert.IsTrue(Person.IsRightHeight(number));
        }

        [DataTestMethod]
        [DataRow("cgj")]
        [DataRow("168.7")]
        [DataRow("45")]
        [DataRow("250")]
        [DataRow("")]
        public void IsRightHeight_StringCheck_ReturnFalse(string str)
        {
            Assert.IsFalse(Person.IsRightHeight(str));
        }

        [DataTestMethod]
        [DataRow("Николай")]
        [DataRow("Olga")]
        [DataRow("Ростов-на-Дону")]
        [DataRow("S-example")]
        [DataRow("Пример'пример")]
        [DataRow("Ex'exaple")]
        [DataRow("Exпример")]
        [DataRow("николай")]
        [DataRow("olga")]

        public void IsRightName_StringCheck_ReturnTrue(string str)
        {
            Assert.AreEqual(true, Person.IsRightName(str));
        }

        [DataTestMethod]
        [DataRow("Pостов-")]
        [DataRow("235")]
        [DataRow("235fd")]
        [DataRow("dsdf235")]
        [DataRow("dd235dd")]
        [DataRow("'пример")]
        [DataRow("Ex'")]
        [DataRow("")]
        public void IsRightName_StringCheck_ReturnFalse(string str)
        {
            Assert.IsFalse(Person.IsRightName(str));
        }

        [DataTestMethod]
        [DataRow("1900")]
        [DataRow("2025")]
        [DataRow("1948")]
        [DataRow("2005")]
        public void IsRightYear_StringCheck_ReturnTrue(string year)
        {
            Assert.IsTrue(Person.IsRightYear(year));
        }

        [DataTestMethod]
        [DataRow("1800")]
        [DataRow("3004")]
        [DataRow("2004,6")]
        [DataRow("1975.22")]
        [DataRow("gsdgd13313")]
        public void IsRightYear_StringCheck_ReturnFalse(string year)
        {
            Assert.IsFalse(Person.IsRightYear(year));
        }

        //проблема с проверкой из-за того, что создание всех объектов в тестах считается и тесты не выполняются по порядку (переполнение
        //наступает раньше времени и не в тех тестах)

        [TestInitialize]
        public void TestInitialize()
        {
            // Сброс счетчика перед каждым тестом
            typeof(Person).GetProperty("Persons_count", BindingFlags.Static | BindingFlags.Public).SetValue(null, (byte)0);
        }

        [TestMethod]
        [ExpectedException(typeof(MyOverflowException))]
        public void DefaultConstructor_OverflowOfPeople_ThrowMyOverflowException()
        {
            for (int i = 0; i <= Byte.MaxValue + 1; i++)
            {
                new Person();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(MyOverflowException))]
        public void NameConstructor_OverflowOfPeople_ThrowMyOverflowException()
        {
            for (int i = 0; i <= Byte.MaxValue + 1; i++)
            {
                new Person("Example");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(MyOverflowException))]
        public void NameAndSurnameConstructor_OverflowOfPeople_ThrowMyOverflowException()
        {
            for (int i = 0; i <= Byte.MaxValue + 1; i++)
            {
                new Person("One", "Two");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(MyOverflowException))]
        public void FullConstructor_OverflowOfPeople_ThrowMyOverflowException()
        {
            for (int i = 0; i <= Byte.MaxValue + 1; i++)
            {
                new Person("Николай", "Петров", "мужской", "2007", "Пенза", "Россия", "170,6");
            }
        }
    }
}