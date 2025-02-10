namespace Lb1_Boyarinova_Bychkova_23VP1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// ������, �������� ��� ��������� ������� Person
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
        /// �������, ���������� ��������� ������������� ������ � ��������� ����� ������ Person
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
                string person_gender = (man.Checked) ? "�������" : "�������";
                //if (man.Checked) person_gender = "�������";
                //if (woman.Checked) person_gender = "�������";
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
                    create_err.Text = "��������� ��� ���� ����� ���������";
                }
                else
                {
                    people.Add(newPerson);
                    create_err.Text = "������!";
                }
                //if (person_name == "") people.Add(new Person());
                //else
                //{
                //    if (person_surname == "" && Person.IsRightName(person_name))
                //        people.Add(new Person(person_name));
                //    else
                //    {
                //        if (person_city == "" || !Person.IsRightName(person_city)
                //            || person_country == "" || !Person.IsRightName(person_country)
                //            || height.Text == "")
                //        {
                //            create_err.Text = "��������� ��� ���� ����� ���������";
                //            return;
                //        }
                //        if (int.TryParse(year_of_birth.Text, out person_year_of_birth) &&
                //            Person.IsRightYear(person_year_of_birth) &&
                //            double.TryParse(height.Text, out person_height) &&
                //            Person.IsRightHeight(Convert.ToDouble(person_height)))
                //        {
                //            people.Add(new Person(person_name, person_surname,
                //            person_gender, person_year_of_birth, person_city, person_country,
                //            Convert.ToDouble(person_height)));
                //        }
                //        else
                //        {
                //            create_err.Text = "������������ ������";
                //            return;
                //        }
                //    }
                //}
                //create_err.Text = "������!";

                name.Text = "";
                surname.Text = "";
                year_of_birth.Text = "2000";
                city.Text = "";
                country.Text = "";
                height.Text = "";
            }
            catch (MyOverflowException ex)
            {
                Win32.MessageBox(0, ex.Message + "\n" + ex.TimeOfExeption.ToString(), "�������������", 0);
            }
        }

        /// <summary>
        /// �������, ��������� ������ ���������� � ��������� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void print_all_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(number.Value);
            if (people.Count < num) data.Text = "������ �������� �� ����������";
            else data.Text = people[num - 1].ToString();
        }

        /// <summary>
        /// �������, ��������� �� ����� �������� ������������ ���� � ���������� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void print_name_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(number.Value);
            if (people.Count < num)
            {
                only_name.Text = "������ �������� �� ����������";
                return;
            }
            string selected = pole.SelectedItem.ToString();
            switch (selected)
            {
                case "���":
                    only_name.Text = people[num - 1].name;
                    break;
                case "�������":
                    only_name.Text = people[num - 1].surname;
                    break;
                case "���":
                    only_name.Text = people[num - 1].getGender();
                    break;
                case "��� ��������":
                    only_name.Text = people[num - 1].getYear_of_birth().ToString();
                    break;
                case "�����":
                    only_name.Text = people[num - 1].getCity();
                    break;
                case "������":
                    only_name.Text = people[num - 1].getCountry();
                    break;
                case "����":
                    only_name.Text = people[num - 1].getHeight().ToString();
                    break;
            }
        }

        /// <summary>
        /// ������� ��� ������������� �������� �������� ����� � 16-� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void print_hex_num_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(number.Value);
            if (people.Count < num)
            {
                only_name.Text = "������ �������� �� ����������";
                return;
            }
            string selected = hex_pole.SelectedItem.ToString();
            if (selected == "��� ��������") print_num.Text =
                    Convert.ToString(Convert.ToInt32(people[num - 1].getYear_of_birth()), 16);
            if (selected == "����") print_num.Text =
                    Convert.ToString(Convert.ToInt32(people[num - 1].getHeight()), 16);
        }

        /// <summary>
        /// �������, �������� �������� ���������� ���� � ������������� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_Click(object sender, EventArgs e)
        {
            change_err.Text = "";
            int num = Convert.ToInt32(num_for_change.Value);
            if (people.Count < num)
            {
                change_err.Text = "������ �������� �� ����������";
                return;
            }
            string selected = change_pole.SelectedItem.ToString();
            string new_value_text = new_value.Text;
            switch (selected)
            {
                case "���":
                    if (Person.IsRightName(new_value_text))
                    {
                        people[num - 1].name = new_value_text;
                    }
                    else
                    {
                        change_err.Text = "������������ ��������";
                    }
                    break;
                case "�������":
                    if (Person.IsRightName(new_value_text))
                    {
                        people[num - 1].surname = new_value_text;
                    }
                    else
                    {
                        change_err.Text = "������������ ��������";
                    }
                    break;
                case "���":
                    if (new_value_text == "�������" || new_value_text == "�������")
                        people[num - 1].setGender(new_value.Text);
                    else change_err.Text = "������������ ��������";
                    break;
                case "��� ��������":
                    //int new_year = 0;
                    if (Person.IsRightYear(new_value_text))
                    {
                        people[num - 1].setYear_of_birth(Convert.ToInt32(new_value_text));
                    }
                    else change_err.Text = "������������ ��������";
                    break;
                case "�����":
                    if (Person.IsRightName(new_value_text))
                    {
                        people[num - 1].setCity(new_value.Text);
                    }
                    else
                    {
                        change_err.Text = "������������ ��������";
                    }
                    break;
                case "������":
                    if (Person.IsRightName(new_value_text))
                    {
                        people[num - 1].setCountry(new_value.Text);
                    }
                    else
                    {
                        change_err.Text = "������������ ��������";
                    }
                    break;
                case "����":
                    //double new_height = 0;
                    if (Person.IsRightHeight(new_value_text))
                    {
                        people[num - 1].setHeight(Convert.ToDouble(new_value_text));
                    }
                    else change_err.Text = "������������ ��������";
                    break;
                default: break;
            }
            if (change_err.Text == "")
            {
                change_err.Text = "������!";
            }

        }

        /// <summary>
        /// ��������� ������ ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
