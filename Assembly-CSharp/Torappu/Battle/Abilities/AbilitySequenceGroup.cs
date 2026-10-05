using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B0B RID: 11019
	[Token(Token = "0x2002B0B")]
	public class AbilitySequenceGroup : AbilityStandard
	{
		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x060126F9 RID: 75513 RVA: 0x00070F38 File Offset: 0x0006F138
		[Token(Token = "0x17002881")]
		private bool alwaysNext
		{
			[Token(Token = "0x60126F9")]
			[Address(RVA = "0xA6C960", Offset = "0xA6B560", VA = "0x180A6C960")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002882 RID: 10370
		// (get) Token: 0x060126FA RID: 75514 RVA: 0x00070F50 File Offset: 0x0006F150
		[Token(Token = "0x17002882")]
		public override FP cooldown
		{
			[Token(Token = "0x60126FA")]
			[Address(RVA = "0xA6CA20", Offset = "0xA6B620", VA = "0x180A6CA20", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002883 RID: 10371
		// (get) Token: 0x060126FB RID: 75515 RVA: 0x00070F68 File Offset: 0x0006F168
		[Token(Token = "0x17002883")]
		public override Ability.Category category
		{
			[Token(Token = "0x60126FB")]
			[Address(RVA = "0xA6C9C0", Offset = "0xA6B5C0", VA = "0x180A6C9C0", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x060126FC RID: 75516 RVA: 0x00070F80 File Offset: 0x0006F180
		[Token(Token = "0x17002884")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x60126FC")]
			[Address(RVA = "0xA6CCE0", Offset = "0xA6B8E0", VA = "0x180A6CCE0", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x060126FD RID: 75517 RVA: 0x00070F98 File Offset: 0x0006F198
		[Token(Token = "0x17002885")]
		public override bool isAffecting
		{
			[Token(Token = "0x60126FD")]
			[Address(RVA = "0xA6CB90", Offset = "0xA6B790", VA = "0x180A6CB90", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x060126FE RID: 75518 RVA: 0x00070FB0 File Offset: 0x0006F1B0
		[Token(Token = "0x17002886")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x60126FE")]
			[Address(RVA = "0xA6C900", Offset = "0xA6B500", VA = "0x180A6C900", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x060126FF RID: 75519 RVA: 0x00070FC8 File Offset: 0x0006F1C8
		[Token(Token = "0x17002887")]
		protected bool alsoInterruptCurrentSubAbility
		{
			[Token(Token = "0x60126FF")]
			[Address(RVA = "0xA6C8A0", Offset = "0xA6B4A0", VA = "0x180A6C8A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002888 RID: 10376
		// (get) Token: 0x06012700 RID: 75520 RVA: 0x00070FE0 File Offset: 0x0006F1E0
		[Token(Token = "0x17002888")]
		protected bool enableLoop
		{
			[Token(Token = "0x6012700")]
			[Address(RVA = "0xA6CB30", Offset = "0xA6B730", VA = "0x180A6CB30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012701 RID: 75521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012701")]
		[Address(RVA = "0xA6B660", Offset = "0xA6A260", VA = "0x180A6B660", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012702 RID: 75522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012702")]
		[Address(RVA = "0xA6B730", Offset = "0xA6A330", VA = "0x180A6B730", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012703 RID: 75523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012703")]
		[Address(RVA = "0xA6B6D0", Offset = "0xA6A2D0", VA = "0x180A6B6D0", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012704 RID: 75524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012704")]
		[Address(RVA = "0xA6B600", Offset = "0xA6A200", VA = "0x180A6B600", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012705 RID: 75525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012705")]
		[Address(RVA = "0xA6BA80", Offset = "0xA6A680", VA = "0x180A6BA80", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012706 RID: 75526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012706")]
		[Address(RVA = "0xA6B9D0", Offset = "0xA6A5D0", VA = "0x180A6B9D0", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012707 RID: 75527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012707")]
		[Address(RVA = "0xA6B0F0", Offset = "0xA69CF0", VA = "0x180A6B0F0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012708 RID: 75528 RVA: 0x00070FF8 File Offset: 0x0006F1F8
		[Token(Token = "0x6012708")]
		[Address(RVA = "0xA6AB90", Offset = "0xA69790", VA = "0x180A6AB90", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012709 RID: 75529 RVA: 0x00071010 File Offset: 0x0006F210
		[Token(Token = "0x6012709")]
		[Address(RVA = "0xA6A9A0", Offset = "0xA695A0", VA = "0x180A6A9A0", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x0601270A RID: 75530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601270A")]
		[Address(RVA = "0xA6AEE0", Offset = "0xA69AE0", VA = "0x180A6AEE0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x0601270B RID: 75531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601270B")]
		[Address(RVA = "0xA6B030", Offset = "0xA69C30", VA = "0x180A6B030", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0601270C RID: 75532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601270C")]
		[Address(RVA = "0xA6BB10", Offset = "0xA6A710", VA = "0x180A6BB10", Slot = "58")]
		public override void PreloadSpecialAudioSignals(string abilityId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x0601270D RID: 75533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601270D")]
		[Address(RVA = "0xA6B860", Offset = "0xA6A460", VA = "0x180A6B860", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x0601270E RID: 75534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601270E")]
		[Address(RVA = "0xA6A850", Offset = "0xA69450", VA = "0x180A6A850", Slot = "95")]
		protected override void Awake()
		{
		}

		// Token: 0x0601270F RID: 75535 RVA: 0x00071028 File Offset: 0x0006F228
		[Token(Token = "0x601270F")]
		[Address(RVA = "0xA6AE80", Offset = "0xA69A80", VA = "0x180A6AE80", Slot = "59")]
		public override bool CheckAtPreCastPhase()
		{
			return default(bool);
		}

		// Token: 0x06012710 RID: 75536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012710")]
		[Address(RVA = "0xA6C3D0", Offset = "0xA6AFD0", VA = "0x180A6C3D0")]
		private void _OnSubAbilityFinished(Ability ability, Ability.FinishReason reason, bool resetCd)
		{
		}

		// Token: 0x06012711 RID: 75537 RVA: 0x00071040 File Offset: 0x0006F240
		[Token(Token = "0x6012711")]
		[Address(RVA = "0xA6BF40", Offset = "0xA6AB40", VA = "0x180A6BF40")]
		private bool _LoopValid()
		{
			return default(bool);
		}

		// Token: 0x06012712 RID: 75538 RVA: 0x00071058 File Offset: 0x0006F258
		[Token(Token = "0x6012712")]
		[Address(RVA = "0xA6C120", Offset = "0xA6AD20", VA = "0x180A6C120")]
		private bool _MoveToNextActiveAbility(out Ability ability)
		{
			return default(bool);
		}

		// Token: 0x06012713 RID: 75539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012713")]
		[Address(RVA = "0xA6C2B0", Offset = "0xA6AEB0", VA = "0x180A6C2B0")]
		private void _OnCastStart()
		{
		}

		// Token: 0x06012714 RID: 75540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012714")]
		[Address(RVA = "0xA6BE20", Offset = "0xA6AA20", VA = "0x180A6BE20", Slot = "39")]
		public override void StopAffect()
		{
		}

		// Token: 0x06012715 RID: 75541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012715")]
		[Address(RVA = "0xA6BCF0", Offset = "0xA6A8F0", VA = "0x180A6BCF0", Slot = "37")]
		public override void ResetCooldown(bool waitFirstPeriod)
		{
		}

		// Token: 0x06012716 RID: 75542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012716")]
		[Address(RVA = "0xA6B7C0", Offset = "0xA6A3C0", VA = "0x180A6B7C0", Slot = "56")]
		public override void OnAttackTimeChanged(FP newValue)
		{
		}

		// Token: 0x06012717 RID: 75543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012717")]
		[Address(RVA = "0xA6C780", Offset = "0xA6B380", VA = "0x180A6C780")]
		public AbilitySequenceGroup()
		{
		}

		// Token: 0x06012719 RID: 75545 RVA: 0x00071088 File Offset: 0x0006F288
		[Token(Token = "0x6012719")]
		[Address(RVA = "0xA4D200", Offset = "0xA4BE00", VA = "0x180A4D200")]
		private bool <>xLuaBaseProxy_get_isAffecting()
		{
			return default(bool);
		}

		// Token: 0x0601271A RID: 75546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601271A")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x0601271B RID: 75547 RVA: 0x000710A0 File Offset: 0x0006F2A0
		[Token(Token = "0x601271B")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x0601271C RID: 75548 RVA: 0x000710B8 File Offset: 0x0006F2B8
		[Token(Token = "0x601271C")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0601271D RID: 75549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601271D")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x0601271E RID: 75550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601271E")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0601271F RID: 75551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601271F")]
		[Address(RVA = "0xA66040", Offset = "0xA64C40", VA = "0x180A66040")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x06012720 RID: 75552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012720")]
		[Address(RVA = "0xA66030", Offset = "0xA64C30", VA = "0x180A66030")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012721 RID: 75553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012721")]
		[Address(RVA = "0xA4FF40", Offset = "0xA4EB40", VA = "0x180A4FF40")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x06012722 RID: 75554 RVA: 0x000710D0 File Offset: 0x0006F2D0
		[Token(Token = "0x6012722")]
		[Address(RVA = "0xA67980", Offset = "0xA66580", VA = "0x180A67980")]
		private bool <>xLuaBaseProxy_CheckAtPreCastPhase()
		{
			return default(bool);
		}

		// Token: 0x06012723 RID: 75555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012723")]
		[Address(RVA = "0xA4D1E0", Offset = "0xA4BDE0", VA = "0x180A4D1E0")]
		private void <>xLuaBaseProxy_StopAffect()
		{
		}

		// Token: 0x06012724 RID: 75556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012724")]
		[Address(RVA = "0xA6BF30", Offset = "0xA6AB30", VA = "0x180A6BF30")]
		private void <>xLuaBaseProxy_ResetCooldown(bool P0)
		{
		}

		// Token: 0x06012725 RID: 75557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012725")]
		[Address(RVA = "0xA66020", Offset = "0xA64C20", VA = "0x180A66020")]
		private void <>xLuaBaseProxy_OnAttackTimeChanged(FP P0)
		{
		}

		// Token: 0x04014D5E RID: 85342
		[Token(Token = "0x4014D5E")]
		private const int MAX_CASTING_TIME = 3600;

		// Token: 0x04014D5F RID: 85343
		[Token(Token = "0x4014D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Ability[] _abilities;

		// Token: 0x04014D60 RID: 85344
		[Token(Token = "0x4014D60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private bool _alwaysNext;

		// Token: 0x04014D61 RID: 85345
		[Token(Token = "0x4014D61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		[SerializeField]
		[Inspect("alwaysNext")]
		private bool _forceNextIfCastFail;

		// Token: 0x04014D62 RID: 85346
		[Token(Token = "0x4014D62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
		[SerializeField]
		private bool _checkCanUseSubAbility;

		// Token: 0x04014D63 RID: 85347
		[Token(Token = "0x4014D63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11B")]
		[SerializeField]
		private bool _useLongestAbilityCooldown;

		// Token: 0x04014D64 RID: 85348
		[Token(Token = "0x4014D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private bool _fireCastStartEventWhenCast;

		// Token: 0x04014D65 RID: 85349
		[Token(Token = "0x4014D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
		[SerializeField]
		[Inspect("alwaysNext", false)]
		private bool _stopMoveNextWhenNotCasting;

		// Token: 0x04014D66 RID: 85350
		[Token(Token = "0x4014D66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11E")]
		private bool m_isCastDirectly;

		// Token: 0x04014D67 RID: 85351
		[Token(Token = "0x4014D67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private ObjectPtr<Entity> m_cachedTarget;

		// Token: 0x04014D68 RID: 85352
		[Token(Token = "0x4014D68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector2 m_inputPos;

		// Token: 0x04014D69 RID: 85353
		[Token(Token = "0x4014D69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private bool m_cachedFirstAttack;

		// Token: 0x04014D6A RID: 85354
		[Token(Token = "0x4014D6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Ability.Category m_category;

		// Token: 0x04014D6B RID: 85355
		[Token(Token = "0x4014D6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private FP m_cooldown;

		// Token: 0x04014D6C RID: 85356
		[Token(Token = "0x4014D6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private int m_currentIndex;

		// Token: 0x04014D6D RID: 85357
		[Token(Token = "0x4014D6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private int m_remainingJobCnt;

		// Token: 0x04014D6E RID: 85358
		[Token(Token = "0x4014D6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private bool _alsoInterruptCurrentSubAbility;

		// Token: 0x04014D6F RID: 85359
		[Token(Token = "0x4014D6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Inspect("alsoInterruptCurrentSubAbility")]
		private List<int> _interruptableSubAbilityIndice;

		// Token: 0x04014D70 RID: 85360
		[Token(Token = "0x4014D70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private bool _alsoStopSubAbilityAffect;

		// Token: 0x04014D71 RID: 85361
		[Token(Token = "0x4014D71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
		[SerializeField]
		private bool _alsoResetSubAbilityCooldown;

		// Token: 0x04014D72 RID: 85362
		[Token(Token = "0x4014D72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x162")]
		[SerializeField]
		private bool _setDataExceptRedundance;

		// Token: 0x04014D73 RID: 85363
		[Token(Token = "0x4014D73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x163")]
		[SerializeField]
		private bool _interruptIfTargetDead;

		// Token: 0x04014D74 RID: 85364
		[Token(Token = "0x4014D74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		[SerializeField]
		private bool _castToInputPosIfTargetInvalid;

		// Token: 0x04014D75 RID: 85365
		[Token(Token = "0x4014D75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private AbstractAnimatedAbility.TimeMode _timeMode;

		// Token: 0x04014D76 RID: 85366
		[Token(Token = "0x4014D76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		[SerializeField]
		private bool _enableLoop;

		// Token: 0x04014D77 RID: 85367
		[Token(Token = "0x4014D77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Inspect("enableLoop")]
		private AbilitySequenceGroup.AbilityLoopGroup[] _abilityLoopSettings;

		// Token: 0x04014D78 RID: 85368
		[Token(Token = "0x4014D78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_alwaysNext;

		// Token: 0x04014D79 RID: 85369
		[Token(Token = "0x4014D79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014D7A RID: 85370
		[Token(Token = "0x4014D7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014D7B RID: 85371
		[Token(Token = "0x4014D7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014D7C RID: 85372
		[Token(Token = "0x4014D7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x04014D7D RID: 85373
		[Token(Token = "0x4014D7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014D7E RID: 85374
		[Token(Token = "0x4014D7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_alsoInterruptCurrentSubAbility;

		// Token: 0x04014D7F RID: 85375
		[Token(Token = "0x4014D7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_enableLoop;

		// Token: 0x04014D80 RID: 85376
		[Token(Token = "0x4014D80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014D81 RID: 85377
		[Token(Token = "0x4014D81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014D82 RID: 85378
		[Token(Token = "0x4014D82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014D83 RID: 85379
		[Token(Token = "0x4014D83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014D84 RID: 85380
		[Token(Token = "0x4014D84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014D85 RID: 85381
		[Token(Token = "0x4014D85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014D86 RID: 85382
		[Token(Token = "0x4014D86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014D87 RID: 85383
		[Token(Token = "0x4014D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x04014D88 RID: 85384
		[Token(Token = "0x4014D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x04014D89 RID: 85385
		[Token(Token = "0x4014D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014D8A RID: 85386
		[Token(Token = "0x4014D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014D8B RID: 85387
		[Token(Token = "0x4014D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x04014D8C RID: 85388
		[Token(Token = "0x4014D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014D8D RID: 85389
		[Token(Token = "0x4014D8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04014D8E RID: 85390
		[Token(Token = "0x4014D8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CheckAtPreCastPhase;

		// Token: 0x04014D8F RID: 85391
		[Token(Token = "0x4014D8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnSubAbilityFinished;

		// Token: 0x04014D90 RID: 85392
		[Token(Token = "0x4014D90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__LoopValid;

		// Token: 0x04014D91 RID: 85393
		[Token(Token = "0x4014D91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__MoveToNextActiveAbility;

		// Token: 0x04014D92 RID: 85394
		[Token(Token = "0x4014D92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnCastStart;

		// Token: 0x04014D93 RID: 85395
		[Token(Token = "0x4014D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_StopAffect;

		// Token: 0x04014D94 RID: 85396
		[Token(Token = "0x4014D94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ResetCooldown;

		// Token: 0x04014D95 RID: 85397
		[Token(Token = "0x4014D95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

		// Token: 0x04014D96 RID: 85398
		[Token(Token = "0x4014D96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B0C RID: 11020
		[Token(Token = "0x2002B0C")]
		[Serializable]
		public class AbilityLoopGroup
		{
			// Token: 0x06012726 RID: 75558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012726")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AbilityLoopGroup()
			{
			}

			// Token: 0x04014D97 RID: 85399
			[Token(Token = "0x4014D97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int loopIndex;

			// Token: 0x04014D98 RID: 85400
			[Token(Token = "0x4014D98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TargetValidator validator;
		}
	}
}
