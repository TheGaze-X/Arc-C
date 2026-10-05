using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003667 RID: 13927
	[Token(Token = "0x2003667")]
	public class StateEngine : MonoBehaviour, IStateEngine, IHotfixable
	{
		// Token: 0x06016289 RID: 90761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016289")]
		[Address(RVA = "0xE9A200", Offset = "0xE98E00", VA = "0x180E9A200")]
		private void Start()
		{
		}

		// Token: 0x0601628A RID: 90762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601628A")]
		[Address(RVA = "0xE99810", Offset = "0xE98410", VA = "0x180E99810")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601628B RID: 90763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601628B")]
		[Address(RVA = "0xE9AC50", Offset = "0xE99850", VA = "0x180E9AC50")]
		private void _StartStateEngine()
		{
		}

		// Token: 0x0601628C RID: 90764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601628C")]
		[Address(RVA = "0xE99340", Offset = "0xE97F40", VA = "0x180E99340")]
		private Transform GetPrefabContainer()
		{
			return null;
		}

		// Token: 0x0601628D RID: 90765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601628D")]
		[Address(RVA = "0xE9A740", Offset = "0xE99340", VA = "0x180E9A740")]
		private List<State> _LoadPrefabStateInsts()
		{
			return null;
		}

		// Token: 0x0601628E RID: 90766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601628E")]
		[Address(RVA = "0xE9A300", Offset = "0xE98F00", VA = "0x180E9A300")]
		private IEnumerator _AddInitialStateCoroutine()
		{
			return null;
		}

		// Token: 0x0601628F RID: 90767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601628F")]
		[Address(RVA = "0xE9A3B0", Offset = "0xE98FB0", VA = "0x180E9A3B0")]
		private State _LoadAndInstDynState(DynStateID state, Transform parent)
		{
			return null;
		}

		// Token: 0x1700353A RID: 13626
		// (get) Token: 0x06016290 RID: 90768 RVA: 0x0008FC10 File Offset: 0x0008DE10
		[Token(Token = "0x1700353A")]
		public bool isInited
		{
			[Token(Token = "0x6016290")]
			[Address(RVA = "0xE9B530", Offset = "0xE9A130", VA = "0x180E9B530")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700353B RID: 13627
		// (get) Token: 0x06016291 RID: 90769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700353B")]
		public State defaultState
		{
			[Token(Token = "0x6016291")]
			[Address(RVA = "0xE9B400", Offset = "0xE9A000", VA = "0x180E9B400")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x06016292 RID: 90770 RVA: 0x0008FC28 File Offset: 0x0008DE28
		[Token(Token = "0x1700353C")]
		public int StackCount
		{
			[Token(Token = "0x6016292")]
			[Address(RVA = "0xE9B350", Offset = "0xE99F50", VA = "0x180E9B350")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06016293 RID: 90771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016293")]
		[Address(RVA = "0xE993F0", Offset = "0xE97FF0", VA = "0x180E993F0")]
		public TransitionManagerAsset GetTransitionManagerAsset()
		{
			return null;
		}

		// Token: 0x06016294 RID: 90772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016294")]
		[Address(RVA = "0xE9A060", Offset = "0xE98C60", VA = "0x180E9A060")]
		public void StartStateEngine()
		{
		}

		// Token: 0x06016295 RID: 90773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016295")]
		[Address(RVA = "0xE99140", Offset = "0xE97D40", VA = "0x180E99140")]
		public IEnumerator CloseStateEngine()
		{
			return null;
		}

		// Token: 0x06016296 RID: 90774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016296")]
		[Address(RVA = "0xE98AD0", Offset = "0xE976D0", VA = "0x180E98AD0")]
		public State[] AchieveSelectableStates()
		{
			return null;
		}

		// Token: 0x06016297 RID: 90775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016297")]
		[Address(RVA = "0xE99450", Offset = "0xE98050", VA = "0x180E99450")]
		public void InjectPage(IPageProvider parentPage)
		{
		}

		// Token: 0x06016298 RID: 90776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016298")]
		[Address(RVA = "0xE99F30", Offset = "0xE98B30", VA = "0x180E99F30")]
		public IEnumerator ResetToDefault(bool force = false)
		{
			return null;
		}

		// Token: 0x06016299 RID: 90777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016299")]
		[Address(RVA = "0xE998F0", Offset = "0xE984F0", VA = "0x180E998F0")]
		public void RegisterOnStateChange(StateEngine.OnStateChangeListener listener)
		{
		}

		// Token: 0x0601629A RID: 90778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601629A")]
		[Address(RVA = "0xE9A260", Offset = "0xE98E60", VA = "0x180E9A260")]
		public void UnregisterOnStateChange(StateEngine.OnStateChangeListener listener)
		{
		}

		// Token: 0x0601629B RID: 90779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601629B")]
		[Address(RVA = "0xE996B0", Offset = "0xE982B0", VA = "0x180E996B0")]
		public void ManualResumeFrontState()
		{
		}

		// Token: 0x0601629C RID: 90780 RVA: 0x0008FC40 File Offset: 0x0008DE40
		[Token(Token = "0x601629C")]
		[Address(RVA = "0xE98CF0", Offset = "0xE978F0", VA = "0x180E98CF0", Slot = "4")]
		public bool AddTop(Type state, StateTransOptions config)
		{
			return default(bool);
		}

		// Token: 0x0601629D RID: 90781 RVA: 0x0008FC58 File Offset: 0x0008DE58
		[Token(Token = "0x601629D")]
		[Address(RVA = "0xE98DA0", Offset = "0xE979A0", VA = "0x180E98DA0", Slot = "5")]
		public bool AddTop(Type state)
		{
			return default(bool);
		}

		// Token: 0x0601629E RID: 90782 RVA: 0x0008FC70 File Offset: 0x0008DE70
		[Token(Token = "0x601629E")]
		public bool AddTop<T>(StateTransOptions config) where T : State
		{
			return default(bool);
		}

		// Token: 0x0601629F RID: 90783 RVA: 0x0008FC88 File Offset: 0x0008DE88
		[Token(Token = "0x601629F")]
		public bool AddTop<T>() where T : State
		{
			return default(bool);
		}

		// Token: 0x060162A0 RID: 90784 RVA: 0x0008FCA0 File Offset: 0x0008DEA0
		[Token(Token = "0x60162A0")]
		[Address(RVA = "0xE99E70", Offset = "0xE98A70", VA = "0x180E99E70", Slot = "8")]
		public bool ReplaceTop(Type state, StateTransOptions config, StateReplaceTransMode replaceTransMode = StateReplaceTransMode.REPLACE_MODE)
		{
			return default(bool);
		}

		// Token: 0x060162A1 RID: 90785 RVA: 0x0008FCB8 File Offset: 0x0008DEB8
		[Token(Token = "0x60162A1")]
		[Address(RVA = "0xE99D50", Offset = "0xE98950", VA = "0x180E99D50", Slot = "9")]
		public bool ReplaceTop(Type state, StateReplaceTransMode replaceTransMode = StateReplaceTransMode.REPLACE_MODE)
		{
			return default(bool);
		}

		// Token: 0x060162A2 RID: 90786 RVA: 0x0008FCD0 File Offset: 0x0008DED0
		[Token(Token = "0x60162A2")]
		public bool ReplaceTop<T>(StateTransOptions config, StateReplaceTransMode replaceTransMode = StateReplaceTransMode.REPLACE_MODE) where T : State
		{
			return default(bool);
		}

		// Token: 0x060162A3 RID: 90787 RVA: 0x0008FCE8 File Offset: 0x0008DEE8
		[Token(Token = "0x60162A3")]
		public bool ReplaceTop<T>(StateReplaceTransMode replaceTransMode = StateReplaceTransMode.REPLACE_MODE) where T : State
		{
			return default(bool);
		}

		// Token: 0x060162A4 RID: 90788 RVA: 0x0008FD00 File Offset: 0x0008DF00
		[Token(Token = "0x60162A4")]
		[Address(RVA = "0xE99B70", Offset = "0xE98770", VA = "0x180E99B70", Slot = "12")]
		public bool RemoveTop(StateTransOptions config)
		{
			return default(bool);
		}

		// Token: 0x060162A5 RID: 90789 RVA: 0x0008FD18 File Offset: 0x0008DF18
		[Token(Token = "0x60162A5")]
		[Address(RVA = "0xE99C00", Offset = "0xE98800", VA = "0x180E99C00", Slot = "13")]
		public bool RemoveTop()
		{
			return default(bool);
		}

		// Token: 0x060162A6 RID: 90790 RVA: 0x0008FD30 File Offset: 0x0008DF30
		[Token(Token = "0x60162A6")]
		[Address(RVA = "0xE999C0", Offset = "0xE985C0", VA = "0x180E999C0", Slot = "14")]
		public bool RemoveToState(Type state, StateTransOptions config)
		{
			return default(bool);
		}

		// Token: 0x060162A7 RID: 90791 RVA: 0x0008FD48 File Offset: 0x0008DF48
		[Token(Token = "0x60162A7")]
		[Address(RVA = "0xE99A70", Offset = "0xE98670", VA = "0x180E99A70", Slot = "15")]
		public bool RemoveToState(Type state)
		{
			return default(bool);
		}

		// Token: 0x060162A8 RID: 90792 RVA: 0x0008FD60 File Offset: 0x0008DF60
		[Token(Token = "0x60162A8")]
		public bool RemoveToState<T>(StateTransOptions config) where T : State
		{
			return default(bool);
		}

		// Token: 0x060162A9 RID: 90793 RVA: 0x0008FD78 File Offset: 0x0008DF78
		[Token(Token = "0x60162A9")]
		public bool RemoveToState<T>() where T : State
		{
			return default(bool);
		}

		// Token: 0x060162AA RID: 90794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162AA")]
		[Address(RVA = "0xE991F0", Offset = "0xE97DF0", VA = "0x180E991F0", Slot = "18")]
		public State GetFrontState()
		{
			return null;
		}

		// Token: 0x060162AB RID: 90795 RVA: 0x0008FD90 File Offset: 0x0008DF90
		[Token(Token = "0x60162AB")]
		[Address(RVA = "0xE994D0", Offset = "0xE980D0", VA = "0x180E994D0", Slot = "19")]
		public bool IsTransitting()
		{
			return default(bool);
		}

		// Token: 0x060162AC RID: 90796 RVA: 0x0008FDA8 File Offset: 0x0008DFA8
		[Token(Token = "0x60162AC")]
		[Address(RVA = "0xE99FF0", Offset = "0xE98BF0", VA = "0x180E99FF0", Slot = "20")]
		public StateEngineRuntime SaveToCache()
		{
			return default(StateEngineRuntime);
		}

		// Token: 0x060162AD RID: 90797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162AD")]
		[Address(RVA = "0xE99570", Offset = "0xE98170", VA = "0x180E99570", Slot = "21")]
		public IEnumerator LoadFromCache(StateEngineRuntime runtime)
		{
			return null;
		}

		// Token: 0x060162AE RID: 90798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162AE")]
		[Address(RVA = "0xE99260", Offset = "0xE97E60", VA = "0x180E99260", Slot = "22")]
		public UIPage GetPage()
		{
			return null;
		}

		// Token: 0x060162AF RID: 90799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162AF")]
		[Address(RVA = "0xE992E0", Offset = "0xE97EE0", VA = "0x180E992E0", Slot = "23")]
		public IStateEnginePlugin GetPlugin()
		{
			return null;
		}

		// Token: 0x060162B0 RID: 90800 RVA: 0x0008FDC0 File Offset: 0x0008DFC0
		[Token(Token = "0x60162B0")]
		public bool CheckIfStateRegistered<StateType>() where StateType : State
		{
			return default(bool);
		}

		// Token: 0x060162B1 RID: 90801 RVA: 0x0008FDD8 File Offset: 0x0008DFD8
		[Token(Token = "0x60162B1")]
		[Address(RVA = "0xE98F20", Offset = "0xE97B20", VA = "0x180E98F20")]
		public bool CheckIfStateRegistered(Type stateType)
		{
			return default(bool);
		}

		// Token: 0x060162B2 RID: 90802 RVA: 0x0008FDF0 File Offset: 0x0008DFF0
		[Token(Token = "0x60162B2")]
		[Address(RVA = "0xE99040", Offset = "0xE97C40", VA = "0x180E99040", Slot = "24")]
		public bool CheckIsExistInStack(Type stateType)
		{
			return default(bool);
		}

		// Token: 0x1700353D RID: 13629
		// (get) Token: 0x060162B3 RID: 90803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700353D")]
		protected IStateEnginePlugin internalPlugin
		{
			[Token(Token = "0x60162B3")]
			[Address(RVA = "0xE9B460", Offset = "0xE9A060", VA = "0x180E9B460")]
			get
			{
				return null;
			}
		}

		// Token: 0x060162B4 RID: 90804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162B4")]
		[Address(RVA = "0xE9ABA0", Offset = "0xE997A0", VA = "0x180E9ABA0")]
		private IEnumerator _PreLoadStatesCoroutine()
		{
			return null;
		}

		// Token: 0x060162B5 RID: 90805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60162B5")]
		[Address(RVA = "0xE9B250", Offset = "0xE99E50", VA = "0x180E9B250")]
		public StateEngine()
		{
		}

		// Token: 0x0401AA24 RID: 109092
		[Token(Token = "0x401AA24")]
		public const string DEFAULT_OBJECT_NAME = "UIStateEngine";

		// Token: 0x0401AA25 RID: 109093
		[Token(Token = "0x401AA25")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TransitionManagerAsset _transitionManagerAsset;

		// Token: 0x0401AA26 RID: 109094
		[Token(Token = "0x401AA26")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private State _defaultState;

		// Token: 0x0401AA27 RID: 109095
		[Token(Token = "0x401AA27")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StateEngine.DefaultStateOperation _defaultStateOperation;

		// Token: 0x0401AA28 RID: 109096
		[Token(Token = "0x401AA28")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _prefabContainer;

		// Token: 0x0401AA29 RID: 109097
		[Token(Token = "0x401AA29")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private State[] _registeredStates;

		// Token: 0x0401AA2A RID: 109098
		[Token(Token = "0x401AA2A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Prefab insts' order in container would follow their order in this array")]
		private GameObject[] _statesFromPrefab;

		// Token: 0x0401AA2B RID: 109099
		[Token(Token = "0x401AA2B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<StateEngine.PrefabConfig> _statesWithParentFromPrefab;

		// Token: 0x0401AA2C RID: 109100
		[Token(Token = "0x401AA2C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<StateEngine.DynPrefabConfig> _dynStatesWithParent;

		// Token: 0x0401AA2D RID: 109101
		[Token(Token = "0x401AA2D")]
		[FieldOffset(Offset = "0x58")]
		private StateEngineImpl m_engineImpl;

		// Token: 0x0401AA2E RID: 109102
		[Token(Token = "0x401AA2E")]
		[FieldOffset(Offset = "0x60")]
		private List<State> m_prefabInstStates;

		// Token: 0x0401AA2F RID: 109103
		[Token(Token = "0x401AA2F")]
		[FieldOffset(Offset = "0x68")]
		private UIDynStateHub m_dynStateHubCache;

		// Token: 0x0401AA30 RID: 109104
		[Token(Token = "0x401AA30")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0401AA31 RID: 109105
		[Token(Token = "0x401AA31")]
		[FieldOffset(Offset = "0x78")]
		private IPageProvider m_pageProvider;

		// Token: 0x0401AA32 RID: 109106
		[Token(Token = "0x401AA32")]
		[FieldOffset(Offset = "0x80")]
		private IStateEnginePlugin m_plugin;

		// Token: 0x0401AA33 RID: 109107
		[Token(Token = "0x401AA33")]
		[FieldOffset(Offset = "0x88")]
		private List<StateEngine.OnStateChangeListener> m_stateChangeListeners;

		// Token: 0x0401AA34 RID: 109108
		[Token(Token = "0x401AA34")]
		[FieldOffset(Offset = "0x90")]
		private State[] m_selectableStates;

		// Token: 0x0401AA35 RID: 109109
		[Token(Token = "0x401AA35")]
		[FieldOffset(Offset = "0x98")]
		private bool m_collectStateReadyFlag;

		// Token: 0x0401AA36 RID: 109110
		[Token(Token = "0x401AA36")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401AA37 RID: 109111
		[Token(Token = "0x401AA37")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401AA38 RID: 109112
		[Token(Token = "0x401AA38")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__StartStateEngine;

		// Token: 0x0401AA39 RID: 109113
		[Token(Token = "0x401AA39")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPrefabContainer;

		// Token: 0x0401AA3A RID: 109114
		[Token(Token = "0x401AA3A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadPrefabStateInsts;

		// Token: 0x0401AA3B RID: 109115
		[Token(Token = "0x401AA3B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AddInitialStateCoroutine;

		// Token: 0x0401AA3C RID: 109116
		[Token(Token = "0x401AA3C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadAndInstDynState;

		// Token: 0x0401AA3D RID: 109117
		[Token(Token = "0x401AA3D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isInited;

		// Token: 0x0401AA3E RID: 109118
		[Token(Token = "0x401AA3E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_defaultState;

		// Token: 0x0401AA3F RID: 109119
		[Token(Token = "0x401AA3F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_StackCount;

		// Token: 0x0401AA40 RID: 109120
		[Token(Token = "0x401AA40")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetTransitionManagerAsset;

		// Token: 0x0401AA41 RID: 109121
		[Token(Token = "0x401AA41")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_StartStateEngine;

		// Token: 0x0401AA42 RID: 109122
		[Token(Token = "0x401AA42")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CloseStateEngine;

		// Token: 0x0401AA43 RID: 109123
		[Token(Token = "0x401AA43")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_AchieveSelectableStates;

		// Token: 0x0401AA44 RID: 109124
		[Token(Token = "0x401AA44")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_InjectPage;

		// Token: 0x0401AA45 RID: 109125
		[Token(Token = "0x401AA45")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ResetToDefault;

		// Token: 0x0401AA46 RID: 109126
		[Token(Token = "0x401AA46")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_RegisterOnStateChange;

		// Token: 0x0401AA47 RID: 109127
		[Token(Token = "0x401AA47")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_UnregisterOnStateChange;

		// Token: 0x0401AA48 RID: 109128
		[Token(Token = "0x401AA48")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ManualResumeFrontState;

		// Token: 0x0401AA49 RID: 109129
		[Token(Token = "0x401AA49")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_AddTop;

		// Token: 0x0401AA4A RID: 109130
		[Token(Token = "0x401AA4A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix1_AddTop;

		// Token: 0x0401AA4B RID: 109131
		[Token(Token = "0x401AA4B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix2_AddTop;

		// Token: 0x0401AA4C RID: 109132
		[Token(Token = "0x401AA4C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix3_AddTop;

		// Token: 0x0401AA4D RID: 109133
		[Token(Token = "0x401AA4D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ReplaceTop;

		// Token: 0x0401AA4E RID: 109134
		[Token(Token = "0x401AA4E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix1_ReplaceTop;

		// Token: 0x0401AA4F RID: 109135
		[Token(Token = "0x401AA4F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix2_ReplaceTop;

		// Token: 0x0401AA50 RID: 109136
		[Token(Token = "0x401AA50")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix3_ReplaceTop;

		// Token: 0x0401AA51 RID: 109137
		[Token(Token = "0x401AA51")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_RemoveTop;

		// Token: 0x0401AA52 RID: 109138
		[Token(Token = "0x401AA52")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix1_RemoveTop;

		// Token: 0x0401AA53 RID: 109139
		[Token(Token = "0x401AA53")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_RemoveToState;

		// Token: 0x0401AA54 RID: 109140
		[Token(Token = "0x401AA54")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix1_RemoveToState;

		// Token: 0x0401AA55 RID: 109141
		[Token(Token = "0x401AA55")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix2_RemoveToState;

		// Token: 0x0401AA56 RID: 109142
		[Token(Token = "0x401AA56")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix3_RemoveToState;

		// Token: 0x0401AA57 RID: 109143
		[Token(Token = "0x401AA57")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_GetFrontState;

		// Token: 0x0401AA58 RID: 109144
		[Token(Token = "0x401AA58")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_IsTransitting;

		// Token: 0x0401AA59 RID: 109145
		[Token(Token = "0x401AA59")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_SaveToCache;

		// Token: 0x0401AA5A RID: 109146
		[Token(Token = "0x401AA5A")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_LoadFromCache;

		// Token: 0x0401AA5B RID: 109147
		[Token(Token = "0x401AA5B")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_GetPage;

		// Token: 0x0401AA5C RID: 109148
		[Token(Token = "0x401AA5C")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_GetPlugin;

		// Token: 0x0401AA5D RID: 109149
		[Token(Token = "0x401AA5D")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_CheckIfStateRegistered;

		// Token: 0x0401AA5E RID: 109150
		[Token(Token = "0x401AA5E")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix1_CheckIfStateRegistered;

		// Token: 0x0401AA5F RID: 109151
		[Token(Token = "0x401AA5F")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_CheckIsExistInStack;

		// Token: 0x0401AA60 RID: 109152
		[Token(Token = "0x401AA60")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_internalPlugin;

		// Token: 0x0401AA61 RID: 109153
		[Token(Token = "0x401AA61")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__PreLoadStatesCoroutine;

		// Token: 0x0401AA62 RID: 109154
		[Token(Token = "0x401AA62")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003668 RID: 13928
		[Token(Token = "0x2003668")]
		public interface IMaintainer
		{
			// Token: 0x060162B6 RID: 90806
			[Token(Token = "0x60162B6")]
			LatchUtils.InvokeWhenUnlock StartStateEngine();
		}

		// Token: 0x02003669 RID: 13929
		[Token(Token = "0x2003669")]
		public enum DefaultStateOperation
		{
			// Token: 0x0401AA64 RID: 109156
			[Token(Token = "0x401AA64")]
			HIDE_ALL,
			// Token: 0x0401AA65 RID: 109157
			[Token(Token = "0x401AA65")]
			SHOW_DEFAULT_ONLY,
			// Token: 0x0401AA66 RID: 109158
			[Token(Token = "0x401AA66")]
			SHOW_ALL,
			// Token: 0x0401AA67 RID: 109159
			[Token(Token = "0x401AA67")]
			DO_NOTHING
		}

		// Token: 0x0200366A RID: 13930
		[Token(Token = "0x200366A")]
		[Serializable]
		public struct PrefabConfig
		{
			// Token: 0x0401AA68 RID: 109160
			[Token(Token = "0x401AA68")]
			[FieldOffset(Offset = "0x0")]
			public State state;

			// Token: 0x0401AA69 RID: 109161
			[Token(Token = "0x401AA69")]
			[FieldOffset(Offset = "0x8")]
			public Transform parent;
		}

		// Token: 0x0200366B RID: 13931
		[Token(Token = "0x200366B")]
		[Serializable]
		public struct DynPrefabConfig
		{
			// Token: 0x0401AA6A RID: 109162
			[Token(Token = "0x401AA6A")]
			[FieldOffset(Offset = "0x0")]
			public DynStateID state;

			// Token: 0x0401AA6B RID: 109163
			[Token(Token = "0x401AA6B")]
			[FieldOffset(Offset = "0x8")]
			public Transform parent;
		}

		// Token: 0x0200366C RID: 13932
		[Token(Token = "0x200366C")]
		public class OnStateChangeListener
		{
			// Token: 0x060162B7 RID: 90807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162B7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OnStateChangeListener()
			{
			}

			// Token: 0x0401AA6C RID: 109164
			[Token(Token = "0x401AA6C")]
			[FieldOffset(Offset = "0x10")]
			public Action<Type, StateEngine.OnStateChangeListener.Additions> onStateEnter;

			// Token: 0x0401AA6D RID: 109165
			[Token(Token = "0x401AA6D")]
			[FieldOffset(Offset = "0x18")]
			public Action<Type, bool, StateEngine.OnStateChangeListener.Additions> onStateResume;

			// Token: 0x0401AA6E RID: 109166
			[Token(Token = "0x401AA6E")]
			[FieldOffset(Offset = "0x20")]
			public Action<Type, bool, StateEngine.OnStateChangeListener.Additions> onStatePreResume;

			// Token: 0x0401AA6F RID: 109167
			[Token(Token = "0x401AA6F")]
			[FieldOffset(Offset = "0x28")]
			public Action<Type, StateEngine.OnStateChangeListener.Additions> onStatePause;

			// Token: 0x0401AA70 RID: 109168
			[Token(Token = "0x401AA70")]
			[FieldOffset(Offset = "0x30")]
			public Action<Type, StateEngine.OnStateChangeListener.Additions> onStateExit;

			// Token: 0x0401AA71 RID: 109169
			[Token(Token = "0x401AA71")]
			[FieldOffset(Offset = "0x38")]
			public Action<Type, Type, StateEngine.OnStateChangeListener.Additions> beforeStateTrans;

			// Token: 0x0200366D RID: 13933
			[Token(Token = "0x200366D")]
			public struct Additions
			{
				// Token: 0x0401AA72 RID: 109170
				[Token(Token = "0x401AA72")]
				[FieldOffset(Offset = "0x0")]
				public bool isFastMode;

				// Token: 0x0401AA73 RID: 109171
				[Token(Token = "0x401AA73")]
				[FieldOffset(Offset = "0x8")]
				public Stack<Type> predicatedStack;
			}
		}

		// Token: 0x0200366E RID: 13934
		[Token(Token = "0x200366E")]
		private class InternalPlugin : IStateEnginePlugin
		{
			// Token: 0x060162B8 RID: 90808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162B8")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public InternalPlugin(StateEngine engine)
			{
			}

			// Token: 0x060162B9 RID: 90809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162B9")]
			[Address(RVA = "0xE926D0", Offset = "0xE912D0", VA = "0x180E926D0", Slot = "4")]
			public void NotifyStateEnter(State.TransEvent evt)
			{
			}

			// Token: 0x060162BA RID: 90810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162BA")]
			[Address(RVA = "0xE927D0", Offset = "0xE913D0", VA = "0x180E927D0", Slot = "8")]
			public void NotifyStateExit(State.TransEvent evt)
			{
			}

			// Token: 0x060162BB RID: 90811 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162BB")]
			[Address(RVA = "0xE928D0", Offset = "0xE914D0", VA = "0x180E928D0", Slot = "7")]
			public void NotifyStatePause(State.TransEvent evt)
			{
			}

			// Token: 0x060162BC RID: 90812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162BC")]
			[Address(RVA = "0xE92AD0", Offset = "0xE916D0", VA = "0x180E92AD0", Slot = "6")]
			public void NotifyStateResume(State.TransEvent evt)
			{
			}

			// Token: 0x060162BD RID: 90813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162BD")]
			[Address(RVA = "0xE929D0", Offset = "0xE915D0", VA = "0x180E929D0", Slot = "5")]
			public void NotifyStatePreResume(State.TransEvent evt)
			{
			}

			// Token: 0x060162BE RID: 90814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162BE")]
			[Address(RVA = "0xE92590", Offset = "0xE91190", VA = "0x180E92590", Slot = "9")]
			public void NotifyBeforeStateTrans(StateTransContext transContext)
			{
			}

			// Token: 0x060162BF RID: 90815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162BF")]
			[Address(RVA = "0xE92F20", Offset = "0xE91B20", VA = "0x180E92F20")]
			private void _TriggerEventListeners(State.TransEvent evt, Action<State.TransEvent, StateEngine.OnStateChangeListener> callback)
			{
			}

			// Token: 0x060162C0 RID: 90816 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162C0")]
			private void _TriggerListeners<ParamT>(ParamT param, Action<ParamT, StateEngine.OnStateChangeListener> callback)
			{
			}

			// Token: 0x060162C1 RID: 90817 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162C1")]
			[Address(RVA = "0xE92CD0", Offset = "0xE918D0", VA = "0x180E92CD0")]
			private void _OnStateEnter(State.TransEvent evt, StateEngine.OnStateChangeListener listener)
			{
			}

			// Token: 0x060162C2 RID: 90818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162C2")]
			[Address(RVA = "0xE92E20", Offset = "0xE91A20", VA = "0x180E92E20")]
			private void _OnStatePreResume(State.TransEvent evt, StateEngine.OnStateChangeListener listener)
			{
			}

			// Token: 0x060162C3 RID: 90819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162C3")]
			[Address(RVA = "0xE92EA0", Offset = "0xE91AA0", VA = "0x180E92EA0")]
			private void _OnStateResume(State.TransEvent evt, StateEngine.OnStateChangeListener listener)
			{
			}

			// Token: 0x060162C4 RID: 90820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162C4")]
			[Address(RVA = "0xE92DB0", Offset = "0xE919B0", VA = "0x180E92DB0")]
			private void _OnStatePause(State.TransEvent evt, StateEngine.OnStateChangeListener listener)
			{
			}

			// Token: 0x060162C5 RID: 90821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162C5")]
			[Address(RVA = "0xE92D40", Offset = "0xE91940", VA = "0x180E92D40")]
			private void _OnStateExit(State.TransEvent evt, StateEngine.OnStateChangeListener listener)
			{
			}

			// Token: 0x060162C6 RID: 90822 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162C6")]
			[Address(RVA = "0xE92BD0", Offset = "0xE917D0", VA = "0x180E92BD0")]
			private void _BeforeStateChange(StateTransContext context, StateEngine.OnStateChangeListener listener)
			{
			}

			// Token: 0x0401AA74 RID: 109172
			[Token(Token = "0x401AA74")]
			[FieldOffset(Offset = "0x10")]
			private StateEngine m_engine;
		}
	}
}
