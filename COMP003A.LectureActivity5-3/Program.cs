/*
// Author: Isaac Martinez
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: OOP - Abstraction
*/
namespace COMP003A.LectureActivity5_3_
{
    /// <summary>
    /// Represents a generic shape with an abstract method.
    /// </summary>
    abstract class Shape
    {
        // Auto-implemented property
        public string Name { get; set; }

        /// <summary>
        /// Abstract method to calculate area
        /// </summary>
        public abstract double CalculateArea();

        /// <summary>
        /// Display the Shape's name
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Shape: {Name}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("");
        }
    }
    /// <summary>
    /// Represents a circle derived from Shape
    /// </summary>
    class Circle : Shape
    {
        //Auto-implemented property
        public double Radius { get; set; }

        /// <summary>
        /// Constructor for Circle
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        /// <summary>
        /// Calculate the area of the circle.
        /// </summary>
        public override double CalculateArea()
        {
            // returns the area of the circle
            return Math.PI * Radius * Radius;
        }
    }
    ///
}
