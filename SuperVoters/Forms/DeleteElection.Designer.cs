
namespace SuperVoters.Forms
{
    partial class DeleteElection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteElection));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addCandiBth = new System.Windows.Forms.Button();
            this.logOutBth = new System.Windows.Forms.Button();
            this.viewElecBth = new System.Windows.Forms.Button();
            this.addElecBth = new System.Windows.Forms.Button();
            this.deleteElecBth = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearBth2 = new System.Windows.Forms.Button();
            this.viewDateBth = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteAndSaveBth = new System.Windows.Forms.Button();
            this.electionDataSet = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clearBth1 = new System.Windows.Forms.Button();
            this.viewTopicBth = new System.Windows.Forms.Button();
            this.txtElecTopic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboElecCat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electionDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.addCandiBth);
            this.groupBox1.Controls.Add(this.logOutBth);
            this.groupBox1.Controls.Add(this.viewElecBth);
            this.groupBox1.Controls.Add(this.addElecBth);
            this.groupBox1.Controls.Add(this.deleteElecBth);
            this.groupBox1.Location = new System.Drawing.Point(34, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 547);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECTION PANEL";
            // 
            // addCandiBth
            // 
            this.addCandiBth.Location = new System.Drawing.Point(18, 124);
            this.addCandiBth.Name = "addCandiBth";
            this.addCandiBth.Size = new System.Drawing.Size(143, 30);
            this.addCandiBth.TabIndex = 4;
            this.addCandiBth.TabStop = false;
            this.addCandiBth.Text = "Add Candidate";
            this.addCandiBth.UseVisualStyleBackColor = true;
            this.addCandiBth.Click += new System.EventHandler(this.addCandiBth_Click);
            // 
            // logOutBth
            // 
            this.logOutBth.Location = new System.Drawing.Point(18, 375);
            this.logOutBth.Name = "logOutBth";
            this.logOutBth.Size = new System.Drawing.Size(143, 30);
            this.logOutBth.TabIndex = 3;
            this.logOutBth.TabStop = false;
            this.logOutBth.Text = "Log Out";
            this.logOutBth.UseVisualStyleBackColor = true;
            this.logOutBth.Click += new System.EventHandler(this.logOutBth_Click);
            // 
            // viewElecBth
            // 
            this.viewElecBth.Location = new System.Drawing.Point(18, 314);
            this.viewElecBth.Name = "viewElecBth";
            this.viewElecBth.Size = new System.Drawing.Size(143, 30);
            this.viewElecBth.TabIndex = 2;
            this.viewElecBth.TabStop = false;
            this.viewElecBth.Text = "View Election Result";
            this.viewElecBth.UseVisualStyleBackColor = true;
            this.viewElecBth.Click += new System.EventHandler(this.viewElecBth_Click);
            // 
            // addElecBth
            // 
            this.addElecBth.Location = new System.Drawing.Point(18, 189);
            this.addElecBth.Name = "addElecBth";
            this.addElecBth.Size = new System.Drawing.Size(143, 30);
            this.addElecBth.TabIndex = 1;
            this.addElecBth.TabStop = false;
            this.addElecBth.Text = "Add New Election";
            this.addElecBth.UseVisualStyleBackColor = true;
            this.addElecBth.Click += new System.EventHandler(this.addElecBth_Click);
            // 
            // deleteElecBth
            // 
            this.deleteElecBth.Location = new System.Drawing.Point(18, 253);
            this.deleteElecBth.Name = "deleteElecBth";
            this.deleteElecBth.Size = new System.Drawing.Size(143, 30);
            this.deleteElecBth.TabIndex = 0;
            this.deleteElecBth.TabStop = false;
            this.deleteElecBth.Text = "Delete Election";
            this.deleteElecBth.UseVisualStyleBackColor = true;
            this.deleteElecBth.Click += new System.EventHandler(this.deleteElecBth_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.deleteAndSaveBth);
            this.groupBox2.Controls.Add(this.electionDataSet);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(231, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(941, 547);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALL ELECTIONS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clearBth2);
            this.groupBox3.Controls.Add(this.viewDateBth);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(478, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 96);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATE TO DATE";
            // 
            // clearBth2
            // 
            this.clearBth2.Location = new System.Drawing.Point(351, 58);
            this.clearBth2.Name = "clearBth2";
            this.clearBth2.Size = new System.Drawing.Size(70, 23);
            this.clearBth2.TabIndex = 26;
            this.clearBth2.Text = "Clear";
            this.clearBth2.UseVisualStyleBackColor = true;
            this.clearBth2.Click += new System.EventHandler(this.clearBth2_Click);
            // 
            // viewDateBth
            // 
            this.viewDateBth.Location = new System.Drawing.Point(351, 25);
            this.viewDateBth.Name = "viewDateBth";
            this.viewDateBth.Size = new System.Drawing.Size(70, 23);
            this.viewDateBth.TabIndex = 25;
            this.viewDateBth.Text = "View";
            this.viewDateBth.UseVisualStyleBackColor = true;
            this.viewDateBth.Click += new System.EventHandler(this.viewDateBth_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(117, 58);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "To Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "From Date:";
            // 
            // deleteAndSaveBth
            // 
            this.deleteAndSaveBth.Location = new System.Drawing.Point(789, 501);
            this.deleteAndSaveBth.Name = "deleteAndSaveBth";
            this.deleteAndSaveBth.Size = new System.Drawing.Size(142, 30);
            this.deleteAndSaveBth.TabIndex = 14;
            this.deleteAndSaveBth.Text = "Delete and Save";
            this.deleteAndSaveBth.UseVisualStyleBackColor = true;
            this.deleteAndSaveBth.Click += new System.EventHandler(this.deleteAndSaveBth_Click);
            // 
            // electionDataSet
            // 
            this.electionDataSet.AllowUserToAddRows = false;
            this.electionDataSet.AllowUserToDeleteRows = false;
            this.electionDataSet.AllowUserToResizeColumns = false;
            this.electionDataSet.AllowUserToResizeRows = false;
            this.electionDataSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.electionDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.electionDataSet.Location = new System.Drawing.Point(13, 132);
            this.electionDataSet.Name = "electionDataSet";
            this.electionDataSet.ReadOnly = true;
            this.electionDataSet.Size = new System.Drawing.Size(922, 363);
            this.electionDataSet.TabIndex = 17;
            this.electionDataSet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.electionDataSet_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.clearBth1);
            this.groupBox4.Controls.Add(this.viewTopicBth);
            this.groupBox4.Controls.Add(this.txtElecTopic);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cboElecCat);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(13, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 96);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SEARCH HERE";
            // 
            // clearBth1
            // 
            this.clearBth1.Location = new System.Drawing.Point(357, 59);
            this.clearBth1.Name = "clearBth1";
            this.clearBth1.Size = new System.Drawing.Size(67, 23);
            this.clearBth1.TabIndex = 27;
            this.clearBth1.Text = "Clear";
            this.clearBth1.UseVisualStyleBackColor = true;
            this.clearBth1.Click += new System.EventHandler(this.clearBth1_Click);
            // 
            // viewTopicBth
            // 
            this.viewTopicBth.Location = new System.Drawing.Point(357, 28);
            this.viewTopicBth.Name = "viewTopicBth";
            this.viewTopicBth.Size = new System.Drawing.Size(67, 23);
            this.viewTopicBth.TabIndex = 26;
            this.viewTopicBth.Text = "View";
            this.viewTopicBth.UseVisualStyleBackColor = true;
            this.viewTopicBth.Click += new System.EventHandler(this.viewTopicBth_Click);
            // 
            // txtElecTopic
            // 
            this.txtElecTopic.Location = new System.Drawing.Point(157, 61);
            this.txtElecTopic.Name = "txtElecTopic";
            this.txtElecTopic.Size = new System.Drawing.Size(173, 20);
            this.txtElecTopic.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Search By Election Topic:";
            // 
            // cboElecCat
            // 
            this.cboElecCat.FormattingEnabled = true;
            this.cboElecCat.Location = new System.Drawing.Point(157, 29);
            this.cboElecCat.Name = "cboElecCat";
            this.cboElecCat.Size = new System.Drawing.Size(173, 21);
            this.cboElecCat.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search By Election Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delete Election";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(18, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 31);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DeleteElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "DeleteElection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteElection";
            this.Load += new System.EventHandler(this.DeleteElection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electionDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addCandiBth;
        private System.Windows.Forms.Button logOutBth;
        private System.Windows.Forms.Button viewElecBth;
        private System.Windows.Forms.Button addElecBth;
        private System.Windows.Forms.Button deleteElecBth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtElecTopic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboElecCat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteAndSaveBth;
        private System.Windows.Forms.DataGridView electionDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewDateBth;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button viewTopicBth;
        private System.Windows.Forms.Button clearBth2;
        private System.Windows.Forms.Button clearBth1;
        private System.Windows.Forms.Button button1;
    }
}