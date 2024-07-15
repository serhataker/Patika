using System;


namespace trynew
	{	        
		class Program
	
{
		static void Main(string[] args)
		{


         Console.WriteLine("Adınızı griiniz:");//kullanıcı Ad bilgilerini alıt
			string Name=Console.ReadLine();//Adı değişkene okuturur.
            Console.WriteLine("Burda olma nedenininiz beliritn lütfen:");//Kullanıcı neden bilgisni alır
			string Neden= Console.ReadLine();// Girilen nedeni değişkene aktarır.
			Console.WriteLine("Merhaba " +Name+ " Hoşgeldiniz "+"\nKişinin Nedeni:"+ Neden);// Giriln değerlerle kullancıya dönüş sağlar.
        }
}
	}
	
