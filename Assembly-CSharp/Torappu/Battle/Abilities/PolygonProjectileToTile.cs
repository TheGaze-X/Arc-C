using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C39 RID: 11321
	[Token(Token = "0x2002C39")]
	public class PolygonProjectileToTile : AbstractProjectileEmitter
	{
		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x060131D7 RID: 78295 RVA: 0x000749E8 File Offset: 0x00072BE8
		[Token(Token = "0x17002A02")]
		protected bool projectileValid
		{
			[Token(Token = "0x60131D7")]
			[Address(RVA = "0xB206F0", Offset = "0xB1F2F0", VA = "0x180B206F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060131D8 RID: 78296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131D8")]
		[Address(RVA = "0xB20130", Offset = "0xB1ED30", VA = "0x180B20130", Slot = "17")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x060131D9 RID: 78297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131D9")]
		[Address(RVA = "0xB20220", Offset = "0xB1EE20", VA = "0x180B20220", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x060131DA RID: 78298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131DA")]
		[Address(RVA = "0xB205F0", Offset = "0xB1F1F0", VA = "0x180B205F0")]
		public PolygonProjectileToTile()
		{
		}

		// Token: 0x060131DB RID: 78299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131DB")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015967 RID: 88423
		[Token(Token = "0x4015967")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _projectileKey;

		// Token: 0x04015968 RID: 88424
		[Token(Token = "0x4015968")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Entity.MountPointType _mountPointType;

		// Token: 0x04015969 RID: 88425
		[Token(Token = "0x4015969")]
		[FieldOffset(Offset = "0x30")]
		protected List<Tile> m_targetTiles;

		// Token: 0x0401596A RID: 88426
		[Token(Token = "0x401596A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_projectileValid;

		// Token: 0x0401596B RID: 88427
		[Token(Token = "0x401596B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x0401596C RID: 88428
		[Token(Token = "0x401596C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401596D RID: 88429
		[Token(Token = "0x401596D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
