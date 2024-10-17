

namespace ConsoleAPP
{
    class City
    {
        private string city_name;
        private string country_name;
        private int person_count;
        private int phone_nums;
        private string[] regions;

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

        public void InputCityName(string city_name) {
            this.city_name = city_name;
        }

        public void InputCountryName(string country_name) {
            this.country_name = country_name;    
        }

        public void InputPersonCount(int person_count) { 
            this.person_count = person_count;
        }

        public void InputPhoneNums(int phone_nums) { 
            this.phone_nums = phone_nums;
        }

        public void InputRegions(string[] regions) { 
            this.regions = new string[regions.Length];

            for (int i = 0; i < regions.Length; i++) {
                this.regions[i] = regions[i];
            }
        }

        public string GetCityName()
        {
            return this.city_name;
        }
        public string GetCountryName()
        {
            return this.country_name;
        }
        public int GetPersonCount()
        {
            return (int) this.person_count;
        }
        public int GetPhoneNums()
        {
            return (int) this.phone_nums;
        }
        public string[] GetRegions()
        {
            return this.regions;
        }

        public void Print() {
            Console.WriteLine(city_name);
            Console.WriteLine(country_name);
            Console.WriteLine(person_count);
            Console.WriteLine(phone_nums);
            Console.WriteLine(regions);
        }



    }

    class Employee
    {
        
        private string fullName;
        private DateTime birthDate;
        private string phone;
        private string workEmail;
        private string position;
        private string jobDescription;

        
        public Employee()
        {
            fullName = string.Empty;
            birthDate = DateTime.MinValue;
            phone = string.Empty;
            workEmail = string.Empty;
            position = string.Empty;
            jobDescription = string.Empty;
        }

        
        public Employee(string fullName, DateTime birthDate, string phone, string workEmail, string position, string jobDescription)
        {
            this.fullName = fullName;
            this.birthDate = birthDate;
            this.phone = phone;
            this.workEmail = workEmail;
            this.position = position;
            this.jobDescription = jobDescription;
        }

        
        public void InputFullName(string fullName)
        {
            this.fullName = fullName;
        }

        public void InputBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }

        public void InputPhone(string phone)
        {
            this.phone = phone;
        }

        public void InputWorkEmail(string workEmail)
        {
            this.workEmail = workEmail;
        }

        public void InputPosition(string position)
        {
            this.position = position;
        }

        public void InputJobDescription(string jobDescription)
        {
            this.jobDescription = jobDescription;
        }

        
        public string GetFullName()
        {
            return this.fullName;
        }

        public DateTime GetBirthDate()
        {
            return this.birthDate;
        }

        public string GetPhone()
        {
            return this.phone;
        }

        public string GetWorkEmail()
        {
            return this.workEmail;
        }

        public string GetPosition()
        {
            return this.position;
        }

        public string GetJobDescription()
        {
            return this.jobDescription;
        }

        
        public void Print()
        {
            Console.WriteLine("ФИО: " + fullName);
            Console.WriteLine("Дата рождения: " + birthDate.ToShortDateString());
            Console.WriteLine("Телефон: " + phone);
            Console.WriteLine("Рабочий email: " + workEmail);
            Console.WriteLine("Должность: " + position);
            Console.WriteLine("Описание служебных обязанностей: " + jobDescription);
        }
    }

    class Airplane
    {
        
        private string airplaneName;
        private string manufacturer;
        private int yearOfManufacture;
        private string airplaneType;

        
        public Airplane()
        {
            airplaneName = string.Empty;
            manufacturer = string.Empty;
            yearOfManufacture = 0;
            airplaneType = string.Empty;
        }

        
        public Airplane(string airplaneName, string manufacturer, int yearOfManufacture, string airplaneType)
        {
            this.airplaneName = airplaneName;
            this.manufacturer = manufacturer;
            this.yearOfManufacture = yearOfManufacture;
            this.airplaneType = airplaneType;
        }

        
        public void InputData(string airplaneName)
        {
            this.airplaneName = airplaneName;
        }

        
        public void InputData(string airplaneName, string manufacturer)
        {
            this.airplaneName = airplaneName;
            this.manufacturer = manufacturer;
        }

        /
        public void InputData(string airplaneName, string manufacturer, int yearOfManufacture, string airplaneType)
        {
            this.airplaneName = airplaneName;
            this.manufacturer = manufacturer;
            this.yearOfManufacture = yearOfManufacture;
            this.airplaneType = airplaneType;
        }

        
        public string GetAirplaneName()
        {
            return this.airplaneName;
        }

        public string GetManufacturer()
        {
            return this.manufacturer;
        }

        public int GetYearOfManufacture()
        {
            return this.yearOfManufacture;
        }

        public string GetAirplaneType()
        {
            return this.airplaneType;
        }


        public void Print()
        {
            Console.WriteLine("Название самолёта: " + airplaneName);
            Console.WriteLine("Производитель: " + manufacturer);
            Console.WriteLine("Год выпуска: " + yearOfManufacture);
            Console.WriteLine("Тип самолёта: " + airplaneType);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}