
namespace SuperVoters.Forms
{
    partial class CastAVotePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CastAVotePage));
            this.GoBackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CandidateListView = new System.Windows.Forms.DataGridView();
            this.SelectedCandidatePictureBox = new System.Windows.Forms.PictureBox();
            this.SelectedCandidateName = new System.Windows.Forms.Label();
            this.SelectedCandidatePartyName = new System.Windows.Forms.Label();
            this.SelectedCandidateDesc = new System.Windows.Forms.Label();
            this.CastVoteBtn = new System.Windows.Forms.Button();
            this.ElectionSelectionCombo = new System.Windows.Forms.ComboBox();
            this.electionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superVotersDataSet = new SuperVoters.SuperVotersDataSet();
            this.SelectElectionLabel = new System.Windows.Forms.Label();
            this.electionTableAdapter = new SuperVoters.SuperVotersDataSetTableAdapters.ElectionTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CandidateListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCandidatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVotersDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoBackBtn
            // 
            this.GoBackBtn.Location = new System.Drawing.Point(13, 13);
            this.GoBackBtn.Name = "GoBackBtn";
            this.GoBackBtn.Size = new System.Drawing.Size(75, 23);
            this.GoBackBtn.TabIndex = 0;
            this.GoBackBtn.Text = "< Go Back";
            this.GoBackBtn.UseVisualStyleBackColor = true;
            this.GoBackBtn.Click += new System.EventHandler(this.GoBackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select A Candidate";
            // 
            // CandidateListView
            // 
            this.CandidateListView.AllowUserToAddRows = false;
            this.CandidateListView.AllowUserToDeleteRows = false;
            this.CandidateListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidateListView.Location = new System.Drawing.Point(261, 71);
            this.CandidateListView.MultiSelect = false;
            this.CandidateListView.Name = "CandidateListView";
            this.CandidateListView.ReadOnly = true;
            this.CandidateListView.Size = new System.Drawing.Size(599, 150);
            this.CandidateListView.TabIndex = 4;
            this.CandidateListView.SelectionChanged += new System.EventHandler(this.CandidateListView_SelectedIndexChanged);
            // 
            // SelectedCandidatePictureBox
            // 
            this.SelectedCandidatePictureBox.Location = new System.Drawing.Point(261, 237);
            this.SelectedCandidatePictureBox.Name = "SelectedCandidatePictureBox";
            this.SelectedCandidatePictureBox.Size = new System.Drawing.Size(100, 99);
            this.SelectedCandidatePictureBox.TabIndex = 5;
            this.SelectedCandidatePictureBox.TabStop = false;
            // 
            // SelectedCandidateName
            // 
            this.SelectedCandidateName.AutoSize = true;
            this.SelectedCandidateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedCandidateName.Location = new System.Drawing.Point(375, 237);
            this.SelectedCandidateName.Name = "SelectedCandidateName";
            this.SelectedCandidateName.Size = new System.Drawing.Size(128, 20);
            this.SelectedCandidateName.TabIndex = 6;
            this.SelectedCandidateName.Text = "Candidate Name";
            // 
            // SelectedCandidatePartyName
            // 
            this.SelectedCandidatePartyName.AutoSize = true;
            this.SelectedCandidatePartyName.Location = new System.Drawing.Point(375, 263);
            this.SelectedCandidatePartyName.Name = "SelectedCandidatePartyName";
            this.SelectedCandidatePartyName.Size = new System.Drawing.Size(82, 13);
            this.SelectedCandidatePartyName.TabIndex = 7;
            this.SelectedCandidatePartyName.Text = "Candidate Party";
            // 
            // SelectedCandidateDesc
            // 
            this.SelectedCandidateDesc.AutoSize = true;
            this.SelectedCandidateDesc.Location = new System.Drawing.Point(375, 282);
            this.SelectedCandidateDesc.Name = "SelectedCandidateDesc";
            this.SelectedCandidateDesc.Size = new System.Drawing.Size(83, 13);
            this.SelectedCandidateDesc.TabIndex = 7;
            this.SelectedCandidateDesc.Text = "Candidate Desc";
            // 
            // CastVoteBtn
            // 
            this.CastVoteBtn.Location = new System.Drawing.Point(708, 396);
            this.CastVoteBtn.Name = "CastVoteBtn";
            this.CastVoteBtn.Size = new System.Drawing.Size(75, 23);
            this.CastVoteBtn.TabIndex = 8;
            this.CastVoteBtn.Text = "Vote";
            this.CastVoteBtn.UseVisualStyleBackColor = true;
            this.CastVoteBtn.Click += new System.EventHandler(this.CastVoteBtn_Click);
            // 
            // ElectionSelectionCombo
            // 
            this.ElectionSelectionCombo.FormattingEnabled = true;
            this.ElectionSelectionCombo.Location = new System.Drawing.Point(261, 396);
            this.ElectionSelectionCombo.Name = "ElectionSelectionCombo";
            this.ElectionSelectionCombo.Size = new System.Drawing.Size(424, 21);
            this.ElectionSelectionCombo.TabIndex = 9;
            this.ElectionSelectionCombo.Visible = false;
            // 
            // electionBindingSource
            // 
            this.electionBindingSource.DataMember = "Election";
            this.electionBindingSource.DataSource = this.superVotersDataSet;
            // 
            // superVotersDataSet
            // 
            this.superVotersDataSet.DataSetName = "SuperVotersDataSet";
            this.superVotersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectElectionLabel
            // 
            this.SelectElectionLabel.AutoSize = true;
            this.SelectElectionLabel.Location = new System.Drawing.Point(261, 380);
            this.SelectElectionLabel.Name = "SelectElectionLabel";
            this.SelectElectionLabel.Size = new System.Drawing.Size(78, 13);
            this.SelectElectionLabel.TabIndex = 10;
            this.SelectElectionLabel.Text = "Select Election";
            this.SelectElectionLabel.Visible = false;
            // 
            // electionTableAdapter
            // 
            this.electionTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(13, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 516);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECTION PANEL";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(18, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 31);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 30);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CastAVotePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectElectionLabel);
            this.Controls.Add(this.ElectionSelectionCombo);
            this.Controls.Add(this.SelectedCandidateDesc);
            this.Controls.Add(this.CastVoteBtn);
            this.Controls.Add(this.SelectedCandidatePartyName);
            this.Controls.Add(this.SelectedCandidateName);
            this.Controls.Add(this.SelectedCandidatePictureBox);
            this.Controls.Add(this.CandidateListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoBackBtn);
            this.Name = "CastAVotePage";
            this.Text = "CastAVotePage";
            this.Load += new System.EventHandler(this.CastAVotePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CandidateListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCandidatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superVotersDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoBackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CandidateListView;
        private System.Windows.Forms.PictureBox SelectedCandidatePictureBox;
        private System.Windows.Forms.Label SelectedCandidateName;
        private System.Windows.Forms.Label SelectedCandidatePartyName;
        private System.Windows.Forms.Label SelectedCandidateDesc;
        private System.Windows.Forms.Button CastVoteBtn;
        private System.Windows.Forms.ComboBox ElectionSelectionCombo;
        private System.Windows.Forms.Label SelectElectionLabel;
        private SuperVotersDataSet superVotersDataSet;
        private System.Windows.Forms.BindingSource electionBindingSource;
        private SuperVotersDataSetTableAdapters.ElectionTableAdapter electionTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}