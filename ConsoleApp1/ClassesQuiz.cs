using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    #region 1. Create a class to represent a bank account with properties for the account balance and owner name.

    internal class BankAccount
    {
        public string? OwnerName { get; set; }
        public double Balance { get; set; }
    }

    #endregion

    #region 2. Develop a class to represent a customer with properties for the customer name, address, and email.

    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }

    #endregion

    #region 3. Create a class to represent a product with properties for the product name, price, and quantity in stock.

    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; } // kg in stock
    }
    #endregion

    #region 4. Develop a class to represent an order with properties for the customer, product, and order date.

    internal class Order
    {
        public Customer? Customer { get; set; }
        public Product? Product { get; set; }
        public DateOnly Date { get; set; }
    }

    #endregion

    #region 5. Create a class to represent an employee with properties for the employee name, job title, and salary.

    internal class Employee
    {
        public string? Name { get; set; }
        public string? JobTitle { get; set; }
        public double Salary { get; set; }
    }

    #endregion

    #region 6. Develop a class to represent a car with properties for the make, model, year, and speed.

    internal class Car
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }
    }

    #endregion

    #region 7. Create a class to represent a point in 2D space with properties for the x and y coordinates.

    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    #endregion

    #region 8. Develop a class to represent a rectangle with properties for the width, height, and area.

    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }
    }

    #endregion

    #region 9. Create a class to represent a triangle with properties for the sides and perimeter.

    internal class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public bool CanCreate() => A + B > C && A + C > B && B + C > A;

        public double Perimeter()
        {
            if (CanCreate()) return A + B + C;
            else return 0;
        }
    }

    #endregion

    #region 10. Develop a class to represent a clock with properties for the hour, minute, and second, and methods to set the time and get the current time.

    internal class Clock
    {
        public int Hour;
        public int Minute;
        public int Second;

        public void SetTime(int hour, int minute, int second)
        {
            Hour = hour; Minute = minute; Second = second;
        }
        public string GetTime()
        {
            return $"{Hour}:{Minute}:{Second}";
        }
    }

    #endregion

}
