using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E46 RID: 3654
	[Token(Token = "0x2000E46")]
	public class ActMultiV3MapModeData
	{
		// Token: 0x06006B14 RID: 27412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B14")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3MapModeData()
		{
		}

		// Token: 0x04004C1C RID: 19484
		[Token(Token = "0x4004C1C")]
		[FieldOffset(Offset = "0x10")]
		public ActMultiV3MapModeType modeType;

		// Token: 0x04004C1D RID: 19485
		[Token(Token = "0x4004C1D")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04004C1E RID: 19486
		[Token(Token = "0x4004C1E")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x04004C1F RID: 19487
		[Token(Token = "0x4004C1F")]
		[FieldOffset(Offset = "0x28")]
		public string color;

		// Token: 0x04004C20 RID: 19488
		[Token(Token = "0x4004C20")]
		[FieldOffset(Offset = "0x30")]
		public int quickMatchSortId;

		// Token: 0x04004C21 RID: 19489
		[Token(Token = "0x4004C21")]
		[FieldOffset(Offset = "0x34")]
		public int stageOverviewSortId;

		// Token: 0x04004C22 RID: 19490
		[Token(Token = "0x4004C22")]
		[FieldOffset(Offset = "0x38")]
		public long unlockTs;

		// Token: 0x04004C23 RID: 19491
		[Token(Token = "0x4004C23")]
		[FieldOffset(Offset = "0x40")]
		public string unlockPageTitle;

		// Token: 0x04004C24 RID: 19492
		[Token(Token = "0x4004C24")]
		[FieldOffset(Offset = "0x48")]
		public string unlockPageDesc;
	}
}
