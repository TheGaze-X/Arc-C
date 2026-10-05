using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E42 RID: 3650
	[Token(Token = "0x2000E42")]
	public class ActMultiV3MapTypeData
	{
		// Token: 0x06006B10 RID: 27408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B10")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3MapTypeData()
		{
		}

		// Token: 0x04004C02 RID: 19458
		[Token(Token = "0x4004C02")]
		[FieldOffset(Offset = "0x10")]
		public string modeId;

		// Token: 0x04004C03 RID: 19459
		[Token(Token = "0x4004C03")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3MapModeType mode;

		// Token: 0x04004C04 RID: 19460
		[Token(Token = "0x4004C04")]
		[FieldOffset(Offset = "0x1C")]
		public ActMultiV3MapDiffType difficulty;

		// Token: 0x04004C05 RID: 19461
		[Token(Token = "0x4004C05")]
		[FieldOffset(Offset = "0x20")]
		public bool isDefaultSelectInQuickMatch;

		// Token: 0x04004C06 RID: 19462
		[Token(Token = "0x4004C06")]
		[FieldOffset(Offset = "0x24")]
		public int squadMax;

		// Token: 0x04004C07 RID: 19463
		[Token(Token = "0x4004C07")]
		[FieldOffset(Offset = "0x28")]
		public string matchUnlockModeId;

		// Token: 0x04004C08 RID: 19464
		[Token(Token = "0x4004C08")]
		[FieldOffset(Offset = "0x30")]
		public int matchUnlockParam;

		// Token: 0x04004C09 RID: 19465
		[Token(Token = "0x4004C09")]
		[FieldOffset(Offset = "0x38")]
		public List<string> stageIdInModeList;

		// Token: 0x04004C0A RID: 19466
		[Token(Token = "0x4004C0A")]
		[FieldOffset(Offset = "0x40")]
		public string unlockHint;
	}
}
