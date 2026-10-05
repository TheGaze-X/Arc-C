using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F86 RID: 3974
	[Token(Token = "0x2000F86")]
	public class FestivalTimeInterval : ITimeValidInfo
	{
		// Token: 0x06006CC5 RID: 27845 RVA: 0x000319F8 File Offset: 0x0002FBF8
		[Token(Token = "0x6006CC5")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x00031A10 File Offset: 0x0002FC10
		[Token(Token = "0x6006CC6")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FestivalTimeInterval()
		{
		}

		// Token: 0x04005479 RID: 21625
		[Token(Token = "0x4005479")]
		[FieldOffset(Offset = "0x10")]
		public long startTs;

		// Token: 0x0400547A RID: 21626
		[Token(Token = "0x400547A")]
		[FieldOffset(Offset = "0x18")]
		public long endTs;
	}
}
