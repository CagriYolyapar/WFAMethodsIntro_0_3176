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
    public partial class Form3 : Form
    {

        //Öyle bir metot yazın ki ilk textbox'a yazılan sayı sırasına göre (1,2,3) o ilgili sıradaki listbox'a diger textboxlardan aldıgı sayı menziline göre sayıları eklesin (butona basıldıgı zaman)


        public void SayiEkle(ListBox lst,int baslangic,int bitis)
        {
            lst.Items.Clear();
            for (int i = baslangic; i <= bitis; i++)
            {
                lst.Items.Add(i);
            }
        }

        public void ListBoxaEkle(string listBoxSirasi,int baslangic,int bitis)
        {
            switch (listBoxSirasi)
            {
                case "1":
                    SayiEkle(LstSonuc1, baslangic, bitis);
                  
                    break;
                case "2":
                    SayiEkle(LstSonuc2, baslangic, bitis);


                    break;
                case "3":
                    SayiEkle(LstSonuc3, baslangic, bitis);

                    break;
            }
        }


        public Form3()
        {
            InitializeComponent();
        }

        private void BtnBelirle_Click(object sender, EventArgs e)
        {
            ListBoxaEkle(TxtListBox.Text,Convert.ToInt32( TxtBaslangic.Text),Convert.ToInt32( TxtBitis.Text));
        }
    }
}
