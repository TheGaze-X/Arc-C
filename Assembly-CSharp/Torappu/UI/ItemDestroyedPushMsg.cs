using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003713 RID: 14099
	[Token(Token = "0x2003713")]
	public class ItemDestroyedPushMsg
	{
		// Token: 0x06016612 RID: 91666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016612")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ItemDestroyedPushMsg()
		{
		}

		// Token: 0x0401AEB7 RID: 110263
		[Token(Token = "0x401AEB7")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x0401AEB8 RID: 110264
		[Token(Token = "0x401AEB8")]
		[FieldOffset(Offset = "0x18")]
		public int count;

		// Token: 0x0401AEB9 RID: 110265
		[Token(Token = "0x401AEB9")]
		[FieldOffset(Offset = "0x20")]
		public string reason;
	}
}
