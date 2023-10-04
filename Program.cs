
class Program
{
    static void Tabl()
    {
        var tabl = new int[10, 10]; 
        for (int i = 0; i < 10; ++ i)
        {
            for (int n = 1; n < 10; ++ n)
            {
                tabl[i, n] = i * n;
                Console.Write(tabl[i, n] + "/t");
            }
            Console.WriteLine();
        }
    }
}