using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B75 RID: 2933
	[Token(Token = "0x2000B75")]
	public class PlayerHomeBackground
	{
		// Token: 0x06006814 RID: 26644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006814")]
		[Address(RVA = "0x1EFAD40", Offset = "0x1EF9940", VA = "0x181EFAD40")]
		public PlayerHomeBackground()
		{
		}

		// Token: 0x04003CF3 RID: 15603
		[Token(Token = "0x4003CF3")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "selected")]
		public string selectedId;

		// Token: 0x04003CF4 RID: 15604
		[Token(Token = "0x4003CF4")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerHomeUnlockStatus> bgs;
	}
}
