using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FA6 RID: 4006
	[Token(Token = "0x2000FA6")]
	public class PingCond
	{
		// Token: 0x06006CEF RID: 27887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CEF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PingCond()
		{
		}

		// Token: 0x04005512 RID: 21778
		[Token(Token = "0x4005512")]
		[FieldOffset(Offset = "0x10")]
		public int cond;

		// Token: 0x04005513 RID: 21779
		[Token(Token = "0x4005513")]
		[FieldOffset(Offset = "0x18")]
		public string txt;
	}
}
