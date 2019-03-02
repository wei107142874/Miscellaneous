using ClassLibrary;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTwm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            //读取配置
            string conn = ConfigurationManager.AppSettings["Conn"].ToString();
            string[] cArray = conn.Split(new char[] { ';' },StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in cArray)
            {
                var d = item.Split('=');
                string name = d[0];
                string value = d[1];

                foreach (Control cur in tp_settings.Controls)
                {
                    if (cur is TextBox)
                    {
                        if (cur.Name.ToLower().Replace(" ", "").Contains(name.ToLower().Replace(" ", "")))
                        {
                            cur.Text = value;
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string conn = string.Empty;
            foreach (Control cur in tp_settings.Controls)
            {
                if (cur is TextBox)
                {
                    conn += cur.Name +"="+ cur.Text+";";
                }
            }
            conn = conn.Replace("tb_", "");

            MysqlHelper mysqlHelper = new MysqlHelper(conn);
            string res= mysqlHelper.TestConnString();
            if (res != "ok")
            {
                MessageBox.Show(res);
                return;
            }

            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings["Conn"].Value = conn;
            cfa.Save();
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("配置更新成功!");
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "(*.xls,*.xlsx)|*.xls;*.xlsx";
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    Thread thread = new Thread(t =>
                    {
                        Console.WriteLine("开始读取数据....");
                        DataTable dataTable = new ExcelHelper().ExcelSheetImportToDataTable(ofd.FileName, tb_sheet.Text);
                        Console.WriteLine("数据读取成功，开始写入.....");
                        List<string> cols = new List<string>();
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            cols.Add(dataTable.Columns[j].ColumnName);
                        }
                        List<string> vals = new List<string>();
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            List<string> rows = new List<string>();
                            for (int j = 0; j < cols.Count; j++)
                            {
                                string val = dataTable.Rows[i][cols[j]].ToString();
                                rows.Add(!string.IsNullOrEmpty(val) ? val : "NULL");
                            }

                            vals.Add("('" + (string.Join("','", rows  )) + "')");

                            if (vals.Count == Convert.ToInt32(tb_frequency.Text) || i + 1 == dataTable.Rows.Count)
                            {
                                //string str = string.Join(",", vals).Replace("'NULL'", "NULL");

                                string sql = $"Insert into {tb_tabname.Text} ({string.Join(",", cols)}) Values {string.Join(",", vals).Replace("'NULL'", "NULL")}";
                                int r = MysqlHelper.ExecuteNonQuery(CommandType.Text, sql);
                                if (r < 1)
                                {
                                    MessageBox.Show("数据写入失败!");
                                }
                                else
                                {
                                    Console.WriteLine("已写入：" + (i + 1) + "条，" + "完成率：" + Math.Round(((float)(i + 1) / dataTable.Rows.Count) * 100, 2) + "%");
                                    vals = new List<string>();
                                }
                            }
                        }
                        MessageBox.Show("数据写入成功!");
                    });
                    thread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        //private void btn_addfieid_Click(object sender, EventArgs e)
        //{
        //    Point point = new Point();
        //    foreach (Control item in tp_home.Controls)
        //    {
        //        if (item is Panel && item.Location.Y>point.Y)
        //        {
        //            point.Y = item.Location.Y;
        //            point.X = item.Location.X;
        //        }
        //    }
        //    point.Y += 35;

        //    Panel panel = new Panel();
        //    panel.Location = point;
        //    panel.Width = panel1.Width;
        //    panel.Height = panel1.Height;
        //    panel.Size = panel1.Size;
        //    tp_home.Controls.Add(panel);


        //    TextBox textBoxfieid = new TextBox();
        //    textBoxfieid.Location = tb_fieid.Location;
        //    textBoxfieid.Width = tb_fieid.Width;
        //    textBoxfieid.Height = tb_fieid.Height;
        //    TextBox textBoxcol = new TextBox();
        //    textBoxcol.Location = tb_colum.Location;
        //    textBoxcol.Width = tb_colum.Width;
        //    textBoxcol.Height = tb_colum.Height;
        //    panel.Controls.Add(textBoxfieid);
        //    panel.Controls.Add(textBoxcol);
        //}
    }
}