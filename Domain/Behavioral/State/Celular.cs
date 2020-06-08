namespace Domain.Behavioral.State
{
    public class Celular
    {
        private IPerfilDeAlerta currentState;
        public double Bateria { get; set; }
        public Celular()
        {
            currentState = new Vibracion();
            Bateria = 100;
        }

        public void SetEstado(IPerfilDeAlerta state)
        {
            currentState = state;
        }
        public void ModificarBateria()
        {
            this.Bateria -= 10;
        }
        public void Alertar()
        {
            currentState.Alertar(this);
        }
    }
}