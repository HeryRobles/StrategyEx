namespace StrategyEx
{
    public class EnvioMaritimo : IEnvioStrategy
    {
        public decimal CalcularCostoEnvio(decimal peso)
        {
            return peso * 1.5m;
        }
    }
}
