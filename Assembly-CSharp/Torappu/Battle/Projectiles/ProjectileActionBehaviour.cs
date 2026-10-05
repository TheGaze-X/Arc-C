using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029A3 RID: 10659
	[Token(Token = "0x20029A3")]
	public class ProjectileActionBehaviour : Projectile.Behaviour, IActionNodeSource
	{
		// Token: 0x06011A68 RID: 72296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A68")]
		[Address(RVA = "0x97C5C0", Offset = "0x97B1C0", VA = "0x18097C5C0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011A69 RID: 72297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A69")]
		[Address(RVA = "0x97C670", Offset = "0x97B270", VA = "0x18097C670", Slot = "13")]
		public override void TryRegisterExtraActionNode()
		{
		}

		// Token: 0x06011A6A RID: 72298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A6A")]
		[Address(RVA = "0x97C6F0", Offset = "0x97B2F0", VA = "0x18097C6F0")]
		private void _AssignActionsInternal()
		{
		}

		// Token: 0x06011A6B RID: 72299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A6B")]
		[Address(RVA = "0x97C520", Offset = "0x97B120", VA = "0x18097C520", Slot = "15")]
		public void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x06011A6C RID: 72300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A6C")]
		[Address(RVA = "0x97C7E0", Offset = "0x97B3E0", VA = "0x18097C7E0")]
		public ProjectileActionBehaviour()
		{
		}

		// Token: 0x06011A6D RID: 72301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A6D")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011A6E RID: 72302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A6E")]
		[Address(RVA = "0x97C6E0", Offset = "0x97B2E0", VA = "0x18097C6E0")]
		private void <>xLuaBaseProxy_TryRegisterExtraActionNode()
		{
		}

		// Token: 0x04013C43 RID: 80963
		[Token(Token = "0x4013C43")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Projectile.Event _ev;

		// Token: 0x04013C44 RID: 80964
		[Token(Token = "0x4013C44")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x04013C45 RID: 80965
		[Token(Token = "0x4013C45")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _overwriteActions;

		// Token: 0x04013C46 RID: 80966
		[Token(Token = "0x4013C46")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _preprocessActionsForProjectile;

		// Token: 0x04013C47 RID: 80967
		[Token(Token = "0x4013C47")]
		[FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool _applyOnApplyAtkScaleToDamageNode;

		// Token: 0x04013C48 RID: 80968
		[Token(Token = "0x4013C48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013C49 RID: 80969
		[Token(Token = "0x4013C49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryRegisterExtraActionNode;

		// Token: 0x04013C4A RID: 80970
		[Token(Token = "0x4013C4A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__AssignActionsInternal;

		// Token: 0x04013C4B RID: 80971
		[Token(Token = "0x4013C4B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x04013C4C RID: 80972
		[Token(Token = "0x4013C4C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
