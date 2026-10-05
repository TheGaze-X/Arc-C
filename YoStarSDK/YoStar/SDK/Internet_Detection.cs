using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public class Internet_Detection
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Internet_Detection()
		{
		}

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x10")]
		public Init Init;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x18")]
		public string Internet_Url;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x20")]
		public Auto_Url Auto_Url;
	}
}
