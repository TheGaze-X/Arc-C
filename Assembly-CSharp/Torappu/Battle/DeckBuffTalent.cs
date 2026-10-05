using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002473 RID: 9331
	[Token(Token = "0x2002473")]
	public class DeckBuffTalent : DeckTalent
	{
		// Token: 0x0600F043 RID: 61507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F043")]
		[Address(RVA = "0x6707F0", Offset = "0x66F3F0", VA = "0x1806707F0", Slot = "33")]
		public override DeckModifier CreateDeckModifier(Deck.Card sourceCard)
		{
			return null;
		}

		// Token: 0x0600F044 RID: 61508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F044")]
		[Address(RVA = "0x670920", Offset = "0x66F520", VA = "0x180670920", Slot = "31")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600F045 RID: 61509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F045")]
		[Address(RVA = "0x670A70", Offset = "0x66F670", VA = "0x180670A70")]
		public DeckBuffTalent()
		{
		}

		// Token: 0x0600F046 RID: 61510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F046")]
		[Address(RVA = "0x66B730", Offset = "0x66A330", VA = "0x18066B730")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x040109A9 RID: 68009
		[Token(Token = "0x40109A9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DeckBuffTalent.Options _options;

		// Token: 0x040109AA RID: 68010
		[Token(Token = "0x40109AA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected DeckBuff[] _deckBuffs;

		// Token: 0x040109AB RID: 68011
		[Token(Token = "0x40109AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateDeckModifier;

		// Token: 0x040109AC RID: 68012
		[Token(Token = "0x40109AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x040109AD RID: 68013
		[Token(Token = "0x40109AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002474 RID: 9332
		[Token(Token = "0x2002474")]
		[Serializable]
		public class Options
		{
			// Token: 0x0600F047 RID: 61511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F047")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x040109AE RID: 68014
			[Token(Token = "0x40109AE")]
			[FieldOffset(Offset = "0x10")]
			public DeckSelector selector;

			// Token: 0x040109AF RID: 68015
			[Token(Token = "0x40109AF")]
			[FieldOffset(Offset = "0x40")]
			[Tooltip("Minimum cnt of verified cards to trig this talent")]
			public int minCntToTrig;

			// Token: 0x040109B0 RID: 68016
			[Token(Token = "0x40109B0")]
			[FieldOffset(Offset = "0x44")]
			public bool useOtherSelectorWhenGetBuff;

			// Token: 0x040109B1 RID: 68017
			[Token(Token = "0x40109B1")]
			[FieldOffset(Offset = "0x48")]
			public DeckSelector selectorWhenGetBuff;
		}

		// Token: 0x02002475 RID: 9333
		[Token(Token = "0x2002475")]
		private class DeckBuffModifier : DeckModifier
		{
			// Token: 0x0600F048 RID: 61512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F048")]
			[Address(RVA = "0x6705E0", Offset = "0x66F1E0", VA = "0x1806705E0")]
			public DeckBuffModifier(Deck.Card sourceCard, IList<DeckBuff> deckBuffs, DeckBuffTalent.Options options, Blackboard blackboard)
			{
			}

			// Token: 0x0600F049 RID: 61513 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F049")]
			[Address(RVA = "0x670400", Offset = "0x66F000", VA = "0x180670400", Slot = "10")]
			public override void Preprocess(Deck deck)
			{
			}

			// Token: 0x0600F04A RID: 61514 RVA: 0x00058878 File Offset: 0x00056A78
			[Token(Token = "0x600F04A")]
			[Address(RVA = "0x670500", Offset = "0x66F100", VA = "0x180670500", Slot = "14")]
			public override bool TryGetDeckBuff(Deck.Card card, out IList<DeckBuff> buffs, out IList<Blackboard> blackboards)
			{
				return default(bool);
			}

			// Token: 0x040109B2 RID: 68018
			[Token(Token = "0x40109B2")]
			[FieldOffset(Offset = "0x20")]
			private IList<DeckBuff> m_deckBuffs;

			// Token: 0x040109B3 RID: 68019
			[Token(Token = "0x40109B3")]
			[FieldOffset(Offset = "0x28")]
			private IList<Blackboard> m_blackboard;

			// Token: 0x040109B4 RID: 68020
			[Token(Token = "0x40109B4")]
			[FieldOffset(Offset = "0x30")]
			private DeckBuffTalent.Options m_options;

			// Token: 0x040109B5 RID: 68021
			[Token(Token = "0x40109B5")]
			[FieldOffset(Offset = "0x38")]
			private bool m_isTriggered;
		}
	}
}
