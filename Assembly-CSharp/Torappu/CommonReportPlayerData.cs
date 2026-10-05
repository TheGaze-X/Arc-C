using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FA7 RID: 4007
	[Token(Token = "0x2000FA7")]
	public class CommonReportPlayerData
	{
		// Token: 0x06006CF0 RID: 27888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CommonReportPlayerData()
		{
		}

		// Token: 0x04005514 RID: 21780
		[Token(Token = "0x4005514")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005515 RID: 21781
		[Token(Token = "0x4005515")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04005516 RID: 21782
		[Token(Token = "0x4005516")]
		[FieldOffset(Offset = "0x20")]
		public string txt;

		// Token: 0x04005517 RID: 21783
		[Token(Token = "0x4005517")]
		[FieldOffset(Offset = "0x28")]
		public string desc;
	}
}
