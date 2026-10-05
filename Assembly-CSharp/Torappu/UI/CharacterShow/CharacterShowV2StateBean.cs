using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DE0 RID: 24032
	[Token(Token = "0x2005DE0")]
	public class CharacterShowV2StateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005241 RID: 21057
		// (get) Token: 0x06022CFB RID: 142587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005241")]
		public CharacterShowProp prop
		{
			[Token(Token = "0x6022CFB")]
			[Address(RVA = "0x1D4ED30", Offset = "0x1D4D930", VA = "0x181D4ED30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022CFC RID: 142588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CFC")]
		[Address(RVA = "0x1D4EC90", Offset = "0x1D4D890", VA = "0x181D4EC90")]
		public CharacterShowV2StateBean()
		{
		}

		// Token: 0x0402FE8D RID: 196237
		[Token(Token = "0x402FE8D")]
		[FieldOffset(Offset = "0x10")]
		private CharacterShowProp m_prop;

		// Token: 0x0402FE8E RID: 196238
		[Token(Token = "0x402FE8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0402FE8F RID: 196239
		[Token(Token = "0x402FE8F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
