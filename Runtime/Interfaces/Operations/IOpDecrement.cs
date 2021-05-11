namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			/*
			public interface IOpDecrement : INumeric
			{
				public IOpDecrement Decrement(in IOpDecrement other);
			}
			*/
			
			public interface IOpDecrement<T> : INumeric
			{
				public T Decrement(in T value);
			}
		}
	}
}