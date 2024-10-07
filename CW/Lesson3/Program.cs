using Lesson3;

Triangle triangle = new Triangle() { A = 5, B = 3, AC = 4 };
Console.WriteLine($"S{triangle.getArea():F2} P={triangle.getPerimetr():F2}");
Circlie circlie = new Circlie(){Radius = 10};
Console.WriteLine($"S={circlie.getArea():F2} {circlie.getArea():F2}");