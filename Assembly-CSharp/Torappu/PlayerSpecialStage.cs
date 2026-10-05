using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020009FE RID: 2558
	[Token(Token = "0x20009FE")]
	public class PlayerSpecialStage
	{
		// Token: 0x060066C2 RID: 26306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerSpecialStage()
		{
		}

		// Token: 0x0400374B RID: 14155
		[Token(Token = "0x400374B")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400374C RID: 14156
		[Token(Token = "0x400374C")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("fts")]
		public long unlockTs;

		// Token: 0x0400374D RID: 14157
		[Token(Token = "0x400374D")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("rts")]
		public long rewardTs;
	}
}
