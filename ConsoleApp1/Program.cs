

using System.Numerics;

namespace ConsoleAPP
{
    class City
    {
        private string city_name { get; set; }
        private string country_name { get; set; }
        private int person_count { get; set; }
        private int phone_nums { get; set; }
        private string[] regions { get; set; }

        public City()
        {
            city_name = string.Empty;
            country_name = string.Empty;
            person_count = 0;
            phone_nums = 0;
            regions = null;
        }

        public City(string city_name, string country_name, int person_count, int phone_nums, string[] regions)
        {
            this.city_name = city_name;
            this.country_name = country_name;
            this.person_count = person_count;
            this.phone_nums = phone_nums;
            this.regions = regions;
        }
        public void Print() {
            Console.WriteLine(city_name);
            Console.WriteLine(country_name);
            Console.WriteLine(person_count);
            Console.WriteLine(phone_nums);
            Console.WriteLine(regions);
        }

        public static City operator +(City a, int p) { 
            return new City(a.city_name, a.country_name, a.person_count + p, a.phone_nums, a.regions);
        }

        public static City operator -(City a, int p)
        {
            return new City(a.city_name, a.country_name, a.person_count - p, a.phone_nums, a.regions);
        }

        public static bool operator ==(City a, City b)
        {
            return a.person_count == a.person_count;
        }
        public static bool operator !=(City a, City b)
        {
            return a.person_count != a.person_count;
        }
        public static bool operator >(City a, City b)
        {
            return a.person_count > a.person_count;
        }
        public static bool operator <(City a, City b)
        {
            return a.person_count < a.person_count;
        }
    }

    class Employee
    {
        
        private string fullName { get; set; }
        private DateTime birthDate { get; set; }
        private string phone { get; set; }
        private string workEmail { get; set; }
        private string position { get; set; }
        private string jobDescription { get; set; }

        private double sallery { get; set; }

        public Employee()
        {
            fullName = string.Empty;
            birthDate = DateTime.MinValue;
            phone = string.Empty;
            workEmail = string.Empty;
            position = string.Empty;
            jobDescription = string.Empty;
            sallery = 0;
        }

        
        public Employee(string fullName, DateTime birthDate, string phone, string workEmail, string position, string jobDescription, double sallery)
        {
            this.fullName = fullName;
            this.birthDate = birthDate;
            this.phone = phone;
            this.workEmail = workEmail;
            this.position = position;
            this.jobDescription = jobDescription;
            this.sallery = sallery;
        }

        
        public void Print()
        {
            Console.WriteLine("ФИО: " + fullName);
            Console.WriteLine("Дата рождения: " + birthDate.ToShortDateString());
            Console.WriteLine("Телефон: " + phone);
            Console.WriteLine("Рабочий email: " + workEmail);
            Console.WriteLine("Должность: " + position);
            Console.WriteLine("Описание служебных обязанностей: " + jobDescription);
            Console.WriteLine("Зарплата: " + sallery);
        }

        public static Employee operator +(Employee a, double f) {
            return new Employee(a.fullName, a.birthDate, a.phone, a.workEmail, a.position, a.jobDescription, a.sallery + f);
        }

        public static Employee operator -(Employee a, double f)
        {
            return new Employee(a.fullName, a.birthDate, a.phone, a.workEmail, a.position, a.jobDescription, a.sallery - f);
        }

        public static bool operator ==(Employee a, Employee b) { 
            return a.sallery == b.sallery;
        }
        public static bool operator !=(Employee a, Employee b)
        {
            return a.sallery != b.sallery;
        }
        public static bool operator >(Employee a, Employee b)
        {
            return a.sallery > b.sallery;
        }
        public static bool operator <(Employee a, Employee b)
        {
            return a.sallery < b.sallery;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}