using System.Runtime.CompilerServices;

namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IMod<T> : INumeric
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public T Remainder(in T value);
			}
			
			public interface IMod : IMod<IMod>
			{ }
			
			#region Compound
			
			public interface IModCompound<T> : INumeric, IOperation
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public void RemainderCompound(in T value);
			}
			
			public interface IModCompound : IModCompound<IModCompound>
			{ }
			
			#endregion
		}
	}
}