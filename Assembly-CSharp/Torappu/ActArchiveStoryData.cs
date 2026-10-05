using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C46 RID: 3142
	[Token(Token = "0x2000C46")]
	[Serializable]
	public class ActArchiveStoryData
	{
		// Token: 0x06006926 RID: 26918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006926")]
		[Address(RVA = "0x1FF8F00", Offset = "0x1FF7B00", VA = "0x181FF8F00")]
		public ActArchiveStoryData()
		{
		}

		// Token: 0x04004016 RID: 16406
		[Token(Token = "0x4004016")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveStoryItemData> stories;
	}
}
