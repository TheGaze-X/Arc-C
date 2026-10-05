using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E07 RID: 3591
	[Token(Token = "0x2000E07")]
	public class ActivityEnemyDuelSingleCommentData
	{
		// Token: 0x06006ADA RID: 27354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelSingleCommentData()
		{
		}

		// Token: 0x04004A8C RID: 19084
		[Token(Token = "0x4004A8C")]
		[FieldOffset(Offset = "0x10")]
		public string commentId;

		// Token: 0x04004A8D RID: 19085
		[Token(Token = "0x4004A8D")]
		[FieldOffset(Offset = "0x18")]
		public int priority;

		// Token: 0x04004A8E RID: 19086
		[Token(Token = "0x4004A8E")]
		[FieldOffset(Offset = "0x20")]
		public string template;

		// Token: 0x04004A8F RID: 19087
		[Token(Token = "0x4004A8F")]
		[FieldOffset(Offset = "0x28")]
		public List<string> param;

		// Token: 0x04004A90 RID: 19088
		[Token(Token = "0x4004A90")]
		[FieldOffset(Offset = "0x30")]
		public string commentText;
	}
}
