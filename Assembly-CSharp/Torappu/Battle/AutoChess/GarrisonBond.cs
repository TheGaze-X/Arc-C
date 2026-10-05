using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002727 RID: 10023
	[Token(Token = "0x2002727")]
	public class GarrisonBond
	{
		// Token: 0x06010481 RID: 66689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010481")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GarrisonBond()
		{
		}

		// Token: 0x04012338 RID: 74552
		[Token(Token = "0x4012338")]
		[FieldOffset(Offset = "0x10")]
		public string bondId;

		// Token: 0x04012339 RID: 74553
		[Token(Token = "0x4012339")]
		[FieldOffset(Offset = "0x18")]
		public int stackCnt;

		// Token: 0x0401233A RID: 74554
		[Token(Token = "0x401233A")]
		[FieldOffset(Offset = "0x1C")]
		public int charCnt;

		// Token: 0x0401233B RID: 74555
		[Token(Token = "0x401233B")]
		[FieldOffset(Offset = "0x20")]
		public bool isActive;
	}
}
