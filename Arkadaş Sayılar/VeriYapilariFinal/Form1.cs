using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariFinal
{
    public partial class frmArkadasSayilar : Form
    {
        public frmArkadasSayilar()
        {
            InitializeComponent();
        }
        LinkedList SayiListesi = new LinkedList();
        int i = 0;
        ArkadasSayiIslemleri ArkadasSayiIslemleri = new ArkadasSayiIslemleri();
        private void btnSayilariGoster_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Sayı Eklenmemiştir.");
            }
            else
            {
                MessageBox.Show(SayiListesi.DisplayElements());
            }
        }

        private void btnSayilarinYeriniDegistir_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Sayı Eklenmemiştir.");
            }
            else//sayı eklenmiş ise 
            {
                ArkadasSayiIslemleri.ArkadasSayiYerDegistir(SayiListesi, i);//bu fonsiyonun karmaşıklığını bigo notasyanu şeklinde hesaplayacağım.
                //O(n^3)'Tür.
                MessageBox.Show("Sayıları Listele Butonuna Basarak Arkadaş Sayıların Yerlerinin Değiştiğini Görebilirsiniz.");
            }
        }
        private void btnSayiGir_Click(object sender, EventArgs e)
        {      
            int ekleneceksayi = Convert.ToInt32(txtSayiGir.Text);
            SayiListesi.InsertLast(ekleneceksayi);
            i++;
            MessageBox.Show(txtSayiGir.Text + " Sayısı Listeye Eklenmiştir.");
            txtSayiGir.Text = " ";                       
        }

        private void btnListeyiTemizle_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Silinecek Liste Bulunmamaktadır.");
            }
            else
            {
                for (int j = 0; j < i; j++)
                {
                    SayiListesi.DeleteLast();
                }
                MessageBox.Show("Liste Silinmiştir.");
                i = 0;
            }
        }
    }
}
