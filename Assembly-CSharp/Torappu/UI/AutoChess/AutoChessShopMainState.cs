using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI.TemplateCharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200631C RID: 25372
	[Token(Token = "0x200631C")]
	public class AutoChessShopMainState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06024927 RID: 149799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024927")]
		[Address(RVA = "0x1F704C0", Offset = "0x1F6F0C0", VA = "0x181F704C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06024928 RID: 149800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024928")]
		[Address(RVA = "0x1F70520", Offset = "0x1F6F120", VA = "0x181F70520", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06024929 RID: 149801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024929")]
		[Address(RVA = "0x1F71120", Offset = "0x1F6FD20", VA = "0x181F71120", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602492A RID: 149802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602492A")]
		[Address(RVA = "0x1F70EE0", Offset = "0x1F6FAE0", VA = "0x181F70EE0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602492B RID: 149803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602492B")]
		[Address(RVA = "0x1F75990", Offset = "0x1F74590", VA = "0x181F75990")]
		private void _RegisterFromCommonFriendAssistState(IStateBean stateBean)
		{
		}

		// Token: 0x0602492C RID: 149804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602492C")]
		[Address(RVA = "0x1F76050", Offset = "0x1F74C50", VA = "0x181F76050")]
		private void _RegisterToCommonFriendAssistState(IStateBean stateBean)
		{
		}

		// Token: 0x0602492D RID: 149805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602492D")]
		[Address(RVA = "0x1F75EF0", Offset = "0x1F74AF0", VA = "0x181F75EF0")]
		private void _RegisterToCharSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0602492E RID: 149806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602492E")]
		[Address(RVA = "0x1F75800", Offset = "0x1F74400", VA = "0x181F75800")]
		private void _RegisterFromCharSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0602492F RID: 149807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602492F")]
		[Address(RVA = "0x1F75B80", Offset = "0x1F74780", VA = "0x181F75B80")]
		private void _RegisterFromQuickAssistState(IStateBean stateBean)
		{
		}

		// Token: 0x06024930 RID: 149808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024930")]
		[Address(RVA = "0x1F71920", Offset = "0x1F70520", VA = "0x181F71920")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024931 RID: 149809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024931")]
		[Address(RVA = "0x1F747C0", Offset = "0x1F733C0", VA = "0x181F747C0")]
		private void _OnReturnClick()
		{
		}

		// Token: 0x06024932 RID: 149810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024932")]
		[Address(RVA = "0x1F717C0", Offset = "0x1F703C0", VA = "0x181F717C0")]
		private AutoChessFriendAssistPlugin _GetFriendAssistPlugin()
		{
			return null;
		}

		// Token: 0x06024933 RID: 149811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024933")]
		[Address(RVA = "0x1F76130", Offset = "0x1F74D30", VA = "0x181F76130")]
		private void _SendSetChessPoolDiyCharsRequest(List<TemplateCharSelectCardViewModel> selectList, int chessLv)
		{
		}

		// Token: 0x06024934 RID: 149812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024934")]
		[Address(RVA = "0x1F76790", Offset = "0x1F75390", VA = "0x181F76790")]
		private Dictionary<string, DiyCharDeploy> _TryGetDiyCharDeployInfo(List<TemplateCharSelectCardViewModel> selectList, int chessLv)
		{
			return null;
		}

		// Token: 0x06024935 RID: 149813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024935")]
		[Address(RVA = "0x1F74CC0", Offset = "0x1F738C0", VA = "0x181F74CC0")]
		private void _OnSetChessPoolDiyCharsSuc(AutoChessSetChessPoolDiyCharResponse resp)
		{
		}

		// Token: 0x06024936 RID: 149814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024936")]
		[Address(RVA = "0x1F75640", Offset = "0x1F74240", VA = "0x181F75640")]
		private void _PlayCharVoice(AutoChessShopViewModel viewModel)
		{
		}

		// Token: 0x06024937 RID: 149815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024937")]
		[Address(RVA = "0x1F71400", Offset = "0x1F70000", VA = "0x181F71400")]
		private void _CheckVoiceChar(TemplateCharSelectMainViewModel selectMainViewModel)
		{
		}

		// Token: 0x06024938 RID: 149816 RVA: 0x000C4BF0 File Offset: 0x000C2DF0
		[Token(Token = "0x6024938")]
		[Address(RVA = "0x1F712F0", Offset = "0x1F6FEF0", VA = "0x181F712F0")]
		private bool _AlreadyInSquad(int instId)
		{
			return default(bool);
		}

		// Token: 0x06024939 RID: 149817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024939")]
		[Address(RVA = "0x1F707C0", Offset = "0x1F6F3C0", VA = "0x181F707C0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602493A RID: 149818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602493A")]
		[Address(RVA = "0x1F73A80", Offset = "0x1F72680", VA = "0x181F73A80")]
		private void _OnDiyItemCardClick(string chessId, int chessLv)
		{
		}

		// Token: 0x0602493B RID: 149819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602493B")]
		[Address(RVA = "0x1F72500", Offset = "0x1F71100", VA = "0x181F72500")]
		private void _OnChessCharItemCardClick(string chessId, int chessLv)
		{
		}

		// Token: 0x0602493C RID: 149820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602493C")]
		[Address(RVA = "0x1F722E0", Offset = "0x1F70EE0", VA = "0x181F722E0")]
		private void _OnChessCharItemCardClickInCharList(string chessId, int chessLv, AutoChessShopViewModel viewModel)
		{
		}

		// Token: 0x0602493D RID: 149821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602493D")]
		[Address(RVA = "0x1F720E0", Offset = "0x1F70CE0", VA = "0x181F720E0")]
		private void _OnChessCharItemCardClickInCharDetailList(string chessId, int chessLv, AutoChessShopViewModel viewModel)
		{
		}

		// Token: 0x0602493E RID: 149822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602493E")]
		[Address(RVA = "0x1F71B30", Offset = "0x1F70730", VA = "0x181F71B30")]
		private void _OnChessCharItemCancelClick(string chessId)
		{
		}

		// Token: 0x0602493F RID: 149823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602493F")]
		[Address(RVA = "0x1F71F30", Offset = "0x1F70B30", VA = "0x181F71F30")]
		private void _OnChessCharItemCancelSuc(AutoChessRemoveChessPoolCharResponse response)
		{
		}

		// Token: 0x06024940 RID: 149824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024940")]
		[Address(RVA = "0x1F729B0", Offset = "0x1F715B0", VA = "0x181F729B0")]
		private void _OnChessTrapItemCardClick(string chessId)
		{
		}

		// Token: 0x06024941 RID: 149825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024941")]
		[Address(RVA = "0x1F73DA0", Offset = "0x1F729A0", VA = "0x181F73DA0")]
		private void _OnMenuLevelItemClick(ValueBundle msg)
		{
		}

		// Token: 0x06024942 RID: 149826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024942")]
		[Address(RVA = "0x1F73100", Offset = "0x1F71D00", VA = "0x181F73100")]
		private void _OnConfirmQuickSkillAndModuleClick()
		{
		}

		// Token: 0x06024943 RID: 149827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024943")]
		[Address(RVA = "0x1F72EC0", Offset = "0x1F71AC0", VA = "0x181F72EC0")]
		private void _OnConfirmMultiCharSkillAndModuleSuc(AutoChessSetChessPoolDeployResponse response)
		{
		}

		// Token: 0x06024944 RID: 149828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024944")]
		[Address(RVA = "0x1F72F40", Offset = "0x1F71B40", VA = "0x181F72F40")]
		private void _OnConfirmMultiCharSkillAndModule()
		{
		}

		// Token: 0x06024945 RID: 149829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024945")]
		[Address(RVA = "0x1F74560", Offset = "0x1F73160", VA = "0x181F74560")]
		private void _OnMultiQuickEditCharSkillItemClick(ValueBundle msg)
		{
		}

		// Token: 0x06024946 RID: 149830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024946")]
		[Address(RVA = "0x1F74300", Offset = "0x1F72F00", VA = "0x181F74300")]
		private void _OnMultiQuickEditCharModuleItemClick(ValueBundle msg)
		{
		}

		// Token: 0x06024947 RID: 149831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024947")]
		[Address(RVA = "0x1F72BE0", Offset = "0x1F717E0", VA = "0x181F72BE0")]
		private void _OnConfirmCharDetailClick()
		{
		}

		// Token: 0x06024948 RID: 149832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024948")]
		[Address(RVA = "0x1F73410", Offset = "0x1F72010", VA = "0x181F73410")]
		private void _OnConfirmSingleCharSkillAndModuleSuc(AutoChessSetChessPoolDeployResponse response)
		{
		}

		// Token: 0x06024949 RID: 149833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024949")]
		[Address(RVA = "0x1F74040", Offset = "0x1F72C40", VA = "0x181F74040")]
		private void _OnMenuShopTypeSwitchClick(AutoChessShopStatus toShopStatus)
		{
		}

		// Token: 0x0602494A RID: 149834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602494A")]
		[Address(RVA = "0x1F764E0", Offset = "0x1F750E0", VA = "0x181F764E0")]
		private void _SwitchToCharList()
		{
		}

		// Token: 0x0602494B RID: 149835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602494B")]
		[Address(RVA = "0x1F76660", Offset = "0x1F75260", VA = "0x181F76660")]
		private void _SwitchToTrapList()
		{
		}

		// Token: 0x0602494C RID: 149836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602494C")]
		[Address(RVA = "0x1F750E0", Offset = "0x1F73CE0", VA = "0x181F750E0")]
		private void _OnTopAssistBtnClick()
		{
		}

		// Token: 0x0602494D RID: 149837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602494D")]
		[Address(RVA = "0x1F752C0", Offset = "0x1F73EC0", VA = "0x181F752C0")]
		private void _OnTopQuickSetBtnClick()
		{
		}

		// Token: 0x0602494E RID: 149838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602494E")]
		[Address(RVA = "0x1F754A0", Offset = "0x1F740A0", VA = "0x181F754A0")]
		private void _OnTopSwitchEditToggleClick(AutoChessShopQuickEditType quickEditType)
		{
		}

		// Token: 0x0602494F RID: 149839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602494F")]
		[Address(RVA = "0x1F735C0", Offset = "0x1F721C0", VA = "0x181F735C0")]
		private void _OnDetailAssist()
		{
		}

		// Token: 0x06024950 RID: 149840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024950")]
		[Address(RVA = "0x1F73930", Offset = "0x1F72530", VA = "0x181F73930")]
		private void _OnDetailBack()
		{
		}

		// Token: 0x06024951 RID: 149841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024951")]
		[Address(RVA = "0x1F749E0", Offset = "0x1F735E0", VA = "0x181F749E0")]
		private void _OnSelectEquip(string equipId)
		{
		}

		// Token: 0x06024952 RID: 149842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024952")]
		[Address(RVA = "0x1F74B50", Offset = "0x1F73750", VA = "0x181F74B50")]
		private void _OnSelectSkill(string skillId)
		{
		}

		// Token: 0x06024953 RID: 149843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024953")]
		[Address(RVA = "0x1F75000", Offset = "0x1F73C00", VA = "0x181F75000")]
		private void _OnSwichGold(bool isGold)
		{
		}

		// Token: 0x06024954 RID: 149844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024954")]
		[Address(RVA = "0x1F716D0", Offset = "0x1F702D0", VA = "0x181F716D0")]
		private AutoChessShopViewModel _EnsureDetail()
		{
			return null;
		}

		// Token: 0x06024955 RID: 149845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024955")]
		[Address(RVA = "0x1F76E30", Offset = "0x1F75A30", VA = "0x181F76E30")]
		private void _TryToTriggerGuidebook()
		{
		}

		// Token: 0x06024956 RID: 149846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024956")]
		[Address(RVA = "0x1F76430", Offset = "0x1F75030", VA = "0x181F76430")]
		private void _StopGuidebookCoroutine()
		{
		}

		// Token: 0x06024957 RID: 149847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024957")]
		[Address(RVA = "0x1F77100", Offset = "0x1F75D00", VA = "0x181F77100")]
		private IEnumerator _WaitAndTriggerGuidebook()
		{
			return null;
		}

		// Token: 0x06024958 RID: 149848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024958")]
		[Address(RVA = "0x1F77040", Offset = "0x1F75C40", VA = "0x181F77040")]
		private void _TryTriggerGuidebook([Optional] Story _)
		{
		}

		// Token: 0x06024959 RID: 149849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024959")]
		[Address(RVA = "0x1F771B0", Offset = "0x1F75DB0", VA = "0x181F771B0")]
		public AutoChessShopMainState()
		{
		}

		// Token: 0x0602495A RID: 149850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602495A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602495B RID: 149851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602495B")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602495C RID: 149852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602495C")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0403306D RID: 209005
		[Token(Token = "0x403306D")]
		private const string GUIDEBOOK_SUB_SIGNAL = "shop";

		// Token: 0x0403306E RID: 209006
		[Token(Token = "0x403306E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AutoChessShopMainView _mainView;

		// Token: 0x0403306F RID: 209007
		[Token(Token = "0x403306F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x04033070 RID: 209008
		[Token(Token = "0x4033070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AutoChessShopMainStateBean m_stateBean;

		// Token: 0x04033071 RID: 209009
		[Token(Token = "0x4033071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04033072 RID: 209010
		[Token(Token = "0x4033072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TemplateCharSelectController.InputParam m_inputParamsToCharSelectState;

		// Token: 0x04033073 RID: 209011
		[Token(Token = "0x4033073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ActAutoChessData.ActAutoChessCharShopChessData m_diyCharShopChessDataToCharSelectState;

		// Token: 0x04033074 RID: 209012
		[Token(Token = "0x4033074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string m_needVoiceChar;

		// Token: 0x04033075 RID: 209013
		[Token(Token = "0x4033075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AutoChessFriendAssistPlugin m_friendAssistPlugin;

		// Token: 0x04033076 RID: 209014
		[Token(Token = "0x4033076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AutoChessShopBaseCharListView.FocusInput m_detailCharListFocusInput;

		// Token: 0x04033077 RID: 209015
		[Token(Token = "0x4033077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Coroutine m_guidebookCoroutine;

		// Token: 0x04033078 RID: 209016
		[Token(Token = "0x4033078")]
		[NonSerialized]
		public const int MSG_DIY_ITEM_CARD_CLICK = 0;

		// Token: 0x04033079 RID: 209017
		[Token(Token = "0x4033079")]
		[NonSerialized]
		public const int MSG_CHAR_CHESS_ITEM_CARD_CLICK = 1;

		// Token: 0x0403307A RID: 209018
		[Token(Token = "0x403307A")]
		[NonSerialized]
		public const int MSG_CHAR_CHESS_ITEM_CANCEL_CLICK = 2;

		// Token: 0x0403307B RID: 209019
		[Token(Token = "0x403307B")]
		[NonSerialized]
		public const int MSG_TRAP_CHESS_ITEM_CARD_CLICK = 3;

		// Token: 0x0403307C RID: 209020
		[Token(Token = "0x403307C")]
		[NonSerialized]
		public const int MSG_MENU_LEVEL_ITEM_CLICK = 4;

		// Token: 0x0403307D RID: 209021
		[Token(Token = "0x403307D")]
		[NonSerialized]
		public const int MSG_MENU_CONFIRM_QUICK_SKILL_AND_MODULE_CLICK = 5;

		// Token: 0x0403307E RID: 209022
		[Token(Token = "0x403307E")]
		[NonSerialized]
		public const int MSG_MENU_CONFIRM_CHAR_DETAIL_CLICK = 6;

		// Token: 0x0403307F RID: 209023
		[Token(Token = "0x403307F")]
		[NonSerialized]
		public const int MSG_MENU_SHOP_TYPE_SWITCH_CLICK = 7;

		// Token: 0x04033080 RID: 209024
		[Token(Token = "0x4033080")]
		[NonSerialized]
		public const int MSG_TOP_ASSIST_BTN_CLICK = 8;

		// Token: 0x04033081 RID: 209025
		[Token(Token = "0x4033081")]
		[NonSerialized]
		public const int MSG_TOP_QUICK_SET_CLICK = 9;

		// Token: 0x04033082 RID: 209026
		[Token(Token = "0x4033082")]
		[NonSerialized]
		public const int MSG_TOP_SWITCH_EDIT_TYPE_TOGGLE_CLICK = 10;

		// Token: 0x04033083 RID: 209027
		[Token(Token = "0x4033083")]
		[NonSerialized]
		public const int MSG_DETAIL_SET_GOLD = 11;

		// Token: 0x04033084 RID: 209028
		[Token(Token = "0x4033084")]
		[NonSerialized]
		public const int MSG_DETAIL_SET_SKILL = 12;

		// Token: 0x04033085 RID: 209029
		[Token(Token = "0x4033085")]
		[NonSerialized]
		public const int MSG_DETAIL_SET_BRANCH = 13;

		// Token: 0x04033086 RID: 209030
		[Token(Token = "0x4033086")]
		[NonSerialized]
		public const int MSG_DETAIL_BACK = 14;

		// Token: 0x04033087 RID: 209031
		[Token(Token = "0x4033087")]
		[NonSerialized]
		public const int MSG_DETAIL_ASSIST = 15;

		// Token: 0x04033088 RID: 209032
		[Token(Token = "0x4033088")]
		[NonSerialized]
		public const int MSG_MULTI_QUICK_EDIT_CHAR_SKILL_ITEM_CLICK = 16;

		// Token: 0x04033089 RID: 209033
		[Token(Token = "0x4033089")]
		[NonSerialized]
		public const int MSG_MULTI_QUICK_EDIT_CHAR_MODULE_ITEM_CLICK = 17;

		// Token: 0x0403308A RID: 209034
		[Token(Token = "0x403308A")]
		[NonSerialized]
		public const int MSG_TOP_MENU_RETURN_CLICK = 18;

		// Token: 0x0403308B RID: 209035
		[Token(Token = "0x403308B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403308C RID: 209036
		[Token(Token = "0x403308C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403308D RID: 209037
		[Token(Token = "0x403308D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403308E RID: 209038
		[Token(Token = "0x403308E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0403308F RID: 209039
		[Token(Token = "0x403308F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterFromCommonFriendAssistState;

		// Token: 0x04033090 RID: 209040
		[Token(Token = "0x4033090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RegisterToCommonFriendAssistState;

		// Token: 0x04033091 RID: 209041
		[Token(Token = "0x4033091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RegisterToCharSelectState;

		// Token: 0x04033092 RID: 209042
		[Token(Token = "0x4033092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RegisterFromCharSelectState;

		// Token: 0x04033093 RID: 209043
		[Token(Token = "0x4033093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RegisterFromQuickAssistState;

		// Token: 0x04033094 RID: 209044
		[Token(Token = "0x4033094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033095 RID: 209045
		[Token(Token = "0x4033095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnReturnClick;

		// Token: 0x04033096 RID: 209046
		[Token(Token = "0x4033096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetFriendAssistPlugin;

		// Token: 0x04033097 RID: 209047
		[Token(Token = "0x4033097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SendSetChessPoolDiyCharsRequest;

		// Token: 0x04033098 RID: 209048
		[Token(Token = "0x4033098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryGetDiyCharDeployInfo;

		// Token: 0x04033099 RID: 209049
		[Token(Token = "0x4033099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnSetChessPoolDiyCharsSuc;

		// Token: 0x0403309A RID: 209050
		[Token(Token = "0x403309A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__PlayCharVoice;

		// Token: 0x0403309B RID: 209051
		[Token(Token = "0x403309B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CheckVoiceChar;

		// Token: 0x0403309C RID: 209052
		[Token(Token = "0x403309C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__AlreadyInSquad;

		// Token: 0x0403309D RID: 209053
		[Token(Token = "0x403309D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403309E RID: 209054
		[Token(Token = "0x403309E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnDiyItemCardClick;

		// Token: 0x0403309F RID: 209055
		[Token(Token = "0x403309F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnChessCharItemCardClick;

		// Token: 0x040330A0 RID: 209056
		[Token(Token = "0x40330A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnChessCharItemCardClickInCharList;

		// Token: 0x040330A1 RID: 209057
		[Token(Token = "0x40330A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnChessCharItemCardClickInCharDetailList;

		// Token: 0x040330A2 RID: 209058
		[Token(Token = "0x40330A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnChessCharItemCancelClick;

		// Token: 0x040330A3 RID: 209059
		[Token(Token = "0x40330A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnChessCharItemCancelSuc;

		// Token: 0x040330A4 RID: 209060
		[Token(Token = "0x40330A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnChessTrapItemCardClick;

		// Token: 0x040330A5 RID: 209061
		[Token(Token = "0x40330A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnMenuLevelItemClick;

		// Token: 0x040330A6 RID: 209062
		[Token(Token = "0x40330A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnConfirmQuickSkillAndModuleClick;

		// Token: 0x040330A7 RID: 209063
		[Token(Token = "0x40330A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnConfirmMultiCharSkillAndModuleSuc;

		// Token: 0x040330A8 RID: 209064
		[Token(Token = "0x40330A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnConfirmMultiCharSkillAndModule;

		// Token: 0x040330A9 RID: 209065
		[Token(Token = "0x40330A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnMultiQuickEditCharSkillItemClick;

		// Token: 0x040330AA RID: 209066
		[Token(Token = "0x40330AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OnMultiQuickEditCharModuleItemClick;

		// Token: 0x040330AB RID: 209067
		[Token(Token = "0x40330AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__OnConfirmCharDetailClick;

		// Token: 0x040330AC RID: 209068
		[Token(Token = "0x40330AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnConfirmSingleCharSkillAndModuleSuc;

		// Token: 0x040330AD RID: 209069
		[Token(Token = "0x40330AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__OnMenuShopTypeSwitchClick;

		// Token: 0x040330AE RID: 209070
		[Token(Token = "0x40330AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__SwitchToCharList;

		// Token: 0x040330AF RID: 209071
		[Token(Token = "0x40330AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__SwitchToTrapList;

		// Token: 0x040330B0 RID: 209072
		[Token(Token = "0x40330B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__OnTopAssistBtnClick;

		// Token: 0x040330B1 RID: 209073
		[Token(Token = "0x40330B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__OnTopQuickSetBtnClick;

		// Token: 0x040330B2 RID: 209074
		[Token(Token = "0x40330B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__OnTopSwitchEditToggleClick;

		// Token: 0x040330B3 RID: 209075
		[Token(Token = "0x40330B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__OnDetailAssist;

		// Token: 0x040330B4 RID: 209076
		[Token(Token = "0x40330B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__OnDetailBack;

		// Token: 0x040330B5 RID: 209077
		[Token(Token = "0x40330B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__OnSelectEquip;

		// Token: 0x040330B6 RID: 209078
		[Token(Token = "0x40330B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__OnSelectSkill;

		// Token: 0x040330B7 RID: 209079
		[Token(Token = "0x40330B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__OnSwichGold;

		// Token: 0x040330B8 RID: 209080
		[Token(Token = "0x40330B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__EnsureDetail;

		// Token: 0x040330B9 RID: 209081
		[Token(Token = "0x40330B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__TryToTriggerGuidebook;

		// Token: 0x040330BA RID: 209082
		[Token(Token = "0x40330BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__StopGuidebookCoroutine;

		// Token: 0x040330BB RID: 209083
		[Token(Token = "0x40330BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__WaitAndTriggerGuidebook;

		// Token: 0x040330BC RID: 209084
		[Token(Token = "0x40330BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__TryTriggerGuidebook;

		// Token: 0x040330BD RID: 209085
		[Token(Token = "0x40330BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
