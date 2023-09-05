using System;
using System.Text;

// namespace Library
// {
//     public class AppointmentService
//     {
//         public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
//         {
//             StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
//             Boolean isValid = true;

//             if (string.IsNullOrEmpty(name))
//             {
//                 stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
//                 isValid = false;
//             }

//             if (string.IsNullOrEmpty(id))
//             {
//                 stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
//                 isValid = false;
//             }

//             if (string.IsNullOrEmpty(phoneNumber))
//             {
//                 stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
//                 isValid = false;
//             }

//             if (string.IsNullOrEmpty(appoinmentPlace))
//             {
//                 stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
//                 isValid = false;
//             }


//             if (string.IsNullOrEmpty(doctorName))
//             {
//                 stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
//                 isValid = false;
//             }

//             if (isValid)
//             {
//                 stringBuilder.Append("Appoinment scheduled");
//             }

//             return stringBuilder.ToString();
//         }

//     }
// }



// Esta clase:
// Coordina la creación de citas médicas
// Valida los datos de la cita médica
// Genera un identificador único para la cita

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(Appointment appointment)
        {
            if (appointment == null)
            {
                throw new ArgumentNullException(nameof(appointment), "Objeto de cita médica es requerido");
            }

            var stringBuilder = new StringBuilder("Programando cita...\n");
            bool isValid = true;

            if (string.IsNullOrEmpty(appointment.Name))
            {
                stringBuilder.Append("No se puede programar la cita, dato 'name' es requerido\n");
                isValid = false;
            }

            // Aqui podría validar otros campos de la cita médica

            if (isValid)
            {
                // Genero un identificador único para la cita 
                stringBuilder.Append("Cita programada");
            }

            return stringBuilder.ToString();
        }
    }
}