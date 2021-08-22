using System.Runtime.CompilerServices;

namespace Platform.Incrementers
{
    /// <summary>
    /// <para>Defines an incrementer that increments any object.</para>
    /// <para>Определяет инкрементер, который выполняет приращение любого объекта.</para>
    /// </summary>
    public interface IIncrementer
    {
        /// <summary>
        /// <para>Increments the object by a specific value.</para>
        /// <para>Выполняет приращение объекта на определённое значение.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Increment();
    }
}
