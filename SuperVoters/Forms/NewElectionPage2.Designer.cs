
namespace SuperVoters.Forms
{
    partial class NewElectionPage2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewElectionPage2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addCandiBth = new System.Windows.Forms.Button();
            this.logOutBth = new System.Windows.Forms.Button();
            this.viewResultBth = new System.Windows.Forms.Button();
            this.addElecBth = new System.Windows.Forms.Button();
            this.deleteElecBth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveCanToElecBth = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.addCandiBth);
            this.groupBox1.Controls.Add(this.logOutBth);
            this.groupBox1.Controls.Add(this.viewResultBth);
            this.groupBox1.Controls.Add(this.addElecBth);
            this.groupBox1.Controls.Add(this.deleteElecBth);
            this.groupBox1.Location = new System.Drawing.Point(34, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 516);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECTION PANEL";
            // 
            // addCandiBth
            // 
            this.addCandiBth.Location = new System.Drawing.Point(18, 118);
            this.addCandiBth.Name = "addCandiBth";
            this.addCandiBth.Size = new System.Drawing.Size(143, 30);
            this.addCandiBth.TabIndex = 5;
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
            // viewResultBth
            // 
            this.viewResultBth.Location = new System.Drawing.Point(18, 310);
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
            this.addElecBth.Location = new System.Drawing.Point(18, 181);
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
            this.deleteElecBth.Location = new System.Drawing.Point(18, 245);
            this.deleteElecBth.Name = "deleteElecBth";
            this.deleteElecBth.Size = new System.Drawing.Size(143, 30);
            this.deleteElecBth.TabIndex = 0;
            this.deleteElecBth.TabStop = false;
            this.deleteElecBth.Text = "Delete Election";
            this.deleteElecBth.UseVisualStyleBackColor = true;
            this.deleteElecBth.Click += new System.EventHandler(this.deleteElecBth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Election Page 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(230, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(923, 193);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step3: Select & Add Candidates To Election";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(911, 160);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.saveCanToElecBth);
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(230, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(923, 256);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Candidates Added To Election";
            // 
            // saveCanToElecBth
            // 
            this.saveCanToElecBth.Location = new System.Drawing.Point(737, 203);
            this.saveCanToElecBth.Name = "saveCanToElecBth";
            this.saveCanToElecBth.Size = new System.Drawing.Size(180, 30);
            this.saveCanToElecBth.TabIndex = 10;
            this.saveCanToElecBth.Text = "Save Candidates To Election";
            this.saveCanToElecBth.UseVisualStyleBackColor = true;
            this.saveCanToElecBth.Click += new System.EventHandler(this.saveCanToElecBth_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(911, 178);
            this.dataGridView2.TabIndex = 9;
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
            // NewElectionPage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewElectionPage2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewElectionPage2";
            this.Load += new System.EventHandler(this.NewElectionPage2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addCandiBth;
        private System.Windows.Forms.Button logOutBth;
        private System.Windows.Forms.Button viewResultBth;
        private System.Windows.Forms.Button addElecBth;
        private System.Windows.Forms.Button deleteElecBth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button saveCanToElecBth;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
    }
}