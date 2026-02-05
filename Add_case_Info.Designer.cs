namespace project
{
    partial class Add_case_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.caseName = new System.Windows.Forms.TextBox();
            this.caseID = new System.Windows.Forms.TextBox();
            this.CaseDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CasePlace = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.CourtID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGen = new System.Windows.Forms.ComboBox();
            this.Statecmb = new System.Windows.Forms.ComboBox();
            this.dobtxt = new System.Windows.Forms.DateTimePicker();
            this.Lastnametxt = new System.Windows.Forms.TextBox();
            this.firstNametxt = new System.Windows.Forms.TextBox();
            this.acc_id = new System.Windows.Forms.TextBox();
            this.addrtxt = new System.Windows.Forms.TextBox();
            this.caseType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Koufi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Case Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(3, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Case ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Wheat;
            this.label4.Location = new System.Drawing.Point(-1, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Case Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Wheat;
            this.label5.Location = new System.Drawing.Point(0, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Case Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Wheat;
            this.label6.Location = new System.Drawing.Point(3, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Court ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // caseName
            // 
            this.caseName.Location = new System.Drawing.Point(111, 272);
            this.caseName.Name = "caseName";
            this.caseName.Size = new System.Drawing.Size(108, 20);
            this.caseName.TabIndex = 9;
            // 
            // caseID
            // 
            this.caseID.Location = new System.Drawing.Point(110, 225);
            this.caseID.Name = "caseID";
            this.caseID.Size = new System.Drawing.Size(108, 20);
            this.caseID.TabIndex = 10;
            this.caseID.Text = " ";
            this.caseID.TextChanged += new System.EventHandler(this.caseID_TextChanged);
            // 
            // CaseDate
            // 
            this.CaseDate.CustomFormat = "dd-MMM-yy";
            this.CaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CaseDate.Location = new System.Drawing.Point(110, 322);
            this.CaseDate.Name = "CaseDate";
            this.CaseDate.Size = new System.Drawing.Size(108, 20);
            this.CaseDate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Wheat;
            this.label7.Location = new System.Drawing.Point(-1, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.Wheat;
            this.label8.Location = new System.Drawing.Point(-1, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Case Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.Wheat;
            this.label9.Location = new System.Drawing.Point(-1, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Case Place";
            // 
            // CasePlace
            // 
            this.CasePlace.Location = new System.Drawing.Point(110, 372);
            this.CasePlace.Name = "CasePlace";
            this.CasePlace.Size = new System.Drawing.Size(108, 20);
            this.CasePlace.TabIndex = 17;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(110, 478);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(108, 20);
            this.desc.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Wheat;
            this.button5.Location = new System.Drawing.Point(207, 537);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 42);
            this.button5.TabIndex = 20;
            this.button5.Text = "Insert";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CourtID
            // 
            this.CourtID.FormattingEnabled = true;
            this.CourtID.Location = new System.Drawing.Point(112, 168);
            this.CourtID.Name = "CourtID";
            this.CourtID.Size = new System.Drawing.Size(107, 21);
            this.CourtID.TabIndex = 21;
            this.CourtID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.Wheat;
            this.label10.Location = new System.Drawing.Point(288, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Accused  ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.Wheat;
            this.label11.Location = new System.Drawing.Point(294, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Adderess";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.Color.Wheat;
            this.label12.Location = new System.Drawing.Point(294, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Gender";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Wheat;
            this.label13.Location = new System.Drawing.Point(294, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "Date of Birth";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.Wheat;
            this.label14.Location = new System.Drawing.Point(294, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 25);
            this.label14.TabIndex = 27;
            this.label14.Text = "Last Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.Color.Wheat;
            this.label15.Location = new System.Drawing.Point(292, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 25);
            this.label15.TabIndex = 28;
            this.label15.Text = "First Name";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Koufi", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Wheat;
            this.label3.Location = new System.Drawing.Point(298, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Accused State\r\n";
            // 
            // cmbGen
            // 
            this.cmbGen.FormattingEnabled = true;
            this.cmbGen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGen.Location = new System.Drawing.Point(437, 372);
            this.cmbGen.Name = "cmbGen";
            this.cmbGen.Size = new System.Drawing.Size(107, 21);
            this.cmbGen.TabIndex = 31;
            // 
            // Statecmb
            // 
            this.Statecmb.FormattingEnabled = true;
            this.Statecmb.Items.AddRange(new object[] {
            "Have Judgment",
            "Not Judged Yet"});
            this.Statecmb.Location = new System.Drawing.Point(436, 478);
            this.Statecmb.Name = "Statecmb";
            this.Statecmb.Size = new System.Drawing.Size(108, 21);
            this.Statecmb.TabIndex = 32;
            // 
            // dobtxt
            // 
            this.dobtxt.CustomFormat = "dd-MMM-yy";
            this.dobtxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobtxt.Location = new System.Drawing.Point(437, 322);
            this.dobtxt.Name = "dobtxt";
            this.dobtxt.Size = new System.Drawing.Size(108, 20);
            this.dobtxt.TabIndex = 33;
            // 
            // Lastnametxt
            // 
            this.Lastnametxt.Location = new System.Drawing.Point(434, 272);
            this.Lastnametxt.Name = "Lastnametxt";
            this.Lastnametxt.Size = new System.Drawing.Size(108, 20);
            this.Lastnametxt.TabIndex = 34;
            this.Lastnametxt.Text = " ";
            // 
            // firstNametxt
            // 
            this.firstNametxt.Location = new System.Drawing.Point(433, 225);
            this.firstNametxt.Name = "firstNametxt";
            this.firstNametxt.Size = new System.Drawing.Size(111, 20);
            this.firstNametxt.TabIndex = 35;
            this.firstNametxt.Text = " ";
            // 
            // acc_id
            // 
            this.acc_id.Location = new System.Drawing.Point(436, 169);
            this.acc_id.Name = "acc_id";
            this.acc_id.Size = new System.Drawing.Size(108, 20);
            this.acc_id.TabIndex = 36;
            this.acc_id.Text = " ";
            // 
            // addrtxt
            // 
            this.addrtxt.Location = new System.Drawing.Point(436, 427);
            this.addrtxt.Name = "addrtxt";
            this.addrtxt.Size = new System.Drawing.Size(108, 20);
            this.addrtxt.TabIndex = 37;
            this.addrtxt.Text = " ";
            // 
            // caseType
            // 
            this.caseType.Location = new System.Drawing.Point(110, 427);
            this.caseType.Name = "caseType";
            this.caseType.Size = new System.Drawing.Size(108, 20);
            this.caseType.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::project.Properties.Resources.Hammer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 612);
            this.Controls.Add(this.addrtxt);
            this.Controls.Add(this.acc_id);
            this.Controls.Add(this.firstNametxt);
            this.Controls.Add(this.Lastnametxt);
            this.Controls.Add(this.dobtxt);
            this.Controls.Add(this.Statecmb);
            this.Controls.Add(this.cmbGen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CourtID);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.CasePlace);
            this.Controls.Add(this.caseType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CaseDate);
            this.Controls.Add(this.caseID);
            this.Controls.Add(this.caseName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Add Case Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox caseName;
        private System.Windows.Forms.TextBox caseID;
        private System.Windows.Forms.DateTimePicker CaseDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CasePlace;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox CourtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGen;
        private System.Windows.Forms.ComboBox Statecmb;
        private System.Windows.Forms.DateTimePicker dobtxt;
        private System.Windows.Forms.TextBox Lastnametxt;
        private System.Windows.Forms.TextBox firstNametxt;
        private System.Windows.Forms.TextBox acc_id;
        private System.Windows.Forms.TextBox addrtxt;
        private System.Windows.Forms.TextBox caseType;
    }
}