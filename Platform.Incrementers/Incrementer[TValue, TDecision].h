namespace Platform::Incrementers
{
    template <typename ...> class Incrementer;
    template <typename TValue, typename TDecision> class Incrementer<TValue, TDecision> : public Incrementer<>
    {
        private: TDecision _trueValue = 0;

        public: Incrementer(std::uint64_t initialValue, TDecision trueValue) : Incrementer<>(initialValue) { return _trueValue = trueValue; }

        public: Incrementer(TDecision trueValue) { _trueValue = trueValue; }

        public: Incrementer() { }

        public: TDecision IncrementAndReturnTrue()
        {
            _result++;
            return _trueValue;
        }

        public: TDecision IncrementAndReturnTrue(TValue value)
        {
            _result++;
            return _trueValue;
        }
    };
}
