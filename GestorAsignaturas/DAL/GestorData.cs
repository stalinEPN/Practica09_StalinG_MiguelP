using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*
 * Se incluye la libreria para trabajar con entity framework
 */
using System.Data.Entity;
/*
 * Se incluye la referencia hacia el modelo
 */
using GestorAsignaturas.Models;

namespace GestorAsignaturas.DAL
{
    /*
     * Se deriva la clase DbConxtext
     */
    public class GestorData : DbContext
    {
        /*
         * Se incluye la propiedad que almacenara el conjunto de objetos de tipo aignatura
         */
        public DbSet<Asignatura> Asignaturas { get; set; }
    }
}