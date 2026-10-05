using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005420 RID: 21536
	[Token(Token = "0x2005420")]
	public class RoguelikeDungeonController : PageSingleComponent, ICompDialogCallBack, IPlayerDataListener, IHotfixable
	{
		// Token: 0x17004A2E RID: 18990
		// (get) Token: 0x0601FAA3 RID: 129699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A2E")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x601FAA3")]
			[Address(RVA = "0x1958CB0", Offset = "0x19578B0", VA = "0x181958CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A2F RID: 18991
		// (get) Token: 0x0601FAA4 RID: 129700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A2F")]
		public RoguelikeCommonTopMenu commonTopMenuPrefab
		{
			[Token(Token = "0x601FAA4")]
			[Address(RVA = "0x1958C40", Offset = "0x1957840", VA = "0x181958C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A30 RID: 18992
		// (get) Token: 0x0601FAA5 RID: 129701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A30")]
		public RoguelikeDungeonZoneViewProperty dungeonZoneProp
		{
			[Token(Token = "0x601FAA5")]
			[Address(RVA = "0x1958DB0", Offset = "0x19579B0", VA = "0x181958DB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A31 RID: 18993
		// (get) Token: 0x0601FAA6 RID: 129702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A31")]
		public RoguelikeFocusViewProperty focusProp
		{
			[Token(Token = "0x601FAA6")]
			[Address(RVA = "0x1958EA0", Offset = "0x1957AA0", VA = "0x181958EA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A32 RID: 18994
		// (get) Token: 0x0601FAA7 RID: 129703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A32")]
		public RoguelikeRewardViewProperty rewardProp
		{
			[Token(Token = "0x601FAA7")]
			[Address(RVA = "0x1959090", Offset = "0x1957C90", VA = "0x181959090")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A33 RID: 18995
		// (get) Token: 0x0601FAA8 RID: 129704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A33")]
		public EventPool<RoguelikeUIEvent> eventPool
		{
			[Token(Token = "0x601FAA8")]
			[Address(RVA = "0x1958E20", Offset = "0x1957A20", VA = "0x181958E20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A34 RID: 18996
		// (get) Token: 0x0601FAA9 RID: 129705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A34")]
		public StateEngine stateEngine
		{
			[Token(Token = "0x601FAA9")]
			[Address(RVA = "0x1959190", Offset = "0x1957D90", VA = "0x181959190")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A35 RID: 18997
		// (get) Token: 0x0601FAAA RID: 129706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A35")]
		public EventTrigger backGroundEventTrigger
		{
			[Token(Token = "0x601FAAA")]
			[Address(RVA = "0x1958B60", Offset = "0x1957760", VA = "0x181958B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A36 RID: 18998
		// (get) Token: 0x0601FAAB RID: 129707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A36")]
		public RectTransform mapPreviewRoot
		{
			[Token(Token = "0x601FAAB")]
			[Address(RVA = "0x1958F20", Offset = "0x1957B20", VA = "0x181958F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A37 RID: 18999
		// (get) Token: 0x0601FAAC RID: 129708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A37")]
		public RoguelikeCameraController cameraController
		{
			[Token(Token = "0x601FAAC")]
			[Address(RVA = "0x1958BD0", Offset = "0x19577D0", VA = "0x181958BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A38 RID: 19000
		// (get) Token: 0x0601FAAD RID: 129709 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FAAE RID: 129710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A38")]
		public RoguelikeDungeonFloatView dungeonFloat
		{
			[Token(Token = "0x601FAAD")]
			[Address(RVA = "0x1958D30", Offset = "0x1957930", VA = "0x181958D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601FAAE")]
			[Address(RVA = "0x1959300", Offset = "0x1957F00", VA = "0x181959300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004A39 RID: 19001
		// (get) Token: 0x0601FAAF RID: 129711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A39")]
		public RoguelikeDungeonZoneViewBase zoneView
		{
			[Token(Token = "0x601FAAF")]
			[Address(RVA = "0x1959280", Offset = "0x1957E80", VA = "0x181959280")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A3A RID: 19002
		// (get) Token: 0x0601FAB0 RID: 129712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A3A")]
		public RoguelikeSingleTopicResHolder resHolder
		{
			[Token(Token = "0x601FAB0")]
			[Address(RVA = "0x1959010", Offset = "0x1957C10", VA = "0x181959010")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A3B RID: 19003
		// (get) Token: 0x0601FAB1 RID: 129713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A3B")]
		public string topicId
		{
			[Token(Token = "0x601FAB1")]
			[Address(RVA = "0x1959200", Offset = "0x1957E00", VA = "0x181959200")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A3C RID: 19004
		// (get) Token: 0x0601FAB2 RID: 129714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A3C")]
		public RoguelikeDungeonController.PendingEventHandler pendingEvtHandler
		{
			[Token(Token = "0x601FAB2")]
			[Address(RVA = "0x1958F90", Offset = "0x1957B90", VA = "0x181958F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004A3D RID: 19005
		// (get) Token: 0x0601FAB3 RID: 129715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A3D")]
		public RoguelikeDungeonSpZonePluginBase spZonePlugin
		{
			[Token(Token = "0x601FAB3")]
			[Address(RVA = "0x1959110", Offset = "0x1957D10", VA = "0x181959110")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FAB4 RID: 129716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAB4")]
		[Address(RVA = "0x1954000", Offset = "0x1952C00", VA = "0x181954000", Slot = "7")]
		protected override void OnStart()
		{
		}

		// Token: 0x0601FAB5 RID: 129717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAB5")]
		[Address(RVA = "0x1953E10", Offset = "0x1952A10", VA = "0x181953E10", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0601FAB6 RID: 129718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FAB6")]
		[Address(RVA = "0x1953580", Offset = "0x1952180", VA = "0x181953580")]
		public static string GetCurrentTopicId()
		{
			return null;
		}

		// Token: 0x0601FAB7 RID: 129719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FAB7")]
		[Address(RVA = "0x1953660", Offset = "0x1952260", VA = "0x181953660")]
		public static RoguelikeTopicDetail GetDetailData(string topicId)
		{
			return null;
		}

		// Token: 0x0601FAB8 RID: 129720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAB8")]
		[Address(RVA = "0x1956B80", Offset = "0x1955780", VA = "0x181956B80")]
		private void _InitController()
		{
		}

		// Token: 0x0601FAB9 RID: 129721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAB9")]
		[Address(RVA = "0x1957A70", Offset = "0x1956670", VA = "0x181957A70")]
		private void _OnNodeClicked(RoguelikeDungeonNode node, Bounds focusBound)
		{
		}

		// Token: 0x0601FABA RID: 129722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FABA")]
		[Address(RVA = "0x1958350", Offset = "0x1956F50", VA = "0x181958350")]
		private void _OnZoneCreated(RoguelikeOnDungeonZoneCreatedArgs args)
		{
		}

		// Token: 0x0601FABB RID: 129723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FABB")]
		[Address(RVA = "0x1957990", Offset = "0x1956590", VA = "0x181957990")]
		private void _OnMenuCreated(RoguelikeMenu menuPanel)
		{
		}

		// Token: 0x0601FABC RID: 129724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FABC")]
		[Address(RVA = "0x1957810", Offset = "0x1956410", VA = "0x181957810")]
		private void _OnDungeonFloatCreated(GameObject obj)
		{
		}

		// Token: 0x0601FABD RID: 129725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FABD")]
		[Address(RVA = "0x1957F80", Offset = "0x1956B80", VA = "0x181957F80")]
		private void _OnStateEnter(Type stateType, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x0601FABE RID: 129726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FABE")]
		[Address(RVA = "0x1958200", Offset = "0x1956E00", VA = "0x181958200")]
		private void _OnStateResume(Type stateType, bool isBack, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x0601FABF RID: 129727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FABF")]
		[Address(RVA = "0x1957640", Offset = "0x1956240", VA = "0x181957640")]
		private void _OnBeforeTransition(Type stateType, Type toType, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x0601FAC0 RID: 129728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAC0")]
		[Address(RVA = "0x19580C0", Offset = "0x1956CC0", VA = "0x1819580C0")]
		private void _OnStatePause(Type stateType, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x0601FAC1 RID: 129729 RVA: 0x000B2A70 File Offset: 0x000B0C70
		[Token(Token = "0x601FAC1")]
		[Address(RVA = "0x1952210", Offset = "0x1950E10", VA = "0x181952210", Slot = "14")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0601FAC2 RID: 129730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAC2")]
		[Address(RVA = "0x1953F30", Offset = "0x1952B30", VA = "0x181953F30", Slot = "15")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0601FAC3 RID: 129731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FAC3")]
		[Address(RVA = "0x1952E50", Offset = "0x1951A50", VA = "0x181952E50")]
		public static RoguelikeCharSelectStateBean.Input CreateTicketCharSelectInput(string tickedId, Action<string, int, Action> resultCallback, [Optional] Action onQuit)
		{
			return null;
		}

		// Token: 0x0601FAC4 RID: 129732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAC4")]
		[Address(RVA = "0x1955CC0", Offset = "0x19548C0", VA = "0x181955CC0")]
		public void SelectRecruitChar(string ticketIndex, Action<string, int, Action> resultCallback, [Optional] Action onQuit)
		{
		}

		// Token: 0x0601FAC5 RID: 129733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAC5")]
		[Address(RVA = "0x1953D00", Offset = "0x1952900", VA = "0x181953D00")]
		public void OnCommonSelectRecruitChar(string ticketIndex, [Optional] Action onQuit)
		{
		}

		// Token: 0x0601FAC6 RID: 129734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAC6")]
		[Address(RVA = "0x1952830", Offset = "0x1951430", VA = "0x181952830")]
		public void ConsumeRecruitUpgradeTicket(string ticketIndex, int selectedInstId, [Optional] Action onFinished)
		{
		}

		// Token: 0x0601FAC7 RID: 129735 RVA: 0x000B2A88 File Offset: 0x000B0C88
		[Token(Token = "0x601FAC7")]
		[Address(RVA = "0x19522C0", Offset = "0x1950EC0", VA = "0x1819522C0")]
		public bool CheckIfHaveActiveRecruitAndOpen([Optional] Action onQuit)
		{
			return default(bool);
		}

		// Token: 0x0601FAC8 RID: 129736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAC8")]
		public void OpenDialog<Dialog, Input>(UICompBuilder<Dialog, Input> builder, out int instId) where Dialog : UICompDialog<Input> where Input : class
		{
		}

		// Token: 0x0601FAC9 RID: 129737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAC9")]
		public void BindDialogCallBack<CallBackHandler>(CallBackHandler handler, int instId) where CallBackHandler : class, ICompDialogCallBack
		{
		}

		// Token: 0x0601FACA RID: 129738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FACA")]
		[Address(RVA = "0x19569D0", Offset = "0x19555D0", VA = "0x1819569D0")]
		private void _CheckNeedToBind()
		{
		}

		// Token: 0x0601FACB RID: 129739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FACB")]
		[Address(RVA = "0x1953780", Offset = "0x1952380", VA = "0x181953780", Slot = "12")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601FACC RID: 129740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FACC")]
		[Address(RVA = "0x19585C0", Offset = "0x19571C0", VA = "0x1819585C0")]
		private IEnumerator _UpdateGacha(List<PlayerRoguelikeCharacter> chars, [Optional] Action onFinished)
		{
			return null;
		}

		// Token: 0x0601FACD RID: 129741 RVA: 0x000B2AA0 File Offset: 0x000B0CA0
		[Token(Token = "0x601FACD")]
		[Address(RVA = "0x1956B00", Offset = "0x1955700", VA = "0x181956B00")]
		private long _GetBGMInstId()
		{
			return 0L;
		}

		// Token: 0x0601FACE RID: 129742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FACE")]
		[Address(RVA = "0x19584D0", Offset = "0x19570D0", VA = "0x1819584D0")]
		private void _TryToLoadSpZonePlugin()
		{
		}

		// Token: 0x0601FACF RID: 129743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FACF")]
		[Address(RVA = "0x1954890", Offset = "0x1953490", VA = "0x181954890")]
		public void ReloadZoneMap()
		{
		}

		// Token: 0x0601FAD0 RID: 129744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAD0")]
		[Address(RVA = "0x1954430", Offset = "0x1953030", VA = "0x181954430")]
		public void ReloadDungeon(bool notifyFromInitState = false)
		{
		}

		// Token: 0x0601FAD1 RID: 129745 RVA: 0x000B2AB8 File Offset: 0x000B0CB8
		[Token(Token = "0x601FAD1")]
		[Address(RVA = "0x1956280", Offset = "0x1954E80", VA = "0x181956280")]
		public bool TryLoadFocusStage()
		{
			return default(bool);
		}

		// Token: 0x0601FAD2 RID: 129746 RVA: 0x000B2AD0 File Offset: 0x000B0CD0
		[Token(Token = "0x601FAD2")]
		[Address(RVA = "0x1952090", Offset = "0x1950C90", VA = "0x181952090")]
		public bool CheckIfCanLoadShopState()
		{
			return default(bool);
		}

		// Token: 0x0601FAD3 RID: 129747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAD3")]
		[Address(RVA = "0x1953AB0", Offset = "0x19526B0", VA = "0x181953AB0")]
		public void HandlerRelicGetPushMsg(List<string> idList)
		{
		}

		// Token: 0x0601FAD4 RID: 129748 RVA: 0x000B2AE8 File Offset: 0x000B0CE8
		[Token(Token = "0x601FAD4")]
		[Address(RVA = "0x1956590", Offset = "0x1955190", VA = "0x181956590")]
		public bool TryProcessTicket()
		{
			return default(bool);
		}

		// Token: 0x0601FAD5 RID: 129749 RVA: 0x000B2B00 File Offset: 0x000B0D00
		[Token(Token = "0x601FAD5")]
		[Address(RVA = "0x19564D0", Offset = "0x19550D0", VA = "0x1819564D0")]
		public bool TryProcessChangeCopper()
		{
			return default(bool);
		}

		// Token: 0x0601FAD6 RID: 129750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAD6")]
		[Address(RVA = "0x1954CC0", Offset = "0x19538C0", VA = "0x181954CC0")]
		public void RequestGiveUpNodeMission(string missionId)
		{
		}

		// Token: 0x0601FAD7 RID: 129751 RVA: 0x000B2B18 File Offset: 0x000B0D18
		[Token(Token = "0x601FAD7")]
		[Address(RVA = "0x1953C50", Offset = "0x1952850", VA = "0x181953C50")]
		public bool NeedZoneTransition()
		{
			return default(bool);
		}

		// Token: 0x0601FAD8 RID: 129752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAD8")]
		[Address(RVA = "0x1955F80", Offset = "0x1954B80", VA = "0x181955F80")]
		public void SetZoneTransitionViewed()
		{
		}

		// Token: 0x0601FAD9 RID: 129753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAD9")]
		[Address(RVA = "0x1955ED0", Offset = "0x1954AD0", VA = "0x181955ED0")]
		public void SetRaycastBlock(bool flag)
		{
		}

		// Token: 0x0601FADA RID: 129754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FADA")]
		public void RegisterMenuAdapter<TState>(RoguelikeMenuAdapter adapter, [Optional] Type adapterType) where TState : State
		{
		}

		// Token: 0x0601FADB RID: 129755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FADB")]
		[Address(RVA = "0x1954300", Offset = "0x1952F00", VA = "0x181954300")]
		public void RegisterMenuAdapter(State state, RoguelikeMenuAdapter adapter, [Optional] Type adapterType)
		{
		}

		// Token: 0x0601FADC RID: 129756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FADC")]
		public TEffect AttachRoguelikeEffect<TEffect>(TEffect effectPrefab) where TEffect : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0601FADD RID: 129757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FADD")]
		[Address(RVA = "0x1956040", Offset = "0x1954C40", VA = "0x181956040")]
		public void ShowDungeon(bool isShow, bool fastMode)
		{
		}

		// Token: 0x0601FADE RID: 129758 RVA: 0x000B2B30 File Offset: 0x000B0D30
		[Token(Token = "0x601FADE")]
		[Address(RVA = "0x1954BE0", Offset = "0x19537E0", VA = "0x181954BE0")]
		public bool RequestExitRoguelike()
		{
			return default(bool);
		}

		// Token: 0x0601FADF RID: 129759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FADF")]
		[Address(RVA = "0x1952740", Offset = "0x1951340", VA = "0x181952740")]
		public void CleanEffect()
		{
		}

		// Token: 0x0601FAE0 RID: 129760 RVA: 0x000B2B48 File Offset: 0x000B0D48
		[Token(Token = "0x601FAE0")]
		[Address(RVA = "0x1951EB0", Offset = "0x1950AB0", VA = "0x181951EB0")]
		public bool CheckDialogCoroActive()
		{
			return default(bool);
		}

		// Token: 0x0601FAE1 RID: 129761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FAE1")]
		[Address(RVA = "0x1958410", Offset = "0x1957010", VA = "0x181958410")]
		private IEnumerator _OpenAvailInterDialogCoro()
		{
			return null;
		}

		// Token: 0x0601FAE2 RID: 129762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAE2")]
		[Address(RVA = "0x19540C0", Offset = "0x1952CC0", VA = "0x1819540C0")]
		public void OpenAvailInterDialog()
		{
		}

		// Token: 0x0601FAE3 RID: 129763 RVA: 0x000B2B60 File Offset: 0x000B0D60
		[Token(Token = "0x601FAE3")]
		public bool SetModuleState<ModuleType>(bool running) where ModuleType : RoguelikeDungeonModule
		{
			return default(bool);
		}

		// Token: 0x0601FAE4 RID: 129764 RVA: 0x000B2B78 File Offset: 0x000B0D78
		[Token(Token = "0x601FAE4")]
		[Address(RVA = "0x19524E0", Offset = "0x19510E0", VA = "0x1819524E0")]
		public bool CheckIfStateDirectOpenByDungeon(Type stateType)
		{
			return default(bool);
		}

		// Token: 0x0601FAE5 RID: 129765 RVA: 0x000B2B90 File Offset: 0x000B0D90
		[Token(Token = "0x601FAE5")]
		[Address(RVA = "0x1951F30", Offset = "0x1950B30", VA = "0x181951F30")]
		public bool CheckFrontStateDontShowMsg()
		{
			return default(bool);
		}

		// Token: 0x0601FAE6 RID: 129766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAE6")]
		[Address(RVA = "0x1956180", Offset = "0x1954D80", VA = "0x181956180")]
		public void TriggerRoguelikeCustomNotify(string path, ValueBundle options)
		{
		}

		// Token: 0x0601FAE7 RID: 129767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAE7")]
		[Address(RVA = "0x1955120", Offset = "0x1953D20", VA = "0x181955120")]
		public void RequestLeaveSpZone()
		{
		}

		// Token: 0x0601FAE8 RID: 129768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FAE8")]
		[Address(RVA = "0x1955760", Offset = "0x1954360", VA = "0x181955760")]
		public static UIPageControllerParam SceneParamToRoguelike(DataBundle dataBundle)
		{
			return null;
		}

		// Token: 0x0601FAE9 RID: 129769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FAE9")]
		[Address(RVA = "0x1955480", Offset = "0x1954080", VA = "0x181955480")]
		public static UIPageControllerParam SceneParamToActivity(DataBundle dataBundle)
		{
			return null;
		}

		// Token: 0x0601FAEA RID: 129770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAEA")]
		[Address(RVA = "0x1951BE0", Offset = "0x19507E0", VA = "0x181951BE0")]
		public static void BattleFinishRedirection()
		{
		}

		// Token: 0x0601FAEB RID: 129771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAEB")]
		[Address(RVA = "0x19587E0", Offset = "0x19573E0", VA = "0x1819587E0")]
		public RoguelikeDungeonController()
		{
		}

		// Token: 0x0601FAF0 RID: 129776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAF0")]
		[Address(RVA = "0xF53770", Offset = "0xF52370", VA = "0x180F53770")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0601FAF1 RID: 129777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAF1")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0402AB51 RID: 174929
		[Token(Token = "0x402AB51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Type[] DONT_SHOW_MSG_STATES;

		// Token: 0x0402AB52 RID: 174930
		[Token(Token = "0x402AB52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeCommonTopMenu _commonTopMenuPrefab;

		// Token: 0x0402AB53 RID: 174931
		[Token(Token = "0x402AB53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x0402AB54 RID: 174932
		[Token(Token = "0x402AB54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0402AB55 RID: 174933
		[Token(Token = "0x402AB55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeCameraController _cameraController;

		// Token: 0x0402AB56 RID: 174934
		[Token(Token = "0x402AB56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RoguelikeCustomNotifyController _customNotifyController;

		// Token: 0x0402AB57 RID: 174935
		[Token(Token = "0x402AB57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private EventTrigger _backGroundEventTrigger;

		// Token: 0x0402AB58 RID: 174936
		[Token(Token = "0x402AB58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _menuHolder;

		// Token: 0x0402AB59 RID: 174937
		[Token(Token = "0x402AB59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private PrefabInstHolder _dungeonFloatHolder;

		// Token: 0x0402AB5A RID: 174938
		[Token(Token = "0x402AB5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _mapPreviewRoot;

		// Token: 0x0402AB5B RID: 174939
		[Token(Token = "0x402AB5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _panelRaycastBlock;

		// Token: 0x0402AB5C RID: 174940
		[Token(Token = "0x402AB5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0402AB5D RID: 174941
		[Token(Token = "0x402AB5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RoguelikeDungeonZoneViewProperty m_dungeonZoneProp;

		// Token: 0x0402AB5E RID: 174942
		[Token(Token = "0x402AB5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RoguelikeFocusViewProperty m_focusProp;

		// Token: 0x0402AB5F RID: 174943
		[Token(Token = "0x402AB5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RoguelikeRewardViewProperty m_rewardProp;

		// Token: 0x0402AB60 RID: 174944
		[Token(Token = "0x402AB60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private EventPool<RoguelikeUIEvent> m_eventPool;

		// Token: 0x0402AB61 RID: 174945
		[Token(Token = "0x402AB61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private StateEngine.OnStateChangeListener m_stateEngineListener;

		// Token: 0x0402AB62 RID: 174946
		[Token(Token = "0x402AB62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RoguelikeDungeonZoneViewBase m_zoneView;

		// Token: 0x0402AB63 RID: 174947
		[Token(Token = "0x402AB63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RogueZoneIndex m_notify;

		// Token: 0x0402AB64 RID: 174948
		[Token(Token = "0x402AB64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RoguelikeDungeonSpZonePluginBase m_spZonePlugin;

		// Token: 0x0402AB65 RID: 174949
		[Token(Token = "0x402AB65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool m_isGachaShowing;

		// Token: 0x0402AB66 RID: 174950
		[Token(Token = "0x402AB66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<RoguelikeDungeonModule> m_modules;

		// Token: 0x0402AB67 RID: 174951
		[Token(Token = "0x402AB67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool m_inited;

		// Token: 0x0402AB68 RID: 174952
		[Token(Token = "0x402AB68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		private bool m_accessedInitState;

		// Token: 0x0402AB69 RID: 174953
		[Token(Token = "0x402AB69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RoguelikeMenu m_menu;

		// Token: 0x0402AB6A RID: 174954
		[Token(Token = "0x402AB6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RoguelikeSingleTopicResHolder m_resHolder;

		// Token: 0x0402AB6B RID: 174955
		[Token(Token = "0x402AB6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string m_topicId;

		// Token: 0x0402AB6C RID: 174956
		[Token(Token = "0x402AB6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RoguelikeDungeonController.PendingEventHandler m_pendingEvtHandler;

		// Token: 0x0402AB6D RID: 174957
		[Token(Token = "0x402AB6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RoguelikeDungeonController.StateStackContext m_stateStackContext;

		// Token: 0x0402AB6E RID: 174958
		[Token(Token = "0x402AB6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Dictionary<int, ICompDialogCallBack> m_compDialogCallBackList;

		// Token: 0x0402AB6F RID: 174959
		[Token(Token = "0x402AB6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool isBinding;

		// Token: 0x0402AB70 RID: 174960
		[Token(Token = "0x402AB70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0402AB72 RID: 174962
		[Token(Token = "0x402AB72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[NonSerialized]
		public RoguelikeCharSelectStateBean.Input input;

		// Token: 0x0402AB73 RID: 174963
		[Token(Token = "0x402AB73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Coroutine m_interDialogCoro;

		// Token: 0x0402AB74 RID: 174964
		[Token(Token = "0x402AB74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool m_coroAvail;

		// Token: 0x0402AB75 RID: 174965
		[Token(Token = "0x402AB75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x0402AB76 RID: 174966
		[Token(Token = "0x402AB76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_commonTopMenuPrefab;

		// Token: 0x0402AB77 RID: 174967
		[Token(Token = "0x402AB77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_dungeonZoneProp;

		// Token: 0x0402AB78 RID: 174968
		[Token(Token = "0x402AB78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_focusProp;

		// Token: 0x0402AB79 RID: 174969
		[Token(Token = "0x402AB79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_rewardProp;

		// Token: 0x0402AB7A RID: 174970
		[Token(Token = "0x402AB7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_eventPool;

		// Token: 0x0402AB7B RID: 174971
		[Token(Token = "0x402AB7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_stateEngine;

		// Token: 0x0402AB7C RID: 174972
		[Token(Token = "0x402AB7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_backGroundEventTrigger;

		// Token: 0x0402AB7D RID: 174973
		[Token(Token = "0x402AB7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_mapPreviewRoot;

		// Token: 0x0402AB7E RID: 174974
		[Token(Token = "0x402AB7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_cameraController;

		// Token: 0x0402AB7F RID: 174975
		[Token(Token = "0x402AB7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_dungeonFloat;

		// Token: 0x0402AB80 RID: 174976
		[Token(Token = "0x402AB80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_dungeonFloat;

		// Token: 0x0402AB81 RID: 174977
		[Token(Token = "0x402AB81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_zoneView;

		// Token: 0x0402AB82 RID: 174978
		[Token(Token = "0x402AB82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_resHolder;

		// Token: 0x0402AB83 RID: 174979
		[Token(Token = "0x402AB83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402AB84 RID: 174980
		[Token(Token = "0x402AB84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_pendingEvtHandler;

		// Token: 0x0402AB85 RID: 174981
		[Token(Token = "0x402AB85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_spZonePlugin;

		// Token: 0x0402AB86 RID: 174982
		[Token(Token = "0x402AB86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0402AB87 RID: 174983
		[Token(Token = "0x402AB87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402AB88 RID: 174984
		[Token(Token = "0x402AB88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetCurrentTopicId;

		// Token: 0x0402AB89 RID: 174985
		[Token(Token = "0x402AB89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetDetailData;

		// Token: 0x0402AB8A RID: 174986
		[Token(Token = "0x402AB8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__InitController;

		// Token: 0x0402AB8B RID: 174987
		[Token(Token = "0x402AB8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnNodeClicked;

		// Token: 0x0402AB8C RID: 174988
		[Token(Token = "0x402AB8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnZoneCreated;

		// Token: 0x0402AB8D RID: 174989
		[Token(Token = "0x402AB8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnMenuCreated;

		// Token: 0x0402AB8E RID: 174990
		[Token(Token = "0x402AB8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnDungeonFloatCreated;

		// Token: 0x0402AB8F RID: 174991
		[Token(Token = "0x402AB8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnStateEnter;

		// Token: 0x0402AB90 RID: 174992
		[Token(Token = "0x402AB90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnStateResume;

		// Token: 0x0402AB91 RID: 174993
		[Token(Token = "0x402AB91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnBeforeTransition;

		// Token: 0x0402AB92 RID: 174994
		[Token(Token = "0x402AB92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnStatePause;

		// Token: 0x0402AB93 RID: 174995
		[Token(Token = "0x402AB93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0402AB94 RID: 174996
		[Token(Token = "0x402AB94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0402AB95 RID: 174997
		[Token(Token = "0x402AB95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CreateTicketCharSelectInput;

		// Token: 0x0402AB96 RID: 174998
		[Token(Token = "0x402AB96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_SelectRecruitChar;

		// Token: 0x0402AB97 RID: 174999
		[Token(Token = "0x402AB97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_OnCommonSelectRecruitChar;

		// Token: 0x0402AB98 RID: 175000
		[Token(Token = "0x402AB98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_ConsumeRecruitUpgradeTicket;

		// Token: 0x0402AB99 RID: 175001
		[Token(Token = "0x402AB99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_CheckIfHaveActiveRecruitAndOpen;

		// Token: 0x0402AB9A RID: 175002
		[Token(Token = "0x402AB9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OpenDialog;

		// Token: 0x0402AB9B RID: 175003
		[Token(Token = "0x402AB9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_BindDialogCallBack;

		// Token: 0x0402AB9C RID: 175004
		[Token(Token = "0x402AB9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__CheckNeedToBind;

		// Token: 0x0402AB9D RID: 175005
		[Token(Token = "0x402AB9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0402AB9E RID: 175006
		[Token(Token = "0x402AB9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__UpdateGacha;

		// Token: 0x0402AB9F RID: 175007
		[Token(Token = "0x402AB9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__GetBGMInstId;

		// Token: 0x0402ABA0 RID: 175008
		[Token(Token = "0x402ABA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__TryToLoadSpZonePlugin;

		// Token: 0x0402ABA1 RID: 175009
		[Token(Token = "0x402ABA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_ReloadZoneMap;

		// Token: 0x0402ABA2 RID: 175010
		[Token(Token = "0x402ABA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_ReloadDungeon;

		// Token: 0x0402ABA3 RID: 175011
		[Token(Token = "0x402ABA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_TryLoadFocusStage;

		// Token: 0x0402ABA4 RID: 175012
		[Token(Token = "0x402ABA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_CheckIfCanLoadShopState;

		// Token: 0x0402ABA5 RID: 175013
		[Token(Token = "0x402ABA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_HandlerRelicGetPushMsg;

		// Token: 0x0402ABA6 RID: 175014
		[Token(Token = "0x402ABA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_TryProcessTicket;

		// Token: 0x0402ABA7 RID: 175015
		[Token(Token = "0x402ABA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_TryProcessChangeCopper;

		// Token: 0x0402ABA8 RID: 175016
		[Token(Token = "0x402ABA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_RequestGiveUpNodeMission;

		// Token: 0x0402ABA9 RID: 175017
		[Token(Token = "0x402ABA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_NeedZoneTransition;

		// Token: 0x0402ABAA RID: 175018
		[Token(Token = "0x402ABAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_SetZoneTransitionViewed;

		// Token: 0x0402ABAB RID: 175019
		[Token(Token = "0x402ABAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_SetRaycastBlock;

		// Token: 0x0402ABAC RID: 175020
		[Token(Token = "0x402ABAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_RegisterMenuAdapter;

		// Token: 0x0402ABAD RID: 175021
		[Token(Token = "0x402ABAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix1_RegisterMenuAdapter;

		// Token: 0x0402ABAE RID: 175022
		[Token(Token = "0x402ABAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_AttachRoguelikeEffect;

		// Token: 0x0402ABAF RID: 175023
		[Token(Token = "0x402ABAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_ShowDungeon;

		// Token: 0x0402ABB0 RID: 175024
		[Token(Token = "0x402ABB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_RequestExitRoguelike;

		// Token: 0x0402ABB1 RID: 175025
		[Token(Token = "0x402ABB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_CleanEffect;

		// Token: 0x0402ABB2 RID: 175026
		[Token(Token = "0x402ABB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_CheckDialogCoroActive;

		// Token: 0x0402ABB3 RID: 175027
		[Token(Token = "0x402ABB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__OpenAvailInterDialogCoro;

		// Token: 0x0402ABB4 RID: 175028
		[Token(Token = "0x402ABB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_OpenAvailInterDialog;

		// Token: 0x0402ABB5 RID: 175029
		[Token(Token = "0x402ABB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_SetModuleState;

		// Token: 0x0402ABB6 RID: 175030
		[Token(Token = "0x402ABB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_CheckIfStateDirectOpenByDungeon;

		// Token: 0x0402ABB7 RID: 175031
		[Token(Token = "0x402ABB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_CheckFrontStateDontShowMsg;

		// Token: 0x0402ABB8 RID: 175032
		[Token(Token = "0x402ABB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_TriggerRoguelikeCustomNotify;

		// Token: 0x0402ABB9 RID: 175033
		[Token(Token = "0x402ABB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_RequestLeaveSpZone;

		// Token: 0x0402ABBA RID: 175034
		[Token(Token = "0x402ABBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_SceneParamToRoguelike;

		// Token: 0x0402ABBB RID: 175035
		[Token(Token = "0x402ABBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_SceneParamToActivity;

		// Token: 0x0402ABBC RID: 175036
		[Token(Token = "0x402ABBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_BattleFinishRedirection;

		// Token: 0x0402ABBD RID: 175037
		[Token(Token = "0x402ABBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005421 RID: 21537
		[Token(Token = "0x2005421")]
		public class StateStackContext : IHotfixable
		{
			// Token: 0x0601FAF2 RID: 129778 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FAF2")]
			[Address(RVA = "0x1968890", Offset = "0x1967490", VA = "0x181968890")]
			public void UpdateCache(Stack<Type> statePredicatedStack)
			{
			}

			// Token: 0x0601FAF3 RID: 129779 RVA: 0x000B2BA8 File Offset: 0x000B0DA8
			[Token(Token = "0x601FAF3")]
			[Address(RVA = "0x19686B0", Offset = "0x19672B0", VA = "0x1819686B0")]
			public bool CheckOpenByDungeonStateInPredicatedStack(Type targetStateType)
			{
				return default(bool);
			}

			// Token: 0x0601FAF4 RID: 129780 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FAF4")]
			[Address(RVA = "0x19689B0", Offset = "0x19675B0", VA = "0x1819689B0")]
			public StateStackContext()
			{
			}

			// Token: 0x0402ABBE RID: 175038
			[Token(Token = "0x402ABBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly Type DUNGEON_STATE_TYPE;

			// Token: 0x0402ABBF RID: 175039
			[Token(Token = "0x402ABBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Stack<Type> m_stateStack;

			// Token: 0x0402ABC0 RID: 175040
			[Token(Token = "0x402ABC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateCache;

			// Token: 0x0402ABC1 RID: 175041
			[Token(Token = "0x402ABC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CheckOpenByDungeonStateInPredicatedStack;

			// Token: 0x0402ABC2 RID: 175042
			[Token(Token = "0x402ABC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005422 RID: 21538
		[Token(Token = "0x2005422")]
		public class PendingEventHandler : IHotfixable
		{
			// Token: 0x0601FAF6 RID: 129782 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FAF6")]
			[Address(RVA = "0x1950280", Offset = "0x194EE80", VA = "0x181950280")]
			public void Init(RoguelikeDungeonController controller)
			{
			}

			// Token: 0x0601FAF7 RID: 129783 RVA: 0x000B2BC0 File Offset: 0x000B0DC0
			[Token(Token = "0x601FAF7")]
			[Address(RVA = "0x194FF00", Offset = "0x194EB00", VA = "0x18194FF00")]
			public bool HandleWhenPageResume()
			{
				return default(bool);
			}

			// Token: 0x0601FAF8 RID: 129784 RVA: 0x000B2BD8 File Offset: 0x000B0DD8
			[Token(Token = "0x601FAF8")]
			[Address(RVA = "0x1950060", Offset = "0x194EC60", VA = "0x181950060")]
			public bool HandleWhenShopBuy()
			{
				return default(bool);
			}

			// Token: 0x0601FAF9 RID: 129785 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FAF9")]
			[Address(RVA = "0x194FC10", Offset = "0x194E810", VA = "0x18194FC10")]
			public void HandleWhenChoiceSelected(bool isFastMode)
			{
			}

			// Token: 0x0601FAFA RID: 129786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FAFA")]
			private void _OpenState<T>(bool isFastMode) where T : State
			{
			}

			// Token: 0x0601FAFB RID: 129787 RVA: 0x000B2BF0 File Offset: 0x000B0DF0
			[Token(Token = "0x601FAFB")]
			[Address(RVA = "0x19501D0", Offset = "0x194EDD0", VA = "0x1819501D0")]
			public bool HandleWhenTakeReward()
			{
				return default(bool);
			}

			// Token: 0x0601FAFC RID: 129788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FAFC")]
			[Address(RVA = "0x1950300", Offset = "0x194EF00", VA = "0x181950300")]
			public PendingEventHandler()
			{
			}

			// Token: 0x0402ABC3 RID: 175043
			[Token(Token = "0x402ABC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private RoguelikeDungeonController m_controller;

			// Token: 0x0402ABC4 RID: 175044
			[Token(Token = "0x402ABC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0402ABC5 RID: 175045
			[Token(Token = "0x402ABC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_HandleWhenPageResume;

			// Token: 0x0402ABC6 RID: 175046
			[Token(Token = "0x402ABC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_HandleWhenShopBuy;

			// Token: 0x0402ABC7 RID: 175047
			[Token(Token = "0x402ABC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_HandleWhenChoiceSelected;

			// Token: 0x0402ABC8 RID: 175048
			[Token(Token = "0x402ABC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__OpenState;

			// Token: 0x0402ABC9 RID: 175049
			[Token(Token = "0x402ABC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_HandleWhenTakeReward;

			// Token: 0x0402ABCA RID: 175050
			[Token(Token = "0x402ABCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005423 RID: 21539
		[Token(Token = "0x2005423")]
		private class ModuleAdapter : IRoguelikeModuleHost
		{
			// Token: 0x0601FAFD RID: 129789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FAFD")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public ModuleAdapter(RoguelikeDungeonController ctrller)
			{
			}

			// Token: 0x17004A3E RID: 19006
			// (get) Token: 0x0601FAFE RID: 129790 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004A3E")]
			public string topicId
			{
				[Token(Token = "0x601FAFE")]
				[Address(RVA = "0x1969630", Offset = "0x1968230", VA = "0x181969630", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601FAFF RID: 129791 RVA: 0x000B2C08 File Offset: 0x000B0E08
			[Token(Token = "0x601FAFF")]
			[Address(RVA = "0x1969480", Offset = "0x1968080", VA = "0x181969480", Slot = "4")]
			public long GetBGMInstId()
			{
				return 0L;
			}

			// Token: 0x0601FB00 RID: 129792 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FB00")]
			[Address(RVA = "0x1969510", Offset = "0x1968110", VA = "0x181969510", Slot = "6")]
			public RoguelikeDungeonPage GetPage()
			{
				return null;
			}

			// Token: 0x0601FB01 RID: 129793 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FB01")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "7")]
			public RoguelikeDungeonController GetController()
			{
				return null;
			}

			// Token: 0x0402ABCB RID: 175051
			[Token(Token = "0x402ABCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private RoguelikeDungeonController m_controller;
		}
	}
}
