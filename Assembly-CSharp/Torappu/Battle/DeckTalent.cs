using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200247E RID: 9342
	[Token(Token = "0x200247E")]
	public abstract class DeckTalent : BasicTalent
	{
		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x0600F071 RID: 61553 RVA: 0x00058A10 File Offset: 0x00056C10
		[Token(Token = "0x17001F44")]
		public override bool attachInDummy
		{
			[Token(Token = "0x600F071")]
			[Address(RVA = "0x6734F0", Offset = "0x6720F0", VA = "0x1806734F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F072 RID: 61554
		[Token(Token = "0x600F072")]
		public abstract DeckModifier CreateDeckModifier(Deck.Card sourceCard);

		// Token: 0x0600F073 RID: 61555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F073")]
		[Address(RVA = "0x673450", Offset = "0x672050", VA = "0x180673450")]
		protected DeckTalent()
		{
		}

		// Token: 0x0600F074 RID: 61556 RVA: 0x00058A28 File Offset: 0x00056C28
		[Token(Token = "0x600F074")]
		[Address(RVA = "0x66C630", Offset = "0x66B230", VA = "0x18066C630")]
		private bool <>xLuaBaseProxy_get_attachInDummy()
		{
			return default(bool);
		}

		// Token: 0x040109E6 RID: 68070
		[Token(Token = "0x40109E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_attachInDummy;

		// Token: 0x040109E7 RID: 68071
		[Token(Token = "0x40109E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
