using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AAA RID: 10922
	[Token(Token = "0x2002AAA")]
	public class CrossRangedAttack : RangedAttack
	{
		// Token: 0x06012286 RID: 74374 RVA: 0x0006F438 File Offset: 0x0006D638
		[Token(Token = "0x6012286")]
		[Address(RVA = "0xA38F60", Offset = "0xA37B60", VA = "0x180A38F60", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x06012287 RID: 74375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012287")]
		[Address(RVA = "0xA39D30", Offset = "0xA38930", VA = "0x180A39D30")]
		public CrossRangedAttack()
		{
		}

		// Token: 0x06012288 RID: 74376 RVA: 0x0006F450 File Offset: 0x0006D650
		[Token(Token = "0x6012288")]
		[Address(RVA = "0xA39D20", Offset = "0xA38920", VA = "0x180A39D20")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x040148AB RID: 84139
		[Token(Token = "0x40148AB")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		private bool _useEightDirections;

		// Token: 0x040148AC RID: 84140
		[Token(Token = "0x40148AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x040148AD RID: 84141
		[Token(Token = "0x40148AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
