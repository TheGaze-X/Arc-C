using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010EB RID: 4331
	[Token(Token = "0x20010EB")]
	public class MedalTypeData
	{
		// Token: 0x06006E92 RID: 28306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E92")]
		[Address(RVA = "0x2107BC0", Offset = "0x21067C0", VA = "0x182107BC0")]
		public MedalTypeData()
		{
		}

		// Token: 0x04005CD7 RID: 23767
		[Token(Token = "0x4005CD7")]
		[FieldOffset(Offset = "0x10")]
		public string medalGroupId;

		// Token: 0x04005CD8 RID: 23768
		[Token(Token = "0x4005CD8")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04005CD9 RID: 23769
		[Token(Token = "0x4005CD9")]
		[FieldOffset(Offset = "0x20")]
		public string medalName;

		// Token: 0x04005CDA RID: 23770
		[Token(Token = "0x4005CDA")]
		[FieldOffset(Offset = "0x28")]
		public List<MedalGroupData> groupData;
	}
}
