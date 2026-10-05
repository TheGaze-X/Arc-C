using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200246C RID: 9324
	[Token(Token = "0x200246C")]
	public abstract class CardHoldTalent : BasicTalent
	{
		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x0600F015 RID: 61461 RVA: 0x00058740 File Offset: 0x00056940
		[Token(Token = "0x17001F33")]
		public override bool attachInDummy
		{
			[Token(Token = "0x600F015")]
			[Address(RVA = "0x66D1B0", Offset = "0x66BDB0", VA = "0x18066D1B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x0600F016 RID: 61462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F34")]
		public string cardEffectPluginName
		{
			[Token(Token = "0x600F016")]
			[Address(RVA = "0x66D210", Offset = "0x66BE10", VA = "0x18066D210")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x0600F017 RID: 61463 RVA: 0x00058758 File Offset: 0x00056958
		[Token(Token = "0x17001F35")]
		public bool hasCardEffectPlugin
		{
			[Token(Token = "0x600F017")]
			[Address(RVA = "0x66D270", Offset = "0x66BE70", VA = "0x18066D270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F018 RID: 61464
		[Token(Token = "0x600F018")]
		public abstract CardHoldTalent.CardHoldDataModifier CreateHoldDataModifier(Character character);

		// Token: 0x0600F019 RID: 61465
		[Token(Token = "0x600F019")]
		public abstract UICardEffectHolder.CardEffectPlugin CreateCardEffectPlugin(Character character, CardHoldTalent.CardHoldDataModifier modifier);

		// Token: 0x0600F01A RID: 61466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F01A")]
		[Address(RVA = "0x66D110", Offset = "0x66BD10", VA = "0x18066D110")]
		protected CardHoldTalent()
		{
		}

		// Token: 0x0600F01B RID: 61467 RVA: 0x00058770 File Offset: 0x00056970
		[Token(Token = "0x600F01B")]
		[Address(RVA = "0x66C630", Offset = "0x66B230", VA = "0x18066C630")]
		private bool <>xLuaBaseProxy_get_attachInDummy()
		{
			return default(bool);
		}

		// Token: 0x04010980 RID: 67968
		[Token(Token = "0x4010980")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _cardEffectPluginName;

		// Token: 0x04010981 RID: 67969
		[Token(Token = "0x4010981")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_attachInDummy;

		// Token: 0x04010982 RID: 67970
		[Token(Token = "0x4010982")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cardEffectPluginName;

		// Token: 0x04010983 RID: 67971
		[Token(Token = "0x4010983")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasCardEffectPlugin;

		// Token: 0x04010984 RID: 67972
		[Token(Token = "0x4010984")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200246D RID: 9325
		[Token(Token = "0x200246D")]
		public abstract class CardHoldDataModifier : ICardModifier, IHotfixable
		{
			// Token: 0x0600F01C RID: 61468
			[Token(Token = "0x600F01C")]
			public abstract void OnTick(Deck.Card card, FP deltaTime);

			// Token: 0x0600F01D RID: 61469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F01D")]
			[Address(RVA = "0x66D0B0", Offset = "0x66BCB0", VA = "0x18066D0B0")]
			protected CardHoldDataModifier()
			{
			}

			// Token: 0x04010985 RID: 67973
			[Token(Token = "0x4010985")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
