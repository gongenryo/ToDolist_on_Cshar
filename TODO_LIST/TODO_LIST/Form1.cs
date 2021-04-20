using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO_LIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            load();　　　　　//ロード時に保存内容の反映
        }

        //ToDoクラスの作成
        public class ToDo
        {
            public Boolean 完了;
            public string 期限;
            public string 内容;
            public Boolean 削除;
        }

        //前回の保存内容の読み込みの関数
        private void load()
        {
            //XMLファイル→List<ToDo>
            List<ToDo> list;
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<ToDo>));
            using (var fs = new System.IO.FileStream("todo.xml", System.IO.FileMode.Open))
            {
                list = (List<ToDo>)serializer.Deserialize(fs);
            }

            //List<ToDo>→DataGridView
            grid.RowCount = list.Count();
            for (int row = 0; row < grid.RowCount; row++)
            {
                ToDo obj = list[row];

                grid[0, row].Value = obj.完了;
                grid[1, row].Value = obj.期限;
                grid[2, row].Value = obj.内容;
                grid[3, row].Value = obj.完了;
            }

        }

        private void Regist_Click(object sender, EventArgs e)
        {
            grid.Rows.Add(false, dTP.Value.ToString("yyyy/MM/dd"), textBox1.Text, false);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid.RowCount; i++)
            {
                if (Convert.ToBoolean(grid.Rows[i].Cells[3].Value) == true)
                {
                    grid.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            List<ToDo> list = new List<ToDo>();

            for (int row = 0; row < grid.RowCount; row++)
            {
                ToDo obj = new ToDo
                {
                    完了 = Convert.ToBoolean(grid[0, row].Value),
                    期限 = grid[1, row].Value.ToString(),
                    内容 = grid[2, row].Value.ToString(),
                    削除 = Convert.ToBoolean(grid[3, row].Value)
                };

                list.Add(obj);
            }

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<ToDo>));
            using (var fs = new System.IO.FileStream("todo.xml", System.IO.FileMode.Create))
            {
                serializer.Serialize(fs, list);
            }
        }

        //完了全選択の行動
        private void Allselect_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < grid.RowCount; i++)
            {
                if (Convert.ToBoolean(grid[0, i].Value) == false)
                {
                    grid[0, i].Value = true;
                }
            }
        }

        //完了全非選択の行動
        private void Allunselect_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < grid.RowCount; i++)
            {
                if (Convert.ToBoolean(grid[0, i].Value) == true)
                {
                    grid[0, i].Value = false;
                }
            }
        }

        //完了非表示の行動
        private void Hidden_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < grid.RowCount; i++)
            {
                if (Convert.ToBoolean(grid[0, i].Value))
                {
                    grid.Rows[i].Visible = false;
                }
            }
        }

        //完了再表示の行動
        private void Redisplay_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < grid.RowCount; i++)
            {
                if (Convert.ToBoolean(grid[0, i].Value))
                {
                    grid.Rows[i].Visible = true;
                }
            }
        }
    }
}
