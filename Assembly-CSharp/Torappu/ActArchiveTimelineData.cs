using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C48 RID: 3144
	[Token(Token = "0x2000C48")]
	[Serializable]
	public class ActArchiveTimelineData
	{
		// Token: 0x06006928 RID: 26920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006928")]
		[Address(RVA = "0x1FF8F90", Offset = "0x1FF7B90", VA = "0x181FF8F90")]
		public ActArchiveTimelineData()
		{
		}

		// Token: 0x04004019 RID: 16409
		[Token(Token = "0x4004019")]
		[FieldOffset(Offset = "0x10")]
		public List<ActArchiveTimelineItemData> timelineList;
	}
}
