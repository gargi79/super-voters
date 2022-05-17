
namespace SuperVoters
{
    partial class VoterForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.mnameTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.dobTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name : *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middle Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name : *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Num# : *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 409);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "DOB : *";
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Location = new System.Drawing.Point(216, 283);
            this.lnameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(148, 26);
            this.lnameTextBox.TabIndex = 12;
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Location = new System.Drawing.Point(216, 166);
            this.fnameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(148, 26);
            this.fnameTextBox.TabIndex = 12;
            this.fnameTextBox.TextChanged += new System.EventHandler(this.fnameTextBox_TextChanged);
            // 
            // mnameTextBox
            // 
            this.mnameTextBox.Location = new System.Drawing.Point(216, 225);
            this.mnameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mnameTextBox.Name = "mnameTextBox";
            this.mnameTextBox.Size = new System.Drawing.Size(148, 26);
            this.mnameTextBox.TabIndex = 13;
            this.mnameTextBox.TextChanged += new System.EventHandler(this.mnameTextBox_TextChanged);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(216, 342);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(148, 26);
            this.numberTextBox.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(424, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(868, 491);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(424, 591);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(134, 51);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(626, 591);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(134, 51);
            this.removeButton.TabIndex = 21;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // dobTextBox
            // 
            this.dobTextBox.Location = new System.Drawing.Point(216, 409);
            this.dobTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dobTextBox.Name = "dobTextBox";
            this.dobTextBox.Size = new System.Drawing.Size(148, 26);
            this.dobTextBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(123, 47);
            this.label1.TabIndex = 52;
            this.label1.Text = "Voter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(40, 466);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(118, 23);
            this.Address.TabIndex = 53;
            this.Address.Text = "Address : *";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(216, 466);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(148, 26);
            this.addressTextBox.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 520);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 55;
            this.label7.Text = "Email : *";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(216, 520);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(148, 26);
            this.emailTextBox.TabIndex = 56;
            // 
            // VoterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 692);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dobTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.mnameTextBox);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VoterForm";
            this.Text = "VoterForm";
            this.Load += new System.EventHandler(this.VoterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox mnameTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox dobTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}
//namespace SuperVoters
//{
//    partial class VoterForm
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.label3 = new System.Windows.Forms.Label();
//            this.label4 = new System.Windows.Forms.Label();
//            this.label5 = new System.Windows.Forms.Label();
//            this.label6 = new System.Windows.Forms.Label();
//            this.label7 = new System.Windows.Forms.Label();
//            this.label8 = new System.Windows.Forms.Label();
//            this.label9 = new System.Windows.Forms.Label();
//            this.label10 = new System.Windows.Forms.Label();
//            this.idTextBox = new System.Windows.Forms.TextBox();
//            this.nameTextBox = new System.Windows.Forms.TextBox();
//            this.lnameTextBox = new System.Windows.Forms.TextBox();
//            this.fnameTextBox = new System.Windows.Forms.TextBox();
//            this.mnameTextBox = new System.Windows.Forms.TextBox();
//            this.numberTextBox = new System.Windows.Forms.TextBox();
//            this.emailTextBox = new System.Windows.Forms.TextBox();
//            this.addressTextBox = new System.Windows.Forms.TextBox();
//            this.votedCheckBox = new System.Windows.Forms.CheckBox();
//            this.dataGridView1 = new System.Windows.Forms.DataGridView();
//            this.addButton = new System.Windows.Forms.Button();
//            this.removeButton = new System.Windows.Forms.Button();
//            this.updateButton = new System.Windows.Forms.Button();
//            this.dobTextBox = new System.Windows.Forms.TextBox();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label1.Location = new System.Drawing.Point(68, 49);
//            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(113, 23);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "Voter Id : *";
//            this.label1.Click += new System.EventHandler(this.label1_Click);
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label2.Location = new System.Drawing.Point(28, 108);
//            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(151, 23);
//            this.label2.TabIndex = 1;
//            this.label2.Text = "Voter Name : *";
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label3.Location = new System.Drawing.Point(38, 166);
//            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(141, 23);
//            this.label3.TabIndex = 2;
//            this.label3.Text = "First Name : *";
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label4.Location = new System.Drawing.Point(18, 225);
//            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(148, 23);
//            this.label4.TabIndex = 3;
//            this.label4.Text = "Middle Name :";
//            // 
//            // label5
//            // 
//            this.label5.AutoSize = true;
//            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label5.Location = new System.Drawing.Point(40, 283);
//            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(139, 23);
//            this.label5.TabIndex = 4;
//            this.label5.Text = "Last Name : *";
//            // 
//            // label6
//            // 
//            this.label6.AutoSize = true;
//            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label6.Location = new System.Drawing.Point(22, 342);
//            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(157, 23);
//            this.label6.TabIndex = 5;
//            this.label6.Text = "Phone Num# : *";
//            // 
//            // label7
//            // 
//            this.label7.AutoSize = true;
//            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label7.Location = new System.Drawing.Point(88, 400);
//            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label7.Name = "label7";
//            this.label7.Size = new System.Drawing.Size(88, 23);
//            this.label7.TabIndex = 6;
//            this.label7.Text = "Email : *";
//            // 
//            // label8
//            // 
//            this.label8.AutoSize = true;
//            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label8.Location = new System.Drawing.Point(64, 458);
//            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label8.Name = "label8";
//            this.label8.Size = new System.Drawing.Size(118, 23);
//            this.label8.TabIndex = 7;
//            this.label8.Text = "Address : *";
//            // 
//            // label9
//            // 
//            this.label9.AutoSize = true;
//            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label9.Location = new System.Drawing.Point(100, 517);
//            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label9.Name = "label9";
//            this.label9.Size = new System.Drawing.Size(80, 23);
//            this.label9.TabIndex = 8;
//            this.label9.Text = "DOB : *";
//            // 
//            // label10
//            // 
//            this.label10.AutoSize = true;
//            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label10.Location = new System.Drawing.Point(87, 575);
//            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label10.Name = "label10";
//            this.label10.Size = new System.Drawing.Size(93, 23);
//            this.label10.TabIndex = 9;
//            this.label10.Text = "Voted : *";
//            // 
//            // idTextBox
//            // 
//            this.idTextBox.Location = new System.Drawing.Point(216, 49);
//            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.idTextBox.Name = "idTextBox";
//            this.idTextBox.Size = new System.Drawing.Size(148, 26);
//            this.idTextBox.TabIndex = 10;
//            // 
//            // nameTextBox
//            // 
//            this.nameTextBox.Location = new System.Drawing.Point(216, 108);
//            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.nameTextBox.Name = "nameTextBox";
//            this.nameTextBox.Size = new System.Drawing.Size(148, 26);
//            this.nameTextBox.TabIndex = 11;
//            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
//            // 
//            // lnameTextBox
//            // 
//            this.lnameTextBox.Location = new System.Drawing.Point(216, 283);
//            this.lnameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.lnameTextBox.Name = "lnameTextBox";
//            this.lnameTextBox.Size = new System.Drawing.Size(148, 26);
//            this.lnameTextBox.TabIndex = 12;
//            this.lnameTextBox.TextChanged += new System.EventHandler(this.lnameTextBox_TextChanged);
//            // 
//            // fnameTextBox
//            // 
//            this.fnameTextBox.Location = new System.Drawing.Point(216, 166);
//            this.fnameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.fnameTextBox.Name = "fnameTextBox";
//            this.fnameTextBox.Size = new System.Drawing.Size(148, 26);
//            this.fnameTextBox.TabIndex = 12;
//            this.fnameTextBox.TextChanged += new System.EventHandler(this.fnameTextBox_TextChanged);
//            // 
//            // mnameTextBox
//            // 
//            this.mnameTextBox.Location = new System.Drawing.Point(216, 225);
//            this.mnameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.mnameTextBox.Name = "mnameTextBox";
//            this.mnameTextBox.Size = new System.Drawing.Size(148, 26);
//            this.mnameTextBox.TabIndex = 13;
//            this.mnameTextBox.TextChanged += new System.EventHandler(this.mnameTextBox_TextChanged);
//            // 
//            // numberTextBox
//            // 
//            this.numberTextBox.Location = new System.Drawing.Point(216, 342);
//            this.numberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.numberTextBox.Name = "numberTextBox";
//            this.numberTextBox.Size = new System.Drawing.Size(148, 26);
//            this.numberTextBox.TabIndex = 14;
//            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
//            // 
//            // emailTextBox
//            // 
//            this.emailTextBox.Location = new System.Drawing.Point(216, 400);
//            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.emailTextBox.Name = "emailTextBox";
//            this.emailTextBox.Size = new System.Drawing.Size(148, 26);
//            this.emailTextBox.TabIndex = 15;
//            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
//            // 
//            // addressTextBox
//            // 
//            this.addressTextBox.Location = new System.Drawing.Point(216, 458);
//            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.addressTextBox.Name = "addressTextBox";
//            this.addressTextBox.Size = new System.Drawing.Size(148, 26);
//            this.addressTextBox.TabIndex = 16;
//            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
//            // 
//            // votedCheckBox
//            // 
//           // this.votedCheckBox.AutoSize = true;
//           // this.votedCheckBox.Location = new System.Drawing.Point(216, 575);
//           // this.votedCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//           // this.votedCheckBox.Name = "votedCheckBox";
//           // this.votedCheckBox.Size = new System.Drawing.Size(63, 24);
//           // this.votedCheckBox.TabIndex = 18;
//          //  this.votedCheckBox.Text = "Yes";
//           // this.votedCheckBox.UseVisualStyleBackColor = true;
//           // this.votedCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
//            // 
//            // dataGridView1
//            // 
//            this.dataGridView1.AllowUserToAddRows = false;
//            this.dataGridView1.AllowUserToDeleteRows = false;
//            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView1.Location = new System.Drawing.Point(424, 49);
//            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.dataGridView1.MultiSelect = false;
//            this.dataGridView1.Name = "dataGridView1";
//            this.dataGridView1.ReadOnly = true;
//            this.dataGridView1.RowHeadersVisible = false;
//            this.dataGridView1.RowHeadersWidth = 62;
//            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            this.dataGridView1.Size = new System.Drawing.Size(868, 491);
//            this.dataGridView1.TabIndex = 19;
//            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
//            // 
//            // addButton
//            // 
//            this.addButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.addButton.Location = new System.Drawing.Point(424, 591);
//            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.addButton.Name = "addButton";
//            this.addButton.Size = new System.Drawing.Size(134, 51);
//            this.addButton.TabIndex = 20;
//            this.addButton.Text = "Add";
//            this.addButton.UseVisualStyleBackColor = true;
//            this.addButton.Click += new System.EventHandler(this.addButton_Click);
//            // 
//            // removeButton
//            // 
//            this.removeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.removeButton.Location = new System.Drawing.Point(626, 591);
//            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.removeButton.Name = "removeButton";
//            this.removeButton.Size = new System.Drawing.Size(134, 51);
//            this.removeButton.TabIndex = 21;
//            this.removeButton.Text = "Remove";
//            this.removeButton.UseVisualStyleBackColor = true;
//            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
//            // 
//            // updateButton
//            // 
//            this.updateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.updateButton.Location = new System.Drawing.Point(826, 591);
//            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.updateButton.Name = "updateButton";
//            this.updateButton.Size = new System.Drawing.Size(134, 51);
//            this.updateButton.TabIndex = 22;
//            this.updateButton.Text = "Update";
//            this.updateButton.UseVisualStyleBackColor = true;
//           // this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
//            // 
//            // dobTextBox
//            // 
//            this.dobTextBox.Location = new System.Drawing.Point(216, 517);
//            this.dobTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.dobTextBox.Name = "dobTextBox";
//            this.dobTextBox.Size = new System.Drawing.Size(148, 26);
//            this.dobTextBox.TabIndex = 23;
//            this.dobTextBox.TextChanged += new System.EventHandler(this.dobTextBox_TextChanged);
//            // 
//            // VoterForm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1344, 692);
//            this.Controls.Add(this.updateButton);
//            this.Controls.Add(this.removeButton);
//            this.Controls.Add(this.addButton);
//            this.Controls.Add(this.dobTextBox);
//            this.Controls.Add(this.dataGridView1);
//            this.Controls.Add(this.votedCheckBox);
//            this.Controls.Add(this.addressTextBox);
//            this.Controls.Add(this.emailTextBox);
//            this.Controls.Add(this.numberTextBox);
//            this.Controls.Add(this.mnameTextBox);
//            this.Controls.Add(this.fnameTextBox);
//            this.Controls.Add(this.lnameTextBox);
//            this.Controls.Add(this.nameTextBox);
//            this.Controls.Add(this.idTextBox);
//            this.Controls.Add(this.label10);
//            this.Controls.Add(this.label9);
//            this.Controls.Add(this.label8);
//            this.Controls.Add(this.label7);
//            this.Controls.Add(this.label6);
//            this.Controls.Add(this.label5);
//            this.Controls.Add(this.label4);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.label1);
//            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.Name = "VoterForm";
//            this.Text = "VoterForm";
//            this.Load += new System.EventHandler(this.VoterForm_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.Label label6;
//        private System.Windows.Forms.Label label7;
//        private System.Windows.Forms.Label label8;
//        private System.Windows.Forms.Label label9;
//        private System.Windows.Forms.Label label10;
//        private System.Windows.Forms.TextBox idTextBox;
//        private System.Windows.Forms.TextBox nameTextBox;
//        private System.Windows.Forms.TextBox lnameTextBox;
//        private System.Windows.Forms.TextBox fnameTextBox;
//        private System.Windows.Forms.TextBox mnameTextBox;
//        private System.Windows.Forms.TextBox numberTextBox;
//        private System.Windows.Forms.TextBox emailTextBox;
//        private System.Windows.Forms.TextBox addressTextBox;
//        private System.Windows.Forms.CheckBox votedCheckBox;
//        private System.Windows.Forms.DataGridView dataGridView1;
//        private System.Windows.Forms.Button addButton;
//        private System.Windows.Forms.Button removeButton;
//        private System.Windows.Forms.Button updateButton;
//        private System.Windows.Forms.TextBox dobTextBox;
//    }
//}