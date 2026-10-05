using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002485 RID: 9349
	[Token(Token = "0x2002485")]
	public class DeckTalentToModifyHealScaleByCost : DeckBuffTalent
	{
		// Token: 0x0600F086 RID: 61574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F086")]
		[Address(RVA = "0x672D80", Offset = "0x671980", VA = "0x180672D80", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F087 RID: 61575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F087")]
		[Address(RVA = "0x672E70", Offset = "0x671A70", VA = "0x180672E70", Slot = "33")]
		public override DeckModifier CreateDeckModifier(Deck.Card sourceCard)
		{
			return null;
		}

		// Token: 0x0600F088 RID: 61576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F088")]
		[Address(RVA = "0x6730D0", Offset = "0x671CD0", VA = "0x1806730D0")]
		public DeckTalentToModifyHealScaleByCost()
		{
		}

		// Token: 0x0600F089 RID: 61577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F089")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x0600F08A RID: 61578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F08A")]
		[Address(RVA = "0x672FA0", Offset = "0x671BA0", VA = "0x180672FA0")]
		private DeckModifier <>xLuaBaseProxy_CreateDeckModifier(Deck.Card P0)
		{
			return null;
		}

		// Token: 0x040109F9 RID: 68089
		[Token(Token = "0x40109F9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int _maxCost;

		// Token: 0x040109FA RID: 68090
		[Token(Token = "0x40109FA")]
		[FieldOffset(Offset = "0x64")]
		private int m_maxCost;

		// Token: 0x040109FB RID: 68091
		[Token(Token = "0x40109FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x040109FC RID: 68092
		[Token(Token = "0x40109FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateDeckModifier;

		// Token: 0x040109FD RID: 68093
		[Token(Token = "0x40109FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002486 RID: 9350
		[Token(Token = "0x2002486")]
		private class DeckModifierToModifyHealScaleByCost : DeckModifier
		{
			// Token: 0x0600F08B RID: 61579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F08B")]
			[Address(RVA = "0x671E00", Offset = "0x670A00", VA = "0x180671E00")]
			public DeckModifierToModifyHealScaleByCost(Deck.Card sourceCard, IList<DeckBuff> deckBuffs, int maxCost, Blackboard blackboard)
			{
			}

			// Token: 0x0600F08C RID: 61580 RVA: 0x00058A88 File Offset: 0x00056C88
			[Token(Token = "0x600F08C")]
			[Address(RVA = "0x671A60", Offset = "0x670660", VA = "0x180671A60", Slot = "14")]
			public override bool TryGetDeckBuff(Deck.Card card, out IList<DeckBuff> buffs, out IList<Blackboard> blackboards)
			{
				return default(bool);
			}

			// Token: 0x040109FE RID: 68094
			[Token(Token = "0x40109FE")]
			[FieldOffset(Offset = "0x20")]
			private IList<DeckBuff> m_deckBuffs;

			// Token: 0x040109FF RID: 68095
			[Token(Token = "0x40109FF")]
			[FieldOffset(Offset = "0x28")]
			private IList<Blackboard> m_blackboard;

			// Token: 0x04010A00 RID: 68096
			[Token(Token = "0x4010A00")]
			[FieldOffset(Offset = "0x30")]
			private int m_maxCost;
		}
	}
}
