using System.Runtime.CompilerServices;

namespace CGTK.Utils.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IDecr<T> : INumeric
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public T Decrement(in T value);
			}
			
			public interface IDecr : IDecr<IDecr>
			{ }
			
			#region Compound
			
			public interface IDecrCompound<T> : INumeric, IOperation
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public void DecrementCompound(in T value);
			}
			
			public interface IDecrCompound : IDecrCompound<IDecrCompound>
			{ }
			
			#endregion
		}
	}
}