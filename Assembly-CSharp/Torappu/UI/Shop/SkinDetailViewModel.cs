using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A8A RID: 23178
	[Token(Token = "0x2005A8A")]
	public class SkinDetailViewModel : DetailCommonViewModel, IHotfixable
	{
		// Token: 0x06021B65 RID: 138085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B65")]
		[Address(RVA = "0x1C27390", Offset = "0x1C25F90", VA = "0x181C27390")]
		public SkinDetailViewModel()
		{
		}

		// Token: 0x0402E196 RID: 188822
		[Token(Token = "0x402E196")]
		[FieldOffset(Offset = "0x70")]
		public string skinId;

		// Token: 0x0402E197 RID: 188823
		[Token(Token = "0x402E197")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
