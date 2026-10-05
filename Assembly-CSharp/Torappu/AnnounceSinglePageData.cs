using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E99 RID: 3737
	[Token(Token = "0x2000E99")]
	public class AnnounceSinglePageData
	{
		// Token: 0x06006B69 RID: 27497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B69")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AnnounceSinglePageData()
		{
		}

		// Token: 0x04004EE3 RID: 20195
		[Token(Token = "0x4004EE3")]
		[FieldOffset(Offset = "0x10")]
		public string announceId;

		// Token: 0x04004EE4 RID: 20196
		[Token(Token = "0x4004EE4")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04004EE5 RID: 20197
		[Token(Token = "0x4004EE5")]
		[FieldOffset(Offset = "0x20")]
		public bool isWebUrl;

		// Token: 0x04004EE6 RID: 20198
		[Token(Token = "0x4004EE6")]
		[FieldOffset(Offset = "0x24")]
		[JsonConverter(typeof(StringEnumConverter))]
		public AnnounceGroup group;

		// Token: 0x04004EE7 RID: 20199
		[Token(Token = "0x4004EE7")]
		[FieldOffset(Offset = "0x28")]
		public string webUrl;

		// Token: 0x04004EE8 RID: 20200
		[Token(Token = "0x4004EE8")]
		[FieldOffset(Offset = "0x30")]
		public int day;

		// Token: 0x04004EE9 RID: 20201
		[Token(Token = "0x4004EE9")]
		[FieldOffset(Offset = "0x34")]
		public int month;
	}
}
