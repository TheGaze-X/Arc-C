using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002471 RID: 9329
	[Token(Token = "0x2002471")]
	public class DeckTakeExtraEnemyTalent : DeckTalent
	{
		// Token: 0x0600F03D RID: 61501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F03D")]
		[Address(RVA = "0x672310", Offset = "0x670F10", VA = "0x180672310", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F03E RID: 61502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F03E")]
		[Address(RVA = "0x6723D0", Offset = "0x670FD0", VA = "0x1806723D0", Slot = "33")]
		public override DeckModifier CreateDeckModifier(Deck.Card sourceCard)
		{
			return null;
		}

		// Token: 0x0600F03F RID: 61503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F03F")]
		[Address(RVA = "0x672490", Offset = "0x671090", VA = "0x180672490")]
		public DeckTakeExtraEnemyTalent()
		{
		}

		// Token: 0x0600F040 RID: 61504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F040")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x040109A2 RID: 68002
		[Token(Token = "0x40109A2")]
		[FieldOffset(Offset = "0x50")]
		private TalentData m_talentData;

		// Token: 0x040109A3 RID: 68003
		[Token(Token = "0x40109A3")]
		[FieldOffset(Offset = "0x58")]
		private List<string> m_enemyIdList;

		// Token: 0x040109A4 RID: 68004
		[Token(Token = "0x40109A4")]
		[FieldOffset(Offset = "0x60")]
		private List<int> m_enemyLevelList;

		// Token: 0x040109A5 RID: 68005
		[Token(Token = "0x40109A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x040109A6 RID: 68006
		[Token(Token = "0x40109A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateDeckModifier;

		// Token: 0x040109A7 RID: 68007
		[Token(Token = "0x40109A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002472 RID: 9330
		[Token(Token = "0x2002472")]
		private class DeckTakeExtraEnemyData : DeckModifier
		{
			// Token: 0x0600F041 RID: 61505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F041")]
			[Address(RVA = "0x6722D0", Offset = "0x670ED0", VA = "0x1806722D0")]
			public DeckTakeExtraEnemyData(Deck.Card sourceCard, TalentData talentData)
			{
			}

			// Token: 0x0600F042 RID: 61506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F042")]
			[Address(RVA = "0x672140", Offset = "0x670D40", VA = "0x180672140", Slot = "10")]
			public override void Preprocess(Deck deck)
			{
			}

			// Token: 0x040109A8 RID: 68008
			[Token(Token = "0x40109A8")]
			[FieldOffset(Offset = "0x20")]
			private TalentData m_internalTalentData;
		}
	}
}
