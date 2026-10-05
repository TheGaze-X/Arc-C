using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000789 RID: 1929
	[Token(Token = "0x2000789")]
	public class UseItemRequest
	{
		// Token: 0x06006405 RID: 25605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006405")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UseItemRequest()
		{
		}

		// Token: 0x0400304A RID: 12362
		[Token(Token = "0x400304A")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x0400304B RID: 12363
		[Token(Token = "0x400304B")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x0400304C RID: 12364
		[Token(Token = "0x400304C")]
		[FieldOffset(Offset = "0x20")]
		public int cnt;
	}
}
