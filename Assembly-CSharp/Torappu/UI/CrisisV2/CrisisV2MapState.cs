using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005943 RID: 22851
	[Token(Token = "0x2005943")]
	public class CrisisV2MapState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x060214AF RID: 136367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60214AF")]
		[Address(RVA = "0x1BB0EA0", Offset = "0x1BAFAA0", VA = "0x181BB0EA0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060214B0 RID: 136368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214B0")]
		[Address(RVA = "0x1BB0F00", Offset = "0x1BAFB00", VA = "0x181BB0F00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060214B1 RID: 136369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214B1")]
		[Address(RVA = "0x1BB1F30", Offset = "0x1BB0B30", VA = "0x181BB1F30", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060214B2 RID: 136370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214B2")]
		[Address(RVA = "0x1BB7260", Offset = "0x1BB5E60", VA = "0x181BB7260")]
		private void _UpdatePreviewIfNeed(CrisisV2MapModel mapModel)
		{
		}

		// Token: 0x060214B3 RID: 136371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214B3")]
		[Address(RVA = "0x1BB4EB0", Offset = "0x1BB3AB0", VA = "0x181BB4EB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060214B4 RID: 136372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214B4")]
		[Address(RVA = "0x1BB6250", Offset = "0x1BB4E50", VA = "0x181BB6250")]
		private void _TriggerTutorialAVG()
		{
		}

		// Token: 0x060214B5 RID: 136373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214B5")]
		[Address(RVA = "0x1BB6500", Offset = "0x1BB5100", VA = "0x181BB6500")]
		private void _TryConsumeGuidebook([Optional] Story story)
		{
		}

		// Token: 0x060214B6 RID: 136374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214B6")]
		[Address(RVA = "0x1BB5F30", Offset = "0x1BB4B30", VA = "0x181BB5F30")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x060214B7 RID: 136375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214B7")]
		[Address(RVA = "0x1BB2770", Offset = "0x1BB1370", VA = "0x181BB2770")]
		private void _EventOnBack()
		{
		}

		// Token: 0x060214B8 RID: 136376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214B8")]
		[Address(RVA = "0x1BB4600", Offset = "0x1BB3200", VA = "0x181BB4600")]
		private void _EventOnTopMenuRouted(UIRouteTarget routeTarget, object param, Action<UIRouteTarget, object> baseHandler)
		{
		}

		// Token: 0x060214B9 RID: 136377 RVA: 0x000B9430 File Offset: 0x000B7630
		[Token(Token = "0x60214B9")]
		[Address(RVA = "0x1BB6CF0", Offset = "0x1BB58F0", VA = "0x181BB6CF0")]
		private int _TutorialOnly_FocusToSlot(CrisisV2MapAVGAdapter.FocusSlotType slotType)
		{
			return 0;
		}

		// Token: 0x060214BA RID: 136378 RVA: 0x000B9448 File Offset: 0x000B7648
		[Token(Token = "0x60214BA")]
		[Address(RVA = "0x1BB70B0", Offset = "0x1BB5CB0", VA = "0x181BB70B0")]
		private int _TutorialOnly_SwitchMapType(CrisisV2MapAVGAdapter.MapType mapType)
		{
			return 0;
		}

		// Token: 0x060214BB RID: 136379 RVA: 0x000B9460 File Offset: 0x000B7660
		[Token(Token = "0x60214BB")]
		[Address(RVA = "0x1BB6F80", Offset = "0x1BB5B80", VA = "0x181BB6F80")]
		private int _TutorialOnly_HidePreview()
		{
			return 0;
		}

		// Token: 0x060214BC RID: 136380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214BC")]
		[Address(RVA = "0x1BB10A0", Offset = "0x1BAFCA0", VA = "0x181BB10A0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060214BD RID: 136381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214BD")]
		[Address(RVA = "0x1BB2E70", Offset = "0x1BB1A70", VA = "0x181BB2E70")]
		private void _EventOnBtnDimensionClick()
		{
		}

		// Token: 0x060214BE RID: 136382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214BE")]
		[Address(RVA = "0x1BB3C00", Offset = "0x1BB2800", VA = "0x181BB3C00")]
		private void _EventOnOpenBagDetail(string bagId)
		{
		}

		// Token: 0x060214BF RID: 136383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214BF")]
		[Address(RVA = "0x1BB3B50", Offset = "0x1BB2750", VA = "0x181BB3B50")]
		private void _EventOnOpenAchieve()
		{
		}

		// Token: 0x060214C0 RID: 136384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214C0")]
		[Address(RVA = "0x1BB4140", Offset = "0x1BB2D40", VA = "0x181BB4140")]
		private void _EventOnSkinPreview(string nodeId)
		{
		}

		// Token: 0x060214C1 RID: 136385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214C1")]
		[Address(RVA = "0x1BB4390", Offset = "0x1BB2F90", VA = "0x181BB4390")]
		private void _EventOnSwitchViewType()
		{
		}

		// Token: 0x060214C2 RID: 136386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214C2")]
		[Address(RVA = "0x1BB3040", Offset = "0x1BB1C40", VA = "0x181BB3040")]
		private void _EventOnClearAllNode()
		{
		}

		// Token: 0x060214C3 RID: 136387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214C3")]
		[Address(RVA = "0x1BB2920", Offset = "0x1BB1520", VA = "0x181BB2920")]
		private void _EventOnBagClick(string bagId)
		{
		}

		// Token: 0x060214C4 RID: 136388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214C4")]
		[Address(RVA = "0x1BB36B0", Offset = "0x1BB22B0", VA = "0x181BB36B0")]
		private void _EventOnNodeClick(string nodeId)
		{
		}

		// Token: 0x060214C5 RID: 136389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214C5")]
		[Address(RVA = "0x1BB3190", Offset = "0x1BB1D90", VA = "0x181BB3190")]
		private void _EventOnClosePreview()
		{
		}

		// Token: 0x060214C6 RID: 136390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214C6")]
		[Address(RVA = "0x1BB3FC0", Offset = "0x1BB2BC0", VA = "0x181BB3FC0")]
		private void _EventOnPreviewSlotClick(object msgObj)
		{
		}

		// Token: 0x060214C7 RID: 136391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214C7")]
		[Address(RVA = "0x1BB57D0", Offset = "0x1BB43D0", VA = "0x181BB57D0")]
		private void _OnNormalNodeClick(CrisisV2MapModel mapModel, CrisisV2MapNodeModel nodeModel)
		{
		}

		// Token: 0x060214C8 RID: 136392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214C8")]
		[Address(RVA = "0x1BB55D0", Offset = "0x1BB41D0", VA = "0x181BB55D0")]
		private void _OnKeypointNodeClick(CrisisV2MapModel mapModel, CrisisV2MapNodeModel nodeModel)
		{
		}

		// Token: 0x060214C9 RID: 136393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214C9")]
		[Address(RVA = "0x1BB5C50", Offset = "0x1BB4850", VA = "0x181BB5C50")]
		private void _OnTreasureNodeClick(CrisisV2MapModel mapModel, CrisisV2MapNodeModel nodeModel)
		{
		}

		// Token: 0x060214CA RID: 136394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214CA")]
		[Address(RVA = "0x1BB4AE0", Offset = "0x1BB36E0", VA = "0x181BB4AE0")]
		private void _GainReward(CrisisV2MapModel mapModel, string nodeId, CrisisV2MissionType missionType)
		{
		}

		// Token: 0x060214CB RID: 136395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214CB")]
		[Address(RVA = "0x1BB60B0", Offset = "0x1BB4CB0", VA = "0x181BB60B0")]
		private void _ShowGainItems(List<RewardItemModel> rewardList, Action onConfirm)
		{
		}

		// Token: 0x060214CC RID: 136396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60214CC")]
		[Address(RVA = "0x1BB5E50", Offset = "0x1BB4A50", VA = "0x181BB5E50")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x060214CD RID: 136397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214CD")]
		[Address(RVA = "0x1BB4900", Offset = "0x1BB3500", VA = "0x181BB4900")]
		private void _EventRuneDetailSlotItemClickEvent(string slotId)
		{
		}

		// Token: 0x060214CE RID: 136398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214CE")]
		[Address(RVA = "0x1BB4720", Offset = "0x1BB3320", VA = "0x181BB4720")]
		private void _EventRuneDetailPackItemClickEvent(string bagId)
		{
		}

		// Token: 0x060214CF RID: 136399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214CF")]
		[Address(RVA = "0x1BB34E0", Offset = "0x1BB20E0", VA = "0x181BB34E0")]
		private void _EventOnJumpComplete(int seqNum)
		{
		}

		// Token: 0x060214D0 RID: 136400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214D0")]
		[Address(RVA = "0x1BB3570", Offset = "0x1BB2170", VA = "0x181BB3570")]
		private void _EventOnMapSwitchComplete()
		{
		}

		// Token: 0x060214D1 RID: 136401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214D1")]
		[Address(RVA = "0x1BB3390", Offset = "0x1BB1F90", VA = "0x181BB3390")]
		private void _EventOnHidePreviewComplete()
		{
		}

		// Token: 0x060214D2 RID: 136402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214D2")]
		[Address(RVA = "0x1BB3D40", Offset = "0x1BB2940", VA = "0x181BB3D40")]
		private void _EventOnOpenMissionState()
		{
		}

		// Token: 0x060214D3 RID: 136403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214D3")]
		[Address(RVA = "0x1BB3E80", Offset = "0x1BB2A80", VA = "0x181BB3E80")]
		private void _EventOnOpenStageDetailState()
		{
		}

		// Token: 0x060214D4 RID: 136404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214D4")]
		[Address(RVA = "0x1BB0E40", Offset = "0x1BAFA40", VA = "0x181BB0E40")]
		public void EventOnStartBattleClick()
		{
		}

		// Token: 0x060214D5 RID: 136405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214D5")]
		[Address(RVA = "0x1BB65C0", Offset = "0x1BB51C0", VA = "0x181BB65C0")]
		private void _TryJumpToCrisisSquadPage()
		{
		}

		// Token: 0x060214D6 RID: 136406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60214D6")]
		[Address(RVA = "0x1BB23C0", Offset = "0x1BB0FC0", VA = "0x181BB23C0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060214D7 RID: 136407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214D7")]
		[Address(RVA = "0x1BB2590", Offset = "0x1BB1190", VA = "0x181BB2590")]
		private void _DataToMissionState(IStateBean stateBean)
		{
		}

		// Token: 0x060214D8 RID: 136408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214D8")]
		[Address(RVA = "0x1BB2680", Offset = "0x1BB1280", VA = "0x181BB2680")]
		private void _DataToStageDetailState(IStateBean stateBean)
		{
		}

		// Token: 0x060214D9 RID: 136409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214D9")]
		[Address(RVA = "0x1BB73E0", Offset = "0x1BB5FE0", VA = "0x181BB73E0")]
		public CrisisV2MapState()
		{
		}

		// Token: 0x060214DA RID: 136410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214DA")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060214DB RID: 136411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214DB")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060214DC RID: 136412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60214DC")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402D64D RID: 185933
		[Token(Token = "0x402D64D")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "map";

		// Token: 0x0402D64E RID: 185934
		[Token(Token = "0x402D64E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0402D64F RID: 185935
		[Token(Token = "0x402D64F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CrisisV2RuneDetailView _runeDetailViewPrefab;

		// Token: 0x0402D650 RID: 185936
		[Token(Token = "0x402D650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _runeDetailViewContainer;

		// Token: 0x0402D651 RID: 185937
		[Token(Token = "0x402D651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CrisisV2SlotDetailMapView _slotDetailMapViewPrefab;

		// Token: 0x0402D652 RID: 185938
		[Token(Token = "0x402D652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _slotDetaiMapContainer;

		// Token: 0x0402D653 RID: 185939
		[Token(Token = "0x402D653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CrisisV2BagDetailMapView _bagDetailMapViewPrefab;

		// Token: 0x0402D654 RID: 185940
		[Token(Token = "0x402D654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _bagDetailMapContainer;

		// Token: 0x0402D655 RID: 185941
		[Token(Token = "0x402D655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CrisisV2MapButtonView _mapButtonView;

		// Token: 0x0402D656 RID: 185942
		[Token(Token = "0x402D656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CrisisV2NodeTipsView _nodeTipsPrefab;

		// Token: 0x0402D657 RID: 185943
		[Token(Token = "0x402D657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RectTransform _nodeTipsContainer;

		// Token: 0x0402D658 RID: 185944
		[Token(Token = "0x402D658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CrisisV2MapAVGAdapter _avgAdapter;

		// Token: 0x0402D659 RID: 185945
		[Token(Token = "0x402D659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _panelBtnStart;

		// Token: 0x0402D65A RID: 185946
		[Token(Token = "0x402D65A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private CrisisV2MapNodePreviewView _previewViewPrefab;

		// Token: 0x0402D65B RID: 185947
		[Token(Token = "0x402D65B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private RectTransform _previewViewContainer;

		// Token: 0x0402D65C RID: 185948
		[Token(Token = "0x402D65C")]
		[NonSerialized]
		public const int MSG_NODE_CLICK = 1;

		// Token: 0x0402D65D RID: 185949
		[Token(Token = "0x402D65D")]
		[NonSerialized]
		public const int MSG_CLEAR_ALL_NODE = 2;

		// Token: 0x0402D65E RID: 185950
		[Token(Token = "0x402D65E")]
		[NonSerialized]
		public const int MSG_SWITCH_VIEW = 3;

		// Token: 0x0402D65F RID: 185951
		[Token(Token = "0x402D65F")]
		[NonSerialized]
		public const int MSG_BAG_CLICK = 4;

		// Token: 0x0402D660 RID: 185952
		[Token(Token = "0x402D660")]
		[NonSerialized]
		public const int MSG_RUNE_DETAIL_SLOT_ITEM_CLICK = 5;

		// Token: 0x0402D661 RID: 185953
		[Token(Token = "0x402D661")]
		[NonSerialized]
		public const int MSG_RUNE_DETAIL_PACK_ITEM_CLICK = 6;

		// Token: 0x0402D662 RID: 185954
		[Token(Token = "0x402D662")]
		[NonSerialized]
		public const int MSG_ON_JUMP_COMPLETE = 7;

		// Token: 0x0402D663 RID: 185955
		[Token(Token = "0x402D663")]
		[NonSerialized]
		public const int MSG_ON_MAP_SWITCH_COMPLETE = 8;

		// Token: 0x0402D664 RID: 185956
		[Token(Token = "0x402D664")]
		[NonSerialized]
		public const int MSG_OPEN_MISSION_STATE = 9;

		// Token: 0x0402D665 RID: 185957
		[Token(Token = "0x402D665")]
		[NonSerialized]
		public const int MSG_OPEN_STAGE_DETAIL_STATE = 10;

		// Token: 0x0402D666 RID: 185958
		[Token(Token = "0x402D666")]
		[NonSerialized]
		public const int MSG_SKIN_PREVIEW = 11;

		// Token: 0x0402D667 RID: 185959
		[Token(Token = "0x402D667")]
		[NonSerialized]
		public const int MSG_OPEN_ACHIEVE = 12;

		// Token: 0x0402D668 RID: 185960
		[Token(Token = "0x402D668")]
		[NonSerialized]
		public const int MSG_OPEN_BAG_DETAIL = 13;

		// Token: 0x0402D669 RID: 185961
		[Token(Token = "0x402D669")]
		[NonSerialized]
		public const int MSG_CLOSE_PREVIEW = 14;

		// Token: 0x0402D66A RID: 185962
		[Token(Token = "0x402D66A")]
		[NonSerialized]
		public const int MSG_PREVIEW_SLOT_CLICKED = 15;

		// Token: 0x0402D66B RID: 185963
		[Token(Token = "0x402D66B")]
		[NonSerialized]
		public const int MSG_ON_HIDE_PREVIEW_COMPLETE = 16;

		// Token: 0x0402D66C RID: 185964
		[Token(Token = "0x402D66C")]
		[NonSerialized]
		public const int MSG_DIMENSION_BTN_CLICK = 17;

		// Token: 0x0402D66D RID: 185965
		[Token(Token = "0x402D66D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool m_hasIntied;

		// Token: 0x0402D66E RID: 185966
		[Token(Token = "0x402D66E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0402D66F RID: 185967
		[Token(Token = "0x402D66F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private CrisisV2RuneDetailView m_runeDetailView;

		// Token: 0x0402D670 RID: 185968
		[Token(Token = "0x402D670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private CrisisV2SlotDetailMapView m_slotDetailMapView;

		// Token: 0x0402D671 RID: 185969
		[Token(Token = "0x402D671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private CrisisV2BagDetailMapView m_bagDetailMapView;

		// Token: 0x0402D672 RID: 185970
		[Token(Token = "0x402D672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private CrisisV2NodeTipsView m_nodeTipsView;

		// Token: 0x0402D673 RID: 185971
		[Token(Token = "0x402D673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private CrisisV2MapNodePreviewView m_previewView;

		// Token: 0x0402D674 RID: 185972
		[Token(Token = "0x402D674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private CrisisV2MapStateBean m_stateBean;

		// Token: 0x0402D675 RID: 185973
		[Token(Token = "0x402D675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402D676 RID: 185974
		[Token(Token = "0x402D676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402D677 RID: 185975
		[Token(Token = "0x402D677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402D678 RID: 185976
		[Token(Token = "0x402D678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdatePreviewIfNeed;

		// Token: 0x0402D679 RID: 185977
		[Token(Token = "0x402D679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D67A RID: 185978
		[Token(Token = "0x402D67A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TriggerTutorialAVG;

		// Token: 0x0402D67B RID: 185979
		[Token(Token = "0x402D67B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x0402D67C RID: 185980
		[Token(Token = "0x402D67C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x0402D67D RID: 185981
		[Token(Token = "0x402D67D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnBack;

		// Token: 0x0402D67E RID: 185982
		[Token(Token = "0x402D67E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnTopMenuRouted;

		// Token: 0x0402D67F RID: 185983
		[Token(Token = "0x402D67F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TutorialOnly_FocusToSlot;

		// Token: 0x0402D680 RID: 185984
		[Token(Token = "0x402D680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TutorialOnly_SwitchMapType;

		// Token: 0x0402D681 RID: 185985
		[Token(Token = "0x402D681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TutorialOnly_HidePreview;

		// Token: 0x0402D682 RID: 185986
		[Token(Token = "0x402D682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402D683 RID: 185987
		[Token(Token = "0x402D683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EventOnBtnDimensionClick;

		// Token: 0x0402D684 RID: 185988
		[Token(Token = "0x402D684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnOpenBagDetail;

		// Token: 0x0402D685 RID: 185989
		[Token(Token = "0x402D685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnOpenAchieve;

		// Token: 0x0402D686 RID: 185990
		[Token(Token = "0x402D686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EventOnSkinPreview;

		// Token: 0x0402D687 RID: 185991
		[Token(Token = "0x402D687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EventOnSwitchViewType;

		// Token: 0x0402D688 RID: 185992
		[Token(Token = "0x402D688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__EventOnClearAllNode;

		// Token: 0x0402D689 RID: 185993
		[Token(Token = "0x402D689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__EventOnBagClick;

		// Token: 0x0402D68A RID: 185994
		[Token(Token = "0x402D68A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__EventOnNodeClick;

		// Token: 0x0402D68B RID: 185995
		[Token(Token = "0x402D68B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__EventOnClosePreview;

		// Token: 0x0402D68C RID: 185996
		[Token(Token = "0x402D68C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__EventOnPreviewSlotClick;

		// Token: 0x0402D68D RID: 185997
		[Token(Token = "0x402D68D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnNormalNodeClick;

		// Token: 0x0402D68E RID: 185998
		[Token(Token = "0x402D68E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnKeypointNodeClick;

		// Token: 0x0402D68F RID: 185999
		[Token(Token = "0x402D68F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnTreasureNodeClick;

		// Token: 0x0402D690 RID: 186000
		[Token(Token = "0x402D690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__GainReward;

		// Token: 0x0402D691 RID: 186001
		[Token(Token = "0x402D691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ShowGainItems;

		// Token: 0x0402D692 RID: 186002
		[Token(Token = "0x402D692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0402D693 RID: 186003
		[Token(Token = "0x402D693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__EventRuneDetailSlotItemClickEvent;

		// Token: 0x0402D694 RID: 186004
		[Token(Token = "0x402D694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__EventRuneDetailPackItemClickEvent;

		// Token: 0x0402D695 RID: 186005
		[Token(Token = "0x402D695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__EventOnJumpComplete;

		// Token: 0x0402D696 RID: 186006
		[Token(Token = "0x402D696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__EventOnMapSwitchComplete;

		// Token: 0x0402D697 RID: 186007
		[Token(Token = "0x402D697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__EventOnHidePreviewComplete;

		// Token: 0x0402D698 RID: 186008
		[Token(Token = "0x402D698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__EventOnOpenMissionState;

		// Token: 0x0402D699 RID: 186009
		[Token(Token = "0x402D699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__EventOnOpenStageDetailState;

		// Token: 0x0402D69A RID: 186010
		[Token(Token = "0x402D69A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_EventOnStartBattleClick;

		// Token: 0x0402D69B RID: 186011
		[Token(Token = "0x402D69B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__TryJumpToCrisisSquadPage;

		// Token: 0x0402D69C RID: 186012
		[Token(Token = "0x402D69C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402D69D RID: 186013
		[Token(Token = "0x402D69D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__DataToMissionState;

		// Token: 0x0402D69E RID: 186014
		[Token(Token = "0x402D69E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__DataToStageDetailState;

		// Token: 0x0402D69F RID: 186015
		[Token(Token = "0x402D69F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
