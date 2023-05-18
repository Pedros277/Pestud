using System;
namespace Pestud
{
 public class Data : Contador
 {
    public DateTime Dia { get; set; }
    public DateTime DiaRev { get; set; }
    public void Revisar(Material materia, int dias)
    {
        Console.WriteLine("Digite o total de dias até a proxima revisão:");
        dias = int.Parse(Console.ReadLine());
        materia.DiaRev = materia.Dia.AddDays(dias);
        
    }
    
 }
}