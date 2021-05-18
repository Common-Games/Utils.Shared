namespace CGTK.Utilities.Shared
{
    public interface IRenderCallbacks
    {
        internal void OnPreRender();
        internal void OnWillRenderObject();
        internal void OnRenderObject();
        internal void OnRenderImage();
        internal void OnPostRender();
        
        internal void OnPreCull();
    }
}
