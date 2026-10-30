using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace besinci_tsk
{
    public partial class Form1 : Form
    {
        string fayl = Path.Combine(Application.StartupPath, "qeydler.txt");
        public Form1()
        {
            InitializeComponent();
            
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            try
            {
                string metn = txtQeyd.Text.Trim();

                if (string.IsNullOrWhiteSpace(metn))
                {
                    MessageBox.Show("Qeyd daxil edin!");
                    return;
                }

                string tarix = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

                using (StreamWriter sw = new StreamWriter(fayl, true, Encoding.UTF8))
                {
                    sw.WriteLine(tarix + " - " + metn);
                }

                MessageBox.Show("Qeyd saxlanildi!");
                txtQeyd.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xeta: " + ex.Message);
            }
        }

        private void btnYeni_Click_1(object sender, EventArgs e)
        {
            try
            {
                string metn = txtQeyd.Text.Trim();

                if (string.IsNullOrWhiteSpace(metn))
                {
                    MessageBox.Show("Qeyd daxil edin!");
                    return;
                }

                string tarix = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

                using (StreamWriter sw = new StreamWriter(fayl, true, Encoding.UTF8))
                {
                    sw.WriteLine(tarix + " - " + metn);
                }

                MessageBox.Show("Qeyd saxlanildi!");
                txtQeyd.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xeta: " + ex.Message);
            }
        }

        private void btnButun_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(fayl))
                {
                    rtbQeydler.Text = "Hele qeyd yoxdur.";
                    return;
                }

                using (StreamReader sr = new StreamReader(fayl, Encoding.UTF8))
                {
                    rtbQeydler.Text = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xeta: " + ex.Message);
            }
        }

        private void btnAxtar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(fayl))
                {
                    MessageBox.Show("Hele qeyd yoxdur.");
                    return;
                }

                string acar = txtAxtar.Text.Trim();

                if (string.IsNullOrWhiteSpace(acar))
                {
                    MessageBox.Show("Axtarilacaq sozu daxil edin!");
                    return;
                }

                StringBuilder netice = new StringBuilder();

                using (StreamReader sr = new StreamReader(fayl, Encoding.UTF8))
                {
                    string setir;

                    while ((setir = sr.ReadLine()) != null)
                    {
                        if (setir.IndexOf(acar, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            netice.AppendLine(setir);
                        }
                    }
                }

                if (netice.Length > 0)
                    rtbQeydler.Text = netice.ToString();
                else
                    rtbQeydler.Text = "Qeyd tapilmadi.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xeta: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cavab = MessageBox.Show(
                    "Butun qeydləri silmek isteyirsiniz?",
                    "Tesdiq",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (cavab == DialogResult.Yes)
                {
                    if (File.Exists(fayl))
                    {
                        File.WriteAllText(fayl, "");
                        rtbQeydler.Clear();
                        MessageBox.Show("Butun qeydlər silindi!");
                    }
                    else
                    {
                        MessageBox.Show("Silinecek qeyd yoxdur.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xeta: " + ex.Message);
            }
        }

        private void btnCixis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtQeyd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtAxtar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
