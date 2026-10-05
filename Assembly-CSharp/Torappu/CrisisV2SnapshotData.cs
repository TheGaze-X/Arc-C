using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FE1 RID: 4065
	[Token(Token = "0x2000FE1")]
	public class CrisisV2SnapshotData
	{
		// Token: 0x06006D37 RID: 27959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D37")]
		[Address(RVA = "0x2101750", Offset = "0x2100350", VA = "0x182101750")]
		public CrisisV2SnapshotData()
		{
		}

		// Token: 0x04005636 RID: 22070
		[Token(Token = "0x4005636")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, CrisisV2SimpleSnapshot> simpleData;

		// Token: 0x04005637 RID: 22071
		[Token(Token = "0x4005637")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, CrisisV2DetailSnapshot> detailData;
	}
}
