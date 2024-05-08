using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    public abstract class Shape
    {
        public abstract double GetArea();// абстрактный метод для вычисления площади
        public virtual bool IsSpecial() => false; // виртуальный метод для проверки условия
    }
}
