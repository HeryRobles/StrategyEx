namespace StrategyEx
{
    public class EnvioTerrestre : IEnvioStrategy
    {
        public decimal CalcularCostoEnvio(decimal peso)
        {
            return peso * 2.5m; 
        }
    }
}
