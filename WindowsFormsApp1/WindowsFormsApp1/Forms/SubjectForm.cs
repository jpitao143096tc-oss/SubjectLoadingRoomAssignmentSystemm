using System;
using System.Windows.Forms;
using WindowsFormsApp1.Managers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms
{
    public partial class SubjectForm : Form
    {
        private SubjectManager subjectManager = new SubjectManager();
        private int selectedSubjectId = 0;

        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            dgvSubjects.DataSource = null;
            dgvSubjects.DataSource = subjectManager.GetAllSubjects();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtProgram.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            Subject subject = new Subject
            {
                Code = txtCode.Text.Trim(),
                Title = txtTitle.Text.Trim(),
                Units = (int)numUnits.Value,
                Program = txtProgram.Text.Trim()
            };

            subjectManager.AddSubject(subject);

            MessageBox.Show("Subject added successfully!");
            LoadSubjects();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == 0)
            {
                MessageBox.Show("Select a subject to update.");
                return;
            }

            Subject subject = new Subject
            {
                SubjectID = selectedSubjectId,
                Code = txtCode.Text.Trim(),
                Title = txtTitle.Text.Trim(),
                Units = (int)numUnits.Value,
                Program = txtProgram.Text.Trim()
            };

            subjectManager.UpdateSubject(subject);

            MessageBox.Show("Subject updated successfully!");
            LoadSubjects();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == 0)
            {
                MessageBox.Show("Select a subject to delete.");
                return;
            }

            subjectManager.DeleteSubject(selectedSubjectId);

            MessageBox.Show("Subject deleted successfully!");
            LoadSubjects();
            ClearInputs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSubjects.Rows[e.RowIndex];

                selectedSubjectId = Convert.ToInt32(row.Cells["SubjectID"].Value);
                txtCode.Text = row.Cells["SubjectCode"].Value.ToString();
                txtTitle.Text = row.Cells["Description"].Value.ToString();
                numUnits.Value = Convert.ToInt32(row.Cells["Units"].Value);
                txtProgram.Text = row.Cells["Program"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtCode.Clear();
            txtTitle.Clear();
            txtProgram.Clear();
            numUnits.Value = 1;
            selectedSubjectId = 0;
        }
    }
}
