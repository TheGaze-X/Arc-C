using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A68 RID: 10856
	[Token(Token = "0x2002A68")]
	public class RushEnemyOutput
	{
		// Token: 0x060120FB RID: 73979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120FB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RushEnemyOutput()
		{
		}

		// Token: 0x04014677 RID: 83575
		[Token(Token = "0x4014677")]
		[FieldOffset(Offset = "0x10")]
		public int enemyIndex;

		// Token: 0x04014678 RID: 83576
		[Token(Token = "0x4014678")]
		[FieldOffset(Offset = "0x14")]
		public int count;
	}
}
