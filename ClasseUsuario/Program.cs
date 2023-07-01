using System;

public class Pessoa {
    public string nome;
    public int idade;
    public string endereco;
}
public class Gerente : Pessoa {
    public string departamento;
    public double salario;
}
public class Supervisor : Pessoa {
    public string area;
    public double salario;
}
public class Operario : Pessoa {
    public string cargo;
    public double salario;
}
public class Program {
    public static void Main() {
        Gerente gerente1 = new Gerente();
        gerente1.nome = "João Silva";
        gerente1.idade = 35;
        gerente1.endereco = "Rua A, 123";
        gerente1.departamento = "Vendas";
        gerente1.salario = 10000.00;

        Supervisor supervisor1 = new Supervisor();
        supervisor1.nome = "Maria Santos";
        supervisor1.idade = 28;
        supervisor1.endereco = "Rua B, 456";
        supervisor1.area = "Produção";
        supervisor1.salario = 5000.00;

        Operario operario1 = new Operario();
        operario1.nome = "Pedro Oliveira";
        operario1.idade = 20;
        operario1.endereco = "Rua C, 789";
        operario1.cargo = "Auxiliar de produção";
        operario1.salario = 2000.00;

        Console.WriteLine("Gerente:");
        Console.WriteLine("Nome: " + gerente1.nome);
        Console.WriteLine("Idade: " + gerente1.idade);
        Console.WriteLine("Endereço: " + gerente1.endereco);
        Console.WriteLine("Departamento: " + gerente1.departamento);
        Console.WriteLine("Salário: " + gerente1.salario);

        Console.WriteLine("\nSupervisor:");
        Console.WriteLine("Nome: " + supervisor1.nome);
        Console.WriteLine("Idade: " + supervisor1.idade);
        Console.WriteLine("Endereço: " + supervisor1.endereco);
        Console.WriteLine("Área: " + supervisor1.area);
        Console.WriteLine("Salário: " + supervisor1.salario);

        Console.WriteLine("\nOperário:");
        Console.WriteLine("Nome: " + operario1.nome);
        Console.WriteLine("Idade: " + operario1.idade);
        Console.WriteLine("Endereço: " + operario1.endereco);
        Console.WriteLine("Cargo: " + operario1.cargo);
        Console.WriteLine("Salário: " + operario1.salario);
    }
}
