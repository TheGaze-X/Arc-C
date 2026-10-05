using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002729 RID: 10025
	[Token(Token = "0x2002729")]
	public class SelfEnemyInfo
	{
		// Token: 0x06010483 RID: 66691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010483")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SelfEnemyInfo()
		{
		}

		// Token: 0x0401233D RID: 74557
		[Token(Token = "0x401233D")]
		[FieldOffset(Offset = "0x10")]
		public string enemyId;

		// Token: 0x0401233E RID: 74558
		[Token(Token = "0x401233E")]
		[FieldOffset(Offset = "0x18")]
		public int actionIndex;

		// Token: 0x0401233F RID: 74559
		[Token(Token = "0x401233F")]
		[FieldOffset(Offset = "0x1C")]
		public int instId;
	}
}
