namespace WcfClient
{
    partial class frmDB
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbo_t1 = new System.Windows.Forms.ComboBox();
            this.txt_t1_1 = new System.Windows.Forms.TextBox();
            this.dgv_t1_1 = new System.Windows.Forms.DataGridView();
            this.btn_t1_3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t1_1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_t1_2
            // 
            this.btn_t1_2.Location = new System.Drawing.Point(267, 18);
            this.btn_t1_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_t1_2.Name = "btn_t1_2";
            this.btn_t1_2.Size = new System.Drawing.Size(97, 39);
            this.btn_t1_2.TabIndex = 9;
            this.btn_t1_2.Text = "조회";
            this.btn_t1_2.UseVisualStyleBackColor = true;
            this.btn_t1_2.Click += new System.EventHandler(this.btn_t5_2_Click);
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
            this.tabPage1.Controls.Add(this.btn_t1_3);
            this.tabPage1.Controls.Add(this.dgv_t1_1);
            this.tabPage1.Controls.Add(this.txt_t1_1);
            this.tabPage1.Controls.Add(this.cbo_t1);
            this.tabPage1.Controls.Add(this.btn_t1_2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1007, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DB Service";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbo_t1
            // 
            this.cbo_t1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_t1.FormattingEnabled = true;
            this.cbo_t1.Items.AddRange(new object[] {
            "Http",
            "NetTcp"});
            this.cbo_t1.Location = new System.Drawing.Point(45, 18);
            this.cbo_t1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_t1.Name = "cbo_t1";
            this.cbo_t1.Size = new System.Drawing.Size(153, 23);
            this.cbo_t1.TabIndex = 14;
            // 
            // txt_t1_1
            // 
            this.txt_t1_1.Location = new System.Drawing.Point(329, 87);
            this.txt_t1_1.Multiline = true;
            this.txt_t1_1.Name = "txt_t1_1";
            this.txt_t1_1.Size = new System.Drawing.Size(548, 271);
            this.txt_t1_1.TabIndex = 15;
            // 
            // dgv_t1_1
            // 
            this.dgv_t1_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_t1_1.Location = new System.Drawing.Point(26, 94);
            this.dgv_t1_1.Name = "dgv_t1_1";
            this.dgv_t1_1.RowHeadersWidth = 51;
            this.dgv_t1_1.RowTemplate.Height = 27;
            this.dgv_t1_1.Size = new System.Drawing.Size(510, 335);
            this.dgv_t1_1.TabIndex = 16;
            // 
            // btn_t1_3
            // 
            this.btn_t1_3.Location = new System.Drawing.Point(423, 20);
            this.btn_t1_3.Name = "btn_t1_3";
            this.btn_t1_3.Size = new System.Drawing.Size(99, 36);
            this.btn_t1_3.TabIndex = 17;
            this.btn_t1_3.Text = "등록";
            this.btn_t1_3.UseVisualStyleBackColor = true;
            this.btn_t1_3.Click += new System.EventHandler(this.btn_t1_3_Click);
            // 
            // frmDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 592);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDB";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t1_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_t1_2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbo_t1;
        private System.Windows.Forms.TextBox txt_t1_1;
        private System.Windows.Forms.DataGridView dgv_t1_1;
        private System.Windows.Forms.Button btn_t1_3;
    }
}

