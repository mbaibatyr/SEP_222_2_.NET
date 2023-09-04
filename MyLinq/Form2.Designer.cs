namespace MyLinq
{
    partial class Form2
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
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.cb_operation = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(75, 43);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(100, 20);
            this.tb_1.TabIndex = 1;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(258, 44);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(100, 20);
            this.tb_2.TabIndex = 2;
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(75, 106);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(100, 20);
            this.tb_result.TabIndex = 4;
            // 
            // cb_operation
            // 
            this.cb_operation.FormattingEnabled = true;
            this.cb_operation.Items.AddRange(new object[] {
            "+",
            "*",
            "-",
            "/"});
            this.cb_operation.Location = new System.Drawing.Point(199, 44);
            this.cb_operation.Name = "cb_operation";
            this.cb_operation.Size = new System.Drawing.Size(40, 21);
            this.cb_operation.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 196);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cb_operation);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.ComboBox cb_operation;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
    }
}