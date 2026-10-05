using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E21 RID: 3617
	[Token(Token = "0x2000E21")]
	public class ActivityMiniStoryData
	{
		// Token: 0x06006AF5 RID: 27381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF5")]
		[Address(RVA = "0x1FFC9A0", Offset = "0x1FFB5A0", VA = "0x181FFC9A0")]
		public ActivityMiniStoryData()
		{
		}

		// Token: 0x04004B53 RID: 19283
		[Token(Token = "0x4004B53")]
		[FieldOffset(Offset = "0x10")]
		public string tokenItemId;

		// Token: 0x04004B54 RID: 19284
		[Token(Token = "0x4004B54")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, ActivityMiniStoryData.ZoneDescInfo> zoneDescList;

		// Token: 0x04004B55 RID: 19285
		[Token(Token = "0x4004B55")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, ActivityMiniStoryData.FavorUpInfo> favorUpList;

		// Token: 0x04004B56 RID: 19286
		[Token(Token = "0x4004B56")]
		[FieldOffset(Offset = "0x28")]
		public List<string> extraDropZoneList;

		// Token: 0x02000E22 RID: 3618
		[Token(Token = "0x2000E22")]
		public class ZoneDescInfo
		{
			// Token: 0x06006AF6 RID: 27382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AF6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ZoneDescInfo()
			{
			}

			// Token: 0x04004B57 RID: 19287
			[Token(Token = "0x4004B57")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04004B58 RID: 19288
			[Token(Token = "0x4004B58")]
			[FieldOffset(Offset = "0x18")]
			public string unlockText;
		}

		// Token: 0x02000E23 RID: 3619
		[Token(Token = "0x2000E23")]
		public class FavorUpInfo
		{
			// Token: 0x06006AF7 RID: 27383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AF7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FavorUpInfo()
			{
			}

			// Token: 0x04004B59 RID: 19289
			[Token(Token = "0x4004B59")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04004B5A RID: 19290
			[Token(Token = "0x4004B5A")]
			[FieldOffset(Offset = "0x18")]
			public long displayStartTime;

			// Token: 0x04004B5B RID: 19291
			[Token(Token = "0x4004B5B")]
			[FieldOffset(Offset = "0x20")]
			public long displayEndTime;
		}
	}
}
