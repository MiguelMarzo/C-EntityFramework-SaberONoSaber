using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using EntidadesBis;

namespace CapaNegocio
{
    public class Negocio
    {
        private Datos _datos = new Datos();

        public Pregunta devolverPregunta(int idPregunta)
        {
            return _datos.devolverPregunta(idPregunta);
        }

        public List<Respuesta> devolverRespuestas(int idPregunta)
        {
            return _datos.devolverRespuestas(idPregunta);
        }
    }
}
