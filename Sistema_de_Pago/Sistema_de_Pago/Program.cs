namespace Sistema_de_Pago
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona el tipo de pago");
            Console.WriteLine("1. Pago con tarjeta");
            Console.WriteLine("2. Pago con efectivo");
            Console.WriteLine("3. Pago por transferencia");

            int respuesta = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el monto");
            double monto  = double.Parse(Console.ReadLine());
            if (monto <= 0) throw new Exception($"No se puede mandar un monto de {monto}");

            switch(respuesta)
            {
                case 1: 
                    PagoConTarjeta tarjeta = new PagoConTarjeta();
                    tarjeta.ProcesarPago(monto);
                break;

                case 2:
                    PagoConEfectivo efectivo = new PagoConEfectivo();
                    efectivo.ProcesarPago(monto);
                break;

                case 3:
                    PagoConTransferencia transferencia = new PagoConTransferencia();
                    transferencia.ProcesarPago(monto);
                break;

                default: throw new Exception("Opcion invalida");
                
            }
        }
    }

    interface IPago
    {
        void ProcesarPago(double monto);
    }

    class PagoConTarjeta : IPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago con tarjeta por {monto}");
        }
    }

    class PagoConEfectivo : IPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago con efectivo por {monto}");
        }
    }

    class PagoConTransferencia : IPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago por transferencia bancaria por {monto}");
        }
    }

}
