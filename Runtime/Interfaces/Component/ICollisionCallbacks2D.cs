namespace CGTK.Utils.Shared
{
    public interface ICollisionCallbacks2D
    {
        internal void OnCollisionEnter2D();
        internal void OnCollisionStay2D();
        internal void OnCollisionExit2D();
    }
}
