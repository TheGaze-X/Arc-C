using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006143 RID: 24899
	[Token(Token = "0x2006143")]
	public class CampaignZoneMapState : State, IValueMsgReceiver, ICompDialogCallBack, IHotfixable
	{
		// Token: 0x06023F10 RID: 147216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023F10")]
		[Address(RVA = "0x1E96620", Offset = "0x1E95220", VA = "0x181E96620", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023F11 RID: 147217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F11")]
		[Address(RVA = "0x1E96790", Offset = "0x1E95390", VA = "0x181E96790", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023F12 RID: 147218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F12")]
		[Address(RVA = "0x1E97220", Offset = "0x1E95E20", VA = "0x181E97220", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06023F13 RID: 147219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023F13")]
		[Address(RVA = "0x1E97560", Offset = "0x1E96160", VA = "0x181E97560", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06023F14 RID: 147220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F14")]
		[Address(RVA = "0x1E99E20", Offset = "0x1E98A20", VA = "0x181E99E20")]
		private void _OnJumpToMissionState(IStateBean bean)
		{
		}

		// Token: 0x06023F15 RID: 147221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F15")]
		[Address(RVA = "0x1E999A0", Offset = "0x1E985A0", VA = "0x181E999A0")]
		private void _OnJumpToCampaignRuleView(IStateBean stateBean)
		{
		}

		// Token: 0x06023F16 RID: 147222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F16")]
		[Address(RVA = "0x1E99AD0", Offset = "0x1E986D0", VA = "0x181E99AD0")]
		private void _OnJumpToEnemyHandBook(IStateBean stateBean)
		{
		}

		// Token: 0x06023F17 RID: 147223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F17")]
		[Address(RVA = "0x1E99FC0", Offset = "0x1E98BC0", VA = "0x181E99FC0")]
		private void _OnJumpToRewardDetailView(IStateBean stateBean)
		{
		}

		// Token: 0x06023F18 RID: 147224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F18")]
		[Address(RVA = "0x1E99C70", Offset = "0x1E98870", VA = "0x181E99C70")]
		private void _OnJumpToFastCampState(IStateBean rawBean)
		{
		}

		// Token: 0x06023F19 RID: 147225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F19")]
		[Address(RVA = "0x1E969B0", Offset = "0x1E955B0", VA = "0x181E969B0", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06023F1A RID: 147226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F1A")]
		[Address(RVA = "0x1E98620", Offset = "0x1E97220", VA = "0x181E98620")]
		private void _EventOnStageClicked(string stageId)
		{
		}

		// Token: 0x06023F1B RID: 147227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F1B")]
		[Address(RVA = "0x1E98180", Offset = "0x1E96D80", VA = "0x181E98180")]
		private void _EventOnFastCampInfoClicked()
		{
		}

		// Token: 0x06023F1C RID: 147228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F1C")]
		[Address(RVA = "0x1E97C80", Offset = "0x1E96880", VA = "0x181E97C80")]
		private void _EventOnAutoBattleBtnClicked()
		{
		}

		// Token: 0x06023F1D RID: 147229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F1D")]
		[Address(RVA = "0x1E98050", Offset = "0x1E96C50", VA = "0x181E98050")]
		private void _EventOnFastBattleBtnClicked()
		{
		}

		// Token: 0x06023F1E RID: 147230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F1E")]
		[Address(RVA = "0x1E988F0", Offset = "0x1E974F0", VA = "0x181E988F0")]
		private void _EventOnTryTriggerFastCampTutorial()
		{
		}

		// Token: 0x06023F1F RID: 147231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F1F")]
		[Address(RVA = "0x1E98270", Offset = "0x1E96E70", VA = "0x181E98270")]
		private void _EventOnJumpBtnClicked()
		{
		}

		// Token: 0x06023F20 RID: 147232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F20")]
		[Address(RVA = "0x1E97E50", Offset = "0x1E96A50", VA = "0x181E97E50")]
		private void _EventOnDropRewardBtnClicked()
		{
		}

		// Token: 0x06023F21 RID: 147233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F21")]
		[Address(RVA = "0x1E98530", Offset = "0x1E97130", VA = "0x181E98530")]
		private void _EventOnRuleBtnClicked()
		{
		}

		// Token: 0x06023F22 RID: 147234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F22")]
		[Address(RVA = "0x1E97F00", Offset = "0x1E96B00", VA = "0x181E97F00")]
		private void _EventOnEnemyBtnClicked()
		{
		}

		// Token: 0x06023F23 RID: 147235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F23")]
		[Address(RVA = "0x1E98710", Offset = "0x1E97310", VA = "0x181E98710")]
		private void _EventOnStartBattleBtnClicked()
		{
		}

		// Token: 0x06023F24 RID: 147236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F24")]
		[Address(RVA = "0x1E98320", Offset = "0x1E96F20", VA = "0x181E98320")]
		private void _EventOnMissionBtnClicked()
		{
		}

		// Token: 0x06023F25 RID: 147237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F25")]
		[Address(RVA = "0x1E96680", Offset = "0x1E95280", VA = "0x181E96680", Slot = "24")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06023F26 RID: 147238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F26")]
		[Address(RVA = "0x1E99020", Offset = "0x1E97C20", VA = "0x181E99020")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023F27 RID: 147239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F27")]
		[Address(RVA = "0x1E9A0F0", Offset = "0x1E98CF0", VA = "0x181E9A0F0")]
		private void _OnPreviewBackBtnClicked()
		{
		}

		// Token: 0x06023F28 RID: 147240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F28")]
		[Address(RVA = "0x1E99370", Offset = "0x1E97F70", VA = "0x181E99370")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x06023F29 RID: 147241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F29")]
		[Address(RVA = "0x1E99720", Offset = "0x1E98320", VA = "0x181E99720")]
		private void _OnInitCampFee(GameObject campFeeObj)
		{
		}

		// Token: 0x06023F2A RID: 147242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F2A")]
		[Address(RVA = "0x1E97DA0", Offset = "0x1E969A0", VA = "0x181E97DA0")]
		private void _EventOnCampFeeClicked()
		{
		}

		// Token: 0x06023F2B RID: 147243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023F2B")]
		[Address(RVA = "0x1E9A430", Offset = "0x1E99030", VA = "0x181E9A430")]
		private IEnumerator _SwitchSelectStateCoroutine(CampaignZoneMapZoneViewModel zoneViewModel, CampaignZoneMapStageViewModel stageViewModel, bool jumpToCampaign = false)
		{
			return null;
		}

		// Token: 0x06023F2C RID: 147244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F2C")]
		[Address(RVA = "0x1E9A150", Offset = "0x1E98D50", VA = "0x181E9A150")]
		private void _OnSwitchSelectStateEnd()
		{
		}

		// Token: 0x06023F2D RID: 147245 RVA: 0x000C2718 File Offset: 0x000C0918
		[Token(Token = "0x6023F2D")]
		[Address(RVA = "0x1E97AA0", Offset = "0x1E966A0", VA = "0x181E97AA0")]
		private bool _CheckCostBeforeStartBattle()
		{
			return default(bool);
		}

		// Token: 0x06023F2E RID: 147246 RVA: 0x000C2730 File Offset: 0x000C0930
		[Token(Token = "0x6023F2E")]
		[Address(RVA = "0x1E97970", Offset = "0x1E96570", VA = "0x181E97970")]
		private bool _CheckApBeforeStartBattle(int apCost)
		{
			return default(bool);
		}

		// Token: 0x06023F2F RID: 147247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F2F")]
		[Address(RVA = "0x1E9A1B0", Offset = "0x1E98DB0", VA = "0x181E9A1B0")]
		private void _SaveCacheStageConfig()
		{
		}

		// Token: 0x06023F30 RID: 147248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F30")]
		[Address(RVA = "0x1E98A50", Offset = "0x1E97650", VA = "0x181E98A50")]
		private void _GoToSquad()
		{
		}

		// Token: 0x06023F31 RID: 147249 RVA: 0x000C2748 File Offset: 0x000C0948
		[Token(Token = "0x6023F31")]
		[Address(RVA = "0x1E97B60", Offset = "0x1E96760", VA = "0x181E97B60")]
		private bool _CheckNeedToLoadBattleLog(out bool allowNoBattleLog)
		{
			return default(bool);
		}

		// Token: 0x06023F32 RID: 147250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F32")]
		[Address(RVA = "0x1E994C0", Offset = "0x1E980C0", VA = "0x181E994C0")]
		private void _OnGoToSquad(string stageId)
		{
		}

		// Token: 0x06023F33 RID: 147251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F33")]
		[Address(RVA = "0x1E989A0", Offset = "0x1E975A0", VA = "0x181E989A0")]
		private void _GoToFastBattle()
		{
		}

		// Token: 0x06023F34 RID: 147252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F34")]
		[Address(RVA = "0x1E9A530", Offset = "0x1E99130", VA = "0x181E9A530")]
		public CampaignZoneMapState()
		{
		}

		// Token: 0x06023F37 RID: 147255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F37")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023F38 RID: 147256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F38")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06023F39 RID: 147257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023F39")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04031E7A RID: 204410
		[Token(Token = "0x4031E7A")]
		[NonSerialized]
		public const int ON_STAGE_BTN_CLICKED = 0;

		// Token: 0x04031E7B RID: 204411
		[Token(Token = "0x4031E7B")]
		[NonSerialized]
		public const int ON_FAST_CAMP_INFO_CLICKED = 1;

		// Token: 0x04031E7C RID: 204412
		[Token(Token = "0x4031E7C")]
		[NonSerialized]
		public const int ON_AUTO_BATTLE_BTN_CLICKED = 2;

		// Token: 0x04031E7D RID: 204413
		[Token(Token = "0x4031E7D")]
		[NonSerialized]
		public const int ON_FAST_BATTLE_BTN_CLICKED = 3;

		// Token: 0x04031E7E RID: 204414
		[Token(Token = "0x4031E7E")]
		[NonSerialized]
		public const int ON_TRY_TRIGGER_FAST_CAMP_TUTORIAL = 4;

		// Token: 0x04031E7F RID: 204415
		[Token(Token = "0x4031E7F")]
		[NonSerialized]
		public const int ON_JUMP_BTN_CLICKED = 5;

		// Token: 0x04031E80 RID: 204416
		[Token(Token = "0x4031E80")]
		[NonSerialized]
		public const int ON_DROP_REWARD_BTN_CLICKED = 6;

		// Token: 0x04031E81 RID: 204417
		[Token(Token = "0x4031E81")]
		[NonSerialized]
		public const int ON_RULE_BTN_CLICKED = 7;

		// Token: 0x04031E82 RID: 204418
		[Token(Token = "0x4031E82")]
		[NonSerialized]
		public const int ON_ENEMY_BTN_CLICKED = 8;

		// Token: 0x04031E83 RID: 204419
		[Token(Token = "0x4031E83")]
		[NonSerialized]
		public const int ON_START_BATTLE_BTN_CLICKED = 9;

		// Token: 0x04031E84 RID: 204420
		[Token(Token = "0x4031E84")]
		[NonSerialized]
		public const int ON_MISSION_BTN_CLICKED = 10;

		// Token: 0x04031E85 RID: 204421
		[Token(Token = "0x4031E85")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _animIn;

		// Token: 0x04031E86 RID: 204422
		[Token(Token = "0x4031E86")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _animOut;

		// Token: 0x04031E87 RID: 204423
		[Token(Token = "0x4031E87")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _previewTopMenuContainer;

		// Token: 0x04031E88 RID: 204424
		[Token(Token = "0x4031E88")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04031E89 RID: 204425
		[Token(Token = "0x4031E89")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CampaignZoneSelectPreviewView _previewView;

		// Token: 0x04031E8A RID: 204426
		[Token(Token = "0x4031E8A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CampaignStagePreviewConfigController _previewConfigController;

		// Token: 0x04031E8B RID: 204427
		[Token(Token = "0x4031E8B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CampaignZoneMapView _mapView;

		// Token: 0x04031E8C RID: 204428
		[Token(Token = "0x4031E8C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CampaignZoneMapStageListView _stageListView;

		// Token: 0x04031E8D RID: 204429
		[Token(Token = "0x4031E8D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private PrefabInstHolder _campFeeHolder;

		// Token: 0x04031E8E RID: 204430
		[Token(Token = "0x4031E8E")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x04031E8F RID: 204431
		[Token(Token = "0x4031E8F")]
		[FieldOffset(Offset = "0xB0")]
		private CampaignZoneMapStateBean m_stateBean;

		// Token: 0x04031E90 RID: 204432
		[Token(Token = "0x4031E90")]
		[FieldOffset(Offset = "0xB8")]
		private CampaignFeeView m_campFeeView;

		// Token: 0x04031E91 RID: 204433
		[Token(Token = "0x4031E91")]
		[FieldOffset(Offset = "0xC0")]
		private CommonTopMenu m_topMenu;

		// Token: 0x04031E92 RID: 204434
		[Token(Token = "0x4031E92")]
		[FieldOffset(Offset = "0xC8")]
		private CommonTopMenu m_previewTopMenu;

		// Token: 0x04031E93 RID: 204435
		[Token(Token = "0x4031E93")]
		[FieldOffset(Offset = "0xD0")]
		private string m_cacheJumpStageId;

		// Token: 0x04031E94 RID: 204436
		[Token(Token = "0x4031E94")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_cacheIsToBreakingDetail;

		// Token: 0x04031E95 RID: 204437
		[Token(Token = "0x4031E95")]
		[FieldOffset(Offset = "0xE0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04031E96 RID: 204438
		[Token(Token = "0x4031E96")]
		[FieldOffset(Offset = "0xF0")]
		private int m_breakingDetailInstId;

		// Token: 0x04031E97 RID: 204439
		[Token(Token = "0x4031E97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04031E98 RID: 204440
		[Token(Token = "0x4031E98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04031E99 RID: 204441
		[Token(Token = "0x4031E99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04031E9A RID: 204442
		[Token(Token = "0x4031E9A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04031E9B RID: 204443
		[Token(Token = "0x4031E9B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToMissionState;

		// Token: 0x04031E9C RID: 204444
		[Token(Token = "0x4031E9C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpToCampaignRuleView;

		// Token: 0x04031E9D RID: 204445
		[Token(Token = "0x4031E9D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandBook;

		// Token: 0x04031E9E RID: 204446
		[Token(Token = "0x4031E9E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpToRewardDetailView;

		// Token: 0x04031E9F RID: 204447
		[Token(Token = "0x4031E9F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnJumpToFastCampState;

		// Token: 0x04031EA0 RID: 204448
		[Token(Token = "0x4031EA0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04031EA1 RID: 204449
		[Token(Token = "0x4031EA1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnStageClicked;

		// Token: 0x04031EA2 RID: 204450
		[Token(Token = "0x4031EA2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnFastCampInfoClicked;

		// Token: 0x04031EA3 RID: 204451
		[Token(Token = "0x4031EA3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnAutoBattleBtnClicked;

		// Token: 0x04031EA4 RID: 204452
		[Token(Token = "0x4031EA4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EventOnFastBattleBtnClicked;

		// Token: 0x04031EA5 RID: 204453
		[Token(Token = "0x4031EA5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EventOnTryTriggerFastCampTutorial;

		// Token: 0x04031EA6 RID: 204454
		[Token(Token = "0x4031EA6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnJumpBtnClicked;

		// Token: 0x04031EA7 RID: 204455
		[Token(Token = "0x4031EA7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnDropRewardBtnClicked;

		// Token: 0x04031EA8 RID: 204456
		[Token(Token = "0x4031EA8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EventOnRuleBtnClicked;

		// Token: 0x04031EA9 RID: 204457
		[Token(Token = "0x4031EA9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EventOnEnemyBtnClicked;

		// Token: 0x04031EAA RID: 204458
		[Token(Token = "0x4031EAA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__EventOnStartBattleBtnClicked;

		// Token: 0x04031EAB RID: 204459
		[Token(Token = "0x4031EAB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__EventOnMissionBtnClicked;

		// Token: 0x04031EAC RID: 204460
		[Token(Token = "0x4031EAC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04031EAD RID: 204461
		[Token(Token = "0x4031EAD")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031EAE RID: 204462
		[Token(Token = "0x4031EAE")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnPreviewBackBtnClicked;

		// Token: 0x04031EAF RID: 204463
		[Token(Token = "0x4031EAF")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x04031EB0 RID: 204464
		[Token(Token = "0x4031EB0")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnInitCampFee;

		// Token: 0x04031EB1 RID: 204465
		[Token(Token = "0x4031EB1")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__EventOnCampFeeClicked;

		// Token: 0x04031EB2 RID: 204466
		[Token(Token = "0x4031EB2")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__SwitchSelectStateCoroutine;

		// Token: 0x04031EB3 RID: 204467
		[Token(Token = "0x4031EB3")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnSwitchSelectStateEnd;

		// Token: 0x04031EB4 RID: 204468
		[Token(Token = "0x4031EB4")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CheckCostBeforeStartBattle;

		// Token: 0x04031EB5 RID: 204469
		[Token(Token = "0x4031EB5")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__CheckApBeforeStartBattle;

		// Token: 0x04031EB6 RID: 204470
		[Token(Token = "0x4031EB6")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__SaveCacheStageConfig;

		// Token: 0x04031EB7 RID: 204471
		[Token(Token = "0x4031EB7")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__GoToSquad;

		// Token: 0x04031EB8 RID: 204472
		[Token(Token = "0x4031EB8")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__CheckNeedToLoadBattleLog;

		// Token: 0x04031EB9 RID: 204473
		[Token(Token = "0x4031EB9")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__OnGoToSquad;

		// Token: 0x04031EBA RID: 204474
		[Token(Token = "0x4031EBA")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__GoToFastBattle;

		// Token: 0x04031EBB RID: 204475
		[Token(Token = "0x4031EBB")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
