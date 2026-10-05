using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200651F RID: 25887
	[Token(Token = "0x200651F")]
	public class ArtMagazineCoverFrontUIView : DataBinder<ArtMagazineCoverViewModelProperty>
	{
		// Token: 0x0602534D RID: 152397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602534D")]
		[Address(RVA = "0x202CE20", Offset = "0x202BA20", VA = "0x18202CE20", Slot = "7")]
		public override void OnValueChanged(ArtMagazineCoverViewModelProperty property)
		{
		}

		// Token: 0x0602534E RID: 152398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602534E")]
		[Address(RVA = "0x202D3C0", Offset = "0x202BFC0", VA = "0x18202D3C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602534F RID: 152399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602534F")]
		[Address(RVA = "0x202D570", Offset = "0x202C170", VA = "0x18202D570")]
		private void _TryPlayEnterAnim()
		{
		}

		// Token: 0x06025350 RID: 152400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025350")]
		[Address(RVA = "0x202D4F0", Offset = "0x202C0F0", VA = "0x18202D4F0")]
		private void _KillEnterAnimIfNecessary()
		{
		}

		// Token: 0x06025351 RID: 152401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025351")]
		[Address(RVA = "0x202CD90", Offset = "0x202B990", VA = "0x18202CD90")]
		public void EventOnNameCardPreviewClick()
		{
		}

		// Token: 0x06025352 RID: 152402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025352")]
		[Address(RVA = "0x202CCE0", Offset = "0x202B8E0", VA = "0x18202CCE0")]
		public void EventOnLeafOverviewBtnClick()
		{
		}

		// Token: 0x06025353 RID: 152403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025353")]
		[Address(RVA = "0x202D6D0", Offset = "0x202C2D0", VA = "0x18202D6D0")]
		public ArtMagazineCoverFrontUIView()
		{
		}

		// Token: 0x040342E7 RID: 213735
		[Token(Token = "0x40342E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Name Card Preview")]
		private GameObject _objNameCardPreviewBtn;

		// Token: 0x040342E8 RID: 213736
		[Token(Token = "0x40342E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Display Count")]
		private GameObject _objDisplayCountNormalBg;

		// Token: 0x040342E9 RID: 213737
		[Token(Token = "0x40342E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Display Count")]
		private GameObject _objDisplayCountMaxBg;

		// Token: 0x040342EA RID: 213738
		[Token(Token = "0x40342EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Display Count")]
		private Text _txtCurrentCount;

		// Token: 0x040342EB RID: 213739
		[Token(Token = "0x40342EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Display Count")]
		private Text _txtLimitCount;

		// Token: 0x040342EC RID: 213740
		[Token(Token = "0x40342EC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Display Name")]
		private SimpleLayoutContent _leafNameList;

		// Token: 0x040342ED RID: 213741
		[Token(Token = "0x40342ED")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Overview")]
		private GameObject _objNewLeafsTips;

		// Token: 0x040342EE RID: 213742
		[Token(Token = "0x40342EE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _animEnter;

		// Token: 0x040342EF RID: 213743
		[Token(Token = "0x40342EF")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x040342F0 RID: 213744
		[Token(Token = "0x40342F0")]
		[FieldOffset(Offset = "0x69")]
		private bool m_hasLeafsSlotDisplay;

		// Token: 0x040342F1 RID: 213745
		[Token(Token = "0x40342F1")]
		[FieldOffset(Offset = "0x70")]
		private List<ArtMagazineCoverLeafItemViewModel> m_leafItemViewModels;

		// Token: 0x040342F2 RID: 213746
		[Token(Token = "0x40342F2")]
		[FieldOffset(Offset = "0x78")]
		private ArtMagazineCoverFrontUIView.LeafNameListAdapter m_leafNameAdapter;

		// Token: 0x040342F3 RID: 213747
		[Token(Token = "0x40342F3")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040342F4 RID: 213748
		[Token(Token = "0x40342F4")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasEnterAnimPlayed;

		// Token: 0x040342F5 RID: 213749
		[Token(Token = "0x40342F5")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_enterAnim;

		// Token: 0x040342F6 RID: 213750
		[Token(Token = "0x40342F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040342F7 RID: 213751
		[Token(Token = "0x40342F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040342F8 RID: 213752
		[Token(Token = "0x40342F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryPlayEnterAnim;

		// Token: 0x040342F9 RID: 213753
		[Token(Token = "0x40342F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__KillEnterAnimIfNecessary;

		// Token: 0x040342FA RID: 213754
		[Token(Token = "0x40342FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnNameCardPreviewClick;

		// Token: 0x040342FB RID: 213755
		[Token(Token = "0x40342FB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnLeafOverviewBtnClick;

		// Token: 0x040342FC RID: 213756
		[Token(Token = "0x40342FC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006520 RID: 25888
		[Token(Token = "0x2006520")]
		private class LeafNameListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06025354 RID: 152404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025354")]
			[Address(RVA = "0x2040DF0", Offset = "0x203F9F0", VA = "0x182040DF0")]
			public LeafNameListAdapter(ArtMagazineCoverFrontUIView closure)
			{
			}

			// Token: 0x170057CE RID: 22478
			// (get) Token: 0x06025355 RID: 152405 RVA: 0x000C7020 File Offset: 0x000C5220
			[Token(Token = "0x170057CE")]
			public override int count
			{
				[Token(Token = "0x6025355")]
				[Address(RVA = "0x2040E70", Offset = "0x203FA70", VA = "0x182040E70", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06025356 RID: 152406 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025356")]
			[Address(RVA = "0x2040B40", Offset = "0x203F740", VA = "0x182040B40", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040342FD RID: 213757
			[Token(Token = "0x40342FD")]
			[FieldOffset(Offset = "0x20")]
			private ArtMagazineCoverFrontUIView m_closure;

			// Token: 0x040342FE RID: 213758
			[Token(Token = "0x40342FE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040342FF RID: 213759
			[Token(Token = "0x40342FF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04034300 RID: 213760
			[Token(Token = "0x4034300")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
