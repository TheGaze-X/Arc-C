using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	public class PingResponse
	{
		// Token: 0x06000506 RID: 1286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PingResponse()
		{
		}

		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x14")]
		public int interval;

		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0x18")]
		public string message;
	}
}
