namespace SuperVoters
{
    partial class CandidateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateForm));
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.partyTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addCandiBth = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addElecBth = new System.Windows.Forms.Button();
            this.deleteElecBth = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(936, 509);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(89, 33);
            this.removeButton.TabIndex = 45;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(729, 509);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 33);
            this.addButton.TabIndex = 44;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(361, 249);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(189, 20);
            this.descriptionTextBox.TabIndex = 47;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(592, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(571, 405);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(361, 210);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(189, 20);
            this.addressTextBox.TabIndex = 41;
            // 
            // partyTextBox
            // 
            this.partyTextBox.Location = new System.Drawing.Point(361, 132);
            this.partyTextBox.Name = "partyTextBox";
            this.partyTextBox.Size = new System.Drawing.Size(189, 20);
            this.partyTextBox.TabIndex = 40;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(361, 171);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(189, 20);
            this.numberTextBox.TabIndex = 39;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(361, 93);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(189, 20);
            this.nameTextBox.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(260, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Description : *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Address : *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(260, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Party : *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Phone Num# : *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Candidate Name : *";
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(386, 509);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(131, 33);
            this.uploadButton.TabIndex = 50;
            this.uploadButton.Text = "Upload Pic";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 32);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "Add Candidate ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.addCandiBth);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.addElecBth);
            this.groupBox1.Controls.Add(this.deleteElecBth);
            this.groupBox1.Location = new System.Drawing.Point(21, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 516);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECTION PANEL";
            // 
            // addCandiBth
            // 
            this.addCandiBth.Location = new System.Drawing.Point(18, 103);
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
            this.button4.Location = new System.Drawing.Point(18, 365);
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
            this.button3.Location = new System.Drawing.Point(18, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 30);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Text = "View Election Result";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addElecBth
            // 
            this.addElecBth.Location = new System.Drawing.Point(18, 166);
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
            this.deleteElecBth.Location = new System.Drawing.Point(18, 230);
            this.deleteElecBth.Name = "deleteElecBth";
            this.deleteElecBth.Size = new System.Drawing.Size(143, 30);
            this.deleteElecBth.TabIndex = 0;
            this.deleteElecBth.TabStop = false;
            this.deleteElecBth.Text = "Delete Election";
            this.deleteElecBth.UseVisualStyleBackColor = true;
            this.deleteElecBth.Click += new System.EventHandler(this.deleteElecBth_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Upload An Image:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SuperVoters.Properties.Resources.defaultimage;
            this.pictureBox1.Location = new System.Drawing.Point(361, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // CandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.partyTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "CandidateForm";
            this.Text = "CandidateForm";
            this.Load += new System.EventHandler(this.CandidateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox partyTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addCandiBth;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addElecBth;
        private System.Windows.Forms.Button deleteElecBth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}