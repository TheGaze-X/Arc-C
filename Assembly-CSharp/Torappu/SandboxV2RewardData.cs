using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200128D RID: 4749
	[Token(Token = "0x200128D")]
	public class SandboxV2RewardData
	{
		// Token: 0x06007205 RID: 29189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007205")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RewardData()
		{
		}

		// Token: 0x040068B0 RID: 26800
		[Token(Token = "0x40068B0")]
		[FieldOffset(Offset = "0x10")]
		public List<SandboxV2RewardItemConfigData> rewardList;
	}
}
