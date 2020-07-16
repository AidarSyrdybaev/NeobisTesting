using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deadline6SecondTry.Entities;

namespace Deadline6SecondTry.Forms.Create
{
    public partial class TeacherCreateForm : Form
    {
        private JsonDatabaseContext _jsonDatabaseContext;

        public TeacherCreateForm(JsonDatabaseContext jsonDatabaseContext)
        {
            _jsonDatabaseContext = jsonDatabaseContext;
            InformationFill();
            InitializeComponent();
        }

        private void StudentSelectBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void TeacherCreateForm_Load(object sender, EventArgs e)
        {
            var SelectedStudent = (Student) StudentsCmbBx.SelectedItem;
            var Student = _jsonDatabaseContext.Students.GetById(SelectedStudent.Id);
            var Human = _jsonDatabaseContext.Humans.GetById(Student.HumanId);
        }

        private void InformationFill()
        {
            var Students = _jsonDatabaseContext.Students.GetAll();
            foreach (var student in Students)
            {
                if (!_jsonDatabaseContext.Humans.GetById(student.HumanId).IsTeacher)
                {
                    StudentsCmbBx.Items.Add(student);
                }
            }
        }
    }
}
