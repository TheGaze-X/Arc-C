using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu
{
	// Token: 0x02000778 RID: 1912
	[Token(Token = "0x2000778")]
	public class PlayerSyncStatusResponse : PlayerDeltaResponse
	{
		// Token: 0x060063F1 RID: 25585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F1")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public PlayerSyncStatusResponse()
		{
		}

		// Token: 0x04003018 RID: 12312
		[Token(Token = "0x4003018")]
		[FieldOffset(Offset = "0x28")]
		public long ts;

		// Token: 0x04003019 RID: 12313
		[Token(Token = "0x4003019")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<long, JObject> result;
	}
}
