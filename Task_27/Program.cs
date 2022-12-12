/*Напишите программу, которая принимает на вход число и
выдает сумму цифр в числе
*/

Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("Сумма всех цифр в числе равна: " + sum);



//while (num > 0)
//{
   // sum = sum + num %10;
  //  num /= 10;
//}
//Console.WriteLine($"Сумма элементов в числе {num}", sum);

//int[]Array = new int[]{num}; 

//
//int[]myArray = new int[8];
//Random rand = new Random();

//for(int i = 0; i < myArray.Length; i++)
//{
   // myArray[i] = rand.Next(0,10);
   // Console.WriteLine(myArray[i]);
//}