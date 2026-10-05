using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200492B RID: 18731
	[Token(Token = "0x200492B")]
	public class UIMedalDIYCardList : UICustomAdapterLayout<DIYMedalModel, UIMedalDIYCardView>, IHotfixable
	{
		// Token: 0x0601C3C7 RID: 115655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3C7")]
		[Address(RVA = "0x15B8D90", Offset = "0x15B7990", VA = "0x1815B8D90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C3C8 RID: 115656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3C8")]
		[Address(RVA = "0x15B89E0", Offset = "0x15B75E0", VA = "0x1815B89E0")]
		public void Render(IMedalDIYContext context, MedalDIYViewModel viewModel)
		{
		}

		// Token: 0x0601C3C9 RID: 115657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3C9")]
		[Address(RVA = "0x15B8D20", Offset = "0x15B7920", VA = "0x1815B8D20")]
		private void _CancelScrollDrag()
		{
		}

		// Token: 0x0601C3CA RID: 115658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3CA")]
		[Address(RVA = "0x15B9030", Offset = "0x15B7C30", VA = "0x1815B9030")]
		private void _OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601C3CB RID: 115659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3CB")]
		[Address(RVA = "0x15B8F90", Offset = "0x15B7B90", VA = "0x1815B8F90")]
		private void _OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601C3CC RID: 115660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3CC")]
		[Address(RVA = "0x15B90D0", Offset = "0x15B7CD0", VA = "0x1815B90D0")]
		private void _OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601C3CD RID: 115661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3CD")]
		[Address(RVA = "0x15B9170", Offset = "0x15B7D70", VA = "0x1815B9170")]
		private void _UpdateBkgTrans()
		{
		}

		// Token: 0x0601C3CE RID: 115662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3CE")]
		[Address(RVA = "0x15B9370", Offset = "0x15B7F70", VA = "0x1815B9370")]
		public UIMedalDIYCardList()
		{
		}

		// Token: 0x04024EEB RID: 151275
		[Token(Token = "0x4024EEB")]
		private const float BKG_MOVE_DUR = 0.16f;

		// Token: 0x04024EEC RID: 151276
		[Token(Token = "0x4024EEC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIWrappedScrollRect _scroll;

		// Token: 0x04024EED RID: 151277
		[Token(Token = "0x4024EED")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIMedalDIYCardView _cardPrefab;

		// Token: 0x04024EEE RID: 151278
		[Token(Token = "0x4024EEE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Rect _padding;

		// Token: 0x04024EEF RID: 151279
		[Token(Token = "0x4024EEF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Vector2 _spacing;

		// Token: 0x04024EF0 RID: 151280
		[Token(Token = "0x4024EF0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Vector2 _gridSize;

		// Token: 0x04024EF1 RID: 151281
		[Token(Token = "0x4024EF1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _bkgTrans;

		// Token: 0x04024EF2 RID: 151282
		[Token(Token = "0x4024EF2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _bkgHideY;

		// Token: 0x04024EF3 RID: 151283
		[Token(Token = "0x4024EF3")]
		[FieldOffset(Offset = "0xB8")]
		private IMedalDIYContext m_context;

		// Token: 0x04024EF4 RID: 151284
		[Token(Token = "0x4024EF4")]
		[FieldOffset(Offset = "0xC0")]
		private MedalDIYViewModel m_viewModel;

		// Token: 0x04024EF5 RID: 151285
		[Token(Token = "0x4024EF5")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_moveTween;

		// Token: 0x04024EF6 RID: 151286
		[Token(Token = "0x4024EF6")]
		[FieldOffset(Offset = "0xD0")]
		private UIMedalDIYCardList.InnerLayouter m_layouter;

		// Token: 0x04024EF7 RID: 151287
		[Token(Token = "0x4024EF7")]
		[FieldOffset(Offset = "0xD8")]
		private UIMedalDIYCardList.InnerAdapter m_adapter;

		// Token: 0x04024EF8 RID: 151288
		[Token(Token = "0x4024EF8")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_isInited;

		// Token: 0x04024EF9 RID: 151289
		[Token(Token = "0x4024EF9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024EFA RID: 151290
		[Token(Token = "0x4024EFA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024EFB RID: 151291
		[Token(Token = "0x4024EFB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CancelScrollDrag;

		// Token: 0x04024EFC RID: 151292
		[Token(Token = "0x4024EFC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnDrag;

		// Token: 0x04024EFD RID: 151293
		[Token(Token = "0x4024EFD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnBeginDrag;

		// Token: 0x04024EFE RID: 151294
		[Token(Token = "0x4024EFE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnEndDrag;

		// Token: 0x04024EFF RID: 151295
		[Token(Token = "0x4024EFF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateBkgTrans;

		// Token: 0x04024F00 RID: 151296
		[Token(Token = "0x4024F00")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200492C RID: 18732
		[Token(Token = "0x200492C")]
		private class InnerLayouter : UICustomGridLayouter<DIYMedalModel, UIMedalDIYCardView>
		{
			// Token: 0x0601C3D0 RID: 115664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3D0")]
			[Address(RVA = "0x15AD570", Offset = "0x15AC170", VA = "0x1815AD570")]
			public InnerLayouter(UIMedalDIYCardList closure)
			{
			}

			// Token: 0x0601C3D1 RID: 115665 RVA: 0x000A7A90 File Offset: 0x000A5C90
			[Token(Token = "0x601C3D1")]
			[Address(RVA = "0x15AC5C0", Offset = "0x15AB1C0", VA = "0x1815AC5C0", Slot = "6")]
			protected override GridPosition DataToOffset(DIYMedalModel data)
			{
				return default(GridPosition);
			}

			// Token: 0x0601C3D2 RID: 115666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3D2")]
			[Address(RVA = "0x15AC690", Offset = "0x15AB290", VA = "0x1815AC690", Slot = "8")]
			protected override void LayoutImmediatelyImpl()
			{
			}

			// Token: 0x0601C3D3 RID: 115667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3D3")]
			[Address(RVA = "0x15AC8F0", Offset = "0x15AB4F0", VA = "0x1815AC8F0", Slot = "7")]
			protected override void LayoutTransitionImpl()
			{
			}

			// Token: 0x0601C3D4 RID: 115668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3D4")]
			[Address(RVA = "0x15ACB60", Offset = "0x15AB760", VA = "0x1815ACB60")]
			private void _SetViewTransformProp(UICustomAdapterLayout<DIYMedalModel, UIMedalDIYCardView>.Layouter.LayoutElement ele, UICustomGridLayouter<DIYMedalModel, UIMedalDIYCardView>.LayoutMeta meta)
			{
			}

			// Token: 0x0601C3D5 RID: 115669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3D5")]
			[Address(RVA = "0x15AD080", Offset = "0x15ABC80", VA = "0x1815AD080")]
			private void _TransitionNewlyAdded(UICustomAdapterLayout<DIYMedalModel, UIMedalDIYCardView>.Layouter.LayoutElement ele, UICustomGridLayouter<DIYMedalModel, UIMedalDIYCardView>.LayoutMeta meta)
			{
			}

			// Token: 0x0601C3D6 RID: 115670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3D6")]
			[Address(RVA = "0x15AD310", Offset = "0x15ABF10", VA = "0x1815AD310")]
			private void _TransitionRemoved(UICustomAdapterLayout<DIYMedalModel, UIMedalDIYCardView>.Layouter.LayoutElement ele)
			{
			}

			// Token: 0x0601C3D7 RID: 115671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3D7")]
			[Address(RVA = "0x15ACDD0", Offset = "0x15AB9D0", VA = "0x1815ACDD0")]
			private void _TransitionMove(UICustomAdapterLayout<DIYMedalModel, UIMedalDIYCardView>.Layouter.LayoutElement ele, UICustomGridLayouter<DIYMedalModel, UIMedalDIYCardView>.LayoutMeta meta)
			{
			}

			// Token: 0x04024F01 RID: 151297
			[Token(Token = "0x4024F01")]
			private const float FAST_TWEEN_DUR = 0.16f;

			// Token: 0x04024F02 RID: 151298
			[Token(Token = "0x4024F02")]
			private const float ADD_REMOVE_ELE_BIAS = 80f;

			// Token: 0x04024F03 RID: 151299
			[Token(Token = "0x4024F03")]
			[FieldOffset(Offset = "0x70")]
			private UIMedalDIYCardList m_closure;

			// Token: 0x04024F04 RID: 151300
			[Token(Token = "0x4024F04")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04024F05 RID: 151301
			[Token(Token = "0x4024F05")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DataToOffset;

			// Token: 0x04024F06 RID: 151302
			[Token(Token = "0x4024F06")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_LayoutImmediatelyImpl;

			// Token: 0x04024F07 RID: 151303
			[Token(Token = "0x4024F07")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_LayoutTransitionImpl;

			// Token: 0x04024F08 RID: 151304
			[Token(Token = "0x4024F08")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__SetViewTransformProp;

			// Token: 0x04024F09 RID: 151305
			[Token(Token = "0x4024F09")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__TransitionNewlyAdded;

			// Token: 0x04024F0A RID: 151306
			[Token(Token = "0x4024F0A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__TransitionRemoved;

			// Token: 0x04024F0B RID: 151307
			[Token(Token = "0x4024F0B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__TransitionMove;
		}

		// Token: 0x02004930 RID: 18736
		[Token(Token = "0x2004930")]
		private class InnerAdapter : UICustomAdapterLayout<DIYMedalModel, UIMedalDIYCardView>.Adapter
		{
			// Token: 0x0601C3DE RID: 115678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3DE")]
			[Address(RVA = "0x15AC530", Offset = "0x15AB130", VA = "0x1815AC530")]
			public InnerAdapter(UIMedalDIYCardList closure)
			{
			}

			// Token: 0x0601C3DF RID: 115679 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C3DF")]
			[Address(RVA = "0x15ABF70", Offset = "0x15AAB70", VA = "0x1815ABF70", Slot = "6")]
			public override UIMedalDIYCardView CreateInst(DIYMedalModel data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x0601C3E0 RID: 115680 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C3E0")]
			[Address(RVA = "0x15AC2A0", Offset = "0x15AAEA0", VA = "0x1815AC2A0", Slot = "4")]
			public override IList<DIYMedalModel> GetData()
			{
				return null;
			}

			// Token: 0x0601C3E1 RID: 115681 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C3E1")]
			[Address(RVA = "0x15AC320", Offset = "0x15AAF20", VA = "0x1815AC320", Slot = "5")]
			public override string GetId(DIYMedalModel data)
			{
				return null;
			}

			// Token: 0x0601C3E2 RID: 115682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3E2")]
			[Address(RVA = "0x15AC3A0", Offset = "0x15AAFA0", VA = "0x1815AC3A0", Slot = "7")]
			public override void UpdateView(UIMedalDIYCardView view, DIYMedalModel data)
			{
			}

			// Token: 0x04024F17 RID: 151319
			[Token(Token = "0x4024F17")]
			[FieldOffset(Offset = "0x20")]
			private UIMedalDIYCardList m_closure;

			// Token: 0x04024F18 RID: 151320
			[Token(Token = "0x4024F18")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04024F19 RID: 151321
			[Token(Token = "0x4024F19")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x04024F1A RID: 151322
			[Token(Token = "0x4024F1A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetData;

			// Token: 0x04024F1B RID: 151323
			[Token(Token = "0x4024F1B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x04024F1C RID: 151324
			[Token(Token = "0x4024F1C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UpdateView;
		}
	}
}
