using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020F5 RID: 8437
	[Token(Token = "0x20020F5")]
	public class Headb2AttackHighlandAOEBase : AbilityStandard.Behaviour, IBuffSource, IEffectSource
	{
		// Token: 0x0600CED8 RID: 52952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CED8")]
		[Address(RVA = "0x34FFA20", Offset = "0x34FE620", VA = "0x1834FFA20", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x0600CED9 RID: 52953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CED9")]
		[Address(RVA = "0x34FFB30", Offset = "0x34FE730", VA = "0x1834FFB30", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600CEDA RID: 52954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEDA")]
		[Address(RVA = "0x34FFAA0", Offset = "0x34FE6A0", VA = "0x1834FFAA0", Slot = "9")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x0600CEDB RID: 52955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CEDB")]
		[Address(RVA = "0x35001A0", Offset = "0x34FEDA0", VA = "0x1835001A0", Slot = "18")]
		protected virtual List<Tile> _GetNeighborTiles(Tile tile)
		{
			return null;
		}

		// Token: 0x0600CEDC RID: 52956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEDC")]
		[Address(RVA = "0x35004F0", Offset = "0x34FF0F0", VA = "0x1835004F0", Slot = "19")]
		protected virtual void _TriggerAOEFromTile(Tile tile, Entity entity, Blackboard blackboard)
		{
		}

		// Token: 0x0600CEDD RID: 52957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CEDD")]
		[Address(RVA = "0x3500910", Offset = "0x34FF510", VA = "0x183500910", Slot = "20")]
		protected virtual ReusableList<Entity> _TryGetEntities_DISPOSE(Entity source, Tile tile, Blackboard blackboard, out bool failed)
		{
			return null;
		}

		// Token: 0x0600CEDE RID: 52958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEDE")]
		[Address(RVA = "0x34FFD90", Offset = "0x34FE990", VA = "0x1834FFD90", Slot = "21")]
		protected virtual void _DoAoeBuffAndDamage(Blackboard blackboard, ReusableList<Entity> targets, Tile tile, Entity source, FP damageScale)
		{
		}

		// Token: 0x0600CEDF RID: 52959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEDF")]
		[Address(RVA = "0x34FFBC0", Offset = "0x34FE7C0", VA = "0x1834FFBC0", Slot = "22")]
		protected virtual void _DealDamageAndEffect(Entity source, Entity target, FP damageScale, Blackboard blackboard)
		{
		}

		// Token: 0x0600CEE0 RID: 52960 RVA: 0x0004AB50 File Offset: 0x00048D50
		[Token(Token = "0x600CEE0")]
		[Address(RVA = "0x3500070", Offset = "0x34FEC70", VA = "0x183500070", Slot = "23")]
		protected virtual Modifier _GetModifier(Entity source, Entity target, FP damageScale, Blackboard blackboard)
		{
			return default(Modifier);
		}

		// Token: 0x0600CEE1 RID: 52961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEE1")]
		[Address(RVA = "0x34FF8A0", Offset = "0x34FE4A0", VA = "0x1834FF8A0", Slot = "16")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600CEE2 RID: 52962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEE2")]
		[Address(RVA = "0x34FF940", Offset = "0x34FE540", VA = "0x1834FF940", Slot = "17")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600CEE3 RID: 52963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEE3")]
		[Address(RVA = "0x3500CC0", Offset = "0x34FF8C0", VA = "0x183500CC0")]
		public Headb2AttackHighlandAOEBase()
		{
		}

		// Token: 0x0600CEE4 RID: 52964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEE4")]
		[Address(RVA = "0xAE3FD0", Offset = "0xAE2BD0", VA = "0x180AE3FD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x0600CEE5 RID: 52965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEE5")]
		[Address(RVA = "0x34FADF0", Offset = "0x34F99F0", VA = "0x1834FADF0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600CEE6 RID: 52966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CEE6")]
		[Address(RVA = "0x34FAB20", Offset = "0x34F9720", VA = "0x1834FAB20")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x0400DC71 RID: 56433
		[Token(Token = "0x400DC71")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected string _rangeRadiusKey;

		// Token: 0x0400DC72 RID: 56434
		[Token(Token = "0x400DC72")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected float _splashRadius;

		// Token: 0x0400DC73 RID: 56435
		[Token(Token = "0x400DC73")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected DamageType _damageType;

		// Token: 0x0400DC74 RID: 56436
		[Token(Token = "0x400DC74")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected SourceApplyWay _sourceApplyWay;

		// Token: 0x0400DC75 RID: 56437
		[Token(Token = "0x400DC75")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected TargetOptions _targetOptions;

		// Token: 0x0400DC76 RID: 56438
		[Token(Token = "0x400DC76")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected bool _excludeTarget;

		// Token: 0x0400DC77 RID: 56439
		[Token(Token = "0x400DC77")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected string _rangeId;

		// Token: 0x0400DC78 RID: 56440
		[Token(Token = "0x400DC78")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected bool _useAbilitySelector;

		// Token: 0x0400DC79 RID: 56441
		[Token(Token = "0x400DC79")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected string _abilityName;

		// Token: 0x0400DC7A RID: 56442
		[Token(Token = "0x400DC7A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		protected string _atkScaleKey;

		// Token: 0x0400DC7B RID: 56443
		[Token(Token = "0x400DC7B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected BuffData[] _buffs;

		// Token: 0x0400DC7C RID: 56444
		[Token(Token = "0x400DC7C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		protected Modifier.SourceAttackType _attackType;

		// Token: 0x0400DC7D RID: 56445
		[Token(Token = "0x400DC7D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected string _tileEffectKey;

		// Token: 0x0400DC7E RID: 56446
		[Token(Token = "0x400DC7E")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		protected string _hitEffectKey;

		// Token: 0x0400DC7F RID: 56447
		[Token(Token = "0x400DC7F")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		protected string _maxTargetCountKey;

		// Token: 0x0400DC80 RID: 56448
		[Token(Token = "0x400DC80")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		protected FilterUtil.FilterType _filterType;

		// Token: 0x0400DC81 RID: 56449
		[Token(Token = "0x400DC81")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		protected string _aoeAudioSignal;

		// Token: 0x0400DC82 RID: 56450
		[Token(Token = "0x400DC82")]
		[FieldOffset(Offset = "0xF8")]
		protected TargetOptions m_targetOptions;

		// Token: 0x0400DC83 RID: 56451
		[Token(Token = "0x400DC83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DC84 RID: 56452
		[Token(Token = "0x400DC84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0400DC85 RID: 56453
		[Token(Token = "0x400DC85")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x0400DC86 RID: 56454
		[Token(Token = "0x400DC86")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetNeighborTiles;

		// Token: 0x0400DC87 RID: 56455
		[Token(Token = "0x400DC87")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TriggerAOEFromTile;

		// Token: 0x0400DC88 RID: 56456
		[Token(Token = "0x400DC88")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryGetEntities_DISPOSE;

		// Token: 0x0400DC89 RID: 56457
		[Token(Token = "0x400DC89")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoAoeBuffAndDamage;

		// Token: 0x0400DC8A RID: 56458
		[Token(Token = "0x400DC8A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DealDamageAndEffect;

		// Token: 0x0400DC8B RID: 56459
		[Token(Token = "0x400DC8B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetModifier;

		// Token: 0x0400DC8C RID: 56460
		[Token(Token = "0x400DC8C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400DC8D RID: 56461
		[Token(Token = "0x400DC8D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400DC8E RID: 56462
		[Token(Token = "0x400DC8E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
