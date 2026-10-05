using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C34 RID: 3124
	[Token(Token = "0x2000C34")]
	public class ActArchiveEndbookData
	{
		// Token: 0x06006912 RID: 26898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006912")]
		[Address(RVA = "0x1FF89D0", Offset = "0x1FF75D0", VA = "0x181FF89D0")]
		public ActArchiveEndbookData()
		{
		}

		// Token: 0x04003FE0 RID: 16352
		[Token(Token = "0x4003FE0")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveEndbookGroupData> endbook;
	}
}
