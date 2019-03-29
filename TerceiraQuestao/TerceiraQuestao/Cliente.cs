namespace TerceiraQuestao
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Credit_Limit { get; set; }
        public Pessoa Cpf { get; set; }

        public override string ToString()
        {
            return $"Nome: {Name}";
        }
    }
}
