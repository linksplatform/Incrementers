using Xunit;

namespace Platform.Incrementers.Tests
{
    /// <summary>
    /// <para>
    /// Represents the incrementer tests.
    /// </para>
    /// <para></para>
    /// </summary>
    public class IncrementerTests
    {
        /// <summary>
        /// <para>
        /// Tests that parameterless constructed setter test.
        /// </para>
        /// <para></para>
        /// </summary>
        [Fact]
        public void ParameterlessConstructedSetterTest()
        {
            Incrementer<int> incrementer = new Incrementer<int>();
            Assert.Equal(default, incrementer.Result);
        }

        /// <summary>
        /// <para>
        /// Tests that constructed with default value setter test.
        /// </para>
        /// <para></para>
        /// </summary>
        [Fact]
        public void ConstructedWithDefaultValueSetterTest()
        {
            Incrementer<int> incrementer = new Incrementer<int>(9UL);
            Assert.Equal(9UL, incrementer.Result);
        }

        /// <summary>
        /// <para>
        /// Tests that methods with boolean return type test.
        /// </para>
        /// <para></para>
        /// </summary>
        [Fact]
        public void MethodsWithBooleanReturnTypeTest()
        {
            Incrementer<int> incrementer = new Incrementer<int>();
            incrementer.Increment();
            Assert.Equal(1UL, incrementer.Result);
            Assert.True(incrementer.IncrementAndReturnTrue());
            Assert.Equal(2UL, incrementer.Result);
        }

        /// <summary>
        /// <para>
        /// Tests that methods with integer return type test.
        /// </para>
        /// <para></para>
        /// </summary>
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
