using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007711 RID: 30481
	[Token(Token = "0x2007711")]
	public class Act1VHalfIdleCharLevelUpgradeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700647F RID: 25727
		// (get) Token: 0x0602AD20 RID: 175392 RVA: 0x000DA298 File Offset: 0x000D8498
		[Token(Token = "0x1700647F")]
		public bool isStable
		{
			[Token(Token = "0x602AD20")]
			[Address(RVA = "0x2697CC0", Offset = "0x26968C0", VA = "0x182697CC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AD21 RID: 175393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD21")]
		[Address(RVA = "0x2697B40", Offset = "0x2696740", VA = "0x182697B40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AD22 RID: 175394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD22")]
		[Address(RVA = "0x2697860", Offset = "0x2696460", VA = "0x182697860")]
		public void Render(Act1VHalfIdleCharUpgradeViewModel viewModel)
		{
		}

		// Token: 0x0602AD23 RID: 175395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD23")]
		[Address(RVA = "0x26976F0", Offset = "0x26962F0", VA = "0x1826976F0")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0602AD24 RID: 175396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD24")]
		[Address(RVA = "0x2697C60", Offset = "0x2696860", VA = "0x182697C60")]
		public Act1VHalfIdleCharLevelUpgradeView()
		{
		}

		// Token: 0x0403DB6A RID: 252778
		[Token(Token = "0x403DB6A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1VHalfIdleCharLevelUpgradeFullView _upgradeFullView;

		// Token: 0x0403DB6B RID: 252779
		[Token(Token = "0x403DB6B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act1VHalfIdleCharLevelUpgradeNotFullView _upgradeNotFullView;

		// Token: 0x0403DB6C RID: 252780
		[Token(Token = "0x403DB6C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animFullViewShow;

		// Token: 0x0403DB6D RID: 252781
		[Token(Token = "0x403DB6D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasNotFullView;

		// Token: 0x0403DB6E RID: 252782
		[Token(Token = "0x403DB6E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlLevelUpgradeGO;

		// Token: 0x0403DB6F RID: 252783
		[Token(Token = "0x403DB6F")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x0403DB70 RID: 252784
		[Token(Token = "0x403DB70")]
		[FieldOffset(Offset = "0x50")]
		private Act1VHalfIdleCharLevelUpgradeView.SwitchTween m_switchTween;

		// Token: 0x0403DB71 RID: 252785
		[Token(Token = "0x403DB71")]
		[FieldOffset(Offset = "0x58")]
		private int m_cachedInitSeqNum;

		// Token: 0x0403DB72 RID: 252786
		[Token(Token = "0x403DB72")]
		[FieldOffset(Offset = "0x5C")]
		private int m_cachedSwitchCharSeqNum;

		// Token: 0x0403DB73 RID: 252787
		[Token(Token = "0x403DB73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isStable;

		// Token: 0x0403DB74 RID: 252788
		[Token(Token = "0x403DB74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DB75 RID: 252789
		[Token(Token = "0x403DB75")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DB76 RID: 252790
		[Token(Token = "0x403DB76")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403DB77 RID: 252791
		[Token(Token = "0x403DB77")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007712 RID: 30482
		[Token(Token = "0x2007712")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x0602AD25 RID: 175397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD25")]
			[Address(RVA = "0x26A9A60", Offset = "0x26A8660", VA = "0x1826A9A60")]
			public SwitchTween(Act1VHalfIdleCharLevelUpgradeView closure)
			{
			}

			// Token: 0x0602AD26 RID: 175398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AD26")]
			[Address(RVA = "0x26A89B0", Offset = "0x26A75B0", VA = "0x1826A89B0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602AD27 RID: 175399 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AD27")]
			[Address(RVA = "0x26A8E70", Offset = "0x26A7A70", VA = "0x1826A8E70", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602AD28 RID: 175400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD28")]
			[Address(RVA = "0x26A8070", Offset = "0x26A6C70", VA = "0x1826A8070", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0602AD29 RID: 175401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD29")]
			[Address(RVA = "0x26A82E0", Offset = "0x26A6EE0", VA = "0x1826A82E0", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0602AD2A RID: 175402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD2A")]
			[Address(RVA = "0x26A88D0", Offset = "0x26A74D0", VA = "0x1826A88D0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0602AD2B RID: 175403 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD2B")]
			[Address(RVA = "0x26A8620", Offset = "0x26A7220", VA = "0x1826A8620", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0602AD2C RID: 175404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD2C")]
			[Address(RVA = "0x26A9650", Offset = "0x26A8250", VA = "0x1826A9650", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602AD2D RID: 175405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD2D")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0602AD2E RID: 175406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD2E")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0602AD2F RID: 175407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD2F")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0602AD30 RID: 175408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD30")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0602AD31 RID: 175409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD31")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403DB78 RID: 252792
			[Token(Token = "0x403DB78")]
			[FieldOffset(Offset = "0x48")]
			private Act1VHalfIdleCharLevelUpgradeView m_closure;

			// Token: 0x0403DB79 RID: 252793
			[Token(Token = "0x403DB79")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403DB7A RID: 252794
			[Token(Token = "0x403DB7A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403DB7B RID: 252795
			[Token(Token = "0x403DB7B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403DB7C RID: 252796
			[Token(Token = "0x403DB7C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0403DB7D RID: 252797
			[Token(Token = "0x403DB7D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0403DB7E RID: 252798
			[Token(Token = "0x403DB7E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0403DB7F RID: 252799
			[Token(Token = "0x403DB7F")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0403DB80 RID: 252800
			[Token(Token = "0x403DB80")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
