﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Data.Entity;

namespace JobFinderModelo.Modelos
{
    public class coneccion
    {

        private static coneccion instance;
        public static DatosConeccionBD datosConeccionBd;

        public static coneccion Instance
        {
            get
            {
                
                if (instance == null)
                {
                    instance = new coneccion();
                }
                return instance;
            }
        }

        
        public coneccion(DatosConeccionBD datosConeccion)
        {
            datosConeccionBd = datosConeccion;
        }


        public coneccion()
        {
            
        }


        public coneccion getConeccion()
        {
            if (datosConeccionBd == null)
            {
                datosConeccionBd = new DatosConeccionBD();
                



                //         public ADMFICEntities(string servidor, String baseDatos, String user, String pass)
                //    : base("name=ADMFICEntities")
                //{


                //var connectionString = this.Database.Connection.ConnectionString + ";password=" + pass;
                //    connectionString = "server=" + servidor + ";userid=" + user + ";persistsecurityinfo=true;database=" + baseDatos + ";password=" + pass;

                //    this.Database.Connection.ConnectionString = connectionString;
                //}

                //        if (!System.IO.Directory.Exists("Configuracion"))
                //        {

                //            System.IO.Directory.CreateDirectory("Configuracion");

                //        }




                //        // leer archivo
               
                datosConeccionBd.Servidor = "localhost";
                datosConeccionBd.BaseDatos = "jobfinder";
                datosConeccionBd.Usuario = "root";
                datosConeccionBd.Contrasena = "wilmerlomas1";
                return new datosConeccionBd(datosConeccionBd.Servidor, datosConeccionBd.BaseDatos,datosConeccionBd.Usuario, datosConeccionBd.Contrasena);

            }

            else
            {
                return new datosConeccionBd(datosConeccionBd.Servidor, datosConeccionBd.BaseDatos,datosConeccionBd.Usuario,datosConeccionBd.Contrasena);
            }

        }
    }

}
