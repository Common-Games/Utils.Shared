namespace CGTK.Utils.Shared
{
    public interface ICollisionCallbacks
    {
        internal void OnCollisionEnter();
        internal void OnCollisionStay();
        internal void OnCollisionExit();
    }
}
