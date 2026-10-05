using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	internal interface IUIElementsUtility
	{
		// Token: 0x060004F1 RID: 1265
		[Token(Token = "0x60004F1")]
		bool TakeCapture();

		// Token: 0x060004F2 RID: 1266
		[Token(Token = "0x60004F2")]
		bool ReleaseCapture();

		// Token: 0x060004F3 RID: 1267
		[Token(Token = "0x60004F3")]
		bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled);

		// Token: 0x060004F4 RID: 1268
		[Token(Token = "0x60004F4")]
		bool CleanupRoots();

		// Token: 0x060004F5 RID: 1269
		[Token(Token = "0x60004F5")]
		bool EndContainerGUIFromException(Exception exception);

		// Token: 0x060004F6 RID: 1270
		[Token(Token = "0x60004F6")]
		bool MakeCurrentIMGUIContainerDirty();
	}
}
