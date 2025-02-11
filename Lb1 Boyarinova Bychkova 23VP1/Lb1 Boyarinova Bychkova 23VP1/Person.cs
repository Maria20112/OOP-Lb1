using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Lb1_Boyarinova_Bychkova_23VP1
{
    /// <summary>
    /// Класс, описывающий предметную область Человек
    /// </summary>
    public class Person
    {
        private const double MIN_HEIGHT = 45.0d;
        private const double MAX_HEIGHT = 250.0d;
        private const int MAX_AGE = 125;
        /// <summary>
        /// Поле "Имя человека"
        /// </summary>
        public string name = "Иван";
        /// <summary>
        /// Поле "Фамилия человека"
        /// </summary>
        public string surname = "Иванов";
        /// <summary>
        /// Поле "Пол человека"
        /// </summary>
        private string gender = "мужской";
        /// <summary>
        /// Поле "Год рождения человека"
        /// </summary>
        private int year_of_birth = 2000;
        /// <summary>
        /// Поле "Город проживания человека"
        /// </summary>
        private string city = "Москва";
        /// <summary>
        /// Поле "Страна проживания человека"
        /// </summary>
        private string country = "Россия";
        /// <summary>
        /// Поле "Рост человека"
        /// </summary>
        private double height = 180.5d;
        /// <summary>
        /// Общее количество созданных объектов класса Person
        /// </summary>
        private static byte persons_count = 0;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Person()
        {
            try
            {
                checked
                {
                    persons_count++;
                }
            }
            catch (OverflowException ex)
            {
                throw new MyOverflowException("Создано слишком много людей", ex)
                {
                    TimeOfExeption = DateTime.Now
                };
            }
        }

        /// <summary>
        /// Конструктор с 2 параметрами
        /// </summary>
        /// <param name="_name">Имя</param>
        /// <param name="_surname">Фамилия</param>
        public Person(string _name, string _surname)
        {
            name = _name;
            surname = _surname;
            try
            {
                checked
                {
                    persons_count++;
                }
            }
            catch (OverflowException ex)
            {
                throw new MyOverflowException("Создано слишком много людей", ex)
                {
                    TimeOfExeption = DateTime.Now
                };
            }
        }

        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="_name">Имя</param>
        public Person(string _name)
        {
            name = _name;
            try
            {
                checked
                {
                    persons_count++;
                }
            }
            catch (OverflowException ex)
            {
                throw new MyOverflowException("Создано слишком много людей", ex)
                {
                    TimeOfExeption = DateTime.Now
                };
            }
        }

        /// <summary>
        /// Конструктор со всеми параметрами
        /// </summary>
        /// <param name="_name">Имя</param>
        /// <param name="_surname">Фамилия</param>
        /// <param name="_gender">Пол</param>
        /// <param name="_year_of_birth">Год рождения</param>
        /// <param name="_city">Город</param>
        /// <param name="_country">Страна</param>
        /// <param name="_height">Рост</param>
        public Person(string _name, string _surname, string _gender, int _year_of_birth, string _city,
            string _country, double _height)
        {
            name = _name;
            surname = _surname;
            gender = _gender;
            year_of_birth = _year_of_birth;
            city = _city;
            country = _country;
            height = _height;
            try
            {
                checked
                {
                    persons_count++;
                }
            }
            catch (OverflowException ex)
            {
                throw new MyOverflowException("Создано слишком много людей", ex)
                {
                    TimeOfExeption = DateTime.Now
                };
            }
        }
        public static Person createPerson()
        {
            return new Person();
        }

        public static Person createPerson(string inputName)
        {
            if (IsRightName(inputName))
            {
                return new Person(inputName);
            }
            return null; //Или исключение???
        }

        public static Person createPerson(string inputName, string inputSurname)
        {
            if (IsRightName(inputName) && IsRightName(inputSurname))
            {
                return new Person(inputName, inputSurname);
            }
            return null;
        }

        public static Person createPerson(string _name, string _surname, string _gender, string _year_of_birth,
            string _city, string _country, string _height)
        {
            if (!IsRightName(_name) || !IsRightName(_surname) || !IsRightYear(_year_of_birth) ||
                !IsRightName(_city) || !IsRightName(_country) || !IsRightHeight(_height))
            {
                return null;
            }
            return new Person(_name, _surname, _gender, Convert.ToInt32(_year_of_birth), _city,
            _country, Convert.ToDouble(_height));
        }

        /// <summary>
        /// Функция для получения значения поля "Пол"
        /// </summary>
        /// <returns>Пол</returns>
        public string getGender() { return gender; }
        /// <summary>
        /// Функция для получения значения поля "Год рождения"
        /// </summary>
        /// <returns>Год рождения</returns>
        public int getYear_of_birth() { return year_of_birth; }
        /// <summary>
        /// Функция для получения значения поля "Город"
        /// </summary>
        /// <returns>Город</returns>
        public string getCity() { return city; }
        /// <summary>
        /// Функция для получения значения поля "Страна"
        /// </summary>
        /// <returns>Страна</returns>
        public string getCountry() { return country; }
        /// <summary>
        /// Функция для получения значения поля "Рост"
        /// </summary>
        /// <returns>Рост</returns>
        public double getHeight() { return height; }
        /// <summary>
        /// Функция для получения общего кол-ва объектов
        /// </summary>
        /// <returns>Общее кол-во объектов</returns>
        public int getPersons_count() { return persons_count; }
        /// <summary>
        /// Функция для изменения значения поля "Пол"
        /// </summary>
        /// <param name="_gender">Новое значение поля "Пол"</param>
        public void setGender(string _gender) { gender = _gender; }
        /// <summary>
        /// Функция для изменения значения поля "Год рождения"
        /// </summary>
        /// <param name="_year_of_birth">Новый год рождения</param>
        public void setYear_of_birth(int _year_of_birth) { year_of_birth = _year_of_birth; }
        /// <summary>
        /// Функция для изменения значения поля "Город"
        /// </summary>
        /// <param name="_city">Новый город</param>
        public void setCity(string _city) { city = _city; }
        /// <summary>
        /// Функция для изменения значения поля "Страна"
        /// </summary>
        /// <param name="_country">Новая страна</param>
        public void setCountry(string _country) { country = _country; }
        /// <summary>
        /// Функция для изменения значения поля "Рост"
        /// </summary>
        /// <param name="_height">Новый рост</param>
        public void setHeight(double _height) { height = _height; }

        /// <summary>
        /// Переопределенный метод ToString()
        /// </summary>
        /// <returns>Полная информация об объекте</returns>
        public override string ToString()
        {
            return "Имя: " + name + "\nФамилия: " + surname + "\nПол: " + gender + "\nГод рождения: " +
                year_of_birth.ToString() + "\nГород: " + city + "\nСтрана: " + country +
                "\nРост: " + height.ToString() + "\nОбщее количество человек: " + persons_count.ToString();
        }

        ///// <summary>
        ///// Проверят правильность высоты роста человека
        ///// </summary>
        ///// <param name="_height">Рост</param>
        ///// <returns>True, если проверка пройдена, иначе - false</returns>
        //static public bool IsRightHeight(double _height)
        //{
        //    return (_height > MIN_HEIGHT && _height < MAX_HEIGHT);
        //}

        /// <summary>
        /// Проверят правильность строки с возможным ростом человека
        /// </summary>
        /// <param name="_height">Строка с возможным ростом</param>
        /// <returns>True, если проверка пройдена, иначе - false</returns>
        static public bool IsRightHeight(string _height)
        {
            string regex = @"^[0-9]+(,[0-9]+)*$";
            return (Regex.IsMatch(_height, regex) && Convert.ToDouble(_height) > MIN_HEIGHT
                && Convert.ToDouble(_height) < MAX_HEIGHT);
        }

        ///// <summary>
        ///// Проверяет правильность года рождения человека
        ///// </summary>
        ///// <param name="_year_of_birth">Год рождения</param>
        ///// <returns>True, если проверка пройдена, иначе - false</returns>
        //static public bool IsRightYear(int _year_of_birth)
        //{
        //    int currentYear = DateTime.Now.Year;
        //    return (_year_of_birth > currentYear - MAX_AGE && _year_of_birth < currentYear);
        //}

        /// <summary>
        /// Проверяет правильность строки с возможным годом рождения человека
        /// </summary>
        /// <param name="_year_of_birth">Строка с возможным годом рождения</param>
        /// <returns>True, если проверка пройдена, иначе - false</returns>
        static public bool IsRightYear(string _year_of_birth)
        {
            string regex = @"^[0-9]+$";
            int currentYear = DateTime.Now.Year;
            return (Regex.IsMatch(_year_of_birth, regex) &&
                Convert.ToInt32(_year_of_birth) > currentYear - MAX_AGE
                && Convert.ToInt32(_year_of_birth) < currentYear);
        }

        /// <summary>
        /// Проверяет правильность какого-либо названия
        /// </summary>
        /// <param name="str">Название</param>
        /// <returns>True, если проверка пройдена, иначе - false</returns>
        static public bool IsRightName(string str)
        {
            string regex = @"^[A-Za-zА-Яа-яЁё-]+$";
            return Regex.IsMatch(str, regex);
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb1_Boyarinova_Bychkova_23VP1
{
    /// <summary>
    /// Класс, описывающий предметную область Человек
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Поле "Имя человека"
        /// </summary>
        public string name;
        /// <summary>
        /// Поле "Фамилия человека"
        /// </summary>
        public string surname;
        /// <summary>
        /// Поле "Пол человека"
        /// </summary>
        private string gender;
        /// <summary>
        /// Поле "Год рождения человека"
        /// </summary>
        private int year_of_birth;
        /// <summary>
        /// Поле "Город проживания человека"
        /// </summary>
        private string city;
        /// <summary>
        /// Поле "Страна проживания человека"
        /// </summary>
        private string country;
        /// <summary>
        /// Поле "Рост человека"
        /// </summary>
        private double height;
        /// <summary>
        /// Общее количество созданных объектов класса Person
        /// </summary>
        private static int persons_count = 0;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Person()
        {
            name = "Иван";
            surname = "Иванов";
            gender = "мужской";
            year_of_birth = 2000;
            city = "Москва";
            country = "Россия";
            height = 180.5f;
            persons_count++;
        }

        /// <summary>
        /// Кончтруктор с 2 параметрами
        /// </summary>
        /// <param name="_name">Имя</param>
        /// <param name="_surname">Фамилия</param>
        public Person(string _name, string _surname)
        {
            name = _name;
            surname = _surname;
            gender = "мужской";
            year_of_birth = 2000;
            city = "Москва";
            country = "Россия";
            height = 180.5f;
            persons_count++;
        }

        /// <summary>
        /// Кончтруктор с 1 параметром
        /// </summary>
        /// <param name="_name">Имя</param>
        public Person(string _name)
        {
            name = _name;
            surname = "Иванов";
            gender = "мужской";
            year_of_birth = 2000;
            city = "Москва";
            country = "Россия";
            height = 180.5f;
            persons_count++;
        }

        /// <summary>
        /// Конструктор со всеми параметрами
        /// </summary>
        /// <param name="_name">Имя</param>
        /// <param name="_surname">Фамилия</param>
        /// <param name="_gender">Пол</param>
        /// <param name="_year_of_birth">Год рождения</param>
        /// <param name="_city">Город</param>
        /// <param name="_country">Страна</param>
        /// <param name="_height">Рост</param>
        public Person(string _name, string _surname, string _gender, int _year_of_birth, string _city,
            string _country, double _height)
        {
            name = _name;
            surname = _surname;
            gender = _gender;
            year_of_birth = _year_of_birth;
            city = _city;
            country = _country;
            height = _height;
            persons_count++;
        }

        /// <summary>
        /// Функция для получения значения поля "Пол"
        /// </summary>
        /// <returns>Пол</returns>
        public string getGender() { return gender; }
        /// <summary>
        /// Функция для получения значения поля "Год рождения"
        /// </summary>
        /// <returns>Год рождения</returns>
        public int getYear_of_birth() { return year_of_birth; }
        /// <summary>
        /// Функция для получения значения поля "Город"
        /// </summary>
        /// <returns>Город</returns>
        public string getCity() { return city; }
        /// <summary>
        /// Функция для получения значения поля "Страна"
        /// </summary>
        /// <returns>Страна</returns>
        public string getCountry() { return country; }
        /// <summary>
        /// Функция для получения значения поля "Рост"
        /// </summary>
        /// <returns>Рост</returns>
        public double getHeight() { return height; }
        /// <summary>
        /// Функция для получения общего кол-ва объектов
        /// </summary>
        /// <returns>Общее кол-во объектов</returns>
        public int getPersons_count() { return persons_count; }
        /// <summary>
        /// Функция для изменения значения поля "Пол"
        /// </summary>
        /// <param name="_gender">Новое значение поля "Пол"</param>
        public void setGender(string _gender) { gender = _gender; }
        /// <summary>
        /// Функция для изменения значения поля "Год рождения"
        /// </summary>
        /// <param name="_year_of_birth">Новый год рождения</param>
        public void setYear_of_birth(int _year_of_birth) { year_of_birth = _year_of_birth; }
        /// <summary>
        /// Функция для изменения значения поля "Город"
        /// </summary>
        /// <param name="_city">Новый город</param>
        public void setCity(string _city) { city = _city; }
        /// <summary>
        /// Функция для изменения значения поля "Страна"
        /// </summary>
        /// <param name="_country">Новая страна</param>
        public void setCountry(string _country) { country = _country; }
        /// <summary>
        /// Функция для изменения значения поля "Рост"
        /// </summary>
        /// <param name="_height">Новый рост</param>
        public void setHeight(double _height) { height = _height; }

        /// <summary>
        /// Переопределенный метод ToString()
        /// </summary>
        /// <returns>Полная информация об объекте</returns>
        public override string ToString()
        {
            return "Имя: " + name + "\nФамилия: " + surname + "\nПол: " + gender + "\nГод рождения: " +
                year_of_birth.ToString() + "\nГород: " + city + "\nСтрана: " + country +
                "\nРост: " + height.ToString() + "\nОбщее количество человек: " + persons_count.ToString();
        }
    }
}*/
