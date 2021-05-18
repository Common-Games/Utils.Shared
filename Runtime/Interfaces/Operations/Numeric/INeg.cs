using System.Runtime.CompilerServices;

namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface INeg<T> : INumeric, IOperation, IOperation<T>
			{
				//[MethodImpl(MethodImplOptions.AggressiveInlining)]
				//public T Negate(in T value);
				
				public T Negated { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
			}
			
			public interface INeg : INeg<INeg>
			{ }
		}
	}
}