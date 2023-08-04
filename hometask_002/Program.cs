// Написать программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt (string message) {
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int XA = Prompt ("введите координаты точки xA ");
int YA = Prompt ("введите координаты точки yA ");
int ZA = Prompt ("введите координаты точки zA ");
int XB = Prompt ("введите координаты точки xB ");
int YB = Prompt ("введите координаты точки yB ");
int ZB = Prompt ("введите координаты точки zB ");

double AB = Math.Sqrt((XB-XA)*(XB-XA)+(YB-YA)*(YB-YA)+(ZB-ZA)*(ZB-ZA));
Console.WriteLine(AB);
