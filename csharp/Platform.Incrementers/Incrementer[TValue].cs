using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Incrementers
{
    /// <summary>
    /// <para>Represents the incrementer that returns boolean decisions from increment operations.</para>
    /// <para>Представляет инкрементер, который возвращает логические решения из операций инкремента.</para>
    /// </summary>
    /// <typeparam name="TValue">The type of value used in increment operations.</typeparam>
    /// <seealso cref="Incrementer{TValue, TDecision}"/>
    public class Incrementer<TValue> : Incrementer<TValue, bool>
    {
        /// <summary>
        /// <para>Initializes a new <see cref="Incrementer{TValue}"/> instance with the specified initial value.</para>
        /// <para>Инициализирует новый экземпляр <see cref="Incrementer{TValue}"/> с указанным начальным значением.</para>
        /// </summary>
        /// <param name="initialValue">
        /// <para>The initial value for the counter.</para>
        /// <para>Начальное значение для счетчика.</para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Incrementer(ulong initialValue) : base(initialValue, true) { }

        /// <summary>
        /// <para>Initializes a new <see cref="Incrementer{TValue}"/> instance with zero initial value and true as decision value.</para>
        /// <para>Инициализирует новый экземпляр <see cref="Incrementer{TValue}"/> с нулевым начальным значением и true как значение решения.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Incrementer() : base(true) { }
    }
}
