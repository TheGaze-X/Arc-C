using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B13 RID: 6931
	[Token(Token = "0x2001B13")]
	public class BuildingCharAvatar : MonoBehaviour, ITimeWatcher, IHotfixable
	{
		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x0600AEA3 RID: 44707 RVA: 0x000432F0 File Offset: 0x000414F0
		[Token(Token = "0x170014AA")]
		public bool isClickable
		{
			[Token(Token = "0x600AEA3")]
			[Address(RVA = "0x328A9F0", Offset = "0x32895F0", VA = "0x18328A9F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600AEA4 RID: 44708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEA4")]
		[Address(RVA = "0x328A280", Offset = "0x3288E80", VA = "0x18328A280")]
		private void Start()
		{
		}

		// Token: 0x0600AEA5 RID: 44709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEA5")]
		[Address(RVA = "0x3289CA0", Offset = "0x32888A0", VA = "0x183289CA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600AEA6 RID: 44710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEA6")]
		[Address(RVA = "0x328A2E0", Offset = "0x3288EE0", VA = "0x18328A2E0", Slot = "4")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x0600AEA7 RID: 44711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEA7")]
		[Address(RVA = "0x328A200", Offset = "0x3288E00", VA = "0x18328A200")]
		public void SetParam(object param)
		{
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x0600AEA8 RID: 44712 RVA: 0x00043308 File Offset: 0x00041508
		// (set) Token: 0x0600AEA9 RID: 44713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170014AB")]
		public bool isHilgihted
		{
			[Token(Token = "0x600AEA8")]
			[Address(RVA = "0x328AA50", Offset = "0x3289650", VA = "0x18328AA50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600AEA9")]
			[Address(RVA = "0x328AC00", Offset = "0x3289800", VA = "0x18328AC00")]
			set
			{
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x0600AEAA RID: 44714 RVA: 0x00043320 File Offset: 0x00041520
		// (set) Token: 0x0600AEAB RID: 44715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170014AC")]
		public bool enableStatusPanel
		{
			[Token(Token = "0x600AEAA")]
			[Address(RVA = "0x328A980", Offset = "0x3289580", VA = "0x18328A980")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600AEAB")]
			[Address(RVA = "0x328AB80", Offset = "0x3289780", VA = "0x18328AB80")]
			set
			{
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x0600AEAC RID: 44716 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AEAD RID: 44717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170014AD")]
		public string labelAddText
		{
			[Token(Token = "0x600AEAC")]
			[Address(RVA = "0x328AAC0", Offset = "0x32896C0", VA = "0x18328AAC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AEAD")]
			[Address(RVA = "0x328AC80", Offset = "0x3289880", VA = "0x18328AC80")]
			set
			{
			}
		}

		// Token: 0x0600AEAE RID: 44718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEAE")]
		[Address(RVA = "0x3289D00", Offset = "0x3288900", VA = "0x183289D00")]
		public void Render(BuildingCharModel charModel, BuildingCharAvatar.OverrideStatus overrideStatus = BuildingCharAvatar.OverrideStatus.NONE, bool isRemovable = false)
		{
		}

		// Token: 0x0600AEAF RID: 44719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEAF")]
		[Address(RVA = "0x3289B70", Offset = "0x3288770", VA = "0x183289B70")]
		public void EventOnAvatarClicked()
		{
		}

		// Token: 0x0600AEB0 RID: 44720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEB0")]
		[Address(RVA = "0x328A360", Offset = "0x3288F60", VA = "0x18328A360")]
		private void _OnUpdateManpower()
		{
		}

		// Token: 0x0600AEB1 RID: 44721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEB1")]
		[Address(RVA = "0x328A3C0", Offset = "0x3288FC0", VA = "0x18328A3C0")]
		private void _UpdateActivePanel()
		{
		}

		// Token: 0x0600AEB2 RID: 44722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEB2")]
		[Address(RVA = "0x328A5D0", Offset = "0x32891D0", VA = "0x18328A5D0")]
		private void _UpdateManpower()
		{
		}

		// Token: 0x0600AEB3 RID: 44723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEB3")]
		[Address(RVA = "0x328A920", Offset = "0x3289520", VA = "0x18328A920")]
		public BuildingCharAvatar()
		{
		}

		// Token: 0x0400A777 RID: 42871
		[Token(Token = "0x400A777")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400A778 RID: 42872
		[Token(Token = "0x400A778")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelAdd;

		// Token: 0x0400A779 RID: 42873
		[Token(Token = "0x400A779")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0400A77A RID: 42874
		[Token(Token = "0x400A77A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelAddLabel;

		// Token: 0x0400A77B RID: 42875
		[Token(Token = "0x400A77B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textAdd;

		// Token: 0x0400A77C RID: 42876
		[Token(Token = "0x400A77C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0400A77D RID: 42877
		[Token(Token = "0x400A77D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelClickable;

		// Token: 0x0400A77E RID: 42878
		[Token(Token = "0x400A77E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Active")]
		private Image _imgAvatar;

		// Token: 0x0400A77F RID: 42879
		[Token(Token = "0x400A77F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Active")]
		private GameObject _hilightMask;

		// Token: 0x0400A780 RID: 42880
		[Token(Token = "0x400A780")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Active")]
		private GameObject _statusContainer;

		// Token: 0x0400A781 RID: 42881
		[Token(Token = "0x400A781")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Active")]
		private GameObject _darkMask;

		// Token: 0x0400A782 RID: 42882
		[Token(Token = "0x400A782")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Active")]
		private GameObject _tiredMask;

		// Token: 0x0400A783 RID: 42883
		[Token(Token = "0x400A783")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Active")]
		private GameObject _iconTired;

		// Token: 0x0400A784 RID: 42884
		[Token(Token = "0x400A784")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Active")]
		private GameObject _iconWork;

		// Token: 0x0400A785 RID: 42885
		[Token(Token = "0x400A785")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Active")]
		private GameObject _iconRest;

		// Token: 0x0400A786 RID: 42886
		[Token(Token = "0x400A786")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Active")]
		private FillProgressBar _progress;

		// Token: 0x0400A787 RID: 42887
		[Token(Token = "0x400A787")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Active")]
		private GameObject _iconRemove;

		// Token: 0x0400A788 RID: 42888
		[Token(Token = "0x400A788")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Active")]
		private GameObject _iconTraining;

		// Token: 0x0400A789 RID: 42889
		[Token(Token = "0x400A789")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Active")]
		private Image _iconApStatus;

		// Token: 0x0400A78A RID: 42890
		[Token(Token = "0x400A78A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Active")]
		private BuildingCharAvatar.StateConfig[] _apStateConfigs;

		// Token: 0x0400A78B RID: 42891
		[Token(Token = "0x400A78B")]
		[FieldOffset(Offset = "0xB8")]
		private object m_param;

		// Token: 0x0400A78C RID: 42892
		[Token(Token = "0x400A78C")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x0400A78D RID: 42893
		[Token(Token = "0x400A78D")]
		[FieldOffset(Offset = "0xC4")]
		private BuildingCharAvatar.OverrideStatus m_overrideStatus;

		// Token: 0x0400A78E RID: 42894
		[Token(Token = "0x400A78E")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isRemovable;

		// Token: 0x0400A78F RID: 42895
		[Token(Token = "0x400A78F")]
		[FieldOffset(Offset = "0xD0")]
		private BuildingCharModel m_charModel;

		// Token: 0x0400A790 RID: 42896
		[Token(Token = "0x400A790")]
		[FieldOffset(Offset = "0x148")]
		private CountDownTask m_countDown;

		// Token: 0x0400A791 RID: 42897
		[Token(Token = "0x400A791")]
		[FieldOffset(Offset = "0x150")]
		[NonSerialized]
		public Action<BuildingCharModel, object> onAvatarClicked;

		// Token: 0x0400A792 RID: 42898
		[Token(Token = "0x400A792")]
		[FieldOffset(Offset = "0x158")]
		[NonSerialized]
		public Action<object> onLockClicked;

		// Token: 0x0400A793 RID: 42899
		[Token(Token = "0x400A793")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isClickable;

		// Token: 0x0400A794 RID: 42900
		[Token(Token = "0x400A794")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400A795 RID: 42901
		[Token(Token = "0x400A795")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400A796 RID: 42902
		[Token(Token = "0x400A796")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0400A797 RID: 42903
		[Token(Token = "0x400A797")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetParam;

		// Token: 0x0400A798 RID: 42904
		[Token(Token = "0x400A798")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isHilgihted;

		// Token: 0x0400A799 RID: 42905
		[Token(Token = "0x400A799")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_isHilgihted;

		// Token: 0x0400A79A RID: 42906
		[Token(Token = "0x400A79A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_enableStatusPanel;

		// Token: 0x0400A79B RID: 42907
		[Token(Token = "0x400A79B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_enableStatusPanel;

		// Token: 0x0400A79C RID: 42908
		[Token(Token = "0x400A79C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_labelAddText;

		// Token: 0x0400A79D RID: 42909
		[Token(Token = "0x400A79D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_labelAddText;

		// Token: 0x0400A79E RID: 42910
		[Token(Token = "0x400A79E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400A79F RID: 42911
		[Token(Token = "0x400A79F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnAvatarClicked;

		// Token: 0x0400A7A0 RID: 42912
		[Token(Token = "0x400A7A0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnUpdateManpower;

		// Token: 0x0400A7A1 RID: 42913
		[Token(Token = "0x400A7A1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateActivePanel;

		// Token: 0x0400A7A2 RID: 42914
		[Token(Token = "0x400A7A2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateManpower;

		// Token: 0x0400A7A3 RID: 42915
		[Token(Token = "0x400A7A3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B14 RID: 6932
		[Token(Token = "0x2001B14")]
		public enum OverrideStatus
		{
			// Token: 0x0400A7A5 RID: 42917
			[Token(Token = "0x400A7A5")]
			NONE,
			// Token: 0x0400A7A6 RID: 42918
			[Token(Token = "0x400A7A6")]
			EMPTY,
			// Token: 0x0400A7A7 RID: 42919
			[Token(Token = "0x400A7A7")]
			LOCKED
		}

		// Token: 0x02001B15 RID: 6933
		[Token(Token = "0x2001B15")]
		[Serializable]
		private struct StateConfig
		{
			// Token: 0x0400A7A8 RID: 42920
			[Token(Token = "0x400A7A8")]
			[FieldOffset(Offset = "0x0")]
			public CharManpowerState state;

			// Token: 0x0400A7A9 RID: 42921
			[Token(Token = "0x400A7A9")]
			[FieldOffset(Offset = "0x8")]
			public Sprite icon;
		}
	}
}
