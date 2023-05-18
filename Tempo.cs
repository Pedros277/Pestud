using System;
namespace Pestud
{
    public class Contador 
    {
        public Contador()
        {
            Inicial = new TimeSpan((int)DateTime.Now.Hour,(int)DateTime.Now.Minute,(int)DateTime.Now.Second);
            Final = new TimeSpan(00,00,00);
        }
        public TimeSpan Final { get; set; }
        public TimeSpan Inicial { get; private set; }
          public void PreInicio()
        {
            var atual = new TimeSpan((int)DateTime.Now.Hour,(int)DateTime.Now.Minute,(int)DateTime.Now.Second);
            var fim = new TimeSpan(00,00,00);
            Inicio(atual,fim);
        }
        public void Inicio(TimeSpan inicio, TimeSpan fim)
        {
            Console.Clear();
            Console.WriteLine($"Inicio : {inicio}");
            Console.WriteLine("Digite ('p') para uma pausa.");
            Console.WriteLine("Digite ('q') para finalizar.");
            Console.WriteLine("Digite ('t') para ver o tempo corrido");
            string escolha = Console.ReadLine().ToLower();
            
            
            switch (escolha)
            {
                case "p": Pausa(inicio,fim);break;
                case "q": Fim(inicio, fim);break;
                case "t": Tempo(inicio,fim);break;
                default : Inicio(inicio,fim);break;
            }
           
            
        }
        public void Tempo(TimeSpan inicio, TimeSpan fim)
        {
            Console.Clear();
            var atual = new TimeSpan((int)DateTime.Now.Hour,(int)DateTime.Now.Minute,(int)DateTime.Now.Second);
            atual += fim;
            var corrido = atual - inicio;
            Console.WriteLine(corrido);
            Thread.Sleep(2000);
            Inicio(inicio, fim);


        }
      
     public void Pausa(TimeSpan inicio, TimeSpan fim)
        {
            Console.Clear();
            
             var atual = new TimeSpan((int)DateTime.Now.Hour,(int)DateTime.Now.Minute,(int)DateTime.Now.Second);
             Console.WriteLine($"Tempo pausado...");
            Console.ReadKey();
            var ho1 = new TimeSpan((int)DateTime.Now.Hour,(int)DateTime.Now.Minute,(int)DateTime.Now.Second);
            var pausa = ho1 - atual;
            fim -= pausa;
            Inicio(inicio, fim);
        }
    
        public void Fim(TimeSpan inicio, TimeSpan fim)
        {
            Console.Clear();
            var atual = new TimeSpan((int)DateTime.Now.Hour,(int)DateTime.Now.Minute,(int)DateTime.Now.Second);
            var final = atual + fim;
            var termino = final - inicio;
            Console.WriteLine("Tempo marcado:");
            Console.WriteLine(termino);
            Console.ReadLine();
            Materia(termino);
        }
        public void Materia(TimeSpan termino)
        {Console.WriteLine("Digite o material:");
            
            string material = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Arquivo salvo.");
            var data = DateTime.Now.ToString("d");
            string id =$"{data} - {termino} => {material} \n";

            Salvar(id);
            MenuDois(material);
            
        }
        public string Salvar(string id)
        {   Console.Clear();
            string arquivo = "";
            string path = @"D:\Proj\Pestud\teste.txt";
            
            Console.WriteLine(id);
            using(var file = new StreamReader(path))
            {
                arquivo = file.ReadToEnd();
                
            }
            var rg = arquivo += id;
            using(var file = new StreamWriter(path))
            {
                file.Write(rg);
            }
            
            
            Console.ReadKey();
            return id;
            
        }
        public void MenuDois(string material)
        {
            Console.Clear();
            Console.WriteLine("Digite '1' para agendar revisão:");
            Console.WriteLine("Digite '0' para voltar ao Menu.");
            var escolha = Console.ReadLine();
            switch(escolha)
            {
                case "1": Agenda(material);break;
                
                default: MenuDois(material);break; 
            }



        }
        public void Agenda(string material)
        {
           Console.Clear();
           Console.WriteLine("Digite o numero de dias para a proxima revisão:");
           int time = int.Parse(Console.ReadLine());
           var atual = DateTime.Now;
           var data = atual.AddDays(time);
           var fim = new TimeSpan();
           string id =$"{data} => {material} (Revisão) \n";
           Salvar(id);
           
        }

    }
}