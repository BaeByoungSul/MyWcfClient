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
            this.dgv_t1_2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_t1_1 = new System.Windows.Forms.Button();
            this.btn_t1_3 = new System.Windows.Forms.Button();
            this.dgv_t1_1 = new System.Windows.Forms.DataGridView();
            this.cbo_t1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgv_t2_2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv_t2_1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t1_1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t2_1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_t1_2
            // 
            this.btn_t1_2.Location = new System.Drawing.Point(472, 16);
            this.btn_t1_2.Name = "btn_t1_2";
            this.btn_t1_2.Size = new System.Drawing.Size(125, 31);
            this.btn_t1_2.TabIndex = 9;
            this.btn_t1_2.Text = "등록(DataSet)";
            this.btn_t1_2.UseVisualStyleBackColor = true;
            this.btn_t1_2.Click += new System.EventHandler(this.btn_t5_2_Click);
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
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.dgv_t1_2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btn_t1_1);
            this.tabPage1.Controls.Add(this.btn_t1_3);
            this.tabPage1.Controls.Add(this.dgv_t1_1);
            this.tabPage1.Controls.Add(this.cbo_t1);
            this.tabPage1.Controls.Add(this.btn_t1_2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MSSql Wcf Client";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_t1_2
            // 
            this.dgv_t1_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_t1_2.Location = new System.Drawing.Point(442, 75);
            this.dgv_t1_2.Name = "dgv_t1_2";
            this.dgv_t1_2.RowTemplate.Height = 23;
            this.dgv_t1_2.Size = new System.Drawing.Size(342, 267);
            this.dgv_t1_2.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "조회(DataSet)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_t1_1
            // 
            this.btn_t1_1.Location = new System.Drawing.Point(234, 368);
            this.btn_t1_1.Name = "btn_t1_1";
            this.btn_t1_1.Size = new System.Drawing.Size(78, 29);
            this.btn_t1_1.TabIndex = 18;
            this.btn_t1_1.Text = "조회(List)";
            this.btn_t1_1.UseVisualStyleBackColor = true;
            this.btn_t1_1.Click += new System.EventHandler(this.btn_t1_1_Click);
            // 
            // btn_t1_3
            // 
            this.btn_t1_3.Location = new System.Drawing.Point(277, 18);
            this.btn_t1_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_t1_3.Name = "btn_t1_3";
            this.btn_t1_3.Size = new System.Drawing.Size(112, 29);
            this.btn_t1_3.TabIndex = 17;
            this.btn_t1_3.Text = "등록(List)";
            this.btn_t1_3.UseVisualStyleBackColor = true;
            this.btn_t1_3.Click += new System.EventHandler(this.btn_t1_3_Click);
            // 
            // dgv_t1_1
            // 
            this.dgv_t1_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_t1_1.Location = new System.Drawing.Point(23, 75);
            this.dgv_t1_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_t1_1.Name = "dgv_t1_1";
            this.dgv_t1_1.RowHeadersWidth = 51;
            this.dgv_t1_1.RowTemplate.Height = 27;
            this.dgv_t1_1.Size = new System.Drawing.Size(366, 268);
            this.dgv_t1_1.TabIndex = 16;
            // 
            // cbo_t1
            // 
            this.cbo_t1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_t1.FormattingEnabled = true;
            this.cbo_t1.Items.AddRange(new object[] {
            "Http",
            "NetTcp"});
            this.cbo_t1.Location = new System.Drawing.Point(23, 16);
            this.cbo_t1.Name = "cbo_t1";
            this.cbo_t1.Size = new System.Drawing.Size(134, 20);
            this.cbo_t1.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.dgv_t2_2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dgv_t2_1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(880, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(706, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 53);
            this.button5.TabIndex = 25;
            this.button5.Text = "Aws";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(594, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 53);
            this.button4.TabIndex = 24;
            this.button4.Text = "Oracle Wallet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgv_t2_2
            // 
            this.dgv_t2_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_t2_2.Location = new System.Drawing.Point(396, 127);
            this.dgv_t2_2.Name = "dgv_t2_2";
            this.dgv_t2_2.RowTemplate.Height = 23;
            this.dgv_t2_2.Size = new System.Drawing.Size(342, 267);
            this.dgv_t2_2.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 53);
            this.button3.TabIndex = 22;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv_t2_1
            // 
            this.dgv_t2_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_t2_1.Location = new System.Drawing.Point(48, 127);
            this.dgv_t2_1.Name = "dgv_t2_1";
            this.dgv_t2_1.RowTemplate.Height = 23;
            this.dgv_t2_1.Size = new System.Drawing.Size(342, 267);
            this.dgv_t2_1.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 53);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(694, 358);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 39);
            this.button6.TabIndex = 21;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 474);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDB";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t1_1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t2_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_t1_2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbo_t1;
        private System.Windows.Forms.DataGridView dgv_t1_1;
        private System.Windows.Forms.Button btn_t1_3;
        private System.Windows.Forms.Button btn_t1_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_t1_2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_t2_1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgv_t2_2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

