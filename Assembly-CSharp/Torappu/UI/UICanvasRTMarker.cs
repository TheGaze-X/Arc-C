using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039D9 RID: 14809
	[Token(Token = "0x20039D9")]
	public class UICanvasRTMarker : MonoBehaviour, IPageCanvasMarker, IPageComponentMarker, IHotfixable
	{
		// Token: 0x0601763A RID: 95802 RVA: 0x00096450 File Offset: 0x00094650
		[Token(Token = "0x601763A")]
		[Address(RVA = "0xFBCCF0", Offset = "0xFBB8F0", VA = "0x180FBCCF0", Slot = "4")]
		public bool IsCollectable()
		{
			return default(bool);
		}

		// Token: 0x0601763B RID: 95803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601763B")]
		[Address(RVA = "0xFBCD50", Offset = "0xFBB950", VA = "0x180FBCD50")]
		public UICanvasRTMarker()
		{
		}

		// Token: 0x0401C3F4 RID: 115700
		[Token(Token = "0x401C3F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsCollectable;

		// Token: 0x0401C3F5 RID: 115701
		[Token(Token = "0x401C3F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
