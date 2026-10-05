using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A87 RID: 23175
	[Token(Token = "0x2005A87")]
	public class DetailMonthlySubViewModel : DetailCommonViewModel, IHotfixable
	{
		// Token: 0x06021B62 RID: 138082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B62")]
		[Address(RVA = "0x1C18810", Offset = "0x1C17410", VA = "0x181C18810")]
		public DetailMonthlySubViewModel()
		{
		}

		// Token: 0x0402E18F RID: 188815
		[Token(Token = "0x402E18F")]
		[FieldOffset(Offset = "0x70")]
		public PlayerMonthlySubPer playerInfo;

		// Token: 0x0402E190 RID: 188816
		[Token(Token = "0x402E190")]
		[FieldOffset(Offset = "0x78")]
		public MonthlySubItem subItem;

		// Token: 0x0402E191 RID: 188817
		[Token(Token = "0x402E191")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
