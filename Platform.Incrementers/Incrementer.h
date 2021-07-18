namespace Platform::Incrementers
{
    class Incrementer : public IIncrementer
    {
        protected: std::uint64_t _result = 0;

        public: std::uint64_t Result()
        {
            return _result;
        }

        public: Incrementer(std::uint64_t initialValue) { _result = initialValue; }

        public: Incrementer() { }

        public: void Increment() { _result++; }
    };
}
