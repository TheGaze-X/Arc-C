using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020006E3 RID: 1763
	[Token(Token = "0x20006E3")]
	public class CrisisV2GetSnapshotResponse : PlayerDeltaResponse
	{
		// Token: 0x06006332 RID: 25394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006332")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public CrisisV2GetSnapshotResponse()
		{
		}

		// Token: 0x04002EF4 RID: 12020
		[Token(Token = "0x4002EF4")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty(PropertyName = "simple")]
		public Dictionary<string, CrisisV2SimpleSnapshot> simpleData;

		// Token: 0x04002EF5 RID: 12021
		[Token(Token = "0x4002EF5")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty(PropertyName = "detail")]
		public Dictionary<string, CrisisV2DetailSnapshot> detailData;
	}
}
