using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Протестируйте все методы класса Calculator с использованием NUnit-фреймворка.
/// </summary>
namespace Task1.Test
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(10,20)==30);
        }
        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(99, 33) == 66);
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(12, 12) == 144);
        }
        [Test]
        public void Miltiplication_MustReturnCorrectSign()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(-12, 12) == -144);
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(36, 12) == 3);
        }
        [Test]
        public void Division_MustReturnCorrectSign()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(-120, 12) == -10);
        }

        [Test]
        public void Division_MustTrowExeption()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(()=>calculator.Division(15, 0));
        }
    }
}
