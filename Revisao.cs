using System;
namespace Pestud
{  
    public class Revisao 
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