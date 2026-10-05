using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E98 RID: 3736
	[Token(Token = "0x2000E98")]
	public class AnnounceData
	{
		// Token: 0x06006B68 RID: 27496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B68")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AnnounceData()
		{
		}

		// Token: 0x04004EE1 RID: 20193
		[Token(Token = "0x4004EE1")]
		[FieldOffset(Offset = "0x10")]
		public List<AnnounceSinglePageData> announceList;

		// Token: 0x04004EE2 RID: 20194
		[Token(Token = "0x4004EE2")]
		[FieldOffset(Offset = "0x18")]
		public string focusAnnounceId;
	}
}
