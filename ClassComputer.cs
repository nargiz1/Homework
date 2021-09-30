using System;

namespace ClassComputer
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Computer
    {
        public string CPU;
        public int HDD;
        public string SystemSoftware;
        public int RAM;
        public Computer(string CPU, int HDD, string SystemSoftware, int RAM)
        {
            this.CPU = CPU;
            this.HDD = HDD;
            this.SystemSoftware = SystemSoftware;
            this.RAM = RAM;
        }
    }

    class Laptop : Computer
    {
        public int Battery;
        public int MaxOpeningAngle;

        public Laptop(string CPU, int HDD, string SystemSoftware, int RAM, int Battery, int MaxOpeningAngle) : base(CPU,HDD,SystemSoftware, RAM)
        {
            this.Battery = Battery;
            this.MaxOpeningAngle = MaxOpeningAngle;
        }


    }

    class Brand : Laptop
    {
        public string BrandName;
        public string Model;
        public string Innovation;

        public Brand(string CPU, int HDD, string SystemSoftware, int RAM, int Battery, int MaxOpeningAngle, string BrandName, string Model, string Innovation):base(CPU, HDD, SystemSoftware, RAM, Battery, MaxOpeningAngle)
        {
            this.BrandName = BrandName;
            this.Model = Model;
            this.Innovation = Innovation;

            Console.WriteLine($"Brand: {BrandName} Model: {Model} CPU: {CPU} HDD: {HDD} System Software:{SystemSoftware} RAM: {RAM} Battery: {Battery} Max Opening Angle: {MaxOpeningAngle} Innovation: {Innovation}");
        }
    }
}
