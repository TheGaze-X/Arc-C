using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B9B RID: 2971
	[Token(Token = "0x2000B9B")]
	public class PlayerMissionArchive
	{
		// Token: 0x06006837 RID: 26679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006837")]
		[Address(RVA = "0x1EFB560", Offset = "0x1EFA160", VA = "0x181EFB560")]
		public PlayerMissionArchive()
		{
		}

		// Token: 0x04003D63 RID: 15715
		[Token(Token = "0x4003D63")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "isOpen")]
		public bool entryOpen;

		// Token: 0x04003D64 RID: 15716
		[Token(Token = "0x4003D64")]
		[FieldOffset(Offset = "0x11")]
		[JsonProperty(PropertyName = "confirmEnterReward")]
		public bool entryRewardClaimed;

		// Token: 0x04003D65 RID: 15717
		[Token(Token = "0x4003D65")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerMissionArchiveNodeState> nodes;
	}
}
