using System;
using System.Threading;

namespace TransferenciaBancariaSimulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banco JNTA...");

            Thread transferencia1 = new Thread(() => RealizarTransferencia("Transferencia a cuenta A", 3000));
            Thread mensaje = new Thread(() => RealizarTransferencia("Validando credenciales", 5000)); 
            Thread mensaje2 = new Thread(() => RealizarTransferencia("Estableciendo una conección segura", 7000)); 

            transferencia1.Start();
            mensaje.Start();
            mensaje2.Start();

            transferencia1.Join();
            mensaje.Join();
            mensaje2.Join();

            Console.WriteLine("¡su transacción se ha completado exitosamente!");
        }

        static void RealizarTransferencia(string nombreTransferencia, int tiempo)
        {
            Console.WriteLine($"{nombreTransferencia} está siendo procesado...");
            Thread.Sleep(tiempo); 
            Console.WriteLine($"-------------------------");
            Console.WriteLine($"{nombreTransferencia} completado.");
            Console.WriteLine($"-------------------------");
        }
    }
}
