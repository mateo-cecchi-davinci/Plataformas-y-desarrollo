﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Controladores;

namespace WindowsFormsApp2
{
    internal static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DB_Controller.initialize();

            if (validateConnection())
            {
                Trace.WriteLine("Conexion a la base de datos establecida con exito");
            }

            Application.Run(FormController.Index);

        }

        public static bool validateConnection()
        {
            try
            {
                DB_Controller.connection.Open();
                DB_Controller.connection.Close();
                return true;

            }
            catch(Exception ex)
            {
                Trace.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return false;
            }
        }

    }
}
