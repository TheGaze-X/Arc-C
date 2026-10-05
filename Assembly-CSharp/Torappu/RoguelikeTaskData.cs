using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001224 RID: 4644
	[Token(Token = "0x2001224")]
	public class RoguelikeTaskData
	{
		// Token: 0x06007022 RID: 28706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007022")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTaskData()
		{
		}

		// Token: 0x0400644A RID: 25674
		[Token(Token = "0x400644A")]
		[FieldOffset(Offset = "0x10")]
		public string taskId;

		// Token: 0x0400644B RID: 25675
		[Token(Token = "0x400644B")]
		[FieldOffset(Offset = "0x18")]
		public string taskName;

		// Token: 0x0400644C RID: 25676
		[Token(Token = "0x400644C")]
		[FieldOffset(Offset = "0x20")]
		public string taskDesc;

		// Token: 0x0400644D RID: 25677
		[Token(Token = "0x400644D")]
		[FieldOffset(Offset = "0x28")]
		public string rewardSceneId;

		// Token: 0x0400644E RID: 25678
		[Token(Token = "0x400644E")]
		[FieldOffset(Offset = "0x30")]
		public RoguelikeTaskRarity taskRarity;
	}
}
