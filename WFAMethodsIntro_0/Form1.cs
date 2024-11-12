using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAMethodsIntro_0
{
    public partial class Form1 : Form
    {


        /*
                        Metotlar
         
         Yazdıgımız bir kod blogunu veya ifadesini birden fazla yerde kullanmak istedigimiz zaman normal şartlar altında o kod blogunu veya ifadesini tekrar yazmamız gerekecektir. Dolayısıyla bu size bir kod kalabalıgının yanında geliştirmesi, yönetilmesi ve hata aldıgınız takdirde müdahale edilmesi zor bir yapı sunacaktır...Karmasık projelerde bu yapıları yönetme ve hata alma durumunda bu yapılara müdahale etme durumları öyle bir hal alır ki projeyi yazmak daha mantıklı bile olabilir...Bu da hem daha fazla sıkıntıya , hataya ve hem de zaman kaybına yol acacaktır...Bu durumlarda yazılımcı daha büyük bir yük altına girer...Birden fazla yerde kullandıgımız kodlarda degişiklik yapmak istedigimiz zaman da tek tek her bir kod ifadesini degiştirmek zorunda kalırsınız...İşte metotlar bu tarz durumlarda hayatımızı kurtarır...Kod tekrarını engeller. Geliştirilebilirligi , yonetilebilirligi saglar ve kodlara topladıgı tek catı altında istedigimiz kadar özgür davranmamızı saglar...


        Avantajlar : 
        Kod karmasıklıgının engellenmesi
        Geliştirilebilirlik
        Tek yerden yönetim


        //Deger Döndürme terimi ilgili yapının yazıldıgı yere sonuc vermesidir (sanki biz oraya bir deger yazıyormusuz gibi)

        Metotlar ikiye ayrılır:

        1 => Geriye Deger Döndürmeyen Metotlar

          a)Parametre Almayan
          b) Parametre Alan

        2 => Geriye Deger Döndüren Metotlar
         
        a) Parametre Almayan
        b) Parametre Alan
         
         

       Metot Syntax'i

        --Geriye Deger Döndürmeyen Metotlar
             ----Parametre Almayan Metotlar

             Metotlar global alanda olusturulmalıdır...

        Geriye deger döndürmeyen metotlar void keyword'u ile işaretlenmek zorundadır...void,olusturdugumuz metodun geriye deger döndürmeyecegini bildirir...Metot isimleri standart olarak büyük harf ile baslar sonra PascalCase devam eder ve metot isimleri standart olarak emir kipinde verilir...Her metodun(iki istisnası dısında) parantezleri olmak zorundadır...

        Metot yaratmak ile metot cagırmak arasında cok büyük bir fark vardır...Siz metot yaratmayı metot cagırmakla kesinlikle karıstırmamalısınız...Metot yaratmak, sizin bir metot yapısı olusturmanız demektir...Metot cagırmak ise daha önce olusturulmus olan bir metodu ismiyle cagırmaktır...

        Sizin kullandıgınız event'lerin hepsi aslında bir metottur...Ama her metot bir event olmak zorunda degildir...
         

        Parametre : Metot olusturulurken metot parantezlerinin icerisine yazdıgımız yapılara parametre denir...

        Argüman  : Metot cagrılırken metot parantezleri icerisine yazdıgımız degerlerdir...


        Metot Yaratma Syntax'i

        Parametre Almayan Metot


        public void Selamla()
        {
             MessageBox.Show("Hello World");
        }


        Metot Cagırma Syntax'i

        Selamla();


        **Parametre Alan
        *
        *Parametre: Metot cagrılırken ona dısarıdan(cagrıldıgı yerden) bir veri girişi yapmak durumunda kullanmamız gereken yapılardır. Bir metoda parametre verebilmek icin metot olusturulurken Parantezlerine degişken tanımlaması gibi ifade yazmamız gerekir
        *
        *
        *Argüman : Metot cagrılırken onun parantezlerine yazdıgımız degerlere denir...Bir argümanın ilgili parametre ile aynı tipten olması veya argüman verilirken ilgili parametrenin tipine dönüstürülmesi gerekir... Parametre almayan metoda argüman verilemez...Parametreli metot da argümansız cagrılamaz...
        *
        *Aslında biz Parametre sayesinde metodun cagrıldıgı yerden metodun yasam alanına bir veri gönderebiliriz bir nevi metodun cagrıldıgı yerden onun yasam alanına acılan bir tünel olarak düsünebilirsiniz...
        *
        *
        *
        *


         
         */

        public void Selamla()
        {
            MessageBox.Show("Hello World");
        }

        public void SayilariEkle()
        {
            LstSonuc.Items.Clear();
            for (int i = 1; i < 11; i++)
            {
                LstSonuc.Items.Add(i);
            }
        }


        



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //Selamla();
        }

        //İki tane textbox bir tane button atın..Kullanıcının textboxlara yazdıgı sayıların toplamını MessageBox ile gösteren bir metot yazın...Butona basıldıgı zaman bu metodu cagırın...

        private void button1_Click(object sender, EventArgs e)
        {
            Selamla(); //Metot cagırma syntax'i

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Selamla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selamla();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SayilariEkle();
        }


        public void SayilariTopla()
        {

            try
            {

                int sayi1 = Convert.ToInt32(TxtSayi1.Text);
                int sayi2 = Convert.ToInt32(TxtSayi2.Text);
                int sonuc = sayi1 + sayi2;
                MessageBox.Show(sonuc.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }




        private void BtnTopla_Click(object sender, EventArgs e)
        {
            SayilariTopla();

            
        }


        public void OzelSelamla()
        {
            MessageBox.Show($"Hosgeldin {TxtIsim.Text}");
        }


        //Parametreli Metot
        public void IsmeGoreSelamla(string veri)
        {
            MessageBox.Show($"Hosgeldin {veri}");
        }

        private void BtnSelamla_Click(object sender, EventArgs e)
        {
            //OzelSelamla();

            IsmeGoreSelamla("Cagrı");
        }
    }
}
