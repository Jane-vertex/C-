/* Задача 21

Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/


int getCoordFromUser(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено некорректное число");
        }
    }
    return result;
}

double getDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
    return result;
}

int ax = getCoordFromUser("Введите коорд X 1-й точки");
int ay = getCoordFromUser("Введите коорд Y 1-й точки");
int az = getCoordFromUser("Введите коорд Z 1-й точки");


int bx = getCoordFromUser("Введите коорд X 2-й точки");
int by = getCoordFromUser("Введите коорд Y 2-й точки");
int bz = getCoordFromUser("Введите коорд Z 2-й точки");

double distance = getDistance(ax, ay, az, bx, by, bz);

Console.WriteLine($"Расстояние между ({ax},{ay},{az}) and ({bx},{by},{bz}) is {distance}");


