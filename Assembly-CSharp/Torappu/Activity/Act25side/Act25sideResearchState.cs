using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074FE RID: 29950
	[Token(Token = "0x20074FE")]
	public class Act25sideResearchState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0602A360 RID: 172896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A360")]
		[Address(RVA = "0x25E5AD0", Offset = "0x25E46D0", VA = "0x1825E5AD0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A361 RID: 172897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A361")]
		[Address(RVA = "0x25E62C0", Offset = "0x25E4EC0", VA = "0x1825E62C0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602A362 RID: 172898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A362")]
		[Address(RVA = "0x25E5A70", Offset = "0x25E4670", VA = "0x1825E5A70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A363 RID: 172899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A363")]
		[Address(RVA = "0x25E64D0", Offset = "0x25E50D0", VA = "0x1825E64D0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602A364 RID: 172900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A364")]
		[Address(RVA = "0x25E8210", Offset = "0x25E6E10", VA = "0x1825E8210")]
		private void _OnEnterAddTokenState(IStateBean stateBean)
		{
		}

		// Token: 0x0602A365 RID: 172901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A365")]
		[Address(RVA = "0x25E8490", Offset = "0x25E7090", VA = "0x1825E8490")]
		private void _OnResearchConfirmState(IStateBean stateBean)
		{
		}

		// Token: 0x0602A366 RID: 172902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A366")]
		[Address(RVA = "0x25E8360", Offset = "0x25E6F60", VA = "0x1825E8360")]
		private void _OnHarvestState(IStateBean stateBean)
		{
		}

		// Token: 0x0602A367 RID: 172903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A367")]
		[Address(RVA = "0x25E8120", Offset = "0x25E6D20", VA = "0x1825E8120")]
		private void _OnCompleteMissionState(IStateBean stateBean)
		{
		}

		// Token: 0x0602A368 RID: 172904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A368")]
		[Address(RVA = "0x25E8860", Offset = "0x25E7460", VA = "0x1825E8860")]
		private void _OnUnlockArchiveState(IStateBean stateBean)
		{
		}

		// Token: 0x0602A369 RID: 172905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A369")]
		[Address(RVA = "0x25E8600", Offset = "0x25E7200", VA = "0x1825E8600")]
		private void _OnRewardState(IStateBean stateBean)
		{
		}

		// Token: 0x0602A36A RID: 172906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A36A")]
		[Address(RVA = "0x25E8770", Offset = "0x25E7370", VA = "0x1825E8770")]
		private void _OnTokenDetail(IStateBean stateBean)
		{
		}

		// Token: 0x0602A36B RID: 172907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A36B")]
		[Address(RVA = "0x25E7A40", Offset = "0x25E6640", VA = "0x1825E7A40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A36C RID: 172908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A36C")]
		[Address(RVA = "0x25E8070", Offset = "0x25E6C70", VA = "0x1825E8070")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x0602A36D RID: 172909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A36D")]
		[Address(RVA = "0x25E8EA0", Offset = "0x25E7AA0", VA = "0x1825E8EA0")]
		private void _UpdateProperty(bool isInit = false)
		{
		}

		// Token: 0x0602A36E RID: 172910 RVA: 0x000D7B08 File Offset: 0x000D5D08
		[Token(Token = "0x602A36E")]
		[Address(RVA = "0x25E7590", Offset = "0x25E6190", VA = "0x1825E7590")]
		private bool _HandlePopup(UIStateAutoPopupController.PopupItem item)
		{
			return default(bool);
		}

		// Token: 0x0602A36F RID: 172911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A36F")]
		[Address(RVA = "0x25E7890", Offset = "0x25E6490", VA = "0x1825E7890")]
		private void _InitControllerPopup(Act25sideDailyRefreshResponse response)
		{
		}

		// Token: 0x0602A370 RID: 172912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A370")]
		[Address(RVA = "0x25E8AA0", Offset = "0x25E76A0", VA = "0x1825E8AA0")]
		private void _ShowDailyAddCount()
		{
		}

		// Token: 0x0602A371 RID: 172913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A371")]
		[Address(RVA = "0x25E8A30", Offset = "0x25E7630", VA = "0x1825E8A30")]
		private void _ShowCompleteMission()
		{
		}

		// Token: 0x0602A372 RID: 172914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A372")]
		[Address(RVA = "0x25E8B80", Offset = "0x25E7780", VA = "0x1825E8B80")]
		private void _ShowUnlockArchive()
		{
		}

		// Token: 0x0602A373 RID: 172915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A373")]
		[Address(RVA = "0x25E8B10", Offset = "0x25E7710", VA = "0x1825E8B10")]
		private void _ShowDailyHarvest()
		{
		}

		// Token: 0x0602A374 RID: 172916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A374")]
		private void _AddTopState<PopState>() where PopState : State
		{
		}

		// Token: 0x0602A375 RID: 172917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A375")]
		[Address(RVA = "0x25E7990", Offset = "0x25E6590", VA = "0x1825E7990")]
		private IEnumerator _InitEnterCoroutine()
		{
			return null;
		}

		// Token: 0x0602A376 RID: 172918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A376")]
		[Address(RVA = "0x25E5BC0", Offset = "0x25E47C0", VA = "0x1825E5BC0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602A377 RID: 172919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A377")]
		[Address(RVA = "0x25E7520", Offset = "0x25E6120", VA = "0x1825E7520")]
		private void _EventOnShowReward()
		{
		}

		// Token: 0x0602A378 RID: 172920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A378")]
		[Address(RVA = "0x25E70E0", Offset = "0x25E5CE0", VA = "0x1825E70E0")]
		private void _EventOnItemSelect(string areaId)
		{
		}

		// Token: 0x0602A379 RID: 172921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A379")]
		[Address(RVA = "0x25E73B0", Offset = "0x25E5FB0", VA = "0x1825E73B0")]
		private void _EventOnRouteToStage(Act25sideResearchAreaView.RouteStageParam param)
		{
		}

		// Token: 0x0602A37A RID: 172922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A37A")]
		[Address(RVA = "0x25E6AA0", Offset = "0x25E56A0", VA = "0x1825E6AA0")]
		private void _EventOnAcceptMission()
		{
		}

		// Token: 0x0602A37B RID: 172923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A37B")]
		[Address(RVA = "0x25E7240", Offset = "0x25E5E40", VA = "0x1825E7240")]
		private void _EventOnOpenArchive()
		{
		}

		// Token: 0x0602A37C RID: 172924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A37C")]
		[Address(RVA = "0x25E6BC0", Offset = "0x25E57C0", VA = "0x1825E6BC0")]
		private void _EventOnCompleteMission()
		{
		}

		// Token: 0x0602A37D RID: 172925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A37D")]
		[Address(RVA = "0x25E8950", Offset = "0x25E7550", VA = "0x1825E8950")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x0602A37E RID: 172926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A37E")]
		[Address(RVA = "0x25E6F50", Offset = "0x25E5B50", VA = "0x1825E6F50")]
		private void _EventOnHarvestClick()
		{
		}

		// Token: 0x0602A37F RID: 172927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A37F")]
		[Address(RVA = "0x25E8BF0", Offset = "0x25E77F0", VA = "0x1825E8BF0")]
		private void _TryHarvest()
		{
		}

		// Token: 0x0602A380 RID: 172928 RVA: 0x000D7B20 File Offset: 0x000D5D20
		[Token(Token = "0x602A380")]
		[Address(RVA = "0x25E7790", Offset = "0x25E6390", VA = "0x1825E7790")]
		private bool _HarvestAvailable()
		{
			return default(bool);
		}

		// Token: 0x0602A381 RID: 172929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A381")]
		[Address(RVA = "0x25E6250", Offset = "0x25E4E50", VA = "0x1825E6250")]
		public void OnPageRoutedTriggerPopup()
		{
		}

		// Token: 0x0602A382 RID: 172930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A382")]
		[Address(RVA = "0x25E6460", Offset = "0x25E5060", VA = "0x1825E6460")]
		public void OnTokenDetailClick()
		{
		}

		// Token: 0x0602A383 RID: 172931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A383")]
		[Address(RVA = "0x25E9040", Offset = "0x25E7C40", VA = "0x1825E9040")]
		public Act25sideResearchState()
		{
		}

		// Token: 0x0602A387 RID: 172935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A387")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602A388 RID: 172936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A388")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602A389 RID: 172937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A389")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403CA83 RID: 248451
		[Token(Token = "0x403CA83")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act25sideResearchView _view;

		// Token: 0x0403CA84 RID: 248452
		[Token(Token = "0x403CA84")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403CA85 RID: 248453
		[Token(Token = "0x403CA85")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403CA86 RID: 248454
		[Token(Token = "0x403CA86")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Act25sideHarvestButtonView _btnView;

		// Token: 0x0403CA87 RID: 248455
		[Token(Token = "0x403CA87")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0403CA88 RID: 248456
		[Token(Token = "0x403CA88")]
		[NonSerialized]
		public const int MSG_ITEM_SELECT = 1;

		// Token: 0x0403CA89 RID: 248457
		[Token(Token = "0x403CA89")]
		[NonSerialized]
		public const int MSG_ROUTE_STAGE = 2;

		// Token: 0x0403CA8A RID: 248458
		[Token(Token = "0x403CA8A")]
		[NonSerialized]
		public const int MSG_ACCEPT_MISSION = 3;

		// Token: 0x0403CA8B RID: 248459
		[Token(Token = "0x403CA8B")]
		[NonSerialized]
		public const int MSG_COMPLETE_MISSION = 4;

		// Token: 0x0403CA8C RID: 248460
		[Token(Token = "0x403CA8C")]
		[NonSerialized]
		public const int MSG_OPEN_ARCHIVE = 5;

		// Token: 0x0403CA8D RID: 248461
		[Token(Token = "0x403CA8D")]
		[NonSerialized]
		public const int MSG_SHOW_REWARD = 6;

		// Token: 0x0403CA8E RID: 248462
		[Token(Token = "0x403CA8E")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0403CA8F RID: 248463
		[Token(Token = "0x403CA8F")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_hasPlayedEnterAnim;

		// Token: 0x0403CA90 RID: 248464
		[Token(Token = "0x403CA90")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cachedActId;

		// Token: 0x0403CA91 RID: 248465
		[Token(Token = "0x403CA91")]
		[FieldOffset(Offset = "0xB0")]
		private Act25sideResearchPage m_page;

		// Token: 0x0403CA92 RID: 248466
		[Token(Token = "0x403CA92")]
		[FieldOffset(Offset = "0xB8")]
		private Act25sideResearchStateBean m_stateBean;

		// Token: 0x0403CA93 RID: 248467
		[Token(Token = "0x403CA93")]
		[FieldOffset(Offset = "0xC0")]
		private Act25sideDailyHarvestStateBean m_harvestBean;

		// Token: 0x0403CA94 RID: 248468
		[Token(Token = "0x403CA94")]
		[FieldOffset(Offset = "0xC8")]
		private Act25sideResearchState.Act25sideResearchPopupController m_popupController;

		// Token: 0x0403CA95 RID: 248469
		[Token(Token = "0x403CA95")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_enterAnimTween;

		// Token: 0x0403CA96 RID: 248470
		[Token(Token = "0x403CA96")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403CA97 RID: 248471
		[Token(Token = "0x403CA97")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403CA98 RID: 248472
		[Token(Token = "0x403CA98")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403CA99 RID: 248473
		[Token(Token = "0x403CA99")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403CA9A RID: 248474
		[Token(Token = "0x403CA9A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnEnterAddTokenState;

		// Token: 0x0403CA9B RID: 248475
		[Token(Token = "0x403CA9B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnResearchConfirmState;

		// Token: 0x0403CA9C RID: 248476
		[Token(Token = "0x403CA9C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnHarvestState;

		// Token: 0x0403CA9D RID: 248477
		[Token(Token = "0x403CA9D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnCompleteMissionState;

		// Token: 0x0403CA9E RID: 248478
		[Token(Token = "0x403CA9E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnUnlockArchiveState;

		// Token: 0x0403CA9F RID: 248479
		[Token(Token = "0x403CA9F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnRewardState;

		// Token: 0x0403CAA0 RID: 248480
		[Token(Token = "0x403CAA0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnTokenDetail;

		// Token: 0x0403CAA1 RID: 248481
		[Token(Token = "0x403CAA1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CAA2 RID: 248482
		[Token(Token = "0x403CAA2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x0403CAA3 RID: 248483
		[Token(Token = "0x403CAA3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateProperty;

		// Token: 0x0403CAA4 RID: 248484
		[Token(Token = "0x403CAA4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__HandlePopup;

		// Token: 0x0403CAA5 RID: 248485
		[Token(Token = "0x403CAA5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitControllerPopup;

		// Token: 0x0403CAA6 RID: 248486
		[Token(Token = "0x403CAA6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ShowDailyAddCount;

		// Token: 0x0403CAA7 RID: 248487
		[Token(Token = "0x403CAA7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ShowCompleteMission;

		// Token: 0x0403CAA8 RID: 248488
		[Token(Token = "0x403CAA8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ShowUnlockArchive;

		// Token: 0x0403CAA9 RID: 248489
		[Token(Token = "0x403CAA9")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ShowDailyHarvest;

		// Token: 0x0403CAAA RID: 248490
		[Token(Token = "0x403CAAA")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__AddTopState;

		// Token: 0x0403CAAB RID: 248491
		[Token(Token = "0x403CAAB")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__InitEnterCoroutine;

		// Token: 0x0403CAAC RID: 248492
		[Token(Token = "0x403CAAC")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403CAAD RID: 248493
		[Token(Token = "0x403CAAD")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__EventOnShowReward;

		// Token: 0x0403CAAE RID: 248494
		[Token(Token = "0x403CAAE")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__EventOnItemSelect;

		// Token: 0x0403CAAF RID: 248495
		[Token(Token = "0x403CAAF")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__EventOnRouteToStage;

		// Token: 0x0403CAB0 RID: 248496
		[Token(Token = "0x403CAB0")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__EventOnAcceptMission;

		// Token: 0x0403CAB1 RID: 248497
		[Token(Token = "0x403CAB1")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__EventOnOpenArchive;

		// Token: 0x0403CAB2 RID: 248498
		[Token(Token = "0x403CAB2")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__EventOnCompleteMission;

		// Token: 0x0403CAB3 RID: 248499
		[Token(Token = "0x403CAB3")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403CAB4 RID: 248500
		[Token(Token = "0x403CAB4")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__EventOnHarvestClick;

		// Token: 0x0403CAB5 RID: 248501
		[Token(Token = "0x403CAB5")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__TryHarvest;

		// Token: 0x0403CAB6 RID: 248502
		[Token(Token = "0x403CAB6")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__HarvestAvailable;

		// Token: 0x0403CAB7 RID: 248503
		[Token(Token = "0x403CAB7")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnPageRoutedTriggerPopup;

		// Token: 0x0403CAB8 RID: 248504
		[Token(Token = "0x403CAB8")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnTokenDetailClick;

		// Token: 0x0403CAB9 RID: 248505
		[Token(Token = "0x403CAB9")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020074FF RID: 29951
		[Token(Token = "0x20074FF")]
		private class Act25sideResearchPopupController : UIStateAutoPopupController
		{
			// Token: 0x0602A38A RID: 172938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A38A")]
			[Address(RVA = "0x25E4BF0", Offset = "0x25E37F0", VA = "0x1825E4BF0")]
			public Act25sideResearchPopupController(Act25sideResearchState closure)
			{
			}

			// Token: 0x0602A38B RID: 172939 RVA: 0x000D7B38 File Offset: 0x000D5D38
			[Token(Token = "0x602A38B")]
			[Address(RVA = "0x25E4800", Offset = "0x25E3400", VA = "0x1825E4800", Slot = "4")]
			protected override bool IsStableEnvironment()
			{
				return default(bool);
			}

			// Token: 0x0602A38C RID: 172940 RVA: 0x000D7B50 File Offset: 0x000D5D50
			[Token(Token = "0x602A38C")]
			[Address(RVA = "0x25E4A80", Offset = "0x25E3680", VA = "0x1825E4A80")]
			private bool _CheckIsInitState()
			{
				return default(bool);
			}

			// Token: 0x0403CABA RID: 248506
			[Token(Token = "0x403CABA")]
			[FieldOffset(Offset = "0x20")]
			private Act25sideResearchState m_closure;

			// Token: 0x0403CABB RID: 248507
			[Token(Token = "0x403CABB")]
			public const int ADD_TOKEM = 0;

			// Token: 0x0403CABC RID: 248508
			[Token(Token = "0x403CABC")]
			public const int GAIN_ITEM = 1;

			// Token: 0x0403CABD RID: 248509
			[Token(Token = "0x403CABD")]
			public const int COMPLETE_MISSION = 2;

			// Token: 0x0403CABE RID: 248510
			[Token(Token = "0x403CABE")]
			public const int UNLOCK_ARCHIVE = 3;

			// Token: 0x0403CABF RID: 248511
			[Token(Token = "0x403CABF")]
			public const int ABLE_HARVEST = 4;

			// Token: 0x0403CAC0 RID: 248512
			[Token(Token = "0x403CAC0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403CAC1 RID: 248513
			[Token(Token = "0x403CAC1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsStableEnvironment;

			// Token: 0x0403CAC2 RID: 248514
			[Token(Token = "0x403CAC2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__CheckIsInitState;
		}
	}
}
