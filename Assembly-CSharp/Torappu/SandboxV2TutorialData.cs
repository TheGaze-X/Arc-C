using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012EC RID: 4844
	[Token(Token = "0x20012EC")]
	public class SandboxV2TutorialData
	{
		// Token: 0x06007265 RID: 29285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007265")]
		[Address(RVA = "0x2210B10", Offset = "0x220F710", VA = "0x182210B10")]
		public SandboxV2TutorialData()
		{
		}

		// Token: 0x04006AFD RID: 27389
		[Token(Token = "0x4006AFD")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, SandboxV2TutorialRepoCharData> charRepoData;

		// Token: 0x04006AFE RID: 27390
		[Token(Token = "0x4006AFE")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, SandboxV2QuestData> questData;

		// Token: 0x04006AFF RID: 27391
		[Token(Token = "0x4006AFF")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, SandboxV2GuideQuestData> guideQuestData;

		// Token: 0x04006B00 RID: 27392
		[Token(Token = "0x4006B00")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, SandboxV2QuestLineData> questLineData;

		// Token: 0x04006B01 RID: 27393
		[Token(Token = "0x4006B01")]
		[FieldOffset(Offset = "0x30")]
		public SandboxV2TutorialBasicConst basicConst;
	}
}
