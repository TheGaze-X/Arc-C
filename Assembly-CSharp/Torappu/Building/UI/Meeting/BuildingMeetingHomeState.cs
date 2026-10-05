using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D5A RID: 7514
	[Token(Token = "0x2001D5A")]
	public class BuildingMeetingHomeState : State
	{
		// Token: 0x0600B97B RID: 47483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B97B")]
		[Address(RVA = "0x33541F0", Offset = "0x3352DF0", VA = "0x1833541F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B97C RID: 47484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B97C")]
		[Address(RVA = "0x3353F50", Offset = "0x3352B50", VA = "0x183353F50")]
		private void Awake()
		{
		}

		// Token: 0x0600B97D RID: 47485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B97D")]
		[Address(RVA = "0x3355C10", Offset = "0x3354810", VA = "0x183355C10")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0600B97E RID: 47486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B97E")]
		[Address(RVA = "0x3354710", Offset = "0x3353310", VA = "0x183354710", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B97F RID: 47487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B97F")]
		[Address(RVA = "0x3354C40", Offset = "0x3353840", VA = "0x183354C40", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600B980 RID: 47488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B980")]
		[Address(RVA = "0x33574E0", Offset = "0x33560E0", VA = "0x1833574E0")]
		private void _UpdatePlayerStatus()
		{
		}

		// Token: 0x0600B981 RID: 47489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B981")]
		[Address(RVA = "0x33573D0", Offset = "0x3355FD0", VA = "0x1833573D0")]
		private void _TryReceiveTransferRewards()
		{
		}

		// Token: 0x0600B982 RID: 47490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B982")]
		[Address(RVA = "0x33562A0", Offset = "0x3354EA0", VA = "0x1833562A0")]
		private IEnumerator _OpenTransferResultPage()
		{
			return null;
		}

		// Token: 0x0600B983 RID: 47491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B983")]
		[Address(RVA = "0x3356E80", Offset = "0x3355A80", VA = "0x183356E80")]
		private void _SetupStationaryCharacter()
		{
		}

		// Token: 0x0600B984 RID: 47492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B984")]
		[Address(RVA = "0x3356AB0", Offset = "0x33556B0", VA = "0x183356AB0")]
		private void _SetupSlots(bool keepSelection = false)
		{
		}

		// Token: 0x0600B985 RID: 47493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B985")]
		[Address(RVA = "0x33570A0", Offset = "0x3355CA0", VA = "0x1833570A0")]
		private void _SetupUnlockTransferButton()
		{
		}

		// Token: 0x0600B986 RID: 47494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B986")]
		[Address(RVA = "0x3357630", Offset = "0x3356230", VA = "0x183357630")]
		private void _UpdateProductProgress()
		{
		}

		// Token: 0x0600B987 RID: 47495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B987")]
		[Address(RVA = "0x3355CE0", Offset = "0x33548E0", VA = "0x183355CE0")]
		private void _OnClueSlotPressed(int index)
		{
		}

		// Token: 0x0600B988 RID: 47496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B988")]
		[Address(RVA = "0x3355F10", Offset = "0x3354B10", VA = "0x183355F10")]
		private void _OnStorageCluePressed(IMeetingClue clue, MeetingClueItemView view)
		{
		}

		// Token: 0x0600B989 RID: 47497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B989")]
		[Address(RVA = "0x3356020", Offset = "0x3354C20", VA = "0x183356020")]
		private void _OnStorageRemoveCluePressed(IMeetingClue clue, MeetingClueItemView view)
		{
		}

		// Token: 0x0600B98A RID: 47498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B98A")]
		[Address(RVA = "0x3356190", Offset = "0x3354D90", VA = "0x183356190")]
		private void _OnStorageUnequipCluePressed(IMeetingClue clue, MeetingClueItemView view)
		{
		}

		// Token: 0x0600B98B RID: 47499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B98B")]
		[Address(RVA = "0x3356350", Offset = "0x3354F50", VA = "0x183356350")]
		private void _RefreshCluesEquipment(int result)
		{
		}

		// Token: 0x0600B98C RID: 47500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B98C")]
		[Address(RVA = "0x33569A0", Offset = "0x33555A0", VA = "0x1833569A0")]
		private void _SetupNewLabels()
		{
		}

		// Token: 0x0600B98D RID: 47501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B98D")]
		[Address(RVA = "0x3356F60", Offset = "0x3355B60", VA = "0x183356F60")]
		private void _SetupTitle()
		{
		}

		// Token: 0x0600B98E RID: 47502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B98E")]
		[Address(RVA = "0x3354FC0", Offset = "0x3353BC0", VA = "0x183354FC0")]
		private void SetupView()
		{
		}

		// Token: 0x0600B98F RID: 47503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B98F")]
		[Address(RVA = "0x33563F0", Offset = "0x3354FF0", VA = "0x1833563F0")]
		private void _SetOffsetMovePosition(float val)
		{
		}

		// Token: 0x0600B990 RID: 47504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B990")]
		[Address(RVA = "0x3356700", Offset = "0x3355300", VA = "0x183356700")]
		private void _SetOffsetMoved(bool moved)
		{
		}

		// Token: 0x0600B991 RID: 47505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B991")]
		[Address(RVA = "0x3354250", Offset = "0x3352E50", VA = "0x183354250")]
		public void OnAutoEquipClicked()
		{
		}

		// Token: 0x0600B992 RID: 47506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B992")]
		[Address(RVA = "0x33549F0", Offset = "0x33535F0", VA = "0x1833549F0")]
		public void OnInactiveAutoEquipClicked()
		{
		}

		// Token: 0x0600B993 RID: 47507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B993")]
		[Address(RVA = "0x3354A70", Offset = "0x3353670", VA = "0x183354A70")]
		public void OnProductButtonPressed()
		{
		}

		// Token: 0x0600B994 RID: 47508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B994")]
		[Address(RVA = "0x3354B60", Offset = "0x3353760", VA = "0x183354B60")]
		public void OnRecvButtonPressed()
		{
		}

		// Token: 0x0600B995 RID: 47509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B995")]
		[Address(RVA = "0x3354CC0", Offset = "0x33538C0", VA = "0x183354CC0")]
		public void OnSendButtonPressed()
		{
		}

		// Token: 0x0600B996 RID: 47510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B996")]
		[Address(RVA = "0x3355B30", Offset = "0x3354730", VA = "0x183355B30")]
		private void Update()
		{
		}

		// Token: 0x0600B997 RID: 47511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B997")]
		[Address(RVA = "0x3354440", Offset = "0x3353040", VA = "0x183354440")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600B998 RID: 47512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B998")]
		[Address(RVA = "0x3354540", Offset = "0x3353140", VA = "0x183354540")]
		public void OnDetailButtonPressed()
		{
		}

		// Token: 0x0600B999 RID: 47513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B999")]
		[Address(RVA = "0x33543D0", Offset = "0x3352FD0", VA = "0x1833543D0")]
		public void OnBackgroundPressed()
		{
		}

		// Token: 0x0600B99A RID: 47514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B99A")]
		[Address(RVA = "0x3354EE0", Offset = "0x3353AE0", VA = "0x183354EE0")]
		public void OnUnlockButtonPressed()
		{
		}

		// Token: 0x0600B99B RID: 47515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B99B")]
		[Address(RVA = "0x3354DA0", Offset = "0x33539A0", VA = "0x183354DA0")]
		public void OnStationCharacterButton0Pressed()
		{
		}

		// Token: 0x0600B99C RID: 47516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B99C")]
		[Address(RVA = "0x3354E40", Offset = "0x3353A40", VA = "0x183354E40")]
		public void OnStationCharacterButton1Pressed()
		{
		}

		// Token: 0x0600B99D RID: 47517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B99D")]
		[Address(RVA = "0x3357910", Offset = "0x3356510", VA = "0x183357910")]
		public BuildingMeetingHomeState()
		{
		}

		// Token: 0x0600B9A6 RID: 47526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9A6")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B9A7 RID: 47527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9A7")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0400B801 RID: 47105
		[Token(Token = "0x400B801")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _blueBackground;

		// Token: 0x0400B802 RID: 47106
		[Token(Token = "0x400B802")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MeetingCharacterView _characterView0;

		// Token: 0x0400B803 RID: 47107
		[Token(Token = "0x400B803")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MeetingCharacterView _characterView1;

		// Token: 0x0400B804 RID: 47108
		[Token(Token = "0x400B804")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0400B805 RID: 47109
		[Token(Token = "0x400B805")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MeetingClueSlotView[] _slotViews;

		// Token: 0x0400B806 RID: 47110
		[Token(Token = "0x400B806")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MeetingClueStorageView _storageView;

		// Token: 0x0400B807 RID: 47111
		[Token(Token = "0x400B807")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private MeetingClueReceiveView _receiveView;

		// Token: 0x0400B808 RID: 47112
		[Token(Token = "0x400B808")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private MeetingClueRemoveHintView _clueRemoveHint;

		// Token: 0x0400B809 RID: 47113
		[Token(Token = "0x400B809")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private MeetingClueProductView _clueProductView;

		// Token: 0x0400B80A RID: 47114
		[Token(Token = "0x400B80A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private BuildingRoomLevelView _roomLevelView;

		// Token: 0x0400B80B RID: 47115
		[Token(Token = "0x400B80B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _roomTitle;

		// Token: 0x0400B80C RID: 47116
		[Token(Token = "0x400B80C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _productProgress;

		// Token: 0x0400B80D RID: 47117
		[Token(Token = "0x400B80D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _newProductLabel;

		// Token: 0x0400B80E RID: 47118
		[Token(Token = "0x400B80E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _newRecvLabel;

		// Token: 0x0400B80F RID: 47119
		[Token(Token = "0x400B80F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _newSendLabel;

		// Token: 0x0400B810 RID: 47120
		[Token(Token = "0x400B810")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private RectTransform _characterPanel;

		// Token: 0x0400B811 RID: 47121
		[Token(Token = "0x400B811")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private RectTransform _slotsPanel;

		// Token: 0x0400B812 RID: 47122
		[Token(Token = "0x400B812")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private RectTransform _rightTopPanel;

		// Token: 0x0400B813 RID: 47123
		[Token(Token = "0x400B813")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RectTransform _rightBottomPanel;

		// Token: 0x0400B814 RID: 47124
		[Token(Token = "0x400B814")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private RectTransform _rightSidePanel;

		// Token: 0x0400B815 RID: 47125
		[Token(Token = "0x400B815")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private AnimationCurve _panelMoveCurve;

		// Token: 0x0400B816 RID: 47126
		[Token(Token = "0x400B816")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _receiveAllButtonRect;

		// Token: 0x0400B817 RID: 47127
		[Token(Token = "0x400B817")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private float _leftOffsetDistance;

		// Token: 0x0400B818 RID: 47128
		[Token(Token = "0x400B818")]
		[FieldOffset(Offset = "0x104")]
		[SerializeField]
		private float _rightOffsetDistance;

		// Token: 0x0400B819 RID: 47129
		[Token(Token = "0x400B819")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private float _rightSideOffsetDistance;

		// Token: 0x0400B81A RID: 47130
		[Token(Token = "0x400B81A")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private float _panelMoveDuration;

		// Token: 0x0400B81B RID: 47131
		[Token(Token = "0x400B81B")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Button _unlockTransferButton;

		// Token: 0x0400B81C RID: 47132
		[Token(Token = "0x400B81C")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Text _unlockEquipedCount;

		// Token: 0x0400B81D RID: 47133
		[Token(Token = "0x400B81D")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Text _unlockNeededCount;

		// Token: 0x0400B81E RID: 47134
		[Token(Token = "0x400B81E")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private GameObject _transferringPanel;

		// Token: 0x0400B81F RID: 47135
		[Token(Token = "0x400B81F")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private float _updateInterval;

		// Token: 0x0400B820 RID: 47136
		[Token(Token = "0x400B820")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Image _productProgressImage;

		// Token: 0x0400B821 RID: 47137
		[Token(Token = "0x400B821")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private MeetingClueConnectLineController _connectLineController;

		// Token: 0x0400B822 RID: 47138
		[Token(Token = "0x400B822")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private BuildingTwoContentNotify _notify;

		// Token: 0x0400B823 RID: 47139
		[Token(Token = "0x400B823")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private MeetingAutoEquipCluesView _panelAutoEquip;

		// Token: 0x0400B824 RID: 47140
		[Token(Token = "0x400B824")]
		[FieldOffset(Offset = "0x158")]
		private IMeetingSession m_currentSession;

		// Token: 0x0400B825 RID: 47141
		[Token(Token = "0x400B825")]
		[FieldOffset(Offset = "0x160")]
		private bool m_offsetMoved;

		// Token: 0x0400B826 RID: 47142
		[Token(Token = "0x400B826")]
		[FieldOffset(Offset = "0x161")]
		private bool m_tweeing;

		// Token: 0x0400B827 RID: 47143
		[Token(Token = "0x400B827")]
		[FieldOffset(Offset = "0x164")]
		private float m_timer;

		// Token: 0x0400B828 RID: 47144
		[Token(Token = "0x400B828")]
		[FieldOffset(Offset = "0x168")]
		private Vector2 m_characterPanelBasePosition;

		// Token: 0x0400B829 RID: 47145
		[Token(Token = "0x400B829")]
		[FieldOffset(Offset = "0x170")]
		private Vector2 m_slotsPanelBasePosition;

		// Token: 0x0400B82A RID: 47146
		[Token(Token = "0x400B82A")]
		[FieldOffset(Offset = "0x178")]
		private Vector2 m_rightTopPanelBasePosition;

		// Token: 0x0400B82B RID: 47147
		[Token(Token = "0x400B82B")]
		[FieldOffset(Offset = "0x180")]
		private Vector2 m_rightBottomPanelBasePosition;

		// Token: 0x0400B82C RID: 47148
		[Token(Token = "0x400B82C")]
		[FieldOffset(Offset = "0x188")]
		private Vector2 m_rightSidePanelBasePosition;

		// Token: 0x0400B82D RID: 47149
		[Token(Token = "0x400B82D")]
		[FieldOffset(Offset = "0x190")]
		private Vector2 m_characterPanelTargetPosition;

		// Token: 0x0400B82E RID: 47150
		[Token(Token = "0x400B82E")]
		[FieldOffset(Offset = "0x198")]
		private Vector2 m_slotPanelTargetPosition;

		// Token: 0x0400B82F RID: 47151
		[Token(Token = "0x400B82F")]
		[FieldOffset(Offset = "0x1A0")]
		private Vector2 m_rightTopPanelTargetPosition;

		// Token: 0x0400B830 RID: 47152
		[Token(Token = "0x400B830")]
		[FieldOffset(Offset = "0x1A8")]
		private Vector2 m_rightBottomPanelTargetPosition;

		// Token: 0x0400B831 RID: 47153
		[Token(Token = "0x400B831")]
		[FieldOffset(Offset = "0x1B0")]
		private Vector2 m_rightSidePanelTargetPosition;

		// Token: 0x0400B832 RID: 47154
		[Token(Token = "0x400B832")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400B833 RID: 47155
		[Token(Token = "0x400B833")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400B834 RID: 47156
		[Token(Token = "0x400B834")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0400B835 RID: 47157
		[Token(Token = "0x400B835")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400B836 RID: 47158
		[Token(Token = "0x400B836")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400B837 RID: 47159
		[Token(Token = "0x400B837")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdatePlayerStatus;

		// Token: 0x0400B838 RID: 47160
		[Token(Token = "0x400B838")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryReceiveTransferRewards;

		// Token: 0x0400B839 RID: 47161
		[Token(Token = "0x400B839")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OpenTransferResultPage;

		// Token: 0x0400B83A RID: 47162
		[Token(Token = "0x400B83A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetupStationaryCharacter;

		// Token: 0x0400B83B RID: 47163
		[Token(Token = "0x400B83B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetupSlots;

		// Token: 0x0400B83C RID: 47164
		[Token(Token = "0x400B83C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetupUnlockTransferButton;

		// Token: 0x0400B83D RID: 47165
		[Token(Token = "0x400B83D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateProductProgress;

		// Token: 0x0400B83E RID: 47166
		[Token(Token = "0x400B83E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnClueSlotPressed;

		// Token: 0x0400B83F RID: 47167
		[Token(Token = "0x400B83F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnStorageCluePressed;

		// Token: 0x0400B840 RID: 47168
		[Token(Token = "0x400B840")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnStorageRemoveCluePressed;

		// Token: 0x0400B841 RID: 47169
		[Token(Token = "0x400B841")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnStorageUnequipCluePressed;

		// Token: 0x0400B842 RID: 47170
		[Token(Token = "0x400B842")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RefreshCluesEquipment;

		// Token: 0x0400B843 RID: 47171
		[Token(Token = "0x400B843")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SetupNewLabels;

		// Token: 0x0400B844 RID: 47172
		[Token(Token = "0x400B844")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SetupTitle;

		// Token: 0x0400B845 RID: 47173
		[Token(Token = "0x400B845")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SetupView;

		// Token: 0x0400B846 RID: 47174
		[Token(Token = "0x400B846")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SetOffsetMovePosition;

		// Token: 0x0400B847 RID: 47175
		[Token(Token = "0x400B847")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SetOffsetMoved;

		// Token: 0x0400B848 RID: 47176
		[Token(Token = "0x400B848")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnAutoEquipClicked;

		// Token: 0x0400B849 RID: 47177
		[Token(Token = "0x400B849")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnInactiveAutoEquipClicked;

		// Token: 0x0400B84A RID: 47178
		[Token(Token = "0x400B84A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnProductButtonPressed;

		// Token: 0x0400B84B RID: 47179
		[Token(Token = "0x400B84B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnRecvButtonPressed;

		// Token: 0x0400B84C RID: 47180
		[Token(Token = "0x400B84C")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnSendButtonPressed;

		// Token: 0x0400B84D RID: 47181
		[Token(Token = "0x400B84D")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400B84E RID: 47182
		[Token(Token = "0x400B84E")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400B84F RID: 47183
		[Token(Token = "0x400B84F")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnDetailButtonPressed;

		// Token: 0x0400B850 RID: 47184
		[Token(Token = "0x400B850")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnBackgroundPressed;

		// Token: 0x0400B851 RID: 47185
		[Token(Token = "0x400B851")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnUnlockButtonPressed;

		// Token: 0x0400B852 RID: 47186
		[Token(Token = "0x400B852")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnStationCharacterButton0Pressed;

		// Token: 0x0400B853 RID: 47187
		[Token(Token = "0x400B853")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnStationCharacterButton1Pressed;

		// Token: 0x0400B854 RID: 47188
		[Token(Token = "0x400B854")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
