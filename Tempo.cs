using System;
namespace Pestud
{
    public class Tempo : AgEst
    {
        public Tempo()
        {

        }
        public TimeSpan Fim { get; set; }
        public TimeSpan Inicio { get; private set; }
    }
}