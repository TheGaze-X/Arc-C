using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AF5 RID: 10997
	[Token(Token = "0x2002AF5")]
	public class ProjectileToTileOnceAbility : ProjectileToTileAbility
	{
		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x060125D9 RID: 75225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002845")]
		public override TargetSelector selector
		{
			[Token(Token = "0x60125D9")]
			[Address(RVA = "0xA747F0", Offset = "0xA733F0", VA = "0x180A747F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060125DA RID: 75226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125DA")]
		[Address(RVA = "0xA74510", Offset = "0xA73110", VA = "0x180A74510", Slot = "110")]
		protected override void OnCastOnTile(Tile tile, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x060125DB RID: 75227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125DB")]
		[Address(RVA = "0xA743E0", Offset = "0xA72FE0", VA = "0x180A743E0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060125DC RID: 75228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125DC")]
		[Address(RVA = "0xA74620", Offset = "0xA73220", VA = "0x180A74620", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x060125DD RID: 75229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125DD")]
		[Address(RVA = "0xA74350", Offset = "0xA72F50", VA = "0x180A74350")]
		public void CastOnTileBySubSelector()
		{
		}

		// Token: 0x060125DE RID: 75230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125DE")]
		[Address(RVA = "0xA74730", Offset = "0xA73330", VA = "0x180A74730")]
		public ProjectileToTileOnceAbility()
		{
		}

		// Token: 0x060125DF RID: 75231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60125DF")]
		[Address(RVA = "0xA74720", Offset = "0xA73320", VA = "0x180A74720")]
		private TargetSelector <>xLuaBaseProxy_get_selector()
		{
			return null;
		}

		// Token: 0x060125E0 RID: 75232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125E0")]
		[Address(RVA = "0xA74700", Offset = "0xA73300", VA = "0x180A74700")]
		private void <>xLuaBaseProxy_OnCastOnTile(Tile P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x060125E1 RID: 75233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125E1")]
		[Address(RVA = "0xA58A00", Offset = "0xA57600", VA = "0x180A58A00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060125E2 RID: 75234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125E2")]
		[Address(RVA = "0xA74710", Offset = "0xA73310", VA = "0x180A74710")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x04014C32 RID: 85042
		[Token(Token = "0x4014C32")]
		[FieldOffset(Offset = "0x258")]
		[SerializeField]
		[Group("CastOnTile")]
		private TileSelector _subTileSelector;

		// Token: 0x04014C33 RID: 85043
		[Token(Token = "0x4014C33")]
		[FieldOffset(Offset = "0x260")]
		private List<Tile> m_cachedTiles;

		// Token: 0x04014C34 RID: 85044
		[Token(Token = "0x4014C34")]
		[FieldOffset(Offset = "0x268")]
		private bool _useSubSelector;

		// Token: 0x04014C35 RID: 85045
		[Token(Token = "0x4014C35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selector;

		// Token: 0x04014C36 RID: 85046
		[Token(Token = "0x4014C36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastOnTile;

		// Token: 0x04014C37 RID: 85047
		[Token(Token = "0x4014C37")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014C38 RID: 85048
		[Token(Token = "0x4014C38")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014C39 RID: 85049
		[Token(Token = "0x4014C39")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CastOnTileBySubSelector;

		// Token: 0x04014C3A RID: 85050
		[Token(Token = "0x4014C3A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
