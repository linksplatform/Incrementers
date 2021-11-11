using System.Runtime.CompilerServices;

#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Incrementers
{
    /// <summary>
    /// <para>
    /// Represents the incrementer.
    /// </para>
    /// <para></para>
    /// </summary>
    /// <seealso cref="Incrementer"/>
    public class Incrementer<TValue, TDecision> : Incrementer
    {
        private readonly TDecision _trueValue;

        /// <summary>
        /// <para>
        /// Initializes a new <see cref="Incrementer"/> instance.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="initialValue">
        /// <para>A initial value.</para>
        /// <para></para>
        /// </param>
        /// <param name="trueValue">
        /// <para>A true value.</para>
        /// <para></para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Incrementer(ulong initialValue, TDecision trueValue) : base(initialValue) => _trueValue = trueValue;

        /// <summary>
        /// <para>
        /// Initializes a new <see cref="Incrementer"/> instance.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="trueValue">
        /// <para>A true value.</para>
        /// <para></para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Incrementer(TDecision trueValue) => _trueValue = trueValue;

        /// <summary>
        /// <para>
        /// Initializes a new <see cref="Incrementer"/> instance.
        /// </para>
        /// <para></para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Incrementer() { }

        /// <summary>
        /// <para>
        /// Increments the and return true.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <returns>
        /// <para>The true value.</para>
        /// <para></para>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision IncrementAndReturnTrue()
        {
            _result++;
            return _trueValue;
        }

        /// <summary>
        /// <para>
        /// Increments the and return true using the specified value.
        /// </para>
        /// <para></para>
        /// </summary>
        /// <param name="value">
        /// <para>The value.</para>
        /// <para></para>
        /// </param>
        /// <returns>
        /// <para>The true value.</para>
        /// <para></para>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TDecision IncrementAndReturnTrue(TValue value)
        {
            _result++;
            return _trueValue;
        }
    }
}
