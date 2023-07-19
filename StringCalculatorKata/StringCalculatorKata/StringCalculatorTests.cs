using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
{
        //Given
        var calculator = new StringCalculator();

        //When
        var result = calculator.Add("");
        
        Assert.Equal(0, result);
}
    [Fact]
    public void StringWithOneReturnOne()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1");

        Assert.Equal(1, result);
    }
    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);



        Assert.Equal(expected, result);
    }

    //[Theory]
    //[InlineData("1,2",3)]
}
