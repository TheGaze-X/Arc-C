using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D8F RID: 15759
	[Token(Token = "0x2003D8F")]
	public class TemplateMissionCommonBgView : TemplateMissionBgView
	{
		// Token: 0x06018837 RID: 100407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018837")]
		[Address(RVA = "0x11098C0", Offset = "0x11084C0", VA = "0x1811098C0", Slot = "8")]
		public override void Init(AbstractTemplateMissionViewController ctrl_, TemplateMissionCustomResHolder customResHolder_)
		{
		}

		// Token: 0x06018838 RID: 100408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018838")]
		[Address(RVA = "0x1109970", Offset = "0x1108570", VA = "0x181109970", Slot = "9")]
		protected override void RenderView()
		{
		}

		// Token: 0x06018839 RID: 100409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018839")]
		[Address(RVA = "0x1109AD0", Offset = "0x11086D0", VA = "0x181109AD0")]
		public TemplateMissionCommonBgView()
		{
		}

		// Token: 0x0601883A RID: 100410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601883A")]
		[Address(RVA = "0x1109AC0", Offset = "0x11086C0", VA = "0x181109AC0")]
		private void <>xLuaBaseProxy_Init(AbstractTemplateMissionViewController P0, TemplateMissionCustomResHolder P1)
		{
		}

		// Token: 0x0401E0BD RID: 123069
		[Token(Token = "0x401E0BD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _bkg;

		// Token: 0x0401E0BE RID: 123070
		[Token(Token = "0x401E0BE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TemplateMissionCommonEntryFadeTween _entryFadeTween;

		// Token: 0x0401E0BF RID: 123071
		[Token(Token = "0x401E0BF")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isRendered;

		// Token: 0x0401E0C0 RID: 123072
		[Token(Token = "0x401E0C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401E0C1 RID: 123073
		[Token(Token = "0x401E0C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401E0C2 RID: 123074
		[Token(Token = "0x401E0C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
