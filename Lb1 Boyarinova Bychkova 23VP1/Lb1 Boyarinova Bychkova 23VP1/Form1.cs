namespace Lb1_Boyarinova_Bychkova_23VP1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Список, хранящий все созданные объекты Person
        /// </summary>
        List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            pole.SelectedIndex = 0;
            hex_pole.SelectedIndex = 0;
            change_pole.SelectedIndex = 0;
        }

        /// <summary>
        /// Функция, получающая введенные пользователем данные и создающая новый 
        /// объект Person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                create_err.Text = "";
                string person_name = name.Text;
                string person_surname = surname.Text;
                string person_gender = (man.Checked) ? "мужской" : "женский";
                string person_year_of_birth = year_of_birth.Text;
                string person_city = city.Text;
                string person_country = country.Text;
                string person_height = height.Text;
                Person newPerson;

                if (person_name == "")
                {
                    newPerson = Person.createPerson();
                }
                else if (person_surname == "")
                {
                    newPerson = Person.createPerson(person_name);
                }
                else if (person_city == "" || person_country == "" || height.Text == "")
                {
                    newPerson = Person.createPerson(person_name, person_surname);
                }
                else
                {
                    newPerson = Person.createPerson(person_name, person_surname,
                            person_gender, person_year_of_birth, person_city,
                            person_country, person_height);
                }

                if (newPerson == null)
                {
                    create_err.Text = "Заполните все поля формы корректно";
                }
                else
                {
                    people.Add(newPerson);
                    create_err.Text = "Готово!";
                }
                name.Text = "";
                surname.Text = "";
                year_of_birth.Text = "2000";
                city.Text = "";
                country.Text = "";
                height.Text = "";
            }
            catch (MyOverflowException ex)
            {
                Win32.MessageBox(0, ex.Message + "\n" + ex.TimeOfExeption.ToString(), "Перенаселение", 0);
            }
        }

        /// <summary>
        /// Функция, выводящая полную информацию о выбранном человеке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void print_all_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(number.Value);
            if (people.Count < num) data.Text = "Некорректное значение";
            else data.Text = people[num - 1].ToString();
        }

        /// <summary>
        /// Функция, выводящая на экран значение определнного поля у выбранного человека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void print_name_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(number.Value);
            if (people.Count < num)
            {
                only_name.Text = "Такого человека не существует";
                return;
            }
            string selected = pole.SelectedItem.ToString();
            switch (selected)
            {
                case "Имя":
                    only_name.Text = people[num - 1].name;
                    break;
                case "Фамилия":
                    only_name.Text = people[num - 1].surname;
                    break;
                case "Пол":
                    only_name.Text = people[num - 1].Gender;
                    break;
                case "Год рождения":
                    only_name.Text = people[num - 1].Year_of_birth.ToString();
                    break;
                case "Город":
                    only_name.Text = people[num - 1].City;
                    break;
                case "Страна":
                    only_name.Text = people[num - 1].Country;
                    break;
                case "Рост":
                    only_name.Text = people[num - 1].Height.ToString();
                    break;
            }
        }

        /// <summary>
        ///Функция для представления значений числовых полей в 16-м формате
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void print_hex_num_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(number.Value);
            if (people.Count < num)
            {
                only_name.Text = "Такого человека не существует";
                return;
            }
            string selected = hex_pole.SelectedItem.ToString();
            if (selected == "Год рождения") print_num.Text =
                    Convert.ToString(Convert.ToInt32(people[num - 1].Year_of_birth), 16);
            if (selected == "Рост") print_num.Text =
                    Convert.ToString(Convert.ToInt32(people[num - 1].Height), 16);
        }

        /// <summary>
        /// Функция, меняющая значение выбранного поля у определенного человека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_Click(object sender, EventArgs e)
        {
            change_err.Text = "";
            int num = Convert.ToInt32(num_for_change.Value);
            if (people.Count < num)
            {
                change_err.Text = "Такого человека не существует";
                return;
            }
            string selected = change_pole.SelectedItem.ToString();
            string new_value_text = new_value.Text;
            switch (selected)
            {
                case "Имя":
                    if (Person.IsRightName(new_value_text))
                    {
                        people[num - 1].name = new_value_text;
                    }
                    else
                    {
                        change_err.Text = "Некорректное значение";
                    }
                    break;
                case "Фамилия":
                    if (Person.IsRightName(new_value_text))
                    {
                        people[num - 1].surname = new_value_text;
                    }
                    else
                    {
                        change_err.Text = "Некорректное значение";
                    }
                    break;
                case "Пол":
                    if (new_value_text == "мужской" || new_value_text == "женский")
                        people[num - 1].Gender = new_value.Text;
                    else change_err.Text = "Некорректное значение";
                    break;
                case "Год рождения":
                    //int new_year = 0;
                    if (Person.IsRightYear(new_value_text))
                    {
                        people[num - 1].Year_of_birth = Convert.ToInt32(new_value_text);
                    }
                    else change_err.Text = "Некорректное значение";
                    break;
                case "Город":
                    if (Person.IsRightName(new_value_text))
                    {
                        people[num - 1].City = new_value.Text;
                    }
                    else
                    {
                        change_err.Text = "Некорректное значение";
                    }
                    break;
                case "Страна":
                    if (Person.IsRightName(new_value_text))
                    {
                        people[num - 1].Country = new_value.Text;
                    }
                    else
                    {
                        change_err.Text = "Некорректное значение";
                    }
                    break;
                case "Рост":
                    //double new_height = 0;
                    if (Person.IsRightHeight(new_value_text))
                    {
                        people[num - 1].Height = Convert.ToDouble(new_value_text);
                    }
                    else change_err.Text = "Некорректное значение";
                    break;
                default: break;
            }
            if (change_err.Text == "")
            {
                change_err.Text = "Готово!";
            }

        }

        /// <summary>
        /// Завершает работу приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
/*{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Список, хранящий все созданные объекты Person
        /// </summary>
        List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            pole.SelectedIndex = 0;
            hex_pole.SelectedIndex = 0;
            change_pole.SelectedIndex = 0;
        }

        /// <summary>
        /// Функция, получающая введенные пользователем данные и создающая новый объект Person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void create_Click(object sender, EventArgs e)
        {
            create_err.Text = "";
            string person_name = name.Text;
            string person_surname = surname.Text;
            string person_gender = "";
            if (man.Checked) person_gender = "мужской";
            if (woman.Checked) person_gender = "женский";
            int person_year_of_birth = 0;
            string person_city = city.Text;
            string person_country = country.Text;
            double person_height = 0;
            if (person_name == "") people.Add(new Person());
            else
            {
                if (person_surname == "") people.Add(new Person(person_name));
                else
                {
                    if (int.TryParse(year_of_birth.Text, out person_year_of_birth) &&
                        double.TryParse(height.Text, out person_height))
                        people.Add(new Person(person_name, person_surname,
                        person_gender, person_year_of_birth, person_city, person_country,
                        Convert.ToDouble(person_height)));
                    else create_err.Text = "Некорректное значение";
                    if (person_gender == "" || person_city == "" || person_country == ""
                        || person_height == 0) create_err.Text = "Введите дополнительные данные";
                }
            }
        }

        /// <summary>
        /// Функция, выводящая полную информацию о выбранном человеке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void print_all_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(number.Value);
            if (people.Count < num) data.Text = "Такого человека не существует";
            else data.Text = people[num - 1].ToString();
        }

        /// <summary>
        /// Функция, выводящая на экран значение определнного поля у выбранного человека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void print_name_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(number.Value);
            if (people.Count < num)
            {
                only_name.Text = "Такого человека не существует";
                return;
            }
            string selected = pole.SelectedItem.ToString();
            switch (selected)
            {
                case "Имя":
                    only_name.Text = people[num - 1].name;
                    break;
                case "Фамилия":
                    only_name.Text = people[num - 1].surname;
                    break;
                case "Пол":
                    only_name.Text = people[num - 1].getGender();
                    break;
                case "Год рождения":
                    only_name.Text = people[num - 1].getYear_of_birth().ToString();
                    break;
                case "Город":
                    only_name.Text = people[num - 1].getCity();
                    break;
                case "Страна":
                    only_name.Text = people[num - 1].getCountry();
                    break;
                case "Рост":
                    only_name.Text = people[num - 1].getHeight().ToString();
                    break;
            }
        }

        /// <summary>
        /// Функция для представления значений числовых полей в 16-м формате
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void print_hex_num_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(number.Value);
            if (people.Count < num)
            {
                only_name.Text = "Такого человека не существует";
                return;
            }
            string selected = hex_pole.SelectedItem.ToString();
            if (selected == "Год рождения") print_num.Text =
                    Convert.ToString(Convert.ToInt32(people[num - 1].getYear_of_birth()), 16);
            if (selected == "Рост") print_num.Text =
                    Convert.ToString(Convert.ToInt32(people[num - 1].getHeight()), 16);
        }

        /// <summary>
        /// Функция, меняющая значение выбранного поля у определенного человека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_Click(object sender, EventArgs e)
        {
            change_err.Text = "";
            int num = Convert.ToInt32(num_for_change.Value);
            if (people.Count < num)
            {
                only_name.Text = "Такого человека не существует";
                return;
            }
            string selected = change_pole.SelectedItem.ToString();
            string new_value_text = new_value.Text;
            switch (selected)
            {
                case "Имя":
                    people[num - 1].name = new_value_text;
                    break;
                case "Фамилия":
                    people[num - 1].surname = new_value_text;
                    break;
                case "Пол":
                    if (new_value_text == "мужской" || new_value_text == "женский")
                        people[num - 1].setGender(new_value.Text);
                    else change_err.Text = "Некорректное значение";
                    break;
                case "Год рождения":
                    int new_year = 0;
                    if (int.TryParse(new_value_text, out new_year))
                        people[num - 1].setYear_of_birth(new_year);
                    else change_err.Text = "Некорректное значение";
                    break;
                case "Город":
                    people[num - 1].setCity(new_value.Text);
                    break;
                case "Страна":
                    people[num - 1].setCountry(new_value.Text);
                    break;
                case "Рост":
                    double new_height = 0;
                    if (double.TryParse(new_value_text, out new_height))
                        people[num - 1].setHeight(new_height);
                    else change_err.Text = "Некорректное значение";
                    break;
            }
        }

        /// <summary>
        /// Завершает работу приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}*/
