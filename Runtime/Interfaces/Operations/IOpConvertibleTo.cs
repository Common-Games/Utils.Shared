namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IOpConvertibleTo<out T> : INumeric
			{
				public T Convert();
			}
		}
	}
}