namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IOpRemainder<T> : INumeric
			{
				public T Remainder(in T value);
			}
			
			/*
			public interface IOpRemainder<TIn, out TOut> : INumeric
			{
				public TOut Remainder(in TIn value);
			}
			*/
		}
	}
}