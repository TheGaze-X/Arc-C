using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004ED2 RID: 20178
	[Token(Token = "0x2004ED2")]
	public class FifthAnnivExploreMapController : PageSingleComponent, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x170046A3 RID: 18083
		// (get) Token: 0x0601E19F RID: 123295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046A3")]
		public FifthAnnivExploreProperty exploreProperty
		{
			[Token(Token = "0x601E19F")]
			[Address(RVA = "0x17CEC50", Offset = "0x17CD850", VA = "0x1817CEC50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170046A4 RID: 18084
		// (get) Token: 0x0601E1A0 RID: 123296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046A4")]
		public FifthAnnivExploreMapViewConfig mapViewConfig
		{
			[Token(Token = "0x601E1A0")]
			[Address(RVA = "0x17CECB0", Offset = "0x17CD8B0", VA = "0x1817CECB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170046A5 RID: 18085
		// (get) Token: 0x0601E1A1 RID: 123297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046A5")]
		public EventPool<FifthAnnivExploreUIEvent> eventPool
		{
			[Token(Token = "0x601E1A1")]
			[Address(RVA = "0x17CEBF0", Offset = "0x17CD7F0", VA = "0x1817CEBF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170046A6 RID: 18086
		// (get) Token: 0x0601E1A2 RID: 123298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046A6")]
		public StateEngine stateEngine
		{
			[Token(Token = "0x601E1A2")]
			[Address(RVA = "0x17CED10", Offset = "0x17CD910", VA = "0x1817CED10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170046A7 RID: 18087
		// (get) Token: 0x0601E1A3 RID: 123299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046A7")]
		public FifthAnnivExploreMapCameraRTHolder cameraRTHolder
		{
			[Token(Token = "0x601E1A3")]
			[Address(RVA = "0x17CEB90", Offset = "0x17CD790", VA = "0x1817CEB90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E1A4 RID: 123300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1A4")]
		[Address(RVA = "0x17CC700", Offset = "0x17CB300", VA = "0x1817CC700", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x0601E1A5 RID: 123301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1A5")]
		[Address(RVA = "0x17CD090", Offset = "0x17CBC90", VA = "0x1817CD090")]
		public void ReloadMap(bool isInit, bool isNewGame = false)
		{
		}

		// Token: 0x0601E1A6 RID: 123302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1A6")]
		[Address(RVA = "0x17CCEC0", Offset = "0x17CBAC0", VA = "0x1817CCEC0")]
		public void OpenQuitDialog()
		{
		}

		// Token: 0x0601E1A7 RID: 123303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1A7")]
		[Address(RVA = "0x17CCCF0", Offset = "0x17CB8F0", VA = "0x1817CCCF0")]
		public void OpenMissionDialog()
		{
		}

		// Token: 0x0601E1A8 RID: 123304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1A8")]
		[Address(RVA = "0x17CC460", Offset = "0x17CB060", VA = "0x1817CC460")]
		public void FinishGame()
		{
		}

		// Token: 0x0601E1A9 RID: 123305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1A9")]
		[Address(RVA = "0x17CE580", Offset = "0x17CD180", VA = "0x1817CE580")]
		private void _OnStateEnter(Type stateType, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x0601E1AA RID: 123306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1AA")]
		[Address(RVA = "0x17CE7C0", Offset = "0x17CD3C0", VA = "0x1817CE7C0")]
		private void _OnStateResume(Type stateType, bool isBack, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x0601E1AB RID: 123307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1AB")]
		[Address(RVA = "0x17CDBE0", Offset = "0x17CC7E0", VA = "0x1817CDBE0")]
		private void _OnBeforeTransition(Type stateType, Type toType, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x0601E1AC RID: 123308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1AC")]
		[Address(RVA = "0x17CE6A0", Offset = "0x17CD2A0", VA = "0x1817CE6A0")]
		private void _OnStatePause(Type stateType, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x0601E1AD RID: 123309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1AD")]
		[Address(RVA = "0x17CDD00", Offset = "0x17CC900", VA = "0x1817CDD00")]
		private void _OnHeritageBtnClick()
		{
		}

		// Token: 0x0601E1AE RID: 123310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1AE")]
		[Address(RVA = "0x17CE470", Offset = "0x17CD070", VA = "0x1817CE470")]
		private void _OnProgressBtnClick()
		{
		}

		// Token: 0x0601E1AF RID: 123311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1AF")]
		[Address(RVA = "0x17CD4D0", Offset = "0x17CC0D0", VA = "0x1817CD4D0")]
		private void _CloseTargetInfo()
		{
		}

		// Token: 0x0601E1B0 RID: 123312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1B0")]
		[Address(RVA = "0x17CD590", Offset = "0x17CC190", VA = "0x1817CD590")]
		private void _InitController()
		{
		}

		// Token: 0x0601E1B1 RID: 123313 RVA: 0x000AD868 File Offset: 0x000ABA68
		[Token(Token = "0x601E1B1")]
		[Address(RVA = "0x17CD3D0", Offset = "0x17CBFD0", VA = "0x1817CD3D0")]
		private bool _CheckUIStable()
		{
			return default(bool);
		}

		// Token: 0x0601E1B2 RID: 123314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1B2")]
		[Address(RVA = "0x17CE260", Offset = "0x17CCE60", VA = "0x1817CE260")]
		private void _OnMsgForwardToNextNodeSuc()
		{
		}

		// Token: 0x0601E1B3 RID: 123315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1B3")]
		[Address(RVA = "0x17CE1D0", Offset = "0x17CCDD0", VA = "0x1817CE1D0")]
		private void _OnMsgForwardToNextNodeFail()
		{
		}

		// Token: 0x0601E1B4 RID: 123316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1B4")]
		[Address(RVA = "0x17CE0D0", Offset = "0x17CCCD0", VA = "0x1817CE0D0")]
		private void _OnMsgBackToMap()
		{
		}

		// Token: 0x0601E1B5 RID: 123317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1B5")]
		[Address(RVA = "0x17CE380", Offset = "0x17CCF80", VA = "0x1817CE380")]
		private void _OnMsgUpdateTopMenu()
		{
		}

		// Token: 0x0601E1B6 RID: 123318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1B6")]
		[Address(RVA = "0x17CC770", Offset = "0x17CB370", VA = "0x1817CC770", Slot = "12")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601E1B7 RID: 123319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1B7")]
		[Address(RVA = "0x17CC4C0", Offset = "0x17CB0C0", VA = "0x1817CC4C0", Slot = "13")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601E1B8 RID: 123320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1B8")]
		[Address(RVA = "0x17CDF20", Offset = "0x17CCB20", VA = "0x1817CDF20")]
		private void _OnMsgBackFromMissionDialog()
		{
		}

		// Token: 0x0601E1B9 RID: 123321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1B9")]
		[Address(RVA = "0x17CE8F0", Offset = "0x17CD4F0", VA = "0x1817CE8F0")]
		public FifthAnnivExploreMapController()
		{
		}

		// Token: 0x0601E1BA RID: 123322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1BA")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x040280CC RID: 164044
		[Token(Token = "0x40280CC")]
		[NonSerialized]
		public const int MSG_FORWARD_TO_NEXT_NODE = 1;

		// Token: 0x040280CD RID: 164045
		[Token(Token = "0x40280CD")]
		[NonSerialized]
		public const int MSG_BACK_TO_MAP = 2;

		// Token: 0x040280CE RID: 164046
		[Token(Token = "0x40280CE")]
		[NonSerialized]
		public const int MSG_UPDATE_TOP_MENU = 3;

		// Token: 0x040280CF RID: 164047
		[Token(Token = "0x40280CF")]
		[NonSerialized]
		public const int MSG_BACK_FROM_MISSION_DIALOG = 4;

		// Token: 0x040280D0 RID: 164048
		[Token(Token = "0x40280D0")]
		[NonSerialized]
		public const int MSG_OPEN_TARGET_VIEW = 5;

		// Token: 0x040280D1 RID: 164049
		[Token(Token = "0x40280D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x040280D2 RID: 164050
		[Token(Token = "0x40280D2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FifthAnnivExploreMapCameraController _cameraController;

		// Token: 0x040280D3 RID: 164051
		[Token(Token = "0x40280D3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FifthAnnivExploreMapView _mapView;

		// Token: 0x040280D4 RID: 164052
		[Token(Token = "0x40280D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rectTransformBottomLeft;

		// Token: 0x040280D5 RID: 164053
		[Token(Token = "0x40280D5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _rectTransformBottomRight;

		// Token: 0x040280D6 RID: 164054
		[Token(Token = "0x40280D6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _rectTransformTopLeft;

		// Token: 0x040280D7 RID: 164055
		[Token(Token = "0x40280D7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _rectTransformTopRight;

		// Token: 0x040280D8 RID: 164056
		[Token(Token = "0x40280D8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private FifthAnnivExploreTopMenuView _topMenuView;

		// Token: 0x040280D9 RID: 164057
		[Token(Token = "0x40280D9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private FifthAnnivExploreTargetInfoView _targetInfoView;

		// Token: 0x040280DA RID: 164058
		[Token(Token = "0x40280DA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FifthAnnivExploreSideInfoView _sideInfoView;

		// Token: 0x040280DB RID: 164059
		[Token(Token = "0x40280DB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _lineCornerCountFactor;

		// Token: 0x040280DC RID: 164060
		[Token(Token = "0x40280DC")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _lineMaxAmplitudeFactor;

		// Token: 0x040280DD RID: 164061
		[Token(Token = "0x40280DD")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x040280DE RID: 164062
		[Token(Token = "0x40280DE")]
		[FieldOffset(Offset = "0x80")]
		private FifthAnnivExploreProperty m_exploreProperty;

		// Token: 0x040280DF RID: 164063
		[Token(Token = "0x40280DF")]
		[FieldOffset(Offset = "0x88")]
		private FifthAnnivExploreMapViewConfig m_mapViewConfig;

		// Token: 0x040280E0 RID: 164064
		[Token(Token = "0x40280E0")]
		[FieldOffset(Offset = "0x90")]
		private FifthAnnivExploreMapController.RouteCornerPos m_cornerPos;

		// Token: 0x040280E1 RID: 164065
		[Token(Token = "0x40280E1")]
		[FieldOffset(Offset = "0xB0")]
		private StateEngine.OnStateChangeListener m_stateChangeListener;

		// Token: 0x040280E2 RID: 164066
		[Token(Token = "0x40280E2")]
		[FieldOffset(Offset = "0xB8")]
		private EventPool<FifthAnnivExploreUIEvent> m_eventPool;

		// Token: 0x040280E3 RID: 164067
		[Token(Token = "0x40280E3")]
		[FieldOffset(Offset = "0xC0")]
		private FifthAnnivExploreTargetInfoProperty m_targetInfoProperty;

		// Token: 0x040280E4 RID: 164068
		[Token(Token = "0x40280E4")]
		[FieldOffset(Offset = "0xC8")]
		private int m_quitDialogInstId;

		// Token: 0x040280E5 RID: 164069
		[Token(Token = "0x40280E5")]
		[FieldOffset(Offset = "0xD0")]
		private FifthAnnivExploreMapCameraRTHolder m_cameraRTHolder;

		// Token: 0x040280E6 RID: 164070
		[Token(Token = "0x40280E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_exploreProperty;

		// Token: 0x040280E7 RID: 164071
		[Token(Token = "0x40280E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_mapViewConfig;

		// Token: 0x040280E8 RID: 164072
		[Token(Token = "0x40280E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_eventPool;

		// Token: 0x040280E9 RID: 164073
		[Token(Token = "0x40280E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_stateEngine;

		// Token: 0x040280EA RID: 164074
		[Token(Token = "0x40280EA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_cameraRTHolder;

		// Token: 0x040280EB RID: 164075
		[Token(Token = "0x40280EB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040280EC RID: 164076
		[Token(Token = "0x40280EC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ReloadMap;

		// Token: 0x040280ED RID: 164077
		[Token(Token = "0x40280ED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OpenQuitDialog;

		// Token: 0x040280EE RID: 164078
		[Token(Token = "0x40280EE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OpenMissionDialog;

		// Token: 0x040280EF RID: 164079
		[Token(Token = "0x40280EF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FinishGame;

		// Token: 0x040280F0 RID: 164080
		[Token(Token = "0x40280F0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnStateEnter;

		// Token: 0x040280F1 RID: 164081
		[Token(Token = "0x40280F1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnStateResume;

		// Token: 0x040280F2 RID: 164082
		[Token(Token = "0x40280F2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnBeforeTransition;

		// Token: 0x040280F3 RID: 164083
		[Token(Token = "0x40280F3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnStatePause;

		// Token: 0x040280F4 RID: 164084
		[Token(Token = "0x40280F4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnHeritageBtnClick;

		// Token: 0x040280F5 RID: 164085
		[Token(Token = "0x40280F5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnProgressBtnClick;

		// Token: 0x040280F6 RID: 164086
		[Token(Token = "0x40280F6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CloseTargetInfo;

		// Token: 0x040280F7 RID: 164087
		[Token(Token = "0x40280F7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InitController;

		// Token: 0x040280F8 RID: 164088
		[Token(Token = "0x40280F8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CheckUIStable;

		// Token: 0x040280F9 RID: 164089
		[Token(Token = "0x40280F9")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnMsgForwardToNextNodeSuc;

		// Token: 0x040280FA RID: 164090
		[Token(Token = "0x40280FA")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnMsgForwardToNextNodeFail;

		// Token: 0x040280FB RID: 164091
		[Token(Token = "0x40280FB")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnMsgBackToMap;

		// Token: 0x040280FC RID: 164092
		[Token(Token = "0x40280FC")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnMsgUpdateTopMenu;

		// Token: 0x040280FD RID: 164093
		[Token(Token = "0x40280FD")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040280FE RID: 164094
		[Token(Token = "0x40280FE")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x040280FF RID: 164095
		[Token(Token = "0x40280FF")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnMsgBackFromMissionDialog;

		// Token: 0x04028100 RID: 164096
		[Token(Token = "0x4028100")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004ED3 RID: 20179
		[Token(Token = "0x2004ED3")]
		public struct RouteCornerPos
		{
			// Token: 0x04028101 RID: 164097
			[Token(Token = "0x4028101")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 bottomLeftPos;

			// Token: 0x04028102 RID: 164098
			[Token(Token = "0x4028102")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 bottomRightPos;

			// Token: 0x04028103 RID: 164099
			[Token(Token = "0x4028103")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 topLeftPos;

			// Token: 0x04028104 RID: 164100
			[Token(Token = "0x4028104")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 topRightPos;
		}
	}
}
