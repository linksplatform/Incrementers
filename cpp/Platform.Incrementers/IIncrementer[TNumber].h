#pragma once

namespace Platform::Incrementers
{
    template <typename ...> class IIncrementer;
    
    template <typename TNumber> 
    class IIncrementer<TNumber>
    {
    public:
        virtual ~IIncrementer() = default;
        virtual TNumber Increment(TNumber number) = 0;
    };
}
