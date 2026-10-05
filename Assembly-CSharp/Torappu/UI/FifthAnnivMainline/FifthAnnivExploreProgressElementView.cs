using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F19 RID: 20249
	[Token(Token = "0x2004F19")]
	public class FifthAnnivExploreProgressElementView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170046BD RID: 18109
		// (get) Token: 0x0601E2C2 RID: 123586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046BD")]
		public UIColorGraphic colorGraphic
		{
			[Token(Token = "0x601E2C2")]
			[Address(RVA = "0x17F1420", Offset = "0x17F0020", VA = "0x1817F1420")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E2C3 RID: 123587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2C3")]
		[Address(RVA = "0x17F1080", Offset = "0x17EFC80", VA = "0x1817F1080")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E2C4 RID: 123588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2C4")]
		[Address(RVA = "0x17F1230", Offset = "0x17EFE30", VA = "0x1817F1230")]
		private void _SetProgress(float targetProgress, bool fastMode)
		{
		}

		// Token: 0x0601E2C5 RID: 123589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2C5")]
		[Address(RVA = "0x17F0C40", Offset = "0x17EF840", VA = "0x1817F0C40")]
		public void Render(int index, FifthAnnivExploreProgressViewModel viewModel)
		{
		}

		// Token: 0x0601E2C6 RID: 123590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2C6")]
		[Address(RVA = "0x17F13C0", Offset = "0x17EFFC0", VA = "0x1817F13C0")]
		public FifthAnnivExploreProgressElementView()
		{
		}

		// Token: 0x040282EA RID: 164586
		[Token(Token = "0x40282EA")]
		private const float ANIM_DURATION = 0.8f;

		// Token: 0x040282EB RID: 164587
		[Token(Token = "0x40282EB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x040282EC RID: 164588
		[Token(Token = "0x40282EC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasDot;

		// Token: 0x040282ED RID: 164589
		[Token(Token = "0x40282ED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _groupDot;

		// Token: 0x040282EE RID: 164590
		[Token(Token = "0x40282EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _rectProgress;

		// Token: 0x040282EF RID: 164591
		[Token(Token = "0x40282EF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x040282F0 RID: 164592
		[Token(Token = "0x40282F0")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x040282F1 RID: 164593
		[Token(Token = "0x40282F1")]
		[FieldOffset(Offset = "0x48")]
		private UISwitchTween m_expandTween;

		// Token: 0x040282F2 RID: 164594
		[Token(Token = "0x40282F2")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_progressTween;

		// Token: 0x040282F3 RID: 164595
		[Token(Token = "0x40282F3")]
		[FieldOffset(Offset = "0x58")]
		private FifthAnnivExploreProgressElementView.Adapter m_adapter;

		// Token: 0x040282F4 RID: 164596
		[Token(Token = "0x40282F4")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedStageNodeCount;

		// Token: 0x040282F5 RID: 164597
		[Token(Token = "0x40282F5")]
		[FieldOffset(Offset = "0x64")]
		private int m_cachedInitSeq;

		// Token: 0x040282F6 RID: 164598
		[Token(Token = "0x40282F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_colorGraphic;

		// Token: 0x040282F7 RID: 164599
		[Token(Token = "0x40282F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040282F8 RID: 164600
		[Token(Token = "0x40282F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetProgress;

		// Token: 0x040282F9 RID: 164601
		[Token(Token = "0x40282F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040282FA RID: 164602
		[Token(Token = "0x40282FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F1A RID: 20250
		[Token(Token = "0x2004F1A")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x0601E2C7 RID: 123591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E2C7")]
			[Address(RVA = "0x17F57F0", Offset = "0x17F43F0", VA = "0x1817F57F0")]
			public SwitchTween(FifthAnnivExploreProgressElementView closure)
			{
			}

			// Token: 0x0601E2C8 RID: 123592 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E2C8")]
			[Address(RVA = "0x17F5380", Offset = "0x17F3F80", VA = "0x1817F5380", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601E2C9 RID: 123593 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E2C9")]
			[Address(RVA = "0x17F5520", Offset = "0x17F4120", VA = "0x1817F5520", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601E2CA RID: 123594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E2CA")]
			[Address(RVA = "0x17F52F0", Offset = "0x17F3EF0", VA = "0x1817F52F0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601E2CB RID: 123595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E2CB")]
			[Address(RVA = "0x17F5260", Offset = "0x17F3E60", VA = "0x1817F5260", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601E2CC RID: 123596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E2CC")]
			[Address(RVA = "0x17F56D0", Offset = "0x17F42D0", VA = "0x1817F56D0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601E2CD RID: 123597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E2CD")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601E2CE RID: 123598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E2CE")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601E2CF RID: 123599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E2CF")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040282FB RID: 164603
			[Token(Token = "0x40282FB")]
			[FieldOffset(Offset = "0x48")]
			private FifthAnnivExploreProgressElementView m_closure;

			// Token: 0x040282FC RID: 164604
			[Token(Token = "0x40282FC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040282FD RID: 164605
			[Token(Token = "0x40282FD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040282FE RID: 164606
			[Token(Token = "0x40282FE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040282FF RID: 164607
			[Token(Token = "0x40282FF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04028300 RID: 164608
			[Token(Token = "0x4028300")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04028301 RID: 164609
			[Token(Token = "0x4028301")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02004F1B RID: 20251
		[Token(Token = "0x2004F1B")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E2D0 RID: 123600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E2D0")]
			[Address(RVA = "0x17E0520", Offset = "0x17DF120", VA = "0x1817E0520")]
			public Adapter(FifthAnnivExploreProgressElementView closure)
			{
			}

			// Token: 0x170046BE RID: 18110
			// (get) Token: 0x0601E2D1 RID: 123601 RVA: 0x000ADBB0 File Offset: 0x000ABDB0
			[Token(Token = "0x170046BE")]
			public override int count
			{
				[Token(Token = "0x601E2D1")]
				[Address(RVA = "0x17E0680", Offset = "0x17DF280", VA = "0x1817E0680", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E2D2 RID: 123602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E2D2")]
			[Address(RVA = "0x17E0180", Offset = "0x17DED80", VA = "0x1817E0180", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04028302 RID: 164610
			[Token(Token = "0x4028302")]
			[FieldOffset(Offset = "0x20")]
			private FifthAnnivExploreProgressElementView m_closure;

			// Token: 0x04028303 RID: 164611
			[Token(Token = "0x4028303")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028304 RID: 164612
			[Token(Token = "0x4028304")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04028305 RID: 164613
			[Token(Token = "0x4028305")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
