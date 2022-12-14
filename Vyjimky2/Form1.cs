using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyjimky2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int soucin = 1;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (!sr.EndOfStream)
                        {
                                soucin *= Int32.Parse(sr.ReadLine());   
                        }
                    }
                }
                MessageBox.Show("soucin: " + soucin);
            }
            catch (FileNotFoundException) { 
                MessageBox.Show("Soubor nenalezen"); 
            }
            catch (FormatException) { 
                MessageBox.Show("Blbej formát"); 
            }
            catch (OverflowException) {
                MessageBox.Show("Přetečeni");
            }
            catch (ArithmeticException) { 
                MessageBox.Show("Čísla!");
            }
        }
    }
}
