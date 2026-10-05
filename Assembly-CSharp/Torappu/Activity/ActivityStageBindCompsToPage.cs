using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D54 RID: 27988
	[Token(Token = "0x2006D54")]
	public class ActivityStageBindCompsToPage : ActivityStageComponent
	{
		// Token: 0x06027E41 RID: 163393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E41")]
		[Address(RVA = "0x22F2B50", Offset = "0x22F1750", VA = "0x1822F2B50", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x06027E42 RID: 163394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E42")]
		[Address(RVA = "0x22F2A10", Offset = "0x22F1610", VA = "0x1822F2A10", Slot = "5")]
		protected override void BeforeUnload()
		{
		}

		// Token: 0x06027E43 RID: 163395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E43")]
		[Address(RVA = "0x22F2AD0", Offset = "0x22F16D0", VA = "0x1822F2AD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06027E44 RID: 163396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E44")]
		[Address(RVA = "0x22F2E40", Offset = "0x22F1A40", VA = "0x1822F2E40")]
		public ActivityStageBindCompsToPage()
		{
		}

		// Token: 0x06027E45 RID: 163397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E45")]
		[Address(RVA = "0x22F1320", Offset = "0x22EFF20", VA = "0x1822F1320")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x06027E46 RID: 163398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E46")]
		[Address(RVA = "0x22F2DE0", Offset = "0x22F19E0", VA = "0x1822F2DE0")]
		private void <>xLuaBaseProxy_BeforeUnload()
		{
		}

		// Token: 0x040388AB RID: 231595
		[Token(Token = "0x40388AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Canvas[] _canvases;

		// Token: 0x040388AC RID: 231596
		[Token(Token = "0x40388AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Renderer[] _renderers;

		// Token: 0x040388AD RID: 231597
		[Token(Token = "0x40388AD")]
		[FieldOffset(Offset = "0x30")]
		private ActivityStageBindCompsToPage.RendererCollection m_rendererCollection;

		// Token: 0x040388AE RID: 231598
		[Token(Token = "0x40388AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x040388AF RID: 231599
		[Token(Token = "0x40388AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BeforeUnload;

		// Token: 0x040388B0 RID: 231600
		[Token(Token = "0x40388B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040388B1 RID: 231601
		[Token(Token = "0x40388B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006D55 RID: 27989
		[Token(Token = "0x2006D55")]
		private class RendererCollection : IPageUIRenderer, IHotfixable, IDisposable
		{
			// Token: 0x06027E47 RID: 163399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027E47")]
			[Address(RVA = "0x22F9BD0", Offset = "0x22F87D0", VA = "0x1822F9BD0")]
			public RendererCollection(ActivityStageBindCompsToPage closure, UIPage page)
			{
			}

			// Token: 0x06027E48 RID: 163400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027E48")]
			[Address(RVA = "0x22F9630", Offset = "0x22F8230", VA = "0x1822F9630", Slot = "4")]
			public void InitSortingInfo(SortingInfo sortingInfo)
			{
			}

			// Token: 0x06027E49 RID: 163401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027E49")]
			[Address(RVA = "0x22F9360", Offset = "0x22F7F60", VA = "0x1822F9360", Slot = "5")]
			public void AdjustToTargetLayer(SortingInfo sortingInfo)
			{
			}

			// Token: 0x06027E4A RID: 163402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027E4A")]
			[Address(RVA = "0x22F96E0", Offset = "0x22F82E0", VA = "0x1822F96E0", Slot = "6")]
			public void RestoreLayers()
			{
			}

			// Token: 0x06027E4B RID: 163403 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027E4B")]
			[Address(RVA = "0x22F9410", Offset = "0x22F8010", VA = "0x1822F9410", Slot = "7")]
			public void Dispose()
			{
			}

			// Token: 0x06027E4C RID: 163404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027E4C")]
			[Address(RVA = "0x22F9960", Offset = "0x22F8560", VA = "0x1822F9960")]
			private void _InitCacheIfNot()
			{
			}

			// Token: 0x06027E4D RID: 163405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027E4D")]
			[Address(RVA = "0x22F9760", Offset = "0x22F8360", VA = "0x1822F9760")]
			private void _BindCanvases()
			{
			}

			// Token: 0x06027E4E RID: 163406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027E4E")]
			[Address(RVA = "0x22F9A90", Offset = "0x22F8690", VA = "0x1822F9A90")]
			private void _UnbindCanvases()
			{
			}

			// Token: 0x040388B2 RID: 231602
			[Token(Token = "0x40388B2")]
			[FieldOffset(Offset = "0x10")]
			private ActivityStageBindCompsToPage m_closure;

			// Token: 0x040388B3 RID: 231603
			[Token(Token = "0x40388B3")]
			[FieldOffset(Offset = "0x18")]
			private bool m_isInited;

			// Token: 0x040388B4 RID: 231604
			[Token(Token = "0x40388B4")]
			[FieldOffset(Offset = "0x20")]
			private UIRendererSortingInfoStorage m_sortingInfo;

			// Token: 0x040388B5 RID: 231605
			[Token(Token = "0x40388B5")]
			[FieldOffset(Offset = "0x28")]
			private List<Canvas> m_bindedCanvases;

			// Token: 0x040388B6 RID: 231606
			[Token(Token = "0x40388B6")]
			[FieldOffset(Offset = "0x30")]
			private UIPage m_registeredPage;

			// Token: 0x040388B7 RID: 231607
			[Token(Token = "0x40388B7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040388B8 RID: 231608
			[Token(Token = "0x40388B8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_InitSortingInfo;

			// Token: 0x040388B9 RID: 231609
			[Token(Token = "0x40388B9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_AdjustToTargetLayer;

			// Token: 0x040388BA RID: 231610
			[Token(Token = "0x40388BA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RestoreLayers;

			// Token: 0x040388BB RID: 231611
			[Token(Token = "0x40388BB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x040388BC RID: 231612
			[Token(Token = "0x40388BC")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__InitCacheIfNot;

			// Token: 0x040388BD RID: 231613
			[Token(Token = "0x40388BD")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__BindCanvases;

			// Token: 0x040388BE RID: 231614
			[Token(Token = "0x40388BE")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__UnbindCanvases;
		}
	}
}
