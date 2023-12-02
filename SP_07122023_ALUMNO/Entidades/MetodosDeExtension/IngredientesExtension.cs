using Entidades.Enumerados;


namespace Entidades.MetodosDeExtension
{
    public class IngredientesExtension
    {
        public double CalcularCostoIngredientes (List<EIngrediente> ingredientes, int costoInicial)
        {
            return 1;
        }

        public List<EIngrediente> IngredientesAleatorios(Random rand)
        {
           // return Ingredientes.Take("Aca va el numero aleatorio)".ToList();

            return new List<EIngrediente> {  new EIngrediente() };
        }

    }
}
