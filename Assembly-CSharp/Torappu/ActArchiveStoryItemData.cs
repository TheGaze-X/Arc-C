using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C47 RID: 3143
	[Token(Token = "0x2000C47")]
	public class ActArchiveStoryItemData
	{
		// Token: 0x06006927 RID: 26919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006927")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveStoryItemData()
		{
		}

		// Token: 0x04004017 RID: 16407
		[Token(Token = "0x4004017")]
		[FieldOffset(Offset = "0x10")]
		public string storyId;

		// Token: 0x04004018 RID: 16408
		[Token(Token = "0x4004018")]
		[FieldOffset(Offset = "0x18")]
		public int storySortId;
	}
}
