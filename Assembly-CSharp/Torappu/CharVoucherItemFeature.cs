using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010BE RID: 4286
	[Token(Token = "0x20010BE")]
	[Serializable]
	public class CharVoucherItemFeature
	{
		// Token: 0x06006E56 RID: 28246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E56")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharVoucherItemFeature()
		{
		}

		// Token: 0x04005BB2 RID: 23474
		[Token(Token = "0x4005BB2")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005BB3 RID: 23475
		[Token(Token = "0x4005BB3")]
		[FieldOffset(Offset = "0x18")]
		public VoucherDisplayType displayType;
	}
}
