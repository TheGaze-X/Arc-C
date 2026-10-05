using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000D6C RID: 3436
	[Token(Token = "0x2000D6C")]
	public class Act5D0Data
	{
		// Token: 0x06006A3E RID: 27198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A3E")]
		[Address(RVA = "0x1FF7560", Offset = "0x1FF6160", VA = "0x181FF7560")]
		public Act5D0Data()
		{
		}

		// Token: 0x040046B7 RID: 18103
		[Token(Token = "0x40046B7")]
		[FieldOffset(Offset = "0x10")]
		public List<MileStoneInfo> mileStoneInfo;

		// Token: 0x040046B8 RID: 18104
		[Token(Token = "0x40046B8")]
		[FieldOffset(Offset = "0x18")]
		public string mileStoneTokenId;

		// Token: 0x040046B9 RID: 18105
		[Token(Token = "0x40046B9")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, Act5D0Data.ZoneDescInfo> zoneDesc;

		// Token: 0x040046BA RID: 18106
		[Token(Token = "0x40046BA")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, Act5D0Data.MissionExtraInfo> missionExtraList;

		// Token: 0x040046BB RID: 18107
		[Token(Token = "0x40046BB")]
		[FieldOffset(Offset = "0x30")]
		public string spReward;

		// Token: 0x02000D6D RID: 3437
		[Token(Token = "0x2000D6D")]
		public class ZoneDescInfo
		{
			// Token: 0x06006A3F RID: 27199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A3F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ZoneDescInfo()
			{
			}

			// Token: 0x040046BC RID: 18108
			[Token(Token = "0x40046BC")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x040046BD RID: 18109
			[Token(Token = "0x40046BD")]
			[FieldOffset(Offset = "0x18")]
			public string lockedText;
		}

		// Token: 0x02000D6E RID: 3438
		[Token(Token = "0x2000D6E")]
		[Serializable]
		public class MissionExtraInfo
		{
			// Token: 0x06006A40 RID: 27200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A40")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MissionExtraInfo()
			{
			}

			// Token: 0x040046BE RID: 18110
			[Token(Token = "0x40046BE")]
			[FieldOffset(Offset = "0x10")]
			public int difficultLevel;

			// Token: 0x040046BF RID: 18111
			[Token(Token = "0x40046BF")]
			[FieldOffset(Offset = "0x18")]
			public string levelDesc;

			// Token: 0x040046C0 RID: 18112
			[Token(Token = "0x40046C0")]
			[FieldOffset(Offset = "0x20")]
			public int sortId;
		}
	}
}
