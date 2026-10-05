using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E60 RID: 3680
	[Token(Token = "0x2000E60")]
	public class ActVecBreakV2HardStageData
	{
		// Token: 0x06006B2D RID: 27437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B2D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActVecBreakV2HardStageData()
		{
		}

		// Token: 0x04004D0C RID: 19724
		[Token(Token = "0x4004D0C")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04004D0D RID: 19725
		[Token(Token = "0x4004D0D")]
		[FieldOffset(Offset = "0x18")]
		public ActVecBreakV2StageOrderType orderType;

		// Token: 0x04004D0E RID: 19726
		[Token(Token = "0x4004D0E")]
		[FieldOffset(Offset = "0x20")]
		public string storyDesc;

		// Token: 0x04004D0F RID: 19727
		[Token(Token = "0x4004D0F")]
		[FieldOffset(Offset = "0x28")]
		public ActVecBreakV2BossData bossData;
	}
}
