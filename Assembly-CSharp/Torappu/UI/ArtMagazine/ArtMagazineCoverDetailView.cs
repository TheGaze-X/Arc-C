using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200652D RID: 25901
	[Token(Token = "0x200652D")]
	public class ArtMagazineCoverDetailView : DataBinder<ArtMagazineCoverDetailViewModelProperty>
	{
		// Token: 0x06025395 RID: 152469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025395")]
		[Address(RVA = "0x202AA30", Offset = "0x2029630", VA = "0x18202AA30", Slot = "7")]
		public override void OnValueChanged(ArtMagazineCoverDetailViewModelProperty property)
		{
		}

		// Token: 0x06025396 RID: 152470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025396")]
		[Address(RVA = "0x202B120", Offset = "0x2029D20", VA = "0x18202B120")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025397 RID: 152471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025397")]
		[Address(RVA = "0x202B450", Offset = "0x202A050", VA = "0x18202B450")]
		private void _MoveToIndex(int index, bool fastMode)
		{
		}

		// Token: 0x06025398 RID: 152472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025398")]
		[Address(RVA = "0x202B520", Offset = "0x202A120", VA = "0x18202B520")]
		private void _RefreshInditPartState(ArtMagazineCoverDetailViewModel viewModel, bool fastModeInditBtnSwitchAnim)
		{
		}

		// Token: 0x06025399 RID: 152473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025399")]
		[Address(RVA = "0x202A910", Offset = "0x2029510", VA = "0x18202A910")]
		public void EventOnLeftArrowClick()
		{
		}

		// Token: 0x0602539A RID: 152474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602539A")]
		[Address(RVA = "0x202A9A0", Offset = "0x20295A0", VA = "0x18202A9A0")]
		public void EventOnRightArrowClick()
		{
		}

		// Token: 0x0602539B RID: 152475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602539B")]
		[Address(RVA = "0x202A880", Offset = "0x2029480", VA = "0x18202A880")]
		public void EventOnInditBtnClick()
		{
		}

		// Token: 0x0602539C RID: 152476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602539C")]
		[Address(RVA = "0x202A7F0", Offset = "0x20293F0", VA = "0x18202A7F0")]
		public void EventOnEditBtnClick()
		{
		}

		// Token: 0x0602539D RID: 152477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602539D")]
		[Address(RVA = "0x202B9A0", Offset = "0x202A5A0", VA = "0x18202B9A0")]
		public ArtMagazineCoverDetailView()
		{
		}

		// Token: 0x0403436C RID: 213868
		[Token(Token = "0x403436C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Indit part")]
		private GameObject _objInditInfoPart;

		// Token: 0x0403436D RID: 213869
		[Token(Token = "0x403436D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Indit part")]
		private GameObject _objInditedPart;

		// Token: 0x0403436E RID: 213870
		[Token(Token = "0x403436E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Indit part")]
		private Text _txtInditIndex;

		// Token: 0x0403436F RID: 213871
		[Token(Token = "0x403436F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Indit part")]
		private Text _txtInditInfo;

		// Token: 0x04034370 RID: 213872
		[Token(Token = "0x4034370")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Indit part")]
		private Text _txtInditNum;

		// Token: 0x04034371 RID: 213873
		[Token(Token = "0x4034371")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Indit part")]
		private GameObject _objCanInditPart;

		// Token: 0x04034372 RID: 213874
		[Token(Token = "0x4034372")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Indit part")]
		private Text _txtCanInditInfo;

		// Token: 0x04034373 RID: 213875
		[Token(Token = "0x4034373")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Indit part")]
		private Text _txtCanInditNum;

		// Token: 0x04034374 RID: 213876
		[Token(Token = "0x4034374")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Indit part")]
		private GameObject _objFullInditPart;

		// Token: 0x04034375 RID: 213877
		[Token(Token = "0x4034375")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Indit part")]
		private Text _txtFullInfo;

		// Token: 0x04034376 RID: 213878
		[Token(Token = "0x4034376")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Indit part")]
		private Text _txtFullInditNum;

		// Token: 0x04034377 RID: 213879
		[Token(Token = "0x4034377")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Indit part")]
		private UIAnimationLocation _animInditPart;

		// Token: 0x04034378 RID: 213880
		[Token(Token = "0x4034378")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Edit part")]
		private GameObject _objEditPart;

		// Token: 0x04034379 RID: 213881
		[Token(Token = "0x4034379")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Arrow part")]
		private CanvasGroup _canvasArrowLeft;

		// Token: 0x0403437A RID: 213882
		[Token(Token = "0x403437A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Arrow part")]
		private CanvasGroup _canvasArrowRight;

		// Token: 0x0403437B RID: 213883
		[Token(Token = "0x403437B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Leaf Info part")]
		private GameObject _objIndexPart;

		// Token: 0x0403437C RID: 213884
		[Token(Token = "0x403437C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Leaf Info part")]
		private Text _txtCurIndex;

		// Token: 0x0403437D RID: 213885
		[Token(Token = "0x403437D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Leaf Info part")]
		private Text _txtTotalCount;

		// Token: 0x0403437E RID: 213886
		[Token(Token = "0x403437E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Leaf Info part")]
		private Text _txtLeafName;

		// Token: 0x0403437F RID: 213887
		[Token(Token = "0x403437F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Scroll part")]
		private ArtMagazineCoverDetailItemView _detailItemPrefab;

		// Token: 0x04034380 RID: 213888
		[Token(Token = "0x4034380")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Scroll part")]
		private ScrollViewPager _scrollViewPager;

		// Token: 0x04034381 RID: 213889
		[Token(Token = "0x4034381")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Scroll part")]
		private UIRecycleLayoutGroup _leafsContent;

		// Token: 0x04034382 RID: 213890
		[Token(Token = "0x4034382")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_hasInited;

		// Token: 0x04034383 RID: 213891
		[Token(Token = "0x4034383")]
		[FieldOffset(Offset = "0xE0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034384 RID: 213892
		[Token(Token = "0x4034384")]
		[FieldOffset(Offset = "0xF0")]
		private FadeSwitchTween m_tweenArrowLeft;

		// Token: 0x04034385 RID: 213893
		[Token(Token = "0x4034385")]
		[FieldOffset(Offset = "0xF8")]
		private FadeSwitchTween m_tweenArrowRight;

		// Token: 0x04034386 RID: 213894
		[Token(Token = "0x4034386")]
		[FieldOffset(Offset = "0x100")]
		private ArtMagazineCoverDetailView.LeafDetailItemAdapter m_detailItemAdapter;

		// Token: 0x04034387 RID: 213895
		[Token(Token = "0x4034387")]
		[FieldOffset(Offset = "0x108")]
		private UISwitchTween m_inditPartSwitchTween;

		// Token: 0x04034388 RID: 213896
		[Token(Token = "0x4034388")]
		[FieldOffset(Offset = "0x110")]
		private int m_enterSeqNum;

		// Token: 0x04034389 RID: 213897
		[Token(Token = "0x4034389")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403438A RID: 213898
		[Token(Token = "0x403438A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403438B RID: 213899
		[Token(Token = "0x403438B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__MoveToIndex;

		// Token: 0x0403438C RID: 213900
		[Token(Token = "0x403438C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshInditPartState;

		// Token: 0x0403438D RID: 213901
		[Token(Token = "0x403438D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnLeftArrowClick;

		// Token: 0x0403438E RID: 213902
		[Token(Token = "0x403438E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnRightArrowClick;

		// Token: 0x0403438F RID: 213903
		[Token(Token = "0x403438F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnInditBtnClick;

		// Token: 0x04034390 RID: 213904
		[Token(Token = "0x4034390")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnEditBtnClick;

		// Token: 0x04034391 RID: 213905
		[Token(Token = "0x4034391")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200652E RID: 25902
		[Token(Token = "0x200652E")]
		private class LeafDetailItemAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0602539E RID: 152478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602539E")]
			[Address(RVA = "0x20405A0", Offset = "0x203F1A0", VA = "0x1820405A0")]
			public LeafDetailItemAdapter(ArtMagazineCoverDetailView closure)
			{
			}

			// Token: 0x0602539F RID: 152479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602539F")]
			[Address(RVA = "0x2040170", Offset = "0x203ED70", VA = "0x182040170", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x060253A0 RID: 152480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60253A0")]
			[Address(RVA = "0x20402A0", Offset = "0x203EEA0", VA = "0x1820402A0")]
			public void RebuildList(ArtMagazineCoverDetailViewModel model)
			{
			}

			// Token: 0x04034392 RID: 213906
			[Token(Token = "0x4034392")]
			[FieldOffset(Offset = "0x18")]
			private ArtMagazineCoverDetailView m_closure;

			// Token: 0x04034393 RID: 213907
			[Token(Token = "0x4034393")]
			[FieldOffset(Offset = "0x20")]
			private List<ArtMagazineCoverDetailItemView.VirtualView> m_cells;

			// Token: 0x04034394 RID: 213908
			[Token(Token = "0x4034394")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04034395 RID: 213909
			[Token(Token = "0x4034395")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x04034396 RID: 213910
			[Token(Token = "0x4034396")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildList;
		}
	}
}
