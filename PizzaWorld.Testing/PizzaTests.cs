using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class PizzaTests
    {
        [Fact]
        private void Test_PizzaExists()
        {
            var sut = new MeatPizza();

            var actual = sut;

            Assert.IsType<MeatPizza>(actual);
            Assert.NotNull(actual);
        }
        [Fact]
         private void Test_HasSize()
         {
             var sut = new MeatPizza();

             var actual = sut;

             Assert.IsType<Size>(actual.Size);
         }
    }
}