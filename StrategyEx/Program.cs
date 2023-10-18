using StrategyEx;

var productoTerrestre = new Producto(new EnvioTerrestre());
productoTerrestre.Nombre = "Producto Terrestre";
productoTerrestre.Peso = 5;

var productoAereo = new Producto(new EnvioAereo());
productoAereo.Nombre = "Producto Aéreo";
productoAereo.Peso = 5;

var productoMaritimo = new Producto(new EnvioMaritimo());
productoMaritimo.Nombre = "Producto Marítimo";
productoMaritimo.Peso = 5;

Console.WriteLine($"Costo de envío para {productoTerrestre.Nombre}: {productoTerrestre.CalcularCostoEnvio()}");
Console.WriteLine($"Costo de envío para {productoAereo.Nombre}: {productoAereo.CalcularCostoEnvio()}");
Console.WriteLine($"Costo de envío para {productoMaritimo.Nombre}: {productoMaritimo.CalcularCostoEnvio()}");
