using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class OrderTests
    {
        [Fact]
        private void Test_OrderExists()
        {
            // arrange
            var sut = new Order(); // inference

            //act
            var actual = sut;

            //assert
            Assert.IsType<Order>(actual);
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_ComputesPrice()
        {
        //Given
        var sut = new Order();
        //When
        var actual = sut;
        //Then
        actual.Pizzas.Add(new MeatPizza(new Size("small"),new Crust("regular")));
        actual.Pizzas.Add(new VeggiePizza(new Size("medium"),new Crust("stuffed")));
        actual.ComputePrice();
        Assert.NotNull(actual.TotalPrice);
        }
    }
}