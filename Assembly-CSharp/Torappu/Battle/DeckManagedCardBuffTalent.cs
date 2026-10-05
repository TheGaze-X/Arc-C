using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200247A RID: 9338
	[Token(Token = "0x200247A")]
	public class DeckManagedCardBuffTalent : BasicTalent
	{
		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x0600F05C RID: 61532 RVA: 0x00058920 File Offset: 0x00056B20
		[Token(Token = "0x17001F3F")]
		public override bool attachInDummy
		{
			[Token(Token = "0x600F05C")]
			[Address(RVA = "0x671050", Offset = "0x66FC50", VA = "0x180671050", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x0600F05D RID: 61533 RVA: 0x00058938 File Offset: 0x00056B38
		[Token(Token = "0x17001F40")]
		public override bool affectInDeck
		{
			[Token(Token = "0x600F05D")]
			[Address(RVA = "0x670FF0", Offset = "0x66FBF0", VA = "0x180670FF0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F05E RID: 61534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F05E")]
		[Address(RVA = "0x670C90", Offset = "0x66F890", VA = "0x180670C90")]
		public void RegisterDeckManagedCardBuff(Deck deck, Deck.Card card)
		{
		}

		// Token: 0x0600F05F RID: 61535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F05F")]
		[Address(RVA = "0x670B00", Offset = "0x66F700", VA = "0x180670B00")]
		private Deck.Card.CardBuff GetCardBuff(Deck.Card card)
		{
			return null;
		}

		// Token: 0x0600F060 RID: 61536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F060")]
		[Address(RVA = "0x670F40", Offset = "0x66FB40", VA = "0x180670F40")]
		public DeckManagedCardBuffTalent()
		{
		}

		// Token: 0x0600F061 RID: 61537 RVA: 0x00058950 File Offset: 0x00056B50
		[Token(Token = "0x600F061")]
		[Address(RVA = "0x66C630", Offset = "0x66B230", VA = "0x18066C630")]
		private bool <>xLuaBaseProxy_get_attachInDummy()
		{
			return default(bool);
		}

		// Token: 0x0600F062 RID: 61538 RVA: 0x00058968 File Offset: 0x00056B68
		[Token(Token = "0x600F062")]
		[Address(RVA = "0x66C3F0", Offset = "0x66AFF0", VA = "0x18066C3F0")]
		private bool <>xLuaBaseProxy_get_affectInDeck()
		{
			return default(bool);
		}

		// Token: 0x040109C8 RID: 68040
		[Token(Token = "0x40109C8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _cardBuffKey;

		// Token: 0x040109C9 RID: 68041
		[Token(Token = "0x40109C9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Deck.DeckManagedCardBuffController.ManageType _manageType;

		// Token: 0x040109CA RID: 68042
		[Token(Token = "0x40109CA")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool _excludeTokenAndTrap;

		// Token: 0x040109CB RID: 68043
		[Token(Token = "0x40109CB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private DeckSelector _selector;

		// Token: 0x040109CC RID: 68044
		[Token(Token = "0x40109CC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _createCardBuffByBlackboard;

		// Token: 0x040109CD RID: 68045
		[Token(Token = "0x40109CD")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Deck.Card.CardBuff.LifeType _lifeType;

		// Token: 0x040109CE RID: 68046
		[Token(Token = "0x40109CE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _isRatio;

		// Token: 0x040109CF RID: 68047
		[Token(Token = "0x40109CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_attachInDummy;

		// Token: 0x040109D0 RID: 68048
		[Token(Token = "0x40109D0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_affectInDeck;

		// Token: 0x040109D1 RID: 68049
		[Token(Token = "0x40109D1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterDeckManagedCardBuff;

		// Token: 0x040109D2 RID: 68050
		[Token(Token = "0x40109D2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCardBuff;

		// Token: 0x040109D3 RID: 68051
		[Token(Token = "0x40109D3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
