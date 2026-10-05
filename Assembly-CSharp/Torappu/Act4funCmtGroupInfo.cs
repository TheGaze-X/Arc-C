using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EAA RID: 3754
	[Token(Token = "0x2000EAA")]
	public class Act4funCmtGroupInfo
	{
		// Token: 0x06006B7C RID: 27516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B7C")]
		[Address(RVA = "0x1FF6EB0", Offset = "0x1FF5AB0", VA = "0x181FF6EB0")]
		public Act4funCmtGroupInfo()
		{
		}

		// Token: 0x04004F49 RID: 20297
		[Token(Token = "0x4004F49")]
		[FieldOffset(Offset = "0x10")]
		public string cmtGroupId;

		// Token: 0x04004F4A RID: 20298
		[Token(Token = "0x4004F4A")]
		[FieldOffset(Offset = "0x18")]
		public List<Act4funCmtInfo> cmtList;
	}
}
