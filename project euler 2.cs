// gerekli degiskenler: toplam, önceki sayi, simdiki sayi, sonraki sayi

using System.Diagnostics;

int x = 1; //onceki sayi
int y = 2; //simdiki sayi 
int z = 0; //sonraki sayi 
int k = 0; //toplam
//kural 1 = simdiki sayi 4000000 dan kücük oldugu surece cift sayilar toplanacak.
while (y <= 4000000)
{
    if (y % 2 == 0)
    {
        k += y;
        
    }
// 1 2 3 5 8 13
    z = x + y; //3 5 8
    x = y;     //2 3 5
    y = z;     //3 5 8 b = a + b 
    
    

}

Console.WriteLine("toplam:" + k);






