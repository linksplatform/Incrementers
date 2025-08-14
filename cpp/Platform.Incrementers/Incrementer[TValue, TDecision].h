namespace Platform::Incrementers
{
    template<typename...>
    class Incrementer;
    template<typename TValue, typename TDecision>
    class Incrementer<TValue, TDecision> : public Incrementer<>
    {
    private:
        using base = Incrementer<>;
        const TDecision _trueValue;

    public:
        Incrementer(std::uint64_t initialValue, TDecision trueValue) : base(initialValue), _trueValue(trueValue)
        {
        }

        Incrementer(TDecision trueValue) : _trueValue(trueValue)
        {
        }

        Incrementer() = default;

        TDecision IncrementAndReturnTrue()
        {
            _result++;
            return _trueValue;
        }

        TDecision IncrementAndReturnTrue(TValue value)
        {
            _result++;
            return _trueValue;
        }
    };
}
