using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb1_Boyarinova_Bychkova_23VP1
{
    /// <summary>
    /// Класс, описывающий предметную область Человек
    /// </summary>
    internal class Person
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
}
