
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;
using Android.Graphics;
using GandalfApp6;
using MeetupDemo1.Droid;

[assembly: ExportRenderer(typeof(ProfilePic), typeof(ProfilePicRenderer))]
namespace MeetupDemo1.Droid
{
    public class ProfilePicRenderer : ImageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);

            TintPicture();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == "TintColor")
            {
                TintPicture();
            }
        }

        private void TintPicture()
        {
            if (Control == null || Element == null)
                return;

            var profilePic = Element as ProfilePic;

            if (profilePic.TintColor == Xamarin.Forms.Color.Transparent)
            {
                Control.ClearColorFilter();
            }
            else
            {
                var colorFilterToApply = new PorterDuffColorFilter(profilePic.TintColor.ToAndroid(), PorterDuff.Mode.SrcIn);
                Control.SetColorFilter(colorFilterToApply);
            }
        }
    }
}
