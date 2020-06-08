
using System;

namespace Domain.Behavioral.State
{
    public class Exterior : IPerfilDeAlerta
    {
        public void Alertar(Celular context)
        {            
            if(context.Bateria > 75)
            {
                Console.WriteLine("Tengo el volumen al máximo");
                context.ModificarBateria();
            }
            else
            {
                Console.WriteLine("No tengo bateria disponible");
                context.SetEstado(new Silencio());
            }

        }
    }
}
