using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000868 RID: 2152
	[Token(Token = "0x2000868")]
	public class SDVoucher
	{
		// Token: 0x06006503 RID: 25859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006503")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SDVoucher()
		{
		}

		// Token: 0x040031A9 RID: 12713
		[Token(Token = "0x40031A9")]
		[FieldOffset(Offset = "0x10")]
		public OptionalVoucherType voucherType;

		// Token: 0x040031AA RID: 12714
		[Token(Token = "0x40031AA")]
		[FieldOffset(Offset = "0x14")]
		public int pickNum;

		// Token: 0x040031AB RID: 12715
		[Token(Token = "0x40031AB")]
		[FieldOffset(Offset = "0x18")]
		public string voucherBgDec;

		// Token: 0x040031AC RID: 12716
		[Token(Token = "0x40031AC")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, OptionalVoucherExtraData> extraDataDic;

		// Token: 0x040031AD RID: 12717
		[Token(Token = "0x40031AD")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> itemList;

		// Token: 0x040031AE RID: 12718
		[Token(Token = "0x40031AE")]
		[FieldOffset(Offset = "0x30")]
		public OptionalVoucherValidInfo validTimeInfo;

		// Token: 0x040031AF RID: 12719
		[Token(Token = "0x40031AF")]
		[FieldOffset(Offset = "0x38")]
		public string voucherDescDetail;
	}
}
