namespace CGTK.Utils.Shared
{
    public interface ITriggerCallbacks
    {
        internal void OnTriggerEnter();
        internal void OnTriggerStay();
        internal void OnTriggerExit();
    }
}