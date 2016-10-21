using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JobFinderModelo.MySql;
using JobFinderModelo.Sql;
using System.Data.Entity;

namespace JobFinderModelo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Modelos.ModeloProducto modeloProducto = new Modelos.ModeloProducto();
            List<tercero> lista = new List<tercero>();
            lista = modeloProducto.listaCompleta();
            lista.ForEach(x => { Console.WriteLine(x.nombre); });
            Console.ReadLine();
        }
    }
}
