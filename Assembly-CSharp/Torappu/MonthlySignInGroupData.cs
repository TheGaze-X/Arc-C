using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F8B RID: 3979
	[Token(Token = "0x2000F8B")]
	public class MonthlySignInGroupData
	{
		// Token: 0x06006CCD RID: 27853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCD")]
		[Address(RVA = "0x2108460", Offset = "0x2107060", VA = "0x182108460")]
		public MonthlySignInGroupData()
		{
		}

		// Token: 0x04005485 RID: 21637
		[Token(Token = "0x4005485")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005486 RID: 21638
		[Token(Token = "0x4005486")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04005487 RID: 21639
		[Token(Token = "0x4005487")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x04005488 RID: 21640
		[Token(Token = "0x4005488")]
		[FieldOffset(Offset = "0x28")]
		public long signStartTime;

		// Token: 0x04005489 RID: 21641
		[Token(Token = "0x4005489")]
		[FieldOffset(Offset = "0x30")]
		public long signEndTime;

		// Token: 0x0400548A RID: 21642
		[Token(Token = "0x400548A")]
		[FieldOffset(Offset = "0x38")]
		public List<MonthlySignInData> items;
	}
}
