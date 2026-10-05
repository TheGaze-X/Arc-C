using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012C5 RID: 4805
	[Token(Token = "0x20012C5")]
	public class SandboxV2ExpeditionData
	{
		// Token: 0x0600723E RID: 29246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600723E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ExpeditionData()
		{
		}

		// Token: 0x04006A25 RID: 27173
		[Token(Token = "0x4006A25")]
		[FieldOffset(Offset = "0x10")]
		public string expeditionId;

		// Token: 0x04006A26 RID: 27174
		[Token(Token = "0x4006A26")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x04006A27 RID: 27175
		[Token(Token = "0x4006A27")]
		[FieldOffset(Offset = "0x20")]
		public string effectDesc;

		// Token: 0x04006A28 RID: 27176
		[Token(Token = "0x4006A28")]
		[FieldOffset(Offset = "0x28")]
		public int costAction;

		// Token: 0x04006A29 RID: 27177
		[Token(Token = "0x4006A29")]
		[FieldOffset(Offset = "0x2C")]
		public int costDrink;

		// Token: 0x04006A2A RID: 27178
		[Token(Token = "0x4006A2A")]
		[FieldOffset(Offset = "0x30")]
		public int charCnt;

		// Token: 0x04006A2B RID: 27179
		[Token(Token = "0x4006A2B")]
		[FieldOffset(Offset = "0x34")]
		public ProfessionCategory profession;

		// Token: 0x04006A2C RID: 27180
		[Token(Token = "0x4006A2C")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
		public List<ProfessionID> professions;

		// Token: 0x04006A2D RID: 27181
		[Token(Token = "0x4006A2D")]
		[FieldOffset(Offset = "0x40")]
		public int minEliteRank;

		// Token: 0x04006A2E RID: 27182
		[Token(Token = "0x4006A2E")]
		[FieldOffset(Offset = "0x44")]
		public int duration;
	}
}
