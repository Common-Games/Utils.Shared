namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		public interface IGet<out T>
		{
			public T Value { get; }
		}
	}
}