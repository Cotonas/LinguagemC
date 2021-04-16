using System;
using System.Globalization;
using System.Collections.Generic;

namespace ListaFuncionarios {
    class Program {
        static void Main(string[] args) {

            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int quant = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quant; i++) {
                Console.WriteLine("\nEmplyoee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int idAumento = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == idAumento);
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percent);
            }
            else {
                Console.WriteLine("\nThis id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employess: ");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }

            Console.Write("\nCaso queira demitir algum funcionario digite 's' para Sim e 'n' para Não: ");
            char opcao = char.Parse(Console.ReadLine());
            if (opcao == 's' || opcao == 'S') {
                Console.Write("\nDigite o nome completo do funcionario para demitir: ");
                string demitir = Console.ReadLine();
                list.RemoveAll(x => x.Name == demitir);
                Console.WriteLine("\nLista de funcionarios atualizada:");
                foreach(Employee obj in list) {
                    Console.WriteLine(obj);
                }
            }
            else {
                Console.WriteLine("\nObrigado por utilizar nosso programa!");
            }

        }
    }
}
