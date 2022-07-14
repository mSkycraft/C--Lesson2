//Задача 13

Console.WriteLine("Задача 13");
Console.Write("Введите число - ");
int a = int.Parse(Console.ReadLine());

void LastNum(int a){
    if(100>a)
        Console.WriteLine("Третьего числа нет");
    else
        Console.WriteLine("Третье число -"+ Convert.ToString(a)[2]);
}


LastNum(a);