namespace windows_form_bazanks
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
            lbResalt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbFrom = new TextBox();
            tbUntil = new TextBox();
            btGenerate = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lResalt = new Label();
            label7 = new Label();
            cbxPressure = new ComboBox();
            cbxTemp = new ComboBox();
            label6 = new Label();
            cbxLong = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            tbNumber = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(119, 27);
            label1.TabIndex = 0;
            label1.Text = "Случайное число:";
            // 
            // lbResalt
            // 
            lbResalt.Location = new Point(6, 49);
            lbResalt.Name = "lbResalt";
            lbResalt.ReadOnly = true;
            lbResalt.Size = new Size(227, 23);
            lbResalt.TabIndex = 1;
            lbResalt.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 89);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 2;
            label2.Text = "От:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 89);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 3;
            label3.Text = "До:";
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(6, 123);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(82, 23);
            tbFrom.TabIndex = 4;
            tbFrom.TextAlign = HorizontalAlignment.Center;
            // 
            // tbUntil
            // 
            tbUntil.Location = new Point(149, 123);
            tbUntil.Name = "tbUntil";
            tbUntil.Size = new Size(84, 23);
            tbUntil.TabIndex = 5;
            tbUntil.TextAlign = HorizontalAlignment.Center;
            // 
            // btGenerate
            // 
            btGenerate.Location = new Point(6, 173);
            btGenerate.Name = "btGenerate";
            btGenerate.Size = new Size(227, 64);
            btGenerate.TabIndex = 6;
            btGenerate.Text = "Сгенерировать";
            btGenerate.UseVisualStyleBackColor = true;
            btGenerate.Click += btGenerate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btGenerate);
            groupBox1.Controls.Add(lbResalt);
            groupBox1.Controls.Add(tbUntil);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbFrom);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 257);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задача1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lResalt);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cbxPressure);
            groupBox2.Controls.Add(cbxTemp);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbxLong);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbNumber);
            groupBox2.Location = new Point(270, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(339, 257);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Задача2";
            // 
            // lResalt
            // 
            lResalt.Location = new Point(26, 157);
            lResalt.Name = "lResalt";
            lResalt.Size = new Size(287, 80);
            lResalt.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(215, 89);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 7;
            label7.Text = "Из Паскалей в:";
            // 
            // cbxPressure
            // 
            cbxPressure.FormattingEnabled = true;
            cbxPressure.Items.AddRange(new object[] { "мм.Р.С.", "Бар", "Атмосфер", "кг.Силы" });
            cbxPressure.Location = new Point(215, 117);
            cbxPressure.Name = "cbxPressure";
            cbxPressure.Size = new Size(98, 23);
            cbxPressure.TabIndex = 6;
            cbxPressure.SelectedIndexChanged += cbxPressure_SelectedIndexChanged;
            // 
            // cbxTemp
            // 
            cbxTemp.FormattingEnabled = true;
            cbxTemp.Items.AddRange(new object[] { "Кельвин", "Фарингейт" });
            cbxTemp.Location = new Point(124, 117);
            cbxTemp.Name = "cbxTemp";
            cbxTemp.Size = new Size(85, 23);
            cbxTemp.TabIndex = 5;
            cbxTemp.SelectedIndexChanged += cbxTemp_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 89);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 4;
            label6.Text = "Из градусов в:";
            // 
            // cbxLong
            // 
            cbxLong.FormattingEnabled = true;
            cbxLong.Items.AddRange(new object[] { "Сантиметры", "Дециметры", "Метры", "Киллометры" });
            cbxLong.Location = new Point(26, 117);
            cbxLong.Name = "cbxLong";
            cbxLong.Size = new Size(92, 23);
            cbxLong.TabIndex = 3;
            cbxLong.SelectedIndexChanged += cbxLong_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 89);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 2;
            label5.Text = "Миллиметры в:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 27);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 1;
            label4.Text = "Введите число";
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(24, 49);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(289, 23);
            tbNumber.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 281);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Случайное число";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox lbResalt;
        private Label label2;
        private Label label3;
        private TextBox tbFrom;
        private TextBox tbUntil;
        private Button btGenerate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private TextBox tbNumber;
        private Label lResalt;
        private Label label7;
        private ComboBox cbxPressure;
        private ComboBox cbxTemp;
        private Label label6;
        private ComboBox cbxLong;
    }
}
