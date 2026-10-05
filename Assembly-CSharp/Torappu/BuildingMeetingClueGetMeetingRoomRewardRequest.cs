using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000676 RID: 1654
	[Token(Token = "0x2000676")]
	public class BuildingMeetingClueGetMeetingRoomRewardRequest : BuildingRequest
	{
		// Token: 0x060062A4 RID: 25252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingMeetingClueGetMeetingRoomRewardRequest()
		{
		}

		// Token: 0x04002E31 RID: 11825
		[Token(Token = "0x4002E31")]
		[FieldOffset(Offset = "0x10")]
		public List<int> type;
	}
}
