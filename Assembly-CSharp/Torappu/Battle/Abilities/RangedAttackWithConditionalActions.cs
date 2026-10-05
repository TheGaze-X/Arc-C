using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AC1 RID: 10945
	[Token(Token = "0x2002AC1")]
	public class RangedAttackWithConditionalActions : RangedAttack
	{
		// Token: 0x060123AD RID: 74669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123AD")]
		[Address(RVA = "0xA47210", Offset = "0xA45E10", VA = "0x180A47210", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060123AE RID: 74670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60123AE")]
		[Address(RVA = "0xA474B0", Offset = "0xA460B0", VA = "0x180A474B0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x060123AF RID: 74671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123AF")]
		[Address(RVA = "0xA473A0", Offset = "0xA45FA0", VA = "0x180A473A0", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x060123B0 RID: 74672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123B0")]
		[Address(RVA = "0xA476E0", Offset = "0xA462E0", VA = "0x180A476E0")]
		public RangedAttackWithConditionalActions()
		{
		}

		// Token: 0x060123B1 RID: 74673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123B1")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060123B2 RID: 74674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60123B2")]
		[Address(RVA = "0xA44FF0", Offset = "0xA43BF0", VA = "0x180A44FF0")]
		private IList<ActionNode> <>xLuaBaseProxy_GetProjectileActions(Projectile.Event P0, Projectile P1)
		{
			return null;
		}

		// Token: 0x060123B3 RID: 74675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123B3")]
		[Address(RVA = "0xA1EDE0", Offset = "0xA1D9E0", VA = "0x180A1EDE0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x040149EA RID: 84458
		[Token(Token = "0x40149EA")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("Extra Actions", Priority = 2)]
		private RangedAttackWithConditionalActions.ConditionalActions[] _conditionalActions;

		// Token: 0x040149EB RID: 84459
		[Token(Token = "0x40149EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040149EC RID: 84460
		[Token(Token = "0x40149EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x040149ED RID: 84461
		[Token(Token = "0x40149ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x040149EE RID: 84462
		[Token(Token = "0x40149EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002AC2 RID: 10946
		[Token(Token = "0x2002AC2")]
		[Serializable]
		public struct ConditionalActions
		{
			// Token: 0x040149EF RID: 84463
			[Token(Token = "0x40149EF")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public TargetValidator ownerValidator;

			// Token: 0x040149F0 RID: 84464
			[Token(Token = "0x40149F0")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public Projectile.Event actionEvent;

			// Token: 0x040149F1 RID: 84465
			[Token(Token = "0x40149F1")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public ActionArray actions;
		}
	}
}
