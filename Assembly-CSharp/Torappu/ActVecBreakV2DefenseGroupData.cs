using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E65 RID: 3685
	[Token(Token = "0x2000E65")]
	public class ActVecBreakV2DefenseGroupData
	{
		// Token: 0x06006B34 RID: 27444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B34")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActVecBreakV2DefenseGroupData()
		{
		}

		// Token: 0x04004D22 RID: 19746
		[Token(Token = "0x4004D22")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04004D23 RID: 19747
		[Token(Token = "0x4004D23")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04004D24 RID: 19748
		[Token(Token = "0x4004D24")]
		[FieldOffset(Offset = "0x20")]
		public List<string> orderedStageList;
	}
}
