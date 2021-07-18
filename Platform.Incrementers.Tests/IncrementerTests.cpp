namespace Platform::Incrementers::Tests
{
    TEST_CLASS(IncrementerTests)
    {
        public: TEST_METHOD(ParameterlessConstructedSetterTest)
        {
            Incrementer<std::int32_t> incrementer = Incrementer<std::int32_t>();
            Assert::AreEqual(0, incrementer.Result);
        }

        public: TEST_METHOD(ConstructedWithDefaultValueSetterTest)
        {
            Incrementer<std::int32_t> incrementer = Incrementer<std::int32_t>(9UL);
            Assert::AreEqual(9UL, incrementer.Result);
        }

        public: TEST_METHOD(MethodsWithBooleanReturnTypeTest)
        {
            Incrementer<std::int32_t> incrementer = Incrementer<std::int32_t>();
            incrementer.Increment();
            Assert::AreEqual(1UL, incrementer.Result);
            Assert::IsTrue(incrementer.IncrementAndReturnTrue());
            Assert::AreEqual(2UL, incrementer.Result);
        }

        public: TEST_METHOD(MethodsWithIntegerReturnTypeTest)
        {
            Incrementer<std::int32_t, std::int32_t> incrementer = Incrementer<std::int32_t, std::int32_t>(1);
            incrementer.Increment();
            Assert::AreEqual(1UL, incrementer.Result);
            Assert::AreEqual(1, incrementer.IncrementAndReturnTrue());
            Assert::AreEqual(2UL, incrementer.Result);
        }
    };
}
