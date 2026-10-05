using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200247F RID: 9343
	[Token(Token = "0x200247F")]
	[RequireComponent(typeof(Ability))]
	public class DeckTalentToAddCardCost : DeckTalent
	{
		// Token: 0x0600F075 RID: 61557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F075")]
		[Address(RVA = "0x672590", Offset = "0x671190", VA = "0x180672590", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F076 RID: 61558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F076")]
		[Address(RVA = "0x672680", Offset = "0x671280", VA = "0x180672680", Slot = "33")]
		public override DeckModifier CreateDeckModifier(Deck.Card sourceCard)
		{
			return null;
		}

		// Token: 0x0600F077 RID: 61559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F077")]
		[Address(RVA = "0x6728A0", Offset = "0x6714A0", VA = "0x1806728A0")]
		public DeckTalentToAddCardCost()
		{
		}

		// Token: 0x0600F078 RID: 61560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F078")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x040109E8 RID: 68072
		[Token(Token = "0x40109E8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DeckSelector _selector;

		// Token: 0x040109E9 RID: 68073
		[Token(Token = "0x40109E9")]
		[FieldOffset(Offset = "0x80")]
		private int m_cost;

		// Token: 0x040109EA RID: 68074
		[Token(Token = "0x40109EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x040109EB RID: 68075
		[Token(Token = "0x40109EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateDeckModifier;

		// Token: 0x040109EC RID: 68076
		[Token(Token = "0x40109EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002480 RID: 9344
		[Token(Token = "0x2002480")]
		private class DeckModifierToAddCardCost : DeckModifier
		{
			// Token: 0x17001F45 RID: 8005
			// (get) Token: 0x0600F079 RID: 61561 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001F45")]
			public override string overrideKey
			{
				[Token(Token = "0x600F079")]
				[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001F46 RID: 8006
			// (get) Token: 0x0600F07A RID: 61562 RVA: 0x00058A40 File Offset: 0x00056C40
			[Token(Token = "0x17001F46")]
			public override FP overridePriority
			{
				[Token(Token = "0x600F07A")]
				[Address(RVA = "0x6719A0", Offset = "0x6705A0", VA = "0x1806719A0", Slot = "9")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x0600F07B RID: 61563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F07B")]
			[Address(RVA = "0x671880", Offset = "0x670480", VA = "0x180671880")]
			public DeckModifierToAddCardCost(Deck.Card sourceCard, DeckSelector selector, int cost, string overrideKey)
			{
			}

			// Token: 0x0600F07C RID: 61564 RVA: 0x00058A58 File Offset: 0x00056C58
			[Token(Token = "0x600F07C")]
			[Address(RVA = "0x671830", Offset = "0x670430", VA = "0x180671830", Slot = "13")]
			public override bool TryGetCardCostDelta(Deck.Card card, out int costDelta)
			{
				return default(bool);
			}

			// Token: 0x040109ED RID: 68077
			[Token(Token = "0x40109ED")]
			[FieldOffset(Offset = "0x20")]
			private DeckSelector m_selector;

			// Token: 0x040109EE RID: 68078
			[Token(Token = "0x40109EE")]
			[FieldOffset(Offset = "0x50")]
			private int m_cost;

			// Token: 0x040109EF RID: 68079
			[Token(Token = "0x40109EF")]
			[FieldOffset(Offset = "0x58")]
			private string m_overrideKey;
		}
	}
}
