using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011FB RID: 4603
	[Token(Token = "0x20011FB")]
	public class RoguelikeTopicChallenge
	{
		// Token: 0x06006FEA RID: 28650 RVA: 0x00032970 File Offset: 0x00030B70
		[Token(Token = "0x6006FEA")]
		[Address(RVA = "0x2111A40", Offset = "0x2110640", VA = "0x182111A40")]
		public bool ShouldSerializechallengeStoryId()
		{
			return default(bool);
		}

		// Token: 0x06006FEB RID: 28651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FEB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicChallenge()
		{
		}

		// Token: 0x040062FA RID: 25338
		[Token(Token = "0x40062FA")]
		[FieldOffset(Offset = "0x10")]
		public string challengeId;

		// Token: 0x040062FB RID: 25339
		[Token(Token = "0x40062FB")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x040062FC RID: 25340
		[Token(Token = "0x40062FC")]
		[FieldOffset(Offset = "0x20")]
		public string challengeName;

		// Token: 0x040062FD RID: 25341
		[Token(Token = "0x40062FD")]
		[FieldOffset(Offset = "0x28")]
		public int challengeGroup;

		// Token: 0x040062FE RID: 25342
		[Token(Token = "0x40062FE")]
		[FieldOffset(Offset = "0x2C")]
		public int challengeGroupSortId;

		// Token: 0x040062FF RID: 25343
		[Token(Token = "0x40062FF")]
		[FieldOffset(Offset = "0x30")]
		public string challengeGroupName;

		// Token: 0x04006300 RID: 25344
		[Token(Token = "0x4006300")]
		[FieldOffset(Offset = "0x38")]
		public string challengeUnlockDesc;

		// Token: 0x04006301 RID: 25345
		[Token(Token = "0x4006301")]
		[FieldOffset(Offset = "0x40")]
		public string challengeUnlockToastDesc;

		// Token: 0x04006302 RID: 25346
		[Token(Token = "0x4006302")]
		[FieldOffset(Offset = "0x48")]
		public string challengeDes;

		// Token: 0x04006303 RID: 25347
		[Token(Token = "0x4006303")]
		[FieldOffset(Offset = "0x50")]
		public List<string> challengeConditionDes;

		// Token: 0x04006304 RID: 25348
		[Token(Token = "0x4006304")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, RoguelikeTopicChallengeTask> challengeTasks;

		// Token: 0x04006305 RID: 25349
		[Token(Token = "0x4006305")]
		[FieldOffset(Offset = "0x60")]
		public string defaultTaskId;

		// Token: 0x04006306 RID: 25350
		[Token(Token = "0x4006306")]
		[FieldOffset(Offset = "0x68")]
		public List<ItemBundle> rewards;

		// Token: 0x04006307 RID: 25351
		[Token(Token = "0x4006307")]
		[FieldOffset(Offset = "0x70")]
		public string challengeStoryId;
	}
}
