using System;

namespace string_turu
{
    class Program 
    {
        static void Main(string[] args) 
        
        {
            #region String Formatlandırma
            string isim = "Eren", soyisim = "Ercan", tcNo = "12345678901";
            int yas = 30;
            bool medeniHal = true;
          //Console.WriteLine("Tc No: " + tcNo + " olan " + isim + " " + soyisim + " adlı şahsın bilgileri | Yaş: " + yas + " " + "| Medeni Hal: " + (medeniHal ? "Evli" : "Bekar"));
            #endregion

            #region String Değeri string.Format Metodu İle Formatlandırma

            //string sonuc = string.Format("Tc No: {0} olan {1} {2} adlı şahsın bilgileri | Yaş: {3} | Medeni Hal: {4}",tcNo,isim,soyisim,yas,medeniHal ? "Evli" : "Bekar");
            //Console.WriteLine(sonuc);
            #endregion

            #region $(String Interpolation) Operatörü İle Formatlandırma

            string sonuc = string.Format($"Tc No: {tcNo} olan {isim} {soyisim} adlı şahsın bilgileri | Yaş: {yas} | Medeni Hal: {(medeniHal ? "Evli" : "Bekar")}");
            Console.WriteLine(sonuc);
            #endregion

        }
    }
}
