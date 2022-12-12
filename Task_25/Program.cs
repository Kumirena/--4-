/* Напишите цикл, который принимает на вход два числа (А и В)
 и возводит число А в натуральную степень В.
 */

 Console.WriteLine("Введите число: ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число: ");
 int b = Convert.ToInt32(Console.ReadLine());

 int b1 = b;
 int a1 = a;

 
 while (b > 1)
 {
    b = b-1;
    a = a * a1;
    
 }

 Console.WriteLine($"{a1} в степени "  + b1 + " = " + a);

