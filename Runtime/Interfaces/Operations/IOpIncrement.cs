namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			/*
			public interface IOpIncrement : INumeric
			{
				public IOpIncrement Increment(in IOpIncrement other);
			}
			*/
			
			public interface IOpIncrement<T> : INumeric
			{
				public T Increment(in T value);
			}
		}
	}
}