namespace ExemploSiteCompra
{
    public class Produto
    {
  
        public Produto(string _nome, double _valor)
        {
            this.Nome = _nome;
            this.Valor = _valor;
        }

        public double Valor { get; internal set; }
        public string Nome { get; set; }
    }
}