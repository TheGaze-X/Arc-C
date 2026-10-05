using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CC4 RID: 23748
	[Token(Token = "0x2005CC4")]
	public class ClimbTowerLayerMenuButton : ClimbTowerMenuButton
	{
		// Token: 0x06022611 RID: 140817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022611")]
		[Address(RVA = "0x1CD1B90", Offset = "0x1CD0790", VA = "0x181CD1B90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022612 RID: 140818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022612")]
		[Address(RVA = "0x1CD1860", Offset = "0x1CD0460", VA = "0x181CD1860", Slot = "4")]
		public override void Render(IClimbTowerMenuButtonDataSource dataSource, bool fastMode)
		{
		}

		// Token: 0x06022613 RID: 140819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022613")]
		[Address(RVA = "0x1CD1CB0", Offset = "0x1CD08B0", VA = "0x181CD1CB0")]
		public ClimbTowerLayerMenuButton()
		{
		}

		// Token: 0x0402F3EB RID: 193515
		[Token(Token = "0x402F3EB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasCurr;

		// Token: 0x0402F3EC RID: 193516
		[Token(Token = "0x402F3EC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasBack;

		// Token: 0x0402F3ED RID: 193517
		[Token(Token = "0x402F3ED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402F3EE RID: 193518
		[Token(Token = "0x402F3EE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgBtnBkg;

		// Token: 0x0402F3EF RID: 193519
		[Token(Token = "0x402F3EF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402F3F0 RID: 193520
		[Token(Token = "0x402F3F0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _normalBkgId;

		// Token: 0x0402F3F1 RID: 193521
		[Token(Token = "0x402F3F1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _hardBkgId;

		// Token: 0x0402F3F2 RID: 193522
		[Token(Token = "0x402F3F2")]
		[FieldOffset(Offset = "0x58")]
		private ClimbTowerLayerMenuButton.SwitchTween m_switchTween;

		// Token: 0x0402F3F3 RID: 193523
		[Token(Token = "0x402F3F3")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0402F3F4 RID: 193524
		[Token(Token = "0x402F3F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F3F5 RID: 193525
		[Token(Token = "0x402F3F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F3F6 RID: 193526
		[Token(Token = "0x402F3F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CC5 RID: 23749
		[Token(Token = "0x2005CC5")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x06022614 RID: 140820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022614")]
			[Address(RVA = "0x1CE0E60", Offset = "0x1CDFA60", VA = "0x181CE0E60")]
			public SwitchTween(ClimbTowerLayerMenuButton closure)
			{
			}

			// Token: 0x06022615 RID: 140821 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022615")]
			[Address(RVA = "0x1CE0590", Offset = "0x1CDF190", VA = "0x181CE0590", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06022616 RID: 140822 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022616")]
			[Address(RVA = "0x1CE0A40", Offset = "0x1CDF640", VA = "0x181CE0A40", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06022617 RID: 140823 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022617")]
			[Address(RVA = "0x1CE00D0", Offset = "0x1CDECD0", VA = "0x181CE00D0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x06022618 RID: 140824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022618")]
			[Address(RVA = "0x1CE0500", Offset = "0x1CDF100", VA = "0x181CE0500", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06022619 RID: 140825 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022619")]
			[Address(RVA = "0x1CE0200", Offset = "0x1CDEE00", VA = "0x181CE0200", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0602261A RID: 140826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602261A")]
			[Address(RVA = "0x1CE03D0", Offset = "0x1CDEFD0", VA = "0x181CE03D0", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0602261B RID: 140827 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602261B")]
			[Address(RVA = "0x1CE0BB0", Offset = "0x1CDF7B0", VA = "0x181CE0BB0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602261C RID: 140828 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602261C")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0602261D RID: 140829 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602261D")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0602261E RID: 140830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602261E")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0602261F RID: 140831 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602261F")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x06022620 RID: 140832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022620")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402F3F7 RID: 193527
			[Token(Token = "0x402F3F7")]
			private const float ANIM_DURATION = 0.16f;

			// Token: 0x0402F3F8 RID: 193528
			[Token(Token = "0x402F3F8")]
			[FieldOffset(Offset = "0x48")]
			private ClimbTowerLayerMenuButton m_closure;

			// Token: 0x0402F3F9 RID: 193529
			[Token(Token = "0x402F3F9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F3FA RID: 193530
			[Token(Token = "0x402F3FA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402F3FB RID: 193531
			[Token(Token = "0x402F3FB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402F3FC RID: 193532
			[Token(Token = "0x402F3FC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0402F3FD RID: 193533
			[Token(Token = "0x402F3FD")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402F3FE RID: 193534
			[Token(Token = "0x402F3FE")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0402F3FF RID: 193535
			[Token(Token = "0x402F3FF")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0402F400 RID: 193536
			[Token(Token = "0x402F400")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02005CC6 RID: 23750
		[Token(Token = "0x2005CC6")]
		public class DataSource : IClimbTowerMenuButtonDataSource, IHotfixable
		{
			// Token: 0x06022621 RID: 140833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022621")]
			[Address(RVA = "0x1CDE100", Offset = "0x1CDCD00", VA = "0x181CDE100")]
			public DataSource()
			{
			}

			// Token: 0x0402F401 RID: 193537
			[Token(Token = "0x402F401")]
			[FieldOffset(Offset = "0x10")]
			public bool isCurrentLayer;

			// Token: 0x0402F402 RID: 193538
			[Token(Token = "0x402F402")]
			[FieldOffset(Offset = "0x11")]
			public bool isFirstTry;

			// Token: 0x0402F403 RID: 193539
			[Token(Token = "0x402F403")]
			[FieldOffset(Offset = "0x12")]
			public bool isHard;

			// Token: 0x0402F404 RID: 193540
			[Token(Token = "0x402F404")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
