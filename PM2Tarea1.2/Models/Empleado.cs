using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PM2Tarea1._2.Models {
    public class Empleado {
        private string nombres;
        private string apellidos;
        private DateTime fechaNacimiento;
        private string correo;
        private List<string> invalidData = new List<string>();
        public Empleado() {
        }

        public Empleado(string nombres, string apellidos, DateTime fechaNacimiento, string correo) {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.Correo = correo;
        }



        public string Nombres {
            get { return this.nombres; }
            set {
                string regExpPattern = "^[a-zA-Z' -]+$";

                if (!string.IsNullOrEmpty(value) && Regex.IsMatch(value, regExpPattern)) {
                    this.nombres = value;
                } else {
                    this.invalidData.Add("Nombres");
                }
            }
        }


        public string Apellidos {
            get { return this.apellidos; }
            set {
                string regExpPattern = "^[a-zA-Z' -]+$";

                if (!string.IsNullOrEmpty(value) && Regex.IsMatch(value, regExpPattern)) {
                    this.apellidos = value;
                } else {
                    this.invalidData.Add("Apellidos");
                }
            }
        }




        public DateTime FechaNacimiento {
            get { return this.fechaNacimiento; }
            set {
                if (value <= DateTime.Now) {
                    this.fechaNacimiento = value;
                } else {
                    this.invalidData.Add("Fecha de Nacimiento");
                }
            }
        }






        public string Correo {
            get { return this.correo; }
            set {
                string regExpPattern = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";

                if (!string.IsNullOrEmpty(value) && Regex.IsMatch(value, regExpPattern)) {
                    this.correo = value;
                } else {
                    this.invalidData.Add("Correo");
                }
            }
        }




        public List<string> GetDatosInvalidos() {
            return this.invalidData;
        }
    }



}