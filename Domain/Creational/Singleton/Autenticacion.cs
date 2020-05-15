using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.Singleton
{
    public class Autenticacion
    {
        public static Autenticacion estado;
        public string Username { get; set; }
        public string Password { get; set; }
        private Autenticacion()
        {

        }
        public static Autenticacion GetInstance()
        {
            if (estado == null)
            {
                estado = new Autenticacion();
            }
            return estado;
        }
    }
}
