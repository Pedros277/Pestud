using System;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Pestud{ 
public class Noti
{
    private Timer timer;

    public void StartNotificationTimer()
    {
        // Cria um Timer com um intervalo de 25 min.
        timer = new Timer(1800000);
        timer.Elapsed += TimerElapsed;
        
        
        timer.AutoReset = true; // Definir como false para gerar apenas uma notificação

        // Inicia o timer
        timer.Start();
    }

    private void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        // Lógica para gerar a notificação
        Console.Clear();
        
        Console.WriteLine("Tempo de descanço");
        Thread.Sleep(300000);
    }
}
}