using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000AAE RID: 2734
	[Token(Token = "0x2000AAE")]
	public class PlayerRoguelikeItem
	{
		// Token: 0x0600676C RID: 26476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676C")]
		[Address(RVA = "0x1EFCB10", Offset = "0x1EFB710", VA = "0x181EFCB10")]
		public PlayerRoguelikeItem()
		{
		}

		// Token: 0x040039A4 RID: 14756
		[Token(Token = "0x40039A4")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("index")]
		public string instId;

		// Token: 0x040039A5 RID: 14757
		[Token(Token = "0x40039A5")]
		[FieldOffset(Offset = "0x18")]
		public string id;

		// Token: 0x040039A6 RID: 14758
		[Token(Token = "0x40039A6")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		// Token: 0x040039A7 RID: 14759
		[Token(Token = "0x40039A7")]
		[FieldOffset(Offset = "0x28")]
		public long ts;

		// Token: 0x040039A8 RID: 14760
		[Token(Token = "0x40039A8")]
		[FieldOffset(Offset = "0x30")]
		public List<RoguelikeRecruitUpgradeCharacter> recruit;

		// Token: 0x040039A9 RID: 14761
		[Token(Token = "0x40039A9")]
		[FieldOffset(Offset = "0x38")]
		public List<RoguelikeRecruitUpgradeCharacter> upgrade;
	}
}
