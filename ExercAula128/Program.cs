﻿using ExercAula128.Entities;
using ExercAula128.Entities.Enums;
using System.Globalization;

namespace ExercAula128
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtendo dados iniciais:
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine( "Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Instanciando departamento e o trabalhador
            Department dept = new Department(deptName);
            Worker worker = new Worker(name,level,baseSalary,dept);

            //Quantidade de contratos e os obtendo
            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {(i+1)} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePorHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("-----  -----");
                HourContract contract = new HourContract(date,valuePorHour,hours);
                worker.AddContract(contract);
            }

            Console.WriteLine("");
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}