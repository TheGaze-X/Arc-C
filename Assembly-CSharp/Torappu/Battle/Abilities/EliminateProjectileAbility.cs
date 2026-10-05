using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002ADA RID: 10970
	[Token(Token = "0x2002ADA")]
	public class EliminateProjectileAbility : CastOnProjectileAbility
	{
		// Token: 0x06012499 RID: 74905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012499")]
		[Address(RVA = "0xA54790", Offset = "0xA53390", VA = "0x180A54790", Slot = "108")]
		protected override void OnCastOnProjectile(Projectile projectile, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x0601249A RID: 74906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601249A")]
		[Address(RVA = "0xA54840", Offset = "0xA53440", VA = "0x180A54840")]
		public EliminateProjectileAbility()
		{
		}

		// Token: 0x04014AD1 RID: 84689
		[Token(Token = "0x4014AD1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCastOnProjectile;

		// Token: 0x04014AD2 RID: 84690
		[Token(Token = "0x4014AD2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
