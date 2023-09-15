using MyDocument.Model;
using MyDocument.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDocument
{
    public partial class fmDocument : Form
    {
        DocumentsOutService service;
        public fmDocument()
        {
            InitializeComponent();
            service = new DocumentsOutService();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            gvDocuments.DataSource = service.getDocumentsOut(tpBegin.Value, tpEnd.Value);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNameDocument.Text))
            {
                MessageBox.Show("Название документа не заполнено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNameDocument.Focus();
                return;
            }
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            string fileName = openFileDialog1.FileName;
            var newFile = Guid.NewGuid().ToString() + Path.GetExtension(fileName);

            tbScanFileName.Text = fileName;

            DocumentsOut doc = new DocumentsOut()
            {
                NameDocument = tbNameDocument.Text,
                InitiatePerson = tbInitiatePerson.Text,
                Notes = tbNotes.Text,
                ScanFileName = ConfigurationManager.AppSettings["folder"] + "\\" + newFile,
            };
            var result2 = service.DocumentsOutAdd(doc);
            if (result2 == Status.OK)
            {
                File.Copy(fileName, ConfigurationManager.AppSettings["folder"] + "\\" + newFile);
                MessageBox.Show("Документ успешно добавлен", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvDocuments.DataSource = service.getDocumentsOut(tpBegin.Value, tpEnd.Value);
            }
            else
                MessageBox.Show("Ошибка добавления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
