using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Day2
{
    public partial class Main : Form
    {


      

        private FileHelper<List<Student>> _fileHelper = new FileHelper<List<Student>>(Program.FilePath);

        public Main()
        {
            InitializeComponent();

            RefreshDiary();
            SetColumnsHeader();

        }

   
       private void SetColumnsHeader()
        {
            dgvDiary.Columns[0].HeaderText = "ID";
            dgvDiary.Columns[1].HeaderText = "First Name";
            dgvDiary.Columns[2].HeaderText = "Last Name";
            dgvDiary.Columns[3].HeaderText = "Comments";
            dgvDiary.Columns[4].HeaderText = "Math";
            dgvDiary.Columns[5].HeaderText = "Physics";
            dgvDiary.Columns[6].HeaderText = "English";
        }

        private void RefreshDiary()
        {
            var students = _fileHelper.DeserializeFromFile();

            dgvDiary.DataSource = students;
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditStudent = new AddEditStudentView();
            addEditStudent.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student, what you want to edit");
                return;
            }

            var addEditStudent = new AddEditStudentView(Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value));
            addEditStudent.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student, what you want to delete");
                return;
            }

            var selectedStudent = dgvDiary.SelectedRows[0];

            var confirmDelete = MessageBox.Show($"Do you want remove student " +
                $"{(selectedStudent.Cells[1].Value.ToString() + " " + selectedStudent.Cells[2].Value.ToString()).Trim()}",
                "Remove Student", MessageBoxButtons.OKCancel);

            if(confirmDelete == DialogResult.OK)
            {
                deleteStudent(Convert.ToInt32(selectedStudent.Cells[0].Value));
                RefreshDiary();
            }
        }

        private void deleteStudent(int id)
        {
            var students = _fileHelper.DeserializeFromFile();
            students.RemoveAll(x => x.Id == id);
            _fileHelper.SerializeToFile(students);
         
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDiary();
        }
    }
}
