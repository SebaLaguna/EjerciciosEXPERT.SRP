using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Creo esta clase que representa los datos de la cita médica
//También almacena los datos de la misma (nombre, ID, número de teléfono, fecha, lugar de la cita, nombre del médico).

namespace Library
{
    public class Appointment
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public string AppointmentPlace { get; set; }
        public string DoctorName { get; set; }
    }
}