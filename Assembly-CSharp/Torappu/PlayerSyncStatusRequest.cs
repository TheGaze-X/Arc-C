using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000777 RID: 1911
	[Token(Token = "0x2000777")]
	public class PlayerSyncStatusRequest
	{
		// Token: 0x060063F0 RID: 25584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F0")]
		[Address(RVA = "0x1EFF6C0", Offset = "0x1EFE2C0", VA = "0x181EFF6C0")]
		public PlayerSyncStatusRequest()
		{
		}

		// Token: 0x04003016 RID: 12310
		[Token(Token = "0x4003016")]
		[FieldOffset(Offset = "0x10")]
		public long modules;

		// Token: 0x04003017 RID: 12311
		[Token(Token = "0x4003017")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(PropertyName = "params")]
		public Dictionary<long, PlayerSyncParam> paramDict;
	}
}
