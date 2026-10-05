using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using Torappu.UI.Squad;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200619E RID: 24990
	[Token(Token = "0x200619E")]
	public class BossRushSquadHomeState : State, IRuneSquadController, ISquadCharSelectContext
	{
		// Token: 0x060240C4 RID: 147652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60240C4")]
		[Address(RVA = "0x1EB7E10", Offset = "0x1EB6A10", VA = "0x181EB7E10", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060240C5 RID: 147653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240C5")]
		[Address(RVA = "0x1EB7F90", Offset = "0x1EB6B90", VA = "0x181EB7F90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060240C6 RID: 147654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240C6")]
		[Address(RVA = "0x1EB8560", Offset = "0x1EB7160", VA = "0x181EB8560", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060240C7 RID: 147655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60240C7")]
		[Address(RVA = "0x1EB8980", Offset = "0x1EB7580", VA = "0x181EB8980", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060240C8 RID: 147656 RVA: 0x000C2DF0 File Offset: 0x000C0FF0
		[Token(Token = "0x60240C8")]
		[Address(RVA = "0x1EB8C30", Offset = "0x1EB7830", VA = "0x181EB8C30", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x060240C9 RID: 147657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60240C9")]
		[Address(RVA = "0x1EB87B0", Offset = "0x1EB73B0", VA = "0x181EB87B0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x060240CA RID: 147658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60240CA")]
		[Address(RVA = "0x1EB7F30", Offset = "0x1EB6B30", VA = "0x181EB7F30", Slot = "24")]
		public List<int> GetTempListForExclusiveInstIds()
		{
			return null;
		}

		// Token: 0x060240CB RID: 147659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60240CB")]
		[Address(RVA = "0x1EB7E70", Offset = "0x1EB6A70", VA = "0x181EB7E70", Slot = "25")]
		public SquadGroupViewModel GetSquadGroupViewModel()
		{
			return null;
		}

		// Token: 0x060240CC RID: 147660 RVA: 0x000C2E08 File Offset: 0x000C1008
		[Token(Token = "0x60240CC")]
		[Address(RVA = "0x1EB7800", Offset = "0x1EB6400", VA = "0x181EB7800", Slot = "23")]
		public bool CheckIfCharSelectable(CharQuery charQuery)
		{
			return default(bool);
		}

		// Token: 0x060240CD RID: 147661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240CD")]
		[Address(RVA = "0x1EBA5E0", Offset = "0x1EB91E0", VA = "0x181EBA5E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060240CE RID: 147662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240CE")]
		[Address(RVA = "0x1EBB0E0", Offset = "0x1EB9CE0", VA = "0x181EBB0E0")]
		private void _OnInitTopMenu(GameObject topMenuObj)
		{
		}

		// Token: 0x060240CF RID: 147663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240CF")]
		[Address(RVA = "0x1EBB3D0", Offset = "0x1EB9FD0", VA = "0x181EBB3D0")]
		private void _OnTopMenuRoutedToOtherPage(UIRouteTarget routeTarget, object param, Action<UIRouteTarget, object> baseHandler)
		{
		}

		// Token: 0x060240D0 RID: 147664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240D0")]
		[Address(RVA = "0x1EB9D90", Offset = "0x1EB8990", VA = "0x181EB9D90")]
		private void _DoStartBattle()
		{
		}

		// Token: 0x060240D1 RID: 147665 RVA: 0x000C2E20 File Offset: 0x000C1020
		[Token(Token = "0x60240D1")]
		[Address(RVA = "0x1EBC9E0", Offset = "0x1EBB5E0", VA = "0x181EBC9E0")]
		private bool _TryShowTipForStartBattle()
		{
			return default(bool);
		}

		// Token: 0x060240D2 RID: 147666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240D2")]
		[Address(RVA = "0x1EB91B0", Offset = "0x1EB7DB0", VA = "0x181EB91B0")]
		private void _ConfirmTipsAndDoStartBattle()
		{
		}

		// Token: 0x060240D3 RID: 147667 RVA: 0x000C2E38 File Offset: 0x000C1038
		[Token(Token = "0x60240D3")]
		[Address(RVA = "0x1EB8E70", Offset = "0x1EB7A70", VA = "0x181EB8E70")]
		private bool _CheckIfStartBattleValid()
		{
			return default(bool);
		}

		// Token: 0x060240D4 RID: 147668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240D4")]
		[Address(RVA = "0x1EBA960", Offset = "0x1EB9560", VA = "0x181EBA960")]
		private void _InvokedStartBattle()
		{
		}

		// Token: 0x060240D5 RID: 147669 RVA: 0x000C2E50 File Offset: 0x000C1050
		[Token(Token = "0x60240D5")]
		[Address(RVA = "0x1EB92A0", Offset = "0x1EB7EA0", VA = "0x181EB92A0")]
		private BattleStartController.Param _CreateParamToStartBattle()
		{
			return default(BattleStartController.Param);
		}

		// Token: 0x060240D6 RID: 147670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240D6")]
		[Address(RVA = "0x1EBB290", Offset = "0x1EB9E90", VA = "0x181EBB290")]
		private void _OnStartBattleSuccess()
		{
		}

		// Token: 0x060240D7 RID: 147671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240D7")]
		[Address(RVA = "0x1EBC440", Offset = "0x1EBB040", VA = "0x181EBC440")]
		private void _SaveCacheStageConfig()
		{
		}

		// Token: 0x060240D8 RID: 147672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240D8")]
		[Address(RVA = "0x1EBC390", Offset = "0x1EBAF90", VA = "0x181EBC390")]
		private void _RefreshStartBtnBg()
		{
		}

		// Token: 0x060240D9 RID: 147673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240D9")]
		[Address(RVA = "0x1EBA290", Offset = "0x1EB8E90", VA = "0x181EBA290")]
		private void _GoToFriendAssist()
		{
		}

		// Token: 0x060240DA RID: 147674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240DA")]
		[Address(RVA = "0x1EBC140", Offset = "0x1EBAD40", VA = "0x181EBC140")]
		private void _PassDataToFriendAssist(IStateBean stateBean)
		{
		}

		// Token: 0x060240DB RID: 147675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240DB")]
		[Address(RVA = "0x1EB9050", Offset = "0x1EB7C50", VA = "0x181EB9050")]
		private void _ClearFiendAssist()
		{
		}

		// Token: 0x060240DC RID: 147676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240DC")]
		[Address(RVA = "0x1EBAB90", Offset = "0x1EB9790", VA = "0x181EBAB90")]
		private void _OnAssistSelectFinished(IStateBean stateBean)
		{
		}

		// Token: 0x060240DD RID: 147677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240DD")]
		[Address(RVA = "0x1EBA130", Offset = "0x1EB8D30", VA = "0x181EBA130")]
		private void _GoToCharSelect(bool isSingleMode, int memberIndex)
		{
		}

		// Token: 0x060240DE RID: 147678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240DE")]
		[Address(RVA = "0x1EBBF90", Offset = "0x1EBAB90", VA = "0x181EBBF90")]
		private void _PassDataToCharSelect(IStateBean stateBean)
		{
		}

		// Token: 0x060240DF RID: 147679 RVA: 0x000C2E68 File Offset: 0x000C1068
		[Token(Token = "0x60240DF")]
		[Address(RVA = "0x1EBB570", Offset = "0x1EBA170", VA = "0x181EBB570")]
		private BossRushSquadHomeState.CharSelectStateBeanInput _ParseSquadSelectParam(bool isSingleMode, int memberIndex)
		{
			return default(BossRushSquadHomeState.CharSelectStateBeanInput);
		}

		// Token: 0x060240E0 RID: 147680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240E0")]
		[Address(RVA = "0x1EBADE0", Offset = "0x1EB99E0", VA = "0x181EBADE0")]
		private void _OnCharSelectFinished(IStateBean stateBean)
		{
		}

		// Token: 0x060240E1 RID: 147681 RVA: 0x000C2E80 File Offset: 0x000C1080
		[Token(Token = "0x60240E1")]
		[Address(RVA = "0x1EB8CA0", Offset = "0x1EB78A0", VA = "0x181EB8CA0")]
		private bool _CheckCharInstSelectable(int instId, string teamId)
		{
			return default(bool);
		}

		// Token: 0x060240E2 RID: 147682 RVA: 0x000C2E98 File Offset: 0x000C1098
		[Token(Token = "0x60240E2")]
		[Address(RVA = "0x1EB7CB0", Offset = "0x1EB68B0", VA = "0x181EB7CB0")]
		private static SquadFriendListItem.LockedStyle GenLockedStyle4CharInvalid()
		{
			return default(SquadFriendListItem.LockedStyle);
		}

		// Token: 0x060240E3 RID: 147683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240E3")]
		[Address(RVA = "0x1EBA740", Offset = "0x1EB9340", VA = "0x181EBA740")]
		private void _InitSquadPlugin()
		{
		}

		// Token: 0x060240E4 RID: 147684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240E4")]
		[Address(RVA = "0x1EBC970", Offset = "0x1EBB570", VA = "0x181EBC970")]
		private void _TriggerSquadPluginResume()
		{
		}

		// Token: 0x060240E5 RID: 147685 RVA: 0x000C2EB0 File Offset: 0x000C10B0
		[Token(Token = "0x60240E5")]
		[Address(RVA = "0x1EB9CE0", Offset = "0x1EB88E0", VA = "0x181EB9CE0")]
		private SquadHomePlugin.PluginInputParams _CreatePluginParam()
		{
			return default(SquadHomePlugin.PluginInputParams);
		}

		// Token: 0x060240E6 RID: 147686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240E6")]
		[Address(RVA = "0x1EBC5E0", Offset = "0x1EBB1E0", VA = "0x181EBC5E0")]
		private void _SwitchSquad(int index, bool isTabClick, bool needCache)
		{
		}

		// Token: 0x060240E7 RID: 147687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240E7")]
		[Address(RVA = "0x1EBC540", Offset = "0x1EBB140", VA = "0x181EBC540")]
		private void _SaveSquadFormationIfNeeded(Action nextStep)
		{
		}

		// Token: 0x060240E8 RID: 147688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60240E8")]
		[Address(RVA = "0x1EB9FC0", Offset = "0x1EB8BC0", VA = "0x181EB9FC0")]
		private SquadItemStruct[] _GetCurSquadMembers()
		{
			return null;
		}

		// Token: 0x060240E9 RID: 147689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240E9")]
		[Address(RVA = "0x1EB9F40", Offset = "0x1EB8B40", VA = "0x181EB9F40")]
		private void _EventOnSquadTabClick(int index)
		{
		}

		// Token: 0x060240EA RID: 147690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240EA")]
		[Address(RVA = "0x1EB7B80", Offset = "0x1EB6780", VA = "0x181EB7B80")]
		public void EventOnSquadLeftRightClick(int delta)
		{
		}

		// Token: 0x060240EB RID: 147691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240EB")]
		[Address(RVA = "0x1EB9EB0", Offset = "0x1EB8AB0", VA = "0x181EB9EB0")]
		private void _EventOnSingleFormationClicked(int memberIndex)
		{
		}

		// Token: 0x060240EC RID: 147692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240EC")]
		[Address(RVA = "0x1EB7B00", Offset = "0x1EB6700", VA = "0x181EB7B00")]
		public void EventOnMultiFormationClicked()
		{
		}

		// Token: 0x060240ED RID: 147693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240ED")]
		[Address(RVA = "0x1EB78D0", Offset = "0x1EB64D0", VA = "0x181EB78D0")]
		public void EventOnAssistBtnClick()
		{
		}

		// Token: 0x060240EE RID: 147694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240EE")]
		[Address(RVA = "0x1EB7950", Offset = "0x1EB6550", VA = "0x181EB7950")]
		public void EventOnAssistClearClick()
		{
		}

		// Token: 0x060240EF RID: 147695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240EF")]
		[Address(RVA = "0x1EB7C20", Offset = "0x1EB6820", VA = "0x181EB7C20")]
		public void EventOnStartBtnClick()
		{
		}

		// Token: 0x060240F0 RID: 147696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240F0")]
		[Address(RVA = "0x1EBCCC0", Offset = "0x1EBB8C0", VA = "0x181EBCCC0")]
		public BossRushSquadHomeState()
		{
		}

		// Token: 0x060240F4 RID: 147700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240F4")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060240F5 RID: 147701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240F5")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060240F6 RID: 147702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60240F6")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060240F7 RID: 147703 RVA: 0x000C2EC8 File Offset: 0x000C10C8
		[Token(Token = "0x60240F7")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x060240F8 RID: 147704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60240F8")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0403218E RID: 205198
		[Token(Token = "0x403218E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0403218F RID: 205199
		[Token(Token = "0x403218F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BossRushSquadGroupController _squadGroupController;

		// Token: 0x04032190 RID: 205200
		[Token(Token = "0x4032190")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SquadAssistCardView _assistCard;

		// Token: 0x04032191 RID: 205201
		[Token(Token = "0x4032191")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SquadHomePluginLoader _homePluginLoader;

		// Token: 0x04032192 RID: 205202
		[Token(Token = "0x4032192")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _startBattleImg;

		// Token: 0x04032193 RID: 205203
		[Token(Token = "0x4032193")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x04032194 RID: 205204
		[Token(Token = "0x4032194")]
		[FieldOffset(Offset = "0x80")]
		private BossRushSquadStateBean m_stateBean;

		// Token: 0x04032195 RID: 205205
		[Token(Token = "0x4032195")]
		[FieldOffset(Offset = "0x88")]
		private BossRushSquadHomeState.CharSelectStateBeanInput m_charSelectStateBeanInput;

		// Token: 0x04032196 RID: 205206
		[Token(Token = "0x4032196")]
		[FieldOffset(Offset = "0xE0")]
		private List<int> m_tempListForExclusiveInstIds;

		// Token: 0x04032197 RID: 205207
		[Token(Token = "0x4032197")]
		[FieldOffset(Offset = "0xE8")]
		private SquadHomePlugin m_squadHomePlugin;

		// Token: 0x04032198 RID: 205208
		[Token(Token = "0x4032198")]
		[FieldOffset(Offset = "0xF0")]
		private SquadCharSelectMaskPlugin m_charSelectMaskPluginPrefab;

		// Token: 0x04032199 RID: 205209
		[Token(Token = "0x4032199")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403219A RID: 205210
		[Token(Token = "0x403219A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403219B RID: 205211
		[Token(Token = "0x403219B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403219C RID: 205212
		[Token(Token = "0x403219C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403219D RID: 205213
		[Token(Token = "0x403219D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0403219E RID: 205214
		[Token(Token = "0x403219E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0403219F RID: 205215
		[Token(Token = "0x403219F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTempListForExclusiveInstIds;

		// Token: 0x040321A0 RID: 205216
		[Token(Token = "0x40321A0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetSquadGroupViewModel;

		// Token: 0x040321A1 RID: 205217
		[Token(Token = "0x40321A1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfCharSelectable;

		// Token: 0x040321A2 RID: 205218
		[Token(Token = "0x40321A2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040321A3 RID: 205219
		[Token(Token = "0x40321A3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x040321A4 RID: 205220
		[Token(Token = "0x40321A4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnTopMenuRoutedToOtherPage;

		// Token: 0x040321A5 RID: 205221
		[Token(Token = "0x40321A5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DoStartBattle;

		// Token: 0x040321A6 RID: 205222
		[Token(Token = "0x40321A6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryShowTipForStartBattle;

		// Token: 0x040321A7 RID: 205223
		[Token(Token = "0x40321A7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ConfirmTipsAndDoStartBattle;

		// Token: 0x040321A8 RID: 205224
		[Token(Token = "0x40321A8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckIfStartBattleValid;

		// Token: 0x040321A9 RID: 205225
		[Token(Token = "0x40321A9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InvokedStartBattle;

		// Token: 0x040321AA RID: 205226
		[Token(Token = "0x40321AA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CreateParamToStartBattle;

		// Token: 0x040321AB RID: 205227
		[Token(Token = "0x40321AB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnStartBattleSuccess;

		// Token: 0x040321AC RID: 205228
		[Token(Token = "0x40321AC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SaveCacheStageConfig;

		// Token: 0x040321AD RID: 205229
		[Token(Token = "0x40321AD")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__RefreshStartBtnBg;

		// Token: 0x040321AE RID: 205230
		[Token(Token = "0x40321AE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GoToFriendAssist;

		// Token: 0x040321AF RID: 205231
		[Token(Token = "0x40321AF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__PassDataToFriendAssist;

		// Token: 0x040321B0 RID: 205232
		[Token(Token = "0x40321B0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ClearFiendAssist;

		// Token: 0x040321B1 RID: 205233
		[Token(Token = "0x40321B1")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnAssistSelectFinished;

		// Token: 0x040321B2 RID: 205234
		[Token(Token = "0x40321B2")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__GoToCharSelect;

		// Token: 0x040321B3 RID: 205235
		[Token(Token = "0x40321B3")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__PassDataToCharSelect;

		// Token: 0x040321B4 RID: 205236
		[Token(Token = "0x40321B4")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ParseSquadSelectParam;

		// Token: 0x040321B5 RID: 205237
		[Token(Token = "0x40321B5")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnCharSelectFinished;

		// Token: 0x040321B6 RID: 205238
		[Token(Token = "0x40321B6")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CheckCharInstSelectable;

		// Token: 0x040321B7 RID: 205239
		[Token(Token = "0x40321B7")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GenLockedStyle4CharInvalid;

		// Token: 0x040321B8 RID: 205240
		[Token(Token = "0x40321B8")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__InitSquadPlugin;

		// Token: 0x040321B9 RID: 205241
		[Token(Token = "0x40321B9")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__TriggerSquadPluginResume;

		// Token: 0x040321BA RID: 205242
		[Token(Token = "0x40321BA")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__CreatePluginParam;

		// Token: 0x040321BB RID: 205243
		[Token(Token = "0x40321BB")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__SwitchSquad;

		// Token: 0x040321BC RID: 205244
		[Token(Token = "0x40321BC")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__SaveSquadFormationIfNeeded;

		// Token: 0x040321BD RID: 205245
		[Token(Token = "0x40321BD")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__GetCurSquadMembers;

		// Token: 0x040321BE RID: 205246
		[Token(Token = "0x40321BE")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__EventOnSquadTabClick;

		// Token: 0x040321BF RID: 205247
		[Token(Token = "0x40321BF")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_EventOnSquadLeftRightClick;

		// Token: 0x040321C0 RID: 205248
		[Token(Token = "0x40321C0")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__EventOnSingleFormationClicked;

		// Token: 0x040321C1 RID: 205249
		[Token(Token = "0x40321C1")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_EventOnMultiFormationClicked;

		// Token: 0x040321C2 RID: 205250
		[Token(Token = "0x40321C2")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_EventOnAssistBtnClick;

		// Token: 0x040321C3 RID: 205251
		[Token(Token = "0x40321C3")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_EventOnAssistClearClick;

		// Token: 0x040321C4 RID: 205252
		[Token(Token = "0x40321C4")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_EventOnStartBtnClick;

		// Token: 0x040321C5 RID: 205253
		[Token(Token = "0x40321C5")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200619F RID: 24991
		[Token(Token = "0x200619F")]
		private class CharSelectPlugin : UICharacterSelectState.Plugin<BossRushSquadHomeState>
		{
			// Token: 0x17005513 RID: 21779
			// (get) Token: 0x060240F9 RID: 147705 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005513")]
			public override string overrideNoCharText
			{
				[Token(Token = "0x60240F9")]
				[Address(RVA = "0x1ECB180", Offset = "0x1EC9D80", VA = "0x181ECB180", Slot = "28")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005514 RID: 21780
			// (get) Token: 0x060240FA RID: 147706 RVA: 0x000C2EE0 File Offset: 0x000C10E0
			[Token(Token = "0x17005514")]
			public override bool showCharInfoEntry
			{
				[Token(Token = "0x60240FA")]
				[Address(RVA = "0x1ECB1F0", Offset = "0x1EC9DF0", VA = "0x181ECB1F0", Slot = "29")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005515 RID: 21781
			// (get) Token: 0x060240FB RID: 147707 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005515")]
			public override CharSelectCardMaskPlugin cardMaskPrefab
			{
				[Token(Token = "0x60240FB")]
				[Address(RVA = "0x1ECB100", Offset = "0x1EC9D00", VA = "0x181ECB100", Slot = "32")]
				get
				{
					return null;
				}
			}

			// Token: 0x060240FC RID: 147708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60240FC")]
			[Address(RVA = "0x1ECA9F0", Offset = "0x1EC95F0", VA = "0x181ECA9F0", Slot = "25")]
			public override void OverrideCharSelect(int instId, Action<int> selfCharSelect)
			{
			}

			// Token: 0x060240FD RID: 147709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60240FD")]
			[Address(RVA = "0x1ECA7A0", Offset = "0x1EC93A0", VA = "0x181ECA7A0", Slot = "37")]
			public override void AddCharMultiSelectExcludeRule(int instId, List<int> excludeInstIds)
			{
			}

			// Token: 0x060240FE RID: 147710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60240FE")]
			[Address(RVA = "0x1ECAE50", Offset = "0x1EC9A50", VA = "0x181ECAE50", Slot = "30")]
			public override void OverrideSkillSelect(string skillId, Action<string> selfSkillSelect)
			{
			}

			// Token: 0x060240FF RID: 147711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60240FF")]
			[Address(RVA = "0x1ECA950", Offset = "0x1EC9550", VA = "0x181ECA950", Slot = "31")]
			public override void OverrideBranchSelect(string equipId, Action<string> selfBranchSelect)
			{
			}

			// Token: 0x06024100 RID: 147712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024100")]
			[Address(RVA = "0x1ECACD0", Offset = "0x1EC98D0", VA = "0x181ECACD0", Slot = "33")]
			public override void OverrideDismiss(Action selfDismiss)
			{
			}

			// Token: 0x06024101 RID: 147713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024101")]
			[Address(RVA = "0x1ECADD0", Offset = "0x1EC99D0", VA = "0x181ECADD0", Slot = "26")]
			public override void OverrideSelectConfirmed(Action selfConfirm)
			{
			}

			// Token: 0x06024102 RID: 147714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024102")]
			[Address(RVA = "0x1ECAD50", Offset = "0x1EC9950", VA = "0x181ECAD50", Slot = "27")]
			public override void OverrideSelectCanceled(Action selfCancel)
			{
			}

			// Token: 0x06024103 RID: 147715 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024103")]
			[Address(RVA = "0x1ECAFC0", Offset = "0x1EC9BC0", VA = "0x181ECAFC0", Slot = "34")]
			public override string OverrideUpdateSelectedSkill(int instId, string prevSkill, Func<int, string, string> selfUpdateSelectSkill)
			{
				return null;
			}

			// Token: 0x06024104 RID: 147716 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024104")]
			[Address(RVA = "0x1ECAEF0", Offset = "0x1EC9AF0", VA = "0x181ECAEF0", Slot = "35")]
			public override string OverrideUpdateSelectedBranch(int instId, string prevBranch, Func<int, string, string> selfUpdateSelectBranch)
			{
				return null;
			}

			// Token: 0x06024105 RID: 147717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024105")]
			[Address(RVA = "0x1ECB090", Offset = "0x1EC9C90", VA = "0x181ECB090")]
			public CharSelectPlugin()
			{
			}

			// Token: 0x040321C6 RID: 205254
			[Token(Token = "0x40321C6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_overrideNoCharText;

			// Token: 0x040321C7 RID: 205255
			[Token(Token = "0x40321C7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showCharInfoEntry;

			// Token: 0x040321C8 RID: 205256
			[Token(Token = "0x40321C8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_cardMaskPrefab;

			// Token: 0x040321C9 RID: 205257
			[Token(Token = "0x40321C9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OverrideCharSelect;

			// Token: 0x040321CA RID: 205258
			[Token(Token = "0x40321CA")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AddCharMultiSelectExcludeRule;

			// Token: 0x040321CB RID: 205259
			[Token(Token = "0x40321CB")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OverrideSkillSelect;

			// Token: 0x040321CC RID: 205260
			[Token(Token = "0x40321CC")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OverrideBranchSelect;

			// Token: 0x040321CD RID: 205261
			[Token(Token = "0x40321CD")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OverrideDismiss;

			// Token: 0x040321CE RID: 205262
			[Token(Token = "0x40321CE")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OverrideSelectConfirmed;

			// Token: 0x040321CF RID: 205263
			[Token(Token = "0x40321CF")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OverrideSelectCanceled;

			// Token: 0x040321D0 RID: 205264
			[Token(Token = "0x40321D0")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OverrideUpdateSelectedSkill;

			// Token: 0x040321D1 RID: 205265
			[Token(Token = "0x40321D1")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OverrideUpdateSelectedBranch;

			// Token: 0x040321D2 RID: 205266
			[Token(Token = "0x40321D2")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020061A0 RID: 24992
		[Token(Token = "0x20061A0")]
		private class SquadAssistPlugin : SquadFriendAssistState.Plugin<BossRushSquadHomeState>
		{
			// Token: 0x06024106 RID: 147718 RVA: 0x000C2EF8 File Offset: 0x000C10F8
			[Token(Token = "0x6024106")]
			[Address(RVA = "0x1ECB870", Offset = "0x1ECA470", VA = "0x181ECB870", Slot = "9")]
			public override bool CheckIfCharValid(CharQuery charQuery, ref SquadFriendListItem.LockedStyle lockStyleConfig)
			{
				return default(bool);
			}

			// Token: 0x06024107 RID: 147719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024107")]
			[Address(RVA = "0x1ECBB10", Offset = "0x1ECA710", VA = "0x181ECBB10")]
			public SquadAssistPlugin()
			{
			}
		}

		// Token: 0x020061A1 RID: 24993
		[Token(Token = "0x20061A1")]
		private struct CharSelectStateBeanInput : SquadHomeState.ICharSelectInput
		{
			// Token: 0x17005516 RID: 21782
			// (get) Token: 0x06024108 RID: 147720 RVA: 0x000C2F10 File Offset: 0x000C1110
			[Token(Token = "0x17005516")]
			public CharSelectStateBean.Input inputParam
			{
				[Token(Token = "0x6024108")]
				[Address(RVA = "0x1ECB250", Offset = "0x1EC9E50", VA = "0x181ECB250", Slot = "4")]
				get
				{
					return default(CharSelectStateBean.Input);
				}
			}

			// Token: 0x17005517 RID: 21783
			// (get) Token: 0x06024109 RID: 147721 RVA: 0x000C2F28 File Offset: 0x000C1128
			// (set) Token: 0x0602410A RID: 147722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005517")]
			public int squadIndex
			{
				[Token(Token = "0x6024109")]
				[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x602410A")]
				[Address(RVA = "0x509F70", Offset = "0x508B70", VA = "0x180509F70")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x040321D3 RID: 205267
			[Token(Token = "0x40321D3")]
			[FieldOffset(Offset = "0x0")]
			public bool isSingleSelectTeamMember;

			// Token: 0x040321D4 RID: 205268
			[Token(Token = "0x40321D4")]
			[FieldOffset(Offset = "0x8")]
			public string selectingTeamId;

			// Token: 0x040321D5 RID: 205269
			[Token(Token = "0x40321D5")]
			[FieldOffset(Offset = "0x10")]
			public CharSelectStateBean.Input paramToSelectState;
		}
	}
}
