using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011E8 RID: 4584
	[Token(Token = "0x20011E8")]
	public class RoguelikeTopicEnroll
	{
		// Token: 0x06006FD6 RID: 28630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FD6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicEnroll()
		{
		}

		// Token: 0x0400627A RID: 25210
		[Token(Token = "0x400627A")]
		[FieldOffset(Offset = "0x10")]
		public string enrollId;

		// Token: 0x0400627B RID: 25211
		[Token(Token = "0x400627B")]
		[FieldOffset(Offset = "0x18")]
		public long enrollTime;

		// Token: 0x0400627C RID: 25212
		[Token(Token = "0x400627C")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeEnrollType enrollType;

		// Token: 0x0400627D RID: 25213
		[Token(Token = "0x400627D")]
		[FieldOffset(Offset = "0x28")]
		public long enrollNoticeEndTime;
	}
}
