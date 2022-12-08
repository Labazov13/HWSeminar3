// √ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2
System.Console.WriteLine("Вводим координаты первой точки...");
System.Console.Write("Введите координаты по X:");
float X = float.Parse(Console.ReadLine()!);
System.Console.Write("Введите координаты по Y:");
float Y = float.Parse(Console.ReadLine()!);
System.Console.Write("Введите координаты по Z:");
float Z = float.Parse(Console.ReadLine()!);
System.Console.WriteLine("Вводим координаты второй точки");
System.Console.Write("Введите координаты по X:");
float X1 = float.Parse(Console.ReadLine()!);
System.Console.Write("Введите координаты по Y:");
float Y1 = float.Parse(Console.ReadLine()!);
System.Console.Write("Введите координаты по Z:");
float Z1 = float.Parse(Console.ReadLine()!);

float diffX = X - X1;
float kvatratX = MathF.Pow(diffX, 2);

float diffY = Y - Y1;
float kvatratY = MathF.Pow(diffY, 2);

float diffZ = Z - Z1;
float kvatratZ = MathF.Pow(diffZ, 2);

float sum = kvatratX + kvatratY + kvatratZ;
Console.WriteLine("Расстояние между двумя точками в 3D пространстве: " + (MathF.Sqrt(sum)));

