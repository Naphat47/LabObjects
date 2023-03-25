using System.Security;

namespace Lab3
{
    public partial class Form1 : Form
    {
        //array <-> List
        List<Student> _student = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }
        List<decimal> lstProfit = new List<decimal>(); //Creat a list lstProfit
        private static int i;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            lstProfit.Add(Convert.ToDecimal(textBoxGrade.Text)); //Add value to list entered by the use

            textBoxMax.Text = lstProfit.Max().ToString(); //Get Max value form the list and assign to textboxMax
            textBoxMin.Text = lstProfit.Min().ToString(); //Get Min value form the list and assign to textboxMax
            //get value from textbox
            String name = this.textBoxName.Text;
            String year = this.textBoxBirthYear.Text;
            String id = this.textBoxId.Text;
            String height = this.textBoxHeight.Text;
            String grade = this.textBoxGrade.Text;
            String major = this.textBoxMajor.Text;
            //convert string to int
            int iYear = Int32.Parse(year);

            //creat obj from Student
            Student newStudent = new Student(name, iYear, id, height, grade, major);
            //Add new student to list
            this._student.Add(newStudent);

            //clear textbox
            this.textBoxName.Text = "";
            this.textBoxBirthYear.Text = "";
            this.textBoxId.Text = "";
            this.textBoxHeight.Text = "";
            this.textBoxGrade.Text = "";
            this.textBoxMajor.Text = "";


            //add data to DataGridView
            BindingSource source = new BindingSource();
            source.DataSource = this._student;
            this.dataGridView1.DataSource = source;

            i++; //+1 allpeople
            textBoxAllperson.Text = i.ToString(); //same up
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}