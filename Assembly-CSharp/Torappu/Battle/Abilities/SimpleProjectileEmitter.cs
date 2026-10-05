using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C3A RID: 11322
	[Token(Token = "0x2002C3A")]
	public class SimpleProjectileEmitter : AbstractProjectileEmitter
	{
		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x060131DC RID: 78300 RVA: 0x00074A00 File Offset: 0x00072C00
		[Token(Token = "0x17002A03")]
		protected bool projectileValid
		{
			[Token(Token = "0x60131DC")]
			[Address(RVA = "0xB26C00", Offset = "0xB25800", VA = "0x180B26C00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060131DD RID: 78301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131DD")]
		[Address(RVA = "0xB26610", Offset = "0xB25210", VA = "0x180B26610", Slot = "17")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x060131DE RID: 78302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131DE")]
		[Address(RVA = "0xB26700", Offset = "0xB25300", VA = "0x180B26700", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x060131DF RID: 78303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131DF")]
		[Address(RVA = "0xB26B50", Offset = "0xB25750", VA = "0x180B26B50")]
		public SimpleProjectileEmitter()
		{
		}

		// Token: 0x060131E0 RID: 78304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131E0")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0401596E RID: 88430
		[Token(Token = "0x401596E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _projectileKey;

		// Token: 0x0401596F RID: 88431
		[Token(Token = "0x401596F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Entity.MountPointType _mountPointType;

		// Token: 0x04015970 RID: 88432
		[Token(Token = "0x4015970")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private AbilityStandard.Event _emitEvent;

		// Token: 0x04015971 RID: 88433
		[Token(Token = "0x4015971")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _includeDeadTargets;

		// Token: 0x04015972 RID: 88434
		[Token(Token = "0x4015972")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		[HideInInspector]
		private bool _manageProjectileByOwner;

		// Token: 0x04015973 RID: 88435
		[Token(Token = "0x4015973")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_projectileValid;

		// Token: 0x04015974 RID: 88436
		[Token(Token = "0x4015974")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04015975 RID: 88437
		[Token(Token = "0x4015975")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015976 RID: 88438
		[Token(Token = "0x4015976")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
