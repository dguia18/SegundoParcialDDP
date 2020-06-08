namespace Domain.Behavioral.State
{
    public class Vibracion : IPerfilDeAlerta
    {
        public void Alertar(Celular context)
        {
            if(context.Bateria > 50)
            {
            System.Console.WriteLine("Estoy vibrando");
                context.ModificarBateria();
            }else
                System.Console.WriteLine("No tengo bateria disponible");
        }
    }
}