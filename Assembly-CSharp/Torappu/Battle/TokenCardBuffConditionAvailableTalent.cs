using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024A1 RID: 9377
	[Token(Token = "0x20024A1")]
	public class TokenCardBuffConditionAvailableTalent : CardHoldTalent
	{
		// Token: 0x0600F10A RID: 61706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F10A")]
		[Address(RVA = "0x698750", Offset = "0x697350", VA = "0x180698750", Slot = "33")]
		public override CardHoldTalent.CardHoldDataModifier CreateHoldDataModifier(Character character)
		{
			return null;
		}

		// Token: 0x0600F10B RID: 61707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F10B")]
		[Address(RVA = "0x6986C0", Offset = "0x6972C0", VA = "0x1806986C0", Slot = "34")]
		public override UICardEffectHolder.CardEffectPlugin CreateCardEffectPlugin(Character character, CardHoldTalent.CardHoldDataModifier modifier)
		{
			return null;
		}

		// Token: 0x0600F10C RID: 61708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F10C")]
		[Address(RVA = "0x6988C0", Offset = "0x6974C0", VA = "0x1806988C0")]
		public TokenCardBuffConditionAvailableTalent()
		{
		}

		// Token: 0x04010AB8 RID: 68280
		[Token(Token = "0x4010AB8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _cardBuffKey;

		// Token: 0x04010AB9 RID: 68281
		[Token(Token = "0x4010AB9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _hostAllowMark;

		// Token: 0x04010ABA RID: 68282
		[Token(Token = "0x4010ABA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateHoldDataModifier;

		// Token: 0x04010ABB RID: 68283
		[Token(Token = "0x4010ABB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateCardEffectPlugin;

		// Token: 0x04010ABC RID: 68284
		[Token(Token = "0x4010ABC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020024A2 RID: 9378
		[Token(Token = "0x20024A2")]
		public class ConditionBuildableModifier : CardHoldTalent.CardHoldDataModifier
		{
			// Token: 0x0600F10D RID: 61709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F10D")]
			[Address(RVA = "0x688E40", Offset = "0x687A40", VA = "0x180688E40")]
			public ConditionBuildableModifier(TokenCardBuffConditionAvailableTalent talent)
			{
			}

			// Token: 0x0600F10E RID: 61710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F10E")]
			[Address(RVA = "0x688A00", Offset = "0x687600", VA = "0x180688A00", Slot = "5")]
			public override void OnTick(Deck.Card card, FP deltaTime)
			{
			}

			// Token: 0x0600F10F RID: 61711 RVA: 0x00058C50 File Offset: 0x00056E50
			[Token(Token = "0x600F10F")]
			[Address(RVA = "0x688CD0", Offset = "0x6878D0", VA = "0x180688CD0")]
			private bool _NeedMarkNotAllow(Deck.Card card)
			{
				return default(bool);
			}

			// Token: 0x0600F110 RID: 61712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F110")]
			[Address(RVA = "0x6888A0", Offset = "0x6874A0", VA = "0x1806888A0")]
			public void AttachNotAllowCardBuffIfNot(Deck.Card card)
			{
			}

			// Token: 0x0600F111 RID: 61713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F111")]
			[Address(RVA = "0x688970", Offset = "0x687570", VA = "0x180688970")]
			public void DetachNotAllowCardBuffIfNot(Deck.Card card)
			{
			}

			// Token: 0x04010ABD RID: 68285
			[Token(Token = "0x4010ABD")]
			[FieldOffset(Offset = "0x10")]
			private string m_cardBuffKey;

			// Token: 0x04010ABE RID: 68286
			[Token(Token = "0x4010ABE")]
			[FieldOffset(Offset = "0x18")]
			private Blackboard m_blackbaord;

			// Token: 0x04010ABF RID: 68287
			[Token(Token = "0x4010ABF")]
			[FieldOffset(Offset = "0x20")]
			private string m_hostAllowMark;

			// Token: 0x04010AC0 RID: 68288
			[Token(Token = "0x4010AC0")]
			[FieldOffset(Offset = "0x28")]
			private bool m_isAttached;

			// Token: 0x04010AC1 RID: 68289
			[Token(Token = "0x4010AC1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04010AC2 RID: 68290
			[Token(Token = "0x4010AC2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x04010AC3 RID: 68291
			[Token(Token = "0x4010AC3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__NeedMarkNotAllow;

			// Token: 0x04010AC4 RID: 68292
			[Token(Token = "0x4010AC4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AttachNotAllowCardBuffIfNot;

			// Token: 0x04010AC5 RID: 68293
			[Token(Token = "0x4010AC5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_DetachNotAllowCardBuffIfNot;
		}
	}
}
