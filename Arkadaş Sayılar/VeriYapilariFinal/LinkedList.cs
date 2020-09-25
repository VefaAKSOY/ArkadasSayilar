using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariFinal
{
    public class LinkedList : ListADT
    {
        public override void InsertFirst(int value)
        {
            Node tmpHead = new Node
            {
                Data = value
            };

            if (Head == null)
                Head = tmpHead;
            else
            {

                tmpHead.Next = Head;

                Head = tmpHead;
            }

            Size++;
        }

        public override void InsertLast(int value)
        {

            Node oldLast = Head;

            if (Head == null)

                InsertFirst(value);
            else
            {

                Node newLast = new Node
                {
                    Data = value
                };


                while (oldLast.Next != null)
                {

                    oldLast = oldLast.Next;

                }


                oldLast.Next = newLast;


                Size++;
            }
        }

        public override void InsertPos(int position, int value)
        {
            Node eklenecekeleman = new Node

            {
                Data = value
            };
            if (Head == null)
            {
                Head = eklenecekeleman;

            }



            else
            {

                Node temp = Head;
                if (position > Size)
                    System.Windows.Forms.MessageBox.Show("Dizi Size'indan buyuk deger girdiniz");
                else if (position == 1)
                    InsertFirst(value);
                else
                {

                    for (int i = 1; i < position - 1; i++)
                    {
                        temp = temp.Next;
                    }
                    eklenecekeleman.Next = temp.Next;
                    temp.Next = eklenecekeleman;
                }
                Size++;
            }
        }
        public override void DeleteFirst()
        {
            if (Head != null)
            {

                Node tempHeadNext = this.Head.Next;

                if (tempHeadNext == null)
                    Head = null;
                else

                    Head = tempHeadNext;

                Size--;
            }
        }
        public override void DeleteLast()
        {

            Node lastNode = Head;

            Node lastPrevNode = null;
            while (lastNode.Next != null)
            {

                lastPrevNode = lastNode;
                lastNode = lastNode.Next;

            }
            Size--;

            lastNode = null;


            if (lastPrevNode != null)
                lastPrevNode.Next = null;
            else
                Head = null;
        }
        public override void DeletePos(int position)
        {
            Node previous = new Node();

            if (position == 1)
                DeleteFirst();

            else if (Head == null)
            {
                Head = previous;

            }
            else
            {
                Node temp = Head;
                if (position > Size)
                    System.Windows.Forms.MessageBox.Show("Dizi Size'indan buyuk deger girdiniz");

                else
                {

                    for (int i = 0; i < position - 1; i++)
                    {
                        previous = temp;
                        temp = temp.Next;

                    }
                    previous.Next = temp.Next;
                }
                Size--;
            }
        }
        public override Node GetElement(int position)
        {
            Node retNode = null;//a1

            Node tempNode = Head;//a2
            int count = 0;//a3

            while (tempNode != null)//worst caesede position değeri n-1 olacağından n-1 kere döner.
            {
                if (count == position)//karmaşıklığı a4*n-1'dir. 
                {
                    retNode = tempNode;//karmaşıklığı 1'dir.
                    break;
                }

                tempNode = tempNode.Next;//karmaşıklığı a5*n-1'dir. 
                count++; //karmaşıklığı a6*n - 1'dir. 
            }
            return retNode;
        }//bu fonksiyonun bigosu O(n)'dir. 
        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "-->" + item.Data;
                item = item.Next;
            }
            return temp;
        }
        public LinkedList YerDegistir(LinkedList arkadassayilistesi, int degiseceksayi1, int degiseceksayi2, int boyut)
        {
            int degiseceksayiindexi1 = 0;//b1
            int degiseceksayiindexi2 = 0;//b2
            for (int i = 0; i < boyut; i++)//n defa döner.
            {
                if (degiseceksayi1 == arkadassayilistesi.GetElement(i).Data)//get element de O(n) olduğu için buraya kadar b1+b2+n*n'dir, bigo cinsinden O(n^2).
                {
                    degiseceksayiindexi1 = i;//1 defa girer.
                }
                if (degiseceksayi2==arkadassayilistesi.GetElement(i).Data)//get element de O(n) olduğu için buraya kadar b1+b2+n*n+n*n'dir, bigo cinsinden O(n^2). 
                {
                    degiseceksayiindexi2= i;//1 defa girer.
                }
            }
            Node node1 = arkadassayilistesi.GetElement(degiseceksayiindexi1);//O(n)
            Node node2 = arkadassayilistesi.GetElement(degiseceksayiindexi2);//O(n)
            Node tmpnode = new Node();//b3
            tmpnode.Data = node2.Data;//b4
            node2.Data = node1.Data;//b5
            node1.Data = tmpnode.Data;//b6           
            return arkadassayilistesi;
        }
        //Fonksiyonun karmaşıklığı, b1+b2+n*n+n*n+2+n+n+b3+b4+b5+b6, bigo cinsinden O(n^2).
    }
}
