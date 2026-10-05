using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061C1 RID: 25025
	[Token(Token = "0x20061C1")]
	public class BossRushStageDetailState : PopupFadeState
	{
		// Token: 0x060241CA RID: 147914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60241CA")]
		[Address(RVA = "0x1EC8B20", Offset = "0x1EC7720", VA = "0x181EC8B20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060241CB RID: 147915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241CB")]
		[Address(RVA = "0x1EC8B80", Offset = "0x1EC7780", VA = "0x181EC8B80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060241CC RID: 147916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241CC")]
		[Address(RVA = "0x1EC8BF0", Offset = "0x1EC77F0", VA = "0x181EC8BF0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060241CD RID: 147917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60241CD")]
		[Address(RVA = "0x1EC8C70", Offset = "0x1EC7870", VA = "0x181EC8C70", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060241CE RID: 147918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241CE")]
		[Address(RVA = "0x1EC9740", Offset = "0x1EC8340", VA = "0x181EC9740")]
		private void _OnJumpToEnemyHandBook(IStateBean stateBean)
		{
		}

		// Token: 0x060241CF RID: 147919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241CF")]
		[Address(RVA = "0x1EC9670", Offset = "0x1EC8270", VA = "0x181EC9670")]
		private void _OnHideMapClick()
		{
		}

		// Token: 0x060241D0 RID: 147920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241D0")]
		[Address(RVA = "0x1EC9A80", Offset = "0x1EC8680", VA = "0x181EC9A80")]
		private void _OnMapPreviewItemClick(int position)
		{
		}

		// Token: 0x060241D1 RID: 147921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241D1")]
		[Address(RVA = "0x1EC9B60", Offset = "0x1EC8760", VA = "0x181EC9B60")]
		private void _OnModeButtonClick(ActivityBossRushData.BossRushStageType stageType)
		{
		}

		// Token: 0x060241D2 RID: 147922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241D2")]
		[Address(RVA = "0x1EC9D70", Offset = "0x1EC8970", VA = "0x181EC9D70")]
		private void _OnModeSwitchClick()
		{
		}

		// Token: 0x060241D3 RID: 147923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241D3")]
		[Address(RVA = "0x1EC95E0", Offset = "0x1EC81E0", VA = "0x181EC95E0")]
		private void _OnEnemyDetailClick()
		{
		}

		// Token: 0x060241D4 RID: 147924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241D4")]
		[Address(RVA = "0x1ECA2B0", Offset = "0x1EC8EB0", VA = "0x181ECA2B0")]
		private void _OnTeamClick(string teamId)
		{
		}

		// Token: 0x060241D5 RID: 147925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241D5")]
		[Address(RVA = "0x1EC9FE0", Offset = "0x1EC8BE0", VA = "0x181EC9FE0")]
		private void _OnStartBattleClick()
		{
		}

		// Token: 0x060241D6 RID: 147926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241D6")]
		[Address(RVA = "0x1EC99A0", Offset = "0x1EC85A0", VA = "0x181EC99A0")]
		private void _OnMapPreviewClick(bool isShown)
		{
		}

		// Token: 0x060241D7 RID: 147927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241D7")]
		[Address(RVA = "0x1EC9F30", Offset = "0x1EC8B30", VA = "0x181EC9F30")]
		private void _OnRewardClick()
		{
		}

		// Token: 0x060241D8 RID: 147928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241D8")]
		[Address(RVA = "0x1EC8DD0", Offset = "0x1EC79D0", VA = "0x181EC8DD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060241D9 RID: 147929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241D9")]
		[Address(RVA = "0x1ECA450", Offset = "0x1EC9050", VA = "0x181ECA450")]
		private void _RefreshView()
		{
		}

		// Token: 0x060241DA RID: 147930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241DA")]
		[Address(RVA = "0x1ECA6F0", Offset = "0x1EC92F0", VA = "0x181ECA6F0")]
		public BossRushStageDetailState()
		{
		}

		// Token: 0x060241DB RID: 147931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241DB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060241DC RID: 147932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241DC")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060241DD RID: 147933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60241DD")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403232D RID: 205613
		[Token(Token = "0x403232D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topContainer;

		// Token: 0x0403232E RID: 205614
		[Token(Token = "0x403232E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BossRushStageDetailButtonGroupView _buttonGroupView;

		// Token: 0x0403232F RID: 205615
		[Token(Token = "0x403232F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BossRushStageDetailMapPreviewView _mapPreviewView;

		// Token: 0x04032330 RID: 205616
		[Token(Token = "0x4032330")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BossRushStageDetailInfoView _infoView;

		// Token: 0x04032331 RID: 205617
		[Token(Token = "0x4032331")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BossRushStageDetailTeamGroupView _teamGroupView;

		// Token: 0x04032332 RID: 205618
		[Token(Token = "0x4032332")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private BossRushStageDetailMapPreviewPanel _previewPanel;

		// Token: 0x04032333 RID: 205619
		[Token(Token = "0x4032333")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private BossRushStageDetailDropPanel _dropPanel;

		// Token: 0x04032334 RID: 205620
		[Token(Token = "0x4032334")]
		[FieldOffset(Offset = "0xA8")]
		private BossRushStageDetailStateBean m_stateBean;

		// Token: 0x04032335 RID: 205621
		[Token(Token = "0x4032335")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x04032336 RID: 205622
		[Token(Token = "0x4032336")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04032337 RID: 205623
		[Token(Token = "0x4032337")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04032338 RID: 205624
		[Token(Token = "0x4032338")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04032339 RID: 205625
		[Token(Token = "0x4032339")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403233A RID: 205626
		[Token(Token = "0x403233A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandBook;

		// Token: 0x0403233B RID: 205627
		[Token(Token = "0x403233B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnHideMapClick;

		// Token: 0x0403233C RID: 205628
		[Token(Token = "0x403233C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnMapPreviewItemClick;

		// Token: 0x0403233D RID: 205629
		[Token(Token = "0x403233D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnModeButtonClick;

		// Token: 0x0403233E RID: 205630
		[Token(Token = "0x403233E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnModeSwitchClick;

		// Token: 0x0403233F RID: 205631
		[Token(Token = "0x403233F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnEnemyDetailClick;

		// Token: 0x04032340 RID: 205632
		[Token(Token = "0x4032340")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnTeamClick;

		// Token: 0x04032341 RID: 205633
		[Token(Token = "0x4032341")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnStartBattleClick;

		// Token: 0x04032342 RID: 205634
		[Token(Token = "0x4032342")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnMapPreviewClick;

		// Token: 0x04032343 RID: 205635
		[Token(Token = "0x4032343")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnRewardClick;

		// Token: 0x04032344 RID: 205636
		[Token(Token = "0x4032344")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032345 RID: 205637
		[Token(Token = "0x4032345")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x04032346 RID: 205638
		[Token(Token = "0x4032346")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
