namespace Lb1_Boyarinova_Bychkova_23VP1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            create = new Button();
            name = new TextBox();
            surname = new TextBox();
            man = new RadioButton();
            woman = new RadioButton();
            year_of_birth = new NumericUpDown();
            city = new TextBox();
            country = new TextBox();
            height = new TextBox();
            number = new NumericUpDown();
            label12 = new Label();
            print_all = new Button();
            data = new Label();
            only_name = new Label();
            print_name = new Button();
            pole = new ComboBox();
            print_hex_num = new Button();
            hex_pole = new ComboBox();
            print_num = new Label();
            label13 = new Label();
            num_for_change = new NumericUpDown();
            change = new Button();
            label14 = new Label();
            change_pole = new ComboBox();
            new_value = new TextBox();
            label15 = new Label();
            change_err = new Label();
            create_err = new Label();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)year_of_birth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)number).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_for_change).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(290, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 60);
            label1.TabIndex = 0;
            label1.Text = "Лабораторная работа №1 \r\n23ВП1\r\nБояринова М.Г., Бычкова Н.Р.\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(290, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 472);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(567, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 472);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(0, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(878, 12);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(76, 89);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 4;
            label2.Text = "Создание объекта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(379, 89);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 5;
            label3.Text = "Вывод данных";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(654, 89);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 6;
            label4.Text = "Изменение данных";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 128);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 7;
            label5.Text = "Имя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 161);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 8;
            label6.Text = "Фамилия";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 208);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 9;
            label7.Text = "Пол";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 278);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 10;
            label8.Text = "Год рождения";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 318);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 11;
            label9.Text = "Город";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 360);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 12;
            label10.Text = "Страна";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 409);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 13;
            label11.Text = "Рост";
            // 
            // create
            // 
            create.Location = new Point(76, 448);
            create.Name = "create";
            create.Size = new Size(127, 48);
            create.TabIndex = 14;
            create.Text = "Создать";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // name
            // 
            name.Location = new Point(91, 125);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 15;
            // 
            // surname
            // 
            surname.Location = new Point(91, 158);
            surname.Name = "surname";
            surname.Size = new Size(125, 27);
            surname.TabIndex = 16;
            // 
            // man
            // 
            man.AutoSize = true;
            man.Location = new Point(91, 204);
            man.Name = "man";
            man.Size = new Size(91, 24);
            man.TabIndex = 17;
            man.TabStop = true;
            man.Text = "мужской";
            man.UseVisualStyleBackColor = true;
            // 
            // woman
            // 
            woman.AutoSize = true;
            woman.Location = new Point(91, 234);
            woman.Name = "woman";
            woman.Size = new Size(90, 24);
            woman.TabIndex = 18;
            woman.TabStop = true;
            woman.Text = "женский";
            woman.UseVisualStyleBackColor = true;
            // 
            // year_of_birth
            // 
            year_of_birth.Location = new Point(126, 276);
            year_of_birth.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            year_of_birth.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            year_of_birth.Name = "year_of_birth";
            year_of_birth.Size = new Size(150, 27);
            year_of_birth.TabIndex = 19;
            year_of_birth.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // city
            // 
            city.Location = new Point(91, 315);
            city.Name = "city";
            city.Size = new Size(125, 27);
            city.TabIndex = 20;
            // 
            // country
            // 
            country.Location = new Point(91, 357);
            country.Name = "country";
            country.Size = new Size(125, 27);
            country.TabIndex = 21;
            // 
            // height
            // 
            height.Location = new Point(91, 406);
            height.Name = "height";
            height.Size = new Size(125, 27);
            height.TabIndex = 22;
            // 
            // number
            // 
            number.Location = new Point(366, 132);
            number.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            number.Name = "number";
            number.Size = new Size(150, 27);
            number.TabIndex = 23;
            number.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(379, 109);
            label12.Name = "label12";
            label12.Size = new Size(119, 20);
            label12.TabIndex = 24;
            label12.Text = "Введите номер ";
            // 
            // print_all
            // 
            print_all.Location = new Point(326, 165);
            print_all.Name = "print_all";
            print_all.Size = new Size(235, 29);
            print_all.TabIndex = 25;
            print_all.Text = "Вывести все данные человека";
            print_all.UseVisualStyleBackColor = true;
            print_all.Click += print_all_Click;
            // 
            // data
            // 
            data.AutoSize = true;
            data.Location = new Point(326, 204);
            data.Name = "data";
            data.Size = new Size(0, 20);
            data.TabIndex = 26;
            // 
            // only_name
            // 
            only_name.AutoSize = true;
            only_name.Location = new Point(306, 406);
            only_name.Name = "only_name";
            only_name.Size = new Size(0, 20);
            only_name.TabIndex = 27;
            // 
            // print_name
            // 
            print_name.Location = new Point(306, 374);
            print_name.Name = "print_name";
            print_name.Size = new Size(79, 29);
            print_name.TabIndex = 28;
            print_name.Text = "Вывести";
            print_name.UseVisualStyleBackColor = true;
            print_name.Click += print_name_Click;
            // 
            // pole
            // 
            pole.FormattingEnabled = true;
            pole.Items.AddRange(new object[] { "Имя", "Фамилия", "Пол", "Год рождения", "Город", "Страна", "Рост" });
            pole.Location = new Point(410, 374);
            pole.Name = "pole";
            pole.Size = new Size(151, 28);
            pole.TabIndex = 29;
            // 
            // print_hex_num
            // 
            print_hex_num.Location = new Point(366, 424);
            print_hex_num.Name = "print_hex_num";
            print_hex_num.Size = new Size(127, 50);
            print_hex_num.TabIndex = 30;
            print_hex_num.Text = "Вывести в 16-м формате";
            print_hex_num.UseVisualStyleBackColor = true;
            print_hex_num.Click += print_hex_num_Click;
            // 
            // hex_pole
            // 
            hex_pole.FormattingEnabled = true;
            hex_pole.Items.AddRange(new object[] { "Год рождения", "Рост" });
            hex_pole.Location = new Point(356, 480);
            hex_pole.Name = "hex_pole";
            hex_pole.Size = new Size(151, 28);
            hex_pole.TabIndex = 31;
            // 
            // print_num
            // 
            print_num.AutoSize = true;
            print_num.Location = new Point(399, 515);
            print_num.Name = "print_num";
            print_num.Size = new Size(0, 20);
            print_num.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(671, 109);
            label13.Name = "label13";
            label13.Size = new Size(115, 20);
            label13.TabIndex = 33;
            label13.Text = "Введите номер";
            // 
            // num_for_change
            // 
            num_for_change.Location = new Point(654, 132);
            num_for_change.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_for_change.Name = "num_for_change";
            num_for_change.Size = new Size(150, 27);
            num_for_change.TabIndex = 34;
            num_for_change.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // change
            // 
            change.Location = new Point(647, 322);
            change.Name = "change";
            change.Size = new Size(157, 29);
            change.TabIndex = 35;
            change.Text = "Изменить данные";
            change.UseVisualStyleBackColor = true;
            change.Click += change_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(635, 174);
            label14.Name = "label14";
            label14.Size = new Size(185, 20);
            label14.TabIndex = 36;
            label14.Text = "Что Вы хотите изменить?";
            // 
            // change_pole
            // 
            change_pole.FormattingEnabled = true;
            change_pole.Items.AddRange(new object[] { "Имя", "Фамилия", "Пол", "Год рождения", "Город", "Страна", "Рост" });
            change_pole.Location = new Point(653, 208);
            change_pole.Name = "change_pole";
            change_pole.Size = new Size(151, 28);
            change_pole.TabIndex = 37;
            // 
            // new_value
            // 
            new_value.Location = new Point(662, 278);
            new_value.Name = "new_value";
            new_value.Size = new Size(125, 27);
            new_value.TabIndex = 38;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(662, 255);
            label15.Name = "label15";
            label15.Size = new Size(124, 20);
            label15.TabIndex = 39;
            label15.Text = "Новое значение";
            // 
            // change_err
            // 
            change_err.AutoSize = true;
            change_err.Location = new Point(599, 361);
            change_err.Name = "change_err";
            change_err.Size = new Size(0, 20);
            change_err.TabIndex = 40;
            // 
            // create_err
            // 
            create_err.AutoSize = true;
            create_err.Location = new Point(33, 515);
            create_err.Name = "create_err";
            create_err.Size = new Size(0, 20);
            create_err.TabIndex = 41;
            // 
            // exit
            // 
            exit.Location = new Point(763, 499);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 42;
            exit.Text = "Выход";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 544);
            Controls.Add(exit);
            Controls.Add(create_err);
            Controls.Add(change_err);
            Controls.Add(label15);
            Controls.Add(new_value);
            Controls.Add(change_pole);
            Controls.Add(label14);
            Controls.Add(change);
            Controls.Add(num_for_change);
            Controls.Add(label13);
            Controls.Add(print_num);
            Controls.Add(hex_pole);
            Controls.Add(print_hex_num);
            Controls.Add(pole);
            Controls.Add(print_name);
            Controls.Add(only_name);
            Controls.Add(data);
            Controls.Add(print_all);
            Controls.Add(label12);
            Controls.Add(number);
            Controls.Add(height);
            Controls.Add(country);
            Controls.Add(city);
            Controls.Add(year_of_birth);
            Controls.Add(woman);
            Controls.Add(man);
            Controls.Add(surname);
            Controls.Add(name);
            Controls.Add(create);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Лабораторная работа №1";
            ((System.ComponentModel.ISupportInitialize)year_of_birth).EndInit();
            ((System.ComponentModel.ISupportInitialize)number).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_for_change).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button create;
        private TextBox name;
        private TextBox surname;
        private RadioButton man;
        private RadioButton woman;
        private NumericUpDown year_of_birth;
        private TextBox city;
        private TextBox country;
        private TextBox height;
        private NumericUpDown number;
        private Label label12;
        private Button print_all;
        private Label data;
        private Label only_name;
        private Button print_name;
        private ComboBox pole;
        private Button print_hex_num;
        private ComboBox hex_pole;
        private Label print_num;
        private Label label13;
        private NumericUpDown num_for_change;
        private Button change;
        private Label label14;
        private ComboBox change_pole;
        private TextBox new_value;
        private Label label15;
        private Label change_err;
        private Label create_err;
        private Button exit;
    }
}
