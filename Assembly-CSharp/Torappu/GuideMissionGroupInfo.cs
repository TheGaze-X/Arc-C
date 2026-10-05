using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001108 RID: 4360
	[Token(Token = "0x2001108")]
	public class GuideMissionGroupInfo
	{
		// Token: 0x06006ECA RID: 28362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GuideMissionGroupInfo()
		{
		}

		// Token: 0x04005D7A RID: 23930
		[Token(Token = "0x4005D7A")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005D7B RID: 23931
		[Token(Token = "0x4005D7B")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04005D7C RID: 23932
		[Token(Token = "0x4005D7C")]
		[FieldOffset(Offset = "0x20")]
		public string shortName;

		// Token: 0x04005D7D RID: 23933
		[Token(Token = "0x4005D7D")]
		[FieldOffset(Offset = "0x28")]
		public string unlockDesc;
	}
}
