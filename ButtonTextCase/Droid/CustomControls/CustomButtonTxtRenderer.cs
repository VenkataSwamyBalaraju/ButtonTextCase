using System;
using ButtonTextCase;
using ButtonTextCase.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomButtonTxt), typeof(CustomButtonTxtRenderer))]
namespace ButtonTextCase.Droid
{
	
      public class CustomButtonTxtRenderer : ButtonRenderer
		{
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
			{
				base.OnElementChanged(e);
				var button = this.Control;
				button.SetAllCaps(false);
			}

			protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
			{
				base.OnElementPropertyChanged(sender, e);
			}
	}
}
