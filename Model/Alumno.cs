using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Alumno
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public static List<Alumno> Listar()
        {
            var alumnos = new List<Alumno>();
            for(var i = 0; i < 10; i++)
            {
                alumnos.Add(new Alumno()
                {
                    id = i,
                    nombre = "Alumno " + i
                });
            }
            return alumnos;
        }

    }
}
