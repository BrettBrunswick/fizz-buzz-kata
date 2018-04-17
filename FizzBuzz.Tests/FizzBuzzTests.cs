using FizzBuzz.Library;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {

        private FizzBuzzService service;

        public FizzBuzzTests()
        {
            service = new FizzBuzzService();
        }

        [Fact]
        public void ShouldReturnFizz() {
            Assert.Equal("Fizz", service.print(3));
            Assert.Equal("Fizz", service.print(6));
        }

        [Fact]
        public void ShouldReturnBuzz() {
            Assert.Equal("Buzz", service.print(5));
            Assert.Equal("Buzz", service.print(10));
        }

        [Fact]
        public void ShouldReturnFizzBuzz() {
            Assert.Equal("FizzBuzz", service.print(15));
            Assert.Equal("FizzBuzz", service.print(30));
        }

        [Fact]
        public void ShouldReturnNumber() {
            Assert.Equal("28", service.print(28));
            Assert.Equal("7", service.print(7));
        }



    }
}