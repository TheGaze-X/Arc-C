using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012E1 RID: 4833
	[Token(Token = "0x20012E1")]
	public class SandboxV2BaseUpdateCondition
	{
		// Token: 0x0600725C RID: 29276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2BaseUpdateCondition()
		{
		}

		// Token: 0x04006AC0 RID: 27328
		[Token(Token = "0x4006AC0")]
		[FieldOffset(Offset = "0x10")]
		public string desc;

		// Token: 0x04006AC1 RID: 27329
		[Token(Token = "0x4006AC1")]
		[FieldOffset(Offset = "0x18")]
		public string limitCond;

		// Token: 0x04006AC2 RID: 27330
		[Token(Token = "0x4006AC2")]
		[FieldOffset(Offset = "0x20")]
		public string[] param;
	}
}
