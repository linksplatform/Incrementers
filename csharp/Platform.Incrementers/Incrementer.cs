using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Incrementers
{
    /// <summary>
    /// <para>Represents the incrementer that maintains an internal counter.</para>
    /// <para>Представляет инкрементер, который поддерживает внутренний счетчик.</para>
    /// </summary>
    /// <remarks>
    /// Must be class, not struct (in order to persist access to Result field value).
    /// </remarks>
    public class Incrementer : IIncrementer
    {
        /// <summary>
        /// <para>The internal result value that stores the current counter.</para>
        /// <para>Внутреннее значение результата, которое хранит текущий счетчик.</para>
        /// </summary>
        protected ulong _result;

        /// <summary>
        /// <para>Gets the current result value.</para>
        /// <para>Получает текущее значение результата.</para>
        /// </summary>
        public ulong Result
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _result;
        }

        /// <summary>
        /// <para>Initializes a new <see cref="Incrementer"/> instance with the specified initial value.</para>
        /// <para>Инициализирует новый экземпляр <see cref="Incrementer"/> с указанным начальным значением.</para>
        /// </summary>
        /// <param name="initialValue">
        /// <para>The initial value for the counter.</para>
        /// <para>Начальное значение для счетчика.</para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Incrementer(ulong initialValue) => _result = initialValue;

        /// <summary>
        /// <para>Initializes a new <see cref="Incrementer"/> instance with zero initial value.</para>
        /// <para>Инициализирует новый экземпляр <see cref="Incrementer"/> с нулевым начальным значением.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Incrementer() { }

        /// <summary>
        /// <para>Increments the internal counter by one.</para>
        /// <para>Увеличивает внутренний счетчик на единицу.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Increment() => _result++;
    }
}
