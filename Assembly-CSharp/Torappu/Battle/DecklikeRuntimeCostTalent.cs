using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002476 RID: 9334
	[Token(Token = "0x2002476")]
	public class DecklikeRuntimeCostTalent : BasicTalent, ICardMiscModifierTalent, IHotfixable
	{
		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x0600F04B RID: 61515 RVA: 0x00058890 File Offset: 0x00056A90
		[Token(Token = "0x17001F3A")]
		public override bool attachInDummy
		{
			[Token(Token = "0x600F04B")]
			[Address(RVA = "0x673CA0", Offset = "0x6728A0", VA = "0x180673CA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F04C RID: 61516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F04C")]
		[Address(RVA = "0x6738C0", Offset = "0x6724C0", VA = "0x1806738C0", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F04D RID: 61517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F04D")]
		[Address(RVA = "0x673AD0", Offset = "0x6726D0", VA = "0x180673AD0")]
		public Deck.Card.RuntimeCostModifier CreateDecklikeRuntimeCostModifier(Deck.Card sourceCard)
		{
			return null;
		}

		// Token: 0x0600F04E RID: 61518 RVA: 0x000588A8 File Offset: 0x00056AA8
		[Token(Token = "0x600F04E")]
		[Address(RVA = "0x6739B0", Offset = "0x6725B0", VA = "0x1806739B0", Slot = "33")]
		public bool CreateDeckRuntimeMiscModifier(Deck.Card sourceCard, out Deck.Card.MiscSettingModifier modifier)
		{
			return default(bool);
		}

		// Token: 0x0600F04F RID: 61519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F04F")]
		[Address(RVA = "0x673C00", Offset = "0x672800", VA = "0x180673C00")]
		public DecklikeRuntimeCostTalent()
		{
		}

		// Token: 0x0600F050 RID: 61520 RVA: 0x000588C0 File Offset: 0x00056AC0
		[Token(Token = "0x600F050")]
		[Address(RVA = "0x66C630", Offset = "0x66B230", VA = "0x18066C630")]
		private bool <>xLuaBaseProxy_get_attachInDummy()
		{
			return default(bool);
		}

		// Token: 0x0600F051 RID: 61521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F051")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x040109B6 RID: 68022
		[Token(Token = "0x40109B6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DecklikeRuntimeCostTalent.Options _options;

		// Token: 0x040109B7 RID: 68023
		[Token(Token = "0x40109B7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected int _runtimeCost;

		// Token: 0x040109B8 RID: 68024
		[Token(Token = "0x40109B8")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Deck.Card.AdvancedCardBuildState _advancedCardBuildState;

		// Token: 0x040109B9 RID: 68025
		[Token(Token = "0x40109B9")]
		[FieldOffset(Offset = "0x60")]
		private int m_runtimeCost;

		// Token: 0x040109BA RID: 68026
		[Token(Token = "0x40109BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_attachInDummy;

		// Token: 0x040109BB RID: 68027
		[Token(Token = "0x40109BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x040109BC RID: 68028
		[Token(Token = "0x40109BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateDecklikeRuntimeCostModifier;

		// Token: 0x040109BD RID: 68029
		[Token(Token = "0x40109BD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateDeckRuntimeMiscModifier;

		// Token: 0x040109BE RID: 68030
		[Token(Token = "0x40109BE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002477 RID: 9335
		[Token(Token = "0x2002477")]
		[Serializable]
		public class Options
		{
			// Token: 0x0600F052 RID: 61522 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F052")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x040109BF RID: 68031
			[Token(Token = "0x40109BF")]
			[FieldOffset(Offset = "0x10")]
			public DeckSelector selector;

			// Token: 0x040109C0 RID: 68032
			[Token(Token = "0x40109C0")]
			[FieldOffset(Offset = "0x40")]
			[Tooltip("Minimum cnt of verified cards to trig this talent")]
			public int minCntToTrig;

			// Token: 0x040109C1 RID: 68033
			[Token(Token = "0x40109C1")]
			[FieldOffset(Offset = "0x44")]
			public bool trackSourceCardInCardBuff;
		}

		// Token: 0x02002478 RID: 9336
		[Token(Token = "0x2002478")]
		public class DecklikeRuntimeCostModifier : Deck.Card.RuntimeCostModifier
		{
			// Token: 0x17001F3B RID: 7995
			// (get) Token: 0x0600F053 RID: 61523 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001F3B")]
			public Deck.Card sourceCard
			{
				[Token(Token = "0x600F053")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001F3C RID: 7996
			// (get) Token: 0x0600F054 RID: 61524 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001F3C")]
			public override string cardBuffKey
			{
				[Token(Token = "0x600F054")]
				[Address(RVA = "0x673750", Offset = "0x672350", VA = "0x180673750", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001F3D RID: 7997
			// (get) Token: 0x0600F055 RID: 61525 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001F3D")]
			public override string overrideKey
			{
				[Token(Token = "0x600F055")]
				[Address(RVA = "0x6737C0", Offset = "0x6723C0", VA = "0x1806737C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001F3E RID: 7998
			// (get) Token: 0x0600F056 RID: 61526 RVA: 0x000588D8 File Offset: 0x00056AD8
			[Token(Token = "0x17001F3E")]
			public override FP overridePriority
			{
				[Token(Token = "0x600F056")]
				[Address(RVA = "0x673840", Offset = "0x672440", VA = "0x180673840", Slot = "9")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x0600F057 RID: 61527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F057")]
			[Address(RVA = "0x6736A0", Offset = "0x6722A0", VA = "0x1806736A0")]
			public DecklikeRuntimeCostModifier(Deck.Card sourceCard, int costDelta, DecklikeRuntimeCostTalent.Options options)
			{
			}

			// Token: 0x0600F058 RID: 61528 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F058")]
			[Address(RVA = "0x673550", Offset = "0x672150", VA = "0x180673550", Slot = "14")]
			public override void Preprocess(Deck deck)
			{
			}

			// Token: 0x0600F059 RID: 61529 RVA: 0x000588F0 File Offset: 0x00056AF0
			[Token(Token = "0x600F059")]
			[Address(RVA = "0x673640", Offset = "0x672240", VA = "0x180673640", Slot = "15")]
			public override bool TryGetCostDelta(Deck.Card card, out int costDelta)
			{
				return default(bool);
			}

			// Token: 0x040109C2 RID: 68034
			[Token(Token = "0x40109C2")]
			[FieldOffset(Offset = "0x28")]
			private Deck.Card m_sourceCard;

			// Token: 0x040109C3 RID: 68035
			[Token(Token = "0x40109C3")]
			[FieldOffset(Offset = "0x30")]
			private int m_costDelta;

			// Token: 0x040109C4 RID: 68036
			[Token(Token = "0x40109C4")]
			[FieldOffset(Offset = "0x38")]
			private DecklikeRuntimeCostTalent.Options m_options;

			// Token: 0x040109C5 RID: 68037
			[Token(Token = "0x40109C5")]
			[FieldOffset(Offset = "0x40")]
			private bool m_isTriggered;
		}

		// Token: 0x02002479 RID: 9337
		[Token(Token = "0x2002479")]
		private class DeckMiscModifier : Deck.Card.MiscSettingModifier
		{
			// Token: 0x0600F05A RID: 61530 RVA: 0x00058908 File Offset: 0x00056B08
			[Token(Token = "0x600F05A")]
			[Address(RVA = "0x6710B0", Offset = "0x66FCB0", VA = "0x1806710B0", Slot = "14")]
			public override bool IsTriggered(Deck.Card card, out Deck.Card.CardBuff.LifeType lifeType)
			{
				return default(bool);
			}

			// Token: 0x0600F05B RID: 61531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F05B")]
			[Address(RVA = "0x671290", Offset = "0x66FE90", VA = "0x180671290")]
			public DeckMiscModifier(Deck.Card sourceCard)
			{
			}

			// Token: 0x040109C6 RID: 68038
			[Token(Token = "0x40109C6")]
			[FieldOffset(Offset = "0x38")]
			private Deck.Card m_sourceCard;

			// Token: 0x040109C7 RID: 68039
			[Token(Token = "0x40109C7")]
			[FieldOffset(Offset = "0x40")]
			private bool m_isTriggered;
		}
	}
}
