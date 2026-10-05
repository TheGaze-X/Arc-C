using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CBF RID: 23743
	[Token(Token = "0x2005CBF")]
	public class ClimbTowerButtonHolderMenuObject : ClimbTowerMenuObject
	{
		// Token: 0x170050C7 RID: 20679
		// (get) Token: 0x060225F2 RID: 140786 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060225F3 RID: 140787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050C7")]
		private ClimbTowerMenuButton currInst
		{
			[Token(Token = "0x60225F2")]
			[Address(RVA = "0x1CD1210", Offset = "0x1CCFE10", VA = "0x181CD1210")]
			get
			{
				return null;
			}
			[Token(Token = "0x60225F3")]
			[Address(RVA = "0x1CD1290", Offset = "0x1CCFE90", VA = "0x181CD1290")]
			set
			{
			}
		}

		// Token: 0x060225F4 RID: 140788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225F4")]
		[Address(RVA = "0x1CD0E50", Offset = "0x1CCFA50", VA = "0x181CD0E50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060225F5 RID: 140789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225F5")]
		[Address(RVA = "0x1CD1010", Offset = "0x1CCFC10", VA = "0x181CD1010")]
		private void _OnBtnClicked()
		{
		}

		// Token: 0x060225F6 RID: 140790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225F6")]
		[Address(RVA = "0x1CD0970", Offset = "0x1CCF570", VA = "0x181CD0970", Slot = "4")]
		public override void Render(ClimbTowerMenuViewModel viewModel)
		{
		}

		// Token: 0x060225F7 RID: 140791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225F7")]
		[Address(RVA = "0x1CD08E0", Offset = "0x1CCF4E0", VA = "0x181CD08E0")]
		public void OnTacticalBuffWindowShowStatusUpdated(bool isShow)
		{
		}

		// Token: 0x060225F8 RID: 140792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225F8")]
		[Address(RVA = "0x1CD09D0", Offset = "0x1CCF5D0", VA = "0x181CD09D0")]
		public void UpdateButton(ClimbTowerMenuButton buttonPrefab, IClimbTowerMenuButtonDataSource dataSource, Action callback, bool fastMode)
		{
		}

		// Token: 0x060225F9 RID: 140793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225F9")]
		[Address(RVA = "0x1CD0830", Offset = "0x1CCF430", VA = "0x181CD0830")]
		public IEnumerator EnsureButton()
		{
			return null;
		}

		// Token: 0x060225FA RID: 140794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225FA")]
		[Address(RVA = "0x1CD1170", Offset = "0x1CCFD70", VA = "0x181CD1170")]
		public ClimbTowerButtonHolderMenuObject()
		{
		}

		// Token: 0x0402F3C5 RID: 193477
		[Token(Token = "0x402F3C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup[] _canvasList;

		// Token: 0x0402F3C6 RID: 193478
		[Token(Token = "0x402F3C6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasRoot;

		// Token: 0x0402F3C7 RID: 193479
		[Token(Token = "0x402F3C7")]
		[FieldOffset(Offset = "0x30")]
		private int m_currIndex;

		// Token: 0x0402F3C8 RID: 193480
		[Token(Token = "0x402F3C8")]
		[FieldOffset(Offset = "0x34")]
		private bool m_hasInited;

		// Token: 0x0402F3C9 RID: 193481
		[Token(Token = "0x402F3C9")]
		[FieldOffset(Offset = "0x35")]
		private bool m_tacticalBuffWindowShow;

		// Token: 0x0402F3CA RID: 193482
		[Token(Token = "0x402F3CA")]
		[FieldOffset(Offset = "0x38")]
		private ClimbTowerMenuButton m_prefab;

		// Token: 0x0402F3CB RID: 193483
		[Token(Token = "0x402F3CB")]
		[FieldOffset(Offset = "0x40")]
		private ClimbTowerMenuButton[] m_instance;

		// Token: 0x0402F3CC RID: 193484
		[Token(Token = "0x402F3CC")]
		[FieldOffset(Offset = "0x48")]
		private ClimbTowerButtonHolderMenuObject.SwitchTween m_switchTween;

		// Token: 0x0402F3CD RID: 193485
		[Token(Token = "0x402F3CD")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_showSwitchTween;

		// Token: 0x0402F3CE RID: 193486
		[Token(Token = "0x402F3CE")]
		[FieldOffset(Offset = "0x58")]
		private Action m_callback;

		// Token: 0x0402F3CF RID: 193487
		[Token(Token = "0x402F3CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currInst;

		// Token: 0x0402F3D0 RID: 193488
		[Token(Token = "0x402F3D0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_currInst;

		// Token: 0x0402F3D1 RID: 193489
		[Token(Token = "0x402F3D1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F3D2 RID: 193490
		[Token(Token = "0x402F3D2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnBtnClicked;

		// Token: 0x0402F3D3 RID: 193491
		[Token(Token = "0x402F3D3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F3D4 RID: 193492
		[Token(Token = "0x402F3D4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTacticalBuffWindowShowStatusUpdated;

		// Token: 0x0402F3D5 RID: 193493
		[Token(Token = "0x402F3D5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateButton;

		// Token: 0x0402F3D6 RID: 193494
		[Token(Token = "0x402F3D6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EnsureButton;

		// Token: 0x0402F3D7 RID: 193495
		[Token(Token = "0x402F3D7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CC0 RID: 23744
		[Token(Token = "0x2005CC0")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x060225FB RID: 140795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60225FB")]
			[Address(RVA = "0x1CE0EE0", Offset = "0x1CDFAE0", VA = "0x181CE0EE0")]
			public SwitchTween(ClimbTowerButtonHolderMenuObject closure)
			{
			}

			// Token: 0x060225FC RID: 140796 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60225FC")]
			[Address(RVA = "0x1CE0700", Offset = "0x1CDF300", VA = "0x181CE0700", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060225FD RID: 140797 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60225FD")]
			[Address(RVA = "0x1CE08A0", Offset = "0x1CDF4A0", VA = "0x181CE08A0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060225FE RID: 140798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60225FE")]
			[Address(RVA = "0x1CE0160", Offset = "0x1CDED60", VA = "0x181CE0160", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x060225FF RID: 140799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60225FF")]
			[Address(RVA = "0x1CE0460", Offset = "0x1CDF060", VA = "0x181CE0460", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06022600 RID: 140800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022600")]
			[Address(RVA = "0x1CE0290", Offset = "0x1CDEE90", VA = "0x181CE0290", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x06022601 RID: 140801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022601")]
			[Address(RVA = "0x1CE0330", Offset = "0x1CDEF30", VA = "0x181CE0330", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x06022602 RID: 140802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022602")]
			[Address(RVA = "0x1CE0CE0", Offset = "0x1CDF8E0", VA = "0x181CE0CE0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06022603 RID: 140803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022603")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x06022604 RID: 140804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022604")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x06022605 RID: 140805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022605")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x06022606 RID: 140806 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022606")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x06022607 RID: 140807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022607")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402F3D8 RID: 193496
			[Token(Token = "0x402F3D8")]
			private const float ANIM_DURATION = 0.23f;

			// Token: 0x0402F3D9 RID: 193497
			[Token(Token = "0x402F3D9")]
			[FieldOffset(Offset = "0x48")]
			private ClimbTowerButtonHolderMenuObject m_closure;

			// Token: 0x0402F3DA RID: 193498
			[Token(Token = "0x402F3DA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F3DB RID: 193499
			[Token(Token = "0x402F3DB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402F3DC RID: 193500
			[Token(Token = "0x402F3DC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402F3DD RID: 193501
			[Token(Token = "0x402F3DD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0402F3DE RID: 193502
			[Token(Token = "0x402F3DE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402F3DF RID: 193503
			[Token(Token = "0x402F3DF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0402F3E0 RID: 193504
			[Token(Token = "0x402F3E0")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0402F3E1 RID: 193505
			[Token(Token = "0x402F3E1")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
