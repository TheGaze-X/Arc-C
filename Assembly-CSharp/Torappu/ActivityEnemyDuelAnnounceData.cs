using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E06 RID: 3590
	[Token(Token = "0x2000E06")]
	public class ActivityEnemyDuelAnnounceData : ITimeValidInfo
	{
		// Token: 0x06006AD7 RID: 27351 RVA: 0x000311B8 File Offset: 0x0002F3B8
		[Token(Token = "0x6006AD7")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x000311D0 File Offset: 0x0002F3D0
		[Token(Token = "0x6006AD8")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelAnnounceData()
		{
		}

		// Token: 0x04004A88 RID: 19080
		[Token(Token = "0x4004A88")]
		[FieldOffset(Offset = "0x10")]
		public long startTs;

		// Token: 0x04004A89 RID: 19081
		[Token(Token = "0x4004A89")]
		[FieldOffset(Offset = "0x18")]
		public long endTs;

		// Token: 0x04004A8A RID: 19082
		[Token(Token = "0x4004A8A")]
		[FieldOffset(Offset = "0x20")]
		public string announceText;

		// Token: 0x04004A8B RID: 19083
		[Token(Token = "0x4004A8B")]
		[FieldOffset(Offset = "0x28")]
		public bool showNew;
	}
}
