namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IOpAbsolute : INumeric
			{
				public IOpAbsolute Absolute();
				
				public IOpAbsolute AbsoluteResult { get; }
			}
			
			public interface IOpAbsolute<out T> : INumeric
			{
				public T Absolute();
				
				public T AbsoluteResult { get; }
			}
		}
	}
}