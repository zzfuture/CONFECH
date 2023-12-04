# RETO 4 CONFECH

Reto que busca crear una interfaz de usuario que permita ingresar los votos por universidad, aceptar(A) , rechazar(R), nulo(N), blanco(B). Si se ingresa X se cierra la votacion. Y se muestra el total de votos por la universidad.

Finalmente se muestra el resultado de la votacion indicando la cantidad de universidades que aceptan, que rechazan y en las que hubo empate entre esas dos opciones.

```csharp
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
```
