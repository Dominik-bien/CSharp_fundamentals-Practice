using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Day2
{
    public partial class AddEditStudentView : Form
    {

      

        private FileHelper<List<Student>> _fileHelper = new FileHelper<List<Student>>(Program.FilePath);

        private int _studentID;
        private Student _student; 
        public AddEditStudentView(int id = 0)
        {
            InitializeComponent();
            _studentID = id;

            getStudentData();

            tbFirstName.Select();

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var students = _fileHelper.DeserializeFromFile();

            if (_studentID != 0)
                students.RemoveAll(x => x.Id == _studentID);
            else
                AssignIdToNewStudent(students);
            
           AddNewUserToList(students);

            _fileHelper.SerializeToFile(students);
            Close();
        }

        private void AddNewUserToList(List<Student> students)
        {
            var student = new Student
            {
                Id = _studentID,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Math = tbMath.Text,
                Physics = tbPhysics.Text,
                Comments = rtbComments.Text,
                English = tbEnglish.Text
            };

            students.Add(student);
        }

        private void AssignIdToNewStudent(List<Student> students)
        {
            var studentsWithHighestId = students.OrderByDescending(x => x.Id).FirstOrDefault();

            _studentID = studentsWithHighestId == null ? 1 : studentsWithHighestId.Id + 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void getStudentData()
        {
            if (_studentID != 0)
            {
                Text = "Edit Student";
                var students = _fileHelper.DeserializeFromFile();
                var student = students.FirstOrDefault(x => x.Id == _studentID);

                if (student == null)
                    throw new Exception("no student with the specified ID");

                fillTextBoxes();

            }
        }

        private void fillTextBoxes()
        {
            tbID.Text = _student.Id.ToString();
            tbFirstName.Text = _student.FirstName;
            tbLastName.Text = _student.LastName;
            tbMath.Text = _student.Math;
            tbPhysics.Text = _student.Physics;
            rtbComments.Text = _student.Comments;
            tbEnglish.Text = _student.English;
        }
    
    }
}
