﻿using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword

using UIKit;
using ITextInput = UIKit.IUITextInput;

using Microsoft.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls;

//in iOS, we need to use two different controls to be able to accept return (UITextField vs UITextView)
//we use this interface to abstract properties that we need to modify in TextBox
public interface ITextBoxView : ITextInput
{
	void UpdateFont();
	bool BecomeFirstResponder();
	bool ResignFirstResponder();

	bool IsFirstResponder { get; }
	void UpdateTextAlignment();
	UIColor TintColor { get; set; }

	Brush Foreground { get; set; }
	void SetTextNative(string text);
	void Select(int start, int length);

	UITextAutocapitalizationType AutocapitalizationType { get; set; }
	UITextAutocorrectionType AutocorrectionType { get; set; }
	UIKeyboardType KeyboardType { get; set; }
	UIKeyboardAppearance KeyboardAppearance { get; set; }
	UIReturnKeyType ReturnKeyType { get; set; }
	bool EnablesReturnKeyAutomatically { get; set; }
	bool SecureTextEntry { get; set; }
	UITextSpellCheckingType SpellCheckingType { get; set; }
}
