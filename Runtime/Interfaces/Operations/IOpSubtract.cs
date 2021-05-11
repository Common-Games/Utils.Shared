using System.Runtime.CompilerServices;

namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IOpSubtract : INumeric
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public IOpSubtract Subtract(in IOpSubtract other);
			}
			
			public interface IOpSubtract<T> : INumeric
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public T Subtract(in T value);
			}
			
			public interface IOpSubtract<out TOut, TIn> : INumeric
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public TOut Subtract(in TIn value);
			}
		}
	}
}