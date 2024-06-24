using System;

namespace testComplexGUI
{
    /// <summary>
    /// Класс "Комплексное число"
    /// </summary>
    public class clsComplex
    {
        /// <summary>
        /// Точность производимых вычислений
        /// (доступно только для чтения)
        /// </summary>
        private readonly float eps = 0.01f;

        /// <summary>
        /// Вещественная часть комплексного числа
        /// (локальное поле)
        /// </summary>
        private double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// (локальное поле)
        /// </summary>
        private double im;

        /// <summary>
        /// Конструктор экземпляра класса "Комплексное число"
        /// (по вещественным входным значениям)
        /// </summary>
        /// <param name="re">Действительная часть</param>
        /// <param name="im">Мнимая часть</param>
        public clsComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        /// <summary>
        /// Конструктор экземпляра класса "Комплексное число"
        /// (по строковым входным значениям)
        /// </summary>
        /// <param name="re">Действительная часть</param>
        /// <param name="im">Мнимая часть</param>
        public clsComplex(string re, string im)
        {
            double.TryParse(re, out this.re);
            double.TryParse(im, out this.im);
        }

        /// <summary>
        /// Пустой конструктор экземпляра класса
        /// "Комплексное число"
        /// </summary>
        public clsComplex() { }

        /// <summary>
        /// Оператор сложения комплексных чисел
        /// </summary>
        /// <param name="cf1">Первое комплексное число</param>
        /// <param name="cf2">Второе комплексное число</param>
        /// <returns></returns>
        public static clsComplex operator +(clsComplex cf1, clsComplex cf2) =>
            new clsComplex(cf1.re + cf2.re, cf1.im + cf2.im);

        public static clsComplex operator -(clsComplex cf1, clsComplex cf2) =>
            new clsComplex(cf1.re - cf2.re, cf1.im - cf2.im);

        public static clsComplex operator *(clsComplex cf1, clsComplex cf2) =>
            new clsComplex(cf1.re * cf2.re + cf1.im * cf2.im,
                cf1.im * cf2.re - cf1.re * cf2.im);

        public static clsComplex operator /(clsComplex cf1, clsComplex cf2) =>
            new clsComplex((cf1.re * cf2.re + cf1.im * cf2.im) /
                (cf2.re * cf2.re + cf2.im * cf2.im),
                (cf1.im * cf2.re - cf1.re * cf2.im) /
                (cf2.re * cf2.re + cf2.im * cf2.im));

        /// <summary>
        /// Форматированный вывод комплексного числа
        /// </summary>
        /// <returns>Строковое представление комплексного числа</returns>
        public override string ToString()
        {
            return (Math.Abs(re) < eps && Math.Abs(im) < eps ? "0" : (Math.Abs(re) >= eps ? $"{re.ToString("0.00").Replace(',', '.')}" : "")) +
                (Math.Abs(im) >= eps ? $" {(im < 0 ? "-" : "+")} i{Math.Abs(im).ToString("0.00").Replace(',', '.')}" : "");
        }

        /// <summary>
        /// Модуль комплексного числа
        /// </summary>
        public double Module
        {
            get
            {
                return Math.Sqrt(re * re + im * im);
            }
        }

        /// <summary>
        /// Комплексно сопряжённое комплексное число
        /// </summary>
        public clsComplex Conjugate
        {
            get
            {
                return new clsComplex(re, -im);
            }
        }

        /// <summary>
        /// Строковое представление мнимой части
        /// для внешнего взаимодействия
        /// </summary>
        public string Im
        {
            get
            {
                return im.ToString();
            }
            set
            {
                double.TryParse(value, out im);
            }
        }

        /// <summary>
        /// Строковое представление вещественной части
        /// для внешнего взаимодействия
        /// </summary>
        public string Re
        {
            get
            {
                return re.ToString();
            }
            set
            {
                double.TryParse(value, out re);
            }
        }

        /// <summary>
        /// Аргумент комплексного числа
        /// </summary>
        public double Argument
        {
            get
            {
                return Math.Atan(im / re);
            }
        }
    }
}
