using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001125 RID: 4389
	[Token(Token = "0x2001125")]
	public class OpenServerSchedule
	{
		// Token: 0x06006EE9 RID: 28393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE9")]
		[Address(RVA = "0x2108F40", Offset = "0x2107B40", VA = "0x182108F40")]
		public OpenServerSchedule()
		{
		}

		// Token: 0x04005E13 RID: 24083
		[Token(Token = "0x4005E13")]
		[FieldOffset(Offset = "0x10")]
		public List<OpenServerScheduleItem> schedule;

		// Token: 0x04005E14 RID: 24084
		[Token(Token = "0x4005E14")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, OpenServerData> dataMap;

		// Token: 0x04005E15 RID: 24085
		[Token(Token = "0x4005E15")]
		[FieldOffset(Offset = "0x20")]
		public OpenServerConst constant;

		// Token: 0x04005E16 RID: 24086
		[Token(Token = "0x4005E16")]
		[FieldOffset(Offset = "0x28")]
		public ReturnData playerReturn;

		// Token: 0x04005E17 RID: 24087
		[Token(Token = "0x4005E17")]
		[FieldOffset(Offset = "0x30")]
		public List<NewbieCheckInPackageData> newbieCheckInPackageList;

		// Token: 0x04005E18 RID: 24088
		[Token(Token = "0x4005E18")]
		[FieldOffset(Offset = "0x38")]
		public LongTermCheckInData longTermCheckInData;
	}
}
