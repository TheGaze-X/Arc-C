using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200078E RID: 1934
	[Token(Token = "0x200078E")]
	public class UseRenameCardRequest
	{
		// Token: 0x0600640E RID: 25614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UseRenameCardRequest()
		{
		}

		// Token: 0x04003056 RID: 12374
		[Token(Token = "0x4003056")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04003057 RID: 12375
		[Token(Token = "0x4003057")]
		[FieldOffset(Offset = "0x18")]
		public int instId;

		// Token: 0x04003058 RID: 12376
		[Token(Token = "0x4003058")]
		[FieldOffset(Offset = "0x20")]
		public string nickName;
	}
}
