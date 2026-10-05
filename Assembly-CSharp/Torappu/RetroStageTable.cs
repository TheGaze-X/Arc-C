using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200113D RID: 4413
	[Token(Token = "0x200113D")]
	[Serializable]
	public class RetroStageTable
	{
		// Token: 0x06006F13 RID: 28435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F13")]
		[Address(RVA = "0x210F4B0", Offset = "0x210E0B0", VA = "0x18210F4B0")]
		public RetroStageTable()
		{
		}

		// Token: 0x04005E8D RID: 24205
		[Token(Token = "0x4005E8D")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, string> zoneToRetro;

		// Token: 0x04005E8E RID: 24206
		[Token(Token = "0x4005E8E")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, StageValidInfo> stageValidInfo;

		// Token: 0x04005E8F RID: 24207
		[Token(Token = "0x4005E8F")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, RetroStageOverrideInfo> stages;

		// Token: 0x04005E90 RID: 24208
		[Token(Token = "0x4005E90")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, RetroActData> retroActList;

		// Token: 0x04005E91 RID: 24209
		[Token(Token = "0x4005E91")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, RetroTrailData> retroTrailList;

		// Token: 0x04005E92 RID: 24210
		[Token(Token = "0x4005E92")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, StageData> stageList;

		// Token: 0x04005E93 RID: 24211
		[Token(Token = "0x4005E93")]
		[FieldOffset(Offset = "0x40")]
		public RetroTrailRuleData ruleData;

		// Token: 0x04005E94 RID: 24212
		[Token(Token = "0x4005E94")]
		[FieldOffset(Offset = "0x48")]
		public ActivityCustomData customData;

		// Token: 0x04005E95 RID: 24213
		[Token(Token = "0x4005E95")]
		[FieldOffset(Offset = "0x50")]
		public int initRetroCoin;

		// Token: 0x04005E96 RID: 24214
		[Token(Token = "0x4005E96")]
		[FieldOffset(Offset = "0x54")]
		public int retroCoinPerWeek;

		// Token: 0x04005E97 RID: 24215
		[Token(Token = "0x4005E97")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<int, int> retroCoinMaxOfLevels;

		// Token: 0x04005E98 RID: 24216
		[Token(Token = "0x4005E98")]
		[FieldOffset(Offset = "0x60")]
		public int retroUnlockCost;

		// Token: 0x04005E99 RID: 24217
		[Token(Token = "0x4005E99")]
		[FieldOffset(Offset = "0x68")]
		public string retroDetail;

		// Token: 0x04005E9A RID: 24218
		[Token(Token = "0x4005E9A")]
		[FieldOffset(Offset = "0x70")]
		public long retroPreShowTime;
	}
}
