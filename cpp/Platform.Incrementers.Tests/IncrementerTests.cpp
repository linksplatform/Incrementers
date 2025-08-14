#include <Platform.Incrementers.h>
#include <gtest/gtest.h>

namespace Platform::Incrementers::Tests
{
    TEST(IncrementersTests, ParameterlessConstructedSetterTest)
    {
        Incrementer<int> incrementer = Incrementer<int>();
        ASSERT_EQ({}, incrementer.Result());
    }

    TEST(IncrementersTests, ConstructedWithDefaultValueSetterTest)
    {
        Incrementer<int> incrementer = Incrementer<int>(9UL);
        ASSERT_EQ(9UL, incrementer.Result());
    }

    TEST(IncrementersTests, MethodsWithBooleanReturnTypeTest)
    {
        Incrementer<int> incrementer = Incrementer<int>();
        incrementer.Increment();
        ASSERT_EQ(1UL, incrementer.Result());
        ASSERT_TRUE(incrementer.IncrementAndReturnTrue());
        ASSERT_EQ(2UL, incrementer.Result());
    }

    TEST(IncrementersTests, MethodsWithIntegerReturnTypeTest)
    {
        Incrementer<int, int> incrementer = Incrementer<int, int>(1);
        incrementer.Increment();
        ASSERT_EQ(1UL, incrementer.Result());
        ASSERT_EQ(1, incrementer.IncrementAndReturnTrue());
        ASSERT_EQ(2UL, incrementer.Result());
    }
}
