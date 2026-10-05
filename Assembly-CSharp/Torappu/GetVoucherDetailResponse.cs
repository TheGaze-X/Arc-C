using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000791 RID: 1937
	[Token(Token = "0x2000791")]
	public class GetVoucherDetailResponse
	{
		// Token: 0x06006411 RID: 25617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006411")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetVoucherDetailResponse()
		{
		}

		// Token: 0x0400305B RID: 12379
		[Token(Token = "0x400305B")]
		[FieldOffset(Offset = "0x10")]
		public OptionalVoucherType voucherType;

		// Token: 0x0400305C RID: 12380
		[Token(Token = "0x400305C")]
		[FieldOffset(Offset = "0x14")]
		public int pickNum;

		// Token: 0x0400305D RID: 12381
		[Token(Token = "0x400305D")]
		[FieldOffset(Offset = "0x18")]
		public string voucherBgDec;

		// Token: 0x0400305E RID: 12382
		[Token(Token = "0x400305E")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, OptionalVoucherExtraData> extraDataDic;

		// Token: 0x0400305F RID: 12383
		[Token(Token = "0x400305F")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> itemList;

		// Token: 0x04003060 RID: 12384
		[Token(Token = "0x4003060")]
		[FieldOffset(Offset = "0x30")]
		public OptionalVoucherValidInfo validTimeInfo;

		// Token: 0x04003061 RID: 12385
		[Token(Token = "0x4003061")]
		[FieldOffset(Offset = "0x38")]
		public string voucherDescDetail;
	}
}
