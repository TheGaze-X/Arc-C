using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002481 RID: 9345
	[Token(Token = "0x2002481")]
	[RequireComponent(typeof(Ability))]
	public class DeckTalentToAddMaxCost : DeckTalent
	{
		// Token: 0x0600F07D RID: 61565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F07D")]
		[Address(RVA = "0x672900", Offset = "0x671500", VA = "0x180672900", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F07E RID: 61566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F07E")]
		[Address(RVA = "0x6729F0", Offset = "0x6715F0", VA = "0x1806729F0", Slot = "33")]
		public override DeckModifier CreateDeckModifier(Deck.Card sourceCard)
		{
			return null;
		}

		// Token: 0x0600F07F RID: 61567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F07F")]
		[Address(RVA = "0x672AA0", Offset = "0x6716A0", VA = "0x180672AA0")]
		public DeckTalentToAddMaxCost()
		{
		}

		// Token: 0x0600F080 RID: 61568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F080")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x040109F0 RID: 68080
		[Token(Token = "0x40109F0")]
		[FieldOffset(Offset = "0x50")]
		private int m_cost;

		// Token: 0x040109F1 RID: 68081
		[Token(Token = "0x40109F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x040109F2 RID: 68082
		[Token(Token = "0x40109F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateDeckModifier;

		// Token: 0x040109F3 RID: 68083
		[Token(Token = "0x40109F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002482 RID: 9346
		[Token(Token = "0x2002482")]
		private class DeckModifierToAddMaxCost : DeckModifier
		{
			// Token: 0x0600F081 RID: 61569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F081")]
			[Address(RVA = "0x671A30", Offset = "0x670630", VA = "0x180671A30")]
			public DeckModifierToAddMaxCost(Deck.Card sourceCard, int cost)
			{
			}

			// Token: 0x0600F082 RID: 61570 RVA: 0x00058A70 File Offset: 0x00056C70
			[Token(Token = "0x600F082")]
			[Address(RVA = "0x671A20", Offset = "0x670620", VA = "0x180671A20", Slot = "12")]
			public override bool TryGetInitCostDelta(out int costDelta)
			{
				return default(bool);
			}

			// Token: 0x040109F4 RID: 68084
			[Token(Token = "0x40109F4")]
			[FieldOffset(Offset = "0x20")]
			private int m_cost;
		}
	}
}
