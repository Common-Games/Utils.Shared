using System.Runtime.CompilerServices;

namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IIncr<T> : INumeric
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public T Increment(in T value);
			}
			
			public interface IIncr : IIncr<IIncr>
			{ }
			
			#region Compound
			
			public interface IIncrCompound<T> : INumeric, IOperation
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public void IncrementCompound(in T value);
			}
			
			public interface IIncrCompound : IIncrCompound<IIncrCompound>
			{ }
			
			#endregion
		}
	}
}