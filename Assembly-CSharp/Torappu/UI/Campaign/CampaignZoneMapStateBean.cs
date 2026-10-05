using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006147 RID: 24903
	[Token(Token = "0x2006147")]
	public class CampaignZoneMapStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06023F46 RID: 147270 RVA: 0x000C2790 File Offset: 0x000C0990
		[Token(Token = "0x6023F46")]
		[Address(RVA = "0x1EADB50", Offset = "0x1EAC750", VA = "0x181EADB50")]
		public bool CheckIfToTriggerFastBattleGuide()
		{
			return default(bool);
		}

		// Token: 0x06023F47 RID: 147271 RVA: 0x000C27A8 File Offset: 0x000C09A8
		[Token(Token = "0x6023F47")]
		[Address(RVA = "0x1EADAB0", Offset = "0x1EAC6B0", VA = "0x181EADAB0")]
		public bool CheckIfFastBattle()
		{
			return default(bool);
		}

		// Token: 0x06023F48 RID: 147272 RVA: 0x000C27C0 File Offset: 0x000C09C0
		[Token(Token = "0x6023F48")]
		[Address(RVA = "0x1EAD9B0", Offset = "0x1EAC5B0", VA = "0x181EAD9B0")]
		public bool CheckIfAutoBattle()
		{
			return default(bool);
		}

		// Token: 0x06023F49 RID: 147273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F49")]
		[Address(RVA = "0x1EADC10", Offset = "0x1EAC810", VA = "0x181EADC10")]
		public CampaignZoneMapStateBean()
		{
		}

		// Token: 0x04031EC9 RID: 204489
		[Token(Token = "0x4031EC9")]
		[FieldOffset(Offset = "0x10")]
		public CampaignZoneMapProperty property;

		// Token: 0x04031ECA RID: 204490
		[Token(Token = "0x4031ECA")]
		[FieldOffset(Offset = "0x18")]
		public CampaignZoneJumpViewModel jumpViewModel;

		// Token: 0x04031ECB RID: 204491
		[Token(Token = "0x4031ECB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfToTriggerFastBattleGuide;

		// Token: 0x04031ECC RID: 204492
		[Token(Token = "0x4031ECC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfFastBattle;

		// Token: 0x04031ECD RID: 204493
		[Token(Token = "0x4031ECD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckIfAutoBattle;

		// Token: 0x04031ECE RID: 204494
		[Token(Token = "0x4031ECE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
