namespace CGTK.Utilities.Shared
{
    public interface IApplicationCallbacks
    {
        internal void OnApplicationFocus();
        internal void OnApplicationPause();
        internal void OnApplicationQuit();
    }
}
