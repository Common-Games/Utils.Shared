using System.Runtime.CompilerServices;

namespace CGTK.Utils.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface INeg<out T> : INumeric, IOperation
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