using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EA1 RID: 3745
	[Token(Token = "0x2000EA1")]
	public class Act4funPerformGroupInfo
	{
		// Token: 0x06006B73 RID: 27507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B73")]
		[Address(RVA = "0x1FF7440", Offset = "0x1FF6040", VA = "0x181FF7440")]
		public Act4funPerformGroupInfo()
		{
		}

		// Token: 0x04004F18 RID: 20248
		[Token(Token = "0x4004F18")]
		[FieldOffset(Offset = "0x10")]
		public string performGroupId;

		// Token: 0x04004F19 RID: 20249
		[Token(Token = "0x4004F19")]
		[FieldOffset(Offset = "0x18")]
		public List<string> performIds;
	}
}
