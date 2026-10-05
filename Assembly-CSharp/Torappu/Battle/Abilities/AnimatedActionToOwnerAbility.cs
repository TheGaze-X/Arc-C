using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002A8F RID: 10895
	[Token(Token = "0x2002A8F")]
	public class AnimatedActionToOwnerAbility : AbstractAnimatedAbility
	{
		// Token: 0x0601215B RID: 74075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601215B")]
		[Address(RVA = "0xA1EA90", Offset = "0xA1D690", VA = "0x180A1EA90", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x0601215C RID: 74076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601215C")]
		[Address(RVA = "0xA1EA20", Offset = "0xA1D620", VA = "0x180A1EA20", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x0601215D RID: 74077 RVA: 0x0006EAD8 File Offset: 0x0006CCD8
		[Token(Token = "0x601215D")]
		[Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20", Slot = "78")]
		protected override bool OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x0601215E RID: 74078 RVA: 0x0006EAF0 File Offset: 0x0006CCF0
		[Token(Token = "0x601215E")]
		[Address(RVA = "0xA1E990", Offset = "0xA1D590", VA = "0x180A1E990", Slot = "90")]
		protected override ActionPurposeMask GeneratePurposeMask()
		{
			return ActionPurposeMask.NONE;
		}

		// Token: 0x0601215F RID: 74079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601215F")]
		[Address(RVA = "0xA1E8F0", Offset = "0xA1D4F0", VA = "0x180A1E8F0", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x06012160 RID: 74080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012160")]
		[Address(RVA = "0xA1EE00", Offset = "0xA1DA00", VA = "0x180A1EE00")]
		public AnimatedActionToOwnerAbility()
		{
		}

		// Token: 0x06012161 RID: 74081 RVA: 0x0006EB08 File Offset: 0x0006CD08
		[Token(Token = "0x6012161")]
		[Address(RVA = "0xA1EDF0", Offset = "0xA1D9F0", VA = "0x180A1EDF0")]
		private bool <>xLuaBaseProxy_OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x06012162 RID: 74082 RVA: 0x0006EB20 File Offset: 0x0006CD20
		[Token(Token = "0x6012162")]
		[Address(RVA = "0xA1E510", Offset = "0xA1D110", VA = "0x180A1E510")]
		private ActionPurposeMask <>xLuaBaseProxy_GeneratePurposeMask()
		{
			return ActionPurposeMask.NONE;
		}

		// Token: 0x06012163 RID: 74083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012163")]
		[Address(RVA = "0xA1EDE0", Offset = "0xA1D9E0", VA = "0x180A1EDE0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x04014787 RID: 83847
		[Token(Token = "0x4014787")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x04014788 RID: 83848
		[Token(Token = "0x4014788")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014789 RID: 83849
		[Token(Token = "0x4014789")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x0401478A RID: 83850
		[Token(Token = "0x401478A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSpellStart;

		// Token: 0x0401478B RID: 83851
		[Token(Token = "0x401478B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GeneratePurposeMask;

		// Token: 0x0401478C RID: 83852
		[Token(Token = "0x401478C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x0401478D RID: 83853
		[Token(Token = "0x401478D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
