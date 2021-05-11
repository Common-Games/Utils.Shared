namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			/*
			public interface IOpDivide : INumeric
			{
				public IOpDivide Divide(in IOpDivide other);
			}
			*/
			
			public interface IOpDivide<T> : INumeric
			{
				public T Divide(in T value);
			}
		}
	}
}