// <auto-generated>
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
	[global::Uno.NotImplemented]
#endif
	public partial interface IContactPanelActivatedEventArgs
	{
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		global::Windows.ApplicationModel.Contacts.Contact Contact
		{
			get;
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		global::Windows.ApplicationModel.Contacts.ContactPanel ContactPanel
		{
			get;
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.IContactPanelActivatedEventArgs.ContactPanel.get
		// Forced skipping of method Windows.ApplicationModel.Activation.IContactPanelActivatedEventArgs.Contact.get
	}
}
