//Задача 15
Console.WriteLine("Задача 13");
Console.Write("Введите число - ");
int a = int.Parse(Console.ReadLine());

void den(int a){
    if((0<a)&&(a<8))
        if(a>=6)
                Console.WriteLine("Да, выходой");
            else   
                Console.WriteLine("Нет, не выходной");
    else
        Console.WriteLine("Число выходит за рамки количества дней недели");
}

den(a);