using Xunit.Sdk;

namespace CSharpSyntax
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Given

        }
        
        
    [Theory]
    [InlineData("Leon", "King", "Leon , King")]
    [InlineData("Ohma", "Tokita", "Ohma , Tokita")]
    [InlineData("Shen", "Wulong", "Shen, Wulong")]
        public void FormattingByName(string first, string last, string expected)
    {
            string fullName = Utils.FormatName(first, last);

            Assert.Equal(expected, fullName);
    
    }

}
}