
namespace SuperVoters.Forms
{
    partial class PendingElection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingElection));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_electionID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_enter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.electionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pending Election";
            // 
            // cb_electionID
            // 
            this.cb_electionID.FormattingEnabled = true;
            this.cb_electionID.Location = new System.Drawing.Point(344, 90);
            this.cb_electionID.Name = "cb_electionID";
            this.cb_electionID.Size = new System.Drawing.Size(404, 21);
            this.cb_electionID.TabIndex = 3;
            this.cb_electionID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_electionID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Election Name:";
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(516, 146);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(65, 23);
            this.button_enter.TabIndex = 5;
            this.button_enter.Text = "Enter";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 6;
            //this.label3.Text = "The election entered was: ";
            // 
            // electionLabel
            // 
            this.electionLabel.AutoSize = true;
            this.electionLabel.Location = new System.Drawing.Point(613, 226);
            this.electionLabel.Name = "electionLabel";
            this.electionLabel.Size = new System.Drawing.Size(13, 13);
            this.electionLabel.TabIndex = 7;
           // this.electionLabel.Text = "?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 516);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECTION PANEL";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(18, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 31);
            this.button1.TabIndex = 54;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 30);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 30);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Text = "View Election Result";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PendingElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.electionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_electionID);
            this.Controls.Add(this.label1);
            this.Name = "PendingElection";
            this.Text = "PendingElection";
            this.Load += new System.EventHandler(this.PendingElection_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_electionID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label electionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}