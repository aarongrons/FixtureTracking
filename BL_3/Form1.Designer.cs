namespace BL_3
{
    partial class TestForm
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
            this.tab_checkout = new System.Windows.Forms.TabPage();
            this.LB_CheckedOut = new System.Windows.Forms.ListBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.cb_lines = new System.Windows.Forms.ComboBox();
            this.lbl_partNum = new System.Windows.Forms.Label();
            this.LB_CheckoutData = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_partNum = new System.Windows.Forms.TextBox();
            this.lbl_line = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btn_undo = new System.Windows.Forms.Button();
            this.tab_checkout.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_checkout
            // 
            this.tab_checkout.Controls.Add(this.btn_undo);
            this.tab_checkout.Controls.Add(this.LB_CheckedOut);
            this.tab_checkout.Controls.Add(this.btn_return);
            this.tab_checkout.Controls.Add(this.cb_lines);
            this.tab_checkout.Controls.Add(this.lbl_partNum);
            this.tab_checkout.Controls.Add(this.LB_CheckoutData);
            this.tab_checkout.Controls.Add(this.button1);
            this.tab_checkout.Controls.Add(this.txt_partNum);
            this.tab_checkout.Controls.Add(this.lbl_line);
            this.tab_checkout.Location = new System.Drawing.Point(4, 22);
            this.tab_checkout.Margin = new System.Windows.Forms.Padding(2);
            this.tab_checkout.Name = "tab_checkout";
            this.tab_checkout.Padding = new System.Windows.Forms.Padding(2);
            this.tab_checkout.Size = new System.Drawing.Size(1788, 808);
            this.tab_checkout.TabIndex = 0;
            this.tab_checkout.Text = "Part Checkout";
            this.tab_checkout.UseVisualStyleBackColor = true;
            // 
            // LB_CheckedOut
            // 
            this.LB_CheckedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CheckedOut.FormattingEnabled = true;
            this.LB_CheckedOut.ItemHeight = 29;
            this.LB_CheckedOut.Location = new System.Drawing.Point(405, 156);
            this.LB_CheckedOut.Margin = new System.Windows.Forms.Padding(2);
            this.LB_CheckedOut.Name = "LB_CheckedOut";
            this.LB_CheckedOut.Size = new System.Drawing.Size(1364, 613);
            this.LB_CheckedOut.TabIndex = 14;
            // 
            // btn_return
            // 
            this.btn_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(46, 510);
            this.btn_return.Margin = new System.Windows.Forms.Padding(2);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(326, 232);
            this.btn_return.TabIndex = 13;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // cb_lines
            // 
            this.cb_lines.DropDownHeight = 200;
            this.cb_lines.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_lines.FormattingEnabled = true;
            this.cb_lines.IntegralHeight = false;
            this.cb_lines.ItemHeight = 29;
            this.cb_lines.Items.AddRange(new object[] {
            "503A",
            "503B",
            "504A",
            "504B",
            "505A",
            "505B",
            "506A",
            "506B",
            "507A",
            "507B",
            "508A",
            "508B",
            "509A",
            "509B",
            "510A",
            "510B",
            "511A",
            "511B",
            "512A",
            "512B",
            "513A",
            "513B"});
            this.cb_lines.Location = new System.Drawing.Point(196, 100);
            this.cb_lines.Margin = new System.Windows.Forms.Padding(2);
            this.cb_lines.Name = "cb_lines";
            this.cb_lines.Size = new System.Drawing.Size(186, 37);
            this.cb_lines.TabIndex = 11;
            this.cb_lines.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_partNum
            // 
            this.lbl_partNum.AutoSize = true;
            this.lbl_partNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_partNum.Location = new System.Drawing.Point(15, 176);
            this.lbl_partNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_partNum.Name = "lbl_partNum";
            this.lbl_partNum.Size = new System.Drawing.Size(149, 29);
            this.lbl_partNum.TabIndex = 3;
            this.lbl_partNum.Text = "Part Number";
            // 
            // LB_CheckoutData
            // 
            this.LB_CheckoutData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CheckoutData.FormattingEnabled = true;
            this.LB_CheckoutData.ItemHeight = 29;
            this.LB_CheckoutData.Location = new System.Drawing.Point(405, 22);
            this.LB_CheckoutData.Margin = new System.Windows.Forms.Padding(2);
            this.LB_CheckoutData.Name = "LB_CheckoutData";
            this.LB_CheckoutData.Size = new System.Drawing.Size(1364, 120);
            this.LB_CheckoutData.TabIndex = 0;
            this.LB_CheckoutData.SelectedIndexChanged += new System.EventHandler(this.LB_CheckoutData_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(46, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 228);
            this.button1.TabIndex = 5;
            this.button1.Text = "Check Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_partNum
            // 
            this.txt_partNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partNum.Location = new System.Drawing.Point(196, 174);
            this.txt_partNum.Margin = new System.Windows.Forms.Padding(2);
            this.txt_partNum.Name = "txt_partNum";
            this.txt_partNum.Size = new System.Drawing.Size(186, 35);
            this.txt_partNum.TabIndex = 1;
            this.txt_partNum.TextChanged += new System.EventHandler(this.txt_partNum_TextChanged);
            // 
            // lbl_line
            // 
            this.lbl_line.AutoSize = true;
            this.lbl_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_line.Location = new System.Drawing.Point(74, 102);
            this.lbl_line.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(59, 29);
            this.lbl_line.TabIndex = 4;
            this.lbl_line.Text = "Line";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_checkout);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1796, 834);
            this.tabControl1.TabIndex = 11;
            // 
            // btn_undo
            // 
            this.btn_undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_undo.Location = new System.Drawing.Point(46, 763);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(326, 36);
            this.btn_undo.TabIndex = 15;
            this.btn_undo.Text = "Undo Return";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1540, 843);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TestForm";
            this.Text = "Blue Lightning Tracker";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.tab_checkout.ResumeLayout(false);
            this.tab_checkout.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tab_checkout;
        private System.Windows.Forms.ListBox LB_CheckedOut;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.ComboBox cb_lines;
        private System.Windows.Forms.Label lbl_partNum;
        private System.Windows.Forms.ListBox LB_CheckoutData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_partNum;
        private System.Windows.Forms.Label lbl_line;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_undo;
    }
}

