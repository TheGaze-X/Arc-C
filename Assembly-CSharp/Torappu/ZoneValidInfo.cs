using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013C5 RID: 5061
	[Token(Token = "0x20013C5")]
	public class ZoneValidInfo : ITimeValidInfo
	{
		// Token: 0x060073B4 RID: 29620 RVA: 0x00033768 File Offset: 0x00031968
		[Token(Token = "0x60073B4")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x00033780 File Offset: 0x00031980
		[Token(Token = "0x60073B5")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ZoneValidInfo()
		{
		}

		// Token: 0x04007091 RID: 28817
		[Token(Token = "0x4007091")]
		[FieldOffset(Offset = "0x10")]
		public long startTs;

		// Token: 0x04007092 RID: 28818
		[Token(Token = "0x4007092")]
		[FieldOffset(Offset = "0x18")]
		public long endTs;
	}
}
