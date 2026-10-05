using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.UI;
using Torappu.Scripts.UI.Squad;
using Torappu.UI.BattleFinish;
using Torappu.UI.Squad;
using Torappu.UI.TemplateCharSelect;

namespace Torappu.UI
{
	// Token: 0x020035E1 RID: 13793
	[Token(Token = "0x20035E1")]
	public interface ICommonSquadPlugin : IHotfixable
	{
		// Token: 0x06015F65 RID: 89957
		[Token(Token = "0x6015F65")]
		ICustomSquadGroupViewModel GetCustomViewModel();

		// Token: 0x06015F66 RID: 89958
		[Token(Token = "0x6015F66")]
		List<CommonSquadSingleSquadViewModel> LoadSquadCache();

		// Token: 0x06015F67 RID: 89959
		[Token(Token = "0x6015F67")]
		void SaveSquadCache();

		// Token: 0x06015F68 RID: 89960
		[Token(Token = "0x6015F68")]
		void UpdateData();

		// Token: 0x06015F69 RID: 89961
		[Token(Token = "0x6015F69")]
		SquadMaxNumInfo GetActivitySquadMaxNumInfo();

		// Token: 0x06015F6A RID: 89962
		[Token(Token = "0x6015F6A")]
		SquadMaxNumInfo GetSquadMaxRawNumInfo();

		// Token: 0x06015F6B RID: 89963
		[Token(Token = "0x6015F6B")]
		int GetSquadMaxCharCount();

		// Token: 0x06015F6C RID: 89964
		[Token(Token = "0x6015F6C")]
		CommonSquadGroupConstrainPolicy GetCustomSquadGroupConstrainPolicy(CommonSquadStateBean stateBean);

		// Token: 0x06015F6D RID: 89965
		[Token(Token = "0x6015F6D")]
		bool AdditionalCheckIfAssistCharValidInCharSelectState(CharQuery charQuery, ref SquadFriendListItem.LockedStyle lockStyleConfig);

		// Token: 0x06015F6E RID: 89966
		[Token(Token = "0x6015F6E")]
		int GetMaxAssistCount();

		// Token: 0x06015F6F RID: 89967
		[Token(Token = "0x6015F6F")]
		ProfessionCategory GetAssistProfessionCategory();

		// Token: 0x06015F70 RID: 89968
		[Token(Token = "0x6015F70")]
		bool GetIfCharSelectStateSynCharWithPlayerData(CommonSquadHomeState.SelectCharParam selectCharParam);

		// Token: 0x06015F71 RID: 89969
		[Token(Token = "0x6015F71")]
		bool GetIfCharSelectStateHasTopMenuInState(CommonSquadHomeState.SelectCharParam selectCharParam);

		// Token: 0x06015F72 RID: 89970
		[Token(Token = "0x6015F72")]
		Action<TemplateCharSelectController.InputParam> GetCharSelectMultiSelectOnFull(CommonSquadHomeState.SelectCharParam selectCharParam);

		// Token: 0x06015F73 RID: 89971
		[Token(Token = "0x6015F73")]
		bool GetCharSelectNeedScroll(CommonSquadHomeState.SelectCharParam selectCharParam);

		// Token: 0x06015F74 RID: 89972
		[Token(Token = "0x6015F74")]
		TemplateCharSelectController.TemplateCustomInput GetCharSelectCustomInput(CommonSquadHomeState.SelectCharParam selectCharParam);

		// Token: 0x06015F75 RID: 89973
		[Token(Token = "0x6015F75")]
		List<TemplateCharSelectCharInputData> GenCharSelectInputDataList(CommonSquadHomeState.SelectCharParam selectCharParam);

		// Token: 0x06015F76 RID: 89974
		[Token(Token = "0x6015F76")]
		TemplateCharSelectCardViewModelCreator GetCreateCharSelectCardViewModelFunc();

		// Token: 0x06015F77 RID: 89975
		[Token(Token = "0x6015F77")]
		void TryRestrictTargetSquadMembers(CommonSquadSingleSquadViewModel targetSquad);

		// Token: 0x06015F78 RID: 89976
		[Token(Token = "0x6015F78")]
		bool CheckIsCanStartBattle(out string toast);

		// Token: 0x06015F79 RID: 89977
		[Token(Token = "0x6015F79")]
		IStartBattleServiceConfig GetStartBattleServiceConfig(CommonStartBattleRequest.SquadModel squadModel, SquadFriendData assistFriend);

		// Token: 0x06015F7A RID: 89978
		[Token(Token = "0x6015F7A")]
		IFinishBattleServiceConfig GetFinishBattleServiceConfig();

		// Token: 0x06015F7B RID: 89979
		[Token(Token = "0x6015F7B")]
		CommonStartBattleRequest.SquadModel ParseBattleStartRequestSquad();

		// Token: 0x06015F7C RID: 89980
		[Token(Token = "0x6015F7C")]
		bool GetIsSkipBattleFinishWhenFailed();

		// Token: 0x06015F7D RID: 89981
		[Token(Token = "0x6015F7D")]
		bool GetIsOverrideBattleFinishBGM();

		// Token: 0x06015F7E RID: 89982
		[Token(Token = "0x6015F7E")]
		bool GetIsUploadBattleLog();

		// Token: 0x06015F7F RID: 89983
		[Token(Token = "0x6015F7F")]
		GameModeMeta GetGameModeMeta();

		// Token: 0x06015F80 RID: 89984
		[Token(Token = "0x6015F80")]
		GameTagMeta GetGameTagMeta();

		// Token: 0x06015F81 RID: 89985
		[Token(Token = "0x6015F81")]
		BattleSysMenuStyle GetBattleSysMenuStyle();

		// Token: 0x06015F82 RID: 89986
		[Token(Token = "0x6015F82")]
		BattleFinishIndexState.IPlugin GetBattleFinishIndexPlugin();

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x06015F83 RID: 89987
		// (set) Token: 0x06015F84 RID: 89988
		[Token(Token = "0x170034C7")]
		ICommonSquadMsgReceiver msgReceiver { [Token(Token = "0x6015F83")] get; [Token(Token = "0x6015F84")] set; }

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x06015F85 RID: 89989
		[Token(Token = "0x170034C8")]
		Dictionary<Type, Action<IStateBean>> toDataListenerActions { [Token(Token = "0x6015F85")] get; }

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x06015F86 RID: 89990
		[Token(Token = "0x170034C9")]
		Dictionary<Type, Action<IStateBean>> fromDataListenerActions { [Token(Token = "0x6015F86")] get; }

		// Token: 0x06015F87 RID: 89991
		[Token(Token = "0x6015F87")]
		bool HandleMsg(int key, ValueBundle msg, UICompDialogMgr dlgMgr);

		// Token: 0x06015F88 RID: 89992
		[Token(Token = "0x6015F88")]
		bool HandleDialogCallback(int instId, ValueBundle output);
	}
}
