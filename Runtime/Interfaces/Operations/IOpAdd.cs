using System.Runtime.CompilerServices;

namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IOpAdd : INumeric
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public IOpAdd Add(in IOpAdd other);
			}
			
			public interface IOpAdd<T> : INumeric
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public T Add(in T value);
			}
			
			public interface IOpAdd<out TOut, TIn> : INumeric
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public TOut Add(in TIn value);
			}
			
		}
	}
}