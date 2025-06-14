using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandmethod
{
    internal class kimlik
    {

        string ad;
        string soyad;
        int yas;
        string memleket;
        char cinsiyet;


     public   string AD
        {
            get { return ad; }
            set { ad = value.ToUpper(); }

        }

     public   string SOYAD
        {
            get { return soyad; }
            set
            {
                soyad = value.ToUpper();
            }
        }

        public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value.ToUpper(); }
        }

        public int YAS
        {
            get { return yas; }
            set { yas = value; }

        }

        public char CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }

        }

        public kimlik() 
        {
            ad = "";
            soyad = "";
            cinsiyet = 'E';
            yas = 18;
            memleket = "ankara";
        }

    }
}