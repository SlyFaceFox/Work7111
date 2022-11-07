using System;
public class MainClass
{
    public static void Main()
    {
        double Sum1 = 0, Sum2 = 0;
        Console.WriteLine("Введите кол-во марок автомобилей:");
        int num1 = int.Parse(Console.ReadLine());
        int[] Car = new int[num1];
        Console.WriteLine("Введите кол-во марок мотоциклов:");
        int num2 = int.Parse(Console.ReadLine());
        int[] Bike = new int[num2];
        Random rand = new Random();
        for (int i = 0; i < num1; i++)
        {
            Car[i] = rand.Next(5000, 10000);
            Sum1 += Car[i];
        }
        for (int i = 0; i < num2; i++)
        {
            Bike[i] = rand.Next(500, 5000);
            Sum2 += Bike[i];
        }
        if (((Sum1 / num1) / (Sum2 / num2)) >= 3)
        {
            Console.WriteLine("Средняя стоимость автомобилей больше средней стоимости мотоциклов в 3+ раза");
        }
        else
        {
            Console.WriteLine("Средняя стоимость автомобилей не больше средней стоимости мотоциклов в 3 раза");
        }
    }        
}
