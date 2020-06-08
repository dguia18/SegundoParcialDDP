
using Domain.Behavioral.State;
using NUnit.Framework;

namespace Domain.Test.Behavioral.Test.State
{
    public class StateTests
    {
        [Test]
        public void ProbarState()
        {
            Celular context = new Celular();
            context.Alertar();
            context.Alertar();
            context.SetEstado(new Exterior());
            context.Alertar();
            context.Alertar();
            
            context.Alertar();
            context.Alertar();
        }
    }
}
