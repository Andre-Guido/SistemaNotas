using System;
using System.Collections.Generic;
using SistemaNotas.Modelos;
using SistemaNotas.Vista;

namespace SistemaNotas.Controlador
{
    // Create, Read, Update, Delete
    public class CarreraController
    {
        private List<Carrera> carreras = new List<Carrera>();
        public Boolean Agregar(string nombre, string codigo)
        {
            try
            {
                Carrera carrera = new Carrera(codigo, nombre);
                carreras.Add(carrera);
                return true;
            } 
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Obtiene todas las carreras.
        /// </summary>
        /// <returns></returns>
        public List<Carrera> GetCarreras()
        {
            return carreras;
        }
        public Carrera GetCarrera(string codigo, string nombre)
        {
            Carrera carrera = carreras.Find(c => c.Codigo == codigo);
            return carrera;
        }
        public Boolean Eliminar(string nombre, string codigo)
        {
            Carrera carrera = GetCarrera(codigo, nombre);
            if (carrera == null)
            {
                return false;
            }
            carreras.Remove(carrera);
            return true;
        }
        /// <summary>
        /// Busca un elemento y retorna los elementos que coinciden.
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public List<Carrera> GetCarreras(string dato)
        {
            List<Carrera> carreras = new List<Carrera>();
            return carreras;
        }
    }
}
