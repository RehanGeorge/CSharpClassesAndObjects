using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ClassesAndObjects
{
    internal class Car
    {
        // Member Variables
        private string _name;
        private int _hp;
        private string _color;
        private int _maxSpeed;

        // Properties
        public string Name { 
            get { return _name; } // Get Accessor
            set
            {
                if (value == "")
                {
                    _name = "DefaultName";
                }
                else
                {
                    _name = value;
                }
            } // Set Accessor
        }

        public int MaxSpeed { set { _maxSpeed = value; } }

        // Default Constructor
        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "red";
        }

        // This is a partial specification constructor
        public Car(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine($"{name} was created");
            _hp = hp;
            _color = "red";
        }

        // Full specification constructor
        public Car(string name, int hp, string color)
        {
            _name = name;
            Console.WriteLine($"{name} was created");
            _hp = hp;
            _color = color;
        }

        // Member Setters

        //public void SetName(string name)
        //{
        //    if (name == "")
        //    {
        //        _name = "DefaultName";
        //    }
        //    else
        //    {
        //        _name = name;
        //    }

        //}

        //// Member Getters
        //public string GetName()
        //{
        //    return _name;
        //}

        public string GetHp() 
        {
            return ($"{_hp.ToString()} horsepower");
        }

        // Member Methods
        public void Drive()
        {
            Console.WriteLine($"{_name} is driving");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} is stopped");
        }

        public void Details()
        {
            Console.WriteLine($"Name: {_name}, HP: {_hp}, Color: {_color}");
        }
    }
}
