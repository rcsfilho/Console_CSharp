using Hospital;
namespace Principal
{
     public class Program
    {
        public static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario ("Jose", 3500, "Manha");
            Console.WriteLine("Dados do Funcionario:");
            funcionario.ExibirDados();

            Console.WriteLine("Quantos médicos você deseja cadastrar?");
            int qtdMedicos = int.Parse(Console.ReadLine());

            List<Medico> medicos = new List<Medico>();

            for(int i = 0; i < qtdMedicos; i++)
            {
                Medico medico = new Medico("", 0, "", "", "", "");

                Console.WriteLine($"Digite o nome do {i+1}º médico:");
                medico.Nome = Console.ReadLine();

                Console.WriteLine($"Digite o salário do {i+1}º médico:");
                medico.Salario = double.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o turno do {i+1}º médico:");
                medico.Turno = Console.ReadLine();

                Console.WriteLine($"Digite o CRM do {i+1}º médico: (máximo de seis numeros permitidos)");
                medico.CRM  = Console.ReadLine();

                Console.WriteLine($"Digite a especialidade do {i+1}º médico:");
                medico.Especialidade = Console.ReadLine();

                Console.WriteLine($"Digite o sexo do {i+1}º médico:");
                medico.Sexo = Console.ReadLine();

                
                medicos.Add(medico);


            }

            Console.WriteLine("\nDados dos Médicos:");
            foreach (Medico medico in medicos)
            {
                medico.ExibirDados();
                Console.WriteLine();
            }


            Console.WriteLine("Quantos enfermeiros você deseja cadastrar?");
            int qtdEnfermeiros = int.Parse(Console.ReadLine());

            List<Enfermeiro> enfermeiros = new List<Enfermeiro>();

            for(int i = 0; i < qtdEnfermeiros; i++)
            {
                Enfermeiro enfermeiro = new Enfermeiro("", 0, "", "", "", 0);

                Console.WriteLine($"Digite o nome do {i+1}º enfermeiro:");
                enfermeiro.Nome = Console.ReadLine();

                Console.WriteLine($"Digite o salário do {i+1}º enfermeiro:");
                enfermeiro.Salario = double.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o turno do {i+1}º enfermeiro:");
                enfermeiro.Turno = Console.ReadLine();

                Console.WriteLine($"Digite o COREN do {i+1}º enfemeiro:");
                enfermeiro.Coren = Console.ReadLine();

                Console.WriteLine($"Digite o setor do {i+1}º enfermeiro:");
                enfermeiro.Setor = Console.ReadLine();

                Console.WriteLine($"Digite quantos anos o {i+1}º enfermeiro tem de experiência:");
                enfermeiro.AnosExperiencia = int.Parse(Console.ReadLine());

                
                enfermeiros.Add(enfermeiro);


            }

            Console.WriteLine("\nDados dos Enfermeiros:");
            foreach (Enfermeiro enfermeiro in enfermeiros)
            {
                enfermeiro.ExibirDados();
                Console.WriteLine();
            }

            Console.WriteLine("Quantos recepcionistas você deseja cadastrar?");
            int qtdRecepcionistas = int.Parse(Console.ReadLine());

            List<Recepcionista> recepcionistas = new List<Recepcionista>();

            for(int i = 0; i < qtdRecepcionistas; i++)
            {
                Recepcionista recepcionista = new Recepcionista("", 0, "", "", "", false);

                Console.WriteLine($"Digite o nome do {i+1}º recepcionista:");
                recepcionista.Nome = Console.ReadLine();

                Console.WriteLine($"Digite o salário do {i+1}º recepcionista:");
                recepcionista.Salario = double.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o turno do {i+1}º recepcionista:");
                recepcionista.Turno = Console.ReadLine();

                Console.WriteLine($"Digite o ramal do {i+1}º recepcionista:");
                recepcionista.Ramal = Console.ReadLine();

                Console.WriteLine($"Digite o Departamento do {i+1}º recepcionista:");
                recepcionista.Departamento = Console.ReadLine();

                Console.WriteLine($"Digite se o {i+1}º recepcionista presta atendimento bilingue:");
                recepcionista.AtendimentoBilingue = bool.Parse(Console.ReadLine());

                
                recepcionistas.Add(recepcionista);


            }

            Console.WriteLine("\nDados dos Recepcionistas:");
            foreach (Recepcionista recepcionista in recepcionistas)
            {
                recepcionista.ExibirDados();
                Console.WriteLine();
            }

            Console.WriteLine("Qual médico deve realizar as consultas? (Digite o número correspondente)");
            for(int i = 0; i < medicos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {medicos[i].Nome}");
            }
            int indexMedico = int.Parse(Console.ReadLine()) - 1;

            if(indexMedico >= 0 && indexMedico < medicos.Count)
            {
                medicos[indexMedico].RealizarConsultas();
            }
            else
            {
                Console.WriteLine("Médico não encontrado.");
            }

            Console.WriteLine("Qual médico deve prescrever o medicamento? (Digite o número correspondente)");
            for(int i = 0; i < medicos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {medicos[i].Nome}");
            }
            int indexMedico2 = int.Parse(Console.ReadLine()) - 1;

            if(indexMedico2 >= 0 && indexMedico2 < medicos.Count)
            {
                medicos[indexMedico2].PrescreverMedicamentos();
            }
            else
            {
                Console.WriteLine("Médico não encontrado.");
            }

            Console.WriteLine("Qual enfermeiro deve realizar o curativo? (Digite o número correspondente)");
            for(int i = 0; i < enfermeiros.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {enfermeiros[i].Nome}");
            }
            int indexEnfermeiro = int.Parse(Console.ReadLine()) - 1;

            if(indexEnfermeiro >= 0 && indexEnfermeiro < enfermeiros.Count)
            {
                enfermeiros[indexEnfermeiro].RealizarCurativos();
            }
            else
            {
                Console.WriteLine("Enfermeiro não encontrado.");
            }

            Console.WriteLine("Qual enfermeiro deve administrar o medicamento? (Digite o número correspondente)");
            for(int i = 0; i < enfermeiros.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {enfermeiros[i].Nome}");
            }
            int indexEnfermeiro2 = int.Parse(Console.ReadLine()) - 1;

            if(indexEnfermeiro2 >= 0 && indexEnfermeiro2 < enfermeiros.Count)
            {
                enfermeiros[indexEnfermeiro2].AdministrarMedicamentos();
            }
            else
            {
                Console.WriteLine("Enfermeiro não encontrado.");
            }

            Console.WriteLine("Qual recepcionista deve orientar os pacientes? (Digite o número correspondente)");
            for(int i = 0; i < recepcionistas.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {recepcionistas[i].Nome}");
            }
            int indexRecepcionistas = int.Parse(Console.ReadLine()) - 1;

            if(indexRecepcionistas >= 0 && indexRecepcionistas < recepcionistas.Count)
            {
                recepcionistas[indexRecepcionistas].ReceberPacientes();
            }
            else
            {
                Console.WriteLine("Recepcionista não encontrado.");
            }

            Console.WriteLine("Qual recepcionista deve ficar responsável pelas chamadas telefônicas? (Digite o número correspondente)");
            for(int i = 0; i < recepcionistas.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {recepcionistas[i].Nome}");
            }
            int indexRecepcionistas2 = int.Parse(Console.ReadLine()) - 1;

            if(indexRecepcionistas2 >= 0 && indexRecepcionistas2 < recepcionistas.Count)
            {
                recepcionistas[indexRecepcionistas2].EncaminharChamadas();
            }
            else
            {
                Console.WriteLine("Recepcionista não encontrado.");
            }
        } 
    }
}
