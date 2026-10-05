using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F1F RID: 20255
	[Token(Token = "0x2004F1F")]
	public class FifthAnnivExploreTopMenuProgressView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E2E7 RID: 123623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2E7")]
		[Address(RVA = "0x17F3740", Offset = "0x17F2340", VA = "0x1817F3740")]
		private void _InitIfNot()
		{
		}

		// Token: 0x170046C0 RID: 18112
		// (get) Token: 0x0601E2E9 RID: 123625 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E2E8 RID: 123624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046C0")]
		public Action onClick
		{
			[Token(Token = "0x601E2E9")]
			[Address(RVA = "0x17F3960", Offset = "0x17F2560", VA = "0x1817F3960")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601E2E8")]
			[Address(RVA = "0x17F39C0", Offset = "0x17F25C0", VA = "0x1817F39C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601E2EA RID: 123626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2EA")]
		[Address(RVA = "0x17F3570", Offset = "0x17F2170", VA = "0x1817F3570")]
		public void OnClick()
		{
		}

		// Token: 0x0601E2EB RID: 123627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2EB")]
		[Address(RVA = "0x17F3680", Offset = "0x17F2280", VA = "0x1817F3680")]
		public void Render(FifthAnnivExploreProgressViewModel viewModel)
		{
		}

		// Token: 0x0601E2EC RID: 123628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2EC")]
		[Address(RVA = "0x17F3900", Offset = "0x17F2500", VA = "0x1817F3900")]
		public FifthAnnivExploreTopMenuProgressView()
		{
		}

		// Token: 0x0402832C RID: 164652
		[Token(Token = "0x402832C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _progressContent;

		// Token: 0x0402832D RID: 164653
		[Token(Token = "0x402832D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402832E RID: 164654
		[Token(Token = "0x402832E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animLoop;

		// Token: 0x0402832F RID: 164655
		[Token(Token = "0x402832F")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x04028330 RID: 164656
		[Token(Token = "0x4028330")]
		[FieldOffset(Offset = "0x40")]
		private FifthAnnivExploreTopMenuProgressView.Adapter m_progressAdapter;

		// Token: 0x04028331 RID: 164657
		[Token(Token = "0x4028331")]
		[FieldOffset(Offset = "0x48")]
		private FifthAnnivExploreProgressViewModel m_cachedProgressViewModel;

		// Token: 0x04028332 RID: 164658
		[Token(Token = "0x4028332")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_loopTween;

		// Token: 0x04028334 RID: 164660
		[Token(Token = "0x4028334")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028335 RID: 164661
		[Token(Token = "0x4028335")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x04028336 RID: 164662
		[Token(Token = "0x4028336")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x04028337 RID: 164663
		[Token(Token = "0x4028337")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04028338 RID: 164664
		[Token(Token = "0x4028338")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028339 RID: 164665
		[Token(Token = "0x4028339")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F20 RID: 20256
		[Token(Token = "0x2004F20")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E2ED RID: 123629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E2ED")]
			[Address(RVA = "0x17E0600", Offset = "0x17DF200", VA = "0x1817E0600")]
			public Adapter(FifthAnnivExploreTopMenuProgressView closure)
			{
			}

			// Token: 0x170046C1 RID: 18113
			// (get) Token: 0x0601E2EE RID: 123630 RVA: 0x000ADBE0 File Offset: 0x000ABDE0
			[Token(Token = "0x170046C1")]
			public override int count
			{
				[Token(Token = "0x601E2EE")]
				[Address(RVA = "0x17E06F0", Offset = "0x17DF2F0", VA = "0x1817E06F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E2EF RID: 123631 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E2EF")]
			[Address(RVA = "0x17E0310", Offset = "0x17DEF10", VA = "0x1817E0310", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402833A RID: 164666
			[Token(Token = "0x402833A")]
			[FieldOffset(Offset = "0x20")]
			private FifthAnnivExploreTopMenuProgressView m_closure;

			// Token: 0x0402833B RID: 164667
			[Token(Token = "0x402833B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402833C RID: 164668
			[Token(Token = "0x402833C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402833D RID: 164669
			[Token(Token = "0x402833D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
