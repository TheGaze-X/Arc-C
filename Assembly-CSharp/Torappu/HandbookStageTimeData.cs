using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200109C RID: 4252
	[Token(Token = "0x200109C")]
	[Serializable]
	public class HandbookStageTimeData
	{
		// Token: 0x06006E28 RID: 28200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E28")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandbookStageTimeData()
		{
		}

		// Token: 0x04005ABA RID: 23226
		[Token(Token = "0x4005ABA")]
		[FieldOffset(Offset = "0x10")]
		public long timestamp;

		// Token: 0x04005ABB RID: 23227
		[Token(Token = "0x4005ABB")]
		[FieldOffset(Offset = "0x18")]
		public HashSet<string> charSet;
	}
}
