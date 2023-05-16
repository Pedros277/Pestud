using System;
namespace Pestud
{  
    public class Revsao : Tempo
{
    public  Material Revisar { get; set; }
    public void Revisa(Material Revisado)
    {
        if (Revisado.Dia == DateTime.Now)
        {
            Console.WriteLine("Dia de revisar conteúdo!!");
            Console.WriteLine(Revisado.Materia);
        }
    }
}
}