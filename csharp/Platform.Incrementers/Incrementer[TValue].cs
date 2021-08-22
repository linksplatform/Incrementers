using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Incrementers
{
    /// <summary>
    /// <para>
    /// Represents the incrementer.
    /// </para>
    /// <para></para>
    /// </summary>
    /// <seealso cref="Incrementer{TValue, bool}"/>
    public class Incrementer<TValue> : Incrementer<TValue, bool>
    {
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
        public Incrementer(ulong initialValue) : base(initialValue, true) { }

        /// <summary>
        /// <para>
        /// Initializes a new <see cref="Incrementer"/> instance.
        /// </para>
        /// <para></para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Incrementer() : base(true) { }
    }
}
