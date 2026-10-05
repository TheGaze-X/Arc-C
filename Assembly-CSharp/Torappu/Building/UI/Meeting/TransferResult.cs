using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D0A RID: 7434
	[Token(Token = "0x2001D0A")]
	public class TransferResult
	{
		// Token: 0x0600B777 RID: 46967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B777")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TransferResult()
		{
		}

		// Token: 0x0400B59B RID: 46491
		[Token(Token = "0x400B59B")]
		[FieldOffset(Offset = "0x10")]
		public long endTime;

		// Token: 0x0400B59C RID: 46492
		[Token(Token = "0x400B59C")]
		[FieldOffset(Offset = "0x18")]
		public int visitNumber;

		// Token: 0x0400B59D RID: 46493
		[Token(Token = "0x400B59D")]
		[FieldOffset(Offset = "0x1C")]
		public int socialPoint;

		// Token: 0x0400B59E RID: 46494
		[Token(Token = "0x400B59E")]
		[FieldOffset(Offset = "0x20")]
		public List<IPeer> visitors;
	}
}
