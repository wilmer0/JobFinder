using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JobFinderModelo.MySql;
using JobFinderModelo.Sql;
using System.Windows.Forms;
using JobFinderModelo.Clases;

namespace JobFinderModelo.Modelos
{
    public class ModeloProducto
    {
        public List<tercero> listaCompleta()
        {
            try
            {
                coneccion coneccion = new coneccion();
                puntoventaEntities entity = coneccion.getConeccion();

                List<tercero> lista = new List<tercero>();
                lista = (from c in entity.tercero
                       select c).ToList();
                return lista;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.: "+ex.ToString());
                return null;
            }
        }
    }
}
