namespace Platform::Incrementers
{
    template<typename...>
    class Incrementer;
    template<>
    class Incrementer<>
    {
    protected:
        std::uint64_t _result = 0;

    public:
        [[nodiscard]] std::uint64_t Result() const
        {
            return _result;
        }

        explicit Incrementer(std::uint64_t initialValue) : _result(initialValue)
        {
        }

        Incrementer() = default;

        void Increment()
        {
            _result++;
        }
    };
}
