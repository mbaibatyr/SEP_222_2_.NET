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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello STEP!", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Hello STEP!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_2.Items.Clear();
            //for (int i = 0; i < lb_1.Items.Count; i++)
            //{
            //    if (int.Parse(lb_1.Items[i].ToString()) >= 5)
            //        lb_2.Items.Add(lb_1.Items[i]);
            //}

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] >= 5)
            //        lb_2.Items.Add(array[i]);
            //}

            var result_1 = array.Where(z => z >= 5)
                            .OrderByDescending(z => z);
            var result_2 = from z in array
                           where z >= 5
                           orderby z descending
                           select z;

            //lb_2.Items.Add(array.First());
            //lb_2.Items.Add(array.Last());

            lb_2.Items.Add(array.Min());
            lb_2.Items.Add(array.Max());
            lb_2.Items.Add(array.Average());


            //foreach (var item in result_2)
            //{
            //    lb_2.Items.Add(item);
            //}  

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] array_1 = lb_1.Items.OfType<string>().ToArray();
            string[] array_2 = lb_3.Items.OfType<string>().ToArray();

            var result_concat = array_1.Concat(array_2);
            var result_union = array_1.Union(array_2);
            var result_intersect = array_1.Intersect(array_2);
            var result_except = array_2.Except(array_1);


            lb_2.Items.AddRange(result_except.ToArray());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<City> lst = new List<City>()
            {
                new City{id=1, name="Almaty"},
                new City{id=2, name="Atyrau"},
                new City{id=3, name="Astana"}
            };

            var result_1 = lst.Where(z => z.id == 4).FirstOrDefault();
            //if (result_1 != null)
            //    lb_2.Items.Add($"{result_1.id} - {result_1.name}");
            //else
            //    lb_2.Items.Add("empty");

            //foreach (var item in result_1)
            //{
            //    lb_2.Items.Add($"{item.id} - {item.name}");
            //}

            //var result_2 = from z in lst
            //               where z.id >= 2
            //               select new
            //               {
            //                   id_name = z.id + " " + z.name
            //               };

            //foreach (var item in result_2)
            //{
            //    lb_2.Items.Add($"{item.id_name}");
            //}

            //var result_3 = lst.Any(z => z.name.StartsWith("a"));

            //var result_4 = lst.All(z => z.name.StartsWith("a"));

            var result_5 = lst.Skip(1).Take(3);
            foreach (var item in result_5)
            {
                lb_2.Items.Add($"{item.name}");
            }

        }
    }

    class City
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
