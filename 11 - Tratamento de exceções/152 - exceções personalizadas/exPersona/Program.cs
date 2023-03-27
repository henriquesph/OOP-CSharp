using System;
using System.Globalization;
using System.Net.Http.Headers;
using exPersona.Entities;
using exPersona.Entities.Exceptions;

public class Program
{
    public static void Main()
    {
        try // cenário: bloco principal de execução do programa
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in data (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out data (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();

            Console.WriteLine("Enter date to update the reservation ");
            Console.Write("Check-in data (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out data (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkIn, checkOut);

            Console.WriteLine("Reservartion: " + reservation);
        }
        catch (DomainExceptions e) // quando ocorre o erro no try a exceção é capturada - ex. personalizada
        {
            Console.WriteLine("Error in reservation: " + e.Message);
        }
        catch (FormatException e) // ex do sistema
        {
            Console.WriteLine("Format error: " + e.Message);
        }
        catch(Exception e) // tipo mais genérico - toda exceção vai "casar" por meio de upcasting
        {
            Console.WriteLine("Unexpected error: " + e.Message);
        }
    }
}