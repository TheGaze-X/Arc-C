using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001422 RID: 5154
	[Token(Token = "0x2001422")]
	public class BusinessCardEquipStatus
	{
		// Token: 0x060076E3 RID: 30435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BusinessCardEquipStatus()
		{
		}

		// Token: 0x0400744C RID: 29772
		[Token(Token = "0x400744C")]
		[FieldOffset(Offset = "0x10")]
		public int unlockCnt;

		// Token: 0x0400744D RID: 29773
		[Token(Token = "0x400744D")]
		[FieldOffset(Offset = "0x14")]
		public int limitedEquipCnt;

		// Token: 0x0400744E RID: 29774
		[Token(Token = "0x400744E")]
		[FieldOffset(Offset = "0x18")]
		public int level3EquipCnt;

		// Token: 0x0400744F RID: 29775
		[Token(Token = "0x400744F")]
		[FieldOffset(Offset = "0x1C")]
		public int equipCharCnt;

		// Token: 0x04007450 RID: 29776
		[Token(Token = "0x4007450")]
		[FieldOffset(Offset = "0x20")]
		public int limitedCharCnt;
	}
}
