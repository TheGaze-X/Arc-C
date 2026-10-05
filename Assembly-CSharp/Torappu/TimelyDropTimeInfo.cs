using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200135B RID: 4955
	[Token(Token = "0x200135B")]
	public class TimelyDropTimeInfo : ITimeValidInfo
	{
		// Token: 0x06007322 RID: 29474 RVA: 0x00033228 File Offset: 0x00031428
		[Token(Token = "0x6007322")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x00033240 File Offset: 0x00031440
		[Token(Token = "0x6007323")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007324")]
		[Address(RVA = "0x2215C60", Offset = "0x2214860", VA = "0x182215C60")]
		public TimelyDropTimeInfo()
		{
		}

		// Token: 0x04006DFE RID: 28158
		[Token(Token = "0x4006DFE")]
		[FieldOffset(Offset = "0x10")]
		public long startTs;

		// Token: 0x04006DFF RID: 28159
		[Token(Token = "0x4006DFF")]
		[FieldOffset(Offset = "0x18")]
		public long endTs;

		// Token: 0x04006E00 RID: 28160
		[Token(Token = "0x4006E00")]
		[FieldOffset(Offset = "0x20")]
		public string stagePic;

		// Token: 0x04006E01 RID: 28161
		[Token(Token = "0x4006E01")]
		[FieldOffset(Offset = "0x28")]
		public string dropPicId;

		// Token: 0x04006E02 RID: 28162
		[Token(Token = "0x4006E02")]
		[FieldOffset(Offset = "0x30")]
		public string stageUnlock;

		// Token: 0x04006E03 RID: 28163
		[Token(Token = "0x4006E03")]
		[FieldOffset(Offset = "0x38")]
		public string entranceDownPicId;

		// Token: 0x04006E04 RID: 28164
		[Token(Token = "0x4006E04")]
		[FieldOffset(Offset = "0x40")]
		public string entranceUpPicId;

		// Token: 0x04006E05 RID: 28165
		[Token(Token = "0x4006E05")]
		[FieldOffset(Offset = "0x48")]
		public string timelyGroupId;

		// Token: 0x04006E06 RID: 28166
		[Token(Token = "0x4006E06")]
		[FieldOffset(Offset = "0x50")]
		public string weeklyPicId;

		// Token: 0x04006E07 RID: 28167
		[Token(Token = "0x4006E07")]
		[FieldOffset(Offset = "0x58")]
		public bool isReplace;

		// Token: 0x04006E08 RID: 28168
		[Token(Token = "0x4006E08")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, long> apSupplyOutOfDateDict;
	}
}
