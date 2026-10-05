using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	public class Init
	{
		// Token: 0x060001CE RID: 462 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Init()
		{
		}

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x10")]
		public string Secret_Key;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x18")]
		public string Endpoint;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x20")]
		public string Project;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x28")]
		public string Access_Key_Id;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x30")]
		public string Access_Key_Secret;
	}
}
