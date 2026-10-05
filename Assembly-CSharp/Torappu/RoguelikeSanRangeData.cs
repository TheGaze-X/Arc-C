using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001186 RID: 4486
	[Token(Token = "0x2001186")]
	public class RoguelikeSanRangeData
	{
		// Token: 0x06006F76 RID: 28534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F76")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeSanRangeData()
		{
		}

		// Token: 0x0400601C RID: 24604
		[Token(Token = "0x400601C")]
		[FieldOffset(Offset = "0x10")]
		public int sanMax;

		// Token: 0x0400601D RID: 24605
		[Token(Token = "0x400601D")]
		[FieldOffset(Offset = "0x18")]
		public string diceGroupId;

		// Token: 0x0400601E RID: 24606
		[Token(Token = "0x400601E")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x0400601F RID: 24607
		[Token(Token = "0x400601F")]
		[FieldOffset(Offset = "0x28")]
		public SanEffectRank sanDungeonEffect;

		// Token: 0x04006020 RID: 24608
		[Token(Token = "0x4006020")]
		[FieldOffset(Offset = "0x2C")]
		public SanEffectRank sanEffectRank;

		// Token: 0x04006021 RID: 24609
		[Token(Token = "0x4006021")]
		[FieldOffset(Offset = "0x30")]
		public string sanEndingDesc;
	}
}
