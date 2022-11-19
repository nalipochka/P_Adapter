using P_Adapter;


int a = 10, b = 12;
RoundHole hole = new RoundHole(a);
Console.WriteLine($"Hole, radius = {a}");
SquarePeg peg = new SquarePeg(b);
Console.WriteLine($"Square, width = {b}");
bool fits = hole.Fits(new SquarePegAdapter(peg));
if(fits)
    Console.WriteLine("A square can be inscribed in a circle!");
else
    Console.WriteLine("A square cannot be inscribed in a circle!");

