using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001049 RID: 4169
	[Token(Token = "0x2001049")]
	public class FavorTable
	{
		// Token: 0x06006DB2 RID: 28082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB2")]
		[Address(RVA = "0x2104490", Offset = "0x2103090", VA = "0x182104490")]
		public FavorTable()
		{
		}

		// Token: 0x04005891 RID: 22673
		[Token(Token = "0x4005891")]
		[FieldOffset(Offset = "0x10")]
		public int maxFavor;

		// Token: 0x04005892 RID: 22674
		[Token(Token = "0x4005892")]
		[FieldOffset(Offset = "0x18")]
		public FavorDataFrames favorFrames;
	}
}
