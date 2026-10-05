using System;
using System.Collections.Generic;
using AdvancedInspector;
using EaseFunctions;
using Il2CppDummyDll;
using Torappu.UI.CustomLayouter;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053E9 RID: 21481
	[Token(Token = "0x20053E9")]
	public class RoguelikeRewardListLayout : UICustomAdapterLayout<RoguelikeRewardItemViewModel, RoguelikeRewardItemHolder>
	{
		// Token: 0x0601F9BB RID: 129467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9BB")]
		[Address(RVA = "0x1959540", Offset = "0x1958140", VA = "0x181959540")]
		public void InitLayout(RoguelikeRewardListLayout.Options options)
		{
		}

		// Token: 0x0601F9BC RID: 129468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9BC")]
		[Address(RVA = "0x1959830", Offset = "0x1958430", VA = "0x181959830")]
		public void UpdateData(IList<RoguelikeRewardItemViewModel> itemList, bool showImmediately = true, bool newAddItemWithDelay = true)
		{
		}

		// Token: 0x0601F9BD RID: 129469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9BD")]
		[Address(RVA = "0x1959C20", Offset = "0x1958820", VA = "0x181959C20")]
		public RoguelikeRewardListLayout()
		{
		}

		// Token: 0x0402A929 RID: 174377
		[Token(Token = "0x402A929")]
		private const float ADDITIONAL_ITEM_SHOW_DELAY = 0.5f;

		// Token: 0x0402A92A RID: 174378
		[Token(Token = "0x402A92A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Rect _padding;

		// Token: 0x0402A92B RID: 174379
		[Token(Token = "0x402A92B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _spacing;

		// Token: 0x0402A92C RID: 174380
		[Token(Token = "0x402A92C")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[Group("Tween")]
		private float _itemMoveDur;

		// Token: 0x0402A92D RID: 174381
		[Token(Token = "0x402A92D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Tween")]
		private float _itemMoveDelay;

		// Token: 0x0402A92E RID: 174382
		[Token(Token = "0x402A92E")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Group("Tween")]
		private float _itemFadeDur;

		// Token: 0x0402A92F RID: 174383
		[Token(Token = "0x402A92F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Tween")]
		private float _itemFadeMoveBias;

		// Token: 0x0402A930 RID: 174384
		[Token(Token = "0x402A930")]
		[FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public RoguelikeRewardItemHolder itemPrefab;

		// Token: 0x0402A931 RID: 174385
		[Token(Token = "0x402A931")]
		[FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		public Vector2 gridSize;

		// Token: 0x0402A932 RID: 174386
		[Token(Token = "0x402A932")]
		[FieldOffset(Offset = "0xB0")]
		private List<RoguelikeRewardItemViewModel> m_itemList;

		// Token: 0x0402A933 RID: 174387
		[Token(Token = "0x402A933")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<int, int> m_gridIndexMap;

		// Token: 0x0402A934 RID: 174388
		[Token(Token = "0x402A934")]
		[FieldOffset(Offset = "0xC0")]
		private string m_topicId;

		// Token: 0x0402A935 RID: 174389
		[Token(Token = "0x402A935")]
		[FieldOffset(Offset = "0xC8")]
		private UIIntEvent m_onItemClicked;

		// Token: 0x0402A936 RID: 174390
		[Token(Token = "0x402A936")]
		[FieldOffset(Offset = "0xD0")]
		private RoguelikeRewardListLayout.InnerAdapter m_adapter;

		// Token: 0x0402A937 RID: 174391
		[Token(Token = "0x402A937")]
		[FieldOffset(Offset = "0xD8")]
		private RoguelikeRewardListLayout.InnerLayouter m_layouter;

		// Token: 0x0402A938 RID: 174392
		[Token(Token = "0x402A938")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_showImmediately;

		// Token: 0x0402A939 RID: 174393
		[Token(Token = "0x402A939")]
		[FieldOffset(Offset = "0xE1")]
		private bool m_newAddItemWithDelay;

		// Token: 0x0402A93A RID: 174394
		[Token(Token = "0x402A93A")]
		[FieldOffset(Offset = "0xE2")]
		private bool m_isInited;

		// Token: 0x0402A93B RID: 174395
		[Token(Token = "0x402A93B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitLayout;

		// Token: 0x0402A93C RID: 174396
		[Token(Token = "0x402A93C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0402A93D RID: 174397
		[Token(Token = "0x402A93D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020053EA RID: 21482
		[Token(Token = "0x20053EA")]
		public struct Options
		{
			// Token: 0x0402A93E RID: 174398
			[Token(Token = "0x402A93E")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x0402A93F RID: 174399
			[Token(Token = "0x402A93F")]
			[FieldOffset(Offset = "0x8")]
			public UIIntEvent onItemClicked;
		}

		// Token: 0x020053EB RID: 21483
		[Token(Token = "0x20053EB")]
		private class InnerLayouter : CustomAutoAlignGridLayouter<RoguelikeRewardItemViewModel, RoguelikeRewardItemHolder>
		{
			// Token: 0x0601F9BE RID: 129470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F9BE")]
			[Address(RVA = "0x194FB80", Offset = "0x194E780", VA = "0x18194FB80")]
			public InnerLayouter(RoguelikeRewardListLayout closure)
			{
			}

			// Token: 0x0601F9BF RID: 129471 RVA: 0x000B2680 File Offset: 0x000B0880
			[Token(Token = "0x601F9BF")]
			[Address(RVA = "0x194F3B0", Offset = "0x194DFB0", VA = "0x18194F3B0", Slot = "6")]
			protected override GridPosition DataToOffset(RoguelikeRewardItemViewModel data)
			{
				return default(GridPosition);
			}

			// Token: 0x0601F9C0 RID: 129472 RVA: 0x000B2698 File Offset: 0x000B0898
			[Token(Token = "0x601F9C0")]
			[Address(RVA = "0x194F4E0", Offset = "0x194E0E0", VA = "0x18194F4E0", Slot = "11")]
			protected override float GetMoveDuration()
			{
				return 0f;
			}

			// Token: 0x0601F9C1 RID: 129473 RVA: 0x000B26B0 File Offset: 0x000B08B0
			[Token(Token = "0x601F9C1")]
			[Address(RVA = "0x194F470", Offset = "0x194E070", VA = "0x18194F470", Slot = "12")]
			protected override float GetMoveDelay()
			{
				return 0f;
			}

			// Token: 0x0601F9C2 RID: 129474 RVA: 0x000B26C8 File Offset: 0x000B08C8
			[Token(Token = "0x601F9C2")]
			[Address(RVA = "0x194F550", Offset = "0x194E150", VA = "0x18194F550", Slot = "13")]
			protected override Interpolator.EaseType GetMoveEase()
			{
				return Interpolator.EaseType.unset;
			}

			// Token: 0x0601F9C3 RID: 129475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F9C3")]
			[Address(RVA = "0x194F5B0", Offset = "0x194E1B0", VA = "0x18194F5B0", Slot = "15")]
			protected override void NewlyAddViewTransition(UICustomAdapterLayout<RoguelikeRewardItemViewModel, RoguelikeRewardItemHolder>.Layouter.LayoutElement ele, UICustomGridLayouter<RoguelikeRewardItemViewModel, RoguelikeRewardItemHolder>.LayoutMeta meta)
			{
			}

			// Token: 0x0601F9C4 RID: 129476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F9C4")]
			[Address(RVA = "0x194F920", Offset = "0x194E520", VA = "0x18194F920", Slot = "14")]
			protected override void RemoveViewTransition(UICustomAdapterLayout<RoguelikeRewardItemViewModel, RoguelikeRewardItemHolder>.Layouter.LayoutElement ele)
			{
			}

			// Token: 0x0402A940 RID: 174400
			[Token(Token = "0x402A940")]
			[FieldOffset(Offset = "0x70")]
			private RoguelikeRewardListLayout m_closure;

			// Token: 0x0402A941 RID: 174401
			[Token(Token = "0x402A941")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A942 RID: 174402
			[Token(Token = "0x402A942")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DataToOffset;

			// Token: 0x0402A943 RID: 174403
			[Token(Token = "0x402A943")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetMoveDuration;

			// Token: 0x0402A944 RID: 174404
			[Token(Token = "0x402A944")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetMoveDelay;

			// Token: 0x0402A945 RID: 174405
			[Token(Token = "0x402A945")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetMoveEase;

			// Token: 0x0402A946 RID: 174406
			[Token(Token = "0x402A946")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_NewlyAddViewTransition;

			// Token: 0x0402A947 RID: 174407
			[Token(Token = "0x402A947")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_RemoveViewTransition;
		}

		// Token: 0x020053EE RID: 21486
		[Token(Token = "0x20053EE")]
		private class InnerAdapter : UICustomAdapterLayout<RoguelikeRewardItemViewModel, RoguelikeRewardItemHolder>.Adapter
		{
			// Token: 0x0601F9C9 RID: 129481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F9C9")]
			[Address(RVA = "0x194F270", Offset = "0x194DE70", VA = "0x18194F270")]
			public InnerAdapter(string topicId, RoguelikeRewardItemHolder prefab)
			{
			}

			// Token: 0x0601F9CA RID: 129482 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F9CA")]
			[Address(RVA = "0x194EFE0", Offset = "0x194DBE0", VA = "0x18194EFE0", Slot = "6")]
			public override RoguelikeRewardItemHolder CreateInst(RoguelikeRewardItemViewModel data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x0601F9CB RID: 129483 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F9CB")]
			[Address(RVA = "0x194F0E0", Offset = "0x194DCE0", VA = "0x18194F0E0", Slot = "4")]
			public override IList<RoguelikeRewardItemViewModel> GetData()
			{
				return null;
			}

			// Token: 0x0601F9CC RID: 129484 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F9CC")]
			[Address(RVA = "0x194F140", Offset = "0x194DD40", VA = "0x18194F140", Slot = "5")]
			public override string GetId(RoguelikeRewardItemViewModel data)
			{
				return null;
			}

			// Token: 0x0601F9CD RID: 129485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F9CD")]
			[Address(RVA = "0x194F1C0", Offset = "0x194DDC0", VA = "0x18194F1C0", Slot = "7")]
			public override void UpdateView(RoguelikeRewardItemHolder view, RoguelikeRewardItemViewModel data)
			{
			}

			// Token: 0x0402A950 RID: 174416
			[Token(Token = "0x402A950")]
			[FieldOffset(Offset = "0x20")]
			public UIIntEvent onClick;

			// Token: 0x0402A951 RID: 174417
			[Token(Token = "0x402A951")]
			[FieldOffset(Offset = "0x28")]
			public List<RoguelikeRewardItemViewModel> itemList;

			// Token: 0x0402A952 RID: 174418
			[Token(Token = "0x402A952")]
			[FieldOffset(Offset = "0x30")]
			private string m_topicId;

			// Token: 0x0402A953 RID: 174419
			[Token(Token = "0x402A953")]
			[FieldOffset(Offset = "0x38")]
			private RoguelikeRewardItemHolder m_prefab;

			// Token: 0x0402A954 RID: 174420
			[Token(Token = "0x402A954")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A955 RID: 174421
			[Token(Token = "0x402A955")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x0402A956 RID: 174422
			[Token(Token = "0x402A956")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetData;

			// Token: 0x0402A957 RID: 174423
			[Token(Token = "0x402A957")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x0402A958 RID: 174424
			[Token(Token = "0x402A958")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UpdateView;
		}
	}
}
