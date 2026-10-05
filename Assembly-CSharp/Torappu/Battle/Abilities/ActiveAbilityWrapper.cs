using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B11 RID: 11025
	[Token(Token = "0x2002B11")]
	public class ActiveAbilityWrapper : EasyToStartAbility
	{
		// Token: 0x1700289E RID: 10398
		// (get) Token: 0x06012760 RID: 75616 RVA: 0x000713A0 File Offset: 0x0006F5A0
		[Token(Token = "0x1700289E")]
		public override FP cooldown
		{
			[Token(Token = "0x6012760")]
			[Address(RVA = "0xA6F7A0", Offset = "0xA6E3A0", VA = "0x180A6F7A0", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700289F RID: 10399
		// (get) Token: 0x06012761 RID: 75617 RVA: 0x000713B8 File Offset: 0x0006F5B8
		[Token(Token = "0x1700289F")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012761")]
			[Address(RVA = "0xA6F740", Offset = "0xA6E340", VA = "0x180A6F740", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x170028A0 RID: 10400
		// (get) Token: 0x06012762 RID: 75618 RVA: 0x000713D0 File Offset: 0x0006F5D0
		[Token(Token = "0x170028A0")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012762")]
			[Address(RVA = "0xA6FA40", Offset = "0xA6E640", VA = "0x180A6FA40", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x06012763 RID: 75619 RVA: 0x000713E8 File Offset: 0x0006F5E8
		[Token(Token = "0x170028A1")]
		public override bool isAffecting
		{
			[Token(Token = "0x6012763")]
			[Address(RVA = "0xA6F800", Offset = "0xA6E400", VA = "0x180A6F800", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170028A2 RID: 10402
		// (get) Token: 0x06012764 RID: 75620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170028A2")]
		public override IDrawableRange rangeToShow
		{
			[Token(Token = "0x6012764")]
			[Address(RVA = "0xA6F940", Offset = "0xA6E540", VA = "0x180A6F940", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170028A3 RID: 10403
		// (get) Token: 0x06012765 RID: 75621 RVA: 0x00071400 File Offset: 0x0006F600
		[Token(Token = "0x170028A3")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012765")]
			[Address(RVA = "0xA6F6E0", Offset = "0xA6E2E0", VA = "0x180A6F6E0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170028A4 RID: 10404
		// (get) Token: 0x06012766 RID: 75622 RVA: 0x00071418 File Offset: 0x0006F618
		[Token(Token = "0x170028A4")]
		public override bool allowNoTarget
		{
			[Token(Token = "0x6012766")]
			[Address(RVA = "0xA6F680", Offset = "0xA6E280", VA = "0x180A6F680", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170028A5 RID: 10405
		// (get) Token: 0x06012767 RID: 75623 RVA: 0x00071430 File Offset: 0x0006F630
		[Token(Token = "0x170028A5")]
		public override FP preDelay
		{
			[Token(Token = "0x6012767")]
			[Address(RVA = "0xA6F8B0", Offset = "0xA6E4B0", VA = "0x180A6F8B0", Slot = "96")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x06012768 RID: 75624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012768")]
		[Address(RVA = "0xA6F1F0", Offset = "0xA6DDF0", VA = "0x180A6F1F0", Slot = "39")]
		public override void StopAffect()
		{
		}

		// Token: 0x06012769 RID: 75625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012769")]
		[Address(RVA = "0xA6EE00", Offset = "0xA6DA00", VA = "0x180A6EE00", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x0601276A RID: 75626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601276A")]
		[Address(RVA = "0xA6EED0", Offset = "0xA6DAD0", VA = "0x180A6EED0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x0601276B RID: 75627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601276B")]
		[Address(RVA = "0xA6F380", Offset = "0xA6DF80", VA = "0x180A6F380", Slot = "38")]
		public override void UpdateCooldown(FP newPeriod, bool waitFirstPeriod, bool keepPassedTime = false)
		{
		}

		// Token: 0x0601276C RID: 75628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601276C")]
		[Address(RVA = "0xA6EE70", Offset = "0xA6DA70", VA = "0x180A6EE70", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x0601276D RID: 75629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601276D")]
		[Address(RVA = "0xA6ED20", Offset = "0xA6D920", VA = "0x180A6ED20", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x0601276E RID: 75630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601276E")]
		[Address(RVA = "0xA6EBD0", Offset = "0xA6D7D0", VA = "0x180A6EBD0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601276F RID: 75631 RVA: 0x00071448 File Offset: 0x0006F648
		[Token(Token = "0x601276F")]
		[Address(RVA = "0xA6ED80", Offset = "0xA6D980", VA = "0x180A6ED80", Slot = "98")]
		protected override FP GetDuration()
		{
			return default(FP);
		}

		// Token: 0x06012770 RID: 75632 RVA: 0x00071460 File Offset: 0x0006F660
		[Token(Token = "0x6012770")]
		[Address(RVA = "0xA6F040", Offset = "0xA6DC40", VA = "0x180A6F040", Slot = "78")]
		protected override bool OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x06012771 RID: 75633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012771")]
		[Address(RVA = "0xA6EF60", Offset = "0xA6DB60", VA = "0x180A6EF60", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012772 RID: 75634 RVA: 0x00071478 File Offset: 0x0006F678
		[Token(Token = "0x6012772")]
		[Address(RVA = "0xA6F470", Offset = "0xA6E070", VA = "0x180A6F470")]
		private FP _GetLifeTime()
		{
			return default(FP);
		}

		// Token: 0x06012773 RID: 75635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012773")]
		[Address(RVA = "0xA6F5F0", Offset = "0xA6E1F0", VA = "0x180A6F5F0")]
		public ActiveAbilityWrapper()
		{
		}

		// Token: 0x06012774 RID: 75636 RVA: 0x00071490 File Offset: 0x0006F690
		[Token(Token = "0x6012774")]
		[Address(RVA = "0xA4D200", Offset = "0xA4BE00", VA = "0x180A4D200")]
		private bool <>xLuaBaseProxy_get_isAffecting()
		{
			return default(bool);
		}

		// Token: 0x06012775 RID: 75637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012775")]
		[Address(RVA = "0xA6F370", Offset = "0xA6DF70", VA = "0x180A6F370")]
		private IDrawableRange <>xLuaBaseProxy_get_rangeToShow()
		{
			return null;
		}

		// Token: 0x06012776 RID: 75638 RVA: 0x000714A8 File Offset: 0x0006F6A8
		[Token(Token = "0x6012776")]
		[Address(RVA = "0xA23D10", Offset = "0xA22910", VA = "0x180A23D10")]
		private bool <>xLuaBaseProxy_get_allowNoTarget()
		{
			return default(bool);
		}

		// Token: 0x06012777 RID: 75639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012777")]
		[Address(RVA = "0xA4D1E0", Offset = "0xA4BDE0", VA = "0x180A4D1E0")]
		private void <>xLuaBaseProxy_StopAffect()
		{
		}

		// Token: 0x06012778 RID: 75640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012778")]
		[Address(RVA = "0xA1FD70", Offset = "0xA1E970", VA = "0x180A1FD70")]
		private void <>xLuaBaseProxy_UpdateCooldown(FP P0, bool P1, bool P2)
		{
		}

		// Token: 0x06012779 RID: 75641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012779")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x0601277A RID: 75642 RVA: 0x000714C0 File Offset: 0x0006F6C0
		[Token(Token = "0x601277A")]
		[Address(RVA = "0xA1EDF0", Offset = "0xA1D9F0", VA = "0x180A1EDF0")]
		private bool <>xLuaBaseProxy_OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x0601277B RID: 75643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601277B")]
		[Address(RVA = "0xA6E010", Offset = "0xA6CC10", VA = "0x180A6E010")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x04014DE4 RID: 85476
		[Token(Token = "0x4014DE4")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Ability[] _wrappedAbilities;

		// Token: 0x04014DE5 RID: 85477
		[Token(Token = "0x4014DE5")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private bool _isInfinity;

		// Token: 0x04014DE6 RID: 85478
		[Token(Token = "0x4014DE6")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private string _durationKey;

		// Token: 0x04014DE7 RID: 85479
		[Token(Token = "0x4014DE7")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Inspect("waitForAttackEvent", false)]
		private float _preDelay;

		// Token: 0x04014DE8 RID: 85480
		[Token(Token = "0x4014DE8")]
		[FieldOffset(Offset = "0x14C")]
		[SerializeField]
		private bool _enableUpdateCooldown;

		// Token: 0x04014DE9 RID: 85481
		[Token(Token = "0x4014DE9")]
		[FieldOffset(Offset = "0x150")]
		private FP m_lifeTime;

		// Token: 0x04014DEA RID: 85482
		[Token(Token = "0x4014DEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014DEB RID: 85483
		[Token(Token = "0x4014DEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014DEC RID: 85484
		[Token(Token = "0x4014DEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014DED RID: 85485
		[Token(Token = "0x4014DED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x04014DEE RID: 85486
		[Token(Token = "0x4014DEE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rangeToShow;

		// Token: 0x04014DEF RID: 85487
		[Token(Token = "0x4014DEF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014DF0 RID: 85488
		[Token(Token = "0x4014DF0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_allowNoTarget;

		// Token: 0x04014DF1 RID: 85489
		[Token(Token = "0x4014DF1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_preDelay;

		// Token: 0x04014DF2 RID: 85490
		[Token(Token = "0x4014DF2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_StopAffect;

		// Token: 0x04014DF3 RID: 85491
		[Token(Token = "0x4014DF3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014DF4 RID: 85492
		[Token(Token = "0x4014DF4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014DF5 RID: 85493
		[Token(Token = "0x4014DF5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateCooldown;

		// Token: 0x04014DF6 RID: 85494
		[Token(Token = "0x4014DF6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014DF7 RID: 85495
		[Token(Token = "0x4014DF7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014DF8 RID: 85496
		[Token(Token = "0x4014DF8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014DF9 RID: 85497
		[Token(Token = "0x4014DF9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetDuration;

		// Token: 0x04014DFA RID: 85498
		[Token(Token = "0x4014DFA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnSpellStart;

		// Token: 0x04014DFB RID: 85499
		[Token(Token = "0x4014DFB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014DFC RID: 85500
		[Token(Token = "0x4014DFC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetLifeTime;

		// Token: 0x04014DFD RID: 85501
		[Token(Token = "0x4014DFD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
