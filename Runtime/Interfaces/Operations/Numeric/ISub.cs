using System.Runtime.CompilerServices;

namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface ISub<T> : INumeric, IOperation, IOperation<T>
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public T Sub(in T value);
			}
			
			public interface ISub : ISub<ISub> 
			{ }

			#region Compound
			
			public interface ISubCompound<T> : INumeric, IOperation, IOperation<T>
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public void SubCompound(in T value);
			}
			
			public interface ISubCompound : ISubCompound<ISubCompound> 
			{ }
			
			#endregion
		}
	}
}