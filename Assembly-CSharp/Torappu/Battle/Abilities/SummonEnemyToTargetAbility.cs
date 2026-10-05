using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AF7 RID: 10999
	[Token(Token = "0x2002AF7")]
	public class SummonEnemyToTargetAbility : AbstractAnimatedAbility
	{
		// Token: 0x060125ED RID: 75245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60125ED")]
		[Address(RVA = "0xA76330", Offset = "0xA74F30", VA = "0x180A76330", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x060125EE RID: 75246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60125EE")]
		[Address(RVA = "0xA763A0", Offset = "0xA74FA0", VA = "0x180A763A0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x060125EF RID: 75247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125EF")]
		[Address(RVA = "0xA761E0", Offset = "0xA74DE0", VA = "0x180A761E0", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x060125F0 RID: 75248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125F0")]
		[Address(RVA = "0xA76280", Offset = "0xA74E80", VA = "0x180A76280", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060125F1 RID: 75249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125F1")]
		[Address(RVA = "0xA75DC0", Offset = "0xA749C0", VA = "0x180A75DC0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060125F2 RID: 75250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125F2")]
		[Address(RVA = "0xA76D20", Offset = "0xA75920", VA = "0x180A76D20", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x060125F3 RID: 75251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125F3")]
		[Address(RVA = "0xA75FB0", Offset = "0xA74BB0", VA = "0x180A75FB0")]
		public void FinishAllSummonedEnemy(object arg)
		{
		}

		// Token: 0x060125F4 RID: 75252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125F4")]
		[Address(RVA = "0xA76E50", Offset = "0xA75A50", VA = "0x180A76E50")]
		private void _CreateLineEffect(Entity target, Entity source)
		{
		}

		// Token: 0x060125F5 RID: 75253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125F5")]
		[Address(RVA = "0xA76430", Offset = "0xA75030", VA = "0x180A76430", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x060125F6 RID: 75254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125F6")]
		[Address(RVA = "0xA77000", Offset = "0xA75C00", VA = "0x180A77000")]
		public SummonEnemyToTargetAbility()
		{
		}

		// Token: 0x060125F7 RID: 75255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125F7")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x060125F8 RID: 75256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125F8")]
		[Address(RVA = "0xA53380", Offset = "0xA51F80", VA = "0x180A53380")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x060125F9 RID: 75257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125F9")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060125FA RID: 75258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125FA")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x060125FB RID: 75259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125FB")]
		[Address(RVA = "0xA25740", Offset = "0xA24340", VA = "0x180A25740")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x04014C45 RID: 85061
		[Token(Token = "0x4014C45")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		[Group("SummonEnemy")]
		private TargetSelector _sourceSelector;

		// Token: 0x04014C46 RID: 85062
		[Token(Token = "0x4014C46")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Group("SummonEnemy")]
		private string _enemyKey;

		// Token: 0x04014C47 RID: 85063
		[Token(Token = "0x4014C47")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[Group("SummonEnemy")]
		private MotionMode _motionMode;

		// Token: 0x04014C48 RID: 85064
		[Token(Token = "0x4014C48")]
		[FieldOffset(Offset = "0x1DC")]
		[SerializeField]
		[Group("SummonEnemy")]
		private bool _unharmful;

		// Token: 0x04014C49 RID: 85065
		[Token(Token = "0x4014C49")]
		[FieldOffset(Offset = "0x1DD")]
		[SerializeField]
		[Group("SummonEnemy")]
		private bool _alwaysCountAsKilled;

		// Token: 0x04014C4A RID: 85066
		[Token(Token = "0x4014C4A")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		[Group("SummonEnemy")]
		private float _waitTime;

		// Token: 0x04014C4B RID: 85067
		[Token(Token = "0x4014C4B")]
		[FieldOffset(Offset = "0x1E4")]
		[SerializeField]
		[Group("SummonEnemy")]
		private float _offset;

		// Token: 0x04014C4C RID: 85068
		[Token(Token = "0x4014C4C")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		[Group("SummonEnemy")]
		private bool _noEndPosition;

		// Token: 0x04014C4D RID: 85069
		[Token(Token = "0x4014C4D")]
		[FieldOffset(Offset = "0x1E9")]
		[SerializeField]
		[Group("SummonEnemy")]
		private bool _selectTargetAsSource;

		// Token: 0x04014C4E RID: 85070
		[Token(Token = "0x4014C4E")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		[Group("SummonEnemy")]
		private BuffData[] _buffsToEnemy;

		// Token: 0x04014C4F RID: 85071
		[Token(Token = "0x4014C4F")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		[Group("SummonEnemy")]
		private int _summonCount;

		// Token: 0x04014C50 RID: 85072
		[Token(Token = "0x4014C50")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		[Group("SummonEnemy")]
		private string _summonCountKey;

		// Token: 0x04014C51 RID: 85073
		[Token(Token = "0x4014C51")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		[Group("SummonEnemy")]
		private bool _getSourceGridFromBB;

		// Token: 0x04014C52 RID: 85074
		[Token(Token = "0x4014C52")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		[Group("SummonEnemy")]
		private List<string> _sourceGridKeys;

		// Token: 0x04014C53 RID: 85075
		[Token(Token = "0x4014C53")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		[Group("SummonEnemy")]
		private int _sourceGridCount;

		// Token: 0x04014C54 RID: 85076
		[Token(Token = "0x4014C54")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		[Group("SummonEnemy")]
		private string _sourceGridCountKey;

		// Token: 0x04014C55 RID: 85077
		[Token(Token = "0x4014C55")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		[Group("Special")]
		private bool _loadValueFromBB;

		// Token: 0x04014C56 RID: 85078
		[Token(Token = "0x4014C56")]
		[FieldOffset(Offset = "0x229")]
		[SerializeField]
		[Group("Special")]
		private bool _finishSummonedWhenOwnerFinish;

		// Token: 0x04014C57 RID: 85079
		[Token(Token = "0x4014C57")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		[Group("Special")]
		private string _lineEffectKey;

		// Token: 0x04014C58 RID: 85080
		[Token(Token = "0x4014C58")]
		[FieldOffset(Offset = "0x238")]
		private List<ObjectPtr<Enemy>> m_summonedEnemy;

		// Token: 0x04014C59 RID: 85081
		[Token(Token = "0x4014C59")]
		[FieldOffset(Offset = "0x240")]
		private string m_enemyKey;

		// Token: 0x04014C5A RID: 85082
		[Token(Token = "0x4014C5A")]
		[FieldOffset(Offset = "0x248")]
		private readonly List<GridPosition> m_sourceGridPositions;

		// Token: 0x04014C5B RID: 85083
		[Token(Token = "0x4014C5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014C5C RID: 85084
		[Token(Token = "0x4014C5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014C5D RID: 85085
		[Token(Token = "0x4014C5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04014C5E RID: 85086
		[Token(Token = "0x4014C5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04014C5F RID: 85087
		[Token(Token = "0x4014C5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014C60 RID: 85088
		[Token(Token = "0x4014C60")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014C61 RID: 85089
		[Token(Token = "0x4014C61")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FinishAllSummonedEnemy;

		// Token: 0x04014C62 RID: 85090
		[Token(Token = "0x4014C62")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateLineEffect;

		// Token: 0x04014C63 RID: 85091
		[Token(Token = "0x4014C63")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04014C64 RID: 85092
		[Token(Token = "0x4014C64")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
