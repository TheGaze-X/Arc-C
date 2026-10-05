using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001363 RID: 4963
	[Token(Token = "0x2001363")]
	public class StoryStageShowGroup
	{
		// Token: 0x0600732C RID: 29484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600732C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StoryStageShowGroup()
		{
		}

		// Token: 0x04006E21 RID: 28193
		[Token(Token = "0x4006E21")]
		[FieldOffset(Offset = "0x10")]
		public string displayRecordId;

		// Token: 0x04006E22 RID: 28194
		[Token(Token = "0x4006E22")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04006E23 RID: 28195
		[Token(Token = "0x4006E23")]
		[FieldOffset(Offset = "0x20")]
		public string accordingStageId;

		// Token: 0x04006E24 RID: 28196
		[Token(Token = "0x4006E24")]
		[FieldOffset(Offset = "0x28")]
		public StageDiffGroup diffGroup;
	}
}
