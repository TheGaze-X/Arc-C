using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200128C RID: 4748
	[Token(Token = "0x200128C")]
	public class SandboxV2RewardItemConfigData
	{
		// Token: 0x06007204 RID: 29188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007204")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RewardItemConfigData()
		{
		}

		// Token: 0x040068AE RID: 26798
		[Token(Token = "0x40068AE")]
		[FieldOffset(Offset = "0x10")]
		public string rewardItem;

		// Token: 0x040068AF RID: 26799
		[Token(Token = "0x40068AF")]
		[FieldOffset(Offset = "0x18")]
		public SandboxPermItemType rewardType;
	}
}
