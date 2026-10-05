using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001423 RID: 5155
	[Token(Token = "0x2001423")]
	public class FriendMedalTemplateGroupInfo
	{
		// Token: 0x060076E4 RID: 30436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E4")]
		[Address(RVA = "0x241F060", Offset = "0x241DC60", VA = "0x18241F060")]
		public FriendMedalTemplateGroupInfo()
		{
		}

		// Token: 0x04007451 RID: 29777
		[Token(Token = "0x4007451")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04007452 RID: 29778
		[Token(Token = "0x4007452")]
		[FieldOffset(Offset = "0x18")]
		public List<string> medalList;
	}
}
