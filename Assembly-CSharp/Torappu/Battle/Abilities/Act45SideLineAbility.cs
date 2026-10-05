using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Projectiles;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B7A RID: 11130
	[Token(Token = "0x2002B7A")]
	public class Act45SideLineAbility : AbstractAnimatedAbility, IEffectSource
	{
		// Token: 0x06012B32 RID: 76594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B32")]
		[Address(RVA = "0xA97A80", Offset = "0xA96680", VA = "0x180A97A80", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012B33 RID: 76595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B33")]
		[Address(RVA = "0xA96DC0", Offset = "0xA959C0", VA = "0x180A96DC0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012B34 RID: 76596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B34")]
		[Address(RVA = "0xA972C0", Offset = "0xA95EC0", VA = "0x180A972C0", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012B35 RID: 76597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B35")]
		[Address(RVA = "0xA976D0", Offset = "0xA962D0", VA = "0x180A976D0", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012B36 RID: 76598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B36")]
		[Address(RVA = "0xA97230", Offset = "0xA95E30", VA = "0x180A97230", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012B37 RID: 76599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B37")]
		[Address(RVA = "0xA96D50", Offset = "0xA95950", VA = "0x180A96D50", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012B38 RID: 76600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B38")]
		[Address(RVA = "0xA98180", Offset = "0xA96D80", VA = "0x180A98180")]
		private void _ClearLines()
		{
		}

		// Token: 0x06012B39 RID: 76601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B39")]
		[Address(RVA = "0xA98910", Offset = "0xA97510", VA = "0x180A98910")]
		private void _RemoveLine(Act45SideLineAbility.LinePairData data)
		{
		}

		// Token: 0x06012B3A RID: 76602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B3A")]
		[Address(RVA = "0xA98B60", Offset = "0xA97760", VA = "0x180A98B60")]
		private void _UpdateTargets()
		{
		}

		// Token: 0x06012B3B RID: 76603 RVA: 0x00072990 File Offset: 0x00070B90
		[Token(Token = "0x6012B3B")]
		[Address(RVA = "0xA98010", Offset = "0xA96C10", VA = "0x180A98010")]
		private bool _CheckTargetIsValid(ObjectPtr<Entity> entityPtr)
		{
			return default(bool);
		}

		// Token: 0x06012B3C RID: 76604 RVA: 0x000729A8 File Offset: 0x00070BA8
		[Token(Token = "0x6012B3C")]
		[Address(RVA = "0xA97EF0", Offset = "0xA96AF0", VA = "0x180A97EF0")]
		private bool _CheckBlockerIsValid(ObjectPtr<Character> characterPtr, bool isCurrentTarget)
		{
			return default(bool);
		}

		// Token: 0x06012B3D RID: 76605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B3D")]
		[Address(RVA = "0xA986B0", Offset = "0xA972B0", VA = "0x180A986B0")]
		private void _RemoveFromBlocker(Act45SideLineAbility.LinePairData data)
		{
		}

		// Token: 0x06012B3E RID: 76606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B3E")]
		[Address(RVA = "0xA96B60", Offset = "0xA95760", VA = "0x180A96B60")]
		public void ClearLines(Character blocker)
		{
		}

		// Token: 0x06012B3F RID: 76607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B3F")]
		[Address(RVA = "0xA982B0", Offset = "0xA96EB0", VA = "0x180A982B0")]
		private void _CreateCheckProjectile()
		{
		}

		// Token: 0x06012B40 RID: 76608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B40")]
		[Address(RVA = "0xA984B0", Offset = "0xA970B0", VA = "0x180A984B0")]
		protected void _CreateProjectileUseSourceAsProjectileSource(string projectileKey, Entity source, Entity target, out Projectile projectile)
		{
		}

		// Token: 0x06012B41 RID: 76609 RVA: 0x000729C0 File Offset: 0x00070BC0
		[Token(Token = "0x6012B41")]
		[Address(RVA = "0xA97B60", Offset = "0xA96760", VA = "0x180A97B60")]
		public bool TryAddBlockToTarget(Entity lineTarget, Character blocker, out bool hasBlocker)
		{
			return default(bool);
		}

		// Token: 0x06012B42 RID: 76610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B42")]
		[Address(RVA = "0xA96F00", Offset = "0xA95B00", VA = "0x180A96F00")]
		public void ForceRemoveBuff(Act45SideLineAbility.LinePairData data)
		{
		}

		// Token: 0x06012B43 RID: 76611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B43")]
		[Address(RVA = "0xA96A20", Offset = "0xA95620", VA = "0x180A96A20")]
		public void ClearBlockerIfNoTarget(Entity lineTarget)
		{
		}

		// Token: 0x06012B44 RID: 76612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012B44")]
		[Address(RVA = "0xA971A0", Offset = "0xA95DA0", VA = "0x180A971A0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012B45 RID: 76613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012B45")]
		[Address(RVA = "0xA97130", Offset = "0xA95D30", VA = "0x180A97130", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012B46 RID: 76614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B46")]
		[Address(RVA = "0xA97080", Offset = "0xA95C80", VA = "0x180A97080", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012B47 RID: 76615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B47")]
		[Address(RVA = "0xA98FF0", Offset = "0xA97BF0", VA = "0x180A98FF0")]
		public Act45SideLineAbility()
		{
		}

		// Token: 0x06012B48 RID: 76616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B48")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012B49 RID: 76617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B49")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012B4A RID: 76618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B4A")]
		[Address(RVA = "0xA25740", Offset = "0xA24340", VA = "0x180A25740")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x06012B4B RID: 76619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B4B")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012B4C RID: 76620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B4C")]
		[Address(RVA = "0xA1E520", Offset = "0xA1D120", VA = "0x180A1E520")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012B4D RID: 76621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B4D")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012B4E RID: 76622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B4E")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x04015213 RID: 86547
		[Token(Token = "0x4015213")]
		protected const int TRIGGER_TICK = 10;

		// Token: 0x04015214 RID: 86548
		[Token(Token = "0x4015214")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private BuffData _lineBuff;

		// Token: 0x04015215 RID: 86549
		[Token(Token = "0x4015215")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private BuffData _lineBuffMark;

		// Token: 0x04015216 RID: 86550
		[Token(Token = "0x4015216")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private string _checkProjectileKey;

		// Token: 0x04015217 RID: 86551
		[Token(Token = "0x4015217")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private bool _clearLineOnCastEnd;

		// Token: 0x04015218 RID: 86552
		[Token(Token = "0x4015218")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private string _lineProjectileKey;

		// Token: 0x04015219 RID: 86553
		[Token(Token = "0x4015219")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private Entity.MountPointType _checkPointStart;

		// Token: 0x0401521A RID: 86554
		[Token(Token = "0x401521A")]
		[FieldOffset(Offset = "0x1F8")]
		protected List<Act45SideLineAbility.LinePairData> m_targetsPair;

		// Token: 0x0401521B RID: 86555
		[Token(Token = "0x401521B")]
		[FieldOffset(Offset = "0x200")]
		private Dictionary<ObjectPtr<Entity>, Act45SideLineAbility.LinePairData> m_targetsPairDict;

		// Token: 0x0401521C RID: 86556
		[Token(Token = "0x401521C")]
		[FieldOffset(Offset = "0x208")]
		private PeriodicTicker m_triggerTicker;

		// Token: 0x0401521D RID: 86557
		[Token(Token = "0x401521D")]
		[FieldOffset(Offset = "0x210")]
		private FP m_lineTime;

		// Token: 0x0401521E RID: 86558
		[Token(Token = "0x401521E")]
		[FieldOffset(Offset = "0x218")]
		private bool m_isCasted;

		// Token: 0x0401521F RID: 86559
		[Token(Token = "0x401521F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04015220 RID: 86560
		[Token(Token = "0x4015220")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015221 RID: 86561
		[Token(Token = "0x4015221")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04015222 RID: 86562
		[Token(Token = "0x4015222")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015223 RID: 86563
		[Token(Token = "0x4015223")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04015224 RID: 86564
		[Token(Token = "0x4015224")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04015225 RID: 86565
		[Token(Token = "0x4015225")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearLines;

		// Token: 0x04015226 RID: 86566
		[Token(Token = "0x4015226")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RemoveLine;

		// Token: 0x04015227 RID: 86567
		[Token(Token = "0x4015227")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateTargets;

		// Token: 0x04015228 RID: 86568
		[Token(Token = "0x4015228")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckTargetIsValid;

		// Token: 0x04015229 RID: 86569
		[Token(Token = "0x4015229")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckBlockerIsValid;

		// Token: 0x0401522A RID: 86570
		[Token(Token = "0x401522A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RemoveFromBlocker;

		// Token: 0x0401522B RID: 86571
		[Token(Token = "0x401522B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ClearLines;

		// Token: 0x0401522C RID: 86572
		[Token(Token = "0x401522C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CreateCheckProjectile;

		// Token: 0x0401522D RID: 86573
		[Token(Token = "0x401522D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CreateProjectileUseSourceAsProjectileSource;

		// Token: 0x0401522E RID: 86574
		[Token(Token = "0x401522E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_TryAddBlockToTarget;

		// Token: 0x0401522F RID: 86575
		[Token(Token = "0x401522F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ForceRemoveBuff;

		// Token: 0x04015230 RID: 86576
		[Token(Token = "0x4015230")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ClearBlockerIfNoTarget;

		// Token: 0x04015231 RID: 86577
		[Token(Token = "0x4015231")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04015232 RID: 86578
		[Token(Token = "0x4015232")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04015233 RID: 86579
		[Token(Token = "0x4015233")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04015234 RID: 86580
		[Token(Token = "0x4015234")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B7B RID: 11131
		[Token(Token = "0x2002B7B")]
		public class LinePairData
		{
			// Token: 0x06012B4F RID: 76623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012B4F")]
			[Address(RVA = "0xAC1960", Offset = "0xAC0560", VA = "0x180AC1960")]
			public LinePairData()
			{
			}

			// Token: 0x04015235 RID: 86581
			[Token(Token = "0x4015235")]
			[FieldOffset(Offset = "0x10")]
			public ObjectPtr<Entity> lineTarget;

			// Token: 0x04015236 RID: 86582
			[Token(Token = "0x4015236")]
			[FieldOffset(Offset = "0x20")]
			public ObjectPtr<Character> blocker;

			// Token: 0x04015237 RID: 86583
			[Token(Token = "0x4015237")]
			[FieldOffset(Offset = "0x30")]
			public ObjectPtr<Buff> buffToTarget;

			// Token: 0x04015238 RID: 86584
			[Token(Token = "0x4015238")]
			[FieldOffset(Offset = "0x40")]
			public ObjectPtr<Buff> buffToTargetMark;

			// Token: 0x04015239 RID: 86585
			[Token(Token = "0x4015239")]
			[FieldOffset(Offset = "0x50")]
			public Act45SideHarpoonRenderer lineProjectile;

			// Token: 0x0401523A RID: 86586
			[Token(Token = "0x401523A")]
			[FieldOffset(Offset = "0x58")]
			public FP remainTime;

			// Token: 0x0401523B RID: 86587
			[Token(Token = "0x401523B")]
			[FieldOffset(Offset = "0x60")]
			public bool isWork;
		}
	}
}
