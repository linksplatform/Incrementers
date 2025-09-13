#pragma once
#include <cstdint>
#include "Incrementer.h"

namespace Platform::Incrementers
{
    template <typename TValue, typename TDecision> 
    class Incrementer<TValue, TDecision> : public Incrementer<>
    {
    private: 
        TDecision _trueValue = TDecision{};

    public: 
        Incrementer(std::uint64_t initialValue, TDecision trueValue) 
            : Incrementer<>(initialValue), _trueValue(trueValue) { }

        explicit Incrementer(TDecision trueValue) : _trueValue(trueValue) { }

        Incrementer() = default;

        TDecision IncrementAndReturnTrue()
        {
            _result++;
            return _trueValue;
        }

        TDecision IncrementAndReturnTrue([[maybe_unused]] TValue value)
        {
            _result++;
            return _trueValue;
        }
    };
}
