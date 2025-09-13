#include <cstdint>
#include <iostream>

// Include our headers
#include "../cpp/Platform.Incrementers/IIncrementer.h"
#include "../cpp/Platform.Incrementers/Incrementer.h"
#include "../cpp/Platform.Incrementers/Incrementer[TValue, TDecision].h"
#include "../cpp/Platform.Incrementers/Incrementer[TValue].h"

int main()
{
    // Test basic Incrementer
    Platform::Incrementers::Incrementer<> incrementer;
    std::cout << "Initial result: " << incrementer.Result() << std::endl;
    
    incrementer.Increment();
    std::cout << "After increment: " << incrementer.Result() << std::endl;
    
    // Test Incrementer with initial value
    Platform::Incrementers::Incrementer<> incrementer2(5UL);
    std::cout << "Initialized with 5: " << incrementer2.Result() << std::endl;
    
    // Test template versions
    Platform::Incrementers::Incrementer<int> templateIncrementer;
    templateIncrementer.Increment();
    std::cout << "Template incrementer result: " << templateIncrementer.Result() << std::endl;
    
    auto result = templateIncrementer.IncrementAndReturnTrue();
    std::cout << "IncrementAndReturnTrue result: " << result << std::endl;
    std::cout << "Template incrementer final result: " << templateIncrementer.Result() << std::endl;
    
    // Test custom return type
    Platform::Incrementers::Incrementer<int, int> customIncrementer(42);
    customIncrementer.Increment();
    auto customResult = customIncrementer.IncrementAndReturnTrue(100);
    std::cout << "Custom incrementer with return type 42: " << customResult << std::endl;
    
    return 0;
}