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
            this.btn_t1_2 = new System.Windows.Forms.Button();
            this.btnDownload_t1 = new System.Windows.Forms.Button();
            this.txtFileName_t1 = new System.Windows.Forms.TextBox();
            this.progBar_t1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_downfile_t2 = new System.Windows.Forms.TextBox();
            this.btn_t2_2 = new System.Windows.Forms.Button();
            this.progressBar_t2_1 = new System.Windows.Forms.ProgressBar();
            this.btn_t2_1 = new System.Windows.Forms.Button();
            this.cbo_t1 = new System.Windows.Forms.ComboBox();
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txrElapsedTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_t1_2
            // 
            this.btn_t1_2.Location = new System.Drawing.Point(40, 17);
            this.btn_t1_2.Name = "btn_t1_2";
            this.btn_t1_2.Size = new System.Drawing.Size(85, 41);
            this.btn_t1_2.TabIndex = 9;
            this.btn_t1_2.Text = "Upload";
            this.btn_t1_2.UseVisualStyleBackColor = true;
            this.btn_t1_2.Click += new System.EventHandler(this.btn_t5_2_Click);
            // 
            // btnDownload_t1
            // 
            this.btnDownload_t1.Location = new System.Drawing.Point(665, 17);
            this.btnDownload_t1.Name = "btnDownload_t1";
            this.btnDownload_t1.Size = new System.Drawing.Size(85, 41);
            this.btnDownload_t1.TabIndex = 10;
            this.btnDownload_t1.Text = "Download";
            this.btnDownload_t1.UseVisualStyleBackColor = true;
            this.btnDownload_t1.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtFileName_t1
            // 
            this.txtFileName_t1.Location = new System.Drawing.Point(449, 27);
            this.txtFileName_t1.Name = "txtFileName_t1";
            this.txtFileName_t1.Size = new System.Drawing.Size(210, 21);
            this.txtFileName_t1.TabIndex = 11;
            // 
            // progBar_t1
            // 
            this.progBar_t1.BackColor = System.Drawing.Color.BlueViolet;
            this.progBar_t1.Location = new System.Drawing.Point(40, 64);
            this.progBar_t1.Name = "progBar_t1";
            this.progBar_t1.Size = new System.Drawing.Size(710, 23);
            this.progBar_t1.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 409);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progBar_t1);
            this.tabPage1.Controls.Add(this.txtFileName_t1);
            this.tabPage1.Controls.Add(this.btn_t1_2);
            this.tabPage1.Controls.Add(this.btnDownload_t1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(912, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File Sync";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_downfile_t2);
            this.tabPage2.Controls.Add(this.btn_t2_2);
            this.tabPage2.Controls.Add(this.progressBar_t2_1);
            this.tabPage2.Controls.Add(this.btn_t2_1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(912, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File Async";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_downfile_t2
            // 
            this.txt_downfile_t2.Location = new System.Drawing.Point(440, 27);
            this.txt_downfile_t2.Name = "txt_downfile_t2";
            this.txt_downfile_t2.Size = new System.Drawing.Size(210, 21);
            this.txt_downfile_t2.TabIndex = 16;
            // 
            // btn_t2_2
            // 
            this.btn_t2_2.Location = new System.Drawing.Point(677, 12);
            this.btn_t2_2.Name = "btn_t2_2";
            this.btn_t2_2.Size = new System.Drawing.Size(107, 48);
            this.btn_t2_2.TabIndex = 15;
            this.btn_t2_2.Text = "Download Async";
            this.btn_t2_2.UseVisualStyleBackColor = true;
            this.btn_t2_2.Click += new System.EventHandler(this.btn_t2_2_Click);
            // 
            // progressBar_t2_1
            // 
            this.progressBar_t2_1.BackColor = System.Drawing.Color.BlueViolet;
            this.progressBar_t2_1.Location = new System.Drawing.Point(40, 66);
            this.progressBar_t2_1.Name = "progressBar_t2_1";
            this.progressBar_t2_1.Size = new System.Drawing.Size(744, 23);
            this.progressBar_t2_1.TabIndex = 14;
            // 
            // btn_t2_1
            // 
            this.btn_t2_1.Location = new System.Drawing.Point(40, 12);
            this.btn_t2_1.Name = "btn_t2_1";
            this.btn_t2_1.Size = new System.Drawing.Size(107, 48);
            this.btn_t2_1.TabIndex = 0;
            this.btn_t2_1.Text = "Upload Async";
            this.btn_t2_1.UseVisualStyleBackColor = true;
            this.btn_t2_1.Click += new System.EventHandler(this.btn_t2_1_ClickAsync);
            // 
            // cbo_t1
            // 
            this.cbo_t1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_t1.FormattingEnabled = true;
            this.cbo_t1.Items.AddRange(new object[] {
            "Http",
            "NetTcp"});
            this.cbo_t1.Location = new System.Drawing.Point(108, 18);
            this.cbo_t1.Name = "cbo_t1";
            this.cbo_t1.Size = new System.Drawing.Size(134, 20);
            this.cbo_t1.TabIndex = 14;
            // 
            // txt_fileName
            // 
            this.txt_fileName.Location = new System.Drawing.Point(372, 17);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.ReadOnly = true;
            this.txt_fileName.Size = new System.Drawing.Size(523, 21);
            this.txt_fileName.TabIndex = 17;
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(258, 12);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(97, 47);
            this.btn_file.TabIndex = 16;
            this.btn_file.Text = "Upload File 선택";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txrElapsedTime);
            this.panel1.Controls.Add(this.txt_fileName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_file);
            this.panel1.Controls.Add(this.cbo_t1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 65);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "시간(초)";
            // 
            // txrElapsedTime
            // 
            this.txrElapsedTime.Location = new System.Drawing.Point(777, 40);
            this.txrElapsedTime.Name = "txrElapsedTime";
            this.txrElapsedTime.ReadOnly = true;
            this.txrElapsedTime.Size = new System.Drawing.Size(117, 21);
            this.txrElapsedTime.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Binding";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 474);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_t1_2;
        private System.Windows.Forms.Button btnDownload_t1;
        private System.Windows.Forms.TextBox txtFileName_t1;
        private System.Windows.Forms.ProgressBar progBar_t1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbo_t1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_t2_1;
        private System.Windows.Forms.ProgressBar progressBar_t2_1;
        private System.Windows.Forms.Button btn_t2_2;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.TextBox txt_fileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_downfile_t2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txrElapsedTime;
    }
}

