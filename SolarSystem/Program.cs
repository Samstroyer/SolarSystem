using Raylib_cs;

Console.WriteLine("Hello, World!");
Console.WriteLine("Or is it solar system?");

Engine e;

Setup();
Draw();

void Setup()
{
    Raylib.InitWindow(800, 800, "Solar System!");
    e = new();
}

void Draw()
{
    e.Run();
}