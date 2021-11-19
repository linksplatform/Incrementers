using Xunit;

namespace Platform.Incrementers.Tests
{
    public class IncrementerTests
    {
        [Fact]
        public void ParameterlessConstructedSetterTest()
        {
            Incrementer<int> incrementer = new Incrementer<int>();
            Assert.Equal(default, incrementer.Result);
        }

        [Fact]
        public void ConstructedWithDefaultValueSetterTest()
        {
            Incrementer<int> incrementer = new Incrementer<int>(9UL);
            Assert.Equal(9UL, incrementer.Result);
        }

        [Fact]
        public void MethodsWithBooleanReturnTypeTest()
        {
            Incrementer<int> incrementer = new Incrementer<int>();
            incrementer.Increment();
            Assert.Equal(1UL, incrementer.Result);
            Assert.True(incrementer.IncrementAndReturnTrue());
            Assert.Equal(2UL, incrementer.Result);
        }

        [Fact]
        public void MethodsWithIntegerReturnTypeTest()
        {
            Incrementer<int, int> incrementer = new Incrementer<int, int>(1);
            incrementer.Increment();
            Assert.Equal(1UL, incrementer.Result);
            Assert.Equal(1, incrementer.IncrementAndReturnTrue());
            Assert.Equal(2UL, incrementer.Result);
        }
    }
}
