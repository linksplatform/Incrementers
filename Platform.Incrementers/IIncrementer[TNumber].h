namespace Platform::Incrementers
{
    template <typename ...> class IIncrementer;
    template <typename TNumber> class IIncrementer<TNumber>
    {
    public:
        virtual TNumber Increment(TNumber number) = 0;
    };
}
