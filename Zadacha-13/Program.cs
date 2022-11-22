using System;
Console.Write("Введите число: ");
int inumber = int.Parse(Console.ReadLine());
string number = inumber.ToString();

if (inumber > 100000){
    Console.WriteLine("Это очень большое число");
}
else{
    if (number.Length < 3){
        Console.WriteLine("У этого чиcла нет третьей цифры");
    }
    else{
        Console.WriteLine(number[2]);
    }
}




