using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A8F RID: 14991
	[Token(Token = "0x2003A8F")]
	public class DialogAnimationSwitchTween : UISwitchTween, IHotfixable
	{
		// Token: 0x06017B22 RID: 97058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B22")]
		[Address(RVA = "0xFE72A0", Offset = "0xFE5EA0", VA = "0x180FE72A0")]
		public DialogAnimationSwitchTween(CanvasGroup canvasGroup, UIAnimationLocation anim)
		{
		}

		// Token: 0x06017B23 RID: 97059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017B23")]
		[Address(RVA = "0xFE6F90", Offset = "0xFE5B90", VA = "0x180FE6F90", Slot = "5")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
		{
			return null;
		}

		// Token: 0x06017B24 RID: 97060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017B24")]
		[Address(RVA = "0xFE7080", Offset = "0xFE5C80", VA = "0x180FE7080", Slot = "4")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
		{
			return null;
		}

		// Token: 0x06017B25 RID: 97061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B25")]
		[Address(RVA = "0xFE71C0", Offset = "0xFE5DC0", VA = "0x180FE71C0", Slot = "10")]
		protected override void ResetToState(bool isShow)
		{
		}

		// Token: 0x06017B26 RID: 97062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B26")]
		[Address(RVA = "0xFE6EF0", Offset = "0xFE5AF0", VA = "0x180FE6EF0", Slot = "6")]
		protected override void BeforeShowEffect()
		{
		}

		// Token: 0x06017B27 RID: 97063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B27")]
		[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
		private void <>xLuaBaseProxy_ResetToState(bool P0)
		{
		}

		// Token: 0x06017B28 RID: 97064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B28")]
		[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
		private void <>xLuaBaseProxy_BeforeShowEffect()
		{
		}

		// Token: 0x0401C972 RID: 117106
		[Token(Token = "0x401C972")]
		[FieldOffset(Offset = "0x48")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0401C973 RID: 117107
		[Token(Token = "0x401C973")]
		[FieldOffset(Offset = "0x50")]
		private UIAnimationLocation m_enterAnim;

		// Token: 0x0401C974 RID: 117108
		[Token(Token = "0x401C974")]
		[FieldOffset(Offset = "0x60")]
		private float m_duration;

		// Token: 0x0401C975 RID: 117109
		[Token(Token = "0x401C975")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C976 RID: 117110
		[Token(Token = "0x401C976")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

		// Token: 0x0401C977 RID: 117111
		[Token(Token = "0x401C977")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

		// Token: 0x0401C978 RID: 117112
		[Token(Token = "0x401C978")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetToState;

		// Token: 0x0401C979 RID: 117113
		[Token(Token = "0x401C979")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BeforeShowEffect;
	}
}
