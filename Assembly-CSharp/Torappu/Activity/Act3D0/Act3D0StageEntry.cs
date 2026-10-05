using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073DE RID: 29662
	[Token(Token = "0x20073DE")]
	public class Act3D0StageEntry : ActivityStageSingleComponent
	{
		// Token: 0x06029E58 RID: 171608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E58")]
		[Address(RVA = "0x256B660", Offset = "0x256A260", VA = "0x18256B660")]
		public void OnBanAct()
		{
		}

		// Token: 0x06029E59 RID: 171609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E59")]
		[Address(RVA = "0x256B720", Offset = "0x256A320", VA = "0x18256B720")]
		public void RefreshTrackPoint()
		{
		}

		// Token: 0x06029E5A RID: 171610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E5A")]
		[Address(RVA = "0x256A8B0", Offset = "0x25694B0", VA = "0x18256A8B0")]
		public void InitData(string defaultBoxId)
		{
		}

		// Token: 0x06029E5B RID: 171611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E5B")]
		[Address(RVA = "0x256A800", Offset = "0x2569400", VA = "0x18256A800")]
		public void EventOnReplicateClicked()
		{
		}

		// Token: 0x06029E5C RID: 171612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E5C")]
		[Address(RVA = "0x256A690", Offset = "0x2569290", VA = "0x18256A690")]
		public void EventOnFavorUpClicked()
		{
		}

		// Token: 0x06029E5D RID: 171613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E5D")]
		[Address(RVA = "0x256A5E0", Offset = "0x25691E0", VA = "0x18256A5E0")]
		public void EventOnDetailClicked()
		{
		}

		// Token: 0x06029E5E RID: 171614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E5E")]
		[Address(RVA = "0x256A750", Offset = "0x2569350", VA = "0x18256A750")]
		public void EventOnMileStoneClicked()
		{
		}

		// Token: 0x06029E5F RID: 171615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E5F")]
		[Address(RVA = "0x256BAD0", Offset = "0x256A6D0", VA = "0x18256BAD0")]
		public Act3D0StageEntry()
		{
		}

		// Token: 0x0403C0B3 RID: 245939
		[Token(Token = "0x403C0B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _buttonImg;

		// Token: 0x0403C0B4 RID: 245940
		[Token(Token = "0x403C0B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _backImg;

		// Token: 0x0403C0B5 RID: 245941
		[Token(Token = "0x403C0B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _boxImg;

		// Token: 0x0403C0B6 RID: 245942
		[Token(Token = "0x403C0B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _timeInfo;

		// Token: 0x0403C0B7 RID: 245943
		[Token(Token = "0x403C0B7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _stateInfo;

		// Token: 0x0403C0B8 RID: 245944
		[Token(Token = "0x403C0B8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIActTrackPoint _actTrackPoint;

		// Token: 0x0403C0B9 RID: 245945
		[Token(Token = "0x403C0B9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _mileStoneButton;

		// Token: 0x0403C0BA RID: 245946
		[Token(Token = "0x403C0BA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _gachaBoxButton;

		// Token: 0x0403C0BB RID: 245947
		[Token(Token = "0x403C0BB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403C0BC RID: 245948
		[Token(Token = "0x403C0BC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UICommonTrackPoint _favorUpTrackPoint;

		// Token: 0x0403C0BD RID: 245949
		[Token(Token = "0x403C0BD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _favorUpObj;

		// Token: 0x0403C0BE RID: 245950
		[Token(Token = "0x403C0BE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _noFavorUpObj;

		// Token: 0x0403C0BF RID: 245951
		[Token(Token = "0x403C0BF")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private TrackPointViewProperty _mileStoneTrackPoint;

		// Token: 0x0403C0C0 RID: 245952
		[Token(Token = "0x403C0C0")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private TrackPointViewProperty m_favorTrackPoint;

		// Token: 0x0403C0C1 RID: 245953
		[Token(Token = "0x403C0C1")]
		[FieldOffset(Offset = "0x90")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403C0C2 RID: 245954
		[Token(Token = "0x403C0C2")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0403C0C3 RID: 245955
		[Token(Token = "0x403C0C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnBanAct;

		// Token: 0x0403C0C4 RID: 245956
		[Token(Token = "0x403C0C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshTrackPoint;

		// Token: 0x0403C0C5 RID: 245957
		[Token(Token = "0x403C0C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403C0C6 RID: 245958
		[Token(Token = "0x403C0C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnReplicateClicked;

		// Token: 0x0403C0C7 RID: 245959
		[Token(Token = "0x403C0C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnFavorUpClicked;

		// Token: 0x0403C0C8 RID: 245960
		[Token(Token = "0x403C0C8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnDetailClicked;

		// Token: 0x0403C0C9 RID: 245961
		[Token(Token = "0x403C0C9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnMileStoneClicked;

		// Token: 0x0403C0CA RID: 245962
		[Token(Token = "0x403C0CA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
