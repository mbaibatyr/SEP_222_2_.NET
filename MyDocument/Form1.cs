using MyDocument.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
