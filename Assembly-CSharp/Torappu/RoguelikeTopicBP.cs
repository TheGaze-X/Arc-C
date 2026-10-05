using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011EB RID: 4587
	[Token(Token = "0x20011EB")]
	public class RoguelikeTopicBP
	{
		// Token: 0x06006FD9 RID: 28633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FD9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicBP()
		{
		}

		// Token: 0x04006286 RID: 25222
		[Token(Token = "0x4006286")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006287 RID: 25223
		[Token(Token = "0x4006287")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x04006288 RID: 25224
		[Token(Token = "0x4006288")]
		[FieldOffset(Offset = "0x1C")]
		public int tokenNum;

		// Token: 0x04006289 RID: 25225
		[Token(Token = "0x4006289")]
		[FieldOffset(Offset = "0x20")]
		public int nextTokenNum;

		// Token: 0x0400628A RID: 25226
		[Token(Token = "0x400628A")]
		[FieldOffset(Offset = "0x28")]
		public string itemID;

		// Token: 0x0400628B RID: 25227
		[Token(Token = "0x400628B")]
		[FieldOffset(Offset = "0x30")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType itemType;

		// Token: 0x0400628C RID: 25228
		[Token(Token = "0x400628C")]
		[FieldOffset(Offset = "0x34")]
		public int itemCount;

		// Token: 0x0400628D RID: 25229
		[Token(Token = "0x400628D")]
		[FieldOffset(Offset = "0x38")]
		public bool isGoodPrize;

		// Token: 0x0400628E RID: 25230
		[Token(Token = "0x400628E")]
		[FieldOffset(Offset = "0x39")]
		public bool isGrandPrize;

		// Token: 0x0400628F RID: 25231
		[Token(Token = "0x400628F")]
		[FieldOffset(Offset = "0x3A")]
		public bool isReturnDisplay;

		// Token: 0x04006290 RID: 25232
		[Token(Token = "0x4006290")]
		[FieldOffset(Offset = "0x3C")]
		public int returnSortId;
	}
}
