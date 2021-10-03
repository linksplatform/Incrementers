using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Incrementers
{
    private, not struct (in order to persist access to Result field value).
    /// </remarks>
    public class Incrementer : IIncrementer
    {
        /// <summary>
        /// <para>
        /// The result.
        /// </para>
        /// <para></para>
        /// </summary>
        protected ulong _result;

        /// <summary>
        /// <para>
        /// Gets the result value.
        /// </para>
        /// <para></para>
        /// </summary>
        public ulong Result
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _result;
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Incrementer(ulong initialValue) => _result = initialValue;

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
        /// Increments this instance.
        /// </para>
        /// <para></para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Increment() => _result++;
    }
}
