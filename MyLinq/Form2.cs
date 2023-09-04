using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLinq
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        StatusEnum Calculate(DateTime dt)
        {

        }

        ReturnObject Calculate(int a, int b, string operation)
        {
            string result = null;
            string error = null;
            StatusEnum status;
            try
            {
                switch (operation)
                {
                    case "+":
                        result = (a + b).ToString();
                        break;
                    case "-":
                        result = (a - b).ToString();
                        break;
                    case "*":
                        result = (a * b).ToString();
                        break;
                    case "/":
                        result = (a / b).ToString();
                        break;
                    default:
                        break;
                }
                status = StatusEnum.OK;
            }
            catch (Exception err)
            {
                error = err.Message;
                status = StatusEnum.ERROR;
            }

            return new ReturnObject
            {
                Result = result,
                Error = error,
                statusEnum = status
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = Calculate(int.Parse(tb_1.Text), int.Parse(tb_2.Text), cb_operation.Text);
            if (result.statusEnum == StatusEnum.OK)
                tb_result.Text = result.Result;
            else
            {
                tb_result.Text = null;
                MessageBox.Show(result.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }

    class ReturnObject
    {
        public StatusEnum statusEnum { get; set; }
        public string Result { get; set; }
        public string Error { get; set; }
    }

    enum StatusEnum
    {
        OK,
        ERROR
    }
}
