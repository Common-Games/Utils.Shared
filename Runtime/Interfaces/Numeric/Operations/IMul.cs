using System.Runtime.CompilerServices;

namespace CGTK.Utils.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IMul<T> : INumeric, IOperation
			{
				/// <summary> Multiply </summary>
				/// <returns></returns>
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public T Mul(in T value);
			}
			
			public interface IMul : IMul<IMul>
			{ }

			#region Compound
			
			public interface IMulCompound<T> : INumeric, IOperation
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public void MulCompound(in T value);
			}
			
			public interface IMulCompound : IMulCompound<IMulCompound>
			{ }
			
			#endregion
		}
	}
}