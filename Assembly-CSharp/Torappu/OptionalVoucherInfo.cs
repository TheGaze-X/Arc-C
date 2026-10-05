using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001128 RID: 4392
	[Token(Token = "0x2001128")]
	[Serializable]
	public class OptionalVoucherInfo
	{
		// Token: 0x06006EEB RID: 28395 RVA: 0x00032388 File Offset: 0x00030588
		[Token(Token = "0x6006EEB")]
		[Address(RVA = "0x1FFA6F0", Offset = "0x1FF92F0", VA = "0x181FFA6F0")]
		public bool ShouldSerializevoucherDescDetail()
		{
			return default(bool);
		}

		// Token: 0x06006EEC RID: 28396 RVA: 0x000323A0 File Offset: 0x000305A0
		[Token(Token = "0x6006EEC")]
		[Address(RVA = "0x1FFA6F0", Offset = "0x1FF92F0", VA = "0x181FFA6F0")]
		public bool ShouldSerializeitemTimeInfoList()
		{
			return default(bool);
		}

		// Token: 0x06006EED RID: 28397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EED")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public OptionalVoucherInfo()
		{
		}

		// Token: 0x04005E1F RID: 24095
		[Token(Token = "0x4005E1F")]
		[FieldOffset(Offset = "0x10")]
		[JsonConverter(typeof(StringEnumConverter))]
		public OptionalVoucherType voucherType;

		// Token: 0x04005E20 RID: 24096
		[Token(Token = "0x4005E20")]
		[FieldOffset(Offset = "0x14")]
		public int pickNum;

		// Token: 0x04005E21 RID: 24097
		[Token(Token = "0x4005E21")]
		[FieldOffset(Offset = "0x18")]
		public string voucherBgDec;

		// Token: 0x04005E22 RID: 24098
		[Token(Token = "0x4005E22")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, OptionalVoucherExtraData> extraDataDic;

		// Token: 0x04005E23 RID: 24099
		[Token(Token = "0x4005E23")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> itemList;

		// Token: 0x04005E24 RID: 24100
		[Token(Token = "0x4005E24")]
		[FieldOffset(Offset = "0x30")]
		public List<VoucherItemTimeInfo> itemTimeInfoList;

		// Token: 0x04005E25 RID: 24101
		[Token(Token = "0x4005E25")]
		[FieldOffset(Offset = "0x38")]
		public OptionalVoucherValidInfo validTimeInfo;

		// Token: 0x04005E26 RID: 24102
		[Token(Token = "0x4005E26")]
		[FieldOffset(Offset = "0x40")]
		public string voucherDescDetail;
	}
}
