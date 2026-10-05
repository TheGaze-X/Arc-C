using System;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B1D RID: 23325
	[Token(Token = "0x2005B1D")]
	public class QCShopREPGood
	{
		// Token: 0x17004F3E RID: 20286
		// (get) Token: 0x06021E06 RID: 138758 RVA: 0x000BB848 File Offset: 0x000B9A48
		[Token(Token = "0x17004F3E")]
		public bool isSoldOut
		{
			[Token(Token = "0x6021E06")]
			[Address(RVA = "0x1C5E710", Offset = "0x1C5D310", VA = "0x181C5E710")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004F3F RID: 20287
		// (get) Token: 0x06021E07 RID: 138759 RVA: 0x000BB860 File Offset: 0x000B9A60
		[Token(Token = "0x17004F3F")]
		public int RemainCount
		{
			[Token(Token = "0x6021E07")]
			[Address(RVA = "0x1C5E6D0", Offset = "0x1C5D2D0", VA = "0x181C5E6D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06021E08 RID: 138760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E08")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public QCShopREPGood()
		{
		}

		// Token: 0x0402E69B RID: 190107
		[Token(Token = "0x402E69B")]
		[FieldOffset(Offset = "0x10")]
		public REPGood goodData;

		// Token: 0x0402E69C RID: 190108
		[Token(Token = "0x402E69C")]
		[FieldOffset(Offset = "0x18")]
		public PlayerGoodItemData playerShop;
	}
}
