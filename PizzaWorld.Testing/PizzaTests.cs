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
        private void Test_HasSizeAndCrust()
        {
            var sut = new MeatPizza(new Size(), new Crust());

            var actual = sut;

            Assert.IsType<Size>(actual.Size);
            Assert.IsType<Crust>(actual.Crust);
        }
        [Fact]
        private void Test_ComputesPrice()
        {
            var sut = new MeatPizza(new Size("small"), new Crust("regular"));

            var actual = sut;

            Assert.NotNull(actual.Price);
        }
    }
}