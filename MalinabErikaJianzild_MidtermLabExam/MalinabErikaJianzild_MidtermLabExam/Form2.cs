using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MalinabErikaJianzild_MidtermLabExam
{
    public partial class Form2 : Form
    {
        private readonly string MySqlCon = "server=127.0.0.1; user=root; database=studentinfodb; password=";
        private string StudentId;

        public Form2(string studentId)
        {
            InitializeComponent();
            StudentId = studentId;
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            using (MySqlConnection Connection = new MySqlConnection(MySqlCon))
            {
                try
                {
                    Connection.Open();
                    string query = @"SELECT 
                                    s.*,
                                    c.courseName,
                                    y.yearLvl,
                                    CONCAT(s.firstName, ' ', s.middleName, ' ', s.lastName) AS fullName,
                                    CONCAT(s.houseNo, ' ', s.brgyName, ', ', s.municipality, ', ', s.province, ', ', s.region, ', ', s.country) AS fullAddress,
                                    CONCAT(s.guardianFirstName, ' ', s.guardianLastName) AS guardianFullName
                                FROM studentrecordtb s
                                JOIN coursetb c ON s.courseId = c.courseId
                                JOIN yeartb y ON s.yearId = y.yearId
                                WHERE s.studentId = @studentId";

                    using (MySqlCommand Cmd = new MySqlCommand(query, Connection))
                    {
                        Cmd.Parameters.AddWithValue("@StudentId", StudentId);

                        using (MySqlDataReader Reader = Cmd.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                // Create labels dynamically using CreateDataLabel method
                                CreateDataLabel("lblStudentId", 400, 200, Reader["studentId"].ToString());
                                CreateDataLabel("lblFullName", 400, 267, Reader["fullName"].ToString());
                                CreateDataLabel("lblAddress", 400, 330, Reader["fullAddress"].ToString());
                                CreateDataLabel("lblBirthdate", 400, 392, Convert.ToDateTime(Reader["birthdate"]).ToString("MMMM dd, yyyy"));
                                CreateDataLabel("lblAge", 400, 459, Reader["age"].ToString());
                                CreateDataLabel("lblContactNo", 400, 520, Reader["studContactNo"].ToString());
                                CreateDataLabel("lblEmail", 400, 590, Reader["emailAddress"].ToString());
                                CreateDataLabel("lblGuardian", 400, 656, Reader["guardianFullName"].ToString());
                                CreateDataLabel("lblHobbies", 400, 724, Reader["hobbies"].ToString());
                                CreateDataLabel("lblNickname", 400, 788, Reader["nickname"].ToString());
                                CreateDataLabel("lblCourse", 400, 852, Reader["courseName"].ToString());
                                CreateDataLabel("lblYear", 400, 920, Reader["yearLvl"].ToString());
                            }
                            else
                            {
                                MessageBox.Show("No student record found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Error loading student details: {Ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to dynamically create labels and add them to the form
        private void CreateDataLabel(string name, int x, int y, string text)
        {
            Label lbl = new Label();
            lbl.Name = name;
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.AutoSize = true;

            // Set font size to 12 (or any size you want) and make it Bold
            lbl.Font = new System.Drawing.Font("Segoe Ui", 11, System.Drawing.FontStyle.Bold);

            this.Controls.Add(lbl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Close Form2
            this.Close();
        }
    }
}