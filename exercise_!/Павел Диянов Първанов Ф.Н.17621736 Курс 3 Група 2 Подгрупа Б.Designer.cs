namespace exercise__
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
            this.button1_scan = new System.Windows.Forms.Button();
            this.button2_sort = new System.Windows.Forms.Button();
            this.button3_result = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Counting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 289);
            this.label1.TabIndex = 0;
            // 
            // button1_scan
            // 
            this.button1_scan.Location = new System.Drawing.Point(12, 365);
            this.button1_scan.Name = "button1_scan";
            this.button1_scan.Size = new System.Drawing.Size(114, 23);
            this.button1_scan.TabIndex = 1;
            this.button1_scan.Text = "1. Scanner";
            this.button1_scan.UseVisualStyleBackColor = true;
            this.button1_scan.Click += new System.EventHandler(this.button1_scan_Click);
            // 
            // button2_sort
            // 
            this.button2_sort.Location = new System.Drawing.Point(146, 365);
            this.button2_sort.Name = "button2_sort";
            this.button2_sort.Size = new System.Drawing.Size(114, 23);
            this.button2_sort.TabIndex = 2;
            this.button2_sort.Text = "2. Sort";
            this.button2_sort.UseVisualStyleBackColor = true;
            this.button2_sort.Click += new System.EventHandler(this.button2_sort_Click);
            // 
            // button3_result
            // 
            this.button3_result.Location = new System.Drawing.Point(279, 365);
            this.button3_result.Name = "button3_result";
            this.button3_result.Size = new System.Drawing.Size(114, 23);
            this.button3_result.TabIndex = 3;
            this.button3_result.Text = "3. Result";
            this.button3_result.UseVisualStyleBackColor = true;
            this.button3_result.Click += new System.EventHandler(this.button3_result_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 339);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(279, 339);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(114, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Време за сканиране";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(146, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Време за сортиране";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(279, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Време за преброяване";
            // 
            // textBox4
            // 
            this.textBox4.AcceptsReturn = true;
            this.textBox4.Location = new System.Drawing.Point(418, 38);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(115, 321);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(418, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Брой числа";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(491, 369);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(42, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(561, 38);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(115, 351);
            this.textBox6.TabIndex = 13;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numbers,
            this.Counting});
            this.dataGridView1.Location = new System.Drawing.Point(694, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(193, 380);
            this.dataGridView1.TabIndex = 14;
            // 
            // Numbers
            // 
            this.Numbers.HeaderText = "ЧИСЛА";
            this.Numbers.Name = "Numbers";
            this.Numbers.ReadOnly = true;
            // 
            // Counting
            // 
            this.Counting.HeaderText = "БРОЙ";
            this.Counting.Name = "Counting";
            this.Counting.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(418, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "ЧИСЛА";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(561, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "СОРТИРАНИ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 395);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3_result);
            this.Controls.Add(this.button2_sort);
            this.Controls.Add(this.button1_scan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Павел Диянов Първанов Ф.Н.17621736 Курс 3 Група 2 Подгрупа Б";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_scan;
        private System.Windows.Forms.Button button2_sort;
        private System.Windows.Forms.Button button3_result;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counting;
    }
}

