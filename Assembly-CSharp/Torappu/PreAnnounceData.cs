using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E95 RID: 3733
	[Token(Token = "0x2000E95")]
	public class PreAnnounceData
	{
		// Token: 0x06006B66 RID: 27494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B66")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PreAnnounceData()
		{
		}

		// Token: 0x04004ED7 RID: 20183
		[Token(Token = "0x4004ED7")]
		[FieldOffset(Offset = "0x10")]
		public string preAnnounceId;

		// Token: 0x04004ED8 RID: 20184
		[Token(Token = "0x4004ED8")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04004ED9 RID: 20185
		[Token(Token = "0x4004ED9")]
		[FieldOffset(Offset = "0x20")]
		public string content;
	}
}
