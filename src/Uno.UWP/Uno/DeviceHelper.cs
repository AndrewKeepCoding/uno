﻿namespace Uno
{
	internal static class DeviceHelper
	{
		internal static bool IsSimulator { get; }
#if (__IOS__ || __TVOS__) && !__MACCATALYST__
			= ObjCRuntime.Runtime.Arch == ObjCRuntime.Arch.SIMULATOR;
#endif
	}
}
