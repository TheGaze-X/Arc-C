using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053EF RID: 21487
	[Token(Token = "0x20053EF")]
	public class RoguelikeRewardListView : DataBinder<RoguelikeRewardViewProperty>, IHotfixable
	{
		// Token: 0x17004A06 RID: 18950
		// (get) Token: 0x0601F9CE RID: 129486 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F9CF RID: 129487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A06")]
		public RoguelikeRewardStyle uiStyle
		{
			[Token(Token = "0x601F9CE")]
			[Address(RVA = "0x195B1B0", Offset = "0x1959DB0", VA = "0x18195B1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F9CF")]
			[Address(RVA = "0x195B290", Offset = "0x1959E90", VA = "0x18195B290")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A07 RID: 18951
		// (get) Token: 0x0601F9D0 RID: 129488 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F9D1 RID: 129489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A07")]
		public Action onCompleteBtnClick
		{
			[Token(Token = "0x601F9D0")]
			[Address(RVA = "0x195B070", Offset = "0x1959C70", VA = "0x18195B070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F9D1")]
			[Address(RVA = "0x195B210", Offset = "0x1959E10", VA = "0x18195B210")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601F9D2 RID: 129490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F9D2")]
		[Address(RVA = "0x195A0B0", Offset = "0x1958CB0", VA = "0x18195A0B0")]
		public IList<RoguelikeRewardItemViewModel> GetDisplayList()
		{
			return null;
		}

		// Token: 0x17004A08 RID: 18952
		// (get) Token: 0x0601F9D3 RID: 129491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A08")]
		protected UIPageListener pageListener
		{
			[Token(Token = "0x601F9D3")]
			[Address(RVA = "0x195B0D0", Offset = "0x1959CD0", VA = "0x18195B0D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F9D4 RID: 129492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9D4")]
		[Address(RVA = "0x195A790", Offset = "0x1959390", VA = "0x18195A790")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F9D5 RID: 129493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9D5")]
		[Address(RVA = "0x195A2C0", Offset = "0x1958EC0", VA = "0x18195A2C0")]
		public void ResetRenderStatus()
		{
		}

		// Token: 0x0601F9D6 RID: 129494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9D6")]
		[Address(RVA = "0x195AB00", Offset = "0x1959700", VA = "0x18195AB00")]
		private void _RenderItemList(RoguelikeRewardListViewModel viewModel)
		{
		}

		// Token: 0x0601F9D7 RID: 129495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9D7")]
		[Address(RVA = "0x195A110", Offset = "0x1958D10", VA = "0x18195A110", Slot = "7")]
		public override void OnValueChanged(RoguelikeRewardViewProperty property)
		{
		}

		// Token: 0x0601F9D8 RID: 129496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9D8")]
		[Address(RVA = "0x1959EF0", Offset = "0x1958AF0", VA = "0x181959EF0")]
		public void CheckIfFinish()
		{
		}

		// Token: 0x0601F9D9 RID: 129497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F9D9")]
		[Address(RVA = "0x195A6E0", Offset = "0x19592E0", VA = "0x18195A6E0")]
		private IEnumerator _DismissCor()
		{
			return null;
		}

		// Token: 0x0601F9DA RID: 129498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9DA")]
		[Address(RVA = "0x195A320", Offset = "0x1958F20", VA = "0x18195A320")]
		public void ToEndAnimation()
		{
		}

		// Token: 0x0601F9DB RID: 129499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F9DB")]
		[Address(RVA = "0x195A4A0", Offset = "0x19590A0", VA = "0x18195A4A0")]
		private IEnumerator _ApplyAnimation()
		{
			return null;
		}

		// Token: 0x0601F9DC RID: 129500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F9DC")]
		[Address(RVA = "0x195A550", Offset = "0x1959150", VA = "0x18195A550")]
		private Coroutine _CoroutineWithPage(IEnumerator coroutine)
		{
			return null;
		}

		// Token: 0x0601F9DD RID: 129501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9DD")]
		[Address(RVA = "0x195AFA0", Offset = "0x1959BA0", VA = "0x18195AFA0")]
		public RoguelikeRewardListView()
		{
		}

		// Token: 0x0402A959 RID: 174425
		[Token(Token = "0x402A959")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeRewardListLayout _listLayout;

		// Token: 0x0402A95A RID: 174426
		[Token(Token = "0x402A95A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIIntEvent _onClick;

		// Token: 0x0402A95B RID: 174427
		[Token(Token = "0x402A95B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _leaveBack;

		// Token: 0x0402A95C RID: 174428
		[Token(Token = "0x402A95C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402A95D RID: 174429
		[Token(Token = "0x402A95D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _transCompleteBtnHolder;

		// Token: 0x0402A960 RID: 174432
		[Token(Token = "0x402A960")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeRewardListViewModel m_cacheViewModel;

		// Token: 0x0402A961 RID: 174433
		[Token(Token = "0x402A961")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_panelBackShowTween;

		// Token: 0x0402A962 RID: 174434
		[Token(Token = "0x402A962")]
		[FieldOffset(Offset = "0x68")]
		private List<RoguelikeRewardItemViewModel> m_itemList;

		// Token: 0x0402A963 RID: 174435
		[Token(Token = "0x402A963")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeRewardExtraInfoFactory m_extraInfoFactory;

		// Token: 0x0402A964 RID: 174436
		[Token(Token = "0x402A964")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_finder;

		// Token: 0x0402A965 RID: 174437
		[Token(Token = "0x402A965")]
		[FieldOffset(Offset = "0x88")]
		private UIPageListener m_pageListener;

		// Token: 0x0402A966 RID: 174438
		[Token(Token = "0x402A966")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isEntryAnimPlayed;

		// Token: 0x0402A967 RID: 174439
		[Token(Token = "0x402A967")]
		[FieldOffset(Offset = "0x91")]
		private bool m_inited;

		// Token: 0x0402A968 RID: 174440
		[Token(Token = "0x402A968")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedTopicId;

		// Token: 0x0402A969 RID: 174441
		[Token(Token = "0x402A969")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiStyle;

		// Token: 0x0402A96A RID: 174442
		[Token(Token = "0x402A96A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_uiStyle;

		// Token: 0x0402A96B RID: 174443
		[Token(Token = "0x402A96B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onCompleteBtnClick;

		// Token: 0x0402A96C RID: 174444
		[Token(Token = "0x402A96C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onCompleteBtnClick;

		// Token: 0x0402A96D RID: 174445
		[Token(Token = "0x402A96D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetDisplayList;

		// Token: 0x0402A96E RID: 174446
		[Token(Token = "0x402A96E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_pageListener;

		// Token: 0x0402A96F RID: 174447
		[Token(Token = "0x402A96F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A970 RID: 174448
		[Token(Token = "0x402A970")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetRenderStatus;

		// Token: 0x0402A971 RID: 174449
		[Token(Token = "0x402A971")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderItemList;

		// Token: 0x0402A972 RID: 174450
		[Token(Token = "0x402A972")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402A973 RID: 174451
		[Token(Token = "0x402A973")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfFinish;

		// Token: 0x0402A974 RID: 174452
		[Token(Token = "0x402A974")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DismissCor;

		// Token: 0x0402A975 RID: 174453
		[Token(Token = "0x402A975")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ToEndAnimation;

		// Token: 0x0402A976 RID: 174454
		[Token(Token = "0x402A976")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ApplyAnimation;

		// Token: 0x0402A977 RID: 174455
		[Token(Token = "0x402A977")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CoroutineWithPage;

		// Token: 0x0402A978 RID: 174456
		[Token(Token = "0x402A978")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
