using NUnit.Framework;

namespace CursoManejoErrores.Tests.NUnit;

public class CalculatorShould
{
    [Test]
    public void Test1()
    {
        var sut = new Calculator(); // System Under Test

        //Assert.That(() => sut.Calculate(1, 2, "+"),
        //            Throws.TypeOf<CalculationOperationNotSupportedException>());

        //Assert.That(() => sut.Calculate(1, 1, "+"),
        //        Throws.TypeOf<CalculationOperationNotSupportedException>()
        //              .With
        //              .Property("Operation").EqualTo("+"));

        //var ex = Assert.Throws<CalculationOperationNotSupportedException>(
        //                                            () => sut.Calculate(1, 1, "+"));

        //Assert.That(ex!.Operation, Is.EqualTo("+"));

        Assert.That(() => sut.Calculate(1, 1, "+"),
                    Throws.InstanceOf<CalculationException>());
    }
}