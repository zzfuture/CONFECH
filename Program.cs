internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Numero de Universidades: ");
        int Universidades = int.Parse(Console.ReadLine());
        int UAceptan = 0;
        int URechazan = 0;
        int UEmpatan = 0;
        for(int i = 0; i<Universidades; i++)
        {
            Console.Write("Universidad: ");
            string Universidad = Console.ReadLine();
            bool loop = true;
            int Aceptan = 0;
            int Rechazan = 0;
            int Nulos = 0;
            int Blanco = 0;
            while(loop)
            {
                Console.Write("Voto: ");
                string voto = Console.ReadLine();
                switch(voto){
                    case "A":
                        Aceptan++;
                        break;
                    case "R":
                        Rechazan++;
                        break;
                    case "N":
                        Nulos++;
                        break;
                    case "B":
                        Blanco++;
                        break;
                    case "X":
                        loop = false;
                        break;
                }
            }
            Console.WriteLine($"{Universidad}: {Aceptan} aceptan, {Rechazan} rechazan, {Blanco} blancos, {Nulos} nulos.");
            if (Aceptan > Rechazan){
                UAceptan++;
            }
            else if (Aceptan < Rechazan){
                URechazan++;
            }
            else {
                UEmpatan++;
            }
        }
        Console.WriteLine($"Universidades que aceptan: {UAceptan}");
        Console.WriteLine($"Universidades que rechazan: {URechazan}");
        Console.WriteLine($"Universidades que empatan: {UEmpatan}");
    }
}