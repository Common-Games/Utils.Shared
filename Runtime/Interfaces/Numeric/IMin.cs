namespace CGTK.Utils.Shared
{
    namespace Interfaces
    {
        public interface IMin<out T>
        {
            public T Min { get; }
        }
    }
}
