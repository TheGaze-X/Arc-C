using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AC5 RID: 10949
	[Token(Token = "0x2002AC5")]
	public class RangedAttackWithExtraActions : RangedAttack
	{
		// Token: 0x060123C1 RID: 74689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60123C1")]
		[Address(RVA = "0xA47D80", Offset = "0xA46980", VA = "0x180A47D80", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x060123C2 RID: 74690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123C2")]
		[Address(RVA = "0xA47CE0", Offset = "0xA468E0", VA = "0x180A47CE0", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x060123C3 RID: 74691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123C3")]
		[Address(RVA = "0xA47ED0", Offset = "0xA46AD0", VA = "0x180A47ED0")]
		public RangedAttackWithExtraActions()
		{
		}

		// Token: 0x060123C4 RID: 74692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60123C4")]
		[Address(RVA = "0xA44FF0", Offset = "0xA43BF0", VA = "0x180A44FF0")]
		private IList<ActionNode> <>xLuaBaseProxy_GetProjectileActions(Projectile.Event P0, Projectile P1)
		{
			return null;
		}

		// Token: 0x060123C5 RID: 74693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123C5")]
		[Address(RVA = "0xA1EDE0", Offset = "0xA1D9E0", VA = "0x180A1EDE0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x040149FE RID: 84478
		[Token(Token = "0x40149FE")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("Extra Actions", Priority = 2)]
		private Projectile.Event _actionEvent;

		// Token: 0x040149FF RID: 84479
		[Token(Token = "0x40149FF")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		[Group("Extra Actions", Priority = 2)]
		private ActionArray _actions;

		// Token: 0x04014A00 RID: 84480
		[Token(Token = "0x4014A00")]
		[FieldOffset(Offset = "0x278")]
		[SerializeField]
		[Group("Extra Actions", Priority = 2)]
		private bool _overwriteAbilityActions;

		// Token: 0x04014A01 RID: 84481
		[Token(Token = "0x4014A01")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014A02 RID: 84482
		[Token(Token = "0x4014A02")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x04014A03 RID: 84483
		[Token(Token = "0x4014A03")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
