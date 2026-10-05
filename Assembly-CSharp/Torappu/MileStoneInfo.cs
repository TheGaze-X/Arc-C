using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000D6F RID: 3439
	[Token(Token = "0x2000D6F")]
	public class MileStoneInfo
	{
		// Token: 0x06006A41 RID: 27201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A41")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MileStoneInfo()
		{
		}

		// Token: 0x040046C1 RID: 18113
		[Token(Token = "0x40046C1")]
		[FieldOffset(Offset = "0x10")]
		public string mileStoneId;

		// Token: 0x040046C2 RID: 18114
		[Token(Token = "0x40046C2")]
		[FieldOffset(Offset = "0x18")]
		public int orderId;

		// Token: 0x040046C3 RID: 18115
		[Token(Token = "0x40046C3")]
		[FieldOffset(Offset = "0x1C")]
		public int tokenNum;

		// Token: 0x040046C4 RID: 18116
		[Token(Token = "0x40046C4")]
		[FieldOffset(Offset = "0x20")]
		public MileStoneInfo.GoodType mileStoneType;

		// Token: 0x040046C5 RID: 18117
		[Token(Token = "0x40046C5")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle normalItem;

		// Token: 0x040046C6 RID: 18118
		[Token(Token = "0x40046C6")]
		[FieldOffset(Offset = "0x30")]
		public int IsBonus;

		// Token: 0x02000D70 RID: 3440
		[Token(Token = "0x2000D70")]
		public enum GoodType
		{
			// Token: 0x040046C8 RID: 18120
			[Token(Token = "0x40046C8")]
			NORMAL,
			// Token: 0x040046C9 RID: 18121
			[Token(Token = "0x40046C9")]
			SPECIAL
		}
	}
}
