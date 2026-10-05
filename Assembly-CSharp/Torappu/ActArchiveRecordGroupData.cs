using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C42 RID: 3138
	[Token(Token = "0x2000C42")]
	public class ActArchiveRecordGroupData
	{
		// Token: 0x06006922 RID: 26914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006922")]
		[Address(RVA = "0x1FF8DE0", Offset = "0x1FF79E0", VA = "0x181FF8DE0")]
		public ActArchiveRecordGroupData()
		{
		}

		// Token: 0x04004007 RID: 16391
		[Token(Token = "0x4004007")]
		[FieldOffset(Offset = "0x10")]
		public string recordId;

		// Token: 0x04004008 RID: 16392
		[Token(Token = "0x4004008")]
		[FieldOffset(Offset = "0x18")]
		public List<ActArchiveRecordItemData> clientRecordItemData;
	}
}
