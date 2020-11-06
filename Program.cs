using System;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)

        {             
            string sair, mensagem;
            do
            {
               Console.Clear();
               int a, b, resto;
               Box("MDC",15,6,5,0);
          
               Console.Write("Entre 1º numero :");
               a=Convert.ToInt16(Console.ReadLine());
               Console.Write("Entre 2º numero :");
               b=Convert.ToInt16(Console.ReadLine());    
              mensagem="O MDC de ("+a+" e "+b+") é ";
               do
                {
                    resto = a % b;
                    a = b;
                    b = resto;
                } while (b!=0);

             mensagem=mensagem + a;             
               Box(mensagem,6,15,0,7);
               Console.Write("\nOutro (s) ?:");
               sair=Console.ReadLine().ToUpper();
            } while(sair == "S");
            Console.Clear();           
        }
        static void Box( String S2,int Cor_Caixa, int Cor_Letra, int X, int Y)//  Texto dentro da caixa    
        {
         int tamanho = S2.Length; 
         Console.SetCursorPosition(X, Y);
         string lin = new string('*', tamanho+4); 
         string vazio = new string(' ',tamanho+2);
           // imprime Caixa
         ConsoleColor CorCaixa = (ConsoleColor)Cor_Caixa;
         Console.ForegroundColor = CorCaixa;
         Console.SetCursorPosition(X, Y);Console.WriteLine(lin);         
         Console.SetCursorPosition(X, Y+1);Console.Write($"*{vazio}*");         
         Console.SetCursorPosition(X, Y+2);Console.Write(lin);   
          // imprime Titulo
         ConsoleColor CorLetra = (ConsoleColor)Cor_Letra;
         Console.ForegroundColor = CorLetra;
         Console.SetCursorPosition(X+2, Y+1);
         Console.WriteLine(S2);
         //proxima coordenadas        
         Console.ResetColor();  
         Console.SetCursorPosition(0, Y+4);
        }// Fecha Box

    }
}