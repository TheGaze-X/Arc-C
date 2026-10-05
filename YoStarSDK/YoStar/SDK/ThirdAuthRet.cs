using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public class ThirdAuthRet
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ThirdAuthRet()
		{
		}

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, object> R_DATA;
	}
}
