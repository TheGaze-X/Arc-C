using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A69 RID: 10857
	[Token(Token = "0x2002A69")]
	public class HuntEnemy : IHotfixable
	{
		// Token: 0x060120FC RID: 73980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120FC")]
		[Address(RVA = "0xA239B0", Offset = "0xA225B0", VA = "0x180A239B0")]
		public HuntEnemy()
		{
		}

		// Token: 0x04014679 RID: 83577
		[Token(Token = "0x4014679")]
		[FieldOffset(Offset = "0x10")]
		public string enemyId;

		// Token: 0x0401467A RID: 83578
		[Token(Token = "0x401467A")]
		[FieldOffset(Offset = "0x18")]
		public int count;

		// Token: 0x0401467B RID: 83579
		[Token(Token = "0x401467B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
