using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200247B RID: 9339
	[Token(Token = "0x200247B")]
	public class DeckMiscTalent : BasicTalent, ICardMiscModifierTalent, IHotfixable
	{
		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x0600F063 RID: 61539 RVA: 0x00058980 File Offset: 0x00056B80
		[Token(Token = "0x17001F41")]
		public override bool attachInDummy
		{
			[Token(Token = "0x600F063")]
			[Address(RVA = "0x6716C0", Offset = "0x6702C0", VA = "0x1806716C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x0600F064 RID: 61540 RVA: 0x00058998 File Offset: 0x00056B98
		[Token(Token = "0x17001F42")]
		public override bool affectInDeck
		{
			[Token(Token = "0x600F064")]
			[Address(RVA = "0x671660", Offset = "0x670260", VA = "0x180671660", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x0600F065 RID: 61541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F43")]
		public override string talentKey
		{
			[Token(Token = "0x600F065")]
			[Address(RVA = "0x671720", Offset = "0x670320", VA = "0x180671720", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F066 RID: 61542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F066")]
		[Address(RVA = "0x6712D0", Offset = "0x66FED0", VA = "0x1806712D0", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F067 RID: 61543 RVA: 0x000589B0 File Offset: 0x00056BB0
		[Token(Token = "0x600F067")]
		[Address(RVA = "0x671430", Offset = "0x670030", VA = "0x180671430", Slot = "33")]
		public bool CreateDeckRuntimeMiscModifier(Deck.Card sourceCard, out Deck.Card.MiscSettingModifier modifier)
		{
			return default(bool);
		}

		// Token: 0x0600F068 RID: 61544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F068")]
		[Address(RVA = "0x6715C0", Offset = "0x6701C0", VA = "0x1806715C0")]
		public DeckMiscTalent()
		{
		}

		// Token: 0x0600F069 RID: 61545 RVA: 0x000589C8 File Offset: 0x00056BC8
		[Token(Token = "0x600F069")]
		[Address(RVA = "0x66C630", Offset = "0x66B230", VA = "0x18066C630")]
		private bool <>xLuaBaseProxy_get_attachInDummy()
		{
			return default(bool);
		}

		// Token: 0x0600F06A RID: 61546 RVA: 0x000589E0 File Offset: 0x00056BE0
		[Token(Token = "0x600F06A")]
		[Address(RVA = "0x66C3F0", Offset = "0x66AFF0", VA = "0x18066C3F0")]
		private bool <>xLuaBaseProxy_get_affectInDeck()
		{
			return default(bool);
		}

		// Token: 0x0600F06B RID: 61547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F06B")]
		[Address(RVA = "0x6715B0", Offset = "0x6701B0", VA = "0x1806715B0")]
		private string <>xLuaBaseProxy_get_talentKey()
		{
			return null;
		}

		// Token: 0x0600F06C RID: 61548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F06C")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x040109D4 RID: 68052
		[Token(Token = "0x40109D4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DeckMiscTalent.Options _options;

		// Token: 0x040109D5 RID: 68053
		[Token(Token = "0x40109D5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _dontOccupyDeployCnt;

		// Token: 0x040109D6 RID: 68054
		[Token(Token = "0x40109D6")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private BuildableType _additionBuildableType;

		// Token: 0x040109D7 RID: 68055
		[Token(Token = "0x40109D7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AdvancedBuildableMask _additionMask;

		// Token: 0x040109D8 RID: 68056
		[Token(Token = "0x40109D8")]
		[FieldOffset(Offset = "0x64")]
		private bool m_dontOccupyDeployCnt;

		// Token: 0x040109D9 RID: 68057
		[Token(Token = "0x40109D9")]
		[FieldOffset(Offset = "0x68")]
		private int m_additionBuildableType;

		// Token: 0x040109DA RID: 68058
		[Token(Token = "0x40109DA")]
		[FieldOffset(Offset = "0x6C")]
		private int m_additionMask;

		// Token: 0x040109DB RID: 68059
		[Token(Token = "0x40109DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_attachInDummy;

		// Token: 0x040109DC RID: 68060
		[Token(Token = "0x40109DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_affectInDeck;

		// Token: 0x040109DD RID: 68061
		[Token(Token = "0x40109DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_talentKey;

		// Token: 0x040109DE RID: 68062
		[Token(Token = "0x40109DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x040109DF RID: 68063
		[Token(Token = "0x40109DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateDeckRuntimeMiscModifier;

		// Token: 0x040109E0 RID: 68064
		[Token(Token = "0x40109E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200247C RID: 9340
		[Token(Token = "0x200247C")]
		[Serializable]
		public class Options
		{
			// Token: 0x0600F06D RID: 61549 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F06D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x040109E1 RID: 68065
			[Token(Token = "0x40109E1")]
			[FieldOffset(Offset = "0x10")]
			public DeckSelector selector;

			// Token: 0x040109E2 RID: 68066
			[Token(Token = "0x40109E2")]
			[FieldOffset(Offset = "0x40")]
			[Tooltip("Minimum cnt of verified cards to trig this talent")]
			public int minCntToTrig;
		}

		// Token: 0x0200247D RID: 9341
		[Token(Token = "0x200247D")]
		private class DeckMiscModifier : Deck.Card.MiscSettingModifier
		{
			// Token: 0x0600F06E RID: 61550 RVA: 0x000589F8 File Offset: 0x00056BF8
			[Token(Token = "0x600F06E")]
			[Address(RVA = "0x6710D0", Offset = "0x66FCD0", VA = "0x1806710D0", Slot = "14")]
			public override bool IsTriggered(Deck.Card card, out Deck.Card.CardBuff.LifeType lifeType)
			{
				return default(bool);
			}

			// Token: 0x0600F06F RID: 61551 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F06F")]
			[Address(RVA = "0x671200", Offset = "0x66FE00", VA = "0x180671200")]
			public DeckMiscModifier(Deck.Card sourceCard, bool dontOccupyDeployCnt, DeckMiscTalent.Options options, AdditionalBuildCondition additionalBuildCondition, bool ignoreRespawningState)
			{
			}

			// Token: 0x0600F070 RID: 61552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F070")]
			[Address(RVA = "0x671110", Offset = "0x66FD10", VA = "0x180671110", Slot = "15")]
			public override void Preprocess(Deck deck)
			{
			}

			// Token: 0x040109E3 RID: 68067
			[Token(Token = "0x40109E3")]
			[FieldOffset(Offset = "0x38")]
			private Deck.Card m_sourceCard;

			// Token: 0x040109E4 RID: 68068
			[Token(Token = "0x40109E4")]
			[FieldOffset(Offset = "0x40")]
			private DeckMiscTalent.Options m_options;

			// Token: 0x040109E5 RID: 68069
			[Token(Token = "0x40109E5")]
			[FieldOffset(Offset = "0x48")]
			private bool m_isTriggered;
		}
	}
}
