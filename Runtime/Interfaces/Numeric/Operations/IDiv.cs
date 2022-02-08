using System.Runtime.CompilerServices;

namespace CGTK.Utils.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IDiv<T> : INumeric
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public T Divide(in T value);
			}
			
			public interface IDiv : IDiv<IDiv>
			{ }
			
			#region Compound
			
			public interface IDivCompound<T> : INumeric, IOperation
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public void DivideCompound(in T value);
			}
			
			public interface IDivCompound : IDivCompound<IDivCompound>
			{ }
			
			#endregion
		}
	}
}