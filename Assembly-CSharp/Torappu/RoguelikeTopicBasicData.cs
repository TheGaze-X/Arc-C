using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011D2 RID: 4562
	[Token(Token = "0x20011D2")]
	public class RoguelikeTopicBasicData : ITimeValidInfo
	{
		// Token: 0x06006FB4 RID: 28596 RVA: 0x000327C0 File Offset: 0x000309C0
		[Token(Token = "0x6006FB4")]
		[Address(RVA = "0x2112BF0", Offset = "0x21117F0", VA = "0x182112BF0", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x06006FB5 RID: 28597 RVA: 0x000327D8 File Offset: 0x000309D8
		[Token(Token = "0x6006FB5")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x06006FB6 RID: 28598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB6")]
		[Address(RVA = "0x2112C00", Offset = "0x2111800", VA = "0x182112C00")]
		public RoguelikeTopicBasicData()
		{
		}

		// Token: 0x040061B1 RID: 25009
		[Token(Token = "0x40061B1")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040061B2 RID: 25010
		[Token(Token = "0x40061B2")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040061B3 RID: 25011
		[Token(Token = "0x40061B3")]
		[FieldOffset(Offset = "0x20")]
		public long startTime;

		// Token: 0x040061B4 RID: 25012
		[Token(Token = "0x40061B4")]
		[FieldOffset(Offset = "0x28")]
		public long disappearTimeOnMainScreen;

		// Token: 0x040061B5 RID: 25013
		[Token(Token = "0x40061B5")]
		[FieldOffset(Offset = "0x30")]
		public int sort;

		// Token: 0x040061B6 RID: 25014
		[Token(Token = "0x40061B6")]
		[FieldOffset(Offset = "0x38")]
		public string showMedalId;

		// Token: 0x040061B7 RID: 25015
		[Token(Token = "0x40061B7")]
		[FieldOffset(Offset = "0x40")]
		public string medalGroupId;

		// Token: 0x040061B8 RID: 25016
		[Token(Token = "0x40061B8")]
		[FieldOffset(Offset = "0x48")]
		public long fullStoredTime;

		// Token: 0x040061B9 RID: 25017
		[Token(Token = "0x40061B9")]
		[FieldOffset(Offset = "0x50")]
		public string lineText;

		// Token: 0x040061BA RID: 25018
		[Token(Token = "0x40061BA")]
		[FieldOffset(Offset = "0x58")]
		public List<RoguelikeTopicBasicData.HomeEntryDisplayData> homeEntryDisplayData;

		// Token: 0x040061BB RID: 25019
		[Token(Token = "0x40061BB")]
		[FieldOffset(Offset = "0x60")]
		public List<RoguelikeModuleType> moduleTypes;

		// Token: 0x040061BC RID: 25020
		[Token(Token = "0x40061BC")]
		[FieldOffset(Offset = "0x68")]
		public RoguelikeTopicConfig config;

		// Token: 0x020011D3 RID: 4563
		[Token(Token = "0x20011D3")]
		public class HomeEntryDisplayData
		{
			// Token: 0x06006FB7 RID: 28599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006FB7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HomeEntryDisplayData()
			{
			}

			// Token: 0x040061BD RID: 25021
			[Token(Token = "0x40061BD")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x040061BE RID: 25022
			[Token(Token = "0x40061BE")]
			[FieldOffset(Offset = "0x18")]
			public string displayId;

			// Token: 0x040061BF RID: 25023
			[Token(Token = "0x40061BF")]
			[FieldOffset(Offset = "0x20")]
			public long startTs;

			// Token: 0x040061C0 RID: 25024
			[Token(Token = "0x40061C0")]
			[FieldOffset(Offset = "0x28")]
			public long endTs;
		}
	}
}
