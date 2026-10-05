using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012FE RID: 4862
	[Token(Token = "0x20012FE")]
	public class SandboxPermBasicData : ITimeValidInfo
	{
		// Token: 0x06007277 RID: 29303 RVA: 0x00032DD8 File Offset: 0x00030FD8
		[Token(Token = "0x6007277")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x00032DF0 File Offset: 0x00030FF0
		[Token(Token = "0x6007278")]
		[Address(RVA = "0x2112BF0", Offset = "0x21117F0", VA = "0x182112BF0", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007279")]
		[Address(RVA = "0x220E190", Offset = "0x220CD90", VA = "0x18220E190")]
		public SandboxPermBasicData()
		{
		}

		// Token: 0x04006BB8 RID: 27576
		[Token(Token = "0x4006BB8")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04006BB9 RID: 27577
		[Token(Token = "0x4006BB9")]
		[FieldOffset(Offset = "0x18")]
		public SandboxPermTemplateType topicTemplate;

		// Token: 0x04006BBA RID: 27578
		[Token(Token = "0x4006BBA")]
		[FieldOffset(Offset = "0x20")]
		public string topicName;

		// Token: 0x04006BBB RID: 27579
		[Token(Token = "0x4006BBB")]
		[FieldOffset(Offset = "0x28")]
		public long topicStartTime;

		// Token: 0x04006BBC RID: 27580
		[Token(Token = "0x4006BBC")]
		[FieldOffset(Offset = "0x30")]
		public long fullStoredTime;

		// Token: 0x04006BBD RID: 27581
		[Token(Token = "0x4006BBD")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;

		// Token: 0x04006BBE RID: 27582
		[Token(Token = "0x4006BBE")]
		[FieldOffset(Offset = "0x40")]
		public string priceItemId;

		// Token: 0x04006BBF RID: 27583
		[Token(Token = "0x4006BBF")]
		[FieldOffset(Offset = "0x48")]
		public string templateShopId;

		// Token: 0x04006BC0 RID: 27584
		[Token(Token = "0x4006BC0")]
		[FieldOffset(Offset = "0x50")]
		public List<SandboxPermBasicData.HomeEntryDisplayData> homeEntryDisplayData;

		// Token: 0x04006BC1 RID: 27585
		[Token(Token = "0x4006BC1")]
		[FieldOffset(Offset = "0x58")]
		public string webBusType;

		// Token: 0x04006BC2 RID: 27586
		[Token(Token = "0x4006BC2")]
		[FieldOffset(Offset = "0x60")]
		public string medalGroupId;

		// Token: 0x020012FF RID: 4863
		[Token(Token = "0x20012FF")]
		public class HomeEntryDisplayData : ITimeValidInfo, IComparable
		{
			// Token: 0x0600727A RID: 29306 RVA: 0x00032E08 File Offset: 0x00031008
			[Token(Token = "0x600727A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "4")]
			public long GetStartTs()
			{
				return 0L;
			}

			// Token: 0x0600727B RID: 29307 RVA: 0x00032E20 File Offset: 0x00031020
			[Token(Token = "0x600727B")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "5")]
			public long GetEndTs()
			{
				return 0L;
			}

			// Token: 0x0600727C RID: 29308 RVA: 0x00032E38 File Offset: 0x00031038
			[Token(Token = "0x600727C")]
			[Address(RVA = "0x22064F0", Offset = "0x22050F0", VA = "0x1822064F0", Slot = "6")]
			public int CompareTo(object obj)
			{
				return 0;
			}

			// Token: 0x0600727D RID: 29309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600727D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HomeEntryDisplayData()
			{
			}

			// Token: 0x04006BC3 RID: 27587
			[Token(Token = "0x4006BC3")]
			[FieldOffset(Offset = "0x10")]
			public string displayId;

			// Token: 0x04006BC4 RID: 27588
			[Token(Token = "0x4006BC4")]
			[FieldOffset(Offset = "0x18")]
			public string topicId;

			// Token: 0x04006BC5 RID: 27589
			[Token(Token = "0x4006BC5")]
			[FieldOffset(Offset = "0x20")]
			public long startTs;

			// Token: 0x04006BC6 RID: 27590
			[Token(Token = "0x4006BC6")]
			[FieldOffset(Offset = "0x28")]
			public long endTs;
		}
	}
}
