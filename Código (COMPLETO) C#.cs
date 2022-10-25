using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int Num1, Num2, result = 0;
        string operacao;
        int VarLoop = 1;
          
        while (VarLoop == 1) {
        Console.WriteLine(">>>>CALCULADORA<<<<");
        Console.WriteLine("Menu de Operacoes: ");
        Console.WriteLine("1 = SOMA.");
        Console.WriteLine("2 = SUBTRACAO.");
        Console.WriteLine("3 = DIVISAO.");
        Console.WriteLine("4 = MULTIPLICACAO."); 
        Console.WriteLine("5 = SAIR.");
        
        Console.WriteLine("");
        Console.WriteLine("Digite o primeiro numero:");
        Num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o numero da operacao:");
        operacao = Console.ReadLine();
        
         Console.WriteLine("Digite o segundo numero:");
        Num2 = int.Parse(Console.ReadLine());
        
        switch (operacao)
        {
            case"1":
            result = Num1 + Num2;
              Console.WriteLine($"O resultado dessa SOMA e:{result}");
            break;
            case"2":
            result = Num1 - Num2;
            Console.WriteLine($"O resultado dessa SUBTRACAO e:{result}");
            break;
            
            case"3":
            if(Num2==0){
            Console.WriteLine("Nao e possivel dividir por 0.");
            break;
            }else{
            result = Num1 / Num2;
            Console.WriteLine($"O resultado dessa DIVISAO e:{result}");
            break;}
            
            case"4":
            result = Num1 * Num2;
            Console.WriteLine($"O resultado dessa MULTIPLICACAO e:{result}");
            break;
            case"5":
            Console.WriteLine("O programa sera encerrado...");
            VarLoop = 0;
            break;
            
            default:
            Console.WriteLine("Operacao invalida");
            break;
        }
      
        Console.WriteLine("Pressione ENTER para continuar...");
        
       Console.ReadKey(true);
       
        }
    }
}
