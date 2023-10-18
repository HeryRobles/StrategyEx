namespace StrategyEx
{
    public class EnvioAereo : IEnvioStrategy
    {
        public decimal CalcularCostoEnvio(decimal peso)
        {
            return peso * 5.0m;
        }
    }
}
