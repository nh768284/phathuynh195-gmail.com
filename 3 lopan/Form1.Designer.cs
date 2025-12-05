namespace _3_lopan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textten = new TextBox();
            textid = new TextBox();
            textstd = new TextBox();
            dangnhap = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textten
            // 
            textten.Location = new Point(161, 39);
            textten.Name = "textten";
            textten.Size = new Size(100, 23);
            textten.TabIndex = 0;
            // 
            // textid
            // 
            textid.Location = new Point(161, 79);
            textid.Name = "textid";
            textid.Size = new Size(100, 23);
            textid.TabIndex = 1;
            // 
            // textstd
            // 
            textstd.Location = new Point(161, 119);
            textstd.Name = "textstd";
            textstd.Size = new Size(100, 23);
            textstd.TabIndex = 2;
            // 
            // dangnhap
            // 
            dangnhap.Location = new Point(123, 161);
            dangnhap.Name = "dangnhap";
            dangnhap.Size = new Size(95, 39);
            dangnhap.TabIndex = 3;
            dangnhap.Text = "dang nhap";
            dangnhap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 42);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 4;
            label1.Text = "ten";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 82);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "dien thoai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 122);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "dia chi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 264);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dangnhap);
            Controls.Add(textstd);
            Controls.Add(textid);
            Controls.Add(textten);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textten;
        private TextBox textid;
        private TextBox textstd;
        private Button dangnhap;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
