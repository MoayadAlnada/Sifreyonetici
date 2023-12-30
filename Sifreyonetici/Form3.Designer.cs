namespace Sifreyonetici
{
    partial class Form3
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
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_wbsitname = new System.Windows.Forms.TextBox();
            this.chk_social = new System.Windows.Forms.CheckBox();
            this.chk_edu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(210, 40);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(253, 20);
            this.txt_url.TabIndex = 0;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(210, 114);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(147, 20);
            this.txt_username.TabIndex = 3;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(210, 155);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '•';
            this.txt_pw.Size = new System.Drawing.Size(147, 20);
            this.txt_pw.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "WebSite URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(355, 200);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(150, 69);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "WebSite Name";
            // 
            // txt_wbsitname
            // 
            this.txt_wbsitname.Location = new System.Drawing.Point(210, 78);
            this.txt_wbsitname.Name = "txt_wbsitname";
            this.txt_wbsitname.Size = new System.Drawing.Size(147, 20);
            this.txt_wbsitname.TabIndex = 1;
            // 
            // chk_social
            // 
            this.chk_social.AutoSize = true;
            this.chk_social.Location = new System.Drawing.Point(187, 200);
            this.chk_social.Name = "chk_social";
            this.chk_social.Size = new System.Drawing.Size(87, 17);
            this.chk_social.TabIndex = 5;
            this.chk_social.Text = "Social Media";
            this.chk_social.UseVisualStyleBackColor = true;
            // 
            // chk_edu
            // 
            this.chk_edu.AutoSize = true;
            this.chk_edu.Location = new System.Drawing.Point(187, 234);
            this.chk_edu.Name = "chk_edu";
            this.chk_edu.Size = new System.Drawing.Size(74, 17);
            this.chk_edu.TabIndex = 6;
            this.chk_edu.Text = "Education";
            this.chk_edu.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 299);
            this.Controls.Add(this.chk_edu);
            this.Controls.Add(this.chk_social);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_wbsitname);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_url);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_wbsitname;
        private System.Windows.Forms.CheckBox chk_social;
        private System.Windows.Forms.CheckBox chk_edu;
    }
}