using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	public class SDKPopupFloatV2 : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012E")]
		protected FadeSwitchTween fadeTween
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x2536840", Offset = "0x2535440", VA = "0x182536840")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x2536520", Offset = "0x2535120", VA = "0x182536520")]
		public void SetByHandler(HGSDKPopupPage.UIState.FloatV2Handler handler)
		{
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x25367E0", Offset = "0x25353E0", VA = "0x1825367E0")]
		public SDKPopupFloatV2()
		{
		}

		// Token: 0x04000A91 RID: 2705
		[Token(Token = "0x4000A91")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04000A92 RID: 2706
		[Token(Token = "0x4000A92")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SDKPopupTitleView _titleView;

		// Token: 0x04000A93 RID: 2707
		[Token(Token = "0x4000A93")]
		[FieldOffset(Offset = "0x28")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x04000A94 RID: 2708
		[Token(Token = "0x4000A94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fadeTween;

		// Token: 0x04000A95 RID: 2709
		[Token(Token = "0x4000A95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetByHandler;

		// Token: 0x04000A96 RID: 2710
		[Token(Token = "0x4000A96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
