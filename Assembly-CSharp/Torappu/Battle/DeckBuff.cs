using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021E8 RID: 8680
	[Token(Token = "0x20021E8")]
	[Serializable]
	public struct DeckBuff : IHotfixable
	{
		// Token: 0x0600D93D RID: 55613 RVA: 0x0004EDB0 File Offset: 0x0004CFB0
		[Token(Token = "0x600D93D")]
		[Address(RVA = "0x35DFC50", Offset = "0x35DE850", VA = "0x1835DFC50")]
		public bool CheckAffectInDeckAndDummy()
		{
			return default(bool);
		}

		// Token: 0x0600D93E RID: 55614 RVA: 0x0004EDC8 File Offset: 0x0004CFC8
		[Token(Token = "0x600D93E")]
		[Address(RVA = "0x35DFCF0", Offset = "0x35DE8F0", VA = "0x1835DFCF0")]
		public bool CheckAffectInHand()
		{
			return default(bool);
		}

		// Token: 0x0600D93F RID: 55615 RVA: 0x0004EDE0 File Offset: 0x0004CFE0
		[Token(Token = "0x600D93F")]
		[Address(RVA = "0x35DFBC0", Offset = "0x35DE7C0", VA = "0x1835DFBC0")]
		public bool CheckAffectGetOffHand()
		{
			return default(bool);
		}

		// Token: 0x0400EA41 RID: 59969
		[Token(Token = "0x400EA41")]
		[FieldOffset(Offset = "0x0")]
		public Deck.Card.CardEffectType cardEffectType;

		// Token: 0x0400EA42 RID: 59970
		[Token(Token = "0x400EA42")]
		[FieldOffset(Offset = "0x4")]
		public Deck.Card.DeckBuffLifeType lifeType;

		// Token: 0x0400EA43 RID: 59971
		[Token(Token = "0x400EA43")]
		[FieldOffset(Offset = "0x8")]
		public bool affectInHand;

		// Token: 0x0400EA44 RID: 59972
		[Token(Token = "0x400EA44")]
		[FieldOffset(Offset = "0x9")]
		public bool affectOutOfHand;

		// Token: 0x0400EA45 RID: 59973
		[Token(Token = "0x400EA45")]
		[FieldOffset(Offset = "0xA")]
		public bool wontSpawnWhenRallyPointSwitch;

		// Token: 0x0400EA46 RID: 59974
		[Token(Token = "0x400EA46")]
		[FieldOffset(Offset = "0xB")]
		public bool showToastWhenAffect;

		// Token: 0x0400EA47 RID: 59975
		[Token(Token = "0x400EA47")]
		[FieldOffset(Offset = "0x10")]
		public string cardAnimWhenDeckbuffAdd;

		// Token: 0x0400EA48 RID: 59976
		[Token(Token = "0x400EA48")]
		[FieldOffset(Offset = "0x18")]
		public bool ignoreSpecialBuild;

		// Token: 0x0400EA49 RID: 59977
		[Token(Token = "0x400EA49")]
		[FieldOffset(Offset = "0x20")]
		public BuffData buff;

		// Token: 0x0400EA4A RID: 59978
		[Token(Token = "0x400EA4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckAffectInDeckAndDummy;

		// Token: 0x0400EA4B RID: 59979
		[Token(Token = "0x400EA4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckAffectInHand;

		// Token: 0x0400EA4C RID: 59980
		[Token(Token = "0x400EA4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckAffectGetOffHand;
	}
}
