using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//a. En el encabezado del archivo incluye 
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace GestorAsignaturas.Models {
    public class Asignatura {

        /*
         * b. Agrega una propiedad de tipo int denominada ID para almacenar
              un identificador único de la asignatura. Coloca el atributo [Key]
              para que indicar que es la llave primaria
         */
        [Key]
        public int ID { get; set; }

        /*
         * Colocar el atributo Nombre con required y un error en caso de no insertar el nombre
         * ademas colocar un tamaño maximo de 100 caracteres con su respectivo error en caso de 
         * superar estos caracteres.
         */

        [Required(ErrorMessage = "El nombre de la asignatura es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre de la asingnatura no puede superar los 100 caracteres.")]
        public string Nombre { get; set; }

        /*
         * Colocar el atributo Codigo con required y un error en caso de no insertar el codigo
         * ademas colocar un tamaño maximo de 7 caracteres con su respectivo error en caso de 
         * superar estos caracteres.
         */

        [Required(ErrorMessage = "El codigo de la asignatura es obligatorio.")]
        [StringLength(7, ErrorMessage = "El codigo de la asingnatura no puede superar los 7 caracteres.")]
        public string Codigo { get; set; }

        /*
         * Colocar el atributo Creditos con required y un error en caso de no insertar el codigo
         * ademas colocar un rango para que el valor de este atributo solamente este entre 0 y 15
         * con su respectivo error en caso de ingresar un valor fuera de este rango.
         */

        [Required(ErrorMessage = "El número de créditos de la asignatura es obligatorio.")]
        [Range(0, 15, ErrorMessage = "El número de créditos debe estar entre 0 y 15.")]
        public int Creditos { get; set; }

        /*
         * Colocar el atributo Horas con required y un error en caso de no insertar las Horas
         * ademas colocar un rango para que el valor de este atributo solamente este entre 1 y 45
         * con su respectivo error en caso de ingresar un valor fuera de este rango.
         */

        [Required(ErrorMessage = "El número de horas de la asignatura es obligatorio.")]
        [Range(1, 45, ErrorMessage = "El número de horas debe estar entre 1 y 45.")]
        public int Horas { get; set; }
    }

}
