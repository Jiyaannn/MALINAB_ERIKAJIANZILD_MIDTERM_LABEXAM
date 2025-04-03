namespace MalinabErikaJianzild_MidtermLabExam
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
            studRecord = new Label();
            studno = new Label();
            name = new Label();
            SuspendLayout();
            // 
            // studRecord
            // 
            studRecord.AutoSize = true;
            studRecord.FlatStyle = FlatStyle.Popup;
            studRecord.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            studRecord.Location = new Point(336, 88);
            studRecord.Name = "studRecord";
            studRecord.Size = new Size(281, 40);
            studRecord.TabIndex = 0;
            studRecord.Text = "Student Record";
            // 
            // studno
            // 
            studno.AutoSize = true;
            studno.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studno.Location = new Point(88, 193);
            studno.Name = "studno";
            studno.Size = new Size(168, 38);
            studno.TabIndex = 1;
            studno.Text = "Student No.";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(430, 193);
            name.Name = "name";
            name.Size = new Size(93, 38);
            name.TabIndex = 2;
            name.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 1050);
            Controls.Add(name);
            Controls.Add(studno);
            Controls.Add(studRecord);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studRecord;
        private Label studno;
        private Label name;
    }
}
