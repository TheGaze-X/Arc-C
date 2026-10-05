using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A3F RID: 2623
	[Token(Token = "0x2000A3F")]
	public class PlayerDexNav
	{
		// Token: 0x060066FE RID: 26366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066FE")]
		[Address(RVA = "0x1EF9970", Offset = "0x1EF8570", VA = "0x181EF9970")]
		public PlayerDexNav()
		{
		}

		// Token: 0x0400381B RID: 14363
		[Token(Token = "0x400381B")]
		[FieldOffset(Offset = "0x10")]
		public PlayerEnemyHandBook enemy;

		// Token: 0x0400381C RID: 14364
		[Token(Token = "0x400381C")]
		[FieldOffset(Offset = "0x18")]
		public PlayerFormulaUnlockRecord formula;
	}
}
