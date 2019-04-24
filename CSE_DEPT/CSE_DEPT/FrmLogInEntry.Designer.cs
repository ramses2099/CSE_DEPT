namespace CSE_DEPT
{
    partial class FrmLogInEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogInEntry));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtpass_word = new System.Windows.Forms.TextBox();
            this.lblpass_word = new System.Windows.Forms.Label();
            this.txtuser_name = new System.Windows.Forms.TextBox();
            this.lbluser_name = new System.Windows.Forms.Label();
            this.txtlogin_id = new System.Windows.Forms.TextBox();
            this.lbllogin_id = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtpass_word);
            this.groupBox1.Controls.Add(this.lblpass_word);
            this.groupBox1.Controls.Add(this.txtuser_name);
            this.groupBox1.Controls.Add(this.lbluser_name);
            this.groupBox1.Controls.Add(this.txtlogin_id);
            this.groupBox1.Controls.Add(this.lbllogin_id);
            this.groupBox1.Location = new System.Drawing.Point(21, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(243, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 44);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(38, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "STUDENT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(42, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "FACULTY:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(136, 157);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // txtpass_word
            // 
            this.txtpass_word.Location = new System.Drawing.Point(136, 95);
            this.txtpass_word.Name = "txtpass_word";
            this.txtpass_word.Size = new System.Drawing.Size(159, 22);
            this.txtpass_word.TabIndex = 5;
            // 
            // lblpass_word
            // 
            this.lblpass_word.AutoSize = true;
            this.lblpass_word.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblpass_word.Location = new System.Drawing.Point(24, 95);
            this.lblpass_word.Name = "lblpass_word";
            this.lblpass_word.Size = new System.Drawing.Size(92, 17);
            this.lblpass_word.TabIndex = 4;
            this.lblpass_word.Text = "PASSWORD:";
            // 
            // txtuser_name
            // 
            this.txtuser_name.Location = new System.Drawing.Point(136, 65);
            this.txtuser_name.Name = "txtuser_name";
            this.txtuser_name.Size = new System.Drawing.Size(159, 22);
            this.txtuser_name.TabIndex = 3;
            // 
            // lbluser_name
            // 
            this.lbluser_name.AutoSize = true;
            this.lbluser_name.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbluser_name.Location = new System.Drawing.Point(21, 65);
            this.lbluser_name.Name = "lbluser_name";
            this.lbluser_name.Size = new System.Drawing.Size(93, 17);
            this.lbluser_name.TabIndex = 2;
            this.lbluser_name.Text = "USER NAME:";
            // 
            // txtlogin_id
            // 
            this.txtlogin_id.Location = new System.Drawing.Point(136, 34);
            this.txtlogin_id.Name = "txtlogin_id";
            this.txtlogin_id.Size = new System.Drawing.Size(100, 22);
            this.txtlogin_id.TabIndex = 1;
            this.txtlogin_id.Text = "A0001";
            // 
            // lbllogin_id
            // 
            this.lbllogin_id.AutoSize = true;
            this.lbllogin_id.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbllogin_id.Location = new System.Drawing.Point(44, 34);
            this.lbllogin_id.Name = "lbllogin_id";
            this.lbllogin_id.Size = new System.Drawing.Size(72, 17);
            this.lbllogin_id.TabIndex = 0;
            this.lbllogin_id.Text = "LOGIN ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(21, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 60);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(146, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(249, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmLogInEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(399, 336);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogInEntry";
            this.Text = "Log In Entry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtpass_word;
        private System.Windows.Forms.Label lblpass_word;
        private System.Windows.Forms.TextBox txtuser_name;
        private System.Windows.Forms.Label lbluser_name;
        private System.Windows.Forms.TextBox txtlogin_id;
        private System.Windows.Forms.Label lbllogin_id;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSearch;
    }
}