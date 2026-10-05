using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005733 RID: 22323
	[Token(Token = "0x2005733")]
	public class RL02ClassicEndingMonthStatsCharView : RoguelikeClassicEndingMonthStatsCharView
	{
		// Token: 0x06020B7D RID: 134013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B7D")]
		[Address(RVA = "0x1B05310", Offset = "0x1B03F10", VA = "0x181B05310", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06020B7E RID: 134014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B7E")]
		[Address(RVA = "0x1B05370", Offset = "0x1B03F70", VA = "0x181B05370", Slot = "5")]
		public override void Render(RoguelikeEndingControllerBase endingController, RoguelikeClassicEndingMonthViewModel viewModel)
		{
		}

		// Token: 0x06020B7F RID: 134015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B7F")]
		[Address(RVA = "0x1B05480", Offset = "0x1B04080", VA = "0x181B05480")]
		public RL02ClassicEndingMonthStatsCharView()
		{
		}

		// Token: 0x06020B80 RID: 134016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B80")]
		[Address(RVA = "0x1A33990", Offset = "0x1A32590", VA = "0x181A33990")]
		private void <>xLuaBaseProxy_Render(RoguelikeEndingControllerBase P0, RoguelikeClassicEndingMonthViewModel P1)
		{
		}

		// Token: 0x0402C68F RID: 181903
		[Token(Token = "0x402C68F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgCharPortrait;

		// Token: 0x0402C690 RID: 181904
		[Token(Token = "0x402C690")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402C691 RID: 181905
		[Token(Token = "0x402C691")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C692 RID: 181906
		[Token(Token = "0x402C692")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
