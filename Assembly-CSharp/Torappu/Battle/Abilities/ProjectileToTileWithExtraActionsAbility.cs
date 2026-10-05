using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AF6 RID: 10998
	[Token(Token = "0x2002AF6")]
	public class ProjectileToTileWithExtraActionsAbility : ProjectileToTileAbility
	{
		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x060125E3 RID: 75235 RVA: 0x000707D0 File Offset: 0x0006E9D0
		[Token(Token = "0x17002846")]
		public bool isHitObjectEvent
		{
			[Token(Token = "0x60125E3")]
			[Address(RVA = "0xA74D60", Offset = "0xA73960", VA = "0x180A74D60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060125E4 RID: 75236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125E4")]
		[Address(RVA = "0xA74860", Offset = "0xA73460", VA = "0x180A74860", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060125E5 RID: 75237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125E5")]
		[Address(RVA = "0xA74A30", Offset = "0xA73630", VA = "0x180A74A30", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x060125E6 RID: 75238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60125E6")]
		[Address(RVA = "0xA74B50", Offset = "0xA73750", VA = "0x180A74B50", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x060125E7 RID: 75239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125E7")]
		[Address(RVA = "0xA74990", Offset = "0xA73590", VA = "0x180A74990", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x060125E8 RID: 75240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125E8")]
		[Address(RVA = "0xA74CB0", Offset = "0xA738B0", VA = "0x180A74CB0")]
		public ProjectileToTileWithExtraActionsAbility()
		{
		}

		// Token: 0x060125E9 RID: 75241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125E9")]
		[Address(RVA = "0xA58A00", Offset = "0xA57600", VA = "0x180A58A00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060125EA RID: 75242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125EA")]
		[Address(RVA = "0xA58A30", Offset = "0xA57630", VA = "0x180A58A30")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x060125EB RID: 75243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60125EB")]
		[Address(RVA = "0xA74CA0", Offset = "0xA738A0", VA = "0x180A74CA0")]
		private IList<ActionNode> <>xLuaBaseProxy_GetProjectileActions(Projectile.Event P0, Projectile P1)
		{
			return null;
		}

		// Token: 0x060125EC RID: 75244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125EC")]
		[Address(RVA = "0xA1EDE0", Offset = "0xA1D9E0", VA = "0x180A1EDE0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x04014C3B RID: 85051
		[Token(Token = "0x4014C3B")]
		[FieldOffset(Offset = "0x258")]
		[SerializeField]
		[Group("Extra")]
		private string[] _extraProjectileKeys;

		// Token: 0x04014C3C RID: 85052
		[Token(Token = "0x4014C3C")]
		[FieldOffset(Offset = "0x260")]
		[SerializeField]
		[Group("Extra")]
		private Projectile.Event _extraActionEvent;

		// Token: 0x04014C3D RID: 85053
		[Token(Token = "0x4014C3D")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("Extra")]
		private ActionArray _extraActions;

		// Token: 0x04014C3E RID: 85054
		[Token(Token = "0x4014C3E")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		[Group("Extra")]
		[Inspect("isHitObjectEvent")]
		private bool _overwriteHitObjectActions;

		// Token: 0x04014C3F RID: 85055
		[Token(Token = "0x4014C3F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isHitObjectEvent;

		// Token: 0x04014C40 RID: 85056
		[Token(Token = "0x4014C40")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014C41 RID: 85057
		[Token(Token = "0x4014C41")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04014C42 RID: 85058
		[Token(Token = "0x4014C42")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014C43 RID: 85059
		[Token(Token = "0x4014C43")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x04014C44 RID: 85060
		[Token(Token = "0x4014C44")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
