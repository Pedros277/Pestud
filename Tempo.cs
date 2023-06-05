using System;
using System.IO;
namespace Pestud
{
    public class Tempo : Material
    {
        public Tempo()
        {
            Inicial = new TimeSpan((int)DateTime.Now.Hour,(int)DateTime.Now.Minute,(int)DateTime.Now.Second);
            TempoDePausa = new TimeSpan(00,00,00);
        }
        public TimeSpan TempoDePausa { get; set; }
        public TimeSpan Final { get; set; }
        public TimeSpan Inicial { get; private set; }
        public void PreInicio()
        {
            
            Console.Clear();
            Console.WriteLine("Tudo Pronto?");
            Console.WriteLine("Digite '1' para Iniciar.");
            Console.WriteLine("Digite '0' para sair.");
            var escolha = Console.ReadLine();
            switch(escolha)
            {
                case "1": PosInicio();break;
                case "0" : System.Environment.Exit(0);break;
                
                default: PreInicio();break; 
            }
        }
          public void PosInicio()
        {   
            var material = new Material();
            
            Inicio(material);
        }
        public void Inicio( Material material)
        {
            var noti = new Noti();
            noti.StartNotificationTimer();
            
            
            material.Dia = DateTime.Now;
            Console.Clear();
            Console.WriteLine($"Inicio : {Inicial}");
            Console.WriteLine("Digite ('p') para uma pausa.");
            Console.WriteLine("Digite ('q') para finalizar.");
            Console.WriteLine("Digite ('t') para ver o tempo corrido");
            Console.WriteLine("Digite ('a') para adicionar anotações");
            string escolha = Console.ReadLine().ToLower();
            
            
            
            switch (escolha)
            {
                case "p": Pausa(material);break;
                case "q": Fim(material);break;
                case "t": Temp(material);break;
                case "a": Anot(material);break;
                default : Inicio(material);break;
            }
           
            
        }
        public TimeSpan Temp(Material material)
        {

            Console.Clear();
            var atual = new TimeSpan((int)DateTime.Now.Hour,(int)DateTime.Now.Minute,(int)DateTime.Now.Second);
            atual += TempoDePausa;
            var corrido = atual - Inicial;
            Console.WriteLine(corrido);
            Thread.Sleep(2000);
            return corrido;

            Inicio(material);


        }
      
     public void Pausa(Material material)
        {
            Console.Clear();
            
             var atual = new TimeSpan((int)DateTime.Now.Hour,(int)DateTime.Now.Minute,(int)DateTime.Now.Second);
             Console.WriteLine($"Tempo pausado...");
            Console.ReadKey();
            var ho1 = new TimeSpan((int)DateTime.Now.Hour,(int)DateTime.Now.Minute,(int)DateTime.Now.Second);
            var pausa = ho1 - atual;
            TempoDePausa -= pausa;
            Inicio(material);
        }
    
        public void Fim(Material material)
        {
            Console.Clear();
            var atual = new TimeSpan((int)DateTime.Now.Hour,(int)DateTime.Now.Minute,(int)DateTime.Now.Second);
            var final = atual + TempoDePausa;
             Final = final - Inicial;
            Console.WriteLine("Tempo marcado:");
            Console.WriteLine(Final);
            Console.ReadLine();
            Materia(material);
        }
        public void Anot (Material material)
        {
            var test = "";
            Console.Clear();
            do{ 
            test = Console.ReadLine();
            test += Environment.NewLine;
            material.Anotacoes += test;
            
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);
            
            Inicio(material);
        }
        public void Materia(Material material)
        
        {
            
            Console.WriteLine("Digite o material:");         
            material.Materia = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Arquivo salvo.");
            var data = DateTime.Now.ToString("d");
            string id =$"{material.Dia.ToString("d")} - {Final} => {material.Materia} \n";
            string path = @"D:\Proj\Pestud\registro.txt";
            string pathAnot = $@"D:\Proj\Pestud\Anot\{material.Materia}.md";
             string idAnot = $@"{material.Materia}
{material.Anotacoes}";
            using (var myFile = File.Create(pathAnot))
            {
               
            }
            Salvar(id,path);
            Salvar(idAnot,pathAnot);
            MenuDois(material);
            
        }
        public string Salvar(string id, string path)
        {   Console.Clear();
            string arquivo = "";
            Console.WriteLine(id);
            using(var file = new StreamReader(path))
            {
                
                arquivo = file.ReadToEnd();
                
            }
            var rg = id += arquivo;
            using(var file = new StreamWriter(path))
            {
                file.Write(rg);
            }
            
            
            Console.ReadKey();
            return id;
            
        }
        public void MenuDois(Material material)
        {

            Console.Clear();
            Console.WriteLine("Digite '1' para agendar revisão:");
            Console.WriteLine("Digite '0' para voltar ao Menu.");
            var escolha = Console.ReadLine();
            switch(escolha)
            {
                case "1": Agenda(material);break;
                case "0": PreInicio();break;
                
                default: MenuDois(material);break; 
            }



        }
        public void Agenda(Material material)
        {
           Console.Clear();
           Console.WriteLine("Digite o numero de dias para a proxima revisão:");
           int time = int.Parse(Console.ReadLine());
           var x = material.DiaRev.AddDays(time);
           material.DiaRev = x;
           var fim = new TimeSpan();
           string id =$"(Revisão) {material.DiaRev.ToString("d")} => {material.Materia} \n";
           string path = @"D:\Proj\Pestud\revisao.md";
           Salvar(id, path);
           
           
        }
        

    }
}