using System.DirectoryServices.ActiveDirectory;

namespace GUI26110603
{
    public partial class FrmMain : Form
    {

        const string FilePath = "..\\..\\..\\data\\save.txt";

        public FrmMain()
        {
            InitializeComponent();
            btnAddStudent.Click += BtnAddStudentClick;
            btnDeleteSelected.Click += BtnDeleteSelectedClick;
            btnDeleteAll.Click += BtnDeleteAllClick;
            this.FormClosing += FrmMainFormClosing;
            this.Load += FrmMainLoad;
        }

        private void FrmMainLoad(object? sender, EventArgs e)
        {
            using StreamReader sr = new(FilePath);
            while (!sr.EndOfStream)
            {
                lsxStudents.Items.Add(sr.ReadLine());
            }
            lblStudentCount.Text = $"diákok száma: {lsxStudents.Items.Count} fő";
        }

        private void FrmMainFormClosing(object? sender, FormClosingEventArgs e)
        {
            using StreamWriter sw = new(FilePath);
            foreach (var row in lsxStudents.Items)
            {
                sw.WriteLine(row);
            }
        }

        private void BtnDeleteAllClick(object? sender, EventArgs e)
        {
            lsxStudents.Items.Clear();
            lblStudentCount.Text = $"diákok száma: {lsxStudents.Items.Count} fő";
        }

        private void BtnDeleteSelectedClick(object? sender, EventArgs e)
        {
            lsxStudents.Items.Remove(lsxStudents.SelectedItem);
            lblStudentCount.Text = $"diákok száma: {lsxStudents.Items.Count} fő";
        }

        private void BtnAddStudentClick(object? sender, EventArgs e)
        {
            string newStudent = $"{txtName.Text} ({nudAge.Value}) [{cbxFieldOfStudy.SelectedItem}]";
            lsxStudents.Items.Add(newStudent);
            lblStudentCount.Text = $"diákok száma: {lsxStudents.Items.Count} fő";
        }
    }
}
