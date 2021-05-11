namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IOpMultiply<T> : INumeric
			{
				public T Multiply(in T value);
			}
		}
	}
}