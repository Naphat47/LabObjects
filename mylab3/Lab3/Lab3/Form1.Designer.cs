namespace Lab3
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
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxBirthYear = new TextBox();
            buttonAdd = new Button();
            dataGridView1 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colHeight = new DataGridViewTextBoxColumn();
            colGrade = new DataGridViewTextBoxColumn();
            colMajor = new DataGridViewTextBoxColumn();
            label3 = new Label();
            textBoxId = new TextBox();
            textBoxHeight = new TextBox();
            textBoxGrade = new TextBox();
            textBoxMajor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            textBoxAllperson = new TextBox();
            textBoxMin = new TextBox();
            textBoxMax = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 31);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 89);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "birth Year";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(105, 28);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxBirthYear
            // 
            textBoxBirthYear.Location = new Point(105, 86);
            textBoxBirthYear.Name = "textBoxBirthYear";
            textBoxBirthYear.Size = new Size(100, 23);
            textBoxBirthYear.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(105, 202);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, colId, colYear, colHeight, colGrade, colMajor });
            dataGridView1.Location = new Point(211, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(643, 239);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colYear
            // 
            colYear.DataPropertyName = "Birthyear";
            colYear.HeaderText = "Year";
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            // 
            // colHeight
            // 
            colHeight.DataPropertyName = "Height";
            colHeight.HeaderText = "Height";
            colHeight.Name = "colHeight";
            colHeight.ReadOnly = true;
            // 
            // colGrade
            // 
            colGrade.DataPropertyName = "Grade";
            colGrade.HeaderText = "Grade";
            colGrade.Name = "colGrade";
            colGrade.ReadOnly = true;
            // 
            // colMajor
            // 
            colMajor.DataPropertyName = "Major";
            colMajor.HeaderText = "Major";
            colMajor.Name = "colMajor";
            colMajor.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 60);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 6;
            label3.Text = "id";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(105, 57);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 7;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(105, 115);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(100, 23);
            textBoxHeight.TabIndex = 8;
            // 
            // textBoxGrade
            // 
            textBoxGrade.Location = new Point(105, 144);
            textBoxGrade.Name = "textBoxGrade";
            textBoxGrade.Size = new Size(100, 23);
            textBoxGrade.TabIndex = 9;
            // 
            // textBoxMajor
            // 
            textBoxMajor.Location = new Point(105, 173);
            textBoxMajor.Name = "textBoxMajor";
            textBoxMajor.Size = new Size(100, 23);
            textBoxMajor.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 118);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 11;
            label4.Text = "height";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 147);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 12;
            label5.Text = "grade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 176);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 13;
            label6.Text = "major";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxAllperson);
            groupBox1.Controls.Add(textBoxMin);
            groupBox1.Controls.Add(textBoxMax);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(211, 283);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 116);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Result";
            // 
            // textBoxAllperson
            // 
            textBoxAllperson.Location = new Point(171, 79);
            textBoxAllperson.Name = "textBoxAllperson";
            textBoxAllperson.Size = new Size(100, 23);
            textBoxAllperson.TabIndex = 20;
            // 
            // textBoxMin
            // 
            textBoxMin.Location = new Point(171, 53);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(100, 23);
            textBoxMin.TabIndex = 19;
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(171, 25);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(100, 23);
            textBoxMax.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(56, 82);
            label9.Name = "label9";
            label9.Size = new Size(109, 15);
            label9.TabIndex = 17;
            label9.Text = "people (AllStudent)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 56);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 16;
            label8.Text = "Grade (Min)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(93, 28);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 15;
            label7.Text = "Grade (Max)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 450);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxMajor);
            Controls.Add(textBoxGrade);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxId);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxBirthYear);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Information ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxBirthYear;
        private Button buttonAdd;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colHeight;
        private DataGridViewTextBoxColumn colGrade;
        private DataGridViewTextBoxColumn colMajor;
        private Label label3;
        private TextBox textBoxId;
        private TextBox textBoxHeight;
        private TextBox textBoxGrade;
        private TextBox textBoxMajor;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox textBoxAllperson;
        private TextBox textBoxMin;
        private TextBox textBoxMax;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}