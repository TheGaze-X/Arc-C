using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006509 RID: 25865
	[Token(Token = "0x2006509")]
	public class AutoChessBattleUIWaitingPanel : AutoChessBattleUIPanelBase
	{
		// Token: 0x060252E3 RID: 152291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252E3")]
		[Address(RVA = "0x203FA40", Offset = "0x203E640", VA = "0x18203FA40", Slot = "7")]
		public override void OnValueChanged(AutoChessBattleUIViewModelProperty property)
		{
		}

		// Token: 0x060252E4 RID: 152292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252E4")]
		[Address(RVA = "0x203FBD0", Offset = "0x203E7D0", VA = "0x18203FBD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060252E5 RID: 152293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252E5")]
		[Address(RVA = "0x203FCC0", Offset = "0x203E8C0", VA = "0x18203FCC0")]
		public AutoChessBattleUIWaitingPanel()
		{
		}

		// Token: 0x0403425D RID: 213597
		[Token(Token = "0x403425D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403425E RID: 213598
		[Token(Token = "0x403425E")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403425F RID: 213599
		[Token(Token = "0x403425F")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x04034260 RID: 213600
		[Token(Token = "0x4034260")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034261 RID: 213601
		[Token(Token = "0x4034261")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034262 RID: 213602
		[Token(Token = "0x4034262")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
