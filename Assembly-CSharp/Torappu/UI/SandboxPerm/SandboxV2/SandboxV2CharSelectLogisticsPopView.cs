using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004027 RID: 16423
	[Token(Token = "0x2004027")]
	public class SandboxV2CharSelectLogisticsPopView : SandboxV2AdminCharSelectAbstractPopView
	{
		// Token: 0x060196BB RID: 104123 RVA: 0x0009DFE0 File Offset: 0x0009C1E0
		[Token(Token = "0x60196BB")]
		[Address(RVA = "0x121F440", Offset = "0x121E040", VA = "0x18121F440", Slot = "4")]
		public override SandboxV2AdminCharSelectStateMode GetStateMode()
		{
			return SandboxV2AdminCharSelectStateMode.SINGLE_SQUAD;
		}

		// Token: 0x060196BC RID: 104124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196BC")]
		[Address(RVA = "0x121F520", Offset = "0x121E120", VA = "0x18121F520", Slot = "5")]
		public override void Show(SandboxV2CharListViewModel charListViewModel)
		{
		}

		// Token: 0x060196BD RID: 104125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196BD")]
		[Address(RVA = "0x121F4A0", Offset = "0x121E0A0", VA = "0x18121F4A0", Slot = "6")]
		public override void Hide()
		{
		}

		// Token: 0x060196BE RID: 104126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196BE")]
		[Address(RVA = "0x121F3A0", Offset = "0x121DFA0", VA = "0x18121F3A0")]
		public void EventOnTipsCloseBtnClick()
		{
		}

		// Token: 0x060196BF RID: 104127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196BF")]
		[Address(RVA = "0x121F5B0", Offset = "0x121E1B0", VA = "0x18121F5B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060196C0 RID: 104128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196C0")]
		[Address(RVA = "0x121F6A0", Offset = "0x121E2A0", VA = "0x18121F6A0")]
		public SandboxV2CharSelectLogisticsPopView()
		{
		}

		// Token: 0x0401FA32 RID: 129586
		[Token(Token = "0x401FA32")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _tipsCanvasGroup;

		// Token: 0x0401FA33 RID: 129587
		[Token(Token = "0x401FA33")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _tipsShowDuration;

		// Token: 0x0401FA34 RID: 129588
		[Token(Token = "0x401FA34")]
		[FieldOffset(Offset = "0x24")]
		private bool m_isInited;

		// Token: 0x0401FA35 RID: 129589
		[Token(Token = "0x401FA35")]
		[FieldOffset(Offset = "0x28")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0401FA36 RID: 129590
		[Token(Token = "0x401FA36")]
		[FieldOffset(Offset = "0x30")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401FA37 RID: 129591
		[Token(Token = "0x401FA37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetStateMode;

		// Token: 0x0401FA38 RID: 129592
		[Token(Token = "0x401FA38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0401FA39 RID: 129593
		[Token(Token = "0x401FA39")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0401FA3A RID: 129594
		[Token(Token = "0x401FA3A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnTipsCloseBtnClick;

		// Token: 0x0401FA3B RID: 129595
		[Token(Token = "0x401FA3B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FA3C RID: 129596
		[Token(Token = "0x401FA3C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
