using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C36 RID: 11318
	[Token(Token = "0x2002C36")]
	public abstract class AbstractProjectileEmitter : AbilityStandard.Behaviour, IProjectileSource
	{
		// Token: 0x060131BF RID: 78271
		[Token(Token = "0x60131BF")]
		public abstract void GatherProjectiles(List<string> projectiles);

		// Token: 0x060131C0 RID: 78272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131C0")]
		[Address(RVA = "0xB135D0", Offset = "0xB121D0", VA = "0x180B135D0")]
		protected AbstractProjectileEmitter()
		{
		}

		// Token: 0x04015951 RID: 88401
		[Token(Token = "0x4015951")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
