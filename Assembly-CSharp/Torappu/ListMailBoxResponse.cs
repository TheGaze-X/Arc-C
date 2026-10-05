using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020007A9 RID: 1961
	[Token(Token = "0x20007A9")]
	public class ListMailBoxResponse : PlayerDeltaResponse
	{
		// Token: 0x0600642B RID: 25643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600642B")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ListMailBoxResponse()
		{
		}

		// Token: 0x0400309C RID: 12444
		[Token(Token = "0x400309C")]
		[FieldOffset(Offset = "0x28")]
		public List<ListMailBoxResponse.MailItem> mailList;

		// Token: 0x0400309D RID: 12445
		[Token(Token = "0x400309D")]
		[FieldOffset(Offset = "0x30")]
		public List<ListMailBoxResponse.SurveyItem> surveyMailList;

		// Token: 0x020007AA RID: 1962
		[Token(Token = "0x20007AA")]
		public struct MailReward
		{
			// Token: 0x0400309E RID: 12446
			[Token(Token = "0x400309E")]
			[FieldOffset(Offset = "0x0")]
			[JsonConverter(typeof(StringEnumConverter))]
			public ItemType type;

			// Token: 0x0400309F RID: 12447
			[Token(Token = "0x400309F")]
			[FieldOffset(Offset = "0x8")]
			public string id;

			// Token: 0x040030A0 RID: 12448
			[Token(Token = "0x40030A0")]
			[FieldOffset(Offset = "0x10")]
			public int count;
		}

		// Token: 0x020007AB RID: 1963
		[Token(Token = "0x20007AB")]
		public enum MailRoute
		{
			// Token: 0x040030A2 RID: 12450
			[Token(Token = "0x40030A2")]
			NORMAL,
			// Token: 0x040030A3 RID: 12451
			[Token(Token = "0x40030A3")]
			TO_MONTHLYSUB
		}

		// Token: 0x020007AC RID: 1964
		[Token(Token = "0x20007AC")]
		public class MailStyle
		{
			// Token: 0x0600642C RID: 25644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600642C")]
			[Address(RVA = "0x1EEB390", Offset = "0x1EE9F90", VA = "0x181EEB390")]
			public MailStyle()
			{
			}

			// Token: 0x040030A4 RID: 12452
			[Token(Token = "0x40030A4")]
			[FieldOffset(Offset = "0x10")]
			public ListMailBoxResponse.MailRoute route;

			// Token: 0x040030A5 RID: 12453
			[Token(Token = "0x40030A5")]
			[FieldOffset(Offset = "0x18")]
			public string banner;
		}

		// Token: 0x020007AD RID: 1965
		[Token(Token = "0x20007AD")]
		public struct MailItem
		{
			// Token: 0x040030A6 RID: 12454
			[Token(Token = "0x40030A6")]
			[FieldOffset(Offset = "0x0")]
			public long mailId;

			// Token: 0x040030A7 RID: 12455
			[Token(Token = "0x40030A7")]
			[FieldOffset(Offset = "0x8")]
			public MailFromInfo type;

			// Token: 0x040030A8 RID: 12456
			[Token(Token = "0x40030A8")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x040030A9 RID: 12457
			[Token(Token = "0x40030A9")]
			[FieldOffset(Offset = "0x18")]
			public List<ListMailBoxResponse.MailReward> items;

			// Token: 0x040030AA RID: 12458
			[Token(Token = "0x40030AA")]
			[FieldOffset(Offset = "0x20")]
			public string from;

			// Token: 0x040030AB RID: 12459
			[Token(Token = "0x40030AB")]
			[FieldOffset(Offset = "0x28")]
			public string subject;

			// Token: 0x040030AC RID: 12460
			[Token(Token = "0x40030AC")]
			[FieldOffset(Offset = "0x30")]
			public string content;

			// Token: 0x040030AD RID: 12461
			[Token(Token = "0x40030AD")]
			[FieldOffset(Offset = "0x38")]
			public DateTime createAt;

			// Token: 0x040030AE RID: 12462
			[Token(Token = "0x40030AE")]
			[FieldOffset(Offset = "0x40")]
			public DateTime expireAt;

			// Token: 0x040030AF RID: 12463
			[Token(Token = "0x40030AF")]
			[FieldOffset(Offset = "0x48")]
			public DateTime receiveAt;

			// Token: 0x040030B0 RID: 12464
			[Token(Token = "0x40030B0")]
			[FieldOffset(Offset = "0x50")]
			public int state;

			// Token: 0x040030B1 RID: 12465
			[Token(Token = "0x40030B1")]
			[FieldOffset(Offset = "0x58")]
			public ListMailBoxResponse.MailStyle style;

			// Token: 0x040030B2 RID: 12466
			[Token(Token = "0x40030B2")]
			[FieldOffset(Offset = "0x60")]
			public string collectionId;
		}

		// Token: 0x020007AE RID: 1966
		[Token(Token = "0x20007AE")]
		public struct SurveyItem
		{
			// Token: 0x040030B3 RID: 12467
			[Token(Token = "0x40030B3")]
			[FieldOffset(Offset = "0x0")]
			public string surveyMailId;

			// Token: 0x040030B4 RID: 12468
			[Token(Token = "0x40030B4")]
			[FieldOffset(Offset = "0x8")]
			public string uid;

			// Token: 0x040030B5 RID: 12469
			[Token(Token = "0x40030B5")]
			[FieldOffset(Offset = "0x10")]
			public string from;

			// Token: 0x040030B6 RID: 12470
			[Token(Token = "0x40030B6")]
			[FieldOffset(Offset = "0x18")]
			public string content;

			// Token: 0x040030B7 RID: 12471
			[Token(Token = "0x40030B7")]
			[FieldOffset(Offset = "0x20")]
			public string subject;

			// Token: 0x040030B8 RID: 12472
			[Token(Token = "0x40030B8")]
			[FieldOffset(Offset = "0x28")]
			public DateTime createAt;

			// Token: 0x040030B9 RID: 12473
			[Token(Token = "0x40030B9")]
			[FieldOffset(Offset = "0x30")]
			public DateTime expireAt;

			// Token: 0x040030BA RID: 12474
			[Token(Token = "0x40030BA")]
			[FieldOffset(Offset = "0x38")]
			public DateTime receiveAt;

			// Token: 0x040030BB RID: 12475
			[Token(Token = "0x40030BB")]
			[FieldOffset(Offset = "0x40")]
			public int state;

			// Token: 0x040030BC RID: 12476
			[Token(Token = "0x40030BC")]
			[FieldOffset(Offset = "0x44")]
			public MailFromInfo type;

			// Token: 0x040030BD RID: 12477
			[Token(Token = "0x40030BD")]
			[FieldOffset(Offset = "0x48")]
			public ListMailBoxResponse.MailStyle style;

			// Token: 0x040030BE RID: 12478
			[Token(Token = "0x40030BE")]
			[FieldOffset(Offset = "0x50")]
			public int platform;
		}
	}
}
