using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007997 RID: 31127
	[Token(Token = "0x2007997")]
	public class Act1ArcadeStageSelectBottomInfoView : DataBinder<Act1ArcadeStageSelectProperty>
	{
		// Token: 0x0602BABA RID: 178874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BABA")]
		[Address(RVA = "0x27A5E40", Offset = "0x27A4A40", VA = "0x1827A5E40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BABB RID: 178875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BABB")]
		[Address(RVA = "0x27A5770", Offset = "0x27A4370", VA = "0x1827A5770", Slot = "7")]
		public override void OnValueChanged(Act1ArcadeStageSelectProperty property)
		{
		}

		// Token: 0x0602BABC RID: 178876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BABC")]
		[Address(RVA = "0x27A5630", Offset = "0x27A4230", VA = "0x1827A5630")]
		public void EventOnClickBadge()
		{
		}

		// Token: 0x0602BABD RID: 178877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BABD")]
		[Address(RVA = "0x27A56D0", Offset = "0x27A42D0", VA = "0x1827A56D0")]
		public void EventOnClickStartBattle()
		{
		}

		// Token: 0x0602BABE RID: 178878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BABE")]
		[Address(RVA = "0x27A5F60", Offset = "0x27A4B60", VA = "0x1827A5F60")]
		public Act1ArcadeStageSelectBottomInfoView()
		{
		}

		// Token: 0x0403F2D3 RID: 258771
		[Token(Token = "0x403F2D3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelRewardSOnly;

		// Token: 0x0403F2D4 RID: 258772
		[Token(Token = "0x403F2D4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelRewardSA;

		// Token: 0x0403F2D5 RID: 258773
		[Token(Token = "0x403F2D5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textRewardRankSOnly;

		// Token: 0x0403F2D6 RID: 258774
		[Token(Token = "0x403F2D6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textRewardRankA;

		// Token: 0x0403F2D7 RID: 258775
		[Token(Token = "0x403F2D7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textRewardRankS;

		// Token: 0x0403F2D8 RID: 258776
		[Token(Token = "0x403F2D8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgToken;

		// Token: 0x0403F2D9 RID: 258777
		[Token(Token = "0x403F2D9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Act1ArcadeStageSelectBadgeItemView> _badgeItemViews;

		// Token: 0x0403F2DA RID: 258778
		[Token(Token = "0x403F2DA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0403F2DB RID: 258779
		[Token(Token = "0x403F2DB")]
		[FieldOffset(Offset = "0x60")]
		private TrackPointViewProperty m_trackPointProperty;

		// Token: 0x0403F2DC RID: 258780
		[Token(Token = "0x403F2DC")]
		[FieldOffset(Offset = "0x68")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0403F2DD RID: 258781
		[Token(Token = "0x403F2DD")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403F2DE RID: 258782
		[Token(Token = "0x403F2DE")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403F2DF RID: 258783
		[Token(Token = "0x403F2DF")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0403F2E0 RID: 258784
		[Token(Token = "0x403F2E0")]
		[FieldOffset(Offset = "0x98")]
		private Act1ArcadeStageSelectBottomInfoView.StageBadgeTrackPointModel.UpdateParam m_trackPointParam;

		// Token: 0x0403F2E1 RID: 258785
		[Token(Token = "0x403F2E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F2E2 RID: 258786
		[Token(Token = "0x403F2E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403F2E3 RID: 258787
		[Token(Token = "0x403F2E3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClickBadge;

		// Token: 0x0403F2E4 RID: 258788
		[Token(Token = "0x403F2E4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClickStartBattle;

		// Token: 0x0403F2E5 RID: 258789
		[Token(Token = "0x403F2E5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007998 RID: 31128
		[Token(Token = "0x2007998")]
		private class StageBadgeTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700666D RID: 26221
			// (get) Token: 0x0602BABF RID: 178879 RVA: 0x000DCD10 File Offset: 0x000DAF10
			// (set) Token: 0x0602BAC0 RID: 178880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700666D")]
			public bool isShow
			{
				[Token(Token = "0x602BABF")]
				[Address(RVA = "0x27A9670", Offset = "0x27A8270", VA = "0x1827A9670", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x602BAC0")]
				[Address(RVA = "0x27A96D0", Offset = "0x27A82D0", VA = "0x1827A96D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0602BAC1 RID: 178881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BAC1")]
			[Address(RVA = "0x27A9500", Offset = "0x27A8100", VA = "0x1827A9500", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602BAC2 RID: 178882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BAC2")]
			[Address(RVA = "0x27A9610", Offset = "0x27A8210", VA = "0x1827A9610")]
			public StageBadgeTrackPointModel()
			{
			}

			// Token: 0x0403F2E7 RID: 258791
			[Token(Token = "0x403F2E7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403F2E8 RID: 258792
			[Token(Token = "0x403F2E8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x0403F2E9 RID: 258793
			[Token(Token = "0x403F2E9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403F2EA RID: 258794
			[Token(Token = "0x403F2EA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02007999 RID: 31129
			[Token(Token = "0x2007999")]
			public class UpdateParam
			{
				// Token: 0x0602BAC3 RID: 178883 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602BAC3")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public UpdateParam()
				{
				}

				// Token: 0x0403F2EB RID: 258795
				[Token(Token = "0x403F2EB")]
				[FieldOffset(Offset = "0x10")]
				public string actId;
			}
		}
	}
}
