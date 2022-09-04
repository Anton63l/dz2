//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


// System.Console.Write("Введите трехзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int d2 = a % 100 / 10; // Вторая цифра
// System.Console.WriteLine(d2);


//адача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


// System.Console.Write("Введите трехзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if(a <= 99){
//     System.Console.WriteLine("Третьей цифры нет"); //Проверка числа 
// }
// else{
//     int d3 = a / 100 % 10; // Третья цифра
//     System.Console.WriteLine(d3);
// }

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.Write("Введите цифру, обозначающую день недели (от 1 до 7): ");
int day = Convert.ToInt32(Console.ReadLine());
if(1< day & day > 7){
    System.Console.WriteLine("Введите корректный день недели: от 1 до 7");
}
else if(day == 6 ^ day == 7){
        System.Console.WriteLine("Да");
}
else{
        System.Console.WriteLine("Нет");
}