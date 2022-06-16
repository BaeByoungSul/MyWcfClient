namespace WcfClient
{
    partial class frmOracle
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbo_t1 = new System.Windows.Forms.ComboBox();
            this.dgv_t1_1 = new System.Windows.Forms.DataGridView();
            this.dgv_t1_2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t1_2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "조회1(Text)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "조회2( Package )";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "등록1( Text )";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbo_t1
            // 
            this.cbo_t1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_t1.FormattingEnabled = true;
            this.cbo_t1.Items.AddRange(new object[] {
            "Http",
            "NetTcp"});
            this.cbo_t1.Location = new System.Drawing.Point(25, 12);
            this.cbo_t1.Name = "cbo_t1";
            this.cbo_t1.Size = new System.Drawing.Size(134, 20);
            this.cbo_t1.TabIndex = 15;
            // 
            // dgv_t1_1
            // 
            this.dgv_t1_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_t1_1.Location = new System.Drawing.Point(25, 139);
            this.dgv_t1_1.Name = "dgv_t1_1";
            this.dgv_t1_1.RowTemplate.Height = 23;
            this.dgv_t1_1.Size = new System.Drawing.Size(341, 246);
            this.dgv_t1_1.TabIndex = 16;
            // 
            // dgv_t1_2
            // 
            this.dgv_t1_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_t1_2.Location = new System.Drawing.Point(404, 141);
            this.dgv_t1_2.Name = "dgv_t1_2";
            this.dgv_t1_2.RowTemplate.Height = 23;
            this.dgv_t1_2.Size = new System.Drawing.Size(342, 244);
            this.dgv_t1_2.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(433, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 49);
            this.button4.TabIndex = 18;
            this.button4.Text = "등록2( Text2 )";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(558, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 49);
            this.button5.TabIndex = 19;
            this.button5.Text = "등록2( package )";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(468, 391);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 49);
            this.button6.TabIndex = 20;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmOracle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgv_t1_2);
            this.Controls.Add(this.dgv_t1_1);
            this.Controls.Add(this.cbo_t1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmOracle";
            this.Text = "frmOracle";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_t1_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbo_t1;
        private System.Windows.Forms.DataGridView dgv_t1_1;
        private System.Windows.Forms.DataGridView dgv_t1_2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}