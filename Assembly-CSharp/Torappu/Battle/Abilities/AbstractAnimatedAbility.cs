using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B0F RID: 11023
	[Token(Token = "0x2002B0F")]
	public abstract class AbstractAnimatedAbility : EasyToStartAbility
	{
		// Token: 0x1700288D RID: 10381
		// (get) Token: 0x06012733 RID: 75571 RVA: 0x00071118 File Offset: 0x0006F318
		[Token(Token = "0x1700288D")]
		public bool needSpecifiedCooldown
		{
			[Token(Token = "0x6012733")]
			[Address(RVA = "0xA6E990", Offset = "0xA6D590", VA = "0x180A6E990")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700288E RID: 10382
		// (get) Token: 0x06012734 RID: 75572 RVA: 0x00071130 File Offset: 0x0006F330
		[Token(Token = "0x1700288E")]
		public bool loadFromBlackboard
		{
			[Token(Token = "0x6012734")]
			[Address(RVA = "0xA6E930", Offset = "0xA6D530", VA = "0x180A6E930")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700288F RID: 10383
		// (get) Token: 0x06012735 RID: 75573 RVA: 0x00071148 File Offset: 0x0006F348
		[Token(Token = "0x1700288F")]
		public AbstractAnimatedAbility.TimeMode timeMode
		{
			[Token(Token = "0x6012735")]
			[Address(RVA = "0xA6EB10", Offset = "0xA6D710", VA = "0x180A6EB10")]
			get
			{
				return AbstractAnimatedAbility.TimeMode.FROM_ATTACK_SPEED;
			}
		}

		// Token: 0x17002890 RID: 10384
		// (get) Token: 0x06012736 RID: 75574 RVA: 0x00071160 File Offset: 0x0006F360
		[Token(Token = "0x17002890")]
		public float animScale
		{
			[Token(Token = "0x6012736")]
			[Address(RVA = "0xA6E4B0", Offset = "0xA6D0B0", VA = "0x180A6E4B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002891 RID: 10385
		// (get) Token: 0x06012737 RID: 75575 RVA: 0x00071178 File Offset: 0x0006F378
		[Token(Token = "0x17002891")]
		protected virtual Modifier.SourceAttackType attackType
		{
			[Token(Token = "0x6012737")]
			[Address(RVA = "0xA6E510", Offset = "0xA6D110", VA = "0x180A6E510", Slot = "99")]
			get
			{
				return Modifier.SourceAttackType.NONE;
			}
		}

		// Token: 0x17002892 RID: 10386
		// (get) Token: 0x06012738 RID: 75576 RVA: 0x00071190 File Offset: 0x0006F390
		[Token(Token = "0x17002892")]
		protected virtual bool useDynamicAttackType
		{
			[Token(Token = "0x6012738")]
			[Address(RVA = "0xA6EB70", Offset = "0xA6D770", VA = "0x180A6EB70", Slot = "100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002893 RID: 10387
		// (get) Token: 0x06012739 RID: 75577 RVA: 0x000711A8 File Offset: 0x0006F3A8
		[Token(Token = "0x17002893")]
		public override bool canSelectCamouflageTarget
		{
			[Token(Token = "0x6012739")]
			[Address(RVA = "0xA6E570", Offset = "0xA6D170", VA = "0x180A6E570", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002894 RID: 10388
		// (get) Token: 0x0601273A RID: 75578 RVA: 0x000711C0 File Offset: 0x0006F3C0
		[Token(Token = "0x17002894")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x601273A")]
			[Address(RVA = "0xA6EA50", Offset = "0xA6D650", VA = "0x180A6EA50", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x17002895 RID: 10389
		// (get) Token: 0x0601273B RID: 75579 RVA: 0x000711D8 File Offset: 0x0006F3D8
		[Token(Token = "0x17002895")]
		public override AbilityStandard.SelectTargetTiming selectTargetTiming
		{
			[Token(Token = "0x601273B")]
			[Address(RVA = "0xA6EAB0", Offset = "0xA6D6B0", VA = "0x180A6EAB0", Slot = "66")]
			get
			{
				return AbilityStandard.SelectTargetTiming.AT_BEGINING;
			}
		}

		// Token: 0x17002896 RID: 10390
		// (get) Token: 0x0601273C RID: 75580 RVA: 0x000711F0 File Offset: 0x0006F3F0
		[Token(Token = "0x17002896")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x601273C")]
			[Address(RVA = "0xA6E450", Offset = "0xA6D050", VA = "0x180A6E450", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002897 RID: 10391
		// (get) Token: 0x0601273D RID: 75581 RVA: 0x00071208 File Offset: 0x0006F408
		[Token(Token = "0x17002897")]
		protected bool forceFaceToDirection
		{
			[Token(Token = "0x601273D")]
			[Address(RVA = "0xA6E870", Offset = "0xA6D470", VA = "0x180A6E870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002898 RID: 10392
		// (get) Token: 0x0601273E RID: 75582 RVA: 0x00071220 File Offset: 0x0006F420
		[Token(Token = "0x17002898")]
		public override bool allowNoTarget
		{
			[Token(Token = "0x601273E")]
			[Address(RVA = "0xA6E3E0", Offset = "0xA6CFE0", VA = "0x180A6E3E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002899 RID: 10393
		// (get) Token: 0x0601273F RID: 75583 RVA: 0x00071238 File Offset: 0x0006F438
		[Token(Token = "0x17002899")]
		public override FP preDelay
		{
			[Token(Token = "0x601273F")]
			[Address(RVA = "0xA6E9F0", Offset = "0xA6D5F0", VA = "0x180A6E9F0", Slot = "96")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700289A RID: 10394
		// (get) Token: 0x06012740 RID: 75584 RVA: 0x00071250 File Offset: 0x0006F450
		[Token(Token = "0x1700289A")]
		public override FP escapeTime
		{
			[Token(Token = "0x6012740")]
			[Address(RVA = "0xA6E7E0", Offset = "0xA6D3E0", VA = "0x180A6E7E0", Slot = "21")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700289B RID: 10395
		// (get) Token: 0x06012741 RID: 75585 RVA: 0x00071268 File Offset: 0x0006F468
		[Token(Token = "0x1700289B")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012741")]
			[Address(RVA = "0xA6E620", Offset = "0xA6D220", VA = "0x180A6E620", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x1700289C RID: 10396
		// (get) Token: 0x06012742 RID: 75586 RVA: 0x00071280 File Offset: 0x0006F480
		[Token(Token = "0x1700289C")]
		public override FP cooldown
		{
			[Token(Token = "0x6012742")]
			[Address(RVA = "0xA6E680", Offset = "0xA6D280", VA = "0x180A6E680", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700289D RID: 10397
		// (get) Token: 0x06012743 RID: 75587 RVA: 0x00071298 File Offset: 0x0006F498
		[Token(Token = "0x1700289D")]
		public override bool ignorePalsyInterrupt
		{
			[Token(Token = "0x6012743")]
			[Address(RVA = "0xA6E8D0", Offset = "0xA6D4D0", VA = "0x180A6E8D0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012744 RID: 75588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012744")]
		[Address(RVA = "0xA6DA30", Offset = "0xA6C630", VA = "0x180A6DA30", Slot = "56")]
		public override void OnAttackTimeChanged(FP newValue)
		{
		}

		// Token: 0x06012745 RID: 75589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012745")]
		[Address(RVA = "0xA6CD40", Offset = "0xA6B940", VA = "0x180A6CD40")]
		public void ApplyAttackTime(FP newAttackTime)
		{
		}

		// Token: 0x06012746 RID: 75590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012746")]
		[Address(RVA = "0xA6D5C0", Offset = "0xA6C1C0", VA = "0x180A6D5C0", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012747 RID: 75591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012747")]
		[Address(RVA = "0xA6D780", Offset = "0xA6C380", VA = "0x180A6D780", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012748 RID: 75592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012748")]
		[Address(RVA = "0xA6D470", Offset = "0xA6C070", VA = "0x180A6D470", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012749 RID: 75593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012749")]
		[Address(RVA = "0xA6DEF0", Offset = "0xA6CAF0", VA = "0x180A6DEF0", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x0601274A RID: 75594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601274A")]
		[Address(RVA = "0xA6D1A0", Offset = "0xA6BDA0", VA = "0x180A6D1A0", Slot = "101")]
		protected virtual void DealWithFaceDirection()
		{
		}

		// Token: 0x0601274B RID: 75595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601274B")]
		[Address(RVA = "0xA6DB60", Offset = "0xA6C760", VA = "0x180A6DB60", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x0601274C RID: 75596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601274C")]
		[Address(RVA = "0xA6CF90", Offset = "0xA6BB90", VA = "0x180A6CF90", Slot = "102")]
		protected virtual Nodes.ApplyDamage CreateDamageNode(DamageType damageType, FP atkScale)
		{
			return null;
		}

		// Token: 0x0601274D RID: 75597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601274D")]
		[Address(RVA = "0xA6D7E0", Offset = "0xA6C3E0", VA = "0x180A6D7E0", Slot = "103")]
		protected virtual Nodes.ApplyDamage NewDamageNode(DamageType damageType, FP atkScale)
		{
			return null;
		}

		// Token: 0x0601274E RID: 75598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601274E")]
		[Address(RVA = "0xA6D060", Offset = "0xA6BC60", VA = "0x180A6D060", Slot = "104")]
		protected virtual Nodes.ApplyElementDamage CreateElementDamageNode(ElementType elementType, FP epDamageRatio)
		{
			return null;
		}

		// Token: 0x0601274F RID: 75599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601274F")]
		[Address(RVA = "0xA6D970", Offset = "0xA6C570", VA = "0x180A6D970")]
		protected Nodes.ApplyElementDamage NewElementDamageNode(ElementType elementType, FP epDamageRatio)
		{
			return null;
		}

		// Token: 0x06012750 RID: 75600 RVA: 0x000712B0 File Offset: 0x0006F4B0
		[Token(Token = "0x6012750")]
		[Address(RVA = "0xA6D720", Offset = "0xA6C320", VA = "0x180A6D720", Slot = "98")]
		protected override FP GetDuration()
		{
			return default(FP);
		}

		// Token: 0x06012751 RID: 75601 RVA: 0x000712C8 File Offset: 0x0006F4C8
		[Token(Token = "0x6012751")]
		[Address(RVA = "0xA6E070", Offset = "0xA6CC70", VA = "0x180A6E070", Slot = "88")]
		protected override bool UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming timing, out float animSpeed)
		{
			return default(bool);
		}

		// Token: 0x06012752 RID: 75602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012752")]
		[Address(RVA = "0xA6D620", Offset = "0xA6C220", VA = "0x180A6D620", Slot = "105")]
		public virtual string GetAnimKey()
		{
			return null;
		}

		// Token: 0x06012753 RID: 75603 RVA: 0x000712E0 File Offset: 0x0006F4E0
		[Token(Token = "0x6012753")]
		[Address(RVA = "0xA6CE10", Offset = "0xA6BA10", VA = "0x180A6CE10", Slot = "106")]
		protected virtual bool CheckDownAttack()
		{
			return default(bool);
		}

		// Token: 0x06012754 RID: 75604 RVA: 0x000712F8 File Offset: 0x0006F4F8
		[Token(Token = "0x6012754")]
		[Address(RVA = "0xA6CED0", Offset = "0xA6BAD0", VA = "0x180A6CED0", Slot = "107")]
		protected virtual bool CheckUpAttack()
		{
			return default(bool);
		}

		// Token: 0x06012755 RID: 75605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012755")]
		[Address(RVA = "0xA6E300", Offset = "0xA6CF00", VA = "0x180A6E300")]
		protected AbstractAnimatedAbility()
		{
		}

		// Token: 0x06012756 RID: 75606 RVA: 0x00071310 File Offset: 0x0006F510
		[Token(Token = "0x6012756")]
		[Address(RVA = "0xA6E040", Offset = "0xA6CC40", VA = "0x180A6E040")]
		private bool <>xLuaBaseProxy_get_canSelectCamouflageTarget()
		{
			return default(bool);
		}

		// Token: 0x06012757 RID: 75607 RVA: 0x00071328 File Offset: 0x0006F528
		[Token(Token = "0x6012757")]
		[Address(RVA = "0xA6E060", Offset = "0xA6CC60", VA = "0x180A6E060")]
		private AbilityStandard.SelectTargetTiming <>xLuaBaseProxy_get_selectTargetTiming()
		{
			return AbilityStandard.SelectTargetTiming.AT_BEGINING;
		}

		// Token: 0x06012758 RID: 75608 RVA: 0x00071340 File Offset: 0x0006F540
		[Token(Token = "0x6012758")]
		[Address(RVA = "0xA23D10", Offset = "0xA22910", VA = "0x180A23D10")]
		private bool <>xLuaBaseProxy_get_allowNoTarget()
		{
			return default(bool);
		}

		// Token: 0x06012759 RID: 75609 RVA: 0x00071358 File Offset: 0x0006F558
		[Token(Token = "0x6012759")]
		[Address(RVA = "0xA4D1F0", Offset = "0xA4BDF0", VA = "0x180A4D1F0")]
		private FP <>xLuaBaseProxy_get_escapeTime()
		{
			return default(FP);
		}

		// Token: 0x0601275A RID: 75610 RVA: 0x00071370 File Offset: 0x0006F570
		[Token(Token = "0x601275A")]
		[Address(RVA = "0xA6E050", Offset = "0xA6CC50", VA = "0x180A6E050")]
		private bool <>xLuaBaseProxy_get_ignorePalsyInterrupt()
		{
			return default(bool);
		}

		// Token: 0x0601275B RID: 75611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601275B")]
		[Address(RVA = "0xA66020", Offset = "0xA64C20", VA = "0x180A66020")]
		private void <>xLuaBaseProxy_OnAttackTimeChanged(FP P0)
		{
		}

		// Token: 0x0601275C RID: 75612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601275C")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x0601275D RID: 75613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601275D")]
		[Address(RVA = "0xA6E020", Offset = "0xA6CC20", VA = "0x180A6E020")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0601275E RID: 75614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601275E")]
		[Address(RVA = "0xA6E010", Offset = "0xA6CC10", VA = "0x180A6E010")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x0601275F RID: 75615 RVA: 0x00071388 File Offset: 0x0006F588
		[Token(Token = "0x601275F")]
		[Address(RVA = "0xA6E030", Offset = "0xA6CC30", VA = "0x180A6E030")]
		private bool <>xLuaBaseProxy_UpdatePlaybackSpeed(AbilityStandard.UpdatePlaybackSpeedTiming P0, out float P1)
		{
			return default(bool);
		}

		// Token: 0x04014D9E RID: 85406
		[Token(Token = "0x4014D9E")]
		private const float MIN_ANIM_SCALE = 0.1f;

		// Token: 0x04014D9F RID: 85407
		[Token(Token = "0x4014D9F")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private AbilityStandard.SelectTargetSource _selectTargetSource;

		// Token: 0x04014DA0 RID: 85408
		[Token(Token = "0x4014DA0")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		private AbilityStandard.SelectTargetTiming _selectTargetTiming;

		// Token: 0x04014DA1 RID: 85409
		[Token(Token = "0x4014DA1")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private AbstractAnimatedAbility.TimeMode _timeMode;

		// Token: 0x04014DA2 RID: 85410
		[Token(Token = "0x4014DA2")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		protected bool _alwaysIncludeTarget;

		// Token: 0x04014DA3 RID: 85411
		[Token(Token = "0x4014DA3")]
		[FieldOffset(Offset = "0x13D")]
		[SerializeField]
		private bool _allowNoTarget;

		// Token: 0x04014DA4 RID: 85412
		[Token(Token = "0x4014DA4")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private string _animKey;

		// Token: 0x04014DA5 RID: 85413
		[Token(Token = "0x4014DA5")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private string _endAnimKey;

		// Token: 0x04014DA6 RID: 85414
		[Token(Token = "0x4014DA6")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private string _downAnimKey;

		// Token: 0x04014DA7 RID: 85415
		[Token(Token = "0x4014DA7")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private string _downEndAnimKey;

		// Token: 0x04014DA8 RID: 85416
		[Token(Token = "0x4014DA8")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private string _upAnimKey;

		// Token: 0x04014DA9 RID: 85417
		[Token(Token = "0x4014DA9")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private string _upEndAnimKey;

		// Token: 0x04014DAA RID: 85418
		[Token(Token = "0x4014DAA")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Inspect("needSpecifiedCooldown")]
		private float _cooldown;

		// Token: 0x04014DAB RID: 85419
		[Token(Token = "0x4014DAB")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Inspect("loadFromBlackboard")]
		private string _cooldownKey;

		// Token: 0x04014DAC RID: 85420
		[Token(Token = "0x4014DAC")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Inspect("waitForAttackEvent", false)]
		private float _preDelay;

		// Token: 0x04014DAD RID: 85421
		[Token(Token = "0x4014DAD")]
		[FieldOffset(Offset = "0x184")]
		[SerializeField]
		private float _escapeTime;

		// Token: 0x04014DAE RID: 85422
		[Token(Token = "0x4014DAE")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		protected bool _faceToTarget;

		// Token: 0x04014DAF RID: 85423
		[Token(Token = "0x4014DAF")]
		[FieldOffset(Offset = "0x189")]
		[SerializeField]
		private bool _faceToDefault;

		// Token: 0x04014DB0 RID: 85424
		[Token(Token = "0x4014DB0")]
		[FieldOffset(Offset = "0x18A")]
		[SerializeField]
		private bool _faceToFront;

		// Token: 0x04014DB1 RID: 85425
		[Token(Token = "0x4014DB1")]
		[FieldOffset(Offset = "0x18B")]
		[SerializeField]
		private bool _faceToFirstCastTarget;

		// Token: 0x04014DB2 RID: 85426
		[Token(Token = "0x4014DB2")]
		[FieldOffset(Offset = "0x18C")]
		[SerializeField]
		private bool _forceFaceToDirection;

		// Token: 0x04014DB3 RID: 85427
		[Token(Token = "0x4014DB3")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private BuffData[] _activeBuffs;

		// Token: 0x04014DB4 RID: 85428
		[Token(Token = "0x4014DB4")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private float _maxAnimScale;

		// Token: 0x04014DB5 RID: 85429
		[Token(Token = "0x4014DB5")]
		[FieldOffset(Offset = "0x19C")]
		[SerializeField]
		private bool _onlyPlayEndAnimWhenIsLastAbility;

		// Token: 0x04014DB6 RID: 85430
		[Token(Token = "0x4014DB6")]
		[FieldOffset(Offset = "0x19D")]
		[SerializeField]
		protected bool _ignorePalsyInterrupt;

		// Token: 0x04014DB7 RID: 85431
		[Token(Token = "0x4014DB7")]
		[FieldOffset(Offset = "0x1A0")]
		private FP m_preDelay;

		// Token: 0x04014DB8 RID: 85432
		[Token(Token = "0x4014DB8")]
		[FieldOffset(Offset = "0x1A8")]
		private FP m_attackTime;

		// Token: 0x04014DB9 RID: 85433
		[Token(Token = "0x4014DB9")]
		[FieldOffset(Offset = "0x1B0")]
		protected float m_animScale;

		// Token: 0x04014DBA RID: 85434
		[Token(Token = "0x4014DBA")]
		[FieldOffset(Offset = "0x1B8")]
		protected Nodes.ApplyDamage m_damageNode;

		// Token: 0x04014DBB RID: 85435
		[Token(Token = "0x4014DBB")]
		[FieldOffset(Offset = "0x1C0")]
		protected Nodes.ApplyElementDamage m_epDamageNode;

		// Token: 0x04014DBC RID: 85436
		[Token(Token = "0x4014DBC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_needSpecifiedCooldown;

		// Token: 0x04014DBD RID: 85437
		[Token(Token = "0x4014DBD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_loadFromBlackboard;

		// Token: 0x04014DBE RID: 85438
		[Token(Token = "0x4014DBE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_timeMode;

		// Token: 0x04014DBF RID: 85439
		[Token(Token = "0x4014DBF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_animScale;

		// Token: 0x04014DC0 RID: 85440
		[Token(Token = "0x4014DC0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_attackType;

		// Token: 0x04014DC1 RID: 85441
		[Token(Token = "0x4014DC1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_useDynamicAttackType;

		// Token: 0x04014DC2 RID: 85442
		[Token(Token = "0x4014DC2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_canSelectCamouflageTarget;

		// Token: 0x04014DC3 RID: 85443
		[Token(Token = "0x4014DC3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014DC4 RID: 85444
		[Token(Token = "0x4014DC4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_selectTargetTiming;

		// Token: 0x04014DC5 RID: 85445
		[Token(Token = "0x4014DC5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014DC6 RID: 85446
		[Token(Token = "0x4014DC6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_forceFaceToDirection;

		// Token: 0x04014DC7 RID: 85447
		[Token(Token = "0x4014DC7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_allowNoTarget;

		// Token: 0x04014DC8 RID: 85448
		[Token(Token = "0x4014DC8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_preDelay;

		// Token: 0x04014DC9 RID: 85449
		[Token(Token = "0x4014DC9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_escapeTime;

		// Token: 0x04014DCA RID: 85450
		[Token(Token = "0x4014DCA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014DCB RID: 85451
		[Token(Token = "0x4014DCB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014DCC RID: 85452
		[Token(Token = "0x4014DCC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_ignorePalsyInterrupt;

		// Token: 0x04014DCD RID: 85453
		[Token(Token = "0x4014DCD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

		// Token: 0x04014DCE RID: 85454
		[Token(Token = "0x4014DCE")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ApplyAttackTime;

		// Token: 0x04014DCF RID: 85455
		[Token(Token = "0x4014DCF")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014DD0 RID: 85456
		[Token(Token = "0x4014DD0")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014DD1 RID: 85457
		[Token(Token = "0x4014DD1")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014DD2 RID: 85458
		[Token(Token = "0x4014DD2")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04014DD3 RID: 85459
		[Token(Token = "0x4014DD3")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_DealWithFaceDirection;

		// Token: 0x04014DD4 RID: 85460
		[Token(Token = "0x4014DD4")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014DD5 RID: 85461
		[Token(Token = "0x4014DD5")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CreateDamageNode;

		// Token: 0x04014DD6 RID: 85462
		[Token(Token = "0x4014DD6")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_NewDamageNode;

		// Token: 0x04014DD7 RID: 85463
		[Token(Token = "0x4014DD7")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CreateElementDamageNode;

		// Token: 0x04014DD8 RID: 85464
		[Token(Token = "0x4014DD8")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_NewElementDamageNode;

		// Token: 0x04014DD9 RID: 85465
		[Token(Token = "0x4014DD9")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetDuration;

		// Token: 0x04014DDA RID: 85466
		[Token(Token = "0x4014DDA")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_UpdatePlaybackSpeed;

		// Token: 0x04014DDB RID: 85467
		[Token(Token = "0x4014DDB")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetAnimKey;

		// Token: 0x04014DDC RID: 85468
		[Token(Token = "0x4014DDC")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CheckDownAttack;

		// Token: 0x04014DDD RID: 85469
		[Token(Token = "0x4014DDD")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CheckUpAttack;

		// Token: 0x04014DDE RID: 85470
		[Token(Token = "0x4014DDE")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B10 RID: 11024
		[Token(Token = "0x2002B10")]
		public enum TimeMode
		{
			// Token: 0x04014DE0 RID: 85472
			[Token(Token = "0x4014DE0")]
			FROM_ATTACK_SPEED,
			// Token: 0x04014DE1 RID: 85473
			[Token(Token = "0x4014DE1")]
			FROM_ANIMATION,
			// Token: 0x04014DE2 RID: 85474
			[Token(Token = "0x4014DE2")]
			SPECIFIED,
			// Token: 0x04014DE3 RID: 85475
			[Token(Token = "0x4014DE3")]
			LOAD_FROM_BLACKBOARD
		}
	}
}
