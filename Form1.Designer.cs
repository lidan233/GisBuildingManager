namespace MapControlApplication7
{
    partial class Form1
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
            this.layers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chooseFile = new System.Windows.Forms.Button();
            this.pathchoose = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.sure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择图层";
            // 
            // layers
            // 
            this.layers.FormattingEnabled = true;
            this.layers.Location = new System.Drawing.Point(101, 51);
            this.layers.Name = "layers";
            this.layers.Size = new System.Drawing.Size(121, 23);
            this.layers.TabIndex = 1;
            this.layers.BindingContextChanged += new System.EventHandler(this.layers_BindingContextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "制定半径";
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(101, 95);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(100, 25);
            this.radius.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "公里";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "生成图层路径";
            // 
            // chooseFile
            // 
            this.chooseFile.Location = new System.Drawing.Point(253, 145);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(52, 23);
            this.chooseFile.TabIndex = 6;
            this.chooseFile.Text = ">";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // pathchoose
            // 
            this.pathchoose.Location = new System.Drawing.Point(134, 142);
            this.pathchoose.Name = "pathchoose";
            this.pathchoose.Size = new System.Drawing.Size(100, 25);
            this.pathchoose.TabIndex = 7;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(219, 198);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(88, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // sure
            // 
            this.sure.Location = new System.Drawing.Point(46, 198);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(90, 23);
            this.sure.TabIndex = 9;
            this.sure.Text = "确定";
            this.sure.UseVisualStyleBackColor = true;
            this.sure.Click += new System.EventHandler(this.sure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 253);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pathchoose);
            this.Controls.Add(this.chooseFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.layers);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox layers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.TextBox pathchoose;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button sure;

    }
}