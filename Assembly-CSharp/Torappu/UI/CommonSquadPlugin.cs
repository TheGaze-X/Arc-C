using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.UI;
using Torappu.CharWord;
using Torappu.Scripts.UI.Squad;
using Torappu.UI.BattleFinish;
using Torappu.UI.Squad;
using Torappu.UI.TemplateCharSelect;
using Torappu.UI.TemplateCharSelect.Common;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035E0 RID: 13792
	[Token(Token = "0x20035E0")]
	public abstract class CommonSquadPlugin<TChar> : ICommonSquadPlugin, IHotfixable where TChar : class, ICommonSquadChar, new()
	{
		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x06015F2D RID: 89901 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015F2E RID: 89902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170034C4")]
		public ICommonSquadMsgReceiver msgReceiver
		{
			[Token(Token = "0x6015F2D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015F2E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06015F2F RID: 89903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F2F")]
		public virtual ICustomSquadGroupViewModel GetCustomViewModel()
		{
			return null;
		}

		// Token: 0x06015F30 RID: 89904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F30")]
		public virtual CommonSquadGroupConstrainPolicy GetCustomSquadGroupConstrainPolicy(CommonSquadStateBean stateBean)
		{
			return null;
		}

		// Token: 0x06015F31 RID: 89905 RVA: 0x0008ED10 File Offset: 0x0008CF10
		[Token(Token = "0x6015F31")]
		public virtual bool HandleMsg(int key, ValueBundle msg, UICompDialogMgr dlgMgr)
		{
			return default(bool);
		}

		// Token: 0x06015F32 RID: 89906 RVA: 0x0008ED28 File Offset: 0x0008CF28
		[Token(Token = "0x6015F32")]
		public bool HandleDialogCallback(int instId, ValueBundle output)
		{
			return default(bool);
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x06015F33 RID: 89907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034C5")]
		public virtual Dictionary<Type, Action<IStateBean>> toDataListenerActions
		{
			[Token(Token = "0x6015F33")]
			get
			{
				return null;
			}
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x06015F34 RID: 89908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034C6")]
		public virtual Dictionary<Type, Action<IStateBean>> fromDataListenerActions
		{
			[Token(Token = "0x6015F34")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015F35 RID: 89909 RVA: 0x0008ED40 File Offset: 0x0008CF40
		[Token(Token = "0x6015F35")]
		public virtual bool CheckIsCanStartBattle(out string toast)
		{
			return default(bool);
		}

		// Token: 0x06015F36 RID: 89910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F36")]
		public virtual IStartBattleServiceConfig GetStartBattleServiceConfig(CommonStartBattleRequest.SquadModel squadModel, SquadFriendData assistFriend)
		{
			return null;
		}

		// Token: 0x06015F37 RID: 89911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F37")]
		public virtual IFinishBattleServiceConfig GetFinishBattleServiceConfig()
		{
			return null;
		}

		// Token: 0x06015F38 RID: 89912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F38")]
		public virtual CommonStartBattleRequest.SquadModel ParseBattleStartRequestSquad()
		{
			return null;
		}

		// Token: 0x06015F39 RID: 89913 RVA: 0x0008ED58 File Offset: 0x0008CF58
		[Token(Token = "0x6015F39")]
		public virtual bool GetIsSkipBattleFinishWhenFailed()
		{
			return default(bool);
		}

		// Token: 0x06015F3A RID: 89914 RVA: 0x0008ED70 File Offset: 0x0008CF70
		[Token(Token = "0x6015F3A")]
		public virtual bool GetIsOverrideBattleFinishBGM()
		{
			return default(bool);
		}

		// Token: 0x06015F3B RID: 89915 RVA: 0x0008ED88 File Offset: 0x0008CF88
		[Token(Token = "0x6015F3B")]
		public virtual bool GetIsUploadBattleLog()
		{
			return default(bool);
		}

		// Token: 0x06015F3C RID: 89916 RVA: 0x0008EDA0 File Offset: 0x0008CFA0
		[Token(Token = "0x6015F3C")]
		public virtual GameModeMeta GetGameModeMeta()
		{
			return default(GameModeMeta);
		}

		// Token: 0x06015F3D RID: 89917 RVA: 0x0008EDB8 File Offset: 0x0008CFB8
		[Token(Token = "0x6015F3D")]
		public virtual GameTagMeta GetGameTagMeta()
		{
			return default(GameTagMeta);
		}

		// Token: 0x06015F3E RID: 89918 RVA: 0x0008EDD0 File Offset: 0x0008CFD0
		[Token(Token = "0x6015F3E")]
		public virtual BattleSysMenuStyle GetBattleSysMenuStyle()
		{
			return BattleSysMenuStyle.DEFAULT;
		}

		// Token: 0x06015F3F RID: 89919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F3F")]
		public virtual BattleFinishIndexState.IPlugin GetBattleFinishIndexPlugin()
		{
			return null;
		}

		// Token: 0x06015F40 RID: 89920 RVA: 0x0008EDE8 File Offset: 0x0008CFE8
		[Token(Token = "0x6015F40")]
		public virtual bool AdditionalCheckIfAssistCharValidInCharSelectState(CharQuery charQuery, ref SquadFriendListItem.LockedStyle lockStyleConfig)
		{
			return default(bool);
		}

		// Token: 0x06015F41 RID: 89921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F41")]
		public virtual void ApplySquadFromCharSelectSingleMode(TemplateCharSelectCardViewModel target, int singleTargetInstId)
		{
		}

		// Token: 0x06015F42 RID: 89922
		[Token(Token = "0x6015F42")]
		protected abstract TChar GetCharViewModelFromCharSelect(TemplateCharSelectCardViewModel selectChar);

		// Token: 0x06015F43 RID: 89923 RVA: 0x0008EE00 File Offset: 0x0008D000
		[Token(Token = "0x6015F43")]
		protected virtual bool CheckIfNeedPlayCharVoiceFromSingleSelect(ICommonSquadChar replacedMember, TemplateCharSelectCardViewModel targetChar)
		{
			return default(bool);
		}

		// Token: 0x06015F44 RID: 89924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F44")]
		public virtual void ApplySquadFromCharSelectMultiMode(List<CommonCharSelectCardDefaultViewModel> selectedList)
		{
		}

		// Token: 0x06015F45 RID: 89925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F45")]
		public virtual List<TemplateCharSelectCharInputData> GenCharSelectInputDataList(CommonSquadHomeState.SelectCharParam selectCharParam)
		{
			return null;
		}

		// Token: 0x06015F46 RID: 89926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F46")]
		public virtual Action<TemplateCharSelectController.InputParam> GetCharSelectMultiSelectOnFull(CommonSquadHomeState.SelectCharParam selectCharParam)
		{
			return null;
		}

		// Token: 0x06015F47 RID: 89927 RVA: 0x0008EE18 File Offset: 0x0008D018
		[Token(Token = "0x6015F47")]
		public virtual bool GetCharSelectNeedScroll(CommonSquadHomeState.SelectCharParam selectCharParam)
		{
			return default(bool);
		}

		// Token: 0x06015F48 RID: 89928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F48")]
		public virtual TemplateCharSelectController.TemplateCustomInput GetCharSelectCustomInput(CommonSquadHomeState.SelectCharParam selectCharParam)
		{
			return null;
		}

		// Token: 0x06015F49 RID: 89929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F49")]
		protected virtual CommonSquadToCharSelectInputData GenCharSelectInputData(TChar cardViewModel)
		{
			return null;
		}

		// Token: 0x06015F4A RID: 89930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F4A")]
		public TemplateCharSelectCardViewModelCreator GetCreateCharSelectCardViewModelFunc()
		{
			return null;
		}

		// Token: 0x06015F4B RID: 89931
		[Token(Token = "0x6015F4B")]
		protected abstract TemplateCharSelectCardViewModel CreateCharSelectCardViewModel(int instId, TemplateCharSelectCharInputData inputNullable, [Optional] PlayerCharacter playerData);

		// Token: 0x06015F4C RID: 89932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F4C")]
		private Queue<ICommonSquadChar> _GetAvailCharQueue(List<CommonCharSelectCardDefaultViewModel> selectedList, CommonSquadSingleSquadViewModel squad)
		{
			return null;
		}

		// Token: 0x06015F4D RID: 89933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F4D")]
		private ICommonSquadChar[] _GetNewMembers(Queue<ICommonSquadChar> availSelectedChars, CommonSquadSingleSquadViewModel squad)
		{
			return null;
		}

		// Token: 0x06015F4E RID: 89934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F4E")]
		protected List<VoiceQuery> GetVoiceQueriesFromSelectList(List<CommonCharSelectCardDefaultViewModel> selectedList)
		{
			return null;
		}

		// Token: 0x06015F4F RID: 89935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F4F")]
		protected List<VoiceQuery> GetVoiceQueriesFromSquad(CommonSquadSingleSquadViewModel squad)
		{
			return null;
		}

		// Token: 0x06015F50 RID: 89936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F50")]
		public void TryRestrictTargetSquadMembers(CommonSquadSingleSquadViewModel targetSquad)
		{
		}

		// Token: 0x06015F51 RID: 89937
		[Token(Token = "0x6015F51")]
		public abstract List<CommonSquadSingleSquadViewModel> LoadSquadCache();

		// Token: 0x06015F52 RID: 89938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F52")]
		public virtual void SaveSquadCache()
		{
		}

		// Token: 0x06015F53 RID: 89939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F53")]
		public virtual void UpdateData()
		{
		}

		// Token: 0x06015F54 RID: 89940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F54")]
		protected virtual void UpdateMemberStatus(CommonSquadGroupViewModel squadGroupViewModel)
		{
		}

		// Token: 0x06015F55 RID: 89941 RVA: 0x0008EE30 File Offset: 0x0008D030
		[Token(Token = "0x6015F55")]
		public virtual SquadMaxNumInfo GetActivitySquadMaxNumInfo()
		{
			return default(SquadMaxNumInfo);
		}

		// Token: 0x06015F56 RID: 89942 RVA: 0x0008EE48 File Offset: 0x0008D048
		[Token(Token = "0x6015F56")]
		public virtual SquadMaxNumInfo GetSquadMaxRawNumInfo()
		{
			return default(SquadMaxNumInfo);
		}

		// Token: 0x06015F57 RID: 89943 RVA: 0x0008EE60 File Offset: 0x0008D060
		[Token(Token = "0x6015F57")]
		public int GetSquadMaxCharCount()
		{
			return 0;
		}

		// Token: 0x06015F58 RID: 89944 RVA: 0x0008EE78 File Offset: 0x0008D078
		[Token(Token = "0x6015F58")]
		public virtual int GetMaxAssistCount()
		{
			return 0;
		}

		// Token: 0x06015F59 RID: 89945 RVA: 0x0008EE90 File Offset: 0x0008D090
		[Token(Token = "0x6015F59")]
		protected virtual bool GetIsSlotMaxIncludeAssistCount()
		{
			return default(bool);
		}

		// Token: 0x06015F5A RID: 89946 RVA: 0x0008EEA8 File Offset: 0x0008D0A8
		[Token(Token = "0x6015F5A")]
		protected virtual int GetStageSlotMax(string stageId)
		{
			return 0;
		}

		// Token: 0x06015F5B RID: 89947 RVA: 0x0008EEC0 File Offset: 0x0008D0C0
		[Token(Token = "0x6015F5B")]
		public ProfessionCategory GetAssistProfessionCategory()
		{
			return ProfessionCategory.NONE;
		}

		// Token: 0x06015F5C RID: 89948 RVA: 0x0008EED8 File Offset: 0x0008D0D8
		[Token(Token = "0x6015F5C")]
		public virtual bool GetIfCharSelectStateSynCharWithPlayerData(CommonSquadHomeState.SelectCharParam selectCharParam)
		{
			return default(bool);
		}

		// Token: 0x06015F5D RID: 89949 RVA: 0x0008EEF0 File Offset: 0x0008D0F0
		[Token(Token = "0x6015F5D")]
		public virtual bool GetIfCharSelectStateHasTopMenuInState(CommonSquadHomeState.SelectCharParam selectCharParam)
		{
			return default(bool);
		}

		// Token: 0x06015F5E RID: 89950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F5E")]
		protected virtual void PassDataToFriendAssist(IStateBean stateBean)
		{
		}

		// Token: 0x06015F5F RID: 89951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F5F")]
		protected virtual void ApplyToFriendAssistBean(SquadFriendAssistStateBean assistBean)
		{
		}

		// Token: 0x06015F60 RID: 89952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F60")]
		protected virtual void OnAssistSelectFinished(IStateBean stateBean)
		{
		}

		// Token: 0x06015F61 RID: 89953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F61")]
		protected virtual void PassDataToCharSelect(IStateBean stateBean)
		{
		}

		// Token: 0x06015F62 RID: 89954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F62")]
		protected virtual void OnCharSelectFinished(IStateBean stateBean)
		{
		}

		// Token: 0x06015F63 RID: 89955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F63")]
		protected virtual void ApplySquadFromCharSelect(CommonCharSelectStateBean selectStateBean)
		{
		}

		// Token: 0x06015F64 RID: 89956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F64")]
		protected CommonSquadPlugin()
		{
		}

		// Token: 0x0401A623 RID: 108067
		[Token(Token = "0x401A623")]
		protected const int FIRST_SQUAD_FROM_TROOP_INDEX = 0;

		// Token: 0x0401A625 RID: 108069
		[Token(Token = "0x401A625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_msgReceiver;

		// Token: 0x0401A626 RID: 108070
		[Token(Token = "0x401A626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_msgReceiver;

		// Token: 0x0401A627 RID: 108071
		[Token(Token = "0x401A627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCustomViewModel;

		// Token: 0x0401A628 RID: 108072
		[Token(Token = "0x401A628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCustomSquadGroupConstrainPolicy;

		// Token: 0x0401A629 RID: 108073
		[Token(Token = "0x401A629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMsg;

		// Token: 0x0401A62A RID: 108074
		[Token(Token = "0x401A62A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleDialogCallback;

		// Token: 0x0401A62B RID: 108075
		[Token(Token = "0x401A62B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_toDataListenerActions;

		// Token: 0x0401A62C RID: 108076
		[Token(Token = "0x401A62C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fromDataListenerActions;

		// Token: 0x0401A62D RID: 108077
		[Token(Token = "0x401A62D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIsCanStartBattle;

		// Token: 0x0401A62E RID: 108078
		[Token(Token = "0x401A62E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetStartBattleServiceConfig;

		// Token: 0x0401A62F RID: 108079
		[Token(Token = "0x401A62F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFinishBattleServiceConfig;

		// Token: 0x0401A630 RID: 108080
		[Token(Token = "0x401A630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ParseBattleStartRequestSquad;

		// Token: 0x0401A631 RID: 108081
		[Token(Token = "0x401A631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetIsSkipBattleFinishWhenFailed;

		// Token: 0x0401A632 RID: 108082
		[Token(Token = "0x401A632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetIsOverrideBattleFinishBGM;

		// Token: 0x0401A633 RID: 108083
		[Token(Token = "0x401A633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetIsUploadBattleLog;

		// Token: 0x0401A634 RID: 108084
		[Token(Token = "0x401A634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetGameModeMeta;

		// Token: 0x0401A635 RID: 108085
		[Token(Token = "0x401A635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetGameTagMeta;

		// Token: 0x0401A636 RID: 108086
		[Token(Token = "0x401A636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBattleSysMenuStyle;

		// Token: 0x0401A637 RID: 108087
		[Token(Token = "0x401A637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBattleFinishIndexPlugin;

		// Token: 0x0401A638 RID: 108088
		[Token(Token = "0x401A638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AdditionalCheckIfAssistCharValidInCharSelectState;

		// Token: 0x0401A639 RID: 108089
		[Token(Token = "0x401A639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplySquadFromCharSelectSingleMode;

		// Token: 0x0401A63A RID: 108090
		[Token(Token = "0x401A63A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfNeedPlayCharVoiceFromSingleSelect;

		// Token: 0x0401A63B RID: 108091
		[Token(Token = "0x401A63B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplySquadFromCharSelectMultiMode;

		// Token: 0x0401A63C RID: 108092
		[Token(Token = "0x401A63C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenCharSelectInputDataList;

		// Token: 0x0401A63D RID: 108093
		[Token(Token = "0x401A63D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCharSelectMultiSelectOnFull;

		// Token: 0x0401A63E RID: 108094
		[Token(Token = "0x401A63E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCharSelectNeedScroll;

		// Token: 0x0401A63F RID: 108095
		[Token(Token = "0x401A63F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCharSelectCustomInput;

		// Token: 0x0401A640 RID: 108096
		[Token(Token = "0x401A640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenCharSelectInputData;

		// Token: 0x0401A641 RID: 108097
		[Token(Token = "0x401A641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCreateCharSelectCardViewModelFunc;

		// Token: 0x0401A642 RID: 108098
		[Token(Token = "0x401A642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetAvailCharQueue;

		// Token: 0x0401A643 RID: 108099
		[Token(Token = "0x401A643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetNewMembers;

		// Token: 0x0401A644 RID: 108100
		[Token(Token = "0x401A644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetVoiceQueriesFromSelectList;

		// Token: 0x0401A645 RID: 108101
		[Token(Token = "0x401A645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetVoiceQueriesFromSquad;

		// Token: 0x0401A646 RID: 108102
		[Token(Token = "0x401A646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryRestrictTargetSquadMembers;

		// Token: 0x0401A647 RID: 108103
		[Token(Token = "0x401A647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SaveSquadCache;

		// Token: 0x0401A648 RID: 108104
		[Token(Token = "0x401A648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401A649 RID: 108105
		[Token(Token = "0x401A649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateMemberStatus;

		// Token: 0x0401A64A RID: 108106
		[Token(Token = "0x401A64A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetActivitySquadMaxNumInfo;

		// Token: 0x0401A64B RID: 108107
		[Token(Token = "0x401A64B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSquadMaxRawNumInfo;

		// Token: 0x0401A64C RID: 108108
		[Token(Token = "0x401A64C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSquadMaxCharCount;

		// Token: 0x0401A64D RID: 108109
		[Token(Token = "0x401A64D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMaxAssistCount;

		// Token: 0x0401A64E RID: 108110
		[Token(Token = "0x401A64E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetIsSlotMaxIncludeAssistCount;

		// Token: 0x0401A64F RID: 108111
		[Token(Token = "0x401A64F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetStageSlotMax;

		// Token: 0x0401A650 RID: 108112
		[Token(Token = "0x401A650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssistProfessionCategory;

		// Token: 0x0401A651 RID: 108113
		[Token(Token = "0x401A651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetIfCharSelectStateSynCharWithPlayerData;

		// Token: 0x0401A652 RID: 108114
		[Token(Token = "0x401A652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetIfCharSelectStateHasTopMenuInState;

		// Token: 0x0401A653 RID: 108115
		[Token(Token = "0x401A653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PassDataToFriendAssist;

		// Token: 0x0401A654 RID: 108116
		[Token(Token = "0x401A654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyToFriendAssistBean;

		// Token: 0x0401A655 RID: 108117
		[Token(Token = "0x401A655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAssistSelectFinished;

		// Token: 0x0401A656 RID: 108118
		[Token(Token = "0x401A656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PassDataToCharSelect;

		// Token: 0x0401A657 RID: 108119
		[Token(Token = "0x401A657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCharSelectFinished;

		// Token: 0x0401A658 RID: 108120
		[Token(Token = "0x401A658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplySquadFromCharSelect;

		// Token: 0x0401A659 RID: 108121
		[Token(Token = "0x401A659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
