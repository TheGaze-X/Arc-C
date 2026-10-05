using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000892 RID: 2194
	[Token(Token = "0x2000892")]
	public class MonthlySubItem : NormalGPItem
	{
		// Token: 0x06006531 RID: 25905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006531")]
		[Address(RVA = "0x1EE7AE0", Offset = "0x1EE66E0", VA = "0x181EE7AE0")]
		public MonthlySubItem()
		{
		}

		// Token: 0x0400322F RID: 12847
		[Token(Token = "0x400322F")]
		[FieldOffset(Offset = "0x80")]
		public string cardId;

		// Token: 0x04003230 RID: 12848
		[Token(Token = "0x4003230")]
		[FieldOffset(Offset = "0x88")]
		public ItemBundle[] dailyBonus;

		// Token: 0x04003231 RID: 12849
		[Token(Token = "0x4003231")]
		[FieldOffset(Offset = "0x90")]
		public string imgId;

		// Token: 0x04003232 RID: 12850
		[Token(Token = "0x4003232")]
		[FieldOffset(Offset = "0x98")]
		public string backId;
	}
}
