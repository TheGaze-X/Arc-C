using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001142 RID: 4418
	[Token(Token = "0x2001142")]
	public class ReturnCheckinGroupData
	{
		// Token: 0x06006F1E RID: 28446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F1E")]
		[Address(RVA = "0x210F710", Offset = "0x210E310", VA = "0x18210F710")]
		public ReturnCheckinGroupData()
		{
		}

		// Token: 0x04005EB8 RID: 24248
		[Token(Token = "0x4005EB8")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005EB9 RID: 24249
		[Token(Token = "0x4005EB9")]
		[FieldOffset(Offset = "0x18")]
		public List<ReturnCheckinItemData> checkinItemList;
	}
}
