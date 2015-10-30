namespace WindowsFormsApplication13_1
{
    partial class IrvineHotel
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rBStand = new System.Windows.Forms.RadioButton();
            this.rBSuite = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cBView = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chBRef = new System.Windows.Forms.CheckBox();
            this.chBKit = new System.Windows.Forms.CheckBox();
            this.chBWine = new System.Windows.Forms.CheckBox();
            this.bSubmit = new System.Windows.Forms.Button();
            this.bQuit = new System.Windows.Forms.Button();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBCredit = new System.Windows.Forms.TextBox();
            this.dTArrival = new System.Windows.Forms.DateTimePicker();
            this.dTDeparture = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arrival Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Paypal or Credit Card #:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departure Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Room Type";
            // 
            // rBStand
            // 
            this.rBStand.AutoSize = true;
            this.rBStand.Location = new System.Drawing.Point(90, 189);
            this.rBStand.Name = "rBStand";
            this.rBStand.Size = new System.Drawing.Size(68, 17);
            this.rBStand.TabIndex = 6;
            this.rBStand.TabStop = true;
            this.rBStand.Text = "Standard";
            this.rBStand.UseVisualStyleBackColor = true;
            // 
            // rBSuite
            // 
            this.rBSuite.AutoSize = true;
            this.rBSuite.Location = new System.Drawing.Point(213, 189);
            this.rBSuite.Name = "rBSuite";
            this.rBSuite.Size = new System.Drawing.Size(49, 17);
            this.rBSuite.TabIndex = 7;
            this.rBSuite.TabStop = true;
            this.rBSuite.Text = "Suite";
            this.rBSuite.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "View";
            // 
            // cBView
            // 
            this.cBView.FormattingEnabled = true;
            this.cBView.Items.AddRange(new object[] {
            "Courtyard View",
            "Ocean View",
            "Mountain View"});
            this.cBView.Location = new System.Drawing.Point(213, 213);
            this.cBView.Name = "cBView";
            this.cBView.Size = new System.Drawing.Size(121, 21);
            this.cBView.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Addition amenities:";
            // 
            // chBRef
            // 
            this.chBRef.AutoSize = true;
            this.chBRef.Location = new System.Drawing.Point(213, 250);
            this.chBRef.Name = "chBRef";
            this.chBRef.Size = new System.Drawing.Size(115, 17);
            this.chBRef.TabIndex = 11;
            this.chBRef.Text = "Luxury Refrigerator";
            this.chBRef.UseVisualStyleBackColor = true;
            // 
            // chBKit
            // 
            this.chBKit.AutoSize = true;
            this.chBKit.Location = new System.Drawing.Point(213, 274);
            this.chBKit.Name = "chBKit";
            this.chBKit.Size = new System.Drawing.Size(62, 17);
            this.chBKit.TabIndex = 12;
            this.chBKit.Text = "Kitchen";
            this.chBKit.UseVisualStyleBackColor = true;
            // 
            // chBWine
            // 
            this.chBWine.AutoSize = true;
            this.chBWine.Location = new System.Drawing.Point(213, 298);
            this.chBWine.Name = "chBWine";
            this.chBWine.Size = new System.Drawing.Size(70, 17);
            this.chBWine.TabIndex = 13;
            this.chBWine.Text = "Wine Bar";
            this.chBWine.UseVisualStyleBackColor = true;
            // 
            // bSubmit
            // 
            this.bSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.Location = new System.Drawing.Point(119, 326);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 23);
            this.bSubmit.TabIndex = 14;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // bQuit
            // 
            this.bQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuit.Location = new System.Drawing.Point(238, 326);
            this.bQuit.Name = "bQuit";
            this.bQuit.Size = new System.Drawing.Size(75, 23);
            this.bQuit.TabIndex = 15;
            this.bQuit.Text = "Quit";
            this.bQuit.UseVisualStyleBackColor = true;
            this.bQuit.Click += new System.EventHandler(this.bQuit_Click);
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(213, 62);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(100, 20);
            this.tBName.TabIndex = 16;
            // 
            // tBCredit
            // 
            this.tBCredit.Location = new System.Drawing.Point(213, 89);
            this.tBCredit.Name = "tBCredit";
            this.tBCredit.Size = new System.Drawing.Size(100, 20);
            this.tBCredit.TabIndex = 17;
            // 
            // dTArrival
            // 
            this.dTArrival.Location = new System.Drawing.Point(213, 116);
            this.dTArrival.Name = "dTArrival";
            this.dTArrival.Size = new System.Drawing.Size(200, 20);
            this.dTArrival.TabIndex = 18;
            // 
            // dTDeparture
            // 
            this.dTDeparture.Location = new System.Drawing.Point(213, 144);
            this.dTDeparture.Name = "dTDeparture";
            this.dTDeparture.Size = new System.Drawing.Size(200, 20);
            this.dTDeparture.TabIndex = 19;
            // 
            // IrvineHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 361);
            this.Controls.Add(this.dTDeparture);
            this.Controls.Add(this.dTArrival);
            this.Controls.Add(this.tBCredit);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.bQuit);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.chBWine);
            this.Controls.Add(this.chBKit);
            this.Controls.Add(this.chBRef);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rBSuite);
            this.Controls.Add(this.rBStand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IrvineHotel";
            this.Text = "Irvine Hotel";
            this.Load += new System.EventHandler(this.IrvineHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rBStand;
        private System.Windows.Forms.RadioButton rBSuite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chBRef;
        private System.Windows.Forms.CheckBox chBKit;
        private System.Windows.Forms.CheckBox chBWine;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bQuit;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBCredit;
        private System.Windows.Forms.DateTimePicker dTArrival;
        private System.Windows.Forms.DateTimePicker dTDeparture;
    }
}

