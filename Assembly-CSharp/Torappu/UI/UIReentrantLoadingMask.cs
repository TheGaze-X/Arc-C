using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A2A RID: 14890
	[Token(Token = "0x2003A2A")]
	public class UIReentrantLoadingMask : UIReentrantFloatPanel
	{
		// Token: 0x06017811 RID: 96273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017811")]
		[Address(RVA = "0xFD24B0", Offset = "0xFD10B0", VA = "0x180FD24B0", Slot = "4")]
		protected override IEnumerator ShowEffect()
		{
			return null;
		}

		// Token: 0x06017812 RID: 96274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017812")]
		[Address(RVA = "0xFD2400", Offset = "0xFD1000", VA = "0x180FD2400", Slot = "5")]
		protected override IEnumerator HideEffect()
		{
			return null;
		}

		// Token: 0x06017813 RID: 96275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017813")]
		[Address(RVA = "0xFD2560", Offset = "0xFD1160", VA = "0x180FD2560")]
		public UIReentrantLoadingMask()
		{
		}

		// Token: 0x06017814 RID: 96276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017814")]
		[Address(RVA = "0xFBC280", Offset = "0xFBAE80", VA = "0x180FBC280")]
		private IEnumerator <>xLuaBaseProxy_ShowEffect()
		{
			return null;
		}

		// Token: 0x06017815 RID: 96277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017815")]
		[Address(RVA = "0xFBC270", Offset = "0xFBAE70", VA = "0x180FBC270")]
		private IEnumerator <>xLuaBaseProxy_HideEffect()
		{
			return null;
		}

		// Token: 0x0401C624 RID: 116260
		[Token(Token = "0x401C624")]
		private const float ANIM_DURATION = 0.23f;

		// Token: 0x0401C625 RID: 116261
		[Token(Token = "0x401C625")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _ripplePanel;

		// Token: 0x0401C626 RID: 116262
		[Token(Token = "0x401C626")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _rippleAnim;

		// Token: 0x0401C627 RID: 116263
		[Token(Token = "0x401C627")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_rippleTween;

		// Token: 0x0401C628 RID: 116264
		[Token(Token = "0x401C628")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowEffect;

		// Token: 0x0401C629 RID: 116265
		[Token(Token = "0x401C629")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x0401C62A RID: 116266
		[Token(Token = "0x401C62A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
