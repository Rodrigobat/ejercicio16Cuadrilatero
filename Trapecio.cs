
namespace EjercicioClase16
{
     public class Trapecio : Cuadrilatero
    {
        public Trapecio() :base()
        {

        }
       public override double calcularArea()
        {
            double result=0;
            result=0.5*((base.vertice1x*base.vertice2y + base.vertice2x*base.vertice3y + base.vertice3x*base.vertice4y + base.vertice4x*base.vertice1y) - (base.vertice1x*base.vertice4y + base.vertice4x*base.vertice3y + base.vertice3x*base.vertice2y + base.vertice2x*base.vertice1y));
            return result;
        }       
    }
}