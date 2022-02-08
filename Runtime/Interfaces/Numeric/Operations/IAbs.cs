using System.Runtime.CompilerServices;

namespace CGTK.Utils.Shared
{
	namespace Interfaces
	{
		namespace Operations
		{
			public interface IAbs<out T> : INumeric
			{
				//[MethodImpl(MethodImplOptions.AggressiveInlining)]
				//public T Absolute();
				
				public T Absolute { [MethodImpl(MethodImplOptions.AggressiveInlining)] get; }
			}
			
			public interface IAbs : IAbs<IAbs>
			{ }
		}
	}
}