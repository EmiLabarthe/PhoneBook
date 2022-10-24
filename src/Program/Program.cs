using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact Emi = new Contact("Emi");
            // Crear la lista de contactos
            Phonebook phonebook1 = new Phonebook(Emi);
            // Agregar contactos a la lista
            Contact Manu = new Contact("Manu");
            phonebook1.AddContact(Manu);
            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos
            string [] Send = new string[1]{"Manu"};
            WhatsApp wpp = new WhatsApp();
            Manu.Phone = "+59891690850";
            phonebook1.Send(Send , wpp, "Hola");
            // Enviar un SMS a algunos contactos
        }
    }
}
