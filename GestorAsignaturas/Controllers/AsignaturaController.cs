using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*
 * Se incluyen las dependencias solicitadas
 */
using System.Data.Entity;
using System.Net;
using GestorAsignaturas.DAL;
using GestorAsignaturas.Models;


namespace GestorAsignaturas.Controllers
{
    public class AsignaturaController : Controller
    {
        /*
         * se agrega un objeto del tipo GestorData
         */
        private GestorData bd = new GestorData();


        // GET: Asignatura
        public ActionResult Index()
        {
            /*
             * se pasa como argumento a la vista una lista de asignaturas
             */
            return View(bd.Asignaturas.ToList());
        }

        /*
         * agregar el metodo de accion Detalles, tiene un argumento id
         */
        // GET: Asignatura/Detalles/5
        public ActionResult Detalles(int? id) {
            if  (id == null) {
                //si no se paso un id valido se returna un BAD REQUEST
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //Se crea un objeto asignatura y se busca la asignatura con el id 
            //pasado como parametro
            Asignatura asignaruta = bd.Asignaturas.Find(id);
            
            if(asignaruta == null) {
                //si no se encuentra la asignatura con el id ingresado, se retorna
                //un NOT FOUND
                return new HttpStatusCodeResult (HttpStatusCode.NotFound);
            }

            //Si el id que se pasa como parametro es correcto y se encuentra la 
            //asignatura se retorna la vista pasandole como parametro la asignatura
            return View(asignaruta);

        }


    }
}