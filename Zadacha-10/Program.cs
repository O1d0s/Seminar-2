using System;
Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();

if (number.Length > 3){
    Console.WriteLine("У этого чиcла больше 3 цифр");
}
else{
    if (number.Length < 3){
        Console.WriteLine("У этого чиcла меньше 3 цифр");
    }
    else{
        Console.WriteLine(number[1]);
    }
}


