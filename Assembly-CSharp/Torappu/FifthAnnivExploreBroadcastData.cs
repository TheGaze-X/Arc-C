using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001050 RID: 4176
	[Token(Token = "0x2001050")]
	public class FifthAnnivExploreBroadcastData
	{
		// Token: 0x06006DB8 RID: 28088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FifthAnnivExploreBroadcastData()
		{
		}

		// Token: 0x040058BF RID: 22719
		[Token(Token = "0x40058BF")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040058C0 RID: 22720
		[Token(Token = "0x40058C0")]
		[FieldOffset(Offset = "0x18")]
		public int eventCount;

		// Token: 0x040058C1 RID: 22721
		[Token(Token = "0x40058C1")]
		[FieldOffset(Offset = "0x20")]
		public string stageId;

		// Token: 0x040058C2 RID: 22722
		[Token(Token = "0x40058C2")]
		[FieldOffset(Offset = "0x28")]
		public string content;
	}
}
