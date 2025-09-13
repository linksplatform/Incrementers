using System.Runtime.CompilerServices;

#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Incrementers
{
    /// <summary>
    /// <para>Represents the incrementer that can increment and return a specific decision value.</para>
    /// <para>Представляет инкрементер, который может увеличивать счетчик и возвращать определенное значение решения.</para>
    /// </summary>
    /// <typeparam name="TValue">The type of value used in increment operations.</typeparam>
    /// <typeparam name="TDecision">The type of decision value returned by increment operations.</typeparam>
    /// <seealso cref="Incrementer"/>
    public class Incrementer<TValue, TDecision> : Incrementer
    {
        /// <summary>
        /// <para>The decision value that is returned by increment operations.</para>
        /// <para>Значение решения, которое возвращается операциями инкремента.</para>
        /// </summary>
        private readonly TDecision _trueValue;

        /// <summary>
        /// <para>Initializes a new <see cref="Incrementer{TValue, TDecision}"/> instance with the specified initial and decision values.</para>
        /// <para>Инициализирует новый экземпляр <see cref="Incrementer{TValue, TDecision}"/> с указанными начальным значением и значением решения.</para>
        /// </summary>
        /// <param name="initialValue">
        /// <para>The initial value for the counter.</para>
        /// <para>Начальное значение для счетчика.</para>
        /// </param>
        /// <param name="trueValue">
        /// <para>The decision value to return from increment operations.</para>
        /// <para>Значение решения, возвращаемое из операций инкремента.</para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Incrementer(ulong initialValue, TDecision trueValue) : base(initialValue) => _trueValue = trueValue;

        /// <summary>
        /// <para>Initializes a new <see cref="Incrementer{TValue, TDecision}"/> instance with the specified decision value and zero initial value.</para>
        /// <para>Инициализирует новый экземпляр <see cref="Incrementer{TValue, TDecision}"/> с указанным значением решения и нулевым начальным значением.</para>
        /// </summary>
        /// <param name="trueValue">
        /// <para>The decision value to return from increment operations.</para>
        /// <para>Значение решения, возвращаемое из операций инкремента.</para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Incrementer(TDecision trueValue) => _trueValue = trueValue;

        /// <summary>
        /// <para>Initializes a new <see cref="Incrementer{TValue, TDecision}"/> instance with default values.</para>
        /// <para>Инициализирует новый экземпляр <see cref="Incrementer{TValue, TDecision}"/> со значениями по умолчанию.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Incrementer() { }

        /// <summary>
        /// <para>Increments the counter and returns the decision value.</para>
        /// <para>Увеличивает счетчик и возвращает значение решения.</para>
        /// </summary>
        /// <returns>
        /// <para>The decision value.</para>
        /// <para>Значение решения.</para>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision IncrementAndReturnTrue()
        {
            _result++;
            return _trueValue;
        }

        /// <summary>
        /// <para>Increments the counter and returns the decision value using the specified value.</para>
        /// <para>Увеличивает счетчик и возвращает значение решения, используя указанное значение.</para>
        /// </summary>
        /// <param name="value">
        /// <para>The value used in the increment operation.</para>
        /// <para>Значение, используемое в операции инкремента.</para>
        /// </param>
        /// <returns>
        /// <para>The decision value.</para>
        /// <para>Значение решения.</para>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision IncrementAndReturnTrue(TValue value)
        {
            _result++;
            return _trueValue;
        }
    }
}
