using System;

namespace Practica2
{
	public class Cronometro
	{
		public Cronometro ()
		{
		}		
		public void iniciar(){
			int horas, minutos, segundos;
			Console.Clear();
			for (horas = 0; horas < 24; horas++){
                        for (minutos = 0; minutos < 60; minutos++){
                            for (segundos = 0; segundos < 60; segundos++){
                                    Console.WriteLine(horas.ToString("00") + ":" + minutos.ToString("00") + ":" + segundos.ToString("00"));
                                    System.Threading.Thread.Sleep(1000);
                                    Console.Clear();
                            }
                        }
                    }
				
		}
	}
}

