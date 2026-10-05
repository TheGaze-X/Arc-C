using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001136 RID: 4406
	[Token(Token = "0x2001136")]
	[Serializable]
	public class RetroStageOverrideInfo
	{
		// Token: 0x06006F0B RID: 28427 RVA: 0x000324C0 File Offset: 0x000306C0
		[Token(Token = "0x6006F0B")]
		[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
		public bool ShouldSerializecanMultipleBattleBattle()
		{
			return default(bool);
		}

		// Token: 0x06006F0C RID: 28428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0C")]
		[Address(RVA = "0x210F440", Offset = "0x210E040", VA = "0x18210F440")]
		public RetroStageOverrideInfo()
		{
		}

		// Token: 0x04005E67 RID: 24167
		[Token(Token = "0x4005E67")]
		[FieldOffset(Offset = "0x10")]
		public StageData.StageDropInfo dropInfo;

		// Token: 0x04005E68 RID: 24168
		[Token(Token = "0x4005E68")]
		[FieldOffset(Offset = "0x18")]
		public string zoneId;

		// Token: 0x04005E69 RID: 24169
		[Token(Token = "0x4005E69")]
		[FieldOffset(Offset = "0x20")]
		public int apCost;

		// Token: 0x04005E6A RID: 24170
		[Token(Token = "0x4005E6A")]
		[FieldOffset(Offset = "0x24")]
		public int apFailReturn;

		// Token: 0x04005E6B RID: 24171
		[Token(Token = "0x4005E6B")]
		[FieldOffset(Offset = "0x28")]
		public int expGain;

		// Token: 0x04005E6C RID: 24172
		[Token(Token = "0x4005E6C")]
		[FieldOffset(Offset = "0x2C")]
		public int goldGain;

		// Token: 0x04005E6D RID: 24173
		[Token(Token = "0x4005E6D")]
		[FieldOffset(Offset = "0x30")]
		public int passFavor;

		// Token: 0x04005E6E RID: 24174
		[Token(Token = "0x4005E6E")]
		[FieldOffset(Offset = "0x34")]
		public int completeFavor;

		// Token: 0x04005E6F RID: 24175
		[Token(Token = "0x4005E6F")]
		[FieldOffset(Offset = "0x38")]
		public bool canMultipleBattle;
	}
}
