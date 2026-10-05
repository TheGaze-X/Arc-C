using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C41 RID: 3137
	[Token(Token = "0x2000C41")]
	[Serializable]
	public class ActArchiveRecordData
	{
		// Token: 0x06006921 RID: 26913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006921")]
		[Address(RVA = "0x1FF8D50", Offset = "0x1FF7950", VA = "0x181FF8D50")]
		public ActArchiveRecordData()
		{
		}

		// Token: 0x04004006 RID: 16390
		[Token(Token = "0x4004006")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveRecordGroupData> record;
	}
}
