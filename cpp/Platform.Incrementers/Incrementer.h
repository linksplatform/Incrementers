#pragma once
#include <cstdint>
#include "IIncrementer.h"

namespace Platform::Incrementers
{
    template <typename ...Args>
    class Incrementer;
    
    // Base specialization (no template parameters)
    template <>
    class Incrementer<> : public IIncrementer
    {
    protected: 
        std::uint64_t _result = 0;

    public: 
        std::uint64_t Result() const
        {
            return _result;
        }

        explicit Incrementer(std::uint64_t initialValue) : _result(initialValue) { }

        Incrementer() = default;

        void Increment() override { _result++; }
    };
}
