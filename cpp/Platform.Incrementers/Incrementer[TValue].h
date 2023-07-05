namespace Platform::Incrementers
{
    template<typename...>
    class Incrementer;
    template<typename TValue>
    class Incrementer<TValue> : public Incrementer<TValue, bool>
    {
    private:
        using base = Incrementer<TValue, bool>;

    public:
        Incrementer(std::uint64_t initialValue) : base(initialValue, true)
        {
        }

        Incrementer() : base(true)
        {
        }
    };
}
