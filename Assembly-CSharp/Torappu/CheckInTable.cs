using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F8D RID: 3981
	[Token(Token = "0x2000F8D")]
	public class CheckInTable
	{
		// Token: 0x06006CCF RID: 27855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCF")]
		[Address(RVA = "0x21000F0", Offset = "0x20FECF0", VA = "0x1821000F0")]
		public CheckInTable()
		{
		}

		// Token: 0x04005491 RID: 21649
		[Token(Token = "0x4005491")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, MonthlySignInGroupData> groups;

		// Token: 0x04005492 RID: 21650
		[Token(Token = "0x4005492")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, List<MonthlyDailyBonusGroup>> monthlySubItem;

		// Token: 0x04005493 RID: 21651
		[Token(Token = "0x4005493")]
		[FieldOffset(Offset = "0x20")]
		public string currentMonthlySubId;
	}
}
