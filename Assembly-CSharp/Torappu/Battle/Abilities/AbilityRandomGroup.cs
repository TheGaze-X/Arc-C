using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B06 RID: 11014
	[Token(Token = "0x2002B06")]
	public class AbilityRandomGroup : AbilityStandard
	{
		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x060126C1 RID: 75457 RVA: 0x00070DB8 File Offset: 0x0006EFB8
		[Token(Token = "0x17002875")]
		public bool isConfigurableProb
		{
			[Token(Token = "0x60126C1")]
			[Address(RVA = "0xA6A6C0", Offset = "0xA692C0", VA = "0x180A6A6C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x060126C2 RID: 75458 RVA: 0x00070DD0 File Offset: 0x0006EFD0
		[Token(Token = "0x17002876")]
		public override Ability.Category category
		{
			[Token(Token = "0x60126C2")]
			[Address(RVA = "0xA6A550", Offset = "0xA69150", VA = "0x180A6A550", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x060126C3 RID: 75459 RVA: 0x00070DE8 File Offset: 0x0006EFE8
		[Token(Token = "0x17002877")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x60126C3")]
			[Address(RVA = "0xA6A7F0", Offset = "0xA693F0", VA = "0x180A6A7F0", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x060126C4 RID: 75460 RVA: 0x00070E00 File Offset: 0x0006F000
		[Token(Token = "0x17002878")]
		protected bool isRandom
		{
			[Token(Token = "0x60126C4")]
			[Address(RVA = "0xA6A720", Offset = "0xA69320", VA = "0x180A6A720")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x060126C5 RID: 75461 RVA: 0x00070E18 File Offset: 0x0006F018
		[Token(Token = "0x17002879")]
		public override FP cooldown
		{
			[Token(Token = "0x60126C5")]
			[Address(RVA = "0xA6A5B0", Offset = "0xA691B0", VA = "0x180A6A5B0", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x060126C6 RID: 75462 RVA: 0x00070E30 File Offset: 0x0006F030
		[Token(Token = "0x1700287A")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x60126C6")]
			[Address(RVA = "0xA6A4F0", Offset = "0xA690F0", VA = "0x180A6A4F0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x060126C7 RID: 75463 RVA: 0x00070E48 File Offset: 0x0006F048
		[Token(Token = "0x1700287B")]
		public bool needUpdateAttackTime
		{
			[Token(Token = "0x60126C7")]
			[Address(RVA = "0xA6A780", Offset = "0xA69380", VA = "0x180A6A780")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060126C8 RID: 75464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60126C8")]
		[Address(RVA = "0xA68AC0", Offset = "0xA676C0", VA = "0x180A68AC0", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x060126C9 RID: 75465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60126C9")]
		[Address(RVA = "0xA68BF0", Offset = "0xA677F0", VA = "0x180A68BF0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x060126CA RID: 75466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60126CA")]
		[Address(RVA = "0xA68B20", Offset = "0xA67720", VA = "0x180A68B20", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x060126CB RID: 75467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60126CB")]
		[Address(RVA = "0xA68B90", Offset = "0xA67790", VA = "0x180A68B90", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x060126CC RID: 75468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126CC")]
		[Address(RVA = "0xA69320", Offset = "0xA67F20", VA = "0x180A69320", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x060126CD RID: 75469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126CD")]
		[Address(RVA = "0xA68600", Offset = "0xA67200", VA = "0x180A68600", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060126CE RID: 75470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126CE")]
		[Address(RVA = "0xA694C0", Offset = "0xA680C0", VA = "0x180A694C0", Slot = "27")]
		public override void UpdateBlackboard(Blackboard extraBlackboard)
		{
		}

		// Token: 0x060126CF RID: 75471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60126CF")]
		[Address(RVA = "0xA6A050", Offset = "0xA68C50", VA = "0x180A6A050")]
		private Ability _SelectAllAbilitiesAtLeastOnce()
		{
			return null;
		}

		// Token: 0x060126D0 RID: 75472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60126D0")]
		[Address(RVA = "0xA69A70", Offset = "0xA68670", VA = "0x180A69A70")]
		private Ability _SelectAbilityDifferentFromLastOne()
		{
			return null;
		}

		// Token: 0x060126D1 RID: 75473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60126D1")]
		[Address(RVA = "0xA69EE0", Offset = "0xA68AE0", VA = "0x180A69EE0")]
		private Ability _SelectAbilityForRandom()
		{
			return null;
		}

		// Token: 0x060126D2 RID: 75474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60126D2")]
		[Address(RVA = "0xA69D90", Offset = "0xA68990", VA = "0x180A69D90")]
		private Ability _SelectAbilityForRandomWithConfigurableProb()
		{
			return null;
		}

		// Token: 0x060126D3 RID: 75475 RVA: 0x00070E60 File Offset: 0x0006F060
		[Token(Token = "0x60126D3")]
		[Address(RVA = "0xA68220", Offset = "0xA66E20", VA = "0x180A68220", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x060126D4 RID: 75476 RVA: 0x00070E78 File Offset: 0x0006F078
		[Token(Token = "0x60126D4")]
		[Address(RVA = "0xA68050", Offset = "0xA66C50", VA = "0x180A68050", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x060126D5 RID: 75477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60126D5")]
		[Address(RVA = "0xA695D0", Offset = "0xA681D0", VA = "0x180A695D0")]
		private Ability _GetAbilityInternal()
		{
			return null;
		}

		// Token: 0x060126D6 RID: 75478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126D6")]
		[Address(RVA = "0xA683F0", Offset = "0xA66FF0", VA = "0x180A683F0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x060126D7 RID: 75479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126D7")]
		[Address(RVA = "0xA68540", Offset = "0xA67140", VA = "0x180A68540", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x060126D8 RID: 75480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60126D8")]
		[Address(RVA = "0xA690B0", Offset = "0xA67CB0", VA = "0x180A690B0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x060126D9 RID: 75481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60126D9")]
		[Address(RVA = "0xA69020", Offset = "0xA67C20", VA = "0x180A69020", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x060126DA RID: 75482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126DA")]
		[Address(RVA = "0xA68E80", Offset = "0xA67A80", VA = "0x180A68E80", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x060126DB RID: 75483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126DB")]
		[Address(RVA = "0xA68DA0", Offset = "0xA679A0", VA = "0x180A68DA0", Slot = "56")]
		public override void OnAttackTimeChanged(FP newValue)
		{
		}

		// Token: 0x060126DC RID: 75484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126DC")]
		[Address(RVA = "0xA699B0", Offset = "0xA685B0", VA = "0x180A699B0")]
		private void _OnSubAbilityFinished(Ability ability, Ability.FinishReason reason, bool resetCd)
		{
		}

		// Token: 0x060126DD RID: 75485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126DD")]
		[Address(RVA = "0xA69140", Offset = "0xA67D40", VA = "0x180A69140", Slot = "58")]
		public override void PreloadSpecialAudioSignals(string abilityId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x060126DE RID: 75486 RVA: 0x00070E90 File Offset: 0x0006F090
		[Token(Token = "0x60126DE")]
		[Address(RVA = "0xA68C80", Offset = "0xA67880", VA = "0x180A68C80", Slot = "35")]
		public override bool InterruptIfNot()
		{
			return default(bool);
		}

		// Token: 0x060126DF RID: 75487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126DF")]
		[Address(RVA = "0xA6A320", Offset = "0xA68F20", VA = "0x180A6A320")]
		public AbilityRandomGroup()
		{
		}

		// Token: 0x060126E0 RID: 75488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126E0")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x060126E1 RID: 75489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126E1")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060126E2 RID: 75490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126E2")]
		[Address(RVA = "0xA694B0", Offset = "0xA680B0", VA = "0x180A694B0")]
		private void <>xLuaBaseProxy_UpdateBlackboard(Blackboard P0)
		{
		}

		// Token: 0x060126E3 RID: 75491 RVA: 0x00070EA8 File Offset: 0x0006F0A8
		[Token(Token = "0x60126E3")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x060126E4 RID: 75492 RVA: 0x00070EC0 File Offset: 0x0006F0C0
		[Token(Token = "0x60126E4")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x060126E5 RID: 75493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126E5")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x060126E6 RID: 75494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126E6")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x060126E7 RID: 75495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126E7")]
		[Address(RVA = "0xA66030", Offset = "0xA64C30", VA = "0x180A66030")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x060126E8 RID: 75496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126E8")]
		[Address(RVA = "0xA66020", Offset = "0xA64C20", VA = "0x180A66020")]
		private void <>xLuaBaseProxy_OnAttackTimeChanged(FP P0)
		{
		}

		// Token: 0x060126E9 RID: 75497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60126E9")]
		[Address(RVA = "0xA66040", Offset = "0xA64C40", VA = "0x180A66040")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x060126EA RID: 75498 RVA: 0x00070ED8 File Offset: 0x0006F0D8
		[Token(Token = "0x60126EA")]
		[Address(RVA = "0xA694A0", Offset = "0xA680A0", VA = "0x180A694A0")]
		private bool <>xLuaBaseProxy_InterruptIfNot()
		{
			return default(bool);
		}

		// Token: 0x04014D24 RID: 85284
		[Token(Token = "0x4014D24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Ability.Category _category;

		// Token: 0x04014D25 RID: 85285
		[Token(Token = "0x4014D25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		private int _coolDownAbilityIndex;

		// Token: 0x04014D26 RID: 85286
		[Token(Token = "0x4014D26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private bool _clearInternalCooldownWhenFinish;

		// Token: 0x04014D27 RID: 85287
		[Token(Token = "0x4014D27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private AbilityRandomGroup.SelectMethod _selectMethod;

		// Token: 0x04014D28 RID: 85288
		[Token(Token = "0x4014D28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private bool _alsoInterruptCurrentSubAbility;

		// Token: 0x04014D29 RID: 85289
		[Token(Token = "0x4014D29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Ability[] _abilities;

		// Token: 0x04014D2A RID: 85290
		[Token(Token = "0x4014D2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private AbstractAnimatedAbility.TimeMode _timeMode;

		// Token: 0x04014D2B RID: 85291
		[Token(Token = "0x4014D2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		private bool _isConfigurableProb;

		// Token: 0x04014D2C RID: 85292
		[Token(Token = "0x4014D2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Inspect("isConfigurableProb")]
		private List<string> _probKeyList;

		// Token: 0x04014D2D RID: 85293
		[Token(Token = "0x4014D2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Inspect("isRandom", true)]
		private bool _diffFromLastOneIfNotFirst;

		// Token: 0x04014D2E RID: 85294
		[Token(Token = "0x4014D2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		[SerializeField]
		[Inspect("isRandom", true)]
		private bool _selectAllAtLeastOnce;

		// Token: 0x04014D2F RID: 85295
		[Token(Token = "0x4014D2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private ObjectPtr<Ability> m_lastCastAbilitySinceFirstAttack;

		// Token: 0x04014D30 RID: 85296
		[Token(Token = "0x4014D30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private List<Ability> m_abilityGroupThisTime;

		// Token: 0x04014D31 RID: 85297
		[Token(Token = "0x4014D31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private List<Ability> m_remainingAbilities;

		// Token: 0x04014D32 RID: 85298
		[Token(Token = "0x4014D32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int m_loopIndex;

		// Token: 0x04014D33 RID: 85299
		[Token(Token = "0x4014D33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int m_randomRangeNum;

		// Token: 0x04014D34 RID: 85300
		[Token(Token = "0x4014D34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private List<AbilityRandomGroup.AbilityWithWeight> m_probList;

		// Token: 0x04014D35 RID: 85301
		[Token(Token = "0x4014D35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private FP m_cooldown;

		// Token: 0x04014D36 RID: 85302
		[Token(Token = "0x4014D36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isConfigurableProb;

		// Token: 0x04014D37 RID: 85303
		[Token(Token = "0x4014D37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014D38 RID: 85304
		[Token(Token = "0x4014D38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014D39 RID: 85305
		[Token(Token = "0x4014D39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isRandom;

		// Token: 0x04014D3A RID: 85306
		[Token(Token = "0x4014D3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014D3B RID: 85307
		[Token(Token = "0x4014D3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014D3C RID: 85308
		[Token(Token = "0x4014D3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_needUpdateAttackTime;

		// Token: 0x04014D3D RID: 85309
		[Token(Token = "0x4014D3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014D3E RID: 85310
		[Token(Token = "0x4014D3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014D3F RID: 85311
		[Token(Token = "0x4014D3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014D40 RID: 85312
		[Token(Token = "0x4014D40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014D41 RID: 85313
		[Token(Token = "0x4014D41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014D42 RID: 85314
		[Token(Token = "0x4014D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014D43 RID: 85315
		[Token(Token = "0x4014D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateBlackboard;

		// Token: 0x04014D44 RID: 85316
		[Token(Token = "0x4014D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SelectAllAbilitiesAtLeastOnce;

		// Token: 0x04014D45 RID: 85317
		[Token(Token = "0x4014D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SelectAbilityDifferentFromLastOne;

		// Token: 0x04014D46 RID: 85318
		[Token(Token = "0x4014D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SelectAbilityForRandom;

		// Token: 0x04014D47 RID: 85319
		[Token(Token = "0x4014D47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SelectAbilityForRandomWithConfigurableProb;

		// Token: 0x04014D48 RID: 85320
		[Token(Token = "0x4014D48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x04014D49 RID: 85321
		[Token(Token = "0x4014D49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x04014D4A RID: 85322
		[Token(Token = "0x4014D4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetAbilityInternal;

		// Token: 0x04014D4B RID: 85323
		[Token(Token = "0x4014D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014D4C RID: 85324
		[Token(Token = "0x4014D4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014D4D RID: 85325
		[Token(Token = "0x4014D4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014D4E RID: 85326
		[Token(Token = "0x4014D4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014D4F RID: 85327
		[Token(Token = "0x4014D4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014D50 RID: 85328
		[Token(Token = "0x4014D50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

		// Token: 0x04014D51 RID: 85329
		[Token(Token = "0x4014D51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnSubAbilityFinished;

		// Token: 0x04014D52 RID: 85330
		[Token(Token = "0x4014D52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x04014D53 RID: 85331
		[Token(Token = "0x4014D53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_InterruptIfNot;

		// Token: 0x04014D54 RID: 85332
		[Token(Token = "0x4014D54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B07 RID: 11015
		[Token(Token = "0x2002B07")]
		public enum SelectMethod
		{
			// Token: 0x04014D56 RID: 85334
			[Token(Token = "0x4014D56")]
			Random,
			// Token: 0x04014D57 RID: 85335
			[Token(Token = "0x4014D57")]
			Loop
		}

		// Token: 0x02002B08 RID: 11016
		[Token(Token = "0x2002B08")]
		private struct AbilityWithWeight : IItemWithWeight
		{
			// Token: 0x1700287C RID: 10364
			// (get) Token: 0x060126EB RID: 75499 RVA: 0x00070EF0 File Offset: 0x0006F0F0
			// (set) Token: 0x060126EC RID: 75500 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700287C")]
			public float weightValue
			{
				[Token(Token = "0x60126EB")]
				[Address(RVA = "0x5DE4D0", Offset = "0x5DD0D0", VA = "0x1805DE4D0", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return 0f;
				}
				[Token(Token = "0x60126EC")]
				[Address(RVA = "0x5DE4E0", Offset = "0x5DD0E0", VA = "0x1805DE4E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x04014D58 RID: 85336
			[Token(Token = "0x4014D58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Ability ability;
		}
	}
}
