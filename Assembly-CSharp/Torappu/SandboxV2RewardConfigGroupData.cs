using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200128F RID: 4751
	[Token(Token = "0x200128F")]
	public class SandboxV2RewardConfigGroupData
	{
		// Token: 0x06007207 RID: 29191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007207")]
		[Address(RVA = "0x2210820", Offset = "0x220F420", VA = "0x182210820")]
		public SandboxV2RewardConfigGroupData()
		{
		}

		// Token: 0x040068B4 RID: 26804
		[Token(Token = "0x40068B4")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, SandboxV2RewardData> stageMapPreviewRewardDict;

		// Token: 0x040068B5 RID: 26805
		[Token(Token = "0x40068B5")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, SandboxV2RewardData> stageDetailPreviewRewardDict;

		// Token: 0x040068B6 RID: 26806
		[Token(Token = "0x40068B6")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, SandboxV2RewardCommonConfig> trapRewardDict;

		// Token: 0x040068B7 RID: 26807
		[Token(Token = "0x40068B7")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, SandboxV2RewardCommonConfig> enemyRewardDict;

		// Token: 0x040068B8 RID: 26808
		[Token(Token = "0x40068B8")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, SandboxV2RewardData> unitPreviewRewardDict;

		// Token: 0x040068B9 RID: 26809
		[Token(Token = "0x40068B9")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, SandboxV2RewardData> stageRewardDict;

		// Token: 0x040068BA RID: 26810
		[Token(Token = "0x40068BA")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, SandboxV2RewardData> rushPreviewRewardDict;
	}
}
