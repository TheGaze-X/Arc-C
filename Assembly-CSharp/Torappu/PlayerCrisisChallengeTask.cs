using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000A94 RID: 2708
	[Token(Token = "0x2000A94")]
	public class PlayerCrisisChallengeTask
	{
		// Token: 0x06006758 RID: 26456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006758")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerCrisisChallengeTask()
		{
		}

		// Token: 0x04003941 RID: 14657
		[Token(Token = "0x4003941")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "finish_ts")]
		public long finishTs;

		// Token: 0x04003942 RID: 14658
		[Token(Token = "0x4003942")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(PropertyName = "reward_ts")]
		public long rewardTs;
	}
}
