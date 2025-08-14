namespace Platform::Incrementers
{
    template<typename _Type, typename TNumber = void>
    concept IIncrementer = requires(_Type object, TNumber parameter)
    {
        {object.Increment(parameter)} -> std::same_as<TNumber>;
    };
}
