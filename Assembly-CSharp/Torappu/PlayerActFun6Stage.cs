using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B80 RID: 2944
	[Token(Token = "0x2000B80")]
	public class PlayerActFun6Stage
	{
		// Token: 0x0600681F RID: 26655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600681F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerActFun6Stage()
		{
		}

		// Token: 0x04003D0F RID: 15631
		[Token(Token = "0x4003D0F")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04003D10 RID: 15632
		[Token(Token = "0x4003D10")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> achievements;

		// Token: 0x04003D11 RID: 15633
		[Token(Token = "0x4003D11")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("speedrunning")]
		public long speedRunning;

		// Token: 0x04003D12 RID: 15634
		[Token(Token = "0x4003D12")]
		[FieldOffset(Offset = "0x28")]
		public PlayerStageState state;
	}
}
