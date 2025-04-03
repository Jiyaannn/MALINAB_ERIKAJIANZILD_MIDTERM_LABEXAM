using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MalinabErikaJianzild_MidtermLabExam
{
    public partial class Form1 : Form
    {
        private readonly string MySqlCon = "server=127.0.0.1; user=root; database=studentinfodb; password=";

        public Form1()
        {
            InitializeComponent();
            TestDatabaseConnection();
        }

        private void TestDatabaseConnection()
        {
            using (MySqlConnection Connection = new MySqlConnection(MySqlCon))
            {
                try
                {
                    Connection.Open();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Error: {Ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentRecords();
        }

        private void LoadStudentRecords()
        {
            using (MySqlConnection Connection = new MySqlConnection(MySqlCon))
            {
                try
                {
                    Connection.Open();
                    string Query = @"
                        SELECT StudentId, CONCAT(FirstName, ' ', MiddleName, ' ', LastName) AS FullName 
                        FROM StudentRecordTb 
                        ORDER BY StudentId";

                    using (MySqlCommand Cmd = new MySqlCommand(Query, Connection))
                    using (MySqlDataReader Reader = Cmd.ExecuteReader())
                    {
                        int YPos = 300;

                        while (Reader.Read())
                        {
                            string StudentId = Reader["StudentId"].ToString();
                            string FullName = Reader["FullName"].ToString();

                            // Create student ID label
                            Label StudentIdLbl = new Label
                            {
                                Text = StudentId,
                                Location = new System.Drawing.Point(130, YPos),
                                AutoSize = true
                            };
                            this.Controls.Add(StudentIdLbl);

                            // Create student full name label
                            Label StudentNameLbl = new Label
                            {
                                Text = FullName,
                                Location = new System.Drawing.Point(370, YPos),
                                AutoSize = true
                            };
                            this.Controls.Add(StudentNameLbl);

                            // Create view button
                            Button ViewBtn = new Button
                            {
                                Text = "View",
                                Name = $"ViewBtn_{StudentId}",
                                Location = new System.Drawing.Point(750, YPos),
                                Size = new System.Drawing.Size(60, 40),
                                Tag = StudentId,
                                 BackColor = System.Drawing.Color.LightYellow
                            };
                            ViewBtn.Click += ViewButton_Click;
                            this.Controls.Add(ViewBtn);

                            YPos += 100;
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Error loading student records: {Ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (sender is Button Btn && Btn.Tag is string StudentId)
            {
                try
                {
                    Form2 IndividualPage = new Form2(StudentId);
                    IndividualPage.Show();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Error opening student page: {Ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
