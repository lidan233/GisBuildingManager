namespace MapControlApplication7.User
{
    partial class Modify
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.psw2 = new System.Windows.Forms.TextBox();
            this.psw1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "要修改的用户名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "修改后的密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(167, 39);
            this.username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(181, 25);
            this.username.TabIndex = 3;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(76, 248);
            this.ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(100, 29);
            this.ok.TabIndex = 6;
            this.ok.Text = "确定修改";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 248);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // psw2
            // 
            this.psw2.Location = new System.Drawing.Point(167, 182);
            this.psw2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.psw2.Name = "psw2";
            this.psw2.Size = new System.Drawing.Size(181, 25);
            this.psw2.TabIndex = 5;
            this.psw2.UseSystemPasswordChar = true;
            // 
            // psw1
            // 
            this.psw1.Location = new System.Drawing.Point(167, 112);
            this.psw1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.psw1.Name = "psw1";
            this.psw1.Size = new System.Drawing.Size(181, 25);
            this.psw1.TabIndex = 4;
            this.psw1.UseSystemPasswordChar = true;
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 334);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.psw2);
            this.Controls.Add(this.psw1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserModify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox psw2;
        private System.Windows.Forms.TextBox psw1;
    }
}