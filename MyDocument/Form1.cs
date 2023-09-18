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
        string Id;
        public fmDocument()
        {
            InitializeComponent();
            service = new DocumentsOutService();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            gvDocuments.DataSource = service.getDocumentsOut(tpBegin.Value, tpEnd.Value);
            Id = null;
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

        private void btEdit_Click(object sender, EventArgs e)
        {
            if(Id == null)
            {
                MessageBox.Show("Для измненения необходимо выделить строчку", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fmEdit edit = new fmEdit();
            var model = service.getDocumentsOutById(Id);
            if (model == null)
                return;
            edit.tbNotes.Text = model.Notes;
            edit.tbNameDocument.Text = model.NameDocument;
            edit.tbInitiatePerson.Text = model.InitiatePerson;
            var result = edit.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            DocumentsOut doc = new DocumentsOut
            {
                Id = int.Parse(Id),
                NameDocument = edit.tbNameDocument.Text,
                InitiatePerson = edit.tbInitiatePerson.Text,
                Notes = edit.tbNotes.Text
            };
            if(service.DocumentsOutEdit(doc) == Status.OK)
            {
                MessageBox.Show("Документ успешно обновлен", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btSearch_Click(null, null);
            }
            else
                MessageBox.Show("При обновлении Документа произошла ошибка", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void gvDocuments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = gvDocuments.Rows[e.RowIndex].Cells[0].Value.ToString();            
            if (gvDocuments.Rows[e.RowIndex].Cells[5].Value == null || gvDocuments.Rows[e.RowIndex].Cells[5].Value.ToString() == "")
            {
                pbScanDocument.ImageLocation = null;                
                return;
            }
            pbScanDocument.ImageLocation = ConfigurationManager.AppSettings["path"] + gvDocuments.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (Id == null)
            {
                MessageBox.Show("Для удаления необходимо выделить строчку", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show("Вы уверены в том что хотите удалить документ?", "Инфо", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
                return;

            if (service.DocumentsOutDelete(Id) == Status.OK)
            {
                MessageBox.Show("Документ успешно удален", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btSearch_Click(null, null);
            }
            else
                MessageBox.Show("При удалении Документа произошла ошибка", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
