namespace Devdas_Chatterjee_Lab05_EX01
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
            this.textBox_int_value = new System.Windows.Forms.TextBox();
            this.textBox_int_search = new System.Windows.Forms.TextBox();
            this.button_int_search = new System.Windows.Forms.Button();
            this.textBox_int_search_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_double_search_result = new System.Windows.Forms.TextBox();
            this.button_double_search = new System.Windows.Forms.Button();
            this.textBox_double_search = new System.Windows.Forms.TextBox();
            this.textBox_double_value = new System.Windows.Forms.TextBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_int_value
            // 
            this.textBox_int_value.Location = new System.Drawing.Point(12, 36);
            this.textBox_int_value.Multiline = true;
            this.textBox_int_value.Name = "textBox_int_value";
            this.textBox_int_value.Size = new System.Drawing.Size(169, 190);
            this.textBox_int_value.TabIndex = 0;
            this.textBox_int_value.TextChanged += new System.EventHandler(this.textBox_int_value_TextChanged);
            // 
            // textBox_int_search
            // 
            this.textBox_int_search.Location = new System.Drawing.Point(240, 62);
            this.textBox_int_search.Name = "textBox_int_search";
            this.textBox_int_search.Size = new System.Drawing.Size(118, 20);
            this.textBox_int_search.TabIndex = 0;
            // 
            // button_int_search
            // 
            this.button_int_search.Location = new System.Drawing.Point(240, 123);
            this.button_int_search.Name = "button_int_search";
            this.button_int_search.Size = new System.Drawing.Size(100, 27);
            this.button_int_search.TabIndex = 1;
            this.button_int_search.Text = "Search >>";
            this.button_int_search.UseVisualStyleBackColor = true;
            this.button_int_search.Click += new System.EventHandler(this.button_int_search_Click);
            // 
            // textBox_int_search_result
            // 
            this.textBox_int_search_result.Location = new System.Drawing.Point(424, 36);
            this.textBox_int_search_result.Multiline = true;
            this.textBox_int_search_result.Name = "textBox_int_search_result";
            this.textBox_int_search_result.Size = new System.Drawing.Size(151, 190);
            this.textBox_int_search_result.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Int Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Search Data Here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Int Search Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Double Search Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enter Search Data Here";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Double Value";
            // 
            // textBox_double_search_result
            // 
            this.textBox_double_search_result.Location = new System.Drawing.Point(424, 277);
            this.textBox_double_search_result.Multiline = true;
            this.textBox_double_search_result.Name = "textBox_double_search_result";
            this.textBox_double_search_result.Size = new System.Drawing.Size(151, 190);
            this.textBox_double_search_result.TabIndex = 10;
            // 
            // button_double_search
            // 
            this.button_double_search.Location = new System.Drawing.Point(240, 364);
            this.button_double_search.Name = "button_double_search";
            this.button_double_search.Size = new System.Drawing.Size(100, 27);
            this.button_double_search.TabIndex = 9;
            this.button_double_search.Text = "Search >>";
            this.button_double_search.UseVisualStyleBackColor = true;
            this.button_double_search.Click += new System.EventHandler(this.button_double_search_Click);
            // 
            // textBox_double_search
            // 
            this.textBox_double_search.Location = new System.Drawing.Point(240, 303);
            this.textBox_double_search.Name = "textBox_double_search";
            this.textBox_double_search.Size = new System.Drawing.Size(118, 20);
            this.textBox_double_search.TabIndex = 8;
            // 
            // textBox_double_value
            // 
            this.textBox_double_value.Location = new System.Drawing.Point(12, 277);
            this.textBox_double_value.Multiline = true;
            this.textBox_double_value.Name = "textBox_double_value";
            this.textBox_double_value.Size = new System.Drawing.Size(169, 190);
            this.textBox_double_value.TabIndex = 7;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(500, 484);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 14;
            this.button_Exit.Text = "E&xit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 519);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_double_search_result);
            this.Controls.Add(this.button_double_search);
            this.Controls.Add(this.textBox_double_search);
            this.Controls.Add(this.textBox_double_value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_int_search_result);
            this.Controls.Add(this.button_int_search);
            this.Controls.Add(this.textBox_int_search);
            this.Controls.Add(this.textBox_int_value);
            this.Name = "Form1";
            this.Text = "Search Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_int_value;
        private System.Windows.Forms.TextBox textBox_int_search;
        private System.Windows.Forms.Button button_int_search;
        private System.Windows.Forms.TextBox textBox_int_search_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_double_search_result;
        private System.Windows.Forms.Button button_double_search;
        private System.Windows.Forms.TextBox textBox_double_search;
        private System.Windows.Forms.TextBox textBox_double_value;
        private System.Windows.Forms.Button button_Exit;
    }
}

