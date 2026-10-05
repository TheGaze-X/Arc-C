using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BE3 RID: 11235
	[Token(Token = "0x2002BE3")]
	public class Svash2DeckAuraBehaviour : AbilityStandard.Behaviour
	{
		// Token: 0x06012F89 RID: 77705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F89")]
		[Address(RVA = "0xAEBA10", Offset = "0xAEA610", VA = "0x180AEBA10", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012F8A RID: 77706 RVA: 0x00074340 File Offset: 0x00072540
		[Token(Token = "0x6012F8A")]
		[Address(RVA = "0xAEBC70", Offset = "0xAEA870", VA = "0x180AEBC70")]
		private bool _IsCardValid(Deck.Card card)
		{
			return default(bool);
		}

		// Token: 0x06012F8B RID: 77707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F8B")]
		[Address(RVA = "0xAEBEE0", Offset = "0xAEAAE0", VA = "0x180AEBEE0")]
		public Svash2DeckAuraBehaviour()
		{
		}

		// Token: 0x06012F8C RID: 77708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F8C")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x040156AE RID: 87726
		[Token(Token = "0x40156AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<DeckBuff> _deckBuffs;

		// Token: 0x040156AF RID: 87727
		[Token(Token = "0x40156AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _overrideId;

		// Token: 0x040156B0 RID: 87728
		[Token(Token = "0x40156B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _containsCardBuff;

		// Token: 0x040156B1 RID: 87729
		[Token(Token = "0x40156B1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _cardBuffKey;

		// Token: 0x040156B2 RID: 87730
		[Token(Token = "0x40156B2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _cardBuffIsRatio;

		// Token: 0x040156B3 RID: 87731
		[Token(Token = "0x40156B3")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private CompareType _compareType;

		// Token: 0x040156B4 RID: 87732
		[Token(Token = "0x40156B4")]
		[FieldOffset(Offset = "0x48")]
		private Svash2DeckAuraBehaviour.DeckBuffCardBuffDeckArua m_cardHoldModifier;

		// Token: 0x040156B5 RID: 87733
		[Token(Token = "0x40156B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040156B6 RID: 87734
		[Token(Token = "0x40156B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__IsCardValid;

		// Token: 0x040156B7 RID: 87735
		[Token(Token = "0x40156B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BE4 RID: 11236
		[Token(Token = "0x2002BE4")]
		public class DeckBuffCardBuffDeckArua : IDeckAura, IHotfixable
		{
			// Token: 0x170029D0 RID: 10704
			// (get) Token: 0x06012F8D RID: 77709 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170029D0")]
			public string key
			{
				[Token(Token = "0x6012F8D")]
				[Address(RVA = "0xAE1680", Offset = "0xAE0280", VA = "0x180AE1680", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170029D1 RID: 10705
			// (get) Token: 0x06012F8E RID: 77710 RVA: 0x00074358 File Offset: 0x00072558
			[Token(Token = "0x170029D1")]
			public int priority
			{
				[Token(Token = "0x6012F8E")]
				[Address(RVA = "0xAE16E0", Offset = "0xAE02E0", VA = "0x180AE16E0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x06012F8F RID: 77711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012F8F")]
			[Address(RVA = "0xAE11D0", Offset = "0xADFDD0", VA = "0x180AE11D0")]
			public DeckBuffCardBuffDeckArua(Svash2DeckAuraBehaviour svash2DeckAuraBehaviour)
			{
			}

			// Token: 0x06012F90 RID: 77712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012F90")]
			[Address(RVA = "0xAE0D70", Offset = "0xADF970", VA = "0x180AE0D70", Slot = "6")]
			public void OnEnable(Deck deck)
			{
			}

			// Token: 0x06012F91 RID: 77713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012F91")]
			[Address(RVA = "0xAE0D10", Offset = "0xADF910", VA = "0x180AE0D10", Slot = "7")]
			public void OnDisable(Deck deck)
			{
			}

			// Token: 0x06012F92 RID: 77714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012F92")]
			[Address(RVA = "0xAE0C90", Offset = "0xADF890", VA = "0x180AE0C90", Slot = "8")]
			public void OnDirty(Deck deck)
			{
			}

			// Token: 0x06012F93 RID: 77715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012F93")]
			[Address(RVA = "0xAE0DF0", Offset = "0xADF9F0", VA = "0x180AE0DF0")]
			private void _ApplyByFilter(Deck deck)
			{
			}

			// Token: 0x040156B8 RID: 87736
			[Token(Token = "0x40156B8")]
			[FieldOffset(Offset = "0x10")]
			private List<DeckBuff> m_deckBuffs;

			// Token: 0x040156B9 RID: 87737
			[Token(Token = "0x40156B9")]
			[FieldOffset(Offset = "0x18")]
			private List<Blackboard> m_blackboards;

			// Token: 0x040156BA RID: 87738
			[Token(Token = "0x40156BA")]
			[FieldOffset(Offset = "0x20")]
			private Blackboard m_cardBuffBlackboard;

			// Token: 0x040156BB RID: 87739
			[Token(Token = "0x40156BB")]
			[FieldOffset(Offset = "0x28")]
			private string m_buffKey;

			// Token: 0x040156BC RID: 87740
			[Token(Token = "0x40156BC")]
			[FieldOffset(Offset = "0x30")]
			private bool m_isRatio;

			// Token: 0x040156BD RID: 87741
			[Token(Token = "0x40156BD")]
			[FieldOffset(Offset = "0x31")]
			private bool m_containsCardBuff;

			// Token: 0x040156BE RID: 87742
			[Token(Token = "0x40156BE")]
			[FieldOffset(Offset = "0x38")]
			private Func<Deck.Card, bool> m_cardFilter;

			// Token: 0x040156C1 RID: 87745
			[Token(Token = "0x40156C1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_key;

			// Token: 0x040156C2 RID: 87746
			[Token(Token = "0x40156C2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_priority;

			// Token: 0x040156C3 RID: 87747
			[Token(Token = "0x40156C3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040156C4 RID: 87748
			[Token(Token = "0x40156C4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnEnable;

			// Token: 0x040156C5 RID: 87749
			[Token(Token = "0x40156C5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnDisable;

			// Token: 0x040156C6 RID: 87750
			[Token(Token = "0x40156C6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnDirty;

			// Token: 0x040156C7 RID: 87751
			[Token(Token = "0x40156C7")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__ApplyByFilter;
		}
	}
}
