using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002487 RID: 9351
	[Token(Token = "0x2002487")]
	[RequireComponent(typeof(Ability))]
	public class DeckTalentToModifyRespawnMaxMultiplier : DeckTalent
	{
		// Token: 0x0600F08D RID: 61581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F08D")]
		[Address(RVA = "0x6731A0", Offset = "0x671DA0", VA = "0x1806731A0", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F08E RID: 61582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F08E")]
		[Address(RVA = "0x6732C0", Offset = "0x671EC0", VA = "0x1806732C0", Slot = "33")]
		public override DeckModifier CreateDeckModifier(Deck.Card sourceCard)
		{
			return null;
		}

		// Token: 0x0600F08F RID: 61583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F08F")]
		[Address(RVA = "0x6733C0", Offset = "0x671FC0", VA = "0x1806733C0")]
		public DeckTalentToModifyRespawnMaxMultiplier()
		{
		}

		// Token: 0x0600F090 RID: 61584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F090")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x04010A01 RID: 68097
		[Token(Token = "0x4010A01")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DeckSelector _selector;

		// Token: 0x04010A02 RID: 68098
		[Token(Token = "0x4010A02")]
		[FieldOffset(Offset = "0x80")]
		private FP m_maxMultiplier;

		// Token: 0x04010A03 RID: 68099
		[Token(Token = "0x4010A03")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010A04 RID: 68100
		[Token(Token = "0x4010A04")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateDeckModifier;

		// Token: 0x04010A05 RID: 68101
		[Token(Token = "0x4010A05")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002488 RID: 9352
		[Token(Token = "0x2002488")]
		private class DeckModifierToModifyRespawnMaxMultiplier : DeckModifier
		{
			// Token: 0x0600F091 RID: 61585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F091")]
			[Address(RVA = "0x6720E0", Offset = "0x670CE0", VA = "0x1806720E0")]
			public DeckModifierToModifyRespawnMaxMultiplier(Deck.Card sourceCard, DeckSelector selector, FP maxMultiplier)
			{
			}

			// Token: 0x0600F092 RID: 61586 RVA: 0x00058AA0 File Offset: 0x00056CA0
			[Token(Token = "0x600F092")]
			[Address(RVA = "0x672000", Offset = "0x670C00", VA = "0x180672000", Slot = "11")]
			public override bool TryHookMaxMultiplier(Deck.Card card, out FP respawnCostMaxMultiplier)
			{
				return default(bool);
			}

			// Token: 0x04010A06 RID: 68102
			[Token(Token = "0x4010A06")]
			[FieldOffset(Offset = "0x20")]
			private DeckSelector m_selector;

			// Token: 0x04010A07 RID: 68103
			[Token(Token = "0x4010A07")]
			[FieldOffset(Offset = "0x50")]
			private FP m_maxMultiplier;
		}
	}
}
