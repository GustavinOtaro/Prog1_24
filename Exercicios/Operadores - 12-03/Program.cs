bool loop = true; 
while(loop) 
{
    WriteLine("Qual operador aritmetico deseja selecionar: (+ - * /) ou escreva 'finalizar' para encerrar o programa ?");
    string? operador = ReadLine();

    if(operador.Equals("finalizar"))
        break;

    switch(operador)
    {
        case "+":
            for (float n2 = 1; n2 <= 9; n2++)
            {
                for (float n1 = 1; n1 <= 9; n1++)
                {
                    WriteLine($"{n1} + {n2} = {n1 + n2}");
                }
                WriteLine("______________________________");
            }
            break;
        case "-":
            for (float n2 = 1; n2 <= 9; n2++)
            {
                for (float n1 = 1; n1 <= 9; n1++)
                {
                    WriteLine($"{n1} - {n2} = {n1 - n2}");
                }
                WriteLine("______________________________");
            }
            break;
        case "*":
            for (float n2 = 1; n2 <= 9; n2++)
            {
                for (float n1 = 1; n1 <= 9; n1++)
                {
                    WriteLine($"{n1} * {n2} = {n1 * n2}");
                }
                WriteLine("______________________________");
            }
            break;
        case "/":
            for (float n2 = 1; n2 <= 9; n2++)
            {
                for (float n1 = 1; n1 <= 9; n1++)
                {
                    WriteLine($"{n1} /  {n2} = {n1 / n2}");
                }
                WriteLine("______________________________");
            }
            break;
        default:
            WriteLine("Operação Invalida!!");
            break;
    }
    
}