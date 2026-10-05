using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A63 RID: 2659
	[Token(Token = "0x2000A63")]
	public class PlayerBuildingMeetingInfoShareState
	{
		// Token: 0x06006722 RID: 26402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006722")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingMeetingInfoShareState()
		{
		}

		// Token: 0x04003886 RID: 14470
		[Token(Token = "0x4003886")]
		[FieldOffset(Offset = "0x10")]
		public long ts;

		// Token: 0x04003887 RID: 14471
		[Token(Token = "0x4003887")]
		[FieldOffset(Offset = "0x18")]
		public int reward;
	}
}
