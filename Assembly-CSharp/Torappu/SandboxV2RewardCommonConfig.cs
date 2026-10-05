using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200128E RID: 4750
	[Token(Token = "0x200128E")]
	public class SandboxV2RewardCommonConfig
	{
		// Token: 0x06007206 RID: 29190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007206")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RewardCommonConfig()
		{
		}

		// Token: 0x040068B1 RID: 26801
		[Token(Token = "0x40068B1")]
		[FieldOffset(Offset = "0x10")]
		public string rewardItemId;

		// Token: 0x040068B2 RID: 26802
		[Token(Token = "0x40068B2")]
		[FieldOffset(Offset = "0x18")]
		public SandboxPermItemType rewardItemType;

		// Token: 0x040068B3 RID: 26803
		[Token(Token = "0x40068B3")]
		[FieldOffset(Offset = "0x1C")]
		public int count;
	}
}
