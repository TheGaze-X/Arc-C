using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EE9 RID: 24297
	[Token(Token = "0x2005EE9")]
	public class CharacterLvlupHomeState : State
	{
		// Token: 0x0602332B RID: 144171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602332B")]
		[Address(RVA = "0x1DB3480", Offset = "0x1DB2080", VA = "0x181DB3480", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602332C RID: 144172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602332C")]
		[Address(RVA = "0x1DB34E0", Offset = "0x1DB20E0", VA = "0x181DB34E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602332D RID: 144173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602332D")]
		[Address(RVA = "0x1DB3620", Offset = "0x1DB2220", VA = "0x181DB3620", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602332E RID: 144174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602332E")]
		[Address(RVA = "0x1DB3700", Offset = "0x1DB2300", VA = "0x181DB3700", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602332F RID: 144175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602332F")]
		[Address(RVA = "0x1DB2F60", Offset = "0x1DB1B60", VA = "0x181DB2F60")]
		public void EventOnClearBtnClick()
		{
		}

		// Token: 0x06023330 RID: 144176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023330")]
		[Address(RVA = "0x1DB3140", Offset = "0x1DB1D40", VA = "0x181DB3140")]
		public void EventOnUpgradeBtnClick()
		{
		}

		// Token: 0x06023331 RID: 144177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023331")]
		[Address(RVA = "0x1DB30D0", Offset = "0x1DB1CD0", VA = "0x181DB30D0")]
		public void EventOnScrollResetBtnClick()
		{
		}

		// Token: 0x06023332 RID: 144178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023332")]
		[Address(RVA = "0x1DB2FD0", Offset = "0x1DB1BD0", VA = "0x181DB2FD0")]
		public void EventOnScrollCancelBtnClick()
		{
		}

		// Token: 0x06023333 RID: 144179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023333")]
		[Address(RVA = "0x1DB3040", Offset = "0x1DB1C40", VA = "0x181DB3040")]
		public void EventOnScrollConfirmBtnClick()
		{
		}

		// Token: 0x06023334 RID: 144180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023334")]
		[Address(RVA = "0x1DB43F0", Offset = "0x1DB2FF0", VA = "0x181DB43F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023335 RID: 144181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023335")]
		[Address(RVA = "0x1DB46E0", Offset = "0x1DB32E0", VA = "0x181DB46E0")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x06023336 RID: 144182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023336")]
		[Address(RVA = "0x1DB4920", Offset = "0x1DB3520", VA = "0x181DB4920")]
		private void _OnModifyingExpCardNum(int index, int deltaNum)
		{
		}

		// Token: 0x06023337 RID: 144183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023337")]
		[Address(RVA = "0x1DB4A30", Offset = "0x1DB3630", VA = "0x181DB4A30")]
		private void _OnWheelBeginDrag()
		{
		}

		// Token: 0x06023338 RID: 144184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023338")]
		[Address(RVA = "0x1DB4B20", Offset = "0x1DB3720", VA = "0x181DB4B20")]
		private void _OnWheelScrollEnd(int index)
		{
		}

		// Token: 0x06023339 RID: 144185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023339")]
		[Address(RVA = "0x1DB4AA0", Offset = "0x1DB36A0", VA = "0x181DB4AA0")]
		private void _OnWheelClicked(int index)
		{
		}

		// Token: 0x0602333A RID: 144186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602333A")]
		[Address(RVA = "0x1DB49C0", Offset = "0x1DB35C0", VA = "0x181DB49C0")]
		private void _OnMoveToMaxValidLevel()
		{
		}

		// Token: 0x0602333B RID: 144187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602333B")]
		[Address(RVA = "0x1DB4810", Offset = "0x1DB3410", VA = "0x181DB4810")]
		private void _OnJumpToMaxState(IStateBean stateBean)
		{
		}

		// Token: 0x0602333C RID: 144188 RVA: 0x000C0198 File Offset: 0x000BE398
		[Token(Token = "0x602333C")]
		[Address(RVA = "0x1DB42C0", Offset = "0x1DB2EC0", VA = "0x181DB42C0")]
		private bool _CheckIfExpAndGoldEnough()
		{
			return default(bool);
		}

		// Token: 0x0602333D RID: 144189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602333D")]
		[Address(RVA = "0x1DB4BA0", Offset = "0x1DB37A0", VA = "0x181DB4BA0")]
		private static UpgradeCharRequest _ParseUpgradeCharRequest(int charInstId, List<CharacterLvlupItemCardViewModel> selectedItems)
		{
			return null;
		}

		// Token: 0x0602333E RID: 144190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602333E")]
		[Address(RVA = "0x1DB3860", Offset = "0x1DB2460", VA = "0x181DB3860")]
		public static void ShowLevelUpToasts(CharQuery charQuery, List<CharacterData.UniqueEquipPair> equipQueries, EvolvePhase evolve, int potentialRank, int mainSkillLvl, int fromLevel, int toLevel, LevelUpToastPrefabConfig prefabConfig)
		{
		}

		// Token: 0x0602333F RID: 144191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602333F")]
		[Address(RVA = "0x1DB4D70", Offset = "0x1DB3970", VA = "0x181DB4D70")]
		public CharacterLvlupHomeState()
		{
		}

		// Token: 0x06023341 RID: 144193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023341")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023342 RID: 144194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023342")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06023343 RID: 144195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023343")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04030809 RID: 198665
		[Token(Token = "0x4030809")]
		private const float TOAST_DELTA = 0.16f;

		// Token: 0x0403080A RID: 198666
		[Token(Token = "0x403080A")]
		private const string ANIM_ENTER = "lvlup_page_enter";

		// Token: 0x0403080B RID: 198667
		[Token(Token = "0x403080B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0403080C RID: 198668
		[Token(Token = "0x403080C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterLvlupHomeView _lvlupView;

		// Token: 0x0403080D RID: 198669
		[Token(Token = "0x403080D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Notify")]
		private CharacterInfoLevelUpNotifyView _levelUpNotify;

		// Token: 0x0403080E RID: 198670
		[Token(Token = "0x403080E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Notify")]
		private CharacterInfoTalentUnlockNotifyView _talentUnlockNotify;

		// Token: 0x0403080F RID: 198671
		[Token(Token = "0x403080F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Notify")]
		private CharacterInfoSkillUnlockNotifyView _skillUnlockNotify;

		// Token: 0x04030810 RID: 198672
		[Token(Token = "0x4030810")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Notify")]
		private CharacterInfoBuildingBuffUnlockNotifyView _buildingBuffUnlockNotify;

		// Token: 0x04030811 RID: 198673
		[Token(Token = "0x4030811")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Notify")]
		private CharacterInfoBuildingBuffUpgradeNotifyView _buildingBuffUpgradeNotify;

		// Token: 0x04030812 RID: 198674
		[Token(Token = "0x4030812")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CharacterLvlupHomeStateBean _stateBean;

		// Token: 0x04030813 RID: 198675
		[Token(Token = "0x4030813")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04030814 RID: 198676
		[Token(Token = "0x4030814")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x04030815 RID: 198677
		[Token(Token = "0x4030815")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030816 RID: 198678
		[Token(Token = "0x4030816")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030817 RID: 198679
		[Token(Token = "0x4030817")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04030818 RID: 198680
		[Token(Token = "0x4030818")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04030819 RID: 198681
		[Token(Token = "0x4030819")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClearBtnClick;

		// Token: 0x0403081A RID: 198682
		[Token(Token = "0x403081A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnUpgradeBtnClick;

		// Token: 0x0403081B RID: 198683
		[Token(Token = "0x403081B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnScrollResetBtnClick;

		// Token: 0x0403081C RID: 198684
		[Token(Token = "0x403081C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnScrollCancelBtnClick;

		// Token: 0x0403081D RID: 198685
		[Token(Token = "0x403081D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnScrollConfirmBtnClick;

		// Token: 0x0403081E RID: 198686
		[Token(Token = "0x403081E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403081F RID: 198687
		[Token(Token = "0x403081F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x04030820 RID: 198688
		[Token(Token = "0x4030820")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnModifyingExpCardNum;

		// Token: 0x04030821 RID: 198689
		[Token(Token = "0x4030821")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnWheelBeginDrag;

		// Token: 0x04030822 RID: 198690
		[Token(Token = "0x4030822")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnWheelScrollEnd;

		// Token: 0x04030823 RID: 198691
		[Token(Token = "0x4030823")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnWheelClicked;

		// Token: 0x04030824 RID: 198692
		[Token(Token = "0x4030824")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnMoveToMaxValidLevel;

		// Token: 0x04030825 RID: 198693
		[Token(Token = "0x4030825")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnJumpToMaxState;

		// Token: 0x04030826 RID: 198694
		[Token(Token = "0x4030826")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckIfExpAndGoldEnough;

		// Token: 0x04030827 RID: 198695
		[Token(Token = "0x4030827")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ParseUpgradeCharRequest;

		// Token: 0x04030828 RID: 198696
		[Token(Token = "0x4030828")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ShowLevelUpToasts;

		// Token: 0x04030829 RID: 198697
		[Token(Token = "0x4030829")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
