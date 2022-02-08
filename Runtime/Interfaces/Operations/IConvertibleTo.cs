namespace CGTK.Utils.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IConvertibleTo<out T> : INumeric
			{
				public T Convert();
			}
		}
	}
}