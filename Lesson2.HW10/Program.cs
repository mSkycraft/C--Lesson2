//Задача 10
Console.WriteLine("Задача 10");
Console.Write("Введите число - ");
int a = int.Parse(Console.ReadLine());

void posled(int a){   
    if((100<=a)&&(a<=999))
        Console.WriteLine("Среднее число - "+ ((int)a/10)%10);
    else
        Console.WriteLine("Число не трехзначное");
}

posled(a);