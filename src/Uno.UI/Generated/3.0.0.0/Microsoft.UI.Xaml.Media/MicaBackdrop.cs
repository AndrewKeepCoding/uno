// <auto-generated>
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class MicaBackdrop : global::Microsoft.UI.Xaml.Media.SystemBackdrop
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Microsoft.UI.Composition.SystemBackdrops.MicaKind Kind
		{
			get
			{
				return (global::Microsoft.UI.Composition.SystemBackdrops.MicaKind)this.GetValue(KindProperty);
			}
			set
			{
				this.SetValue(KindProperty, value);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty KindProperty { get; } =
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Kind), typeof(global::Microsoft.UI.Composition.SystemBackdrops.MicaKind),
			typeof(global::Microsoft.UI.Xaml.Media.MicaBackdrop),
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::Microsoft.UI.Composition.SystemBackdrops.MicaKind)));
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MicaBackdrop() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Media.MicaBackdrop", "MicaBackdrop.MicaBackdrop()");
		}
#endif
		// Forced skipping of method Microsoft.UI.Xaml.Media.MicaBackdrop.MicaBackdrop()
		// Forced skipping of method Microsoft.UI.Xaml.Media.MicaBackdrop.Kind.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.MicaBackdrop.Kind.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.MicaBackdrop.KindProperty.get
	}
}