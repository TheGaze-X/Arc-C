using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001386 RID: 4998
	[Token(Token = "0x2001386")]
	public class StoryReviewGroupClientData
	{
		// Token: 0x06007369 RID: 29545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007369")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StoryReviewGroupClientData()
		{
		}

		// Token: 0x04006EF6 RID: 28406
		[Token(Token = "0x4006EF6")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006EF7 RID: 28407
		[Token(Token = "0x4006EF7")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04006EF8 RID: 28408
		[Token(Token = "0x4006EF8")]
		[FieldOffset(Offset = "0x20")]
		[JsonConverter(typeof(StringEnumConverter))]
		public StoryReviewEntryType entryType;

		// Token: 0x04006EF9 RID: 28409
		[Token(Token = "0x4006EF9")]
		[FieldOffset(Offset = "0x24")]
		[JsonConverter(typeof(StringEnumConverter))]
		public StoryReviewType actType;

		// Token: 0x04006EFA RID: 28410
		[Token(Token = "0x4006EFA")]
		[FieldOffset(Offset = "0x28")]
		public long startTime;

		// Token: 0x04006EFB RID: 28411
		[Token(Token = "0x4006EFB")]
		[FieldOffset(Offset = "0x30")]
		public long endTime;

		// Token: 0x04006EFC RID: 28412
		[Token(Token = "0x4006EFC")]
		[FieldOffset(Offset = "0x38")]
		public long startShowTime;

		// Token: 0x04006EFD RID: 28413
		[Token(Token = "0x4006EFD")]
		[FieldOffset(Offset = "0x40")]
		public long endShowTime;

		// Token: 0x04006EFE RID: 28414
		[Token(Token = "0x4006EFE")]
		[FieldOffset(Offset = "0x48")]
		public long remakeStartTime;

		// Token: 0x04006EFF RID: 28415
		[Token(Token = "0x4006EFF")]
		[FieldOffset(Offset = "0x50")]
		public long remakeEndTime;

		// Token: 0x04006F00 RID: 28416
		[Token(Token = "0x4006F00")]
		[FieldOffset(Offset = "0x58")]
		public string storyEntryPicId;

		// Token: 0x04006F01 RID: 28417
		[Token(Token = "0x4006F01")]
		[FieldOffset(Offset = "0x60")]
		public string storyPicId;

		// Token: 0x04006F02 RID: 28418
		[Token(Token = "0x4006F02")]
		[FieldOffset(Offset = "0x68")]
		public string storyMainColor;

		// Token: 0x04006F03 RID: 28419
		[Token(Token = "0x4006F03")]
		[FieldOffset(Offset = "0x70")]
		public int customType;

		// Token: 0x04006F04 RID: 28420
		[Token(Token = "0x4006F04")]
		[FieldOffset(Offset = "0x78")]
		public string storyCompleteMedalId;

		// Token: 0x04006F05 RID: 28421
		[Token(Token = "0x4006F05")]
		[FieldOffset(Offset = "0x80")]
		public ItemBundle[] rewards;

		// Token: 0x04006F06 RID: 28422
		[Token(Token = "0x4006F06")]
		[FieldOffset(Offset = "0x88")]
		public List<StoryReviewInfoClientData> infoUnlockDatas;
	}
}
