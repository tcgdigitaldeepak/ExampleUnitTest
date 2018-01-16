using System;

namespace Prime.Services
{
    public class PrimeService
    {
public bool IsPrime(int candidate)
{
    if (candidate <2 )
    {
        return false;
    }
    throw new NotImplementedException("Please create a test first");
}

[DataTestMethod]
[DataRow(-1)]
[DataRow(0)]
[DataRow(1)]
public void ReturnFalseGivenValuesLessThan2(int value)
{
    var result = _primeService.IsPrime(value);

    Assert.IsFalse(result, $"{value} should not be prime");
}
    }
}