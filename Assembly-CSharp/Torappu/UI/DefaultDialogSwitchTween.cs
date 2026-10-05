using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A8E RID: 14990
	[Token(Token = "0x2003A8E")]
	public class DefaultDialogSwitchTween : UISwitchTween
	{
		// Token: 0x06017B1B RID: 97051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B1B")]
		[Address(RVA = "0xFE67A0", Offset = "0xFE53A0", VA = "0x180FE67A0")]
		public DefaultDialogSwitchTween(CanvasGroup alphaHandler, bool ignoreTimeScale = false)
		{
		}

		// Token: 0x06017B1C RID: 97052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017B1C")]
		[Address(RVA = "0xFE6540", Offset = "0xFE5140", VA = "0x180FE6540", Slot = "5")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
		{
			return null;
		}

		// Token: 0x06017B1D RID: 97053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017B1D")]
		[Address(RVA = "0xFE6610", Offset = "0xFE5210", VA = "0x180FE6610", Slot = "4")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
		{
			return null;
		}

		// Token: 0x06017B1E RID: 97054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B1E")]
		[Address(RVA = "0xFE6710", Offset = "0xFE5310", VA = "0x180FE6710", Slot = "10")]
		protected override void ResetToState(bool isShow)
		{
		}

		// Token: 0x06017B1F RID: 97055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B1F")]
		[Address(RVA = "0xFE64D0", Offset = "0xFE50D0", VA = "0x180FE64D0", Slot = "6")]
		protected override void BeforeShowEffect()
		{
		}

		// Token: 0x06017B20 RID: 97056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B20")]
		[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
		private void <>xLuaBaseProxy_ResetToState(bool P0)
		{
		}

		// Token: 0x06017B21 RID: 97057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B21")]
		[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
		private void <>xLuaBaseProxy_BeforeShowEffect()
		{
		}

		// Token: 0x0401C96A RID: 117098
		[Token(Token = "0x401C96A")]
		[FieldOffset(Offset = "0x48")]
		private CanvasGroup m_alphaHandler;

		// Token: 0x0401C96B RID: 117099
		[Token(Token = "0x401C96B")]
		[FieldOffset(Offset = "0x50")]
		private bool m_ignoreTimeScale;

		// Token: 0x0401C96C RID: 117100
		[Token(Token = "0x401C96C")]
		[FieldOffset(Offset = "0x54")]
		public float duration;

		// Token: 0x0401C96D RID: 117101
		[Token(Token = "0x401C96D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C96E RID: 117102
		[Token(Token = "0x401C96E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

		// Token: 0x0401C96F RID: 117103
		[Token(Token = "0x401C96F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

		// Token: 0x0401C970 RID: 117104
		[Token(Token = "0x401C970")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetToState;

		// Token: 0x0401C971 RID: 117105
		[Token(Token = "0x401C971")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BeforeShowEffect;
	}
}
