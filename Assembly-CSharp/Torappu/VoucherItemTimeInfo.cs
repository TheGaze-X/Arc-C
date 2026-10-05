using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001129 RID: 4393
	[Token(Token = "0x2001129")]
	public class VoucherItemTimeInfo
	{
		// Token: 0x06006EEE RID: 28398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EEE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VoucherItemTimeInfo()
		{
		}

		// Token: 0x04005E27 RID: 24103
		[Token(Token = "0x4005E27")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04005E28 RID: 24104
		[Token(Token = "0x4005E28")]
		[FieldOffset(Offset = "0x18")]
		public long startTs;
	}
}
