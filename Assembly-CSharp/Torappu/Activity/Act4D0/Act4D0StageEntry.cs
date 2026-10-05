using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x0200726B RID: 29291
	[Token(Token = "0x200726B")]
	public class Act4D0StageEntry : ActivityStageSingleComponent
	{
		// Token: 0x060297FC RID: 169980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60297FC")]
		[Address(RVA = "0x24E0900", Offset = "0x24DF500", VA = "0x1824E0900")]
		public GameObject GetTopMenu()
		{
			return null;
		}

		// Token: 0x060297FD RID: 169981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297FD")]
		[Address(RVA = "0x24E0960", Offset = "0x24DF560", VA = "0x1824E0960")]
		public void InitData()
		{
		}

		// Token: 0x060297FE RID: 169982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297FE")]
		[Address(RVA = "0x24E1810", Offset = "0x24E0410", VA = "0x1824E1810")]
		public Act4D0StageEntry()
		{
		}

		// Token: 0x0403B4C2 RID: 242882
		[Token(Token = "0x403B4C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIActTrackPoint _activityTrackPoint;

		// Token: 0x0403B4C3 RID: 242883
		[Token(Token = "0x403B4C3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIActTrackPoint _mileStoneTrackPoint;

		// Token: 0x0403B4C4 RID: 242884
		[Token(Token = "0x403B4C4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act4D0EntryStageObjContainer _stageContainer;

		// Token: 0x0403B4C5 RID: 242885
		[Token(Token = "0x403B4C5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _stoneText;

		// Token: 0x0403B4C6 RID: 242886
		[Token(Token = "0x403B4C6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _topMenu;

		// Token: 0x0403B4C7 RID: 242887
		[Token(Token = "0x403B4C7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _entryTopMenu;

		// Token: 0x0403B4C8 RID: 242888
		[Token(Token = "0x403B4C8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _remainText;

		// Token: 0x0403B4C9 RID: 242889
		[Token(Token = "0x403B4C9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0403B4CA RID: 242890
		[Token(Token = "0x403B4CA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _bannedPart;

		// Token: 0x0403B4CB RID: 242891
		[Token(Token = "0x403B4CB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _hourOffset;

		// Token: 0x0403B4CC RID: 242892
		[Token(Token = "0x403B4CC")]
		[FieldOffset(Offset = "0x70")]
		private TrackPointViewProperty m_activityRedPoint;

		// Token: 0x0403B4CD RID: 242893
		[Token(Token = "0x403B4CD")]
		[FieldOffset(Offset = "0x78")]
		private TrackPointViewProperty m_mileStoneRedPoint;

		// Token: 0x0403B4CE RID: 242894
		[Token(Token = "0x403B4CE")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0403B4CF RID: 242895
		[Token(Token = "0x403B4CF")]
		[FieldOffset(Offset = "0x88")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403B4D0 RID: 242896
		[Token(Token = "0x403B4D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetTopMenu;

		// Token: 0x0403B4D1 RID: 242897
		[Token(Token = "0x403B4D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403B4D2 RID: 242898
		[Token(Token = "0x403B4D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
