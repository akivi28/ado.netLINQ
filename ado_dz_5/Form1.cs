using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado_dz_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using(DataClassesDataContext context = new DataClassesDataContext())
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            dataGridView1.DataSource = context.Information;
                        }
                        break;
                    case 1:
                        {
                            dataGridView1.DataSource = context.Information
                                .Select(t => new { t.Name });
                        }break;
                    case 2:
                        {
                            dataGridView1.DataSource = context.Information
                                .Select(t => new { t.Capital });
                        }
                        break;
                    case 3:
                        {
                            dataGridView1.DataSource = context.Information
                                .Where(t => t.Continent == "Europe")
                                .Select(t => new { t.Name });
                        }
                        break;
                    case 4:
                        {
                            dataGridView1.DataSource = context.Information
                                .Where(t => t.Area > 600000)
                                .Select(t => new { t.Name });
                        }
                        break;
                    case 5:
                        {
                            dataGridView1.DataSource = context.Information
                                .Where(t => t.Name.Contains("a") && t.Name.Contains("u"))
                                .Select(t => new { t.Name });
                        }
                        break;
                    case 6:
                        {
                            dataGridView1.DataSource = context.Information
                                .Where(t => t.Name.Contains("a"))
                                .Select(t => new { t.Name });
                        }
                        break;
                    case 7:
                        {
                            dataGridView1.DataSource = context.Information
                                .Where(t => t.Area > 300000 && t.Area < 600000)
                                .Select(t => new { t.Name });
                        }
                        break;
                    case 8:
                        {
                            dataGridView1.DataSource = context.Information
                                .Where(t => t.NumberOfInhabitants > 50000000)
                                .Select(t => new { t.Name });
                        }
                        break;
                    case 9:
                        {
                            dataGridView1.DataSource = context.Information
                                .OrderByDescending(t => t.Area)
                                .Take(5)
                                .Select (t => new { t.Name, t.Area });
                        }
                        break;
                    case 10:
                        {
                            dataGridView1.DataSource = context.Information
                                .OrderByDescending(t => t.NumberOfInhabitants)
                                .Take(5)
                                .Select(t => new { t.Name, t.NumberOfInhabitants });
                        }
                        break;
                    case 11:
                        {
                            dataGridView1.DataSource = context.Information
                            .OrderByDescending(t => t.Area)
                            .Take(1)
                            .Select(t => new { t.Name, t.Area });
                        }
                        break;
                    case 12:
                        {
                            dataGridView1.DataSource = context.Information
                            .OrderByDescending(t => t.NumberOfInhabitants)
                            .Take(1)
                            .Select(t => new { t.Name, t.NumberOfInhabitants });
                        }
                        break;
                    case 13:
                        {
                            dataGridView1.DataSource = context.Information
                            .Where(t => t.Continent == "Asia")
                            .OrderBy(t => t.Area)
                            .Take(1)
                            .Select(t => new { t.Name, t.Area });
                        }
                        break;
                    case 14:
                        {
                            double averageAreaInAsia = (double)context.Information
                            .Where(t => t.Continent == "Asia")
                            .Average(t => t.Area);

                            var averageAreaList = new List<double> { averageAreaInAsia };

                            dataGridView1.DataSource = averageAreaList
                                .Select(area => new { AverageAreaInAsia = area })
                                .ToList();
                        }
                        break;
                    default:
                        {

                        }
                        break;
                }
            }
        }
    }
}
