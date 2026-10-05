using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AA5 RID: 10917
	[Token(Token = "0x2002AA5")]
	public class AroundTargetRangedAttack : RangedAttack
	{
		// Token: 0x06012238 RID: 74296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012238")]
		[Address(RVA = "0xA35270", Offset = "0xA33E70", VA = "0x180A35270", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012239 RID: 74297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012239")]
		[Address(RVA = "0xA36AA0", Offset = "0xA356A0", VA = "0x180A36AA0")]
		private void _ModifyAtkScaleWhenCreateProjectile()
		{
		}

		// Token: 0x0601223A RID: 74298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601223A")]
		[Address(RVA = "0xA35BD0", Offset = "0xA347D0", VA = "0x180A35BD0", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x0601223B RID: 74299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601223B")]
		[Address(RVA = "0xA35560", Offset = "0xA34160", VA = "0x180A35560", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x0601223C RID: 74300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601223C")]
		[Address(RVA = "0xA35E20", Offset = "0xA34A20", VA = "0x180A35E20", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x0601223D RID: 74301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601223D")]
		[Address(RVA = "0xA353B0", Offset = "0xA33FB0", VA = "0x180A353B0", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0601223E RID: 74302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601223E")]
		[Address(RVA = "0xA35EB0", Offset = "0xA34AB0", VA = "0x180A35EB0", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x0601223F RID: 74303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601223F")]
		[Address(RVA = "0xA354E0", Offset = "0xA340E0", VA = "0x180A354E0", Slot = "114")]
		protected override string GetProjectileKey()
		{
			return null;
		}

		// Token: 0x06012240 RID: 74304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012240")]
		[Address(RVA = "0xA36940", Offset = "0xA35540", VA = "0x180A36940")]
		private Projectile _CreateAroundProjectile(ILocatable target, out Projectile fakeProjectile, int projectileIndex)
		{
			return null;
		}

		// Token: 0x06012241 RID: 74305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012241")]
		[Address(RVA = "0xA36280", Offset = "0xA34E80", VA = "0x180A36280")]
		private void _CalculateProjectilesStartPos(Vector3 target)
		{
		}

		// Token: 0x06012242 RID: 74306 RVA: 0x0006F2D0 File Offset: 0x0006D4D0
		[Token(Token = "0x6012242")]
		[Address(RVA = "0xA36030", Offset = "0xA34C30", VA = "0x180A36030")]
		private Quaternion _CalculateProjectilesStartDirection()
		{
			return default(Quaternion);
		}

		// Token: 0x06012243 RID: 74307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012243")]
		[Address(RVA = "0xA36B90", Offset = "0xA35790", VA = "0x180A36B90")]
		public AroundTargetRangedAttack()
		{
		}

		// Token: 0x06012244 RID: 74308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012244")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012245 RID: 74309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012245")]
		[Address(RVA = "0xA36010", Offset = "0xA34C10", VA = "0x180A36010")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012246 RID: 74310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012246")]
		[Address(RVA = "0xA36000", Offset = "0xA34C00", VA = "0x180A36000")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x06012247 RID: 74311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012247")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012248 RID: 74312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012248")]
		[Address(RVA = "0xA35F90", Offset = "0xA34B90", VA = "0x180A35F90")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x06012249 RID: 74313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012249")]
		[Address(RVA = "0xA36020", Offset = "0xA34C20", VA = "0x180A36020")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x0601224A RID: 74314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601224A")]
		[Address(RVA = "0xA35FA0", Offset = "0xA34BA0", VA = "0x180A35FA0")]
		private string <>xLuaBaseProxy_GetProjectileKey()
		{
			return null;
		}

		// Token: 0x0401485E RID: 84062
		[Token(Token = "0x401485E")]
		private const string NEXT_PROJECTILE_KEY = "next_projectile_key";

		// Token: 0x0401485F RID: 84063
		[Token(Token = "0x401485F")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("AroundTarget", Priority = -1)]
		private int _projectileCnt;

		// Token: 0x04014860 RID: 84064
		[Token(Token = "0x4014860")]
		[FieldOffset(Offset = "0x26C")]
		[SerializeField]
		[Group("AroundTarget", Priority = -1)]
		private float _projectileAroundRadius;

		// Token: 0x04014861 RID: 84065
		[Token(Token = "0x4014861")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		[Group("AroundTarget", Priority = -1)]
		private bool _clearProjectilesWhenDetached;

		// Token: 0x04014862 RID: 84066
		[Token(Token = "0x4014862")]
		[FieldOffset(Offset = "0x271")]
		[SerializeField]
		[Group("AroundTarget", Priority = -1)]
		private bool _createNewProjectileWhenCastOnTarget;

		// Token: 0x04014863 RID: 84067
		[Token(Token = "0x4014863")]
		[FieldOffset(Offset = "0x272")]
		[SerializeField]
		[Group("AroundTarget", Priority = -1)]
		private bool _useCharacterDirectionAsForward;

		// Token: 0x04014864 RID: 84068
		[Token(Token = "0x4014864")]
		[FieldOffset(Offset = "0x278")]
		private List<ILocatable> m_projectileStartPos;

		// Token: 0x04014865 RID: 84069
		[Token(Token = "0x4014865")]
		[FieldOffset(Offset = "0x280")]
		private int m_projectileCnt;

		// Token: 0x04014866 RID: 84070
		[Token(Token = "0x4014866")]
		[FieldOffset(Offset = "0x284")]
		private float m_projectileAroundRadius;

		// Token: 0x04014867 RID: 84071
		[Token(Token = "0x4014867")]
		[FieldOffset(Offset = "0x288")]
		private List<ObjectPtr<Projectile>> m_projectilesKeepPosList;

		// Token: 0x04014868 RID: 84072
		[Token(Token = "0x4014868")]
		[FieldOffset(Offset = "0x290")]
		private string m_nextProjectileKey;

		// Token: 0x04014869 RID: 84073
		[Token(Token = "0x4014869")]
		[FieldOffset(Offset = "0x298")]
		private FP m_changeAtkScale;

		// Token: 0x0401486A RID: 84074
		[Token(Token = "0x401486A")]
		[FieldOffset(Offset = "0x2A0")]
		private bool m_keepLastPos;

		// Token: 0x0401486B RID: 84075
		[Token(Token = "0x401486B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401486C RID: 84076
		[Token(Token = "0x401486C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ModifyAtkScaleWhenCreateProjectile;

		// Token: 0x0401486D RID: 84077
		[Token(Token = "0x401486D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x0401486E RID: 84078
		[Token(Token = "0x401486E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x0401486F RID: 84079
		[Token(Token = "0x401486F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04014870 RID: 84080
		[Token(Token = "0x4014870")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04014871 RID: 84081
		[Token(Token = "0x4014871")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014872 RID: 84082
		[Token(Token = "0x4014872")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetProjectileKey;

		// Token: 0x04014873 RID: 84083
		[Token(Token = "0x4014873")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CreateAroundProjectile;

		// Token: 0x04014874 RID: 84084
		[Token(Token = "0x4014874")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CalculateProjectilesStartPos;

		// Token: 0x04014875 RID: 84085
		[Token(Token = "0x4014875")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CalculateProjectilesStartDirection;

		// Token: 0x04014876 RID: 84086
		[Token(Token = "0x4014876")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
