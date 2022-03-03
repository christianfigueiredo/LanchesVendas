using IES.Models;
using System.Linq;

namespace IES.Data
{
    public class IESDbInitializer
    {
        public static void Initializer(IESContext context)
        {
            context.Database.EnsureCreated();
            if(context.Departamentos.Any())
            {
                return;
            }
            var departamentos = new Departamento[]
            {
                new Departamento{Nome="Ciência da Computação"},
                new Departamento {Nome="Ciência de Alimentos"}
            };

            foreach(Departamento d in departamentos)
            {
                context.Departamentos.Add(d);
            }
            context.SaveChanges();
        }
    }
}
