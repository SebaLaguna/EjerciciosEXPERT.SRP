// using System;
// using Library;

// namespace Program
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
//             Console.WriteLine(appointmentResult);

//             string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
//             Console.WriteLine(appointmentResult2);
//         }
//     }
// }


// Iplemento las demás clases y hago que se impriman los datos de los pacientes para las citas médicas

using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo objetos de cita médica en lugar de variables separadas
            var appointment1 = new Appointment
            {
                Name = "Steven Jhonson",
                Id = "986782342",
                PhoneNumber = "5555-555-555",
                Date = DateTime.Now,
                AppointmentPlace = "Wall Street",
                DoctorName = "Armand"
            };

            // Creo la cita médica utilizando el objeto
            string appointmentResult1 = AppointmentService.CreateAppointment(appointment1);
            Console.WriteLine(appointmentResult1);

            // Imprimo los valores de la cita médica para que me aparecezcan en la consola solamente
            Console.WriteLine("Datos de la cita médica 1:");
            Console.WriteLine($"Nombre: {appointment1.Name}");
            Console.WriteLine($"ID: {appointment1.Id}");
            Console.WriteLine($"Número de teléfono: {appointment1.PhoneNumber}");
            Console.WriteLine($"Fecha: {appointment1.Date}");
            Console.WriteLine($"Lugar de la cita: {appointment1.AppointmentPlace}");
            Console.WriteLine($"Nombre del médico: {appointment1.DoctorName}");

            var appointment2 = new Appointment
            {
                Name = "Ralf Manson",
                Id = "",
                PhoneNumber = "5555-555-555",
                Date = DateTime.Now,
                AppointmentPlace = "Queen Street",
                DoctorName = ""
            };

            string appointmentResult2 = AppointmentService.CreateAppointment(appointment2);
            Console.WriteLine(appointmentResult2);

            // También imprimo los valores de la cita médica 2
            Console.WriteLine("Datos de la cita médica 2:");
            Console.WriteLine($"Nombre: {appointment2.Name}");
            Console.WriteLine($"ID: {appointment2.Id}");
            Console.WriteLine($"Número de teléfono: {appointment2.PhoneNumber}");
            Console.WriteLine($"Fecha: {appointment2.Date}");
            Console.WriteLine($"Lugar de la cita: {appointment2.AppointmentPlace}");
            Console.WriteLine($"Nombre del médico: {appointment2.DoctorName}");
        }
    }
}


