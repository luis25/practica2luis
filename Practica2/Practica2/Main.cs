using System;
using System.Threading;

namespace Practica2
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			string opc;
			
			
			
			Console.WriteLine("Menu \n 1- Reloj \n 2-Cronometro");
			opc=Console.ReadLine(); 
			
			switch(opc){
			case "1": Reloj r=new Reloj();
				r.iniciar();
				 
				break;
			case "2": Cronometro c=new Cronometro();
				c.iniciar();
				

                    
				
				break;
			
			}
		}
	}
}