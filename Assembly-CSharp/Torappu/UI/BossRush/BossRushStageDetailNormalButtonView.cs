using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061BF RID: 25023
	[Token(Token = "0x20061BF")]
	public class BossRushStageDetailNormalButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005537 RID: 21815
		// (get) Token: 0x060241BB RID: 147899 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060241BC RID: 147900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005537")]
		public Action<ActivityBossRushData.BossRushStageType> onBtnClick
		{
			[Token(Token = "0x60241BB")]
			[Address(RVA = "0x1EC8A40", Offset = "0x1EC7640", VA = "0x181EC8A40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60241BC")]
			[Address(RVA = "0x1EC8AA0", Offset = "0x1EC76A0", VA = "0x181EC8AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060241BD RID: 147901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241BD")]
		[Address(RVA = "0x1EC8640", Offset = "0x1EC7240", VA = "0x181EC8640")]
		public void Render(ActivityBossRushData.BossRushStageType selectStage, Dictionary<ActivityBossRushData.BossRushStageType, BossRushStageModel> unlockMap)
		{
		}

		// Token: 0x060241BE RID: 147902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241BE")]
		[Address(RVA = "0x1EC8530", Offset = "0x1EC7130", VA = "0x181EC8530")]
		public void OnClick()
		{
		}

		// Token: 0x060241BF RID: 147903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241BF")]
		[Address(RVA = "0x1EC8890", Offset = "0x1EC7490", VA = "0x181EC8890")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060241C0 RID: 147904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241C0")]
		[Address(RVA = "0x1EC89E0", Offset = "0x1EC75E0", VA = "0x181EC89E0")]
		public BossRushStageDetailNormalButtonView()
		{
		}

		// Token: 0x04032316 RID: 205590
		[Token(Token = "0x4032316")]
		private const float SWITCH_FADETIME = 0.1f;

		// Token: 0x04032317 RID: 205591
		[Token(Token = "0x4032317")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActivityBossRushData.BossRushStageType _bindStageType;

		// Token: 0x04032318 RID: 205592
		[Token(Token = "0x4032318")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _selectCanvasGroup;

		// Token: 0x04032319 RID: 205593
		[Token(Token = "0x4032319")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _textCanvasGroup;

		// Token: 0x0403231A RID: 205594
		[Token(Token = "0x403231A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Graphic _btnHotSpot;

		// Token: 0x0403231B RID: 205595
		[Token(Token = "0x403231B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403231C RID: 205596
		[Token(Token = "0x403231C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textMode;

		// Token: 0x0403231D RID: 205597
		[Token(Token = "0x403231D")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0403231E RID: 205598
		[Token(Token = "0x403231E")]
		[FieldOffset(Offset = "0x50")]
		private BossRushStageDetailNormalButtonView.NormalBtnFadeSwitch m_fadeSwitchTween;

		// Token: 0x04032320 RID: 205600
		[Token(Token = "0x4032320")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBtnClick;

		// Token: 0x04032321 RID: 205601
		[Token(Token = "0x4032321")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBtnClick;

		// Token: 0x04032322 RID: 205602
		[Token(Token = "0x4032322")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032323 RID: 205603
		[Token(Token = "0x4032323")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04032324 RID: 205604
		[Token(Token = "0x4032324")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032325 RID: 205605
		[Token(Token = "0x4032325")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020061C0 RID: 25024
		[Token(Token = "0x20061C0")]
		private class NormalBtnFadeSwitch : UISwitchTween
		{
			// Token: 0x060241C1 RID: 147905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60241C1")]
			[Address(RVA = "0x1ECB7F0", Offset = "0x1ECA3F0", VA = "0x181ECB7F0")]
			public NormalBtnFadeSwitch(BossRushStageDetailNormalButtonView closure)
			{
			}

			// Token: 0x060241C2 RID: 147906 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60241C2")]
			[Address(RVA = "0x1ECB3C0", Offset = "0x1EC9FC0", VA = "0x181ECB3C0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060241C3 RID: 147907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60241C3")]
			[Address(RVA = "0x1ECB540", Offset = "0x1ECA140", VA = "0x181ECB540", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060241C4 RID: 147908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60241C4")]
			[Address(RVA = "0x1ECB320", Offset = "0x1EC9F20", VA = "0x181ECB320", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x060241C5 RID: 147909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60241C5")]
			[Address(RVA = "0x1ECB280", Offset = "0x1EC9E80", VA = "0x181ECB280", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x060241C6 RID: 147910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60241C6")]
			[Address(RVA = "0x1ECB6C0", Offset = "0x1ECA2C0", VA = "0x181ECB6C0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060241C7 RID: 147911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60241C7")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x060241C8 RID: 147912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60241C8")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x060241C9 RID: 147913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60241C9")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04032326 RID: 205606
			[Token(Token = "0x4032326")]
			[FieldOffset(Offset = "0x48")]
			private BossRushStageDetailNormalButtonView m_closure;

			// Token: 0x04032327 RID: 205607
			[Token(Token = "0x4032327")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04032328 RID: 205608
			[Token(Token = "0x4032328")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04032329 RID: 205609
			[Token(Token = "0x4032329")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403232A RID: 205610
			[Token(Token = "0x403232A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0403232B RID: 205611
			[Token(Token = "0x403232B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0403232C RID: 205612
			[Token(Token = "0x403232C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
