using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GDI
{

    public partial class menu : Form
    {
        char last_el = ' ';
        public Building f;
        public author r;
        public help h;
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nP1 = 0, nP2 = 0;
            try
            {   

                string[] sG1 = textBox1.Text.Split(',');
                int[] G1 = new int[sG1.Length];
                for (int i = 0; i < sG1.Length; i++)
                {
                    
                    G1[i] = Convert.ToInt32(sG1[i]);
                   
                }

                string[] sG2 = textBox2.Text.Split(',');
                int[] G2 = new int[sG2.Length];
                for (int i = 0; i < sG2.Length; i++)
                {                   
                    G2[i] = Convert.ToInt32(sG2[i]);
                    
                }
                //
                string[] sP1 = textBox_P1.Text.Split(',');
                int[] P1 = new int[sP1.Length];
                for (int i = 0; i < sP1.Length; i++)
                {
                    P1[i] = Convert.ToInt32(sP1[i]);
                    
                }
                //

                //
                string[] sP2 = textBox_P2.Text.Split(',');
                int[] P2 = new int[sP2.Length];
                for (int i = 0; i < sP2.Length; i++)
                {
                    P2[i] = Convert.ToInt32(sP2[i]);
                    
                }
                //
                nP1 = P1.Length;
                nP2 = P2.Length;

                int maxValue = G1.Max<int>();
                int maxValue1 = G2.Max<int>();
                if (maxValue > nP1 || maxValue1 > nP2 || nP1 > 20 || nP2 > 20)
                    maxValue = maxValue / 0;
                f = new Building(G1, G2, P1, P2);
                f.Show();
            }
            catch
            {               
                MessageBox.Show("Введите данные правильно!", "Сообщение");
            }

           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (number == ',' && last_el == number)
                e.Handled = true;
            last_el = number;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;  //
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (number == ',' && last_el == number)
                e.Handled = true;
            last_el = number;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;  //
            }
        }

        private void textBox_P1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (number == ',' && last_el == number)
                e.Handled = true;
            last_el = number;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;  //
            }
        }

        private void textBox_P2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (number == ',' && last_el == number)
                e.Handled = true;
            last_el = number;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;  //
            }
        }

        private void author_button_Click(object sender, EventArgs e)
        {
            r = new author();
            r.Show();
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            h = new help();
            h.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadToEnd();
            textBox1.Text = line;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadToEnd();
            textBox2.Text = line;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadToEnd();
            textBox_P1.Text = line;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadToEnd();
            textBox_P2.Text = line;
        }
    }
}
