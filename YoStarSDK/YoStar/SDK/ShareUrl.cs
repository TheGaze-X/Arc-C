using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	public class ShareUrl : ShareContent
	{
		// Token: 0x06000251 RID: 593 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private ShareUrl()
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x5BE2240", Offset = "0x5BE0E40", VA = "0x185BE2240")]
		public ShareUrl(string title, string url)
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		public string getUrl()
		{
			return null;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
		public string getTitle()
		{
			return null;
		}

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x18")]
		private string url;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x20")]
		private string title;
	}
}
