using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000835 RID: 2101
	[Token(Token = "0x2000835")]
	public class ChangeSecretaryRequest
	{
		// Token: 0x060064CD RID: 25805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064CD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangeSecretaryRequest()
		{
		}

		// Token: 0x0400313B RID: 12603
		[Token(Token = "0x400313B")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x0400313C RID: 12604
		[Token(Token = "0x400313C")]
		[FieldOffset(Offset = "0x18")]
		public string skinId;
	}
}
