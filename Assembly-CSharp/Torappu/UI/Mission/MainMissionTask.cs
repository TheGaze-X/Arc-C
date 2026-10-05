using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004893 RID: 18579
	[Token(Token = "0x2004893")]
	public class MainMissionTask : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700429B RID: 17051
		// (get) Token: 0x0601C0B1 RID: 114865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700429B")]
		public string taskID
		{
			[Token(Token = "0x601C0B1")]
			[Address(RVA = "0x1569030", Offset = "0x1567C30", VA = "0x181569030")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C0B2 RID: 114866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0B2")]
		[Address(RVA = "0x1568310", Offset = "0x1566F10", VA = "0x181568310")]
		public void OnClick()
		{
		}

		// Token: 0x0601C0B3 RID: 114867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0B3")]
		[Address(RVA = "0x1568380", Offset = "0x1566F80", VA = "0x181568380")]
		public void OnFinish()
		{
		}

		// Token: 0x0601C0B4 RID: 114868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0B4")]
		[Address(RVA = "0x15687C0", Offset = "0x15673C0", VA = "0x1815687C0")]
		private void _ApplyViewStyle(MainMissionTaskViewStyleConfig style)
		{
		}

		// Token: 0x0601C0B5 RID: 114869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0B5")]
		[Address(RVA = "0x15678C0", Offset = "0x15664C0", VA = "0x1815678C0")]
		public void InitData(MissionViewModel data, MainMissionTask.Option option)
		{
		}

		// Token: 0x0601C0B6 RID: 114870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0B6")]
		[Address(RVA = "0x15681D0", Offset = "0x1566DD0", VA = "0x1815681D0")]
		public void OnClickFold()
		{
		}

		// Token: 0x0601C0B7 RID: 114871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0B7")]
		[Address(RVA = "0x1568270", Offset = "0x1566E70", VA = "0x181568270")]
		public void OnClickSpread()
		{
		}

		// Token: 0x0601C0B8 RID: 114872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0B8")]
		[Address(RVA = "0x1568400", Offset = "0x1567000", VA = "0x181568400")]
		private void _ApplyStyle(bool unfinish, bool useCustomStyle)
		{
		}

		// Token: 0x0601C0B9 RID: 114873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0B9")]
		[Address(RVA = "0x1568FD0", Offset = "0x1567BD0", VA = "0x181568FD0")]
		public MainMissionTask()
		{
		}

		// Token: 0x040249AE RID: 149934
		[Token(Token = "0x40249AE")]
		private const float NORMAL_HEIGHT = 82f;

		// Token: 0x040249AF RID: 149935
		[Token(Token = "0x40249AF")]
		private const float TWO_HEIGHT = 95f;

		// Token: 0x040249B0 RID: 149936
		[Token(Token = "0x40249B0")]
		private const float THREE_HEIGHT = 105f;

		// Token: 0x040249B1 RID: 149937
		[Token(Token = "0x40249B1")]
		private const float IS_LAST = 105f;

		// Token: 0x040249B2 RID: 149938
		[Token(Token = "0x40249B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _description;

		// Token: 0x040249B3 RID: 149939
		[Token(Token = "0x40249B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text[] _descriptions;

		// Token: 0x040249B4 RID: 149940
		[Token(Token = "0x40249B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _requirementBackground;

		// Token: 0x040249B5 RID: 149941
		[Token(Token = "0x40249B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _requirementText;

		// Token: 0x040249B6 RID: 149942
		[Token(Token = "0x40249B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _acceptButtonImage;

		// Token: 0x040249B7 RID: 149943
		[Token(Token = "0x40249B7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _acceptButtonGlowImage;

		// Token: 0x040249B8 RID: 149944
		[Token(Token = "0x40249B8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _acceptButtonText;

		// Token: 0x040249B9 RID: 149945
		[Token(Token = "0x40249B9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MainMissionProgressItem _progressItemTypeOneReward;

		// Token: 0x040249BA RID: 149946
		[Token(Token = "0x40249BA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MainMissionProgressItem _progressItemTypeTwoReward;

		// Token: 0x040249BB RID: 149947
		[Token(Token = "0x40249BB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MissionRewardPreviewItem _rewardItemOne;

		// Token: 0x040249BC RID: 149948
		[Token(Token = "0x40249BC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MissionRewardPreviewItem _rewardItemTwo;

		// Token: 0x040249BD RID: 149949
		[Token(Token = "0x40249BD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objAcceptTips;

		// Token: 0x040249BE RID: 149950
		[Token(Token = "0x40249BE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _finished;

		// Token: 0x040249BF RID: 149951
		[Token(Token = "0x40249BF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _unfinished;

		// Token: 0x040249C0 RID: 149952
		[Token(Token = "0x40249C0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject[] _characterStrenthenPanels;

		// Token: 0x040249C1 RID: 149953
		[Token(Token = "0x40249C1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject[] _nonCharacterStrenthenPanels;

		// Token: 0x040249C2 RID: 149954
		[Token(Token = "0x40249C2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _hotSpot;

		// Token: 0x040249C3 RID: 149955
		[Token(Token = "0x40249C3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _backgroundDownDecImage;

		// Token: 0x040249C4 RID: 149956
		[Token(Token = "0x40249C4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x040249C5 RID: 149957
		[Token(Token = "0x40249C5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _backgroundGlow;

		// Token: 0x040249C6 RID: 149958
		[Token(Token = "0x40249C6")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _twoBackPart;

		// Token: 0x040249C7 RID: 149959
		[Token(Token = "0x40249C7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _threeBackPart;

		// Token: 0x040249C8 RID: 149960
		[Token(Token = "0x40249C8")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _foldHotspot;

		// Token: 0x040249C9 RID: 149961
		[Token(Token = "0x40249C9")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _foldBtn;

		// Token: 0x040249CA RID: 149962
		[Token(Token = "0x40249CA")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _foldBack;

		// Token: 0x040249CB RID: 149963
		[Token(Token = "0x40249CB")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Button _spreadBtn;

		// Token: 0x040249CC RID: 149964
		[Token(Token = "0x40249CC")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private MainMissionTaskStyleHub _styleHub;

		// Token: 0x040249CD RID: 149965
		[Token(Token = "0x40249CD")]
		[FieldOffset(Offset = "0xF0")]
		private MissionViewModel m_dataCache;

		// Token: 0x040249CE RID: 149966
		[Token(Token = "0x40249CE")]
		[FieldOffset(Offset = "0xF8")]
		private UIStringEvent m_onFoldAction;

		// Token: 0x040249CF RID: 149967
		[Token(Token = "0x40249CF")]
		[FieldOffset(Offset = "0x100")]
		private UIStringEvent m_onSpreadAction;

		// Token: 0x040249D0 RID: 149968
		[Token(Token = "0x40249D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_taskID;

		// Token: 0x040249D1 RID: 149969
		[Token(Token = "0x40249D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040249D2 RID: 149970
		[Token(Token = "0x40249D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040249D3 RID: 149971
		[Token(Token = "0x40249D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyViewStyle;

		// Token: 0x040249D4 RID: 149972
		[Token(Token = "0x40249D4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040249D5 RID: 149973
		[Token(Token = "0x40249D5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickFold;

		// Token: 0x040249D6 RID: 149974
		[Token(Token = "0x40249D6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClickSpread;

		// Token: 0x040249D7 RID: 149975
		[Token(Token = "0x40249D7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ApplyStyle;

		// Token: 0x040249D8 RID: 149976
		[Token(Token = "0x40249D8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004894 RID: 18580
		[Token(Token = "0x2004894")]
		public struct Option
		{
			// Token: 0x040249D9 RID: 149977
			[Token(Token = "0x40249D9")]
			[FieldOffset(Offset = "0x0")]
			public static MainMissionTask.Option EMPTY;

			// Token: 0x040249DA RID: 149978
			[Token(Token = "0x40249DA")]
			[FieldOffset(Offset = "0x0")]
			public bool useCustomStyle;

			// Token: 0x040249DB RID: 149979
			[Token(Token = "0x40249DB")]
			[FieldOffset(Offset = "0x8")]
			public MainMissionTask prefab;

			// Token: 0x040249DC RID: 149980
			[Token(Token = "0x40249DC")]
			[FieldOffset(Offset = "0x10")]
			public UIStringEvent onSpreadEvent;

			// Token: 0x040249DD RID: 149981
			[Token(Token = "0x40249DD")]
			[FieldOffset(Offset = "0x18")]
			public UIStringEvent onFoldEvent;

			// Token: 0x040249DE RID: 149982
			[Token(Token = "0x40249DE")]
			[FieldOffset(Offset = "0x20")]
			public MissionModel.BranchWrappedGroup.RenderViewModel viewModel;
		}

		// Token: 0x02004895 RID: 18581
		[Token(Token = "0x2004895")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<MainMissionTask>
		{
			// Token: 0x0601C0BB RID: 114875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C0BB")]
			[Address(RVA = "0x1577800", Offset = "0x1576400", VA = "0x181577800")]
			public VirtualView(MainMissionTask.Option option)
			{
			}

			// Token: 0x0601C0BC RID: 114876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C0BC")]
			[Address(RVA = "0x1577610", Offset = "0x1576210", VA = "0x181577610", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0601C0BD RID: 114877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C0BD")]
			[Address(RVA = "0x1577730", Offset = "0x1576330", VA = "0x181577730", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0601C0BE RID: 114878 RVA: 0x000A70B8 File Offset: 0x000A52B8
			[Token(Token = "0x601C0BE")]
			[Address(RVA = "0x1577510", Offset = "0x1576110", VA = "0x181577510", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0601C0BF RID: 114879 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C0BF")]
			[Address(RVA = "0x15773D0", Offset = "0x1575FD0", VA = "0x1815773D0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x040249DF RID: 149983
			[Token(Token = "0x40249DF")]
			[FieldOffset(Offset = "0x20")]
			private MainMissionTask.Option m_option;

			// Token: 0x040249E0 RID: 149984
			[Token(Token = "0x40249E0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040249E1 RID: 149985
			[Token(Token = "0x40249E1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x040249E2 RID: 149986
			[Token(Token = "0x40249E2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x040249E3 RID: 149987
			[Token(Token = "0x40249E3")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x040249E4 RID: 149988
			[Token(Token = "0x40249E4")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPrefab;
		}
	}
}
