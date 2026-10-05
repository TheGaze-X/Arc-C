using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EF0 RID: 24304
	[Token(Token = "0x2005EF0")]
	public class CharacterLvlupVoucherState : State
	{
		// Token: 0x06023369 RID: 144233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023369")]
		[Address(RVA = "0x1DB6530", Offset = "0x1DB5130", VA = "0x181DB6530", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602336A RID: 144234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602336A")]
		[Address(RVA = "0x1DB69F0", Offset = "0x1DB55F0", VA = "0x181DB69F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602336B RID: 144235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602336B")]
		[Address(RVA = "0x1DB6BD0", Offset = "0x1DB57D0", VA = "0x181DB6BD0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602336C RID: 144236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602336C")]
		[Address(RVA = "0x1DB6C60", Offset = "0x1DB5860", VA = "0x181DB6C60", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602336D RID: 144237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602336D")]
		[Address(RVA = "0x1DB7000", Offset = "0x1DB5C00", VA = "0x181DB7000")]
		private void _OnJumpToMaxState(IStateBean stateBean)
		{
		}

		// Token: 0x0602336E RID: 144238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602336E")]
		[Address(RVA = "0x1DB6DC0", Offset = "0x1DB59C0", VA = "0x181DB6DC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602336F RID: 144239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602336F")]
		[Address(RVA = "0x1DB6ED0", Offset = "0x1DB5AD0", VA = "0x181DB6ED0")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x06023370 RID: 144240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023370")]
		[Address(RVA = "0x1DB7100", Offset = "0x1DB5D00", VA = "0x181DB7100")]
		private IEnumerator _TryOpenLevelMaxState()
		{
			return null;
		}

		// Token: 0x06023371 RID: 144241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023371")]
		[Address(RVA = "0x1DB6590", Offset = "0x1DB5190", VA = "0x181DB6590")]
		public void OnCloseBtnClicked()
		{
		}

		// Token: 0x06023372 RID: 144242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023372")]
		[Address(RVA = "0x1DB6640", Offset = "0x1DB5240", VA = "0x181DB6640")]
		public void OnConfirmBtnClicked()
		{
		}

		// Token: 0x06023373 RID: 144243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023373")]
		[Address(RVA = "0x1DB71B0", Offset = "0x1DB5DB0", VA = "0x181DB71B0")]
		public CharacterLvlupVoucherState()
		{
		}

		// Token: 0x06023375 RID: 144245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023375")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023376 RID: 144246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023376")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06023377 RID: 144247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023377")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04030850 RID: 198736
		[Token(Token = "0x4030850")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04030851 RID: 198737
		[Token(Token = "0x4030851")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterLvlupVoucherStateBean _stateBean;

		// Token: 0x04030852 RID: 198738
		[Token(Token = "0x4030852")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterLvlupVoucherView _voucherView;

		// Token: 0x04030853 RID: 198739
		[Token(Token = "0x4030853")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Notify")]
		private CharacterInfoLevelUpNotifyView _levelUpNotify;

		// Token: 0x04030854 RID: 198740
		[Token(Token = "0x4030854")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Notify")]
		private CharacterInfoTalentUnlockNotifyView _talentUnlockNotify;

		// Token: 0x04030855 RID: 198741
		[Token(Token = "0x4030855")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Notify")]
		private CharacterInfoSkillUnlockNotifyView _skillUnlockNotify;

		// Token: 0x04030856 RID: 198742
		[Token(Token = "0x4030856")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Notify")]
		private CharacterInfoBuildingBuffUnlockNotifyView _buildingBuffUnlockNotify;

		// Token: 0x04030857 RID: 198743
		[Token(Token = "0x4030857")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Notify")]
		private CharacterInfoBuildingBuffUpgradeNotifyView _buildingBuffUpgradeNotify;

		// Token: 0x04030858 RID: 198744
		[Token(Token = "0x4030858")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04030859 RID: 198745
		[Token(Token = "0x4030859")]
		[FieldOffset(Offset = "0x98")]
		private CharacterLvlupPage.Param m_param;

		// Token: 0x0403085A RID: 198746
		[Token(Token = "0x403085A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403085B RID: 198747
		[Token(Token = "0x403085B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403085C RID: 198748
		[Token(Token = "0x403085C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403085D RID: 198749
		[Token(Token = "0x403085D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403085E RID: 198750
		[Token(Token = "0x403085E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToMaxState;

		// Token: 0x0403085F RID: 198751
		[Token(Token = "0x403085F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030860 RID: 198752
		[Token(Token = "0x4030860")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x04030861 RID: 198753
		[Token(Token = "0x4030861")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryOpenLevelMaxState;

		// Token: 0x04030862 RID: 198754
		[Token(Token = "0x4030862")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCloseBtnClicked;

		// Token: 0x04030863 RID: 198755
		[Token(Token = "0x4030863")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClicked;

		// Token: 0x04030864 RID: 198756
		[Token(Token = "0x4030864")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
