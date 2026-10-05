using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200631B RID: 25371
	[Token(Token = "0x200631B")]
	public class AutoChessShopMainStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005630 RID: 22064
		// (get) Token: 0x06024925 RID: 149797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005630")]
		public AutoChessShopProperty shopProperty
		{
			[Token(Token = "0x6024925")]
			[Address(RVA = "0x1F70460", Offset = "0x1F6F060", VA = "0x181F70460")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024926 RID: 149798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024926")]
		[Address(RVA = "0x1F703C0", Offset = "0x1F6EFC0", VA = "0x181F703C0")]
		public AutoChessShopMainStateBean()
		{
		}

		// Token: 0x0403306A RID: 209002
		[Token(Token = "0x403306A")]
		[FieldOffset(Offset = "0x10")]
		private AutoChessShopProperty m_shopProperty;

		// Token: 0x0403306B RID: 209003
		[Token(Token = "0x403306B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_shopProperty;

		// Token: 0x0403306C RID: 209004
		[Token(Token = "0x403306C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
