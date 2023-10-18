namespace StrategyEx
{
    public class Producto
    {
        private IEnvioStrategy _strategy;

        public Producto(IEnvioStrategy strategy)
        {
            _strategy = strategy;
        }

        public string Nombre { get; set; }
        public decimal Peso { get; set; }

        public decimal CalcularCostoEnvio()
        {
            return _strategy.CalcularCostoEnvio(Peso);
        }
    }
}
