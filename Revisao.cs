using System;
namespace Pestud
{  
    public class Revisao : Material
{
    
    public  Material Materia { get; set; }
    public void DiaRevisar(Material materia)
    {
        if (materia.DiaRev == DateTime.Now)
        {
            Console.WriteLine("Dia de revisão!!!");
            Console.WriteLine(materia.Materia);
        }
    }
    
}
}