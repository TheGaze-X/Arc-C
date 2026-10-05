using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.CharWord;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DD0 RID: 15824
	[Token(Token = "0x2003DD0")]
	public class SquadHomeState : State, ISquadCharSelectContext, IValueMsgReceiver
	{
		// Token: 0x060189D2 RID: 100818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189D2")]
		[Address(RVA = "0x1129960", Offset = "0x1128560", VA = "0x181129960")]
		private void OnEnable()
		{
		}

		// Token: 0x060189D3 RID: 100819 RVA: 0x0009AEC0 File Offset: 0x000990C0
		[Token(Token = "0x60189D3")]
		[Address(RVA = "0x11291A0", Offset = "0x1127DA0", VA = "0x1811291A0")]
		public static SquadFriendListItem.LockedStyle GenLockedStyle4CharAlreadyExist()
		{
			return default(SquadFriendListItem.LockedStyle);
		}

		// Token: 0x060189D4 RID: 100820 RVA: 0x0009AED8 File Offset: 0x000990D8
		[Token(Token = "0x60189D4")]
		[Address(RVA = "0x1129460", Offset = "0x1128060", VA = "0x181129460")]
		public static SquadFriendListItem.LockedStyle GenLockedStyle4ExclusiveCharAlreadyExist(string exclusiveInfo)
		{
			return default(SquadFriendListItem.LockedStyle);
		}

		// Token: 0x060189D5 RID: 100821 RVA: 0x0009AEF0 File Offset: 0x000990F0
		[Token(Token = "0x60189D5")]
		[Address(RVA = "0x1129300", Offset = "0x1127F00", VA = "0x181129300")]
		public static SquadFriendListItem.LockedStyle GenLockedStyle4CharRequired()
		{
			return default(SquadFriendListItem.LockedStyle);
		}

		// Token: 0x060189D6 RID: 100822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189D6")]
		[Address(RVA = "0x1129E90", Offset = "0x1128A90", VA = "0x181129E90", Slot = "25")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060189D7 RID: 100823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60189D7")]
		[Address(RVA = "0x11295C0", Offset = "0x11281C0", VA = "0x1811295C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060189D8 RID: 100824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189D8")]
		[Address(RVA = "0x11299F0", Offset = "0x11285F0", VA = "0x1811299F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060189D9 RID: 100825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189D9")]
		[Address(RVA = "0x1129F40", Offset = "0x1128B40", VA = "0x181129F40", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060189DA RID: 100826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189DA")]
		[Address(RVA = "0x11298D0", Offset = "0x11284D0", VA = "0x1811298D0")]
		public void GoToFriendAssistState()
		{
		}

		// Token: 0x060189DB RID: 100827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60189DB")]
		[Address(RVA = "0x112AD70", Offset = "0x1129970", VA = "0x18112AD70", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060189DC RID: 100828 RVA: 0x0009AF08 File Offset: 0x00099108
		[Token(Token = "0x60189DC")]
		[Address(RVA = "0x112C120", Offset = "0x112AD20", VA = "0x18112C120", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x060189DD RID: 100829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60189DD")]
		[Address(RVA = "0x112AAC0", Offset = "0x11296C0", VA = "0x18112AAC0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x060189DE RID: 100830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60189DE")]
		[Address(RVA = "0x1129870", Offset = "0x1128470", VA = "0x181129870", Slot = "23")]
		public List<int> GetTempListForExclusiveInstIds()
		{
			return null;
		}

		// Token: 0x060189DF RID: 100831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60189DF")]
		[Address(RVA = "0x11297F0", Offset = "0x11283F0", VA = "0x1811297F0", Slot = "24")]
		public SquadGroupViewModel GetSquadGroupViewModel()
		{
			return null;
		}

		// Token: 0x060189E0 RID: 100832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189E0")]
		[Address(RVA = "0x1127CC0", Offset = "0x11268C0", VA = "0x181127CC0")]
		public static void ApplySquadFromCharSelect(SquadGroupViewModel squadGroupModel, SquadHomeState.ICharSelectInput input, CharSelectStateBean.Output output)
		{
		}

		// Token: 0x060189E1 RID: 100833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189E1")]
		[Address(RVA = "0x112C820", Offset = "0x112B420", VA = "0x18112C820")]
		private static void _ApplySquadFromCharSelectSingleMode(CharacterCardViewModel target, int editIndex, SquadViewModel squad)
		{
		}

		// Token: 0x060189E2 RID: 100834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189E2")]
		[Address(RVA = "0x112C280", Offset = "0x112AE80", VA = "0x18112C280")]
		private static void _ApplySquadFromCharSelectMultiMode(IList<CharacterCardViewModel> selectedChars, SquadViewModel squad)
		{
		}

		// Token: 0x060189E3 RID: 100835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60189E3")]
		[Address(RVA = "0x112BE30", Offset = "0x112AA30", VA = "0x18112BE30")]
		public static string UpdateCharSelectedSkill(int instId, string prevSkill, IList<SquadItemStruct> squad)
		{
			return null;
		}

		// Token: 0x060189E4 RID: 100836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60189E4")]
		[Address(RVA = "0x112BBA0", Offset = "0x112A7A0", VA = "0x18112BBA0")]
		public static string UpdateCharSelectedBranch(int instId, string prevEquip, IList<SquadItemStruct> squad)
		{
			return null;
		}

		// Token: 0x060189E5 RID: 100837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189E5")]
		[Address(RVA = "0x112A9B0", Offset = "0x11295B0", VA = "0x18112A9B0")]
		public static void PlaySquadVoice(VoiceQuery query, int squadIndex)
		{
		}

		// Token: 0x060189E6 RID: 100838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189E6")]
		[Address(RVA = "0x112A410", Offset = "0x1129010", VA = "0x18112A410")]
		public static void PlaySquadVoice(IList<SquadItemStruct> prevSquad, IList<CharacterCardViewModel> newSquad)
		{
		}

		// Token: 0x060189E7 RID: 100839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189E7")]
		[Address(RVA = "0x112A8C0", Offset = "0x11294C0", VA = "0x18112A8C0")]
		public static void PlaySquadVoice(IList<VoiceQuery> prevSquad, IList<VoiceQuery> newSquad)
		{
		}

		// Token: 0x060189E8 RID: 100840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189E8")]
		[Address(RVA = "0x1128CC0", Offset = "0x11278C0", VA = "0x181128CC0")]
		public void EventOnSquadTabClick(int index)
		{
		}

		// Token: 0x060189E9 RID: 100841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189E9")]
		[Address(RVA = "0x1128B50", Offset = "0x1127750", VA = "0x181128B50")]
		public void EventOnSquadLeftClick(int delta)
		{
		}

		// Token: 0x060189EA RID: 100842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189EA")]
		[Address(RVA = "0x11282D0", Offset = "0x1126ED0", VA = "0x1811282D0")]
		public void EventOnClearBtnClick()
		{
		}

		// Token: 0x060189EB RID: 100843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189EB")]
		[Address(RVA = "0x1128890", Offset = "0x1127490", VA = "0x181128890")]
		public void EventOnSingleFormatClick(int memberIndex)
		{
		}

		// Token: 0x060189EC RID: 100844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189EC")]
		[Address(RVA = "0x11287E0", Offset = "0x11273E0", VA = "0x1811287E0")]
		public void EventOnRenameClick(int squadIndex)
		{
		}

		// Token: 0x060189ED RID: 100845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189ED")]
		[Address(RVA = "0x1128520", Offset = "0x1127120", VA = "0x181128520")]
		public void EventOnMultiFormatClick()
		{
		}

		// Token: 0x060189EE RID: 100846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189EE")]
		[Address(RVA = "0x1128DF0", Offset = "0x11279F0", VA = "0x181128DF0")]
		public void EventOnStartBattleClick()
		{
		}

		// Token: 0x060189EF RID: 100847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189EF")]
		[Address(RVA = "0x112F6E0", Offset = "0x112E2E0", VA = "0x18112F6E0")]
		private void _OnInitTopMenu(GameObject topMenuObj)
		{
		}

		// Token: 0x060189F0 RID: 100848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189F0")]
		[Address(RVA = "0x112FAB0", Offset = "0x112E6B0", VA = "0x18112FAB0")]
		private void _OnTopMenuRoutedToOtherPage(UIRouteTarget routeTarget, object param, Action<UIRouteTarget, object> baseHandler)
		{
		}

		// Token: 0x060189F1 RID: 100849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189F1")]
		[Address(RVA = "0x1128200", Offset = "0x1126E00", VA = "0x181128200")]
		public void CleanAssist()
		{
		}

		// Token: 0x060189F2 RID: 100850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189F2")]
		[Address(RVA = "0x112FA50", Offset = "0x112E650", VA = "0x18112FA50")]
		private void _OnStartBattleSuccess()
		{
		}

		// Token: 0x060189F3 RID: 100851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60189F3")]
		[Address(RVA = "0x112A0E0", Offset = "0x1128CE0", VA = "0x18112A0E0")]
		public static CharacterCardViewModel PickRandomCharacter(IList<SquadItemStruct> squad)
		{
			return null;
		}

		// Token: 0x060189F4 RID: 100852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189F4")]
		[Address(RVA = "0x112ED30", Offset = "0x112D930", VA = "0x18112ED30")]
		private void _DeleteCurrentSquad()
		{
		}

		// Token: 0x060189F5 RID: 100853 RVA: 0x0009AF20 File Offset: 0x00099120
		[Token(Token = "0x60189F5")]
		[Address(RVA = "0x11301D0", Offset = "0x112EDD0", VA = "0x1811301D0")]
		private CharSelectStateBean.Input _ParseSquadSelectParam(bool isSingleMode, int memberIndex)
		{
			return default(CharSelectStateBean.Input);
		}

		// Token: 0x060189F6 RID: 100854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189F6")]
		[Address(RVA = "0x1130D80", Offset = "0x112F980", VA = "0x181130D80")]
		private void _SaveSquadFormationIfNeeded(Action<SquadFormationResponse> nextStep, bool mustGoNext = true)
		{
		}

		// Token: 0x060189F7 RID: 100855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60189F7")]
		[Address(RVA = "0x112FC00", Offset = "0x112E800", VA = "0x18112FC00")]
		private SquadFormationRequest _ParseSquadFormationRequest()
		{
			return null;
		}

		// Token: 0x060189F8 RID: 100856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189F8")]
		[Address(RVA = "0x112AFB0", Offset = "0x1129BB0", VA = "0x18112AFB0")]
		public static void SendAssistCharListRequest(ProfessionCategory profession, bool refreshFlag, string squadId, Action<GetFriendAssistCharListResponse> onProceed)
		{
		}

		// Token: 0x060189F9 RID: 100857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189F9")]
		[Address(RVA = "0x1129620", Offset = "0x1128220", VA = "0x181129620")]
		public void GetSquadAssist()
		{
		}

		// Token: 0x060189FA RID: 100858 RVA: 0x0009AF38 File Offset: 0x00099138
		[Token(Token = "0x60189FA")]
		[Address(RVA = "0x112D480", Offset = "0x112C080", VA = "0x18112D480")]
		private BattleStartController.Param _CreateParamToStartBattle()
		{
			return default(BattleStartController.Param);
		}

		// Token: 0x060189FB RID: 100859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60189FB")]
		[Address(RVA = "0x112F3D0", Offset = "0x112DFD0", VA = "0x18112F3D0")]
		private string _GetRetroGroupIdForStartBattle(string stageId)
		{
			return null;
		}

		// Token: 0x060189FC RID: 100860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189FC")]
		[Address(RVA = "0x112F4C0", Offset = "0x112E0C0", VA = "0x18112F4C0")]
		private void _InvokedStartBattle(BattleStartController.Param param)
		{
		}

		// Token: 0x060189FD RID: 100861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189FD")]
		[Address(RVA = "0x112F860", Offset = "0x112E460", VA = "0x18112F860")]
		private void _OnResReadyToStartBattle(BattleStartController.Param param)
		{
		}

		// Token: 0x060189FE RID: 100862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189FE")]
		[Address(RVA = "0x1130900", Offset = "0x112F500", VA = "0x181130900")]
		private void _QuitSquad(SquadFormationResponse response)
		{
		}

		// Token: 0x060189FF RID: 100863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189FF")]
		[Address(RVA = "0x11309D0", Offset = "0x112F5D0", VA = "0x1811309D0")]
		private void _RaiseSavedSquadSignal()
		{
		}

		// Token: 0x06018A00 RID: 100864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A00")]
		[Address(RVA = "0x112C190", Offset = "0x112AD90", VA = "0x18112C190")]
		private void _AlertSquadInvalid()
		{
		}

		// Token: 0x06018A01 RID: 100865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A01")]
		[Address(RVA = "0x1130A30", Offset = "0x112F630", VA = "0x181130A30")]
		private void _SaveCacheStageConfig()
		{
		}

		// Token: 0x06018A02 RID: 100866 RVA: 0x0009AF50 File Offset: 0x00099150
		[Token(Token = "0x6018A02")]
		[Address(RVA = "0x112CDF0", Offset = "0x112B9F0", VA = "0x18112CDF0")]
		private bool _CheckIfStartBattleValid()
		{
			return default(bool);
		}

		// Token: 0x06018A03 RID: 100867 RVA: 0x0009AF68 File Offset: 0x00099168
		[Token(Token = "0x6018A03")]
		[Address(RVA = "0x112CCC0", Offset = "0x112B8C0", VA = "0x18112CCC0")]
		private bool _CheckIfStageCrossDays(SquadPage.Params squadParam)
		{
			return default(bool);
		}

		// Token: 0x06018A04 RID: 100868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018A04")]
		[Address(RVA = "0x112F300", Offset = "0x112DF00", VA = "0x18112F300")]
		private SquadItemStruct[] _GetCurSquadMembers()
		{
			return null;
		}

		// Token: 0x06018A05 RID: 100869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A05")]
		[Address(RVA = "0x112D3A0", Offset = "0x112BFA0", VA = "0x18112D3A0")]
		private void _ConfirmTipsAndDoStartBattle()
		{
		}

		// Token: 0x06018A06 RID: 100870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A06")]
		[Address(RVA = "0x112EF30", Offset = "0x112DB30", VA = "0x18112EF30")]
		private void _DoStartBattle()
		{
		}

		// Token: 0x06018A07 RID: 100871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A07")]
		[Address(RVA = "0x1131030", Offset = "0x112FC30", VA = "0x181131030")]
		private void _TriggerSquadPluginResume()
		{
		}

		// Token: 0x06018A08 RID: 100872 RVA: 0x0009AF80 File Offset: 0x00099180
		[Token(Token = "0x6018A08")]
		[Address(RVA = "0x112F150", Offset = "0x112DD50", VA = "0x18112F150")]
		private static SquadItemStruct _FindInstInSquad(int instId, IList<SquadItemStruct> squad)
		{
			return default(SquadItemStruct);
		}

		// Token: 0x06018A09 RID: 100873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A09")]
		[Address(RVA = "0x11310A0", Offset = "0x112FCA0", VA = "0x1811310A0")]
		public SquadHomeState()
		{
		}

		// Token: 0x06018A14 RID: 100884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A14")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06018A15 RID: 100885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018A15")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06018A16 RID: 100886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018A16")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06018A17 RID: 100887 RVA: 0x0009AF98 File Offset: 0x00099198
		[Token(Token = "0x6018A17")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x06018A18 RID: 100888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018A18")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0401E2BD RID: 123581
		[Token(Token = "0x401E2BD")]
		[NonSerialized]
		public const int ON_MSG_REFRESH_DATA = 10;

		// Token: 0x0401E2BE RID: 123582
		[Token(Token = "0x401E2BE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SquadHomeStateBean _stateBean;

		// Token: 0x0401E2BF RID: 123583
		[Token(Token = "0x401E2BF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0401E2C0 RID: 123584
		[Token(Token = "0x401E2C0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Animator _deleteState;

		// Token: 0x0401E2C1 RID: 123585
		[Token(Token = "0x401E2C1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelNormalSquad;

		// Token: 0x0401E2C2 RID: 123586
		[Token(Token = "0x401E2C2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelBattleSquad;

		// Token: 0x0401E2C3 RID: 123587
		[Token(Token = "0x401E2C3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SquadGroupController _squadGroupController;

		// Token: 0x0401E2C4 RID: 123588
		[Token(Token = "0x401E2C4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SquadHomePluginLoader _homePluginLoader;

		// Token: 0x0401E2C5 RID: 123589
		[Token(Token = "0x401E2C5")]
		private const string ANIMATORPARAM = "delete";

		// Token: 0x0401E2C6 RID: 123590
		[Token(Token = "0x401E2C6")]
		[FieldOffset(Offset = "0x88")]
		private bool m_deleteFlag;

		// Token: 0x0401E2C7 RID: 123591
		[Token(Token = "0x401E2C7")]
		[FieldOffset(Offset = "0x8C")]
		private int m_editingSquadIndexCache;

		// Token: 0x0401E2C8 RID: 123592
		[Token(Token = "0x401E2C8")]
		[FieldOffset(Offset = "0x90")]
		private SquadHomePlugin m_squadHomePlugin;

		// Token: 0x0401E2C9 RID: 123593
		[Token(Token = "0x401E2C9")]
		[FieldOffset(Offset = "0x98")]
		private SquadCharSelectMaskPlugin m_charSelectMaskPluginPrefab;

		// Token: 0x0401E2CA RID: 123594
		[Token(Token = "0x401E2CA")]
		[FieldOffset(Offset = "0xA0")]
		private SquadHomeState.DefaultCharSelectInput m_charSelectInputParam;

		// Token: 0x0401E2CB RID: 123595
		[Token(Token = "0x401E2CB")]
		[FieldOffset(Offset = "0xE8")]
		private List<int> m_tempListForExclusiveInstIds;

		// Token: 0x0401E2CC RID: 123596
		[Token(Token = "0x401E2CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401E2CD RID: 123597
		[Token(Token = "0x401E2CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenLockedStyle4CharAlreadyExist;

		// Token: 0x0401E2CE RID: 123598
		[Token(Token = "0x401E2CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenLockedStyle4ExclusiveCharAlreadyExist;

		// Token: 0x0401E2CF RID: 123599
		[Token(Token = "0x401E2CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenLockedStyle4CharRequired;

		// Token: 0x0401E2D0 RID: 123600
		[Token(Token = "0x401E2D0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401E2D1 RID: 123601
		[Token(Token = "0x401E2D1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401E2D2 RID: 123602
		[Token(Token = "0x401E2D2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401E2D3 RID: 123603
		[Token(Token = "0x401E2D3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401E2D4 RID: 123604
		[Token(Token = "0x401E2D4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GoToFriendAssistState;

		// Token: 0x0401E2D5 RID: 123605
		[Token(Token = "0x401E2D5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401E2D6 RID: 123606
		[Token(Token = "0x401E2D6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0401E2D7 RID: 123607
		[Token(Token = "0x401E2D7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0401E2D8 RID: 123608
		[Token(Token = "0x401E2D8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetTempListForExclusiveInstIds;

		// Token: 0x0401E2D9 RID: 123609
		[Token(Token = "0x401E2D9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetSquadGroupViewModel;

		// Token: 0x0401E2DA RID: 123610
		[Token(Token = "0x401E2DA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ApplySquadFromCharSelect;

		// Token: 0x0401E2DB RID: 123611
		[Token(Token = "0x401E2DB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ApplySquadFromCharSelectSingleMode;

		// Token: 0x0401E2DC RID: 123612
		[Token(Token = "0x401E2DC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ApplySquadFromCharSelectMultiMode;

		// Token: 0x0401E2DD RID: 123613
		[Token(Token = "0x401E2DD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_UpdateCharSelectedSkill;

		// Token: 0x0401E2DE RID: 123614
		[Token(Token = "0x401E2DE")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_UpdateCharSelectedBranch;

		// Token: 0x0401E2DF RID: 123615
		[Token(Token = "0x401E2DF")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_PlaySquadVoice;

		// Token: 0x0401E2E0 RID: 123616
		[Token(Token = "0x401E2E0")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix1_PlaySquadVoice;

		// Token: 0x0401E2E1 RID: 123617
		[Token(Token = "0x401E2E1")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix2_PlaySquadVoice;

		// Token: 0x0401E2E2 RID: 123618
		[Token(Token = "0x401E2E2")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnSquadTabClick;

		// Token: 0x0401E2E3 RID: 123619
		[Token(Token = "0x401E2E3")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_EventOnSquadLeftClick;

		// Token: 0x0401E2E4 RID: 123620
		[Token(Token = "0x401E2E4")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_EventOnClearBtnClick;

		// Token: 0x0401E2E5 RID: 123621
		[Token(Token = "0x401E2E5")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_EventOnSingleFormatClick;

		// Token: 0x0401E2E6 RID: 123622
		[Token(Token = "0x401E2E6")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_EventOnRenameClick;

		// Token: 0x0401E2E7 RID: 123623
		[Token(Token = "0x401E2E7")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_EventOnMultiFormatClick;

		// Token: 0x0401E2E8 RID: 123624
		[Token(Token = "0x401E2E8")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_EventOnStartBattleClick;

		// Token: 0x0401E2E9 RID: 123625
		[Token(Token = "0x401E2E9")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x0401E2EA RID: 123626
		[Token(Token = "0x401E2EA")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnTopMenuRoutedToOtherPage;

		// Token: 0x0401E2EB RID: 123627
		[Token(Token = "0x401E2EB")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CleanAssist;

		// Token: 0x0401E2EC RID: 123628
		[Token(Token = "0x401E2EC")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__OnStartBattleSuccess;

		// Token: 0x0401E2ED RID: 123629
		[Token(Token = "0x401E2ED")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_PickRandomCharacter;

		// Token: 0x0401E2EE RID: 123630
		[Token(Token = "0x401E2EE")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__DeleteCurrentSquad;

		// Token: 0x0401E2EF RID: 123631
		[Token(Token = "0x401E2EF")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__ParseSquadSelectParam;

		// Token: 0x0401E2F0 RID: 123632
		[Token(Token = "0x401E2F0")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__SaveSquadFormationIfNeeded;

		// Token: 0x0401E2F1 RID: 123633
		[Token(Token = "0x401E2F1")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__ParseSquadFormationRequest;

		// Token: 0x0401E2F2 RID: 123634
		[Token(Token = "0x401E2F2")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_SendAssistCharListRequest;

		// Token: 0x0401E2F3 RID: 123635
		[Token(Token = "0x401E2F3")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GetSquadAssist;

		// Token: 0x0401E2F4 RID: 123636
		[Token(Token = "0x401E2F4")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__CreateParamToStartBattle;

		// Token: 0x0401E2F5 RID: 123637
		[Token(Token = "0x401E2F5")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__GetRetroGroupIdForStartBattle;

		// Token: 0x0401E2F6 RID: 123638
		[Token(Token = "0x401E2F6")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__InvokedStartBattle;

		// Token: 0x0401E2F7 RID: 123639
		[Token(Token = "0x401E2F7")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__OnResReadyToStartBattle;

		// Token: 0x0401E2F8 RID: 123640
		[Token(Token = "0x401E2F8")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__QuitSquad;

		// Token: 0x0401E2F9 RID: 123641
		[Token(Token = "0x401E2F9")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__RaiseSavedSquadSignal;

		// Token: 0x0401E2FA RID: 123642
		[Token(Token = "0x401E2FA")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__AlertSquadInvalid;

		// Token: 0x0401E2FB RID: 123643
		[Token(Token = "0x401E2FB")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__SaveCacheStageConfig;

		// Token: 0x0401E2FC RID: 123644
		[Token(Token = "0x401E2FC")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__CheckIfStartBattleValid;

		// Token: 0x0401E2FD RID: 123645
		[Token(Token = "0x401E2FD")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__CheckIfStageCrossDays;

		// Token: 0x0401E2FE RID: 123646
		[Token(Token = "0x401E2FE")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__GetCurSquadMembers;

		// Token: 0x0401E2FF RID: 123647
		[Token(Token = "0x401E2FF")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__ConfirmTipsAndDoStartBattle;

		// Token: 0x0401E300 RID: 123648
		[Token(Token = "0x401E300")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__DoStartBattle;

		// Token: 0x0401E301 RID: 123649
		[Token(Token = "0x401E301")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__TriggerSquadPluginResume;

		// Token: 0x0401E302 RID: 123650
		[Token(Token = "0x401E302")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__FindInstInSquad;

		// Token: 0x0401E303 RID: 123651
		[Token(Token = "0x401E303")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003DD1 RID: 15825
		[Token(Token = "0x2003DD1")]
		public class SquadAssistPlugin : SquadFriendAssistState.Plugin<SquadHomeState>
		{
			// Token: 0x06018A19 RID: 100889 RVA: 0x0009AFB0 File Offset: 0x000991B0
			[Token(Token = "0x6018A19")]
			[Address(RVA = "0x11222E0", Offset = "0x1120EE0", VA = "0x1811222E0", Slot = "9")]
			public override bool CheckIfCharValid(CharQuery charQuery, ref SquadFriendListItem.LockedStyle lockStyleConfig)
			{
				return default(bool);
			}

			// Token: 0x06018A1A RID: 100890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A1A")]
			[Address(RVA = "0x11225F0", Offset = "0x11211F0", VA = "0x1811225F0")]
			public SquadAssistPlugin()
			{
			}
		}

		// Token: 0x02003DD2 RID: 15826
		[Token(Token = "0x2003DD2")]
		public class CharSelectPlugin : UICharacterSelectState.Plugin<SquadHomeState>
		{
			// Token: 0x17003AAC RID: 15020
			// (get) Token: 0x06018A1B RID: 100891 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003AAC")]
			public override string overrideNoCharText
			{
				[Token(Token = "0x6018A1B")]
				[Address(RVA = "0x111C330", Offset = "0x111AF30", VA = "0x18111C330", Slot = "28")]
				get
				{
					return null;
				}
			}

			// Token: 0x17003AAD RID: 15021
			// (get) Token: 0x06018A1C RID: 100892 RVA: 0x0009AFC8 File Offset: 0x000991C8
			[Token(Token = "0x17003AAD")]
			public override bool showCharInfoEntry
			{
				[Token(Token = "0x6018A1C")]
				[Address(RVA = "0x111C410", Offset = "0x111B010", VA = "0x18111C410", Slot = "29")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17003AAE RID: 15022
			// (get) Token: 0x06018A1D RID: 100893 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003AAE")]
			public override CharSelectCardMaskPlugin cardMaskPrefab
			{
				[Token(Token = "0x6018A1D")]
				[Address(RVA = "0x111C2B0", Offset = "0x111AEB0", VA = "0x18111C2B0", Slot = "32")]
				get
				{
					return null;
				}
			}

			// Token: 0x06018A1E RID: 100894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A1E")]
			[Address(RVA = "0x111B860", Offset = "0x111A460", VA = "0x18111B860", Slot = "25")]
			public override void OverrideCharSelect(int instId, Action<int> selfCharSelect)
			{
			}

			// Token: 0x06018A1F RID: 100895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A1F")]
			[Address(RVA = "0x111B9D0", Offset = "0x111A5D0", VA = "0x18111B9D0", Slot = "33")]
			public override void OverrideDismiss(Action selfDismiss)
			{
			}

			// Token: 0x06018A20 RID: 100896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A20")]
			[Address(RVA = "0x111BAD0", Offset = "0x111A6D0", VA = "0x18111BAD0", Slot = "27")]
			public override void OverrideSelectCanceled(Action selfCancel)
			{
			}

			// Token: 0x06018A21 RID: 100897 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A21")]
			[Address(RVA = "0x111BC50", Offset = "0x111A850", VA = "0x18111BC50", Slot = "26")]
			public override void OverrideSelectConfirmed(Action selfConfirm)
			{
			}

			// Token: 0x06018A22 RID: 100898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A22")]
			[Address(RVA = "0x111BCD0", Offset = "0x111A8D0", VA = "0x18111BCD0", Slot = "30")]
			public override void OverrideSkillSelect(string skillId, Action<string> selfSkillSelect)
			{
			}

			// Token: 0x06018A23 RID: 100899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A23")]
			[Address(RVA = "0x111B720", Offset = "0x111A320", VA = "0x18111B720", Slot = "31")]
			public override void OverrideBranchSelect(string equipId, Action<string> selfBranchSelect)
			{
			}

			// Token: 0x06018A24 RID: 100900 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018A24")]
			[Address(RVA = "0x111C080", Offset = "0x111AC80", VA = "0x18111C080", Slot = "34")]
			public override string OverrideUpdateSelectedSkill(int instId, string prevSkill, Func<int, string, string> selfUpdateSelectSkill)
			{
				return null;
			}

			// Token: 0x06018A25 RID: 100901 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018A25")]
			[Address(RVA = "0x111BEE0", Offset = "0x111AAE0", VA = "0x18111BEE0", Slot = "35")]
			public override string OverrideUpdateSelectedBranch(int instId, string prevBranch, Func<int, string, string> selfUpdateSelectBranch)
			{
				return null;
			}

			// Token: 0x06018A26 RID: 100902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A26")]
			[Address(RVA = "0x111B600", Offset = "0x111A200", VA = "0x18111B600", Slot = "37")]
			public override void AddCharMultiSelectExcludeRule(int instId, List<int> excludeInstIds)
			{
			}

			// Token: 0x06018A27 RID: 100903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A27")]
			[Address(RVA = "0x111C1C0", Offset = "0x111ADC0", VA = "0x18111C1C0")]
			public CharSelectPlugin()
			{
			}

			// Token: 0x0401E304 RID: 123652
			[Token(Token = "0x401E304")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_overrideNoCharText;

			// Token: 0x0401E305 RID: 123653
			[Token(Token = "0x401E305")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showCharInfoEntry;

			// Token: 0x0401E306 RID: 123654
			[Token(Token = "0x401E306")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_cardMaskPrefab;

			// Token: 0x0401E307 RID: 123655
			[Token(Token = "0x401E307")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OverrideCharSelect;

			// Token: 0x0401E308 RID: 123656
			[Token(Token = "0x401E308")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OverrideDismiss;

			// Token: 0x0401E309 RID: 123657
			[Token(Token = "0x401E309")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OverrideSelectCanceled;

			// Token: 0x0401E30A RID: 123658
			[Token(Token = "0x401E30A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OverrideSelectConfirmed;

			// Token: 0x0401E30B RID: 123659
			[Token(Token = "0x401E30B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OverrideSkillSelect;

			// Token: 0x0401E30C RID: 123660
			[Token(Token = "0x401E30C")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OverrideBranchSelect;

			// Token: 0x0401E30D RID: 123661
			[Token(Token = "0x401E30D")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OverrideUpdateSelectedSkill;

			// Token: 0x0401E30E RID: 123662
			[Token(Token = "0x401E30E")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OverrideUpdateSelectedBranch;

			// Token: 0x0401E30F RID: 123663
			[Token(Token = "0x401E30F")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_AddCharMultiSelectExcludeRule;

			// Token: 0x0401E310 RID: 123664
			[Token(Token = "0x401E310")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003DD3 RID: 15827
		[Token(Token = "0x2003DD3")]
		public interface ICharSelectInput
		{
			// Token: 0x17003AAF RID: 15023
			// (get) Token: 0x06018A28 RID: 100904
			[Token(Token = "0x17003AAF")]
			CharSelectStateBean.Input inputParam { [Token(Token = "0x6018A28")] get; }

			// Token: 0x17003AB0 RID: 15024
			// (get) Token: 0x06018A29 RID: 100905
			[Token(Token = "0x17003AB0")]
			int squadIndex { [Token(Token = "0x6018A29")] get; }
		}

		// Token: 0x02003DD4 RID: 15828
		[Token(Token = "0x2003DD4")]
		public struct DefaultCharSelectInput : SquadHomeState.ICharSelectInput
		{
			// Token: 0x17003AB1 RID: 15025
			// (get) Token: 0x06018A2A RID: 100906 RVA: 0x0009AFE0 File Offset: 0x000991E0
			// (set) Token: 0x06018A2B RID: 100907 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003AB1")]
			public CharSelectStateBean.Input inputParam
			{
				[Token(Token = "0x6018A2A")]
				[Address(RVA = "0x111C700", Offset = "0x111B300", VA = "0x18111C700", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default(CharSelectStateBean.Input);
				}
				[Token(Token = "0x6018A2B")]
				[Address(RVA = "0x111C730", Offset = "0x111B330", VA = "0x18111C730")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003AB2 RID: 15026
			// (get) Token: 0x06018A2C RID: 100908 RVA: 0x0009AFF8 File Offset: 0x000991F8
			// (set) Token: 0x06018A2D RID: 100909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003AB2")]
			public int squadIndex
			{
				[Token(Token = "0x6018A2C")]
				[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x6018A2D")]
				[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06018A2E RID: 100910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018A2E")]
			[Address(RVA = "0x111C6D0", Offset = "0x111B2D0", VA = "0x18111C6D0")]
			public DefaultCharSelectInput(CharSelectStateBean.Input paramToSelectState, int targetSquadIndex)
			{
			}
		}
	}
}
