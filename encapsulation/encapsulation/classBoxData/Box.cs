using System;
using System.Collections.Generic;
using System.Text;

namespace classBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        private double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Length cannot be zero or negative.");
                    }
                    this.length = value;
                }
                catch (Exception msg)
                {
                    Console.WriteLine(msg.Message);
                    Environment.Exit(0);
                }
            }
        }

        private double Width
        {
            get => this.width;
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Width cannot be zero or negative.");
                    }
                    this.width = value;
                }
                catch (Exception msg)
                {
                    Console.WriteLine(msg.Message);
                    Environment.Exit(0);
                }
                                
            }
        }
        private double Height
        {
            get => this.height;
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Height cannot be zero or negative.");
                    }
                    this.height = value;
                }
                catch (Exception msg)
                {
                    Console.WriteLine(msg.Message);
                    Environment.Exit(0);
                }
            }
        }
        public double SurfaceArea() => 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;

        public double LateralSurfaceArea() => 2 * this.Length * this.Height + 2 * this.Width * this.Height;

        public double Volume() => this.Length * this.Width * this.Height;
    }
}
