using System;

namespace testComplexGUIUnsecured
{
    /// <summary>
    /// Класс "Комплексное число"
    /// </summary>
    class clsComplex
    {
        /// <summary>
        /// Точность производимых вычислений
        /// </summary>
        public float eps = 0.01f;

        /// <summary>
        /// Вещественная часть комплексного числа
        /// </summary>
        public double Re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double Im;

        /// <summary>
        /// Конструктор экземпляра класса "Комплексное число"
        /// (по вещественным входным значениям)
        /// </summary>
        /// <param name="Re">Действительная часть</param>
        /// <param name="Im">Мнимая часть</param>
        public clsComplex(double Re, double Im)
        {
            this.Re = Re;
            this.Im = Im;
        }

        public clsComplex() { }

        /// <summary>
        /// Оператор сложения комплексных чисел
        /// </summary>
        /// <param name="cf1">Первое комплексное число</param>
        /// <param name="cf2">Второе комплексное число</param>
        public static clsComplex operator +(clsComplex cf1, clsComplex cf2) =>
            new clsComplex(cf1.Re + cf2.Re, cf1.Im + cf2.Im);

        public static clsComplex operator -(clsComplex cf1, clsComplex cf2) =>
            new clsComplex(cf1.Re - cf2.Re, cf1.Im - cf2.Im);

        public static clsComplex operator *(clsComplex cf1, clsComplex cf2) =>
            new clsComplex(cf1.Re * cf2.Re + cf1.Im * cf2.Im,
                cf1.Im * cf2.Re - cf1.Re * cf2.Im);

        public static clsComplex operator /(clsComplex cf1, clsComplex cf2) =>
            new clsComplex((cf1.Re * cf2.Re + cf1.Im * cf2.Im) /
                (cf2.Re * cf2.Re + cf2.Im * cf2.Im),
                (cf1.Im * cf2.Re - cf1.Re * cf2.Im) /
                (cf2.Re * cf2.Re + cf2.Im * cf2.Im));

        /// <summary>
        /// Форматированный вывод комплексного числа
        /// </summary>
        public override string ToString() => 
            (Math.Abs(Re) < eps && Math.Abs(Im) < eps ? "0" : (Math.Abs(Re) >= eps ? $"{Re.ToString("0.00").Replace(',', '.')}" : "")) +
                (Math.Abs(Im) >= eps ? $" {(Im < 0 ? "-" : "+")} i{Math.Abs(Im).ToString("0.00").Replace(',', '.')}" : "");

        /// <summary>
        /// Модуль комплексного числа
        /// </summary>
        public double Module() => Math.Sqrt(Re * Re + Im * Im);

        /// <summary>
        /// Комплексно сопряжённое комплексное число
        /// </summary>
        public clsComplex Conjugate() => new clsComplex(Re, -Im);

        /// <summary>
        /// Аргумент комплексного числа
        /// </summary>
        public double Argument() => Math.Atan(Im / Re);
    }
}
