using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000782 RID: 1922
	[Token(Token = "0x2000782")]
	public class CharGachaVoucherData
	{
		// Token: 0x060063FA RID: 25594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharGachaVoucherData()
		{
		}

		// Token: 0x04003025 RID: 12325
		[Token(Token = "0x4003025")]
		[FieldOffset(Offset = "0x10")]
		public string voucherId;

		// Token: 0x04003026 RID: 12326
		[Token(Token = "0x4003026")]
		[FieldOffset(Offset = "0x18")]
		public int pickNum;

		// Token: 0x04003027 RID: 12327
		[Token(Token = "0x4003027")]
		[FieldOffset(Offset = "0x1C")]
		public bool hasSecurity;

		// Token: 0x04003028 RID: 12328
		[Token(Token = "0x4003028")]
		[FieldOffset(Offset = "0x20")]
		public int securityRarity;

		// Token: 0x04003029 RID: 12329
		[Token(Token = "0x4003029")]
		[FieldOffset(Offset = "0x28")]
		public long startTime;

		// Token: 0x0400302A RID: 12330
		[Token(Token = "0x400302A")]
		[FieldOffset(Offset = "0x30")]
		public long endTime;

		// Token: 0x0400302B RID: 12331
		[Token(Token = "0x400302B")]
		[FieldOffset(Offset = "0x38")]
		[JsonConverter(typeof(StringEnumConverter))]
		public GachaVoucherType voucherType;

		// Token: 0x0400302C RID: 12332
		[Token(Token = "0x400302C")]
		[FieldOffset(Offset = "0x40")]
		public List<RarityRate> rarityRateList;

		// Token: 0x0400302D RID: 12333
		[Token(Token = "0x400302D")]
		[FieldOffset(Offset = "0x48")]
		public List<CharGachaVoucherPool> pool;

		// Token: 0x0400302E RID: 12334
		[Token(Token = "0x400302E")]
		[FieldOffset(Offset = "0x50")]
		public GachaDetailData detailData;
	}
}
