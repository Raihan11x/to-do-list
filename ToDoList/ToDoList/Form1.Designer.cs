namespace ToDoList
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
            this.Daily = new System.Windows.Forms.GroupBox();
            this.lblDaily = new System.Windows.Forms.Label();
            this.cbEmails = new System.Windows.Forms.CheckBox();
            this.cbRemaining = new System.Windows.Forms.CheckBox();
            this.cbBreakfast = new System.Windows.Forms.CheckBox();
            this.cbBrush = new System.Windows.Forms.CheckBox();
            this.cbPrayer = new System.Windows.Forms.CheckBox();
            this.cbCode = new System.Windows.Forms.CheckBox();
            this.Once = new System.Windows.Forms.GroupBox();
            this.lblOnce = new System.Windows.Forms.Label();
            this.cbProjects = new System.Windows.Forms.CheckBox();
            this.cbLaundry = new System.Windows.Forms.CheckBox();
            this.cbFamily = new System.Windows.Forms.CheckBox();
            this.cbHouse = new System.Windows.Forms.CheckBox();
            this.cbGrocery = new System.Windows.Forms.CheckBox();
            this.cbRoom = new System.Windows.Forms.CheckBox();
            this.Twice = new System.Windows.Forms.GroupBox();
            this.lblTwice = new System.Windows.Forms.Label();
            this.cbGraveyard = new System.Windows.Forms.CheckBox();
            this.cbFootball = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Daily.SuspendLayout();
            this.Once.SuspendLayout();
            this.Twice.SuspendLayout();
            this.SuspendLayout();
            // 
            // Daily
            // 
            this.Daily.Controls.Add(this.lblDaily);
            this.Daily.Controls.Add(this.cbEmails);
            this.Daily.Controls.Add(this.cbRemaining);
            this.Daily.Controls.Add(this.cbBreakfast);
            this.Daily.Controls.Add(this.cbBrush);
            this.Daily.Controls.Add(this.cbPrayer);
            this.Daily.Controls.Add(this.cbCode);
            this.Daily.Location = new System.Drawing.Point(12, 12);
            this.Daily.Name = "Daily";
            this.Daily.Size = new System.Drawing.Size(276, 355);
            this.Daily.TabIndex = 0;
            this.Daily.TabStop = false;
            this.Daily.Text = "To Do List: Daily";
            // 
            // lblDaily
            // 
            this.lblDaily.AutoSize = true;
            this.lblDaily.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDaily.Location = new System.Drawing.Point(22, 278);
            this.lblDaily.Name = "lblDaily";
            this.lblDaily.Size = new System.Drawing.Size(0, 32);
            this.lblDaily.TabIndex = 6;
            // 
            // cbEmails
            // 
            this.cbEmails.AutoSize = true;
            this.cbEmails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbEmails.Location = new System.Drawing.Point(6, 158);
            this.cbEmails.Name = "cbEmails";
            this.cbEmails.Size = new System.Drawing.Size(97, 19);
            this.cbEmails.TabIndex = 5;
            this.cbEmails.Text = "Check Emails";
            this.cbEmails.UseVisualStyleBackColor = true;
            // 
            // cbRemaining
            // 
            this.cbRemaining.AutoSize = true;
            this.cbRemaining.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbRemaining.Location = new System.Drawing.Point(6, 133);
            this.cbRemaining.Name = "cbRemaining";
            this.cbRemaining.Size = new System.Drawing.Size(156, 19);
            this.cbRemaining.TabIndex = 4;
            this.cbRemaining.Text = "Pray Remaining Prayers";
            this.cbRemaining.UseVisualStyleBackColor = true;
            // 
            // cbBreakfast
            // 
            this.cbBreakfast.AutoSize = true;
            this.cbBreakfast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbBreakfast.Location = new System.Drawing.Point(6, 83);
            this.cbBreakfast.Name = "cbBreakfast";
            this.cbBreakfast.Size = new System.Drawing.Size(80, 19);
            this.cbBreakfast.TabIndex = 3;
            this.cbBreakfast.Text = "Breakfast";
            this.cbBreakfast.UseVisualStyleBackColor = true;
            // 
            // cbBrush
            // 
            this.cbBrush.AutoSize = true;
            this.cbBrush.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbBrush.Location = new System.Drawing.Point(6, 58);
            this.cbBrush.Name = "cbBrush";
            this.cbBrush.Size = new System.Drawing.Size(93, 19);
            this.cbBrush.TabIndex = 2;
            this.cbBrush.Text = "Brush Teeth";
            this.cbBrush.UseVisualStyleBackColor = true;
            this.cbBrush.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbPrayer
            // 
            this.cbPrayer.AutoSize = true;
            this.cbPrayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbPrayer.Location = new System.Drawing.Point(6, 33);
            this.cbPrayer.Name = "cbPrayer";
            this.cbPrayer.Size = new System.Drawing.Size(143, 19);
            this.cbPrayer.TabIndex = 1;
            this.cbPrayer.Text = "Morning Prayer (Fajr)";
            this.cbPrayer.UseVisualStyleBackColor = true;
            // 
            // cbCode
            // 
            this.cbCode.AutoSize = true;
            this.cbCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbCode.Location = new System.Drawing.Point(6, 108);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(154, 19);
            this.cbCode.TabIndex = 0;
            this.cbCode.Text = "Practice Code (2 hours)";
            this.cbCode.UseVisualStyleBackColor = true;
            this.cbCode.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Once
            // 
            this.Once.Controls.Add(this.lblOnce);
            this.Once.Controls.Add(this.cbProjects);
            this.Once.Controls.Add(this.cbLaundry);
            this.Once.Controls.Add(this.cbFamily);
            this.Once.Controls.Add(this.cbHouse);
            this.Once.Controls.Add(this.cbGrocery);
            this.Once.Controls.Add(this.cbRoom);
            this.Once.Location = new System.Drawing.Point(294, 12);
            this.Once.Name = "Once";
            this.Once.Size = new System.Drawing.Size(278, 355);
            this.Once.TabIndex = 1;
            this.Once.TabStop = false;
            this.Once.Text = "To Do List: Once a Week";
            // 
            // lblOnce
            // 
            this.lblOnce.AutoSize = true;
            this.lblOnce.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblOnce.Location = new System.Drawing.Point(16, 280);
            this.lblOnce.Name = "lblOnce";
            this.lblOnce.Size = new System.Drawing.Size(0, 45);
            this.lblOnce.TabIndex = 6;
            // 
            // cbProjects
            // 
            this.cbProjects.AutoSize = true;
            this.cbProjects.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbProjects.Location = new System.Drawing.Point(6, 158);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(151, 19);
            this.cbProjects.TabIndex = 5;
            this.cbProjects.Text = "Work on New Projects";
            this.cbProjects.UseVisualStyleBackColor = true;
            // 
            // cbLaundry
            // 
            this.cbLaundry.AutoSize = true;
            this.cbLaundry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbLaundry.Location = new System.Drawing.Point(6, 133);
            this.cbLaundry.Name = "cbLaundry";
            this.cbLaundry.Size = new System.Drawing.Size(70, 19);
            this.cbLaundry.TabIndex = 4;
            this.cbLaundry.Text = "Laundry";
            this.cbLaundry.UseVisualStyleBackColor = true;
            // 
            // cbFamily
            // 
            this.cbFamily.AutoSize = true;
            this.cbFamily.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbFamily.Location = new System.Drawing.Point(6, 108);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(88, 19);
            this.cbFamily.TabIndex = 3;
            this.cbFamily.Text = "Visit Family";
            this.cbFamily.UseVisualStyleBackColor = true;
            // 
            // cbHouse
            // 
            this.cbHouse.AutoSize = true;
            this.cbHouse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbHouse.Location = new System.Drawing.Point(6, 83);
            this.cbHouse.Name = "cbHouse";
            this.cbHouse.Size = new System.Drawing.Size(116, 19);
            this.cbHouse.TabIndex = 2;
            this.cbHouse.Text = "Clean the House";
            this.cbHouse.UseVisualStyleBackColor = true;
            // 
            // cbGrocery
            // 
            this.cbGrocery.AutoSize = true;
            this.cbGrocery.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbGrocery.Location = new System.Drawing.Point(6, 58);
            this.cbGrocery.Name = "cbGrocery";
            this.cbGrocery.Size = new System.Drawing.Size(126, 19);
            this.cbGrocery.TabIndex = 1;
            this.cbGrocery.Text = "Grocery Shopping";
            this.cbGrocery.UseVisualStyleBackColor = true;
            // 
            // cbRoom
            // 
            this.cbRoom.AutoSize = true;
            this.cbRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbRoom.Location = new System.Drawing.Point(6, 33);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(111, 19);
            this.cbRoom.TabIndex = 0;
            this.cbRoom.Text = "Clean Bedroom";
            this.cbRoom.UseVisualStyleBackColor = true;
            // 
            // Twice
            // 
            this.Twice.Controls.Add(this.lblTwice);
            this.Twice.Controls.Add(this.cbGraveyard);
            this.Twice.Controls.Add(this.cbFootball);
            this.Twice.Location = new System.Drawing.Point(578, 12);
            this.Twice.Name = "Twice";
            this.Twice.Size = new System.Drawing.Size(210, 355);
            this.Twice.TabIndex = 2;
            this.Twice.TabStop = false;
            this.Twice.Text = "To Do List: Twice a Week";
            // 
            // lblTwice
            // 
            this.lblTwice.AutoSize = true;
            this.lblTwice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTwice.Location = new System.Drawing.Point(9, 278);
            this.lblTwice.Name = "lblTwice";
            this.lblTwice.Size = new System.Drawing.Size(0, 32);
            this.lblTwice.TabIndex = 2;
            // 
            // cbGraveyard
            // 
            this.cbGraveyard.AutoSize = true;
            this.cbGraveyard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbGraveyard.Location = new System.Drawing.Point(9, 48);
            this.cbGraveyard.Name = "cbGraveyard";
            this.cbGraveyard.Size = new System.Drawing.Size(111, 19);
            this.cbGraveyard.TabIndex = 1;
            this.cbGraveyard.Text = "Visit Graveyard";
            this.cbGraveyard.UseVisualStyleBackColor = true;
            // 
            // cbFootball
            // 
            this.cbFootball.AutoSize = true;
            this.cbFootball.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbFootball.Location = new System.Drawing.Point(9, 24);
            this.cbFootball.Name = "cbFootball";
            this.cbFootball.Size = new System.Drawing.Size(95, 19);
            this.cbFootball.TabIndex = 0;
            this.cbFootball.Text = "Play Football";
            this.cbFootball.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(170, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(445, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Twice);
            this.Controls.Add(this.Once);
            this.Controls.Add(this.Daily);
            this.Name = "Form1";
            this.Daily.ResumeLayout(false);
            this.Daily.PerformLayout();
            this.Once.ResumeLayout(false);
            this.Once.PerformLayout();
            this.Twice.ResumeLayout(false);
            this.Twice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Daily;
        private CheckBox cbBrush;
        private CheckBox cbPrayer;
        private CheckBox cbCode;
        private GroupBox Once;
        private GroupBox Twice;
        private CheckBox cbEmails;
        private CheckBox cbRemaining;
        private CheckBox cbBreakfast;
        private CheckBox cbFamily;
        private CheckBox cbHouse;
        private CheckBox cbGrocery;
        private CheckBox cbRoom;
        private CheckBox cbFootball;
        private Button button1;
        private Button button2;
        private CheckBox cbProjects;
        private CheckBox cbLaundry;
        private CheckBox cbGraveyard;
        private Label lblDaily;
        private Label lblOnce;
        private Label lblTwice;
    }
}