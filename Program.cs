using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAgeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Enter the year of birth : ");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month of birth : ");
            int monthOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day of birth : ");
            int dayOfBirth = Convert.ToInt32(Console.ReadLine());

            DateTime birthDay = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);

            if (birthDay.Day > now.Day && birthDay.Month < now.Month)
            {
                int day = (now.Day - birthDay.Day) + DateTime.DaysInMonth(now.Year, birthDay.Month);
                int month = now.Month - birthDay.Month - 1;
                int year = now.Year - birthDay.Year;
                int hour = now.Hour - birthDay.Hour;
                int minute = now.Minute - birthDay.Minute;
                Console.WriteLine($"You are {year} years, {month} months, {day} days, {hour} hours and {minute} minutes old.");
            }
            else if (birthDay.Day < now.Day && birthDay.Month > now.Month)
            {
                int day = now.Day - birthDay.Day;
                int year = now.Year - birthDay.Year - 1;
                int month = now.Month - birthDay.Month + 12;
                int hour = now.Hour - birthDay.Hour;
                int minute = now.Minute - birthDay.Minute;
                Console.WriteLine($"You are {year} years, {month} months, {day} days, {hour} hours and {minute} minutes old.");
            }
            else if(birthDay.Day < now.Day && birthDay.Month < now.Month)
            {
                int year = now.Year - birthDay.Year;
                int month = now.Month - birthDay.Month;
                int day = now.Day - birthDay.Day;
                int hour = now.Hour - birthDay.Hour;
                int minute = now.Minute - birthDay.Minute;
                Console.WriteLine($"You are {year} years, {month} months, {day} days, {hour} hours and {minute} minutes old.");
            }
            else
            {
                int day = (now.Day - birthDay.Day) + DateTime.DaysInMonth(now.Year, birthDay.Month);
                int month = now.Month - birthDay.Month + 12;
                int year = now.Year - birthDay.Year - 1;
                int hour = now.Hour - birthDay.Hour;
                int minute = now.Minute - birthDay.Minute;
                Console.WriteLine($"You are {year} years, {month} months, {day} days, {hour} hours and {minute} minutes old.");
            }
            Console.ReadKey();
        }
    }
}
