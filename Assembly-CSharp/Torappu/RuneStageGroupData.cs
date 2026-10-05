using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200135D RID: 4957
	[Token(Token = "0x200135D")]
	[Serializable]
	public class RuneStageGroupData
	{
		// Token: 0x06007326 RID: 29478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007326")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RuneStageGroupData()
		{
		}

		// Token: 0x04006E0A RID: 28170
		[Token(Token = "0x4006E0A")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04006E0B RID: 28171
		[Token(Token = "0x4006E0B")]
		[FieldOffset(Offset = "0x18")]
		public List<RuneStageGroupData.RuneStageInst> activeRuneStages;

		// Token: 0x04006E0C RID: 28172
		[Token(Token = "0x4006E0C")]
		[FieldOffset(Offset = "0x20")]
		public long startTs;

		// Token: 0x04006E0D RID: 28173
		[Token(Token = "0x4006E0D")]
		[FieldOffset(Offset = "0x28")]
		public long endTs;

		// Token: 0x0200135E RID: 4958
		[Token(Token = "0x200135E")]
		[Serializable]
		public class RuneStageInst
		{
			// Token: 0x06007327 RID: 29479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007327")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RuneStageInst()
			{
			}

			// Token: 0x04006E0E RID: 28174
			[Token(Token = "0x4006E0E")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04006E0F RID: 28175
			[Token(Token = "0x4006E0F")]
			[FieldOffset(Offset = "0x18")]
			public string[] activePackedRuneIds;
		}
	}
}
