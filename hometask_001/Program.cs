// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt (string message) {
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void FindNumberQuater (int number) {
    if (9999 < number && number < 100000) {
        int i = number%10;
        int I = number/1000;
        int y = number/10;
        if (i == I/10 && y%10 == I%10){
            Console.WriteLine("да");
        }
        else {
            Console.WriteLine("нет");
        }
    }
    else {
        Console.WriteLine("Число не является пятизначным");
    }

}

int num = Prompt("Введите пятизначное число ");
FindNumberQuater(num);