using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200112A RID: 4394
	[Token(Token = "0x200112A")]
	public class OptionalVoucherValidInfo : ITimeValidInfo
	{
		// Token: 0x06006EEF RID: 28399 RVA: 0x000323B8 File Offset: 0x000305B8
		[Token(Token = "0x6006EEF")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x06006EF0 RID: 28400 RVA: 0x000323D0 File Offset: 0x000305D0
		[Token(Token = "0x6006EF0")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x06006EF1 RID: 28401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public OptionalVoucherValidInfo()
		{
		}

		// Token: 0x04005E29 RID: 24105
		[Token(Token = "0x4005E29")]
		[FieldOffset(Offset = "0x10")]
		public long startTs;

		// Token: 0x04005E2A RID: 24106
		[Token(Token = "0x4005E2A")]
		[FieldOffset(Offset = "0x18")]
		public long endTs;
	}
}
