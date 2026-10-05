using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public class Auto_Url
	{
		// Token: 0x060001CF RID: 463 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Auto_Url()
		{
		}

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x10")]
		public List<string> HTTP;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x18")]
		public List<string> PING;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x20")]
		public List<string> TCPPING;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x28")]
		public List<string> MTR;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x30")]
		public List<string> DNS;
	}
}
