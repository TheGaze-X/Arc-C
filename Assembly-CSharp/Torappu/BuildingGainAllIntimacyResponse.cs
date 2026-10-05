using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x0200065F RID: 1631
	[Token(Token = "0x200065F")]
	public class BuildingGainAllIntimacyResponse : PlayerDeltaResponse
	{
		// Token: 0x0600628D RID: 25229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628D")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingGainAllIntimacyResponse()
		{
		}

		// Token: 0x04002E17 RID: 11799
		[Token(Token = "0x4002E17")]
		[FieldOffset(Offset = "0x28")]
		public int normal;

		// Token: 0x04002E18 RID: 11800
		[Token(Token = "0x4002E18")]
		[FieldOffset(Offset = "0x2C")]
		public int assist;

		// Token: 0x04002E19 RID: 11801
		[Token(Token = "0x4002E19")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("private")]
		public int privateRelated;
	}
}
