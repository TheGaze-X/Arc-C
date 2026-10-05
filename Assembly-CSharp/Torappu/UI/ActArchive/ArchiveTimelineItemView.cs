using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C33 RID: 27699
	[Token(Token = "0x2006C33")]
	public class ArchiveTimelineItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D56 RID: 23894
		// (get) Token: 0x060278AD RID: 161965 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060278AE RID: 161966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D56")]
		public ArchiveTimelineController controller
		{
			[Token(Token = "0x60278AD")]
			[Address(RVA = "0x22B8B10", Offset = "0x22B7710", VA = "0x1822B8B10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60278AE")]
			[Address(RVA = "0x22B8B70", Offset = "0x22B7770", VA = "0x1822B8B70")]
			set
			{
			}
		}

		// Token: 0x060278AF RID: 161967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278AF")]
		[Address(RVA = "0x22B7F90", Offset = "0x22B6B90", VA = "0x1822B7F90")]
		public void ApplyData(TimelineItemModel timelineItemModel)
		{
		}

		// Token: 0x060278B0 RID: 161968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278B0")]
		[Address(RVA = "0x22B8430", Offset = "0x22B7030", VA = "0x1822B8430")]
		public void EventOnMusicClicked()
		{
		}

		// Token: 0x060278B1 RID: 161969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278B1")]
		[Address(RVA = "0x22B8770", Offset = "0x22B7370", VA = "0x1822B8770")]
		public void EventOnPicClicked()
		{
		}

		// Token: 0x060278B2 RID: 161970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278B2")]
		[Address(RVA = "0x22B8290", Offset = "0x22B6E90", VA = "0x1822B8290")]
		public void EventOnAvgClicked()
		{
		}

		// Token: 0x060278B3 RID: 161971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278B3")]
		[Address(RVA = "0x22B8910", Offset = "0x22B7510", VA = "0x1822B8910")]
		public void EventOnStoryClicked()
		{
		}

		// Token: 0x060278B4 RID: 161972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278B4")]
		[Address(RVA = "0x22B85D0", Offset = "0x22B71D0", VA = "0x1822B85D0")]
		public void EventOnNewsClicked()
		{
		}

		// Token: 0x060278B5 RID: 161973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278B5")]
		[Address(RVA = "0x22B8AB0", Offset = "0x22B76B0", VA = "0x1822B8AB0")]
		public ArchiveTimelineItemView()
		{
		}

		// Token: 0x0403810C RID: 229644
		[Token(Token = "0x403810C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArchiveTimelineItemView.TimelineLineView _lineView;

		// Token: 0x0403810D RID: 229645
		[Token(Token = "0x403810D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArchiveTimelineItemView.TimelineMusicItemView _musicItemView;

		// Token: 0x0403810E RID: 229646
		[Token(Token = "0x403810E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArchiveTimelineItemView.TimelinePicItemView _picItemView;

		// Token: 0x0403810F RID: 229647
		[Token(Token = "0x403810F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ArchiveTimelineItemView.TimelineAvgItemView _avgItemView;

		// Token: 0x04038110 RID: 229648
		[Token(Token = "0x4038110")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveTimelineItemView.TimelineStoryItemView _storyItemView;

		// Token: 0x04038111 RID: 229649
		[Token(Token = "0x4038111")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArchiveTimelineItemView.TimelineNewsItemView _newsItemView;

		// Token: 0x04038112 RID: 229650
		[Token(Token = "0x4038112")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _timelineDesc;

		// Token: 0x04038113 RID: 229651
		[Token(Token = "0x4038113")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _timelineTitle;

		// Token: 0x04038114 RID: 229652
		[Token(Token = "0x4038114")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x04038115 RID: 229653
		[Token(Token = "0x4038115")]
		[FieldOffset(Offset = "0x60")]
		private TimelineItemModel m_cachedModel;

		// Token: 0x04038116 RID: 229654
		[Token(Token = "0x4038116")]
		[FieldOffset(Offset = "0x68")]
		private ArchiveTimelineController m_controller;

		// Token: 0x04038117 RID: 229655
		[Token(Token = "0x4038117")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04038118 RID: 229656
		[Token(Token = "0x4038118")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04038119 RID: 229657
		[Token(Token = "0x4038119")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0403811A RID: 229658
		[Token(Token = "0x403811A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnMusicClicked;

		// Token: 0x0403811B RID: 229659
		[Token(Token = "0x403811B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnPicClicked;

		// Token: 0x0403811C RID: 229660
		[Token(Token = "0x403811C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnAvgClicked;

		// Token: 0x0403811D RID: 229661
		[Token(Token = "0x403811D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnStoryClicked;

		// Token: 0x0403811E RID: 229662
		[Token(Token = "0x403811E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnNewsClicked;

		// Token: 0x0403811F RID: 229663
		[Token(Token = "0x403811F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C34 RID: 27700
		[Token(Token = "0x2006C34")]
		[Serializable]
		private class TimelineLineView : IHotfixable
		{
			// Token: 0x060278B6 RID: 161974 RVA: 0x000CEAA8 File Offset: 0x000CCCA8
			[Token(Token = "0x60278B6")]
			[Address(RVA = "0x22CFE90", Offset = "0x22CEA90", VA = "0x1822CFE90")]
			private int _determineLineIndex(TimelineItemModel timelineItemModel)
			{
				return 0;
			}

			// Token: 0x060278B7 RID: 161975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278B7")]
			[Address(RVA = "0x22CFC30", Offset = "0x22CE830", VA = "0x1822CFC30")]
			public void ApplyData(TimelineItemModel timelineItemModel)
			{
			}

			// Token: 0x060278B8 RID: 161976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278B8")]
			[Address(RVA = "0x22CFE20", Offset = "0x22CEA20", VA = "0x1822CFE20")]
			public TimelineLineView()
			{
			}

			// Token: 0x04038120 RID: 229664
			[Token(Token = "0x4038120")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private List<Image> _lines;

			// Token: 0x04038121 RID: 229665
			[Token(Token = "0x4038121")]
			[FieldOffset(Offset = "0x18")]
			private int m_cachedIndex;

			// Token: 0x04038122 RID: 229666
			[Token(Token = "0x4038122")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__determineLineIndex;

			// Token: 0x04038123 RID: 229667
			[Token(Token = "0x4038123")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyData;

			// Token: 0x04038124 RID: 229668
			[Token(Token = "0x4038124")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006C35 RID: 27701
		[Token(Token = "0x2006C35")]
		[Serializable]
		private abstract class TimelineResItemView<TModel> : IHotfixable where TModel : ArchiveItemModel
		{
			// Token: 0x17005D57 RID: 23895
			// (get) Token: 0x060278B9 RID: 161977 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005D57")]
			protected Image imageBkg
			{
				[Token(Token = "0x60278B9")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005D58 RID: 23896
			// (get) Token: 0x060278BA RID: 161978 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005D58")]
			protected Image imageMask
			{
				[Token(Token = "0x60278BA")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005D59 RID: 23897
			// (get) Token: 0x060278BB RID: 161979 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005D59")]
			protected Image imageStack
			{
				[Token(Token = "0x60278BB")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005D5A RID: 23898
			// (get) Token: 0x060278BC RID: 161980 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060278BD RID: 161981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005D5A")]
			public ArchiveTimelineController controller
			{
				[Token(Token = "0x60278BC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60278BD")]
				set
				{
				}
			}

			// Token: 0x060278BE RID: 161982
			[Token(Token = "0x60278BE")]
			protected abstract void _onSetController(ArchiveTimelineController controller);

			// Token: 0x060278BF RID: 161983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278BF")]
			protected void _updateStackNum(int stackNum)
			{
			}

			// Token: 0x060278C0 RID: 161984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278C0")]
			protected void _updateLocked(bool locked)
			{
			}

			// Token: 0x060278C1 RID: 161985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278C1")]
			protected void _updateChecked(bool isChecked)
			{
			}

			// Token: 0x060278C2 RID: 161986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278C2")]
			protected void _updateText(string text)
			{
			}

			// Token: 0x060278C3 RID: 161987
			[Token(Token = "0x60278C3")]
			public abstract void ApplyData(TimelineResModel<TModel> model);

			// Token: 0x060278C4 RID: 161988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278C4")]
			protected TimelineResItemView()
			{
			}

			// Token: 0x04038125 RID: 229669
			[Token(Token = "0x4038125")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			protected GameObject _panelRoot;

			// Token: 0x04038126 RID: 229670
			[Token(Token = "0x4038126")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Image _panelStack;

			// Token: 0x04038127 RID: 229671
			[Token(Token = "0x4038127")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Text _textStack;

			// Token: 0x04038128 RID: 229672
			[Token(Token = "0x4038128")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private GameObject _panelLocked;

			// Token: 0x04038129 RID: 229673
			[Token(Token = "0x4038129")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private GameObject _panelChecked;

			// Token: 0x0403812A RID: 229674
			[Token(Token = "0x403812A")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private ArchiveTimelineItemText _panelText;

			// Token: 0x0403812B RID: 229675
			[Token(Token = "0x403812B")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Image _imageBkg;

			// Token: 0x0403812C RID: 229676
			[Token(Token = "0x403812C")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Image _imageMask;

			// Token: 0x0403812D RID: 229677
			[Token(Token = "0x403812D")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Image _imageStack;

			// Token: 0x0403812E RID: 229678
			[Token(Token = "0x403812E")]
			[FieldOffset(Offset = "0x0")]
			private int m_cachedStackNum;

			// Token: 0x0403812F RID: 229679
			[Token(Token = "0x403812F")]
			[FieldOffset(Offset = "0x0")]
			private bool m_cachedLocked;

			// Token: 0x04038130 RID: 229680
			[Token(Token = "0x4038130")]
			[FieldOffset(Offset = "0x0")]
			private bool m_cachedChecked;

			// Token: 0x04038131 RID: 229681
			[Token(Token = "0x4038131")]
			[FieldOffset(Offset = "0x0")]
			private ArchiveTimelineController m_controller;

			// Token: 0x04038132 RID: 229682
			[Token(Token = "0x4038132")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_imageBkg;

			// Token: 0x04038133 RID: 229683
			[Token(Token = "0x4038133")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_imageMask;

			// Token: 0x04038134 RID: 229684
			[Token(Token = "0x4038134")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_imageStack;

			// Token: 0x04038135 RID: 229685
			[Token(Token = "0x4038135")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_controller;

			// Token: 0x04038136 RID: 229686
			[Token(Token = "0x4038136")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_controller;

			// Token: 0x04038137 RID: 229687
			[Token(Token = "0x4038137")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__updateStackNum;

			// Token: 0x04038138 RID: 229688
			[Token(Token = "0x4038138")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__updateLocked;

			// Token: 0x04038139 RID: 229689
			[Token(Token = "0x4038139")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__updateChecked;

			// Token: 0x0403813A RID: 229690
			[Token(Token = "0x403813A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__updateText;

			// Token: 0x0403813B RID: 229691
			[Token(Token = "0x403813B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006C36 RID: 27702
		[Token(Token = "0x2006C36")]
		[Serializable]
		private class TimelineMusicItemView : ArchiveTimelineItemView.TimelineResItemView<MusicItemModel>
		{
			// Token: 0x060278C5 RID: 161989 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278C5")]
			[Address(RVA = "0x22D01B0", Offset = "0x22CEDB0", VA = "0x1822D01B0", Slot = "4")]
			protected override void _onSetController(ArchiveTimelineController controller)
			{
			}

			// Token: 0x060278C6 RID: 161990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278C6")]
			[Address(RVA = "0x22CFF70", Offset = "0x22CEB70", VA = "0x1822CFF70", Slot = "5")]
			public override void ApplyData(TimelineResModel<MusicItemModel> model)
			{
			}

			// Token: 0x060278C7 RID: 161991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278C7")]
			[Address(RVA = "0x22D0140", Offset = "0x22CED40", VA = "0x1822D0140")]
			public TimelineMusicItemView()
			{
			}

			// Token: 0x0403813C RID: 229692
			[Token(Token = "0x403813C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__onSetController;

			// Token: 0x0403813D RID: 229693
			[Token(Token = "0x403813D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyData;

			// Token: 0x0403813E RID: 229694
			[Token(Token = "0x403813E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006C37 RID: 27703
		[Token(Token = "0x2006C37")]
		[Serializable]
		private class TimelinePicItemView : ArchiveTimelineItemView.TimelineResItemView<PicItemModel>
		{
			// Token: 0x17005D5B RID: 23899
			// (get) Token: 0x060278C8 RID: 161992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005D5B")]
			protected Image imageFrame
			{
				[Token(Token = "0x60278C8")]
				[Address(RVA = "0x22D1010", Offset = "0x22CFC10", VA = "0x1822D1010")]
				get
				{
					return null;
				}
			}

			// Token: 0x060278C9 RID: 161993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278C9")]
			[Address(RVA = "0x22D0CF0", Offset = "0x22CF8F0", VA = "0x1822D0CF0", Slot = "4")]
			protected override void _onSetController(ArchiveTimelineController controller)
			{
			}

			// Token: 0x060278CA RID: 161994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278CA")]
			[Address(RVA = "0x22D0850", Offset = "0x22CF450", VA = "0x1822D0850", Slot = "5")]
			public override void ApplyData(TimelineResModel<PicItemModel> model)
			{
			}

			// Token: 0x060278CB RID: 161995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278CB")]
			[Address(RVA = "0x22D0C80", Offset = "0x22CF880", VA = "0x1822D0C80")]
			public TimelinePicItemView()
			{
			}

			// Token: 0x0403813F RID: 229695
			[Token(Token = "0x403813F")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			private Image _imageThumbnail;

			// Token: 0x04038140 RID: 229696
			[Token(Token = "0x4038140")]
			[FieldOffset(Offset = "0x70")]
			[SerializeField]
			private Image _imageFrame;

			// Token: 0x04038141 RID: 229697
			[Token(Token = "0x4038141")]
			[FieldOffset(Offset = "0x78")]
			private string m_cachedPicId;

			// Token: 0x04038142 RID: 229698
			[Token(Token = "0x4038142")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_imageFrame;

			// Token: 0x04038143 RID: 229699
			[Token(Token = "0x4038143")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__onSetController;

			// Token: 0x04038144 RID: 229700
			[Token(Token = "0x4038144")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ApplyData;

			// Token: 0x04038145 RID: 229701
			[Token(Token = "0x4038145")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006C38 RID: 27704
		[Token(Token = "0x2006C38")]
		[Serializable]
		private class TimelineAvgItemView : ArchiveTimelineItemView.TimelineResItemView<AvgItemModel>
		{
			// Token: 0x060278CC RID: 161996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278CC")]
			[Address(RVA = "0x22CE890", Offset = "0x22CD490", VA = "0x1822CE890", Slot = "4")]
			protected override void _onSetController(ArchiveTimelineController controller)
			{
			}

			// Token: 0x060278CD RID: 161997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278CD")]
			[Address(RVA = "0x22CE650", Offset = "0x22CD250", VA = "0x1822CE650", Slot = "5")]
			public override void ApplyData(TimelineResModel<AvgItemModel> model)
			{
			}

			// Token: 0x060278CE RID: 161998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278CE")]
			[Address(RVA = "0x22CE820", Offset = "0x22CD420", VA = "0x1822CE820")]
			public TimelineAvgItemView()
			{
			}

			// Token: 0x04038146 RID: 229702
			[Token(Token = "0x4038146")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__onSetController;

			// Token: 0x04038147 RID: 229703
			[Token(Token = "0x4038147")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyData;

			// Token: 0x04038148 RID: 229704
			[Token(Token = "0x4038148")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006C39 RID: 27705
		[Token(Token = "0x2006C39")]
		[Serializable]
		private class TimelineStoryItemView : ArchiveTimelineItemView.TimelineResItemView<StoryItemModel>
		{
			// Token: 0x060278CF RID: 161999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278CF")]
			[Address(RVA = "0x22D1310", Offset = "0x22CFF10", VA = "0x1822D1310", Slot = "4")]
			protected override void _onSetController(ArchiveTimelineController controller)
			{
			}

			// Token: 0x060278D0 RID: 162000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278D0")]
			[Address(RVA = "0x22D10D0", Offset = "0x22CFCD0", VA = "0x1822D10D0", Slot = "5")]
			public override void ApplyData(TimelineResModel<StoryItemModel> model)
			{
			}

			// Token: 0x060278D1 RID: 162001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278D1")]
			[Address(RVA = "0x22D12A0", Offset = "0x22CFEA0", VA = "0x1822D12A0")]
			public TimelineStoryItemView()
			{
			}

			// Token: 0x04038149 RID: 229705
			[Token(Token = "0x4038149")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__onSetController;

			// Token: 0x0403814A RID: 229706
			[Token(Token = "0x403814A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyData;

			// Token: 0x0403814B RID: 229707
			[Token(Token = "0x403814B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006C3A RID: 27706
		[Token(Token = "0x2006C3A")]
		[Serializable]
		private class TimelineNewsItemView : ArchiveTimelineItemView.TimelineResItemView<NewsItemModel>
		{
			// Token: 0x060278D2 RID: 162002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278D2")]
			[Address(RVA = "0x22D0620", Offset = "0x22CF220", VA = "0x1822D0620", Slot = "4")]
			protected override void _onSetController(ArchiveTimelineController controller)
			{
			}

			// Token: 0x060278D3 RID: 162003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278D3")]
			[Address(RVA = "0x22D03E0", Offset = "0x22CEFE0", VA = "0x1822D03E0", Slot = "5")]
			public override void ApplyData(TimelineResModel<NewsItemModel> model)
			{
			}

			// Token: 0x060278D4 RID: 162004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60278D4")]
			[Address(RVA = "0x22D05B0", Offset = "0x22CF1B0", VA = "0x1822D05B0")]
			public TimelineNewsItemView()
			{
			}

			// Token: 0x0403814C RID: 229708
			[Token(Token = "0x403814C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__onSetController;

			// Token: 0x0403814D RID: 229709
			[Token(Token = "0x403814D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyData;

			// Token: 0x0403814E RID: 229710
			[Token(Token = "0x403814E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
