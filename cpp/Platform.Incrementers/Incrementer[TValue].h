#pragma once
#include <cstdint>
#include "Incrementer[TValue, TDecision].h"

namespace Platform::Incrementers
{    
    template <typename TValue> 
    class Incrementer<TValue> : public Incrementer<TValue, bool>
    {
    public: 
        explicit Incrementer(std::uint64_t initialValue) 
            : Incrementer<TValue, bool>(initialValue, true) { }

        Incrementer() : Incrementer<TValue, bool>(true) { }
    };
}
