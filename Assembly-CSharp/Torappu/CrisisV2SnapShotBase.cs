using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000FDD RID: 4061
	[Token(Token = "0x2000FDD")]
	public class CrisisV2SnapShotBase
	{
		// Token: 0x06006D33 RID: 27955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D33")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2SnapShotBase()
		{
		}

		// Token: 0x04005629 RID: 22057
		[Token(Token = "0x4005629")]
		[FieldOffset(Offset = "0x10")]
		public List<int> scoreCurrent;

		// Token: 0x0400562A RID: 22058
		[Token(Token = "0x400562A")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(PropertyName = "CommentOld")]
		public List<string> oldCommentIdList;

		// Token: 0x0400562B RID: 22059
		[Token(Token = "0x400562B")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty(PropertyName = "CommentNew")]
		public List<string> newCommentIdList;

		// Token: 0x0400562C RID: 22060
		[Token(Token = "0x400562C")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty(PropertyName = "rune")]
		public List<string> runeIdList;

		// Token: 0x0400562D RID: 22061
		[Token(Token = "0x400562D")]
		[FieldOffset(Offset = "0x30")]
		public long ts;
	}
}
