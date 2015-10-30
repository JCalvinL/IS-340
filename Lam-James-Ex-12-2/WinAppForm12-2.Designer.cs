namespace WindowsFormsApplication12_2
{
    partial class Main
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
            this.lPrice = new System.Windows.Forms.Label();
            this.lDown = new System.Windows.Forms.Label();
            this.lDuration = new System.Windows.Forms.Label();
            this.lInterest = new System.Windows.Forms.Label();
            this.lPayment = new System.Windows.Forms.Label();
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.tBDown = new System.Windows.Forms.TextBox();
            this.tBDuration = new System.Windows.Forms.TextBox();
            this.tBInterest = new System.Windows.Forms.TextBox();
            this.tBPayment = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bCalculate = new System.Windows.Forms.Button();
            this.bQuit = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mortgage Payment Calculator";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(129, 60);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(65, 13);
            this.lPrice.TabIndex = 1;
            this.lPrice.Text = "House Price";
            // 
            // lDown
            // 
            this.lDown.AutoSize = true;
            this.lDown.Location = new System.Drawing.Point(129, 96);
            this.lDown.Name = "lDown";
            this.lDown.Size = new System.Drawing.Size(79, 13);
            this.lDown.TabIndex = 2;
            this.lDown.Text = "Down Payment";
            // 
            // lDuration
            // 
            this.lDuration.AutoSize = true;
            this.lDuration.Location = new System.Drawing.Point(129, 132);
            this.lDuration.Name = "lDuration";
            this.lDuration.Size = new System.Drawing.Size(74, 13);
            this.lDuration.TabIndex = 3;
            this.lDuration.Text = "Loan Duration";
            // 
            // lInterest
            // 
            this.lInterest.AutoSize = true;
            this.lInterest.Location = new System.Drawing.Point(129, 167);
            this.lInterest.Name = "lInterest";
            this.lInterest.Size = new System.Drawing.Size(78, 13);
            this.lInterest.TabIndex = 4;
            this.lInterest.Text = "Annual Interest";
            // 
            // lPayment
            // 
            this.lPayment.AutoSize = true;
            this.lPayment.Location = new System.Drawing.Point(150, 269);
            this.lPayment.Name = "lPayment";
            this.lPayment.Size = new System.Drawing.Size(88, 13);
            this.lPayment.TabIndex = 5;
            this.lPayment.Text = "Monthly Payment";
            this.lPayment.Visible = false;
            // 
            // tBPrice
            // 
            this.tBPrice.Location = new System.Drawing.Point(272, 57);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(100, 20);
            this.tBPrice.TabIndex = 6;
            // 
            // tBDown
            // 
            this.tBDown.Location = new System.Drawing.Point(272, 89);
            this.tBDown.Name = "tBDown";
            this.tBDown.Size = new System.Drawing.Size(100, 20);
            this.tBDown.TabIndex = 7;
            // 
            // tBDuration
            // 
            this.tBDuration.Location = new System.Drawing.Point(272, 125);
            this.tBDuration.Name = "tBDuration";
            this.tBDuration.Size = new System.Drawing.Size(100, 20);
            this.tBDuration.TabIndex = 8;
            // 
            // tBInterest
            // 
            this.tBInterest.Location = new System.Drawing.Point(272, 159);
            this.tBInterest.Name = "tBInterest";
            this.tBInterest.Size = new System.Drawing.Size(100, 20);
            this.tBInterest.TabIndex = 9;
            // 
            // tBPayment
            // 
            this.tBPayment.Location = new System.Drawing.Point(272, 266);
            this.tBPayment.Name = "tBPayment";
            this.tBPayment.ReadOnly = true;
            this.tBPayment.Size = new System.Drawing.Size(100, 20);
            this.tBPayment.TabIndex = 10;
            this.tBPayment.Visible = false;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResult.Location = new System.Drawing.Point(222, 233);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(61, 20);
            this.lResult.TabIndex = 11;
            this.lResult.Text = "Result";
            this.lResult.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // bCalculate
            // 
            this.bCalculate.Location = new System.Drawing.Point(175, 195);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(75, 23);
            this.bCalculate.TabIndex = 13;
            this.bCalculate.Text = "Calculate";
            this.bCalculate.UseVisualStyleBackColor = true;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // bQuit
            // 
            this.bQuit.Location = new System.Drawing.Point(256, 195);
            this.bQuit.Name = "bQuit";
            this.bQuit.Size = new System.Drawing.Size(75, 23);
            this.bQuit.TabIndex = 14;
            this.bQuit.Text = "Quit";
            this.bQuit.UseVisualStyleBackColor = true;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 405);
            this.Controls.Add(this.bQuit);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.tBPayment);
            this.Controls.Add(this.tBInterest);
            this.Controls.Add(this.tBDuration);
            this.Controls.Add(this.tBDown);
            this.Controls.Add(this.tBPrice);
            this.Controls.Add(this.lPayment);
            this.Controls.Add(this.lInterest);
            this.Controls.Add(this.lDuration);
            this.Controls.Add(this.lDown);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lDown;
        private System.Windows.Forms.Label lDuration;
        private System.Windows.Forms.Label lInterest;
        private System.Windows.Forms.Label lPayment;
        private System.Windows.Forms.TextBox tBPrice;
        private System.Windows.Forms.TextBox tBDown;
        private System.Windows.Forms.TextBox tBDuration;
        private System.Windows.Forms.TextBox tBInterest;
        private System.Windows.Forms.TextBox tBPayment;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.Button bQuit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
    }
}

