namespace Platform::Incrementers
{
    template <typename ...> class Incrementer;
    template <typename TValue> class Incrementer<TValue> : public Incrementer<TValue, bool>
    {
        public: Incrementer(std::uint64_t initialValue) : Incrementer<TValue, bool>(initialValue, true) { }

        public: Incrementer() : Incrementer<TValue, bool>(true) { }
    };
}
