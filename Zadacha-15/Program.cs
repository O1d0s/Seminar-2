Console.Write("Введите число от 1 до 7: ");
int a = int.Parse(Console.ReadLine());

if (a >= 1 && a <= 7){
    if( a >= 1 && a <= 5 ){
        Console.WriteLine("Нет");
    }
    else{
        Console.WriteLine("Да");
    }
}
else{
    Console.WriteLine("Ошибка");
}