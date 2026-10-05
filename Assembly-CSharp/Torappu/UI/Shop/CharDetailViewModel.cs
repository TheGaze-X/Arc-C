using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A89 RID: 23177
	[Token(Token = "0x2005A89")]
	public class CharDetailViewModel : DetailCommonViewModel, IHotfixable
	{
		// Token: 0x06021B64 RID: 138084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B64")]
		[Address(RVA = "0x1C17A00", Offset = "0x1C16600", VA = "0x181C17A00")]
		public CharDetailViewModel()
		{
		}

		// Token: 0x0402E194 RID: 188820
		[Token(Token = "0x402E194")]
		[FieldOffset(Offset = "0x70")]
		public string charId;

		// Token: 0x0402E195 RID: 188821
		[Token(Token = "0x402E195")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
