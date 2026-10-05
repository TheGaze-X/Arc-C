using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020025FA RID: 9722
	[Token(Token = "0x20025FA")]
	public class InteractableBounceEnemy : BounceEnemy
	{
		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x0600FD4D RID: 64845 RVA: 0x0005FD78 File Offset: 0x0005DF78
		[Token(Token = "0x17002210")]
		public override bool disableUIUnitHud
		{
			[Token(Token = "0x600FD4D")]
			[Address(RVA = "0x75A010", Offset = "0x758C10", VA = "0x18075A010", Slot = "196")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x0600FD4E RID: 64846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002211")]
		protected InteractableBounceEnemy.ForceInfo baseTypeCachedForceInfo
		{
			[Token(Token = "0x600FD4E")]
			[Address(RVA = "0x759E90", Offset = "0x758A90", VA = "0x180759E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x0600FD4F RID: 64847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002212")]
		protected InteractableBounceEnemy.UIForceInfo baseTypeCachedForceInfoUI
		{
			[Token(Token = "0x600FD4F")]
			[Address(RVA = "0x759D90", Offset = "0x758990", VA = "0x180759D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x0600FD50 RID: 64848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002213")]
		public InteractableBounceEnemy.ForceInfo baseTypeDescriteForceInfo
		{
			[Token(Token = "0x600FD50")]
			[Address(RVA = "0x759F50", Offset = "0x758B50", VA = "0x180759F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600FD51 RID: 64849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD51")]
		[Address(RVA = "0x758B60", Offset = "0x757760", VA = "0x180758B60", Slot = "222")]
		public virtual void UpdatePhysicalParams(InteractableBounceEnemy.IPhysicalParams pparams)
		{
		}

		// Token: 0x0600FD52 RID: 64850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD52")]
		[Address(RVA = "0x757FD0", Offset = "0x756BD0", VA = "0x180757FD0", Slot = "223")]
		public virtual void ApplyForce(Entity forceSource, InteractableBounceEnemy.IForceInfo forceInfo)
		{
		}

		// Token: 0x0600FD53 RID: 64851 RVA: 0x0005FD90 File Offset: 0x0005DF90
		[Token(Token = "0x600FD53")]
		[Address(RVA = "0x759770", Offset = "0x758370", VA = "0x180759770", Slot = "224")]
		protected virtual bool _ShouldApplyFinalForce(InteractableBounceEnemy.IForceInfo cachedForceInfo)
		{
			return default(bool);
		}

		// Token: 0x0600FD54 RID: 64852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD54")]
		[Address(RVA = "0x758D60", Offset = "0x757960", VA = "0x180758D60", Slot = "225")]
		protected virtual void _ApplyFinalForce(InteractableBounceEnemy.IForceInfo finalForceInfo)
		{
		}

		// Token: 0x0600FD55 RID: 64853 RVA: 0x0005FDA8 File Offset: 0x0005DFA8
		[Token(Token = "0x600FD55")]
		[Address(RVA = "0x758480", Offset = "0x757080", VA = "0x180758480", Slot = "226")]
		public virtual FP GetForceScaler(Entity forceSource)
		{
			return default(FP);
		}

		// Token: 0x0600FD56 RID: 64854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD56")]
		[Address(RVA = "0x759060", Offset = "0x757C60", VA = "0x180759060")]
		protected void _FindSurroundingTiles()
		{
		}

		// Token: 0x0600FD57 RID: 64855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD57")]
		[Address(RVA = "0x7583B0", Offset = "0x756FB0", VA = "0x1807583B0", Slot = "174")]
		public override void GatherActionNodes(List<ActionNode> actions)
		{
		}

		// Token: 0x0600FD58 RID: 64856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD58")]
		[Address(RVA = "0x7594C0", Offset = "0x7580C0", VA = "0x1807594C0", Slot = "227")]
		protected virtual void _RunActionsOnTargetWhenCollide(Entity target)
		{
		}

		// Token: 0x0600FD59 RID: 64857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD59")]
		[Address(RVA = "0x759210", Offset = "0x757E10", VA = "0x180759210", Slot = "228")]
		protected virtual void _RunActionsOnSelfWhenCollide(Entity target)
		{
		}

		// Token: 0x0600FD5A RID: 64858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD5A")]
		[Address(RVA = "0x7598A0", Offset = "0x7584A0", VA = "0x1807598A0", Slot = "229")]
		protected virtual void _UpdateAnimation(FP deltaTime)
		{
		}

		// Token: 0x0600FD5B RID: 64859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD5B")]
		[Address(RVA = "0x758AE0", Offset = "0x7576E0", VA = "0x180758AE0", Slot = "221")]
		public override void PlayUnbalanceAnimation()
		{
		}

		// Token: 0x0600FD5C RID: 64860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD5C")]
		[Address(RVA = "0x759A90", Offset = "0x758690", VA = "0x180759A90", Slot = "230")]
		protected virtual void _UpdateUnbalanceAnimation()
		{
		}

		// Token: 0x0600FD5D RID: 64861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD5D")]
		[Address(RVA = "0x758A40", Offset = "0x757640", VA = "0x180758A40", Slot = "27")]
		public override void OnTick(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600FD5E RID: 64862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD5E")]
		[Address(RVA = "0x7587F0", Offset = "0x7573F0", VA = "0x1807587F0")]
		private void OnCollisionEnter2D(Collision2D other)
		{
		}

		// Token: 0x0600FD5F RID: 64863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD5F")]
		[Address(RVA = "0x759BD0", Offset = "0x7587D0", VA = "0x180759BD0")]
		public InteractableBounceEnemy()
		{
		}

		// Token: 0x0600FD60 RID: 64864 RVA: 0x0005FDC0 File Offset: 0x0005DFC0
		[Token(Token = "0x600FD60")]
		[Address(RVA = "0x747BC0", Offset = "0x7467C0", VA = "0x180747BC0")]
		private bool <>xLuaBaseProxy_get_disableUIUnitHud()
		{
			return default(bool);
		}

		// Token: 0x0600FD61 RID: 64865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD61")]
		[Address(RVA = "0x747BA0", Offset = "0x7467A0", VA = "0x180747BA0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x0600FD62 RID: 64866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD62")]
		[Address(RVA = "0x747BB0", Offset = "0x7467B0", VA = "0x180747BB0")]
		private void <>xLuaBaseProxy_PlayUnbalanceAnimation()
		{
		}

		// Token: 0x0600FD63 RID: 64867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD63")]
		[Address(RVA = "0x6099E0", Offset = "0x6085E0", VA = "0x1806099E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04011983 RID: 72067
		[Token(Token = "0x4011983")]
		[FieldOffset(Offset = "0x530")]
		[SerializeField]
		protected BounceEnemyPhysicalFeatureTalent _phyTalent;

		// Token: 0x04011984 RID: 72068
		[Token(Token = "0x4011984")]
		[FieldOffset(Offset = "0x538")]
		[SerializeField]
		protected InteractableBounceEnemy.FilterType _triggerForceFilterType;

		// Token: 0x04011985 RID: 72069
		[Token(Token = "0x4011985")]
		[FieldOffset(Offset = "0x53C")]
		[SerializeField]
		protected bool _disableIdleAnimation;

		// Token: 0x04011986 RID: 72070
		[Token(Token = "0x4011986")]
		[FieldOffset(Offset = "0x540")]
		[SerializeField]
		protected ActionArray _actionsToSelfWhenCollide;

		// Token: 0x04011987 RID: 72071
		[Token(Token = "0x4011987")]
		[FieldOffset(Offset = "0x548")]
		[SerializeField]
		protected ActionArray _actionsToTargetWhenCollide;

		// Token: 0x04011988 RID: 72072
		[Token(Token = "0x4011988")]
		[FieldOffset(Offset = "0x550")]
		protected readonly string MOVE_LEFT_KEY;

		// Token: 0x04011989 RID: 72073
		[Token(Token = "0x4011989")]
		[FieldOffset(Offset = "0x558")]
		protected readonly string MOVE_RIGHT_KEY;

		// Token: 0x0401198A RID: 72074
		[Token(Token = "0x401198A")]
		[FieldOffset(Offset = "0x560")]
		protected FP m_triggerTotalDmg;

		// Token: 0x0401198B RID: 72075
		[Token(Token = "0x401198B")]
		[FieldOffset(Offset = "0x568")]
		protected FP m_bounceFrictionFactor;

		// Token: 0x0401198C RID: 72076
		[Token(Token = "0x401198C")]
		[FieldOffset(Offset = "0x570")]
		protected FP m_attenuation;

		// Token: 0x0401198D RID: 72077
		[Token(Token = "0x401198D")]
		[FieldOffset(Offset = "0x578")]
		protected FP m_kickBackDefaultForce;

		// Token: 0x0401198E RID: 72078
		[Token(Token = "0x401198E")]
		[FieldOffset(Offset = "0x580")]
		protected Tile m_cacheRootTile;

		// Token: 0x0401198F RID: 72079
		[Token(Token = "0x401198F")]
		[FieldOffset(Offset = "0x588")]
		protected readonly HashSet<Tile> m_surroundTiles;

		// Token: 0x04011990 RID: 72080
		[Token(Token = "0x4011990")]
		[FieldOffset(Offset = "0x590")]
		protected InteractableBounceEnemy.ForceInfo m_cachedForceInfo;

		// Token: 0x04011991 RID: 72081
		[Token(Token = "0x4011991")]
		[FieldOffset(Offset = "0x598")]
		protected InteractableBounceEnemy.UIForceInfo m_cachedForceInfoUI;

		// Token: 0x04011992 RID: 72082
		[Token(Token = "0x4011992")]
		[FieldOffset(Offset = "0x5A0")]
		protected InteractableBounceEnemy.ForceInfo m_descriteForceInfo;

		// Token: 0x04011993 RID: 72083
		[Token(Token = "0x4011993")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_disableUIUnitHud;

		// Token: 0x04011994 RID: 72084
		[Token(Token = "0x4011994")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_baseTypeCachedForceInfo;

		// Token: 0x04011995 RID: 72085
		[Token(Token = "0x4011995")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_baseTypeCachedForceInfoUI;

		// Token: 0x04011996 RID: 72086
		[Token(Token = "0x4011996")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_baseTypeDescriteForceInfo;

		// Token: 0x04011997 RID: 72087
		[Token(Token = "0x4011997")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePhysicalParams;

		// Token: 0x04011998 RID: 72088
		[Token(Token = "0x4011998")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplyForce;

		// Token: 0x04011999 RID: 72089
		[Token(Token = "0x4011999")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShouldApplyFinalForce;

		// Token: 0x0401199A RID: 72090
		[Token(Token = "0x401199A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ApplyFinalForce;

		// Token: 0x0401199B RID: 72091
		[Token(Token = "0x401199B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetForceScaler;

		// Token: 0x0401199C RID: 72092
		[Token(Token = "0x401199C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FindSurroundingTiles;

		// Token: 0x0401199D RID: 72093
		[Token(Token = "0x401199D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x0401199E RID: 72094
		[Token(Token = "0x401199E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RunActionsOnTargetWhenCollide;

		// Token: 0x0401199F RID: 72095
		[Token(Token = "0x401199F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RunActionsOnSelfWhenCollide;

		// Token: 0x040119A0 RID: 72096
		[Token(Token = "0x40119A0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateAnimation;

		// Token: 0x040119A1 RID: 72097
		[Token(Token = "0x40119A1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_PlayUnbalanceAnimation;

		// Token: 0x040119A2 RID: 72098
		[Token(Token = "0x40119A2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateUnbalanceAnimation;

		// Token: 0x040119A3 RID: 72099
		[Token(Token = "0x40119A3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040119A4 RID: 72100
		[Token(Token = "0x40119A4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnCollisionEnter2D;

		// Token: 0x040119A5 RID: 72101
		[Token(Token = "0x40119A5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020025FB RID: 9723
		[Token(Token = "0x20025FB")]
		public enum FilterType
		{
			// Token: 0x040119A7 RID: 72103
			[Token(Token = "0x40119A7")]
			TOTAL_DAMAGE
		}

		// Token: 0x020025FC RID: 9724
		[Token(Token = "0x20025FC")]
		public interface IPhysicalParams
		{
		}

		// Token: 0x020025FD RID: 9725
		[Token(Token = "0x20025FD")]
		public class InteractableBounceEnemyPhysicalParams : InteractableBounceEnemy.IPhysicalParams, IHotfixable
		{
			// Token: 0x0600FD64 RID: 64868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FD64")]
			[Address(RVA = "0x757F70", Offset = "0x756B70", VA = "0x180757F70")]
			public InteractableBounceEnemyPhysicalParams()
			{
			}

			// Token: 0x040119A8 RID: 72104
			[Token(Token = "0x40119A8")]
			[FieldOffset(Offset = "0x10")]
			public FP bounciness;

			// Token: 0x040119A9 RID: 72105
			[Token(Token = "0x40119A9")]
			[FieldOffset(Offset = "0x18")]
			public FP friction;

			// Token: 0x040119AA RID: 72106
			[Token(Token = "0x40119AA")]
			[FieldOffset(Offset = "0x20")]
			public FP triggerDmg;

			// Token: 0x040119AB RID: 72107
			[Token(Token = "0x40119AB")]
			[FieldOffset(Offset = "0x28")]
			public FP kickBackDefaultForce;

			// Token: 0x040119AC RID: 72108
			[Token(Token = "0x40119AC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020025FE RID: 9726
		[Token(Token = "0x20025FE")]
		public interface IForceInfo
		{
		}

		// Token: 0x020025FF RID: 9727
		[Token(Token = "0x20025FF")]
		public class ForceInfo : InteractableBounceEnemy.IForceInfo, IHotfixable
		{
			// Token: 0x0600FD65 RID: 64869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FD65")]
			[Address(RVA = "0x7563B0", Offset = "0x754FB0", VA = "0x1807563B0")]
			public void Add(InteractableBounceEnemy.ForceInfo other)
			{
			}

			// Token: 0x0600FD66 RID: 64870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FD66")]
			[Address(RVA = "0x7564A0", Offset = "0x7550A0", VA = "0x1807564A0")]
			public void Reset()
			{
			}

			// Token: 0x0600FD67 RID: 64871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FD67")]
			[Address(RVA = "0x756530", Offset = "0x755130", VA = "0x180756530")]
			public ForceInfo()
			{
			}

			// Token: 0x040119AD RID: 72109
			[Token(Token = "0x40119AD")]
			[FieldOffset(Offset = "0x10")]
			public FP xAxisForce;

			// Token: 0x040119AE RID: 72110
			[Token(Token = "0x40119AE")]
			[FieldOffset(Offset = "0x18")]
			public FP yAxisForce;

			// Token: 0x040119AF RID: 72111
			[Token(Token = "0x40119AF")]
			[FieldOffset(Offset = "0x20")]
			public FP dmgValue;

			// Token: 0x040119B0 RID: 72112
			[Token(Token = "0x40119B0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Add;

			// Token: 0x040119B1 RID: 72113
			[Token(Token = "0x40119B1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x040119B2 RID: 72114
			[Token(Token = "0x40119B2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002600 RID: 9728
		[Token(Token = "0x2002600")]
		public interface IUIForceInfo
		{
		}

		// Token: 0x02002601 RID: 9729
		[Token(Token = "0x2002601")]
		public class UIForceInfo : InteractableBounceEnemy.IUIForceInfo, IHotfixable
		{
			// Token: 0x0600FD68 RID: 64872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FD68")]
			[Address(RVA = "0x766DC0", Offset = "0x7659C0", VA = "0x180766DC0")]
			public UIForceInfo()
			{
			}

			// Token: 0x040119B3 RID: 72115
			[Token(Token = "0x40119B3")]
			[FieldOffset(Offset = "0x10")]
			public FP xAxisForce;

			// Token: 0x040119B4 RID: 72116
			[Token(Token = "0x40119B4")]
			[FieldOffset(Offset = "0x18")]
			public FP yAxisForce;

			// Token: 0x040119B5 RID: 72117
			[Token(Token = "0x40119B5")]
			[FieldOffset(Offset = "0x20")]
			public FP ratio;

			// Token: 0x040119B6 RID: 72118
			[Token(Token = "0x40119B6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
