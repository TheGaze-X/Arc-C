using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000156")]
	[Flags]
	public enum EChatSteamIDInstanceFlags
	{
		// Token: 0x04000882 RID: 2178
		[Token(Token = "0x4000882")]
		k_EChatAccountInstanceMask = 4095,
		// Token: 0x04000883 RID: 2179
		[Token(Token = "0x4000883")]
		k_EChatInstanceFlagClan = 524288,
		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		k_EChatInstanceFlagLobby = 262144,
		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		k_EChatInstanceFlagMMSLobby = 131072
	}
}
