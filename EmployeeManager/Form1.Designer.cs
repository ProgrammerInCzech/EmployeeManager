
namespace EmployeeManager
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMinimized = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.ComBoxEmployee = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnExtract = new System.Windows.Forms.Button();
            this.LblDate = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.ComBoxLevel = new System.Windows.Forms.ComboBox();
            this.ComBoxJob = new System.Windows.Forms.ComboBox();
            this.TmrCheck = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblRequired2 = new System.Windows.Forms.Label();
            this.LblRequired1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblLevel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnMinimized);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Emploeyee Manager";
            // 
            // BtnMinimized
            // 
            this.BtnMinimized.FlatAppearance.BorderSize = 0;
            this.BtnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnMinimized.ForeColor = System.Drawing.Color.Black;
            this.BtnMinimized.Location = new System.Drawing.Point(819, 0);
            this.BtnMinimized.Name = "BtnMinimized";
            this.BtnMinimized.Size = new System.Drawing.Size(45, 34);
            this.BtnMinimized.TabIndex = 2;
            this.BtnMinimized.Text = "━";
            this.BtnMinimized.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Location = new System.Drawing.Point(869, -1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(45, 35);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "✕";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // ComBoxEmployee
            // 
            this.ComBoxEmployee.FormattingEnabled = true;
            this.ComBoxEmployee.Location = new System.Drawing.Point(46, 152);
            this.ComBoxEmployee.Name = "ComBoxEmployee";
            this.ComBoxEmployee.Size = new System.Drawing.Size(121, 21);
            this.ComBoxEmployee.TabIndex = 1;
            this.ComBoxEmployee.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(315, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "ADD EMPLOYEE";
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.Location = new System.Drawing.Point(436, 318);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(86, 23);
            this.BtnAddEmployee.TabIndex = 8;
            this.BtnAddEmployee.Text = "Add";
            this.BtnAddEmployee.UseVisualStyleBackColor = true;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Employee";
            // 
            // BtnExtract
            // 
            this.BtnExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExtract.ForeColor = System.Drawing.Color.White;
            this.BtnExtract.Location = new System.Drawing.Point(11, 491);
            this.BtnExtract.Name = "BtnExtract";
            this.BtnExtract.Size = new System.Drawing.Size(75, 23);
            this.BtnExtract.TabIndex = 11;
            this.BtnExtract.Text = "EXTRACT";
            this.BtnExtract.UseVisualStyleBackColor = true;
            this.BtnExtract.Click += new System.EventHandler(this.BtnExtract_Click);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblDate.ForeColor = System.Drawing.Color.White;
            this.LblDate.Location = new System.Drawing.Point(780, 491);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(48, 24);
            this.LblDate.TabIndex = 12;
            this.LblDate.Text = "Date";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(320, 227);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 18;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(422, 227);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(100, 20);
            this.TxtSurname.TabIndex = 19;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(320, 271);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(202, 20);
            this.txtTitle.TabIndex = 20;
            // 
            // ComBoxLevel
            // 
            this.ComBoxLevel.FormattingEnabled = true;
            this.ComBoxLevel.Items.AddRange(new object[] {
            "Junior",
            "Middle",
            "Senior"});
            this.ComBoxLevel.Location = new System.Drawing.Point(320, 318);
            this.ComBoxLevel.Name = "ComBoxLevel";
            this.ComBoxLevel.Size = new System.Drawing.Size(110, 21);
            this.ComBoxLevel.TabIndex = 21;
            // 
            // ComBoxJob
            // 
            this.ComBoxJob.FormattingEnabled = true;
            this.ComBoxJob.Items.AddRange(new object[] {
            "Developer",
            "Aministrators",
            "IT support",
            "Others"});
            this.ComBoxJob.Location = new System.Drawing.Point(320, 166);
            this.ComBoxJob.Name = "ComBoxJob";
            this.ComBoxJob.Size = new System.Drawing.Size(202, 21);
            this.ComBoxJob.TabIndex = 22;
            // 
            // TmrCheck
            // 
            this.TmrCheck.Enabled = true;
            this.TmrCheck.Tick += new System.EventHandler(this.TmrCheck_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(320, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "POSITION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(320, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(419, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "SURNAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(320, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "TITLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(321, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "LEVEL";
            // 
            // LblRequired2
            // 
            this.LblRequired2.AutoSize = true;
            this.LblRequired2.ForeColor = System.Drawing.Color.BurlyWood;
            this.LblRequired2.Location = new System.Drawing.Point(528, 230);
            this.LblRequired2.Name = "LblRequired2";
            this.LblRequired2.Size = new System.Drawing.Size(64, 13);
            this.LblRequired2.TabIndex = 28;
            this.LblRequired2.Text = "REQUIRED";
            this.LblRequired2.Visible = false;
            // 
            // LblRequired1
            // 
            this.LblRequired1.AutoSize = true;
            this.LblRequired1.ForeColor = System.Drawing.Color.BurlyWood;
            this.LblRequired1.Location = new System.Drawing.Point(528, 169);
            this.LblRequired1.Name = "LblRequired1";
            this.LblRequired1.Size = new System.Drawing.Size(64, 13);
            this.LblRequired1.TabIndex = 29;
            this.LblRequired1.Text = "REQUIRED";
            this.LblRequired1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(632, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "MONEY PER MONTH";
            // 
            // LblLevel
            // 
            this.LblLevel.AutoSize = true;
            this.LblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblLevel.ForeColor = System.Drawing.Color.White;
            this.LblLevel.Location = new System.Drawing.Point(633, 158);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(16, 24);
            this.LblLevel.TabIndex = 31;
            this.LblLevel.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(915, 526);
            this.Controls.Add(this.LblLevel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblRequired1);
            this.Controls.Add(this.LblRequired2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComBoxJob);
            this.Controls.Add(this.ComBoxLevel);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.BtnExtract);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnAddEmployee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComBoxEmployee);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMinimized;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComBoxEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnExtract;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox ComBoxLevel;
        private System.Windows.Forms.ComboBox ComBoxJob;
        private System.Windows.Forms.Timer TmrCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblRequired2;
        private System.Windows.Forms.Label LblRequired1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblLevel;
    }
}

