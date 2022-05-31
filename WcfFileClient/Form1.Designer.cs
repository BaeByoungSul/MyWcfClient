namespace WcfClient
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
            this.btn_t1_1 = new System.Windows.Forms.Button();
            this.txt_t1_1 = new System.Windows.Forms.TextBox();
            this.btn_t1_2 = new System.Windows.Forms.Button();
            this.btnDownload_t1 = new System.Windows.Forms.Button();
            this.txtFileName_t1 = new System.Windows.Forms.TextBox();
            this.txtReadText = new System.Windows.Forms.TextBox();
            this.progBar_t1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbo_t1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_t1_1
            // 
            this.btn_t1_1.Location = new System.Drawing.Point(21, 20);
            this.btn_t1_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_t1_1.Name = "btn_t1_1";
            this.btn_t1_1.Size = new System.Drawing.Size(74, 39);
            this.btn_t1_1.TabIndex = 7;
            this.btn_t1_1.Text = "File";
            this.btn_t1_1.UseVisualStyleBackColor = true;
            this.btn_t1_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // txt_t1_1
            // 
            this.txt_t1_1.Location = new System.Drawing.Point(21, 66);
            this.txt_t1_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_t1_1.Name = "txt_t1_1";
            this.txt_t1_1.ReadOnly = true;
            this.txt_t1_1.Size = new System.Drawing.Size(597, 25);
            this.txt_t1_1.TabIndex = 8;
            // 
            // btn_t1_2
            // 
            this.btn_t1_2.Location = new System.Drawing.Point(133, 20);
            this.btn_t1_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_t1_2.Name = "btn_t1_2";
            this.btn_t1_2.Size = new System.Drawing.Size(97, 39);
            this.btn_t1_2.TabIndex = 9;
            this.btn_t1_2.Text = "Upload";
            this.btn_t1_2.UseVisualStyleBackColor = true;
            this.btn_t1_2.Click += new System.EventHandler(this.btn_t5_2_Click);
            // 
            // btnDownload_t1
            // 
            this.btnDownload_t1.Location = new System.Drawing.Point(267, 119);
            this.btnDownload_t1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDownload_t1.Name = "btnDownload_t1";
            this.btnDownload_t1.Size = new System.Drawing.Size(97, 39);
            this.btnDownload_t1.TabIndex = 10;
            this.btnDownload_t1.Text = "Download";
            this.btnDownload_t1.UseVisualStyleBackColor = true;
            this.btnDownload_t1.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtFileName_t1
            // 
            this.txtFileName_t1.Location = new System.Drawing.Point(21, 119);
            this.txtFileName_t1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFileName_t1.Name = "txtFileName_t1";
            this.txtFileName_t1.Size = new System.Drawing.Size(239, 25);
            this.txtFileName_t1.TabIndex = 11;
            // 
            // txtReadText
            // 
            this.txtReadText.Location = new System.Drawing.Point(21, 165);
            this.txtReadText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReadText.Multiline = true;
            this.txtReadText.Name = "txtReadText";
            this.txtReadText.Size = new System.Drawing.Size(597, 230);
            this.txtReadText.TabIndex = 12;
            // 
            // progBar_t1
            // 
            this.progBar_t1.BackColor = System.Drawing.Color.BlueViolet;
            this.progBar_t1.Location = new System.Drawing.Point(237, 20);
            this.progBar_t1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progBar_t1.Name = "progBar_t1";
            this.progBar_t1.Size = new System.Drawing.Size(382, 29);
            this.progBar_t1.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1015, 592);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbo_t1);
            this.tabPage1.Controls.Add(this.txtReadText);
            this.tabPage1.Controls.Add(this.progBar_t1);
            this.tabPage1.Controls.Add(this.btn_t1_1);
            this.tabPage1.Controls.Add(this.txt_t1_1);
            this.tabPage1.Controls.Add(this.txtFileName_t1);
            this.tabPage1.Controls.Add(this.btn_t1_2);
            this.tabPage1.Controls.Add(this.btnDownload_t1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1007, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File Service";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbo_t1
            // 
            this.cbo_t1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_t1.FormattingEnabled = true;
            this.cbo_t1.Items.AddRange(new object[] {
            "Http",
            "NetTcp"});
            this.cbo_t1.Location = new System.Drawing.Point(667, 18);
            this.cbo_t1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_t1.Name = "cbo_t1";
            this.cbo_t1.Size = new System.Drawing.Size(153, 23);
            this.cbo_t1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 592);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_t1_1;
        private System.Windows.Forms.TextBox txt_t1_1;
        private System.Windows.Forms.Button btn_t1_2;
        private System.Windows.Forms.Button btnDownload_t1;
        private System.Windows.Forms.TextBox txtFileName_t1;
        private System.Windows.Forms.TextBox txtReadText;
        private System.Windows.Forms.ProgressBar progBar_t1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbo_t1;
    }
}

