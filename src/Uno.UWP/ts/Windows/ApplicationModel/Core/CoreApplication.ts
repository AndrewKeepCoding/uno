﻿namespace Windows.ApplicationModel.Core {
	/**
	 * Support file for the Windows.ApplicationModel.Core 
	 * */
	export class CoreApplication {

		private static _initializedExportsResolve: (value?: unknown) => void;
		private static _initializedExports: Promise<void> = new Promise<void>((resolve) => { CoreApplication._initializedExportsResolve = resolve; });

		public static initialize() {

			// create a non-finishing promise

			Uno.UI.Dispatching.NativeDispatcher.init(
				new Promise<boolean>(resolve => (<any>window).setImmediate(async () => {
					await CoreApplication.initializeExports();
					CoreApplication._initializedExportsResolve(true);
					resolve(true);
				}))
			);
		}

		/**
		 * Provides a promised that resolves when CoreApplication is initialized
		 */
		public static async waitForInitialized(): Promise<void> {
			await CoreApplication._initializedExports;
		}

		public static async initializeExports() {

			if ((<any>Module).getAssemblyExports !== undefined) {
				const unoExports = await (<any>Module).getAssemblyExports("Uno");
				const unoUIDispatchingExports = await (<any>Module).getAssemblyExports("Uno.UI.Dispatching");

				const runtimeWasmExports = await (<any>Module).getAssemblyExports("Uno.Foundation.Runtime.WebAssembly");

				if (Object.entries(unoExports).length > 0) {

					// DotnetExports may already have been initialized
					(<any>globalThis).DotnetExports = (<any>globalThis).DotnetExports || {};

					(<any>globalThis).DotnetExports.Uno = unoExports;
					(<any>globalThis).DotnetExports.UnoUIDispatching = unoUIDispatchingExports;
					(<any>globalThis).DotnetExports.UnoFoundationRuntimeWebAssembly = runtimeWasmExports;
				}
			}
		}
	}
}
