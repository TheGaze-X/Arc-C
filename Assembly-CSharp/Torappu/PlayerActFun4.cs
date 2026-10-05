using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B7C RID: 2940
	[Token(Token = "0x2000B7C")]
	public class PlayerActFun4
	{
		// Token: 0x0600681B RID: 26651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600681B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerActFun4()
		{
		}

		// Token: 0x04003D01 RID: 15617
		[Token(Token = "0x4003D01")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerActFun4Stage> stages;

		// Token: 0x04003D02 RID: 15618
		[Token(Token = "0x4003D02")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> liveEndings;

		// Token: 0x04003D03 RID: 15619
		[Token(Token = "0x4003D03")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("cameraLv")]
		public int tokenLevel;

		// Token: 0x04003D04 RID: 15620
		[Token(Token = "0x4003D04")]
		[FieldOffset(Offset = "0x24")]
		[JsonProperty("fans")]
		public int fansNum;

		// Token: 0x04003D05 RID: 15621
		[Token(Token = "0x4003D05")]
		[FieldOffset(Offset = "0x28")]
		public int posts;

		// Token: 0x04003D06 RID: 15622
		[Token(Token = "0x4003D06")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, PlayerActFun4Mission> missions;
	}
}
