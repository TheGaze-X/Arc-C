using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C40 RID: 3136
	[Token(Token = "0x2000C40")]
	public class ActArchivePicItemData
	{
		// Token: 0x06006920 RID: 26912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006920")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchivePicItemData()
		{
		}

		// Token: 0x04004004 RID: 16388
		[Token(Token = "0x4004004")]
		[FieldOffset(Offset = "0x10")]
		public string picId;

		// Token: 0x04004005 RID: 16389
		[Token(Token = "0x4004005")]
		[FieldOffset(Offset = "0x18")]
		public int picSortId;
	}
}
