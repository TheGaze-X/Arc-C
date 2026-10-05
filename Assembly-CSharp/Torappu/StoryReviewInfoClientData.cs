using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001385 RID: 4997
	[Token(Token = "0x2001385")]
	public class StoryReviewInfoClientData
	{
		// Token: 0x06007368 RID: 29544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007368")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StoryReviewInfoClientData()
		{
		}

		// Token: 0x04006EE3 RID: 28387
		[Token(Token = "0x4006EE3")]
		[FieldOffset(Offset = "0x10")]
		public StoryReviewType storyReviewType;

		// Token: 0x04006EE4 RID: 28388
		[Token(Token = "0x4006EE4")]
		[FieldOffset(Offset = "0x18")]
		public string storyId;

		// Token: 0x04006EE5 RID: 28389
		[Token(Token = "0x4006EE5")]
		[FieldOffset(Offset = "0x20")]
		public string storyGroup;

		// Token: 0x04006EE6 RID: 28390
		[Token(Token = "0x4006EE6")]
		[FieldOffset(Offset = "0x28")]
		public int storySort;

		// Token: 0x04006EE7 RID: 28391
		[Token(Token = "0x4006EE7")]
		[FieldOffset(Offset = "0x30")]
		public string storyDependence;

		// Token: 0x04006EE8 RID: 28392
		[Token(Token = "0x4006EE8")]
		[FieldOffset(Offset = "0x38")]
		public int storyCanShow;

		// Token: 0x04006EE9 RID: 28393
		[Token(Token = "0x4006EE9")]
		[FieldOffset(Offset = "0x40")]
		public string storyCode;

		// Token: 0x04006EEA RID: 28394
		[Token(Token = "0x4006EEA")]
		[FieldOffset(Offset = "0x48")]
		public string storyName;

		// Token: 0x04006EEB RID: 28395
		[Token(Token = "0x4006EEB")]
		[FieldOffset(Offset = "0x50")]
		public string storyPic;

		// Token: 0x04006EEC RID: 28396
		[Token(Token = "0x4006EEC")]
		[FieldOffset(Offset = "0x58")]
		public string storyInfo;

		// Token: 0x04006EED RID: 28397
		[Token(Token = "0x4006EED")]
		[FieldOffset(Offset = "0x60")]
		public int storyCanEnter;

		// Token: 0x04006EEE RID: 28398
		[Token(Token = "0x4006EEE")]
		[FieldOffset(Offset = "0x68")]
		public string storyTxt;

		// Token: 0x04006EEF RID: 28399
		[Token(Token = "0x4006EEF")]
		[FieldOffset(Offset = "0x70")]
		public string avgTag;

		// Token: 0x04006EF0 RID: 28400
		[Token(Token = "0x4006EF0")]
		[FieldOffset(Offset = "0x78")]
		[JsonConverter(typeof(StringEnumConverter))]
		public StoryReviewUnlockType unLockType;

		// Token: 0x04006EF1 RID: 28401
		[Token(Token = "0x4006EF1")]
		[FieldOffset(Offset = "0x7C")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType costItemType;

		// Token: 0x04006EF2 RID: 28402
		[Token(Token = "0x4006EF2")]
		[FieldOffset(Offset = "0x80")]
		public string costItemId;

		// Token: 0x04006EF3 RID: 28403
		[Token(Token = "0x4006EF3")]
		[FieldOffset(Offset = "0x88")]
		public int costItemCount;

		// Token: 0x04006EF4 RID: 28404
		[Token(Token = "0x4006EF4")]
		[FieldOffset(Offset = "0x8C")]
		public int stageCount;

		// Token: 0x04006EF5 RID: 28405
		[Token(Token = "0x4006EF5")]
		[FieldOffset(Offset = "0x90")]
		public StoryData.Condition.StageCondition[] requiredStages;
	}
}
