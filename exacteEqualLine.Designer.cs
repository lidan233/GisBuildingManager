namespace MapControlApplication7
{
    partial class exacteEqualLine
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
            this.basenumber = new System.Windows.Forms.TextBox();
            this.dis = new System.Windows.Forms.TextBox();
            this.savepath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.layers1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入栅格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "等高线间隔";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "基本等高线";
            // 
            // basenumber
            // 
            this.basenumber.Location = new System.Drawing.Point(133, 146);
            this.basenumber.Name = "basenumber";
            this.basenumber.Size = new System.Drawing.Size(148, 25);
            this.basenumber.TabIndex = 4;
            // 
            // dis
            // 
            this.dis.Location = new System.Drawing.Point(133, 96);
            this.dis.Name = "dis";
            this.dis.Size = new System.Drawing.Size(148, 25);
            this.dis.TabIndex = 5;
            // 
            // savepath
            // 
            this.savepath.Location = new System.Drawing.Point(133, 202);
            this.savepath.Name = "savepath";
            this.savepath.Size = new System.Drawing.Size(148, 25);
            this.savepath.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "输出等高线";
            // 
            // sure
            // 
            this.sure.Location = new System.Drawing.Point(45, 273);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(75, 23);
            this.sure.TabIndex = 9;
            this.sure.Text = "OK";
            this.sure.UseVisualStyleBackColor = true;
            this.sure.Click += new System.EventHandler(this.sure_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(272, 273);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // layers1
            // 
            this.layers1.FormattingEnabled = true;
            this.layers1.Location = new System.Drawing.Point(133, 50);
            this.layers1.Name = "layers1";
            this.layers1.Size = new System.Drawing.Size(121, 23);
            this.layers1.TabIndex = 11;
            this.layers1.SelectedIndexChanged += new System.EventHandler(this.layers1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exacteEqualLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.layers1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.savepath);
            this.Controls.Add(this.dis);
            this.Controls.Add(this.basenumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "exacteEqualLine";
            this.Text = "exacteEqualLine";
            this.Load += new System.EventHandler(this.exacteEqualLine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox basenumber;
        private System.Windows.Forms.TextBox dis;
        private System.Windows.Forms.TextBox savepath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sure;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox layers1;
        private System.Windows.Forms.Button button1;
    }
}