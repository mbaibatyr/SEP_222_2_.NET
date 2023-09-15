namespace MyDocument
{
    partial class fmDocument
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvDocuments = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tpBegin = new System.Windows.Forms.DateTimePicker();
            this.tpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbNameDocument = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInitiatePerson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbScanFileName = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocuments)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 176);
            this.panel1.TabIndex = 0;
            // 
            // gvDocuments
            // 
            this.gvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDocuments.Location = new System.Drawing.Point(0, 176);
            this.gvDocuments.Name = "gvDocuments";
            this.gvDocuments.Size = new System.Drawing.Size(1102, 377);
            this.gvDocuments.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tpEnd);
            this.panel2.Controls.Add(this.tpBegin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 176);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.btAdd);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbScanFileName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbNotes);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbInitiatePerson);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbNameDocument);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(465, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 176);
            this.panel3.TabIndex = 1;
            // 
            // tpBegin
            // 
            this.tpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tpBegin.Location = new System.Drawing.Point(149, 29);
            this.tpBegin.Name = "tpBegin";
            this.tpBegin.Size = new System.Drawing.Size(109, 20);
            this.tpBegin.TabIndex = 0;
            // 
            // tpEnd
            // 
            this.tpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tpEnd.Location = new System.Drawing.Point(149, 74);
            this.tpEnd.Name = "tpEnd";
            this.tpEnd.Size = new System.Drawing.Size(109, 20);
            this.tpEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата с";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата по";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(300, 72);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Найти";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbNameDocument
            // 
            this.tbNameDocument.Location = new System.Drawing.Point(132, 12);
            this.tbNameDocument.Multiline = true;
            this.tbNameDocument.Name = "tbNameDocument";
            this.tbNameDocument.Size = new System.Drawing.Size(358, 48);
            this.tbNameDocument.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(31, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Наименование документа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Инициатор";
            // 
            // tbInitiatePerson
            // 
            this.tbInitiatePerson.Location = new System.Drawing.Point(132, 72);
            this.tbInitiatePerson.Name = "tbInitiatePerson";
            this.tbInitiatePerson.Size = new System.Drawing.Size(358, 20);
            this.tbInitiatePerson.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Примечания";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(132, 98);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(358, 20);
            this.tbNotes.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Путь к файлу";
            // 
            // tbScanFileName
            // 
            this.tbScanFileName.Location = new System.Drawing.Point(132, 130);
            this.tbScanFileName.Name = "tbScanFileName";
            this.tbScanFileName.Size = new System.Drawing.Size(358, 20);
            this.tbScanFileName.TabIndex = 6;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(537, 127);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fmDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 553);
            this.Controls.Add(this.gvDocuments);
            this.Controls.Add(this.panel1);
            this.Name = "fmDocument";
            this.Text = "Исходящие";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDocuments)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvDocuments;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tpEnd;
        private System.Windows.Forms.DateTimePicker tpBegin;
        private System.Windows.Forms.TextBox tbNameDocument;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInitiatePerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbScanFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

