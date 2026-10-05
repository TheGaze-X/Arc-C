using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	[NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
	public class Cursor
	{
		// Token: 0x06000691 RID: 1681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x594A960", Offset = "0x5949560", VA = "0x18594A960")]
		public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
		{
		}

		// Token: 0x1700018E RID: 398
		// (set) Token: 0x06000692 RID: 1682
		[Token(Token = "0x1700018E")]
		public static extern bool visible { [Token(Token = "0x6000692")] [Address(RVA = "0x594A9E0", Offset = "0x59495E0", VA = "0x18594A9E0")] [MethodImpl(4096)] set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000693 RID: 1683
		[Token(Token = "0x1700018F")]
		public static extern CursorLockMode lockState { [Token(Token = "0x6000693")] [Address(RVA = "0x594A9B0", Offset = "0x59495B0", VA = "0x18594A9B0")] [MethodImpl(4096)] get; }

		// Token: 0x06000694 RID: 1684
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x594A900", Offset = "0x5949500", VA = "0x18594A900")]
		[MethodImpl(4096)]
		private static extern void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode);
	}
}
