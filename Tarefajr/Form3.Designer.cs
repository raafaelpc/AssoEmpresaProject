namespace Tarefajr
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tabPage2 = new TabPage();
            label9 = new Label();
            textBox8 = new TextBox();
            textBox10 = new TextBox();
            label13 = new Label();
            label15 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label11 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label8 = new Label();
            label7 = new Label();
            tabPage1 = new TabPage();
            label16 = new Label();
            textBox9 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label14 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label12 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label10 = new Label();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            tabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(353, 28);
            label1.Name = "label1";
            label1.Size = new Size(310, 28);
            label1.TabIndex = 0;
            label1.Text = "Edite um associado ou empresa";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(radioButton3);
            tabPage2.Controls.Add(radioButton4);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(721, 490);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Empresa";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(186, 240);
            label9.Name = "label9";
            label9.Size = new Size(322, 28);
            label9.TabIndex = 43;
            label9.Text = "Vincule asssociados nas empresa";
            // 
            // textBox8
            // 
            textBox8.Cursor = Cursors.No;
            textBox8.ImeMode = ImeMode.Off;
            textBox8.Location = new Point(303, 324);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(100, 25);
            textBox8.TabIndex = 47;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(303, 284);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 25);
            textBox10.TabIndex = 45;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(189, 327);
            label13.Name = "label13";
            label13.Size = new Size(109, 19);
            label13.TabIndex = 46;
            label13.Text = "Nome associado";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(203, 287);
            label15.Name = "label15";
            label15.Size = new Size(86, 19);
            label15.TabIndex = 44;
            label15.Text = "Id Associado";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(397, 198);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(95, 23);
            radioButton3.TabIndex = 30;
            radioButton3.TabStop = true;
            radioButton3.Text = "Desativado";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(303, 198);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(74, 23);
            radioButton4.TabIndex = 29;
            radioButton4.TabStop = true;
            radioButton4.Text = "Ativado";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(237, 198);
            label11.Name = "label11";
            label11.Size = new Size(47, 19);
            label11.TabIndex = 28;
            label11.Text = "Status";
            // 
            // button6
            // 
            button6.Location = new Point(314, 412);
            button6.Name = "button6";
            button6.Size = new Size(79, 25);
            button6.TabIndex = 23;
            button6.Text = "Atualizar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.CausesValidation = false;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.World);
            button5.Location = new Point(520, 50);
            button5.Name = "button5";
            button5.Size = new Size(125, 25);
            button5.TabIndex = 22;
            button5.Text = "Deletar Empresa";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(425, 49);
            button4.Name = "button4";
            button4.Size = new Size(79, 25);
            button4.TabIndex = 21;
            button4.Text = "Procurar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(303, 98);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 25);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(303, 146);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 25);
            textBox7.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 53);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 2;
            label3.Text = "Id da Empresa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(237, 149);
            label8.Name = "label8";
            label8.Size = new Size(40, 19);
            label8.TabIndex = 13;
            label8.Text = "CNPJ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(237, 101);
            label7.Name = "label7";
            label7.Size = new Size(46, 19);
            label7.TabIndex = 11;
            label7.Text = "Nome";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(textBox9);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(721, 490);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Associado";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(219, 275);
            label16.Name = "label16";
            label16.Size = new Size(322, 28);
            label16.TabIndex = 19;
            label16.Text = "Vincule asssociados nas empresa";
            // 
            // textBox9
            // 
            textBox9.Cursor = Cursors.No;
            textBox9.Location = new Point(336, 359);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(100, 25);
            textBox9.TabIndex = 42;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(336, 319);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 25);
            textBox5.TabIndex = 40;
            textBox5.TextChanged += textBox5_TextChanged_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(336, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 25);
            textBox3.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(336, 132);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 25);
            textBox4.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(270, 362);
            label14.Name = "label14";
            label14.Size = new Size(46, 19);
            label14.TabIndex = 41;
            label14.Text = "Nome";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 322);
            label6.Name = "label6";
            label6.Size = new Size(86, 19);
            label6.TabIndex = 39;
            label6.Text = "Id Associado";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(318, 227);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(181, 227);
            label12.Name = "label12";
            label12.Size = new Size(131, 19);
            label12.TabIndex = 28;
            label12.Text = "Data de nascimento";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(404, 176);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 23);
            radioButton2.TabIndex = 27;
            radioButton2.TabStop = true;
            radioButton2.Text = "Desativado";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(310, 176);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(74, 23);
            radioButton1.TabIndex = 26;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ativado";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(244, 176);
            label10.Name = "label10";
            label10.Size = new Size(47, 19);
            label10.TabIndex = 24;
            label10.Text = "Status";
            // 
            // button3
            // 
            button3.Location = new Point(347, 427);
            button3.Name = "button3";
            button3.Size = new Size(79, 25);
            button3.TabIndex = 21;
            button3.Text = "Atualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.CausesValidation = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.World);
            button2.Location = new Point(527, 44);
            button2.Name = "button2";
            button2.Size = new Size(125, 25);
            button2.TabIndex = 20;
            button2.Text = "Deletar Associado";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 44);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 1;
            label2.Text = "Id do Associado";
            // 
            // button1
            // 
            button1.Location = new Point(442, 44);
            button1.Name = "button1";
            button1.Size = new Size(79, 25);
            button1.TabIndex = 16;
            button1.Text = "Procurar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 92);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 5;
            label4.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 132);
            label5.Name = "label5";
            label5.Size = new Size(30, 19);
            label5.TabIndex = 6;
            label5.Text = "Cpf";
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "";
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(160, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(729, 520);
            tabControl1.TabIndex = 18;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 617);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button4;
        private DataGridView dataGridView2;
        private Label label10;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button6;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label11;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private TabPage tabPage3;
        private TextBox textBox8;
        private Label label13;
        private Button button7;
        private Label label9;
        private TextBox textBox10;
        private Label label15;
        private Label label16;
        private TextBox textBox9;
        private Label label14;
        private TextBox textBox5;
        private Label label6;
    }
}