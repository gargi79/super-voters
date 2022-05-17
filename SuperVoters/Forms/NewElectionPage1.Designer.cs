
namespace SuperVoters.Forms
{
    partial class NewElectionPage1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewElectionPage1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addCandiBth = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.viewResultBth = new System.Windows.Forms.Button();
            this.addElecBth = new System.Windows.Forms.Button();
            this.deleteElecBth = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ElecCategoryList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ElecTopicText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addElectionBth = new System.Windows.Forms.Button();
            this.errorProviderForElecTopic = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.errorProviderForElecCat = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.confirmBth = new System.Windows.Forms.Button();
            this.ElectionList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForElecTopic)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForElecCat)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Election Page 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.addCandiBth);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.viewResultBth);
            this.groupBox1.Controls.Add(this.addElecBth);
            this.groupBox1.Controls.Add(this.deleteElecBth);
            this.groupBox1.Location = new System.Drawing.Point(39, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 516);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECTION PANEL";
            // 
            // addCandiBth
            // 
            this.addCandiBth.Location = new System.Drawing.Point(18, 81);
            this.addCandiBth.Name = "addCandiBth";
            this.addCandiBth.Size = new System.Drawing.Size(143, 30);
            this.addCandiBth.TabIndex = 5;
            this.addCandiBth.TabStop = false;
            this.addCandiBth.Text = "Add Candidate";
            this.addCandiBth.UseVisualStyleBackColor = true;
            this.addCandiBth.Click += new System.EventHandler(this.addCandiBth_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 30);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.logOutBth_Click);
            // 
            // viewResultBth
            // 
            this.viewResultBth.Location = new System.Drawing.Point(18, 273);
            this.viewResultBth.Name = "viewResultBth";
            this.viewResultBth.Size = new System.Drawing.Size(143, 30);
            this.viewResultBth.TabIndex = 2;
            this.viewResultBth.TabStop = false;
            this.viewResultBth.Text = "View Election Result";
            this.viewResultBth.UseVisualStyleBackColor = true;
            this.viewResultBth.Click += new System.EventHandler(this.viewResultBth_Click);
            // 
            // addElecBth
            // 
            this.addElecBth.Location = new System.Drawing.Point(18, 144);
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
            this.deleteElecBth.Location = new System.Drawing.Point(18, 208);
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
            this.groupBox2.Controls.Add(this.ElecCategoryList);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.EndDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.StartDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ElecTopicText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(252, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(920, 98);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step1: Create An Election";
            // 
            // ElecCategoryList
            // 
            this.ElecCategoryList.FormattingEnabled = true;
            this.ElecCategoryList.Location = new System.Drawing.Point(591, 20);
            this.ElecCategoryList.Name = "ElecCategoryList";
            this.ElecCategoryList.Size = new System.Drawing.Size(305, 21);
            this.ElecCategoryList.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Election Category:";
            // 
            // EndDate
            // 
            this.EndDate.CustomFormat = "yyyy-MM-dd";
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDate.Location = new System.Drawing.Point(591, 57);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(305, 20);
            this.EndDate.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "End Date:";
            // 
            // StartDate
            // 
            this.StartDate.CustomFormat = "yyyy-MM-dd";
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDate.Location = new System.Drawing.Point(94, 57);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(302, 20);
            this.StartDate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Start Date:";
            // 
            // ElecTopicText
            // 
            this.ElecTopicText.Location = new System.Drawing.Point(94, 21);
            this.ElecTopicText.Name = "ElecTopicText";
            this.ElecTopicText.Size = new System.Drawing.Size(302, 20);
            this.ElecTopicText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Election Topic:";
            // 
            // addElectionBth
            // 
            this.addElectionBth.Location = new System.Drawing.Point(820, 183);
            this.addElectionBth.Name = "addElectionBth";
            this.addElectionBth.Size = new System.Drawing.Size(83, 30);
            this.addElectionBth.TabIndex = 10;
            this.addElectionBth.Text = "Add";
            this.addElectionBth.UseVisualStyleBackColor = true;
            this.addElectionBth.Click += new System.EventHandler(this.addElectionBth_Click);
            // 
            // errorProviderForElecTopic
            // 
            this.errorProviderForElecTopic.ContainerControl = this;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.addElectionBth);
            this.groupBox5.Controls.Add(this.dataGridView3);
            this.groupBox5.Location = new System.Drawing.Point(252, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(920, 223);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Elections";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(24, 30);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView3.Size = new System.Drawing.Size(879, 138);
            this.dataGridView3.TabIndex = 0;
            // 
            // errorProviderForElecCat
            // 
            this.errorProviderForElecCat.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.confirmBth);
            this.groupBox3.Controls.Add(this.ElectionList);
            this.groupBox3.Location = new System.Drawing.Point(252, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(920, 197);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step2: Select An Election To Add Candidates";
            // 
            // confirmBth
            // 
            this.confirmBth.Location = new System.Drawing.Point(820, 38);
            this.confirmBth.Name = "confirmBth";
            this.confirmBth.Size = new System.Drawing.Size(83, 29);
            this.confirmBth.TabIndex = 1;
            this.confirmBth.Text = "Confirm";
            this.confirmBth.UseVisualStyleBackColor = true;
            this.confirmBth.Click += new System.EventHandler(this.confirmBth_Click);
            // 
            // ElectionList
            // 
            this.ElectionList.FormattingEnabled = true;
            this.ElectionList.Location = new System.Drawing.Point(114, 43);
            this.ElectionList.Name = "ElectionList";
            this.ElectionList.Size = new System.Drawing.Size(645, 21);
            this.ElectionList.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(18, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 31);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewElectionPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "NewElectionPage1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewElection";
            this.Load += new System.EventHandler(this.NewElection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForElecTopic)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForElecCat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addElecBth;
        private System.Windows.Forms.Button deleteElecBth;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button viewResultBth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ElecTopicText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ElecCategoryList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProviderForElecTopic;
        private System.Windows.Forms.Button addCandiBth;
        private System.Windows.Forms.Button addElectionBth;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ErrorProvider errorProviderForElecCat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button confirmBth;
        private System.Windows.Forms.ComboBox ElectionList;
        private System.Windows.Forms.Button button1;
    }
}