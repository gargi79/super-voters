
namespace SuperVoters.Forms
{
    partial class VoteResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoteResults));
            this.label1 = new System.Windows.Forms.Label();
            this.Messages = new System.Windows.Forms.TextBox();
            this.ElectionNames = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridVotingResults = new System.Windows.Forms.DataGridView();
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVotingResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voting Results";
            // 
            // Messages
            // 
            this.Messages.Location = new System.Drawing.Point(511, 500);
            this.Messages.MinimumSize = new System.Drawing.Size(20, 20);
            this.Messages.Multiline = true;
            this.Messages.Name = "Messages";
            this.Messages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Messages.Size = new System.Drawing.Size(254, 37);
            this.Messages.TabIndex = 19;
            this.Messages.Visible = false;
            // 
            // ElectionNames
            // 
            this.ElectionNames.FormattingEnabled = true;
            this.ElectionNames.Location = new System.Drawing.Point(430, 93);
            this.ElectionNames.Name = "ElectionNames";
            this.ElectionNames.Size = new System.Drawing.Size(412, 21);
            this.ElectionNames.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(862, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 27;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Election name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(32, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 516);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECTION PANEL";
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
            // dataGridVotingResults
            // 
            this.dataGridVotingResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVotingResults.Location = new System.Drawing.Point(483, 160);
            this.dataGridVotingResults.Name = "dataGridVotingResults";
            this.dataGridVotingResults.Size = new System.Drawing.Size(302, 288);
            this.dataGridVotingResults.TabIndex = 55;
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.Location = new System.Drawing.Point(12, 17);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(75, 23);
            this.GoBackBtn.TabIndex = 56;
            this.GoBackBtn.Text = "< Go Back";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(23, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 31);
            this.button2.TabIndex = 56;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VoteResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.GoBackBtn);
            this.Controls.Add(this.dataGridVotingResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ElectionNames);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.label1);
            this.Name = "VoteResults";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VoteResults_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVotingResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Messages;
        private System.Windows.Forms.ComboBox ElectionNames;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridVotingResults;
        private System.Windows.Forms.Button GoBackBtn;
        private System.Windows.Forms.Button button2;
    }
}