using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B7D RID: 11133
	[Token(Token = "0x2002B7D")]
	public class Angel2CharacterMenuRelativeAbility : CharacterMenuRelativeAbility, IEffectSource
	{
		// Token: 0x06012B6D RID: 76653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B6D")]
		[Address(RVA = "0xAAB4F0", Offset = "0xAAA0F0", VA = "0x180AAB4F0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012B6E RID: 76654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B6E")]
		[Address(RVA = "0xAAB650", Offset = "0xAAA250", VA = "0x180AAB650", Slot = "96")]
		protected override void FilterCandidateCards(Deck cardDeck, HashSet<Deck.Card> validCards)
		{
		}

		// Token: 0x06012B6F RID: 76655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B6F")]
		[Address(RVA = "0xAABCB0", Offset = "0xAAA8B0", VA = "0x180AABCB0")]
		public Angel2CharacterMenuRelativeAbility()
		{
		}

		// Token: 0x06012B70 RID: 76656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B70")]
		[Address(RVA = "0xAABB90", Offset = "0xAAA790", VA = "0x180AABB90")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012B71 RID: 76657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B71")]
		[Address(RVA = "0xAABBA0", Offset = "0xAAA7A0", VA = "0x180AABBA0")]
		private void <>xLuaBaseProxy_FilterCandidateCards(Deck P0, HashSet<Deck.Card> P1)
		{
		}

		// Token: 0x04015252 RID: 86610
		[Token(Token = "0x4015252")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private string _limitationBlackboardKey;

		// Token: 0x04015253 RID: 86611
		[Token(Token = "0x4015253")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private string _cntSharedBlackboardKey;

		// Token: 0x04015254 RID: 86612
		[Token(Token = "0x4015254")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private string _selectorAbilityNameEnemyWithin;

		// Token: 0x04015255 RID: 86613
		[Token(Token = "0x4015255")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private string _selectorAbilityNameWithoutEnemy;

		// Token: 0x04015256 RID: 86614
		[Token(Token = "0x4015256")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private string _selectorFallback;

		// Token: 0x04015257 RID: 86615
		[Token(Token = "0x4015257")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private string _secondarySelectorAbilityName;

		// Token: 0x04015258 RID: 86616
		[Token(Token = "0x4015258")]
		[FieldOffset(Offset = "0x180")]
		private uint m_targetCardUid;

		// Token: 0x04015259 RID: 86617
		[Token(Token = "0x4015259")]
		[FieldOffset(Offset = "0x188")]
		private Ability m_secondarySelectorAbility;

		// Token: 0x0401525A RID: 86618
		[Token(Token = "0x401525A")]
		[FieldOffset(Offset = "0x190")]
		private List<Deck.Card> m_potentialList;

		// Token: 0x0401525B RID: 86619
		[Token(Token = "0x401525B")]
		[FieldOffset(Offset = "0x198")]
		private Character ownerCharacter;

		// Token: 0x0401525C RID: 86620
		[Token(Token = "0x401525C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x0401525D RID: 86621
		[Token(Token = "0x401525D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FilterCandidateCards;

		// Token: 0x0401525E RID: 86622
		[Token(Token = "0x401525E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
