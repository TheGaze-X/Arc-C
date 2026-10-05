using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200087A RID: 2170
	[Token(Token = "0x200087A")]
	public class LowGoodGroupUnlock
	{
		// Token: 0x06006516 RID: 25878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006516")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LowGoodGroupUnlock()
		{
		}

		// Token: 0x040031EB RID: 12779
		[Token(Token = "0x40031EB")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x040031EC RID: 12780
		[Token(Token = "0x40031EC")]
		[FieldOffset(Offset = "0x18")]
		public int lggThreshold;
	}
}
