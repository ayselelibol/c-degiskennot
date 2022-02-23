using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte b = 5;//1byte yer kaplar
            sbyte c = 5;//1byte yer kaplar
            short s = 5;//2byte yer kaplar
            ushort us = 5; //2byte yer kaplar
            Int16 i16 = 2; //2 byte
            int i = 2; //2 byte
            Int32 i32 = 2; //4byte yer kaplar
            Int64 i64 = 2; //8byte yer kaplar
            uint ui = 2; //4byte yer kaplar
            long l = 4; //8byte yer kaplar
            ulong ul = 4; //8byte

            //reel sayılar 
            float f=5; //4byte
            double d =5; //8byte
            decimal de =5;//16byte

            char ch ='2'; //2byte
            string str ="A"; //sınırsız

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 ="x";
            object o2 ="y";
            object o3 = 4;
            object o4 =4.6;

            //string ifadeler
            string str1="";
            string str2= string.Empty;
            str2="aysel elibol";
            string ad ="zikriye";
            string soyad ="ürkmez";
            string tamisim = ad + " " + soyad;

            //ınteger tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 4;
            int integer3 = integer1 * integer2;

            //boolean
            bool bool1 = 10<2; //false

            //degisken donüşümleri
            string str20 = "20";
            int int20 = 20;

            string yenideger = str20 + int20.ToString();
            Console.WriteLine(yenideger); //çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); //çıktısı 40

            int int22 = int20 + int.Parse(str20); //çıktısı 40

            //datetime

            string datetime =DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 =DateTime.Now.ToString("dd,MM,yyyy");
            Console.WriteLine(datetime2);

            string hour =DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);



        }
    }
}
