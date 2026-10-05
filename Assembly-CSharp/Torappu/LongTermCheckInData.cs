using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010DE RID: 4318
	[Token(Token = "0x20010DE")]
	public class LongTermCheckInData
	{
		// Token: 0x06006E82 RID: 28290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E82")]
		[Address(RVA = "0x2106B90", Offset = "0x2105790", VA = "0x182106B90")]
		public LongTermCheckInData()
		{
		}

		// Token: 0x04005C82 RID: 23682
		[Token(Token = "0x4005C82")]
		[FieldOffset(Offset = "0x10")]
		public List<LongTermCheckInGroupData> groupList;

		// Token: 0x04005C83 RID: 23683
		[Token(Token = "0x4005C83")]
		[FieldOffset(Offset = "0x18")]
		public LongTermCheckInConstData constData;
	}
}
