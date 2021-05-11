namespace CGTK.Utilities.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IOpNegate : INumeric
			{
				public IOpNegate Negate();
				
				public IOpNegate Negated { get; }
			}
			
			public interface IOpNegate<out T> : INumeric
			{
				public T Negate();
				
				public T NegateResult { get; }
			}
		}
	}
}