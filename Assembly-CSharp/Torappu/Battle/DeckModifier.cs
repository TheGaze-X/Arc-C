using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020021EB RID: 8683
	[Token(Token = "0x20021EB")]
	public abstract class DeckModifier : IOverrideableDeckModifier
	{
		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x0600D945 RID: 55621 RVA: 0x0004EE10 File Offset: 0x0004D010
		// (set) Token: 0x0600D946 RID: 55622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001ACE")]
		public bool overrideValid
		{
			[Token(Token = "0x600D945")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D946")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x0600D947 RID: 55623 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D948 RID: 55624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001ACF")]
		public Deck.Card sourceCard
		{
			[Token(Token = "0x600D947")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D948")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x0600D949 RID: 55625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001AD0")]
		public virtual string overrideKey
		{
			[Token(Token = "0x600D949")]
			[Address(RVA = "0x35E05A0", Offset = "0x35DF1A0", VA = "0x1835E05A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x0600D94A RID: 55626 RVA: 0x0004EE28 File Offset: 0x0004D028
		[Token(Token = "0x17001AD1")]
		public virtual FP overridePriority
		{
			[Token(Token = "0x600D94A")]
			[Address(RVA = "0x35E05E0", Offset = "0x35DF1E0", VA = "0x1835E05E0", Slot = "9")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x0600D94B RID: 55627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D94B")]
		[Address(RVA = "0x1CF9670", Offset = "0x1CF8270", VA = "0x181CF9670")]
		public DeckModifier(Deck.Card sourceCard)
		{
		}

		// Token: 0x0600D94C RID: 55628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D94C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		public virtual void Preprocess(Deck deck)
		{
		}

		// Token: 0x0600D94D RID: 55629 RVA: 0x0004EE40 File Offset: 0x0004D040
		[Token(Token = "0x600D94D")]
		[Address(RVA = "0x35E0550", Offset = "0x35DF150", VA = "0x1835E0550", Slot = "11")]
		public virtual bool TryHookMaxMultiplier(Deck.Card card, out FP respawnCostMaxMultiplier)
		{
			return default(bool);
		}

		// Token: 0x0600D94E RID: 55630 RVA: 0x0004EE58 File Offset: 0x0004D058
		[Token(Token = "0x600D94E")]
		[Address(RVA = "0x35E0540", Offset = "0x35DF140", VA = "0x1835E0540", Slot = "12")]
		public virtual bool TryGetInitCostDelta(out int costDelta)
		{
			return default(bool);
		}

		// Token: 0x0600D94F RID: 55631 RVA: 0x0004EE70 File Offset: 0x0004D070
		[Token(Token = "0x600D94F")]
		[Address(RVA = "0x35E0530", Offset = "0x35DF130", VA = "0x1835E0530", Slot = "13")]
		public virtual bool TryGetCardCostDelta(Deck.Card card, out int costDelta)
		{
			return default(bool);
		}

		// Token: 0x0600D950 RID: 55632 RVA: 0x0004EE88 File Offset: 0x0004D088
		[Token(Token = "0x600D950")]
		[Address(RVA = "0x313D210", Offset = "0x313BE10", VA = "0x18313D210", Slot = "14")]
		public virtual bool TryGetDeckBuff(Deck.Card card, out IList<DeckBuff> buffs, out IList<Blackboard> blackboards)
		{
			return default(bool);
		}
	}
}
