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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.설명 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_t1_1
            // 
            this.btn_t1_1.Location = new System.Drawing.Point(18, 16);
            this.btn_t1_1.Name = "btn_t1_1";
            this.btn_t1_1.Size = new System.Drawing.Size(65, 31);
            this.btn_t1_1.TabIndex = 7;
            this.btn_t1_1.Text = "File";
            this.btn_t1_1.UseVisualStyleBackColor = true;
            this.btn_t1_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // txt_t1_1
            // 
            this.txt_t1_1.Location = new System.Drawing.Point(18, 53);
            this.txt_t1_1.Name = "txt_t1_1";
            this.txt_t1_1.ReadOnly = true;
            this.txt_t1_1.Size = new System.Drawing.Size(523, 21);
            this.txt_t1_1.TabIndex = 8;
            // 
            // btn_t1_2
            // 
            this.btn_t1_2.Location = new System.Drawing.Point(116, 16);
            this.btn_t1_2.Name = "btn_t1_2";
            this.btn_t1_2.Size = new System.Drawing.Size(85, 31);
            this.btn_t1_2.TabIndex = 9;
            this.btn_t1_2.Text = "Upload";
            this.btn_t1_2.UseVisualStyleBackColor = true;
            this.btn_t1_2.Click += new System.EventHandler(this.btn_t5_2_Click);
            // 
            // btnDownload_t1
            // 
            this.btnDownload_t1.Location = new System.Drawing.Point(234, 95);
            this.btnDownload_t1.Name = "btnDownload_t1";
            this.btnDownload_t1.Size = new System.Drawing.Size(85, 31);
            this.btnDownload_t1.TabIndex = 10;
            this.btnDownload_t1.Text = "Download";
            this.btnDownload_t1.UseVisualStyleBackColor = true;
            this.btnDownload_t1.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtFileName_t1
            // 
            this.txtFileName_t1.Location = new System.Drawing.Point(18, 95);
            this.txtFileName_t1.Name = "txtFileName_t1";
            this.txtFileName_t1.Size = new System.Drawing.Size(210, 21);
            this.txtFileName_t1.TabIndex = 11;
            // 
            // txtReadText
            // 
            this.txtReadText.Location = new System.Drawing.Point(18, 132);
            this.txtReadText.Multiline = true;
            this.txtReadText.Name = "txtReadText";
            this.txtReadText.Size = new System.Drawing.Size(523, 185);
            this.txtReadText.TabIndex = 12;
            // 
            // progBar_t1
            // 
            this.progBar_t1.BackColor = System.Drawing.Color.BlueViolet;
            this.progBar_t1.Location = new System.Drawing.Point(207, 16);
            this.progBar_t1.Name = "progBar_t1";
            this.progBar_t1.Size = new System.Drawing.Size(334, 23);
            this.progBar_t1.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 474);
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
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 441);
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
            this.cbo_t1.Location = new System.Drawing.Point(584, 14);
            this.cbo_t1.Name = "cbo_t1";
            this.cbo_t1.Size = new System.Drawing.Size(134, 20);
            this.cbo_t1.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DB Service";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "구분";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Query, Text",
            "Procedure, Text",
            "Procedure, Stored"});
            this.comboBox1.Location = new System.Drawing.Point(64, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 20);
            this.comboBox1.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "MSSQL조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 474);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbo_t1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn 설명;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

