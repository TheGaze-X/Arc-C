using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020010A2 RID: 4258
	[Token(Token = "0x20010A2")]
	public class HotUpdateMetaPicData : ITimeValidInfo
	{
		// Token: 0x06006E2F RID: 28207 RVA: 0x00031F98 File Offset: 0x00030198
		[Token(Token = "0x6006E2F")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x06006E30 RID: 28208 RVA: 0x00031FB0 File Offset: 0x000301B0
		[Token(Token = "0x6006E30")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x06006E31 RID: 28209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E31")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HotUpdateMetaPicData()
		{
		}

		// Token: 0x04005AD4 RID: 23252
		[Token(Token = "0x4005AD4")]
		[FieldOffset(Offset = "0x10")]
		public string picId;

		// Token: 0x04005AD5 RID: 23253
		[Token(Token = "0x4005AD5")]
		[FieldOffset(Offset = "0x18")]
		public int groupId;

		// Token: 0x04005AD6 RID: 23254
		[Token(Token = "0x4005AD6")]
		[FieldOffset(Offset = "0x1C")]
		public int sortId;

		// Token: 0x04005AD7 RID: 23255
		[Token(Token = "0x4005AD7")]
		[FieldOffset(Offset = "0x20")]
		public long startTime;

		// Token: 0x04005AD8 RID: 23256
		[Token(Token = "0x4005AD8")]
		[FieldOffset(Offset = "0x28")]
		public long endTime;

		// Token: 0x04005AD9 RID: 23257
		[Token(Token = "0x4005AD9")]
		[FieldOffset(Offset = "0x30")]
		public List<string> textList;

		// Token: 0x04005ADA RID: 23258
		[Token(Token = "0x4005ADA")]
		[FieldOffset(Offset = "0x38")]
		public HotUpdateMetaPicData.PicType picType;

		// Token: 0x04005ADB RID: 23259
		[Token(Token = "0x4005ADB")]
		[FieldOffset(Offset = "0x40")]
		public string logoId;

		// Token: 0x04005ADC RID: 23260
		[Token(Token = "0x4005ADC")]
		[FieldOffset(Offset = "0x48")]
		public string color;

		// Token: 0x020010A3 RID: 4259
		[Token(Token = "0x20010A3")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum PicType
		{
			// Token: 0x04005ADE RID: 23262
			[Token(Token = "0x4005ADE")]
			NONE,
			// Token: 0x04005ADF RID: 23263
			[Token(Token = "0x4005ADF")]
			SKIN
		}
	}
}
