using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02007005 RID: 28677
	[Token(Token = "0x2007005")]
	public class ActMultiV3StageListView : DataBinder<ActMultiV3StageListProperty>
	{
		// Token: 0x06028B63 RID: 166755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B63")]
		[Address(RVA = "0x2414CD0", Offset = "0x24138D0", VA = "0x182414CD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028B64 RID: 166756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B64")]
		[Address(RVA = "0x2414530", Offset = "0x2413130", VA = "0x182414530", Slot = "7")]
		public override void OnValueChanged(ActMultiV3StageListProperty property)
		{
		}

		// Token: 0x06028B65 RID: 166757 RVA: 0x000D2B88 File Offset: 0x000D0D88
		[Token(Token = "0x6028B65")]
		[Address(RVA = "0x2414B50", Offset = "0x2413750", VA = "0x182414B50")]
		private UIAnimationLocation _GetDiffAnim(ActMultiV3MapDiffType diffType)
		{
			return default(UIAnimationLocation);
		}

		// Token: 0x06028B66 RID: 166758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B66")]
		[Address(RVA = "0x24143F0", Offset = "0x2412FF0", VA = "0x1824143F0")]
		public void OnBackBtnClicked()
		{
		}

		// Token: 0x06028B67 RID: 166759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B67")]
		[Address(RVA = "0x2414490", Offset = "0x2413090", VA = "0x182414490")]
		public void OnInfoBtnClicked()
		{
		}

		// Token: 0x06028B68 RID: 166760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B68")]
		[Address(RVA = "0x2414DF0", Offset = "0x24139F0", VA = "0x182414DF0")]
		public ActMultiV3StageListView()
		{
		}

		// Token: 0x0403A07F RID: 237695
		[Token(Token = "0x403A07F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _modeAnim;

		// Token: 0x0403A080 RID: 237696
		[Token(Token = "0x403A080")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActMultiV3StageListRowView _rowViewPrefab;

		// Token: 0x0403A081 RID: 237697
		[Token(Token = "0x403A081")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _layout;

		// Token: 0x0403A082 RID: 237698
		[Token(Token = "0x403A082")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ActMultiV3StageListTabView[] _tabViews;

		// Token: 0x0403A083 RID: 237699
		[Token(Token = "0x403A083")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _pnlClose;

		// Token: 0x0403A084 RID: 237700
		[Token(Token = "0x403A084")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ActMultiV3StageListView.AnimConfig[] _animConfigs;

		// Token: 0x0403A085 RID: 237701
		[Token(Token = "0x403A085")]
		[FieldOffset(Offset = "0x58")]
		private ActMultiV3StageListViewModel.ViewMode m_cachedViewMode;

		// Token: 0x0403A086 RID: 237702
		[Token(Token = "0x403A086")]
		[FieldOffset(Offset = "0x60")]
		private ActMultiV3StageListViewModel m_cachedViewModel;

		// Token: 0x0403A087 RID: 237703
		[Token(Token = "0x403A087")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x0403A088 RID: 237704
		[Token(Token = "0x403A088")]
		[FieldOffset(Offset = "0x70")]
		private ActMultiV3StageListView.Adapter m_adapter;

		// Token: 0x0403A089 RID: 237705
		[Token(Token = "0x403A089")]
		[FieldOffset(Offset = "0x78")]
		private ActMultiV3MapDiffType m_cachedDiffType;

		// Token: 0x0403A08A RID: 237706
		[Token(Token = "0x403A08A")]
		[FieldOffset(Offset = "0x7C")]
		private int m_cachedInitSeqNum;

		// Token: 0x0403A08B RID: 237707
		[Token(Token = "0x403A08B")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_diffAnimTween;

		// Token: 0x0403A08C RID: 237708
		[Token(Token = "0x403A08C")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403A08D RID: 237709
		[Token(Token = "0x403A08D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A08E RID: 237710
		[Token(Token = "0x403A08E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403A08F RID: 237711
		[Token(Token = "0x403A08F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetDiffAnim;

		// Token: 0x0403A090 RID: 237712
		[Token(Token = "0x403A090")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackBtnClicked;

		// Token: 0x0403A091 RID: 237713
		[Token(Token = "0x403A091")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInfoBtnClicked;

		// Token: 0x0403A092 RID: 237714
		[Token(Token = "0x403A092")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007006 RID: 28678
		[Token(Token = "0x2007006")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<ActMultiV3StageListRowView>
		{
			// Token: 0x06028B69 RID: 166761 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028B69")]
			[Address(RVA = "0x241ADE0", Offset = "0x24199E0", VA = "0x18241ADE0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06028B6A RID: 166762 RVA: 0x000D2BA0 File Offset: 0x000D0DA0
			[Token(Token = "0x6028B6A")]
			[Address(RVA = "0x241AE40", Offset = "0x2419A40", VA = "0x18241AE40", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06028B6B RID: 166763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B6B")]
			[Address(RVA = "0x241AEB0", Offset = "0x2419AB0", VA = "0x18241AEB0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06028B6C RID: 166764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B6C")]
			[Address(RVA = "0x241B070", Offset = "0x2419C70", VA = "0x18241B070", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06028B6D RID: 166765 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B6D")]
			[Address(RVA = "0x241B0D0", Offset = "0x2419CD0", VA = "0x18241B0D0")]
			public VirtualView()
			{
			}

			// Token: 0x0403A093 RID: 237715
			[Token(Token = "0x403A093")]
			private const float PERFER_SIZE_WITH_TITLE = 226f;

			// Token: 0x0403A094 RID: 237716
			[Token(Token = "0x403A094")]
			private const float PERFER_SIZE_WITHOUT_TITLE = 142f;

			// Token: 0x0403A095 RID: 237717
			[Token(Token = "0x403A095")]
			[FieldOffset(Offset = "0x20")]
			public GameObject rowPrefab;

			// Token: 0x0403A096 RID: 237718
			[Token(Token = "0x403A096")]
			[FieldOffset(Offset = "0x28")]
			public bool isFirstRow;

			// Token: 0x0403A097 RID: 237719
			[Token(Token = "0x403A097")]
			[FieldOffset(Offset = "0x30")]
			public List<ActMultiV3StageModeGroupTitleViewModel> rowModeTypeList;

			// Token: 0x0403A098 RID: 237720
			[Token(Token = "0x403A098")]
			[FieldOffset(Offset = "0x38")]
			public ListDict<string, ActMultiV3StageItemViewModel> stages;

			// Token: 0x0403A099 RID: 237721
			[Token(Token = "0x403A099")]
			[FieldOffset(Offset = "0x40")]
			public ActMultiV3StageListViewModel stageListViewModel;

			// Token: 0x0403A09A RID: 237722
			[Token(Token = "0x403A09A")]
			[FieldOffset(Offset = "0x48")]
			public int startIndex;

			// Token: 0x0403A09B RID: 237723
			[Token(Token = "0x403A09B")]
			[FieldOffset(Offset = "0x4C")]
			public int endIndex;

			// Token: 0x0403A09C RID: 237724
			[Token(Token = "0x403A09C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0403A09D RID: 237725
			[Token(Token = "0x403A09D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0403A09E RID: 237726
			[Token(Token = "0x403A09E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0403A09F RID: 237727
			[Token(Token = "0x403A09F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0403A0A0 RID: 237728
			[Token(Token = "0x403A0A0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02007007 RID: 28679
		[Token(Token = "0x2007007")]
		public class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x06028B6E RID: 166766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B6E")]
			[Address(RVA = "0x2418C40", Offset = "0x2417840", VA = "0x182418C40")]
			public Adapter(ActMultiV3StageListView closure)
			{
			}

			// Token: 0x06028B6F RID: 166767 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B6F")]
			[Address(RVA = "0x2418820", Offset = "0x2417420", VA = "0x182418820")]
			private void _GenerateViewsInModeGroup(ActMultiV3StageModeGroupViewModel modeGroupViewModel, IList<UIRecycleLayoutAdapter.IVirtualView> res)
			{
			}

			// Token: 0x06028B70 RID: 166768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028B70")]
			[Address(RVA = "0x2417F40", Offset = "0x2416B40", VA = "0x182417F40", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x06028B71 RID: 166769 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B71")]
			[Address(RVA = "0x2418080", Offset = "0x2416C80", VA = "0x182418080")]
			public void RebuildList()
			{
			}

			// Token: 0x0403A0A1 RID: 237729
			[Token(Token = "0x403A0A1")]
			private const int COLUMNS_PER_ROW = 5;

			// Token: 0x0403A0A2 RID: 237730
			[Token(Token = "0x403A0A2")]
			[FieldOffset(Offset = "0x18")]
			private ActMultiV3StageListView m_closure;

			// Token: 0x0403A0A3 RID: 237731
			[Token(Token = "0x403A0A3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403A0A4 RID: 237732
			[Token(Token = "0x403A0A4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__GenerateViewsInModeGroup;

			// Token: 0x0403A0A5 RID: 237733
			[Token(Token = "0x403A0A5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0403A0A6 RID: 237734
			[Token(Token = "0x403A0A6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RebuildList;
		}

		// Token: 0x02007008 RID: 28680
		[Token(Token = "0x2007008")]
		[Serializable]
		private class AnimConfig : IHotfixable
		{
			// Token: 0x1700601D RID: 24605
			// (get) Token: 0x06028B72 RID: 166770 RVA: 0x000D2BB8 File Offset: 0x000D0DB8
			[Token(Token = "0x1700601D")]
			public ActMultiV3MapDiffType diffType
			{
				[Token(Token = "0x6028B72")]
				[Address(RVA = "0x24190A0", Offset = "0x2417CA0", VA = "0x1824190A0")]
				get
				{
					return ActMultiV3MapDiffType.NONE;
				}
			}

			// Token: 0x1700601E RID: 24606
			// (get) Token: 0x06028B73 RID: 166771 RVA: 0x000D2BD0 File Offset: 0x000D0DD0
			[Token(Token = "0x1700601E")]
			public UIAnimationLocation diffAnim
			{
				[Token(Token = "0x6028B73")]
				[Address(RVA = "0x2419020", Offset = "0x2417C20", VA = "0x182419020")]
				get
				{
					return default(UIAnimationLocation);
				}
			}

			// Token: 0x06028B74 RID: 166772 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B74")]
			[Address(RVA = "0x2418FC0", Offset = "0x2417BC0", VA = "0x182418FC0")]
			public AnimConfig()
			{
			}

			// Token: 0x0403A0A7 RID: 237735
			[Token(Token = "0x403A0A7")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private ActMultiV3MapDiffType _diffType;

			// Token: 0x0403A0A8 RID: 237736
			[Token(Token = "0x403A0A8")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private UIAnimationLocation _diffAnim;

			// Token: 0x0403A0A9 RID: 237737
			[Token(Token = "0x403A0A9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_diffType;

			// Token: 0x0403A0AA RID: 237738
			[Token(Token = "0x403A0AA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_diffAnim;

			// Token: 0x0403A0AB RID: 237739
			[Token(Token = "0x403A0AB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
