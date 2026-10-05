using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C29 RID: 3113
	[Token(Token = "0x2000C29")]
	public class ActArchiveChatGroupData
	{
		// Token: 0x06006908 RID: 26888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006908")]
		[Address(RVA = "0x1FF85E0", Offset = "0x1FF71E0", VA = "0x181FF85E0")]
		public ActArchiveChatGroupData()
		{
		}

		// Token: 0x04003FB2 RID: 16306
		[Token(Token = "0x4003FB2")]
		[FieldOffset(Offset = "0x10")]
		public int sortId;

		// Token: 0x04003FB3 RID: 16307
		[Token(Token = "0x4003FB3")]
		[FieldOffset(Offset = "0x18")]
		public List<ActArchiveChatItemData> chatItemList;
	}
}
