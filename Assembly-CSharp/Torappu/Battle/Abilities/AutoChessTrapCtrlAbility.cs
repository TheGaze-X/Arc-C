using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B7F RID: 11135
	[Token(Token = "0x2002B7F")]
	public class AutoChessTrapCtrlAbility : AbilityStandard
	{
		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x06012B7A RID: 76666 RVA: 0x00072AC8 File Offset: 0x00070CC8
		[Token(Token = "0x17002934")]
		public override FP cooldown
		{
			[Token(Token = "0x6012B7A")]
			[Address(RVA = "0xAADE80", Offset = "0xAACA80", VA = "0x180AADE80", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x06012B7B RID: 76667 RVA: 0x00072AE0 File Offset: 0x00070CE0
		[Token(Token = "0x17002935")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012B7B")]
			[Address(RVA = "0xAADE20", Offset = "0xAACA20", VA = "0x180AADE20", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x06012B7C RID: 76668 RVA: 0x00072AF8 File Offset: 0x00070CF8
		[Token(Token = "0x17002936")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012B7C")]
			[Address(RVA = "0xAADF00", Offset = "0xAACB00", VA = "0x180AADF00", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x06012B7D RID: 76669 RVA: 0x00072B10 File Offset: 0x00070D10
		[Token(Token = "0x17002937")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012B7D")]
			[Address(RVA = "0xAADDC0", Offset = "0xAAC9C0", VA = "0x180AADDC0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012B7E RID: 76670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012B7E")]
		[Address(RVA = "0xAACE90", Offset = "0xAABA90", VA = "0x180AACE90", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012B7F RID: 76671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012B7F")]
		[Address(RVA = "0xAAD080", Offset = "0xAABC80", VA = "0x180AAD080", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012B80 RID: 76672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012B80")]
		[Address(RVA = "0xAACFF0", Offset = "0xAABBF0", VA = "0x180AACFF0", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012B81 RID: 76673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012B81")]
		[Address(RVA = "0xAACF00", Offset = "0xAABB00", VA = "0x180AACF00", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012B82 RID: 76674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012B82")]
		[Address(RVA = "0xAACE30", Offset = "0xAABA30", VA = "0x180AACE30", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012B83 RID: 76675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012B83")]
		[Address(RVA = "0xAACF60", Offset = "0xAABB60", VA = "0x180AACF60", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012B84 RID: 76676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B84")]
		[Address(RVA = "0xAAD270", Offset = "0xAABE70", VA = "0x180AAD270", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012B85 RID: 76677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B85")]
		[Address(RVA = "0xAACC80", Offset = "0xAAB880", VA = "0x180AACC80", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012B86 RID: 76678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B86")]
		[Address(RVA = "0xAACD40", Offset = "0xAAB940", VA = "0x180AACD40", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012B87 RID: 76679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B87")]
		[Address(RVA = "0xAAD5E0", Offset = "0xAAC1E0", VA = "0x180AAD5E0")]
		private void _OnAutoChessExitShop(object arg)
		{
		}

		// Token: 0x06012B88 RID: 76680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B88")]
		[Address(RVA = "0xAAD690", Offset = "0xAAC290", VA = "0x180AAD690")]
		private void _OnAutoChessRoundFinished(object arg)
		{
		}

		// Token: 0x06012B89 RID: 76681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B89")]
		[Address(RVA = "0xAAD740", Offset = "0xAAC340", VA = "0x180AAD740")]
		private void _OnPlaneAnim(object arg)
		{
		}

		// Token: 0x06012B8A RID: 76682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B8A")]
		[Address(RVA = "0xAAD380", Offset = "0xAABF80", VA = "0x180AAD380")]
		protected void _DoPlayAnim(string startAnim, string idleAnim)
		{
		}

		// Token: 0x06012B8B RID: 76683 RVA: 0x00072B28 File Offset: 0x00070D28
		[Token(Token = "0x6012B8B")]
		[Address(RVA = "0xAAD7F0", Offset = "0xAAC3F0", VA = "0x180AAD7F0")]
		private bool _PlayAnimationInternal(string animName)
		{
			return default(bool);
		}

		// Token: 0x06012B8C RID: 76684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B8C")]
		[Address(RVA = "0xAAD8F0", Offset = "0xAAC4F0", VA = "0x180AAD8F0")]
		private void _PlaySignal(string animName)
		{
		}

		// Token: 0x06012B8D RID: 76685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B8D")]
		[Address(RVA = "0xAAD110", Offset = "0xAABD10", VA = "0x180AAD110", Slot = "58")]
		public override void PreloadSpecialAudioSignals(string abilityId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x06012B8E RID: 76686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B8E")]
		[Address(RVA = "0xAADB10", Offset = "0xAAC710", VA = "0x180AADB10")]
		private void _PreloadSignal(Action<string, string> preloader, string anim)
		{
		}

		// Token: 0x06012B8F RID: 76687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B8F")]
		[Address(RVA = "0xAADC50", Offset = "0xAAC850", VA = "0x180AADC50")]
		public AutoChessTrapCtrlAbility()
		{
		}

		// Token: 0x06012B90 RID: 76688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B90")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012B91 RID: 76689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B91")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012B92 RID: 76690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B92")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012B93 RID: 76691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012B93")]
		[Address(RVA = "0xA66040", Offset = "0xA64C40", VA = "0x180A66040")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x04015273 RID: 86643
		[Token(Token = "0x4015273")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private string _roundStartIdleAnim;

		// Token: 0x04015274 RID: 86644
		[Token(Token = "0x4015274")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private string _roundStartAnim;

		// Token: 0x04015275 RID: 86645
		[Token(Token = "0x4015275")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private string _roundEndIdleAnim;

		// Token: 0x04015276 RID: 86646
		[Token(Token = "0x4015276")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private string _roundEndAnim;

		// Token: 0x04015277 RID: 86647
		[Token(Token = "0x4015277")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private string _initShopStateAnim;

		// Token: 0x04015278 RID: 86648
		[Token(Token = "0x4015278")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private string _initBattleStateAnim;

		// Token: 0x04015279 RID: 86649
		[Token(Token = "0x4015279")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private string _planeAnim;

		// Token: 0x0401527A RID: 86650
		[Token(Token = "0x401527A")]
		[FieldOffset(Offset = "0x148")]
		private CoroutineId m_coroutine;

		// Token: 0x0401527B RID: 86651
		[Token(Token = "0x401527B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x0401527C RID: 86652
		[Token(Token = "0x401527C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x0401527D RID: 86653
		[Token(Token = "0x401527D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x0401527E RID: 86654
		[Token(Token = "0x401527E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x0401527F RID: 86655
		[Token(Token = "0x401527F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04015280 RID: 86656
		[Token(Token = "0x4015280")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04015281 RID: 86657
		[Token(Token = "0x4015281")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04015282 RID: 86658
		[Token(Token = "0x4015282")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04015283 RID: 86659
		[Token(Token = "0x4015283")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04015284 RID: 86660
		[Token(Token = "0x4015284")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04015285 RID: 86661
		[Token(Token = "0x4015285")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04015286 RID: 86662
		[Token(Token = "0x4015286")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04015287 RID: 86663
		[Token(Token = "0x4015287")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04015288 RID: 86664
		[Token(Token = "0x4015288")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnAutoChessExitShop;

		// Token: 0x04015289 RID: 86665
		[Token(Token = "0x4015289")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnAutoChessRoundFinished;

		// Token: 0x0401528A RID: 86666
		[Token(Token = "0x401528A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnPlaneAnim;

		// Token: 0x0401528B RID: 86667
		[Token(Token = "0x401528B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DoPlayAnim;

		// Token: 0x0401528C RID: 86668
		[Token(Token = "0x401528C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__PlayAnimationInternal;

		// Token: 0x0401528D RID: 86669
		[Token(Token = "0x401528D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PlaySignal;

		// Token: 0x0401528E RID: 86670
		[Token(Token = "0x401528E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x0401528F RID: 86671
		[Token(Token = "0x401528F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__PreloadSignal;

		// Token: 0x04015290 RID: 86672
		[Token(Token = "0x4015290")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
