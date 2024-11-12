using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAMethodsIntro_0
{
    public partial class Form2 : Form
    {
        //Bana öyle bir metot yazın ki bu metot, isim olarak aldıgı rengi Form'un ve buttonların arka plan rengi olarak versin...Bu metot textbox'a bir renk ismi (İngilizce'si) yazdıgım zaman calıssın ve hata vermesin...
        public Form2()
        {
            InitializeComponent();
        }


        public void RenkVer(string renkIsmi)
        {
            try
            {
                BackColor = Color.FromName(renkIsmi);
                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is Button) Controls[i].BackColor = Color.FromName(renkIsmi);
                }
            }
            catch 
            {

               
            }
            
        }

        private void TxtRenk_TextChanged(object sender, EventArgs e)
        {
            RenkVer(TxtRenk.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
