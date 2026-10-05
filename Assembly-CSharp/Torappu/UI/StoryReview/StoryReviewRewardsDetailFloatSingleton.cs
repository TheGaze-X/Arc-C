using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004915 RID: 18709
	[Token(Token = "0x2004915")]
	public class StoryReviewRewardsDetailFloatSingleton : PageSingleComponent
	{
		// Token: 0x0601C352 RID: 115538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C352")]
		[Address(RVA = "0x15B54F0", Offset = "0x15B40F0", VA = "0x1815B54F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C353 RID: 115539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C353")]
		[Address(RVA = "0x15B5040", Offset = "0x15B3C40", VA = "0x1815B5040")]
		public void Render(RectTransform obj, List<ItemBundle> itemList)
		{
		}

		// Token: 0x0601C354 RID: 115540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C354")]
		[Address(RVA = "0x15B4F00", Offset = "0x15B3B00", VA = "0x1815B4F00")]
		public void ClosePage()
		{
		}

		// Token: 0x0601C355 RID: 115541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C355")]
		[Address(RVA = "0x15B5600", Offset = "0x15B4200", VA = "0x1815B5600")]
		public StoryReviewRewardsDetailFloatSingleton()
		{
		}

		// Token: 0x04024E2A RID: 151082
		[Token(Token = "0x4024E2A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _backBtn;

		// Token: 0x04024E2B RID: 151083
		[Token(Token = "0x4024E2B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04024E2C RID: 151084
		[Token(Token = "0x4024E2C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04024E2D RID: 151085
		[Token(Token = "0x4024E2D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _itemCount;

		// Token: 0x04024E2E RID: 151086
		[Token(Token = "0x4024E2E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("The common anchor position base of the managed views")]
		private RectTransform _panelLocal;

		// Token: 0x04024E2F RID: 151087
		[Token(Token = "0x4024E2F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _rootView;

		// Token: 0x04024E30 RID: 151088
		[Token(Token = "0x4024E30")]
		[FieldOffset(Offset = "0x50")]
		private StoryReviewRewardsDetailFloatSingleton.Adapter m_adapter;

		// Token: 0x04024E31 RID: 151089
		[Token(Token = "0x4024E31")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04024E32 RID: 151090
		[Token(Token = "0x4024E32")]
		[FieldOffset(Offset = "0x60")]
		private Tweener m_tween;

		// Token: 0x04024E33 RID: 151091
		[Token(Token = "0x4024E33")]
		protected const float FADE_DURATION = 0.23f;

		// Token: 0x04024E34 RID: 151092
		[Token(Token = "0x4024E34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024E35 RID: 151093
		[Token(Token = "0x4024E35")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024E36 RID: 151094
		[Token(Token = "0x4024E36")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClosePage;

		// Token: 0x04024E37 RID: 151095
		[Token(Token = "0x4024E37")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004916 RID: 18710
		[Token(Token = "0x2004916")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170042F1 RID: 17137
			// (get) Token: 0x0601C356 RID: 115542 RVA: 0x000A78E0 File Offset: 0x000A5AE0
			[Token(Token = "0x170042F1")]
			public override int count
			{
				[Token(Token = "0x601C356")]
				[Address(RVA = "0x15AB9D0", Offset = "0x15AA5D0", VA = "0x1815AB9D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601C357 RID: 115543 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C357")]
			[Address(RVA = "0x15AB6B0", Offset = "0x15AA2B0", VA = "0x1815AB6B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601C358 RID: 115544 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C358")]
			[Address(RVA = "0x15AB970", Offset = "0x15AA570", VA = "0x1815AB970")]
			public Adapter()
			{
			}

			// Token: 0x04024E38 RID: 151096
			[Token(Token = "0x4024E38")]
			[FieldOffset(Offset = "0x20")]
			public List<ItemBundle> viewModelList;

			// Token: 0x04024E39 RID: 151097
			[Token(Token = "0x4024E39")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04024E3A RID: 151098
			[Token(Token = "0x4024E3A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04024E3B RID: 151099
			[Token(Token = "0x4024E3B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
