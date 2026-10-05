using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C4F RID: 3151
	[Token(Token = "0x2000C4F")]
	public class ActArchiveWrathData
	{
		// Token: 0x06006933 RID: 26931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006933")]
		[Address(RVA = "0x1FF9190", Offset = "0x1FF7D90", VA = "0x181FF9190")]
		public ActArchiveWrathData()
		{
		}

		// Token: 0x04004031 RID: 16433
		[Token(Token = "0x4004031")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveWrathItemData> wraths;
	}
}
