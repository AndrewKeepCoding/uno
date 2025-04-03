using System;
using Uno;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation;

[NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
public sealed partial class SearchActivatedEventArgs : IActivatedEventArgs
{
	public ActivationKind Kind => ActivationKind.Search;

	[NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	public ApplicationExecutionState PreviousExecutionState { get; }

	[NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	public SplashScreen SplashScreen { get; }

	[NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	public int CurrentlyShownApplicationViewId { get; }

	[NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	public string Language { get; }

	[NotImplemented("__ANDROID__", "__IOS__", "__TVOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	public string QueryText { get; }
}
