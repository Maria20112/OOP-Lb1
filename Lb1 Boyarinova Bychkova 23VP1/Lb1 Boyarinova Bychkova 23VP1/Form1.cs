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
            create_err.Text = "";
            string person_name = name.Text;
            string person_surname = surname.Text;
            string person_gender = "";
            if (man.Checked) person_gender = "�������";
            if (woman.Checked) person_gender = "�������";
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
                    else create_err.Text = "������������ ��������";
                    if (person_gender == "" || person_city == "" || person_country == ""
                        || person_height == 0) create_err.Text = "������� �������������� ������";
                }
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
                only_name.Text = "������ �������� �� ����������";
                return;
            }
            string selected = change_pole.SelectedItem.ToString();
            string new_value_text = new_value.Text;
            switch (selected)
            {
                case "���":
                    people[num - 1].name = new_value_text;
                    break;
                case "�������":
                    people[num - 1].surname = new_value_text;
                    break;
                case "���":
                    if (new_value_text == "�������" || new_value_text == "�������")
                        people[num - 1].setGender(new_value.Text);
                    else change_err.Text = "������������ ��������";
                    break;
                case "��� ��������":
                    int new_year = 0;
                    if (int.TryParse(new_value_text, out new_year))
                        people[num - 1].setYear_of_birth(new_year);
                    else change_err.Text = "������������ ��������";
                    break;
                case "�����":
                    people[num - 1].setCity(new_value.Text);
                    break;
                case "������":
                    people[num - 1].setCountry(new_value.Text);
                    break;
                case "����":
                    double new_height = 0;
                    if (double.TryParse(new_value_text, out new_height))
                        people[num - 1].setHeight(new_height);
                    else change_err.Text = "������������ ��������";
                    break;
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
