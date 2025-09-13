#pragma once

namespace Platform::Incrementers
{
    class IIncrementer
    {
    public:
        virtual ~IIncrementer() = default;
        virtual void Increment() = 0;
    };
}
