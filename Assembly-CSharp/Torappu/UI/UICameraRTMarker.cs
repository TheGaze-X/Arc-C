using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039D8 RID: 14808
	[Token(Token = "0x20039D8")]
	public class UICameraRTMarker : MonoBehaviour, IPageCameraMarker, IPageComponentMarker, IHotfixable
	{
		// Token: 0x06017638 RID: 95800 RVA: 0x00096438 File Offset: 0x00094638
		[Token(Token = "0x6017638")]
		[Address(RVA = "0xFBCC30", Offset = "0xFBB830", VA = "0x180FBCC30", Slot = "4")]
		public bool IsCollectable()
		{
			return default(bool);
		}

		// Token: 0x06017639 RID: 95801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017639")]
		[Address(RVA = "0xFBCC90", Offset = "0xFBB890", VA = "0x180FBCC90")]
		public UICameraRTMarker()
		{
		}

		// Token: 0x0401C3F2 RID: 115698
		[Token(Token = "0x401C3F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsCollectable;

		// Token: 0x0401C3F3 RID: 115699
		[Token(Token = "0x401C3F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
