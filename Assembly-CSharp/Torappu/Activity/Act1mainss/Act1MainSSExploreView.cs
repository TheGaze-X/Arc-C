using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x02007853 RID: 30803
	[Token(Token = "0x2007853")]
	public class Act1MainSSExploreView : TemplateActivityCommonPlugin
	{
		// Token: 0x0602B319 RID: 176921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B319")]
		[Address(RVA = "0x271AA10", Offset = "0x2719610", VA = "0x18271AA10", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602B31A RID: 176922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B31A")]
		[Address(RVA = "0x271A960", Offset = "0x2719560", VA = "0x18271A960")]
		public void OnOpenPage()
		{
		}

		// Token: 0x0602B31B RID: 176923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B31B")]
		[Address(RVA = "0x271A770", Offset = "0x2719370", VA = "0x18271A770")]
		public void OnOpenMission()
		{
		}

		// Token: 0x0602B31C RID: 176924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B31C")]
		[Address(RVA = "0x271AD10", Offset = "0x2719910", VA = "0x18271AD10")]
		public Act1MainSSExploreView()
		{
		}

		// Token: 0x0403E718 RID: 255768
		[Token(Token = "0x403E718")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0403E719 RID: 255769
		[Token(Token = "0x403E719")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommonTrackPoint _missionTrackPoint;

		// Token: 0x0403E71A RID: 255770
		[Token(Token = "0x403E71A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _lockedText;

		// Token: 0x0403E71B RID: 255771
		[Token(Token = "0x403E71B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _missionBtn;

		// Token: 0x0403E71C RID: 255772
		[Token(Token = "0x403E71C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _lockedPart;

		// Token: 0x0403E71D RID: 255773
		[Token(Token = "0x403E71D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _unlockedPart;

		// Token: 0x0403E71E RID: 255774
		[Token(Token = "0x403E71E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _inTimeLockedPart;

		// Token: 0x0403E71F RID: 255775
		[Token(Token = "0x403E71F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _notInTimeLockedPart;

		// Token: 0x0403E720 RID: 255776
		[Token(Token = "0x403E720")]
		[FieldOffset(Offset = "0x68")]
		private Act1MainSSExploreTrackPoint m_trackPointModel;

		// Token: 0x0403E721 RID: 255777
		[Token(Token = "0x403E721")]
		[FieldOffset(Offset = "0x70")]
		private TrackPointViewProperty m_property;

		// Token: 0x0403E722 RID: 255778
		[Token(Token = "0x403E722")]
		[FieldOffset(Offset = "0x78")]
		private TrackPointViewProperty m_missionProperty;

		// Token: 0x0403E723 RID: 255779
		[Token(Token = "0x403E723")]
		[FieldOffset(Offset = "0x80")]
		private Act1MainSSHomeExploreViewModel m_cacheViewModel;

		// Token: 0x0403E724 RID: 255780
		[Token(Token = "0x403E724")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403E725 RID: 255781
		[Token(Token = "0x403E725")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnOpenPage;

		// Token: 0x0403E726 RID: 255782
		[Token(Token = "0x403E726")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnOpenMission;

		// Token: 0x0403E727 RID: 255783
		[Token(Token = "0x403E727")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
