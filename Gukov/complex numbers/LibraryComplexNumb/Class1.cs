using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryComplexNumb
{
    public class ComplexNum
    {
        double re, im;
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ComplexNum() { re = 0; im = 0; }
        /// <summary>
        /// конструктор с 1 параметром
        /// </summary>
        public ComplexNum(double r) { re = r; im = 0; }
        /// <summary>
        /// конструктор с 2 параметрами
        /// </summary>
        public ComplexNum(double r, double i) { re = r; im = i; }
        /// <summary>
        /// конструктор копирования
        /// </summary>
        public ComplexNum(ComplexNum c) { re = c.Re; im = c.Im; }


        public double Re { get => re; set => re = value; }
        public double Im { get => im; set => im = value; }

        /// <summary>
        /// модуль комплексного числа
        /// </summary>
        public double abs()
        {
            return Math.Sqrt(re * re + im * im);
        }

        /// <summary>
        /// аргумент комплексного числа
        /// </summary>
        public double argument()
        {
            return Math.Atan2(re, im) * 180 / Math.PI;
        }

        /// <summary>
        /// сложение комплексного числа и комплексного числа
        /// </summary>
        public static ComplexNum Sum(ComplexNum a, ComplexNum b)
        {
            ComplexNum res = new ComplexNum();
            res.re = a.re + b.re;
            res.im = a.im + b.im;
            return res;
        }

        /// <summary>
        /// сложение комплексного числа и числа
        /// </summary>
        public static ComplexNum Sum(ComplexNum a, double b)
        {
            ComplexNum res = new ComplexNum();
            res.re = a.re + b;
            res.im = a.im;
            return res;
        }

        /// <summary>
        /// умножение комплексного числа и комплексного числа
        /// </summary>
        public static ComplexNum Multiplication(ComplexNum a, ComplexNum b)
        {
            ComplexNum res = new ComplexNum();
            res.re = a.re * b.re - a.im * b.im;
            res.im = a.im * b.re + a.re * b.im;
            return res;
        }

        /// <summary>
        /// множение комплексного числа и числа
        /// </summary>
        public static ComplexNum Multiplication(ComplexNum a, double b)
        {
            ComplexNum res = new ComplexNum();
            res.re = a.re * b;
            res.im = a.im * b;
            return res;
        }

        /// <summary>
        /// разность комплексного числа и комплексного числа
        /// </summary>
        public static ComplexNum Subtract(ComplexNum a, ComplexNum b)
        {
            ComplexNum res = new ComplexNum();
            res.re = a.re - b.re;
            res.im = a.im - b.im;
            return res;
        }

        /// <summary>
        /// разность комплексного числа и числа
        /// </summary>
        public static ComplexNum Subtract(ComplexNum a, double b)
        {
            ComplexNum res = new ComplexNum();
            res.re = a.re - b;
            res.im = a.im;
            return res;
        }

        //операторы для работы с комплексными числами

        public static ComplexNum operator +(ComplexNum a, ComplexNum b)
        {
            return ComplexNum.Sum(a, b);
        }

        public static ComplexNum operator +(ComplexNum a, double b)
        {
            return ComplexNum.Sum(a, b);
        }

        public static ComplexNum operator -(ComplexNum a, ComplexNum b)
        {
            return ComplexNum.Subtract(a, b);
        }
        public static ComplexNum operator -(ComplexNum a, double b)
        {
            return ComplexNum.Subtract(a, b);
        }

        public static ComplexNum operator *(ComplexNum a, ComplexNum b)
        {
            return ComplexNum.Multiplication(a, b);
        }

        public static ComplexNum operator *(ComplexNum a, double b)
        {
            return ComplexNum.Multiplication(a, b);
        }

        /// <summary>
        /// вывод комплексного числа
        /// </summary>
        public override string ToString()
        {
            return String.Format("{0} + i{1}", this.re, this.im);
        }
    }
}
