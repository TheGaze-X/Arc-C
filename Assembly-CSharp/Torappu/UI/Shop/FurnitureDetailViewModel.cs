using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A8B RID: 23179
	[Token(Token = "0x2005A8B")]
	public class FurnitureDetailViewModel : DetailCommonViewModel, IHotfixable
	{
		// Token: 0x06021B66 RID: 138086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B66")]
		[Address(RVA = "0x1C1ACF0", Offset = "0x1C198F0", VA = "0x181C1ACF0")]
		public FurnitureDetailViewModel()
		{
		}

		// Token: 0x0402E198 RID: 188824
		[Token(Token = "0x402E198")]
		[FieldOffset(Offset = "0x70")]
		public string furnitureId;

		// Token: 0x0402E199 RID: 188825
		[Token(Token = "0x402E199")]
		[FieldOffset(Offset = "0x78")]
		public int originDiamPrice;

		// Token: 0x0402E19A RID: 188826
		[Token(Token = "0x402E19A")]
		[FieldOffset(Offset = "0x7C")]
		public int diamPrice;

		// Token: 0x0402E19B RID: 188827
		[Token(Token = "0x402E19B")]
		[FieldOffset(Offset = "0x80")]
		public int originCoinPrice;

		// Token: 0x0402E19C RID: 188828
		[Token(Token = "0x402E19C")]
		[FieldOffset(Offset = "0x84")]
		public int coinPrice;

		// Token: 0x0402E19D RID: 188829
		[Token(Token = "0x402E19D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
