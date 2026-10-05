using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Setting;
using UnityEngine;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FE8 RID: 16360
	[Token(Token = "0x2003FE8")]
	public class SettingState : PopupFloatState, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x06019573 RID: 103795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019573")]
		[Address(RVA = "0x1200820", Offset = "0x11FF420", VA = "0x181200820", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019574 RID: 103796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019574")]
		[Address(RVA = "0x1200B50", Offset = "0x11FF750", VA = "0x181200B50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06019575 RID: 103797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019575")]
		[Address(RVA = "0x1200C50", Offset = "0x11FF850", VA = "0x181200C50", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06019576 RID: 103798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019576")]
		[Address(RVA = "0x1200880", Offset = "0x11FF480", VA = "0x181200880", Slot = "33")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06019577 RID: 103799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019577")]
		[Address(RVA = "0x11FFD30", Offset = "0x11FE930", VA = "0x1811FFD30")]
		public void EventOnBtnBackClick()
		{
		}

		// Token: 0x06019578 RID: 103800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019578")]
		[Address(RVA = "0x1200020", Offset = "0x11FEC20", VA = "0x181200020")]
		public void EventOnBtnResetClick()
		{
		}

		// Token: 0x06019579 RID: 103801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019579")]
		[Address(RVA = "0x1200210", Offset = "0x11FEE10", VA = "0x181200210")]
		public void EventOnBtnVideoDownloadClick()
		{
		}

		// Token: 0x0601957A RID: 103802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601957A")]
		[Address(RVA = "0x1200BC0", Offset = "0x11FF7C0", VA = "0x181200BC0")]
		public void OnFullScreenRefresh(SettingConstVars.SettingType type)
		{
		}

		// Token: 0x0601957B RID: 103803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601957B")]
		[Address(RVA = "0x1200480", Offset = "0x11FF080", VA = "0x181200480")]
		public void EventOnBtnVoiceDownloadClick()
		{
		}

		// Token: 0x0601957C RID: 103804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601957C")]
		[Address(RVA = "0x11FFDB0", Offset = "0x11FE9B0", VA = "0x1811FFDB0")]
		public void EventOnBtnDynIllustDownloadClick()
		{
		}

		// Token: 0x0601957D RID: 103805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601957D")]
		[Address(RVA = "0x1200740", Offset = "0x11FF340", VA = "0x181200740")]
		public void EventOnBtnVoiceLangCustomizeClick()
		{
		}

		// Token: 0x0601957E RID: 103806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601957E")]
		[Address(RVA = "0x1201110", Offset = "0x11FFD10", VA = "0x181201110")]
		public void PlayerQuit()
		{
		}

		// Token: 0x0601957F RID: 103807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601957F")]
		[Address(RVA = "0x1202A50", Offset = "0x1201650", VA = "0x181202A50")]
		private void _OnVoiceLangBatchSetClicked(VoiceLangType voiceLang)
		{
		}

		// Token: 0x06019580 RID: 103808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019580")]
		[Address(RVA = "0x12029D0", Offset = "0x12015D0", VA = "0x1812029D0")]
		private void _OnSettingCategoryClicked(SettingCategory category)
		{
		}

		// Token: 0x06019581 RID: 103809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019581")]
		[Address(RVA = "0x1201DF0", Offset = "0x12009F0", VA = "0x181201DF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019582 RID: 103810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019582")]
		[Address(RVA = "0x12014B0", Offset = "0x12000B0", VA = "0x1812014B0")]
		private void _BatchVoiceLangRequest(VoiceLangType langType)
		{
		}

		// Token: 0x06019583 RID: 103811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019583")]
		[Address(RVA = "0x12031E0", Offset = "0x1201DE0", VA = "0x1812031E0")]
		private void _SetDynIllustPartStatus()
		{
		}

		// Token: 0x06019584 RID: 103812 RVA: 0x0009DC80 File Offset: 0x0009BE80
		[Token(Token = "0x6019584")]
		[Address(RVA = "0x1201740", Offset = "0x1200340", VA = "0x181201740")]
		private static bool _CheckIfVoicePrefEnabled(VoiceLangType voiceLangType)
		{
			return default(bool);
		}

		// Token: 0x06019585 RID: 103813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019585")]
		[Address(RVA = "0x1202430", Offset = "0x1201030", VA = "0x181202430")]
		private void _InitPCKeyPanel()
		{
		}

		// Token: 0x06019586 RID: 103814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019586")]
		[Address(RVA = "0x12025C0", Offset = "0x12011C0", VA = "0x1812025C0")]
		private void _OnEnterPCKeyPanel()
		{
		}

		// Token: 0x06019587 RID: 103815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019587")]
		[Address(RVA = "0x1202810", Offset = "0x1201410", VA = "0x181202810")]
		private void _OnPCKeyItemClicked(PCKeySettingSelectedDialog.Input input)
		{
		}

		// Token: 0x06019588 RID: 103816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019588")]
		[Address(RVA = "0x1202910", Offset = "0x1201510", VA = "0x181202910")]
		private void _OnPCKeyTabSwitchClicked(bool isNormal)
		{
		}

		// Token: 0x06019589 RID: 103817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019589")]
		[Address(RVA = "0x12026E0", Offset = "0x12012E0", VA = "0x1812026E0")]
		private void _OnPCKeyBtnDisplayItemClicked(PCKeySettingDisplayBtnView.Output output)
		{
		}

		// Token: 0x0601958A RID: 103818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601958A")]
		[Address(RVA = "0x12030F0", Offset = "0x1201CF0", VA = "0x1812030F0")]
		private void _ResetPCKeySettingToDefault()
		{
		}

		// Token: 0x0601958B RID: 103819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601958B")]
		[Address(RVA = "0x1202EE0", Offset = "0x1201AE0", VA = "0x181202EE0")]
		private void _OpenPCKeySettingSelectedDialog(PCKeySettingSelectedDialog.Input input)
		{
		}

		// Token: 0x0601958C RID: 103820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601958C")]
		[Address(RVA = "0x1202D70", Offset = "0x1201970", VA = "0x181202D70")]
		private void _OpenPCKeySettingConflictDialog(PCKeySettingConflictDialog.Input input)
		{
		}

		// Token: 0x0601958D RID: 103821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601958D")]
		[Address(RVA = "0x1201980", Offset = "0x1200580", VA = "0x181201980")]
		private void _HandleSelectedDialogCallBack(PCKeySettingSelectedDialog.Output dlgOutput)
		{
		}

		// Token: 0x0601958E RID: 103822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601958E")]
		[Address(RVA = "0x1201800", Offset = "0x1200400", VA = "0x181201800")]
		private void _HandleConflictDialogCallBack(bool confirmed, PCKeySettingConflictDialog.Input input)
		{
		}

		// Token: 0x0601958F RID: 103823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601958F")]
		[Address(RVA = "0x12034C0", Offset = "0x12020C0", VA = "0x1812034C0")]
		public SettingState()
		{
		}

		// Token: 0x06019591 RID: 103825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019591")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401F843 RID: 129091
		[Token(Token = "0x401F843")]
		[NonSerialized]
		public const int MSG_ON_ENTER_PC_KEY_PANEL = 0;

		// Token: 0x0401F844 RID: 129092
		[Token(Token = "0x401F844")]
		[NonSerialized]
		public const int MSG_PC_KEY_ITEM_CLICKED = 1;

		// Token: 0x0401F845 RID: 129093
		[Token(Token = "0x401F845")]
		[NonSerialized]
		public const int MSG_PC_KEY_BTN_DISPLAY_ITEM_CLICKED = 2;

		// Token: 0x0401F846 RID: 129094
		[Token(Token = "0x401F846")]
		[NonSerialized]
		public const int MSG_PC_KEY_TAB_SWITCH_CLICKED = 3;

		// Token: 0x0401F847 RID: 129095
		[Token(Token = "0x401F847")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SettingPanel _settingPanel;

		// Token: 0x0401F848 RID: 129096
		[Token(Token = "0x401F848")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _panelAccount;

		// Token: 0x0401F849 RID: 129097
		[Token(Token = "0x401F849")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _panelOthers;

		// Token: 0x0401F84A RID: 129098
		[Token(Token = "0x401F84A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelDynIllustSetting;

		// Token: 0x0401F84B RID: 129099
		[Token(Token = "0x401F84B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelDynIllustRes;

		// Token: 0x0401F84C RID: 129100
		[Token(Token = "0x401F84C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _tabsDynIllustLoadStrategy;

		// Token: 0x0401F84D RID: 129101
		[Token(Token = "0x401F84D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("DynEntrace")]
		private GameObject _panelDynIllustStart;

		// Token: 0x0401F84E RID: 129102
		[Token(Token = "0x401F84E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("DynEntrace")]
		private GameObject _tabsDynEntrance;

		// Token: 0x0401F84F RID: 129103
		[Token(Token = "0x401F84F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("DynEntrace")]
		private GameObject _tabsDynEntranceLoginStrategy;

		// Token: 0x0401F850 RID: 129104
		[Token(Token = "0x401F850")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("DynEntrace")]
		private GameObject _textDynIllustCommonTip;

		// Token: 0x0401F851 RID: 129105
		[Token(Token = "0x401F851")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("DynEntrace")]
		private GameObject _textDynIllustDownloadTip;

		// Token: 0x0401F852 RID: 129106
		[Token(Token = "0x401F852")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("DynEntrace")]
		private GameObject _textDynEntranceCommonTip;

		// Token: 0x0401F853 RID: 129107
		[Token(Token = "0x401F853")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("DynEntrace")]
		private GameObject _textDynEntranceDownloadTip;

		// Token: 0x0401F854 RID: 129108
		[Token(Token = "0x401F854")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("DynEntrace")]
		private GameObject _textDynEntranceLoginCommonTip;

		// Token: 0x0401F855 RID: 129109
		[Token(Token = "0x401F855")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("DynEntrace")]
		private GameObject _textDynEntranceLoginDownloadTip;

		// Token: 0x0401F856 RID: 129110
		[Token(Token = "0x401F856")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private TwoStateToggle _videoDownloadToggle;

		// Token: 0x0401F857 RID: 129111
		[Token(Token = "0x401F857")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TwoStateToggle _voiceDownloadToggle;

		// Token: 0x0401F858 RID: 129112
		[Token(Token = "0x401F858")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private TwoStateToggle _dynIllustDownloadToggle;

		// Token: 0x0401F859 RID: 129113
		[Token(Token = "0x401F859")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private SimpleLayoutContent _voiceLangBatchContainer;

		// Token: 0x0401F85A RID: 129114
		[Token(Token = "0x401F85A")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("PC")]
		private UIFullScreenImage _fullScreenImage;

		// Token: 0x0401F85B RID: 129115
		[Token(Token = "0x401F85B")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("PC")]
		private Transform _panelPCKey;

		// Token: 0x0401F85C RID: 129116
		[Token(Token = "0x401F85C")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("PC")]
		private RectTransform _dialogContainer;

		// Token: 0x0401F85D RID: 129117
		[Token(Token = "0x401F85D")]
		[FieldOffset(Offset = "0x120")]
		private SettingState.VoiceLangAdapter m_voiceLangAdapter;

		// Token: 0x0401F85E RID: 129118
		[Token(Token = "0x401F85E")]
		[FieldOffset(Offset = "0x128")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0401F85F RID: 129119
		[Token(Token = "0x401F85F")]
		[FieldOffset(Offset = "0x130")]
		private PCKeySettingProperty m_pcProperty;

		// Token: 0x0401F860 RID: 129120
		[Token(Token = "0x401F860")]
		[FieldOffset(Offset = "0x138")]
		private int m_pcKeySelectedDlgInst;

		// Token: 0x0401F861 RID: 129121
		[Token(Token = "0x401F861")]
		[FieldOffset(Offset = "0x13C")]
		private int m_pcKeyConflictDlgInst;

		// Token: 0x0401F862 RID: 129122
		[Token(Token = "0x401F862")]
		[FieldOffset(Offset = "0x140")]
		private PCKeySettingSelectedDialog.Input m_nextSelectedDialogInput;

		// Token: 0x0401F863 RID: 129123
		[Token(Token = "0x401F863")]
		[FieldOffset(Offset = "0x148")]
		private bool m_isInited;

		// Token: 0x0401F864 RID: 129124
		[Token(Token = "0x401F864")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401F865 RID: 129125
		[Token(Token = "0x401F865")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401F866 RID: 129126
		[Token(Token = "0x401F866")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401F867 RID: 129127
		[Token(Token = "0x401F867")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0401F868 RID: 129128
		[Token(Token = "0x401F868")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBtnBackClick;

		// Token: 0x0401F869 RID: 129129
		[Token(Token = "0x401F869")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBtnResetClick;

		// Token: 0x0401F86A RID: 129130
		[Token(Token = "0x401F86A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBtnVideoDownloadClick;

		// Token: 0x0401F86B RID: 129131
		[Token(Token = "0x401F86B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnFullScreenRefresh;

		// Token: 0x0401F86C RID: 129132
		[Token(Token = "0x401F86C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnBtnVoiceDownloadClick;

		// Token: 0x0401F86D RID: 129133
		[Token(Token = "0x401F86D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnBtnDynIllustDownloadClick;

		// Token: 0x0401F86E RID: 129134
		[Token(Token = "0x401F86E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnBtnVoiceLangCustomizeClick;

		// Token: 0x0401F86F RID: 129135
		[Token(Token = "0x401F86F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_PlayerQuit;

		// Token: 0x0401F870 RID: 129136
		[Token(Token = "0x401F870")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnVoiceLangBatchSetClicked;

		// Token: 0x0401F871 RID: 129137
		[Token(Token = "0x401F871")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnSettingCategoryClicked;

		// Token: 0x0401F872 RID: 129138
		[Token(Token = "0x401F872")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F873 RID: 129139
		[Token(Token = "0x401F873")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__BatchVoiceLangRequest;

		// Token: 0x0401F874 RID: 129140
		[Token(Token = "0x401F874")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SetDynIllustPartStatus;

		// Token: 0x0401F875 RID: 129141
		[Token(Token = "0x401F875")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckIfVoicePrefEnabled;

		// Token: 0x0401F876 RID: 129142
		[Token(Token = "0x401F876")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InitPCKeyPanel;

		// Token: 0x0401F877 RID: 129143
		[Token(Token = "0x401F877")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnEnterPCKeyPanel;

		// Token: 0x0401F878 RID: 129144
		[Token(Token = "0x401F878")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnPCKeyItemClicked;

		// Token: 0x0401F879 RID: 129145
		[Token(Token = "0x401F879")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnPCKeyTabSwitchClicked;

		// Token: 0x0401F87A RID: 129146
		[Token(Token = "0x401F87A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnPCKeyBtnDisplayItemClicked;

		// Token: 0x0401F87B RID: 129147
		[Token(Token = "0x401F87B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ResetPCKeySettingToDefault;

		// Token: 0x0401F87C RID: 129148
		[Token(Token = "0x401F87C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OpenPCKeySettingSelectedDialog;

		// Token: 0x0401F87D RID: 129149
		[Token(Token = "0x401F87D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OpenPCKeySettingConflictDialog;

		// Token: 0x0401F87E RID: 129150
		[Token(Token = "0x401F87E")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__HandleSelectedDialogCallBack;

		// Token: 0x0401F87F RID: 129151
		[Token(Token = "0x401F87F")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__HandleConflictDialogCallBack;

		// Token: 0x0401F880 RID: 129152
		[Token(Token = "0x401F880")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FE9 RID: 16361
		[Token(Token = "0x2003FE9")]
		private struct VoiceLangBtnConfig
		{
			// Token: 0x0401F881 RID: 129153
			[Token(Token = "0x401F881")]
			[FieldOffset(Offset = "0x0")]
			public VoiceLangType type;
		}

		// Token: 0x02003FEA RID: 16362
		[Token(Token = "0x2003FEA")]
		private class VoiceLangAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06019592 RID: 103826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019592")]
			[Address(RVA = "0x1229A60", Offset = "0x1228660", VA = "0x181229A60")]
			public VoiceLangAdapter(Action<VoiceLangType> onItemClicked)
			{
			}

			// Token: 0x17003C7D RID: 15485
			// (get) Token: 0x06019593 RID: 103827 RVA: 0x0009DC98 File Offset: 0x0009BE98
			[Token(Token = "0x17003C7D")]
			public override int count
			{
				[Token(Token = "0x6019593")]
				[Address(RVA = "0x1229B40", Offset = "0x1228740", VA = "0x181229B40", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019594 RID: 103828 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019594")]
			[Address(RVA = "0x12294C0", Offset = "0x12280C0", VA = "0x1812294C0", Slot = "5")]
			public override GameObject RenderView(int i, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06019595 RID: 103829 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019595")]
			[Address(RVA = "0x1229780", Offset = "0x1228380", VA = "0x181229780")]
			private void _InitItems()
			{
			}

			// Token: 0x06019596 RID: 103830 RVA: 0x0009DCB0 File Offset: 0x0009BEB0
			[Token(Token = "0x6019596")]
			[Address(RVA = "0x1229720", Offset = "0x1228320", VA = "0x181229720")]
			private static VoiceLangType _ConvertToType(VoiceLangType voiceLang)
			{
				return VoiceLangType.NONE;
			}

			// Token: 0x0401F882 RID: 129154
			[Token(Token = "0x401F882")]
			[FieldOffset(Offset = "0x20")]
			private List<SettingState.VoiceLangBtnConfig> m_btnList;

			// Token: 0x0401F883 RID: 129155
			[Token(Token = "0x401F883")]
			[FieldOffset(Offset = "0x28")]
			private Action<VoiceLangType> m_onItemClicked;

			// Token: 0x0401F884 RID: 129156
			[Token(Token = "0x401F884")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F885 RID: 129157
			[Token(Token = "0x401F885")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401F886 RID: 129158
			[Token(Token = "0x401F886")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401F887 RID: 129159
			[Token(Token = "0x401F887")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__InitItems;

			// Token: 0x0401F888 RID: 129160
			[Token(Token = "0x401F888")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__ConvertToType;
		}
	}
}
