using System.Runtime.CompilerServices;

namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IMul<T> : INumeric, IOperation, IOperation<T>
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public T Multiply(in T value);
			}
			
			public interface IMul : IMul<IMul>
			{ }

			#region Compound
			
			public interface IMulCompound<T> : INumeric, IOperation
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public void MultiplyCompound(in T value);
			}
			
			public interface IMulCompound : IMulCompound<IMulCompound>
			{ }
			
			#endregion
		}
	}
}