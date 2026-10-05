using System;
using Il2CppDummyDll;

namespace YoStar.SDK.Bean
{
	// Token: 0x0200029F RID: 671
	[Token(Token = "0x200029F")]
	public class CreditCardData
	{
		// Token: 0x06000FB1 RID: 4017 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CreditCardData()
		{
		}

		// Token: 0x04000CF4 RID: 3316
		[Token(Token = "0x4000CF4")]
		[FieldOffset(Offset = "0x10")]
		public string CardNo;

		// Token: 0x04000CF5 RID: 3317
		[Token(Token = "0x4000CF5")]
		[FieldOffset(Offset = "0x18")]
		public string CardSeq;

		// Token: 0x04000CF6 RID: 3318
		[Token(Token = "0x4000CF6")]
		[FieldOffset(Offset = "0x20")]
		public string Expire;

		// Token: 0x04000CF7 RID: 3319
		[Token(Token = "0x4000CF7")]
		[FieldOffset(Offset = "0x28")]
		public string HolderName;
	}
}
