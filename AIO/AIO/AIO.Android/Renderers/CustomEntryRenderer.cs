using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using AIO.Controls;
using AIO.Droid.Renderers;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]


namespace AIO.Droid.Renderers
{

    [System.Obsolete]
    public class CustomEntryRenderer : EntryRenderer
    {

        public CustomEntryRenderer()
        {

        }
        // Override the OnElementChanged method so we can tweak this renderer post-initial setup
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                this.Control.Background = this.Resources.GetDrawable(Resource.Drawable.noBorderEditText);
            }
        }
    }
}