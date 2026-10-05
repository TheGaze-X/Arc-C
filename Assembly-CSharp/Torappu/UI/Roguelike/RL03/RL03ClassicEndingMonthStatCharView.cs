using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005816 RID: 22550
	[Token(Token = "0x2005816")]
	public class RL03ClassicEndingMonthStatCharView : RoguelikeClassicEndingMonthStatsCharView
	{
		// Token: 0x06020F44 RID: 134980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F44")]
		[Address(RVA = "0x1B45DE0", Offset = "0x1B449E0", VA = "0x181B45DE0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06020F45 RID: 134981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F45")]
		[Address(RVA = "0x1B45E40", Offset = "0x1B44A40", VA = "0x181B45E40", Slot = "5")]
		public override void Render(RoguelikeEndingControllerBase endingController, RoguelikeClassicEndingMonthViewModel viewModel)
		{
		}

		// Token: 0x06020F46 RID: 134982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F46")]
		[Address(RVA = "0x1B46110", Offset = "0x1B44D10", VA = "0x181B46110")]
		public RL03ClassicEndingMonthStatCharView()
		{
		}

		// Token: 0x06020F47 RID: 134983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F47")]
		[Address(RVA = "0x1A33990", Offset = "0x1A32590", VA = "0x181A33990")]
		private void <>xLuaBaseProxy_Render(RoguelikeEndingControllerBase P0, RoguelikeClassicEndingMonthViewModel P1)
		{
		}

		// Token: 0x0402CCE3 RID: 183523
		[Token(Token = "0x402CCE3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgCharPortrait;

		// Token: 0x0402CCE4 RID: 183524
		[Token(Token = "0x402CCE4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _prfession;

		// Token: 0x0402CCE5 RID: 183525
		[Token(Token = "0x402CCE5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _rarity;

		// Token: 0x0402CCE6 RID: 183526
		[Token(Token = "0x402CCE6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _charName;

		// Token: 0x0402CCE7 RID: 183527
		[Token(Token = "0x402CCE7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402CCE8 RID: 183528
		[Token(Token = "0x402CCE8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CCE9 RID: 183529
		[Token(Token = "0x402CCE9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
