using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000798 RID: 1944
	[Token(Token = "0x2000798")]
	public class VoucherCharDetailResponse
	{
		// Token: 0x06006418 RID: 25624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006418")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VoucherCharDetailResponse()
		{
		}

		// Token: 0x0400306E RID: 12398
		[Token(Token = "0x400306E")]
		[FieldOffset(Offset = "0x10")]
		public CharGachaVoucherData info;
	}
}
