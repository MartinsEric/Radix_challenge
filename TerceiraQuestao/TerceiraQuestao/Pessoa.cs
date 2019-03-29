namespace TerceiraQuestao
{
    public class Pessoa
    {
        public string Cpf { get; set; }

        public int Id_customers { get; set; }
        public Cliente Cliente { get; set; }
        

        public override string ToString()
        {
            return $" Cpf: {Cpf}";
        }
    }
}
