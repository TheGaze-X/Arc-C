using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200364F RID: 13903
	[Token(Token = "0x200364F")]
	internal sealed class StateEngineImpl : IStateEngine, IHotfixable
	{
		// Token: 0x060161EF RID: 90607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161EF")]
		[Address(RVA = "0xE97B70", Offset = "0xE96770", VA = "0x180E97B70")]
		internal StateEngineImpl(ITransitionManager transMgr, State[] stateList, IStateEnginePlugin plugin)
		{
		}

		// Token: 0x060161F0 RID: 90608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161F0")]
		[Address(RVA = "0xE95E40", Offset = "0xE94A40", VA = "0x180E95E40")]
		private void _ClearInputModuleWhenNecessary(bool isForward, State toState, State fromState)
		{
		}

		// Token: 0x060161F1 RID: 90609 RVA: 0x0008F808 File Offset: 0x0008DA08
		[Token(Token = "0x60161F1")]
		[Address(RVA = "0xE95D40", Offset = "0xE94940", VA = "0x180E95D40")]
		private bool _CheckStateNeedInterrupt(State state)
		{
			return default(bool);
		}

		// Token: 0x060161F2 RID: 90610 RVA: 0x0008F820 File Offset: 0x0008DA20
		[Token(Token = "0x60161F2")]
		[Address(RVA = "0xE96600", Offset = "0xE95200", VA = "0x180E96600")]
		private bool _TransToStateWithAddMode(Type stateType, StateTransOptions config, bool bKeepCurStateInStack)
		{
			return default(bool);
		}

		// Token: 0x060161F3 RID: 90611 RVA: 0x0008F838 File Offset: 0x0008DA38
		[Token(Token = "0x60161F3")]
		[Address(RVA = "0xE94470", Offset = "0xE93070", VA = "0x180E94470", Slot = "4")]
		public bool AddTop(Type stateType, StateTransOptions config)
		{
			return default(bool);
		}

		// Token: 0x060161F4 RID: 90612 RVA: 0x0008F850 File Offset: 0x0008DA50
		[Token(Token = "0x60161F4")]
		[Address(RVA = "0xE94510", Offset = "0xE93110", VA = "0x180E94510", Slot = "5")]
		public bool AddTop(Type stateType)
		{
			return default(bool);
		}

		// Token: 0x060161F5 RID: 90613 RVA: 0x0008F868 File Offset: 0x0008DA68
		[Token(Token = "0x60161F5")]
		public bool AddTop<T>() where T : State
		{
			return default(bool);
		}

		// Token: 0x060161F6 RID: 90614 RVA: 0x0008F880 File Offset: 0x0008DA80
		[Token(Token = "0x60161F6")]
		public bool AddTop<T>(StateTransOptions config) where T : State
		{
			return default(bool);
		}

		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x060161F7 RID: 90615 RVA: 0x0008F898 File Offset: 0x0008DA98
		[Token(Token = "0x17003528")]
		public int StackCount
		{
			[Token(Token = "0x60161F7")]
			[Address(RVA = "0xE97DF0", Offset = "0xE969F0", VA = "0x180E97DF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060161F8 RID: 90616 RVA: 0x0008F8B0 File Offset: 0x0008DAB0
		[Token(Token = "0x60161F8")]
		[Address(RVA = "0xE96C40", Offset = "0xE95840", VA = "0x180E96C40")]
		private bool _TransToStateWithRemoveMode(StateTransOptions config, Type newPushStateType)
		{
			return default(bool);
		}

		// Token: 0x060161F9 RID: 90617 RVA: 0x0008F8C8 File Offset: 0x0008DAC8
		[Token(Token = "0x60161F9")]
		[Address(RVA = "0xE95200", Offset = "0xE93E00", VA = "0x180E95200", Slot = "12")]
		public bool RemoveTop(StateTransOptions config)
		{
			return default(bool);
		}

		// Token: 0x060161FA RID: 90618 RVA: 0x0008F8E0 File Offset: 0x0008DAE0
		[Token(Token = "0x60161FA")]
		[Address(RVA = "0xE95110", Offset = "0xE93D10", VA = "0x180E95110", Slot = "13")]
		public bool RemoveTop()
		{
			return default(bool);
		}

		// Token: 0x060161FB RID: 90619 RVA: 0x0008F8F8 File Offset: 0x0008DAF8
		[Token(Token = "0x60161FB")]
		[Address(RVA = "0xE97420", Offset = "0xE96020", VA = "0x180E97420")]
		private bool _TransToStateWithReplaceMode(Type stateType, StateTransOptions config)
		{
			return default(bool);
		}

		// Token: 0x060161FC RID: 90620 RVA: 0x0008F910 File Offset: 0x0008DB10
		[Token(Token = "0x60161FC")]
		[Address(RVA = "0xE963C0", Offset = "0xE94FC0", VA = "0x180E963C0")]
		private bool _ReplaceTopWithMode(Type stateType, StateTransOptions config, StateReplaceTransMode transMode = StateReplaceTransMode.REPLACE_MODE)
		{
			return default(bool);
		}

		// Token: 0x060161FD RID: 90621 RVA: 0x0008F928 File Offset: 0x0008DB28
		[Token(Token = "0x60161FD")]
		[Address(RVA = "0xE95280", Offset = "0xE93E80", VA = "0x180E95280", Slot = "8")]
		public bool ReplaceTop(Type stateType, StateTransOptions config, StateReplaceTransMode transMode = StateReplaceTransMode.REPLACE_MODE)
		{
			return default(bool);
		}

		// Token: 0x060161FE RID: 90622 RVA: 0x0008F940 File Offset: 0x0008DB40
		[Token(Token = "0x60161FE")]
		[Address(RVA = "0xE95320", Offset = "0xE93F20", VA = "0x180E95320", Slot = "9")]
		public bool ReplaceTop(Type stateType, StateReplaceTransMode transMode = StateReplaceTransMode.REPLACE_MODE)
		{
			return default(bool);
		}

		// Token: 0x060161FF RID: 90623 RVA: 0x0008F958 File Offset: 0x0008DB58
		[Token(Token = "0x60161FF")]
		public bool ReplaceTop<T>(StateReplaceTransMode transMode = StateReplaceTransMode.REPLACE_MODE) where T : State
		{
			return default(bool);
		}

		// Token: 0x06016200 RID: 90624 RVA: 0x0008F970 File Offset: 0x0008DB70
		[Token(Token = "0x6016200")]
		public bool ReplaceTop<T>(StateTransOptions config, StateReplaceTransMode transMode = StateReplaceTransMode.REPLACE_MODE) where T : State
		{
			return default(bool);
		}

		// Token: 0x06016201 RID: 90625 RVA: 0x0008F988 File Offset: 0x0008DB88
		[Token(Token = "0x6016201")]
		[Address(RVA = "0xE94A50", Offset = "0xE93650", VA = "0x180E94A50", Slot = "14")]
		public bool RemoveToState(Type stateType, StateTransOptions config)
		{
			return default(bool);
		}

		// Token: 0x06016202 RID: 90626 RVA: 0x0008F9A0 File Offset: 0x0008DBA0
		[Token(Token = "0x6016202")]
		[Address(RVA = "0xE95060", Offset = "0xE93C60", VA = "0x180E95060", Slot = "15")]
		public bool RemoveToState(Type stateType)
		{
			return default(bool);
		}

		// Token: 0x06016203 RID: 90627 RVA: 0x0008F9B8 File Offset: 0x0008DBB8
		[Token(Token = "0x6016203")]
		public bool RemoveToState<T>() where T : State
		{
			return default(bool);
		}

		// Token: 0x06016204 RID: 90628 RVA: 0x0008F9D0 File Offset: 0x0008DBD0
		[Token(Token = "0x6016204")]
		public bool RemoveToState<T>(StateTransOptions config) where T : State
		{
			return default(bool);
		}

		// Token: 0x06016205 RID: 90629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016205")]
		[Address(RVA = "0xE947C0", Offset = "0xE933C0", VA = "0x180E947C0", Slot = "18")]
		public State GetFrontState()
		{
			return null;
		}

		// Token: 0x06016206 RID: 90630 RVA: 0x0008F9E8 File Offset: 0x0008DBE8
		[Token(Token = "0x6016206")]
		[Address(RVA = "0xE94920", Offset = "0xE93520", VA = "0x180E94920", Slot = "19")]
		public bool IsTransitting()
		{
			return default(bool);
		}

		// Token: 0x06016207 RID: 90631 RVA: 0x0008FA00 File Offset: 0x0008DC00
		[Token(Token = "0x6016207")]
		[Address(RVA = "0xE954E0", Offset = "0xE940E0", VA = "0x180E954E0", Slot = "20")]
		public StateEngineRuntime SaveToCache()
		{
			return default(StateEngineRuntime);
		}

		// Token: 0x06016208 RID: 90632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016208")]
		[Address(RVA = "0xE94980", Offset = "0xE93580", VA = "0x180E94980", Slot = "21")]
		public IEnumerator LoadFromCache(StateEngineRuntime runtime)
		{
			return null;
		}

		// Token: 0x06016209 RID: 90633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016209")]
		[Address(RVA = "0xE953F0", Offset = "0xE93FF0", VA = "0x180E953F0")]
		public IEnumerator ResetToDefault(State defaultState, bool force)
		{
			return null;
		}

		// Token: 0x0601620A RID: 90634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601620A")]
		[Address(RVA = "0xE94860", Offset = "0xE93460", VA = "0x180E94860", Slot = "22")]
		public UIPage GetPage()
		{
			return null;
		}

		// Token: 0x0601620B RID: 90635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601620B")]
		[Address(RVA = "0xE948C0", Offset = "0xE934C0", VA = "0x180E948C0", Slot = "23")]
		public IStateEnginePlugin GetPlugin()
		{
			return null;
		}

		// Token: 0x0601620C RID: 90636 RVA: 0x0008FA18 File Offset: 0x0008DC18
		[Token(Token = "0x601620C")]
		[Address(RVA = "0xE94630", Offset = "0xE93230", VA = "0x180E94630")]
		public bool CheckIfStateRegistered(Type stateType)
		{
			return default(bool);
		}

		// Token: 0x0601620D RID: 90637 RVA: 0x0008FA30 File Offset: 0x0008DC30
		[Token(Token = "0x601620D")]
		[Address(RVA = "0xE94700", Offset = "0xE93300", VA = "0x180E94700", Slot = "24")]
		public bool CheckIsExistInStack(Type stateType)
		{
			return default(bool);
		}

		// Token: 0x0601620E RID: 90638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601620E")]
		[Address(RVA = "0xE95750", Offset = "0xE94350", VA = "0x180E95750")]
		public IEnumerable<State> TranverseStaticStates()
		{
			return null;
		}

		// Token: 0x0601620F RID: 90639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601620F")]
		[Address(RVA = "0xE961E0", Offset = "0xE94DE0", VA = "0x180E961E0")]
		private State _PickStateInstance(Type stateType)
		{
			return null;
		}

		// Token: 0x06016210 RID: 90640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016210")]
		[Address(RVA = "0xE95B80", Offset = "0xE94780", VA = "0x180E95B80")]
		private void _ApplyStateCache(Type stateType, object cache)
		{
		}

		// Token: 0x06016211 RID: 90641 RVA: 0x0008FA48 File Offset: 0x0008DC48
		[Token(Token = "0x6016211")]
		[Address(RVA = "0xE96030", Offset = "0xE94C30", VA = "0x180E96030")]
		private bool _IsExistInStack(Type stateType)
		{
			return default(bool);
		}

		// Token: 0x06016212 RID: 90642 RVA: 0x0008FA60 File Offset: 0x0008DC60
		[Token(Token = "0x6016212")]
		[Address(RVA = "0xE95810", Offset = "0xE94410", VA = "0x180E95810")]
		private bool _AddStateWhenEmpty(Type stateType, StateTransOptions config, Action unlockAction)
		{
			return default(bool);
		}

		// Token: 0x06016213 RID: 90643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016213")]
		[Address(RVA = "0xE96290", Offset = "0xE94E90", VA = "0x180E96290")]
		private void _RemoveTheLastState(StateTransOptions config)
		{
		}

		// Token: 0x06016214 RID: 90644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016214")]
		[Address(RVA = "0xE964A0", Offset = "0xE950A0", VA = "0x180E964A0")]
		private void _SyncStatePool(State[] stateList)
		{
		}

		// Token: 0x06016215 RID: 90645 RVA: 0x0008FA78 File Offset: 0x0008DC78
		[Token(Token = "0x6016215")]
		[Address(RVA = "0xE96170", Offset = "0xE94D70", VA = "0x180E96170")]
		private bool _LockTransition()
		{
			return default(bool);
		}

		// Token: 0x06016216 RID: 90646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016216")]
		[Address(RVA = "0xE97B10", Offset = "0xE96710", VA = "0x180E97B10")]
		private void _UnlockTransition()
		{
		}

		// Token: 0x06016217 RID: 90647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016217")]
		[Address(RVA = "0xE97A40", Offset = "0xE96640", VA = "0x180E97A40")]
		private void _TryTriggerStory(State state)
		{
		}

		// Token: 0x06016218 RID: 90648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016218")]
		[Address(RVA = "0xE95EF0", Offset = "0xE94AF0", VA = "0x180E95EF0")]
		private Stack<Type> _GenerateStateTypeStack()
		{
			return null;
		}

		// Token: 0x0401A97E RID: 108926
		[Token(Token = "0x401A97E")]
		[FieldOffset(Offset = "0x10")]
		private Stack<StateEngineImpl.StackElement> m_stateStack;

		// Token: 0x0401A97F RID: 108927
		[Token(Token = "0x401A97F")]
		[FieldOffset(Offset = "0x18")]
		private ITransitionManager m_transMgr;

		// Token: 0x0401A980 RID: 108928
		[Token(Token = "0x401A980")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<Type, State> m_staticStatePool;

		// Token: 0x0401A981 RID: 108929
		[Token(Token = "0x401A981")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isTransitting;

		// Token: 0x0401A982 RID: 108930
		[Token(Token = "0x401A982")]
		[FieldOffset(Offset = "0x30")]
		private IStateEnginePlugin m_plugin;

		// Token: 0x0401A983 RID: 108931
		[Token(Token = "0x401A983")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A984 RID: 108932
		[Token(Token = "0x401A984")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ClearInputModuleWhenNecessary;

		// Token: 0x0401A985 RID: 108933
		[Token(Token = "0x401A985")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckStateNeedInterrupt;

		// Token: 0x0401A986 RID: 108934
		[Token(Token = "0x401A986")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TransToStateWithAddMode;

		// Token: 0x0401A987 RID: 108935
		[Token(Token = "0x401A987")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddTop;

		// Token: 0x0401A988 RID: 108936
		[Token(Token = "0x401A988")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_AddTop;

		// Token: 0x0401A989 RID: 108937
		[Token(Token = "0x401A989")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix2_AddTop;

		// Token: 0x0401A98A RID: 108938
		[Token(Token = "0x401A98A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix3_AddTop;

		// Token: 0x0401A98B RID: 108939
		[Token(Token = "0x401A98B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_StackCount;

		// Token: 0x0401A98C RID: 108940
		[Token(Token = "0x401A98C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TransToStateWithRemoveMode;

		// Token: 0x0401A98D RID: 108941
		[Token(Token = "0x401A98D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RemoveTop;

		// Token: 0x0401A98E RID: 108942
		[Token(Token = "0x401A98E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix1_RemoveTop;

		// Token: 0x0401A98F RID: 108943
		[Token(Token = "0x401A98F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TransToStateWithReplaceMode;

		// Token: 0x0401A990 RID: 108944
		[Token(Token = "0x401A990")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ReplaceTopWithMode;

		// Token: 0x0401A991 RID: 108945
		[Token(Token = "0x401A991")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ReplaceTop;

		// Token: 0x0401A992 RID: 108946
		[Token(Token = "0x401A992")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1_ReplaceTop;

		// Token: 0x0401A993 RID: 108947
		[Token(Token = "0x401A993")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix2_ReplaceTop;

		// Token: 0x0401A994 RID: 108948
		[Token(Token = "0x401A994")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix3_ReplaceTop;

		// Token: 0x0401A995 RID: 108949
		[Token(Token = "0x401A995")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_RemoveToState;

		// Token: 0x0401A996 RID: 108950
		[Token(Token = "0x401A996")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix1_RemoveToState;

		// Token: 0x0401A997 RID: 108951
		[Token(Token = "0x401A997")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix2_RemoveToState;

		// Token: 0x0401A998 RID: 108952
		[Token(Token = "0x401A998")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix3_RemoveToState;

		// Token: 0x0401A999 RID: 108953
		[Token(Token = "0x401A999")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetFrontState;

		// Token: 0x0401A99A RID: 108954
		[Token(Token = "0x401A99A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_IsTransitting;

		// Token: 0x0401A99B RID: 108955
		[Token(Token = "0x401A99B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SaveToCache;

		// Token: 0x0401A99C RID: 108956
		[Token(Token = "0x401A99C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_LoadFromCache;

		// Token: 0x0401A99D RID: 108957
		[Token(Token = "0x401A99D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ResetToDefault;

		// Token: 0x0401A99E RID: 108958
		[Token(Token = "0x401A99E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetPage;

		// Token: 0x0401A99F RID: 108959
		[Token(Token = "0x401A99F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetPlugin;

		// Token: 0x0401A9A0 RID: 108960
		[Token(Token = "0x401A9A0")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_CheckIfStateRegistered;

		// Token: 0x0401A9A1 RID: 108961
		[Token(Token = "0x401A9A1")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CheckIsExistInStack;

		// Token: 0x0401A9A2 RID: 108962
		[Token(Token = "0x401A9A2")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_TranverseStaticStates;

		// Token: 0x0401A9A3 RID: 108963
		[Token(Token = "0x401A9A3")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__PickStateInstance;

		// Token: 0x0401A9A4 RID: 108964
		[Token(Token = "0x401A9A4")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__ApplyStateCache;

		// Token: 0x0401A9A5 RID: 108965
		[Token(Token = "0x401A9A5")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__IsExistInStack;

		// Token: 0x0401A9A6 RID: 108966
		[Token(Token = "0x401A9A6")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__AddStateWhenEmpty;

		// Token: 0x0401A9A7 RID: 108967
		[Token(Token = "0x401A9A7")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__RemoveTheLastState;

		// Token: 0x0401A9A8 RID: 108968
		[Token(Token = "0x401A9A8")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__SyncStatePool;

		// Token: 0x0401A9A9 RID: 108969
		[Token(Token = "0x401A9A9")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__LockTransition;

		// Token: 0x0401A9AA RID: 108970
		[Token(Token = "0x401A9AA")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__UnlockTransition;

		// Token: 0x0401A9AB RID: 108971
		[Token(Token = "0x401A9AB")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__TryTriggerStory;

		// Token: 0x0401A9AC RID: 108972
		[Token(Token = "0x401A9AC")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__GenerateStateTypeStack;

		// Token: 0x02003650 RID: 13904
		[Token(Token = "0x2003650")]
		private struct StackElement
		{
			// Token: 0x06016219 RID: 90649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016219")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			public State GetState()
			{
				return null;
			}

			// Token: 0x0601621A RID: 90650 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601621A")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			public string GetClassName()
			{
				return null;
			}

			// Token: 0x0601621B RID: 90651 RVA: 0x0008FA90 File Offset: 0x0008DC90
			[Token(Token = "0x601621B")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			public StateSource GetStateSource()
			{
				return StateSource.Init;
			}

			// Token: 0x0601621C RID: 90652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601621C")]
			[Address(RVA = "0xE93EF0", Offset = "0xE92AF0", VA = "0x180E93EF0")]
			public StackElement(State state, StateSource source)
			{
			}

			// Token: 0x0601621D RID: 90653 RVA: 0x0008FAA8 File Offset: 0x0008DCA8
			[Token(Token = "0x601621D")]
			[Address(RVA = "0xE93E70", Offset = "0xE92A70", VA = "0x180E93E70")]
			public bool IsStateTypeMatch(Type stateType)
			{
				return default(bool);
			}

			// Token: 0x0401A9AD RID: 108973
			[Token(Token = "0x401A9AD")]
			[FieldOffset(Offset = "0x0")]
			private string m_className;

			// Token: 0x0401A9AE RID: 108974
			[Token(Token = "0x401A9AE")]
			[FieldOffset(Offset = "0x8")]
			private State m_state;

			// Token: 0x0401A9AF RID: 108975
			[Token(Token = "0x401A9AF")]
			[FieldOffset(Offset = "0x10")]
			private StateSource m_source;
		}
	}
}
