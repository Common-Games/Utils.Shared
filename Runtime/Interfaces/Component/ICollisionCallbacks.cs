namespace CGTK.Utilities.Shared
{
    public interface ICollisionCallbacks
    {
        internal void OnCollisionEnter();
        internal void OnCollisionStay();
        internal void OnCollisionExit();
    }
}
