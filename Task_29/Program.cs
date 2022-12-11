/*Напишите программу, которая задает массив из 8 элементов
и выводит их на экран.
*/

    
int[]myArray = new int[8];
Random rand = new Random();

for(int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rand.Next(0,10);
    Console.WriteLine(myArray[i]);
}
