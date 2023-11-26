namespace Hospital
{
    public class Funcionario
{
    private string nome;
    private double salario;
    private string turno;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public double Salario
    {
        get { return salario; }
        set { salario = value; }
    }

    public string Turno
    {
        get { return turno; }
        set { turno = value; }
    }

    public Funcionario(string nome, double salario, string turno)
    {
        Nome = nome;
        Salario = salario;
        Turno = turno;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Salário: {Salario}");
        Console.WriteLine($"Turno: {Turno}");
    }
}

public class Medico : Funcionario
{
    private string crm;
    private string especialidade;
    private string sexo;

    public string CRM 
    { 
        get { return crm; } 
        set { crm = value; } 
    }

    public string Especialidade 
    { 
        get { return especialidade; } 
        set { especialidade = value; } 
    }

    public string Sexo 
    { 
        get { return sexo; } 
        set { sexo = value; } 
    }

    public Medico(string nome, double salario, string turno, string crm, string especialidade, string sexo) : base(nome, salario, turno)
    {
        CRM = crm;
        Especialidade = especialidade;
        Sexo = sexo;
    }

    public string GetNomeMed()
    {
        return base.Nome;
    }

    public void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"CRM: {CRM}");
        Console.WriteLine($"Especialidade: {Especialidade}");
        Console.WriteLine($"Sexo: {Sexo}");
    }
    public void RealizarConsultas()
    {
        Console.WriteLine($"{Nome} realizando consultas");
    }
    public void PrescreverMedicamentos()
    {
        Console.WriteLine($"{Nome} prescrevendo medicamentos");
    }
}

public class Enfermeiro : Funcionario
{
    private string coren;
    private string setor;
    private int anosExperiencia;

    public string Coren 
    { 
        get { return coren; } 
        set { coren = value; } 
    }

    public string Setor 
    { 
        get { return setor; } 
        set { setor = value; } 
    }

    public int AnosExperiencia 
    { 
        get { return anosExperiencia; } 
        set { anosExperiencia = value; } 
    }

    public Enfermeiro(string nome, double salario, string turno, string coren, string setor, int anosExperiencia)
        : base(nome, salario, turno)
    {
        Coren = coren;
        Setor = setor;
        AnosExperiencia = anosExperiencia;
    }


    public string GetNomeEnf()
    {
        return base.Nome;
    }

   public void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"COREN: {Coren}");
        Console.WriteLine($"Setor: {Setor}");
        Console.WriteLine($"Anos de experiencia: {AnosExperiencia}");
    }
    public void RealizarCurativos()
    {
        Console.WriteLine($"{Nome} realizando curativos");
    }

    public void AdministrarMedicamentos()
    {
        Console.WriteLine($"{Nome} administrando medicamentos");
    }
}

public class Recepcionista : Funcionario
{
    private string ramal;
    private string departamento;
    private bool atendimentoBilingue;

    public string Ramal
    {
        get { return ramal; } 
        set { ramal = value; } 
    }

    public string Departamento
    {
        get { return departamento; } 
        set {departamento = value; }
    }

    public bool AtendimentoBilingue
    {
        get { return atendimentoBilingue; }
        set {atendimentoBilingue = value; }
    }
    public Recepcionista(string nome, double salario, string turno, string ramal, string departamento, bool atendimentoBilingue)
        : base(nome, salario, turno)
    {
        Ramal = ramal;
        Departamento = departamento;
        AtendimentoBilingue = atendimentoBilingue;
    }
        public string GetNomeRep()
    {
        return base.Nome;
    }

        public void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Ramal: {Ramal}");
        Console.WriteLine($"Departamento: {Departamento}");
        Console.WriteLine($"Atendimento Bilingue: {AtendimentoBilingue}");
    }
     public void ReceberPacientes()
    {
        Console.WriteLine($"{Nome} recebe os pacientes no Hospital.");
    }
    public void EncaminharChamadas()
    {
        Console.WriteLine($"{Nome} repassa as chamadas telefônicas.");
    }

}
}
