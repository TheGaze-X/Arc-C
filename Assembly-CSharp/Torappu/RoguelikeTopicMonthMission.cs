using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011ED RID: 4589
	[Token(Token = "0x20011ED")]
	public class RoguelikeTopicMonthMission
	{
		// Token: 0x06006FDE RID: 28638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FDE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicMonthMission()
		{
		}

		// Token: 0x0400629D RID: 25245
		[Token(Token = "0x400629D")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400629E RID: 25246
		[Token(Token = "0x400629E")]
		[FieldOffset(Offset = "0x18")]
		public string taskName;

		// Token: 0x0400629F RID: 25247
		[Token(Token = "0x400629F")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeGameMonthTaskClass taskClass;

		// Token: 0x040062A0 RID: 25248
		[Token(Token = "0x40062A0")]
		[FieldOffset(Offset = "0x24")]
		public int innerClassWeight;

		// Token: 0x040062A1 RID: 25249
		[Token(Token = "0x40062A1")]
		[FieldOffset(Offset = "0x28")]
		public string template;

		// Token: 0x040062A2 RID: 25250
		[Token(Token = "0x40062A2")]
		[FieldOffset(Offset = "0x30")]
		public string[] paramList;

		// Token: 0x040062A3 RID: 25251
		[Token(Token = "0x40062A3")]
		[FieldOffset(Offset = "0x38")]
		public string desc;

		// Token: 0x040062A4 RID: 25252
		[Token(Token = "0x40062A4")]
		[FieldOffset(Offset = "0x40")]
		public int tokenRewardNum;
	}
}
