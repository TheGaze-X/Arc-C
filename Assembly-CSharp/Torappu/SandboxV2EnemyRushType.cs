using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001280 RID: 4736
	[Token(Token = "0x2001280")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2EnemyRushType
	{
		// Token: 0x04006875 RID: 26741
		[Token(Token = "0x4006875")]
		NORMAL,
		// Token: 0x04006876 RID: 26742
		[Token(Token = "0x4006876")]
		ELITE,
		// Token: 0x04006877 RID: 26743
		[Token(Token = "0x4006877")]
		BOSS,
		// Token: 0x04006878 RID: 26744
		[Token(Token = "0x4006878")]
		BANDIT,
		// Token: 0x04006879 RID: 26745
		[Token(Token = "0x4006879")]
		RALLY,
		// Token: 0x0400687A RID: 26746
		[Token(Token = "0x400687A")]
		THIEF,
		// Token: 0x0400687B RID: 26747
		[Token(Token = "0x400687B")]
		MESSENGER,
		// Token: 0x0400687C RID: 26748
		[Token(Token = "0x400687C")]
		INSECT
	}
}
