using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariFinal
{
    public class ArkadasSayiIslemleri
    {
        public LinkedList ArkadasSayiYerDegistir(LinkedList arkadassayilistesi,int boyut)
        { //BigO NOTASYONU en son hesaplayacağım, ilk önce satır satır karmaşıklığı yazacağım. Ara ara bigo notasyonunu hesaplayıp sonda da son bir hesaplama yapacağım. 
            int sayac = 0;//c1 sabit
            for (int i = 0; i < boyut; i++)//Worst casede bir tane arkadaş sayıyı bulması yeteceğinden karmaşıklığı n-1'dir
            {
                int arkadassayi = arkadassayilistesi.GetElement(i).Data; //bu fonksiyonun içini hesapladığımızda bigo cinsinden karmaşıklığı, O(n)'dir. 
                //Buraya n-1 defa geleceğinden n*(n-1)'dir.
                int digerarkadassayi = 0;//c2
                for (int j = 1; j < arkadassayi; j++)//bu satır listenin içindeki sayı kadar yani K kadar döner diyelim.
                {
                    if (arkadassayi%j==0)//Burada kodun karmaşıklığı K*c3 + c2 + c1 + n*(n-1)=O(n^2) 
                    {
                        digerarkadassayi = digerarkadassayi+ j;
                    }
                  
                }//O(n^2)
                for (int k = 0; k < boyut; k++)//worst casede n defa döner. Karmaşıklığı buraya kadar n^2 +n*(n-1)'dir. BigO cinsinden değeri O(n^2) 
                {
                    int tmpsayi = arkadassayilistesi.GetElement(k).Data;//fonksiyonun içine girdiğimizde, karmaşıklığı n'dir. Karmaşıklığı n*n^2 bigo cinsinden O(n^3)

                    if (digerarkadassayi == tmpsayi)//sadece bu satır c4*n'dir.Buraya kadar yukarıda hesapladığım için sadece O(n^2)'yi alacağım. Buraya kadar c4*n^2+n^3'tür.
                    {
                        arkadassayilistesi = arkadassayilistesi.YerDegistir(arkadassayilistesi, arkadassayi, digerarkadassayi, boyut);//bu fonksiyonun içine girdiğimizde;O(n^2)
                        //buraya sadece bir defa geldiğinden burada karmaşıklık n ile çarpılmaz O(n^2) olarak kalır.
                        sayac++;//1
                        break;
                    }
                    
                }
                if (sayac!=0)//n-1 defa gelir.
                {
                    break;
                }
              
            }
            
            return arkadassayilistesi;
        }//SON OLARAK HESAPLADIĞIMIZDA, n ^ 2 + n * ( n - 1 ) + n ^ 3 + n ^ 2 + 1 + n-1 O(n^3)'tür.
    }
}
                                               
