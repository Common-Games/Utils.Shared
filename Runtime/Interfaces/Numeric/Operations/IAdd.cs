using System.Runtime.CompilerServices;

namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IAdd<TIn, out TOut> : INumeric, IOperation
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public TOut Add(in TIn value);
			}
			
			public interface IAdd<T> : IAdd<T, T>
			{ }
			
			public interface IAdd : IAdd<IAdd>
			{ }

			#region Compound
			
			public interface IAddCompound<T> : INumeric, IOperation
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				public void AddCompound(in T value);
			}
			
			public interface IAddCompound : IAddCompound<IAddCompound>
			{ }
			
			#endregion
			
		}
	}
}