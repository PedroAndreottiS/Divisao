//Ok, vamos começar criando os "doubles"
 double divisor, dividendo, quociente;

  Console.WriteLine("Escreva um número para o dividendo...");
   dividendo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Escreva um número para o Divisor...");
     divisor = Convert.ToDouble(Console.ReadLine());

//Nunca use um If sem outro comando na frente(no caso o divisor == 0)... Pode atrapalhar o resto.

if (divisor == 0) 
{ 
        Console.WriteLine("não é possível dividir por 0");
} else 
{ 
    quociente = dividendo/divisor;
    Console.WriteLine($"{dividendo} dividido por {divisor} é igual a {quociente}");
}
 //Acabei!
