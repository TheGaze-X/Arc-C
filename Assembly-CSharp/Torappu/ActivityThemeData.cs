using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E7F RID: 3711
	[Token(Token = "0x2000E7F")]
	public class ActivityThemeData : ITimeValidInfo
	{
		// Token: 0x06006B49 RID: 27465 RVA: 0x00031290 File Offset: 0x0002F490
		[Token(Token = "0x6006B49")]
		[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x06006B4A RID: 27466 RVA: 0x000312A8 File Offset: 0x0002F4A8
		[Token(Token = "0x6006B4A")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x06006B4B RID: 27467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B4B")]
		[Address(RVA = "0x1FFD960", Offset = "0x1FFC560", VA = "0x181FFD960")]
		public ActivityThemeData()
		{
		}

		// Token: 0x04004E1E RID: 19998
		[Token(Token = "0x4004E1E")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04004E1F RID: 19999
		[Token(Token = "0x4004E1F")]
		[FieldOffset(Offset = "0x18")]
		public ActivityThemeType type;

		// Token: 0x04004E20 RID: 20000
		[Token(Token = "0x4004E20")]
		[FieldOffset(Offset = "0x20")]
		public string funcId;

		// Token: 0x04004E21 RID: 20001
		[Token(Token = "0x4004E21")]
		[FieldOffset(Offset = "0x28")]
		public long endTs;

		// Token: 0x04004E22 RID: 20002
		[Token(Token = "0x4004E22")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;

		// Token: 0x04004E23 RID: 20003
		[Token(Token = "0x4004E23")]
		[FieldOffset(Offset = "0x38")]
		public string itemId;

		// Token: 0x04004E24 RID: 20004
		[Token(Token = "0x4004E24")]
		[FieldOffset(Offset = "0x40")]
		public List<ActivityThemeData.TimeNode> timeNodes;

		// Token: 0x04004E25 RID: 20005
		[Token(Token = "0x4004E25")]
		[FieldOffset(Offset = "0x48")]
		public List<ActivityThemeData.PicGroup> picGroups;

		// Token: 0x04004E26 RID: 20006
		[Token(Token = "0x4004E26")]
		[FieldOffset(Offset = "0x50")]
		public long startTs;

		// Token: 0x02000E80 RID: 3712
		[Token(Token = "0x2000E80")]
		public class TimeNode
		{
			// Token: 0x06006B4C RID: 27468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B4C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TimeNode()
			{
			}

			// Token: 0x04004E27 RID: 20007
			[Token(Token = "0x4004E27")]
			[FieldOffset(Offset = "0x10")]
			public string title;

			// Token: 0x04004E28 RID: 20008
			[Token(Token = "0x4004E28")]
			[FieldOffset(Offset = "0x18")]
			public long ts;
		}

		// Token: 0x02000E81 RID: 3713
		[Token(Token = "0x2000E81")]
		public class PicGroup
		{
			// Token: 0x06006B4D RID: 27469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B4D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PicGroup()
			{
			}

			// Token: 0x04004E29 RID: 20009
			[Token(Token = "0x4004E29")]
			[FieldOffset(Offset = "0x10")]
			public int sortIndex;

			// Token: 0x04004E2A RID: 20010
			[Token(Token = "0x4004E2A")]
			[FieldOffset(Offset = "0x18")]
			public string picId;

			// Token: 0x04004E2B RID: 20011
			[Token(Token = "0x4004E2B")]
			[FieldOffset(Offset = "0x20")]
			public CommonAvailCheck availCheck;
		}
	}
}
