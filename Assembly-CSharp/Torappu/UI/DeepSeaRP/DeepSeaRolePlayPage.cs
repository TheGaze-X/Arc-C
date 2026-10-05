using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200511C RID: 20764
	[Token(Token = "0x200511C")]
	public class DeepSeaRolePlayPage : StateEnginePage
	{
		// Token: 0x17004774 RID: 18292
		// (get) Token: 0x0601EA9C RID: 125596 RVA: 0x000AF308 File Offset: 0x000AD508
		[Token(Token = "0x17004774")]
		public bool isRetro
		{
			[Token(Token = "0x601EA9C")]
			[Address(RVA = "0x1860050", Offset = "0x185EC50", VA = "0x181860050")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004775 RID: 18293
		// (get) Token: 0x0601EA9D RID: 125597 RVA: 0x000AF320 File Offset: 0x000AD520
		[Token(Token = "0x17004775")]
		public bool isTechTreeNodesAllLock
		{
			[Token(Token = "0x601EA9D")]
			[Address(RVA = "0x18600E0", Offset = "0x185ECE0", VA = "0x1818600E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004776 RID: 18294
		// (get) Token: 0x0601EA9E RID: 125598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004776")]
		public string selectedZoneId
		{
			[Token(Token = "0x601EA9E")]
			[Address(RVA = "0x1860240", Offset = "0x185EE40", VA = "0x181860240")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004777 RID: 18295
		// (get) Token: 0x0601EA9F RID: 125599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004777")]
		public string selectedPlaceId
		{
			[Token(Token = "0x601EA9F")]
			[Address(RVA = "0x18601B0", Offset = "0x185EDB0", VA = "0x1818601B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004778 RID: 18296
		// (get) Token: 0x0601EAA0 RID: 125600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004778")]
		public string groupId
		{
			[Token(Token = "0x601EAA0")]
			[Address(RVA = "0x185FFC0", Offset = "0x185EBC0", VA = "0x18185FFC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004779 RID: 18297
		// (get) Token: 0x0601EAA1 RID: 125601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004779")]
		public List<DeepSeaRPZoneMapModel> zoneMapModelList
		{
			[Token(Token = "0x601EAA1")]
			[Address(RVA = "0x18602D0", Offset = "0x185EED0", VA = "0x1818602D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EAA2 RID: 125602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAA2")]
		[Address(RVA = "0x185BEF0", Offset = "0x185AAF0", VA = "0x18185BEF0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0601EAA3 RID: 125603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EAA3")]
		[Address(RVA = "0x185B6F0", Offset = "0x185A2F0", VA = "0x18185B6F0", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0601EAA4 RID: 125604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EAA4")]
		[Address(RVA = "0x185B630", Offset = "0x185A230", VA = "0x18185B630", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0601EAA5 RID: 125605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAA5")]
		[Address(RVA = "0x185B570", Offset = "0x185A170", VA = "0x18185B570", Slot = "23")]
		public override void DisplayWholePage(bool isShow)
		{
		}

		// Token: 0x0601EAA6 RID: 125606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EAA6")]
		[Address(RVA = "0x185BE40", Offset = "0x185AA40", VA = "0x18185BE40", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601EAA7 RID: 125607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAA7")]
		[Address(RVA = "0x185C320", Offset = "0x185AF20", VA = "0x18185C320")]
		public void StartAvgAndBackToDeepSea(StoryData targetStory, string placeId, bool showNodeDetail)
		{
		}

		// Token: 0x0601EAA8 RID: 125608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAA8")]
		[Address(RVA = "0x185E540", Offset = "0x185D140", VA = "0x18185E540")]
		private void _InitDeepSeaProp()
		{
		}

		// Token: 0x0601EAA9 RID: 125609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAA9")]
		[Address(RVA = "0x185EB60", Offset = "0x185D760", VA = "0x18185EB60")]
		private void _InitMapBar()
		{
		}

		// Token: 0x0601EAAA RID: 125610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EAAA")]
		[Address(RVA = "0x185E300", Offset = "0x185CF00", VA = "0x18185E300")]
		private IEnumerator _AddBattlePreviewState()
		{
			return null;
		}

		// Token: 0x0601EAAB RID: 125611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAAB")]
		[Address(RVA = "0x185E790", Offset = "0x185D390", VA = "0x18185E790")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601EAAC RID: 125612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EAAC")]
		[Address(RVA = "0x185E3B0", Offset = "0x185CFB0", VA = "0x18185E3B0")]
		private CommonTopMenu _CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0601EAAD RID: 125613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAAD")]
		[Address(RVA = "0x185F230", Offset = "0x185DE30", VA = "0x18185F230")]
		private void _OnBackAction()
		{
		}

		// Token: 0x0601EAAE RID: 125614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EAAE")]
		[Address(RVA = "0x185B840", Offset = "0x185A440", VA = "0x18185B840")]
		public static List<UIPageStackParam.StackElement> GenPageStackToJumpBack(DataBundle stageBundle, DeepSeaRolePlayPage.Params param)
		{
			return null;
		}

		// Token: 0x0601EAAF RID: 125615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAAF")]
		[Address(RVA = "0x185C010", Offset = "0x185AC10", VA = "0x18185C010")]
		public static void SaveParamToBundle(DeepSeaRolePlayPage.Params param, DataBundle targetBundle)
		{
		}

		// Token: 0x0601EAB0 RID: 125616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAB0")]
		[Address(RVA = "0x185F440", Offset = "0x185E040", VA = "0x18185F440")]
		private void _OnNodeClick(string placeId, string nodeId)
		{
		}

		// Token: 0x0601EAB1 RID: 125617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAB1")]
		[Address(RVA = "0x185F770", Offset = "0x185E370", VA = "0x18185F770")]
		private void _OnPlaceDiscover(string placeId)
		{
		}

		// Token: 0x0601EAB2 RID: 125618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAB2")]
		[Address(RVA = "0x185FAD0", Offset = "0x185E6D0", VA = "0x18185FAD0")]
		private void _OnShopClick()
		{
		}

		// Token: 0x0601EAB3 RID: 125619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAB3")]
		[Address(RVA = "0x185F0B0", Offset = "0x185DCB0", VA = "0x18185F0B0")]
		private void _OnArchiveClick()
		{
		}

		// Token: 0x0601EAB4 RID: 125620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAB4")]
		[Address(RVA = "0x185FC80", Offset = "0x185E880", VA = "0x18185FC80")]
		private void _OnTechDetailClick()
		{
		}

		// Token: 0x0601EAB5 RID: 125621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAB5")]
		[Address(RVA = "0x185F290", Offset = "0x185DE90", VA = "0x18185F290")]
		private void _OnMissionAimClick(string nodeId)
		{
		}

		// Token: 0x0601EAB6 RID: 125622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAB6")]
		[Address(RVA = "0x185FDB0", Offset = "0x185E9B0", VA = "0x18185FDB0")]
		private void _OnZoneSwitchClick()
		{
		}

		// Token: 0x0601EAB7 RID: 125623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAB7")]
		[Address(RVA = "0x185DF50", Offset = "0x185CB50", VA = "0x18185DF50")]
		public void UpdateDeepSeaStatus()
		{
		}

		// Token: 0x0601EAB8 RID: 125624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAB8")]
		[Address(RVA = "0x185B7B0", Offset = "0x185A3B0", VA = "0x18185B7B0")]
		public void FocusOnPlace(string placeId)
		{
		}

		// Token: 0x0601EAB9 RID: 125625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAB9")]
		[Address(RVA = "0x185C610", Offset = "0x185B210", VA = "0x18185C610")]
		public void TryActivateNode(string placeId, string nodeId, Action onComplete)
		{
		}

		// Token: 0x0601EABA RID: 125626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EABA")]
		[Address(RVA = "0x185CE10", Offset = "0x185BA10", VA = "0x18185CE10")]
		public void TryReadEvent(string placeId, string nodeId, string eventId, Action onComplete)
		{
		}

		// Token: 0x0601EABB RID: 125627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EABB")]
		[Address(RVA = "0x185C9F0", Offset = "0x185B5F0", VA = "0x18185C9F0")]
		public void TryOpenTreasure(string placeId, string nodeId, string treasureId, Action<DeepSeaOpenTreasureResponse> onComplete)
		{
		}

		// Token: 0x0601EABC RID: 125628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EABC")]
		[Address(RVA = "0x185DA80", Offset = "0x185C680", VA = "0x18185DA80")]
		public void TryUnlockTech(string placeId, string nodeId, string techTreeId, Action onComplete)
		{
		}

		// Token: 0x0601EABD RID: 125629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EABD")]
		[Address(RVA = "0x185D230", Offset = "0x185BE30", VA = "0x18185D230")]
		public void TryReadStory(string placeId, string nodeId, string storyKey, Action onComplete)
		{
		}

		// Token: 0x0601EABE RID: 125630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EABE")]
		[Address(RVA = "0x185D650", Offset = "0x185C250", VA = "0x18185D650")]
		public void TrySelectChoice(string placeId, string nodeId, int choiceIdx, Action onComplete)
		{
		}

		// Token: 0x0601EABF RID: 125631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EABF")]
		[Address(RVA = "0x185BBC0", Offset = "0x185A7C0", VA = "0x18185BBC0")]
		public DeepSeaRPNodeModel GetSelectedNodeModel()
		{
			return null;
		}

		// Token: 0x0601EAC0 RID: 125632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EAC0")]
		[Address(RVA = "0x185BC50", Offset = "0x185A850", VA = "0x18185BC50")]
		public DeepSeaRPPlaceModel GetSelectedPlaceModel()
		{
			return null;
		}

		// Token: 0x0601EAC1 RID: 125633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EAC1")]
		[Address(RVA = "0x185BB30", Offset = "0x185A730", VA = "0x18185BB30")]
		public Act17sideData.EventData GetSelectedLockEventData()
		{
			return null;
		}

		// Token: 0x0601EAC2 RID: 125634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAC2")]
		[Address(RVA = "0x185C290", Offset = "0x185AE90", VA = "0x18185C290")]
		public void SetToolbarVisible(bool isVisible)
		{
		}

		// Token: 0x0601EAC3 RID: 125635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAC3")]
		[Address(RVA = "0x185C130", Offset = "0x185AD30", VA = "0x18185C130")]
		public void SelectZone(string zoneId)
		{
		}

		// Token: 0x0601EAC4 RID: 125636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EAC4")]
		[Address(RVA = "0x185FE40", Offset = "0x185EA40", VA = "0x18185FE40")]
		private IEnumerator _SwitchZoneWithAnim(string zoneId)
		{
			return null;
		}

		// Token: 0x0601EAC5 RID: 125637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAC5")]
		[Address(RVA = "0x185BCE0", Offset = "0x185A8E0", VA = "0x18185BCE0")]
		public void HandlePushMsg(DeepSeaLandmarkPushMessage msg)
		{
		}

		// Token: 0x0601EAC6 RID: 125638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAC6")]
		[Address(RVA = "0x185FF10", Offset = "0x185EB10", VA = "0x18185FF10")]
		public DeepSeaRolePlayPage()
		{
		}

		// Token: 0x0601EACB RID: 125643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EACB")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0601EACC RID: 125644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EACC")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0601EACD RID: 125645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EACD")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0601EACE RID: 125646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EACE")]
		[Address(RVA = "0x185DEE0", Offset = "0x185CAE0", VA = "0x18185DEE0")]
		private void <>xLuaBaseProxy_DisplayWholePage(bool P0)
		{
		}

		// Token: 0x0601EACF RID: 125647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EACF")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x040291EF RID: 168431
		[Token(Token = "0x40291EF")]
		public const string KEY_PARAM_BUNDLE = "key_deep_sea_param";

		// Token: 0x040291F0 RID: 168432
		[Token(Token = "0x40291F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private DeepSeaRPZoneMapContainer _mapContainer;

		// Token: 0x040291F1 RID: 168433
		[Token(Token = "0x40291F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x040291F2 RID: 168434
		[Token(Token = "0x40291F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform _mapBarContainer;

		// Token: 0x040291F3 RID: 168435
		[Token(Token = "0x40291F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private DeepSeaLandmarkNotify _landmarkNotify;

		// Token: 0x040291F4 RID: 168436
		[Token(Token = "0x40291F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private UIAnimationLocation _toolbarAnim;

		// Token: 0x040291F5 RID: 168437
		[Token(Token = "0x40291F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private CanvasGroup _mapSwitchCanvasGroup;

		// Token: 0x040291F6 RID: 168438
		[Token(Token = "0x40291F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private UIAnimationLocation _mapSwitchEnterAnim;

		// Token: 0x040291F7 RID: 168439
		[Token(Token = "0x40291F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private float _mapUpdateDelay;

		// Token: 0x040291F8 RID: 168440
		[Token(Token = "0x40291F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private UICommonPageEffectHolder _zoneEffect;

		// Token: 0x040291F9 RID: 168441
		[Token(Token = "0x40291F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool m_hasInited;

		// Token: 0x040291FA RID: 168442
		[Token(Token = "0x40291FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private DeepSeaRPProperty m_property;

		// Token: 0x040291FB RID: 168443
		[Token(Token = "0x40291FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private AnimationSwitchTween m_toolbarSwitchTween;

		// Token: 0x040291FC RID: 168444
		[Token(Token = "0x40291FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private DeepSeaRPZoneBarContainer m_bar;

		// Token: 0x040291FD RID: 168445
		[Token(Token = "0x40291FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool m_showBattlePreview;

		// Token: 0x040291FE RID: 168446
		[Token(Token = "0x40291FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isRetro;

		// Token: 0x040291FF RID: 168447
		[Token(Token = "0x40291FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isTechTreeNodesAllLock;

		// Token: 0x04029200 RID: 168448
		[Token(Token = "0x4029200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedZoneId;

		// Token: 0x04029201 RID: 168449
		[Token(Token = "0x4029201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectedPlaceId;

		// Token: 0x04029202 RID: 168450
		[Token(Token = "0x4029202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_groupId;

		// Token: 0x04029203 RID: 168451
		[Token(Token = "0x4029203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_zoneMapModelList;

		// Token: 0x04029204 RID: 168452
		[Token(Token = "0x4029204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04029205 RID: 168453
		[Token(Token = "0x4029205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x04029206 RID: 168454
		[Token(Token = "0x4029206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x04029207 RID: 168455
		[Token(Token = "0x4029207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DisplayWholePage;

		// Token: 0x04029208 RID: 168456
		[Token(Token = "0x4029208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04029209 RID: 168457
		[Token(Token = "0x4029209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_StartAvgAndBackToDeepSea;

		// Token: 0x0402920A RID: 168458
		[Token(Token = "0x402920A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitDeepSeaProp;

		// Token: 0x0402920B RID: 168459
		[Token(Token = "0x402920B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitMapBar;

		// Token: 0x0402920C RID: 168460
		[Token(Token = "0x402920C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__AddBattlePreviewState;

		// Token: 0x0402920D RID: 168461
		[Token(Token = "0x402920D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402920E RID: 168462
		[Token(Token = "0x402920E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CreateCommonTopMenu;

		// Token: 0x0402920F RID: 168463
		[Token(Token = "0x402920F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnBackAction;

		// Token: 0x04029210 RID: 168464
		[Token(Token = "0x4029210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GenPageStackToJumpBack;

		// Token: 0x04029211 RID: 168465
		[Token(Token = "0x4029211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SaveParamToBundle;

		// Token: 0x04029212 RID: 168466
		[Token(Token = "0x4029212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnNodeClick;

		// Token: 0x04029213 RID: 168467
		[Token(Token = "0x4029213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnPlaceDiscover;

		// Token: 0x04029214 RID: 168468
		[Token(Token = "0x4029214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnShopClick;

		// Token: 0x04029215 RID: 168469
		[Token(Token = "0x4029215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnArchiveClick;

		// Token: 0x04029216 RID: 168470
		[Token(Token = "0x4029216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnTechDetailClick;

		// Token: 0x04029217 RID: 168471
		[Token(Token = "0x4029217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnMissionAimClick;

		// Token: 0x04029218 RID: 168472
		[Token(Token = "0x4029218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnZoneSwitchClick;

		// Token: 0x04029219 RID: 168473
		[Token(Token = "0x4029219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_UpdateDeepSeaStatus;

		// Token: 0x0402921A RID: 168474
		[Token(Token = "0x402921A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_FocusOnPlace;

		// Token: 0x0402921B RID: 168475
		[Token(Token = "0x402921B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_TryActivateNode;

		// Token: 0x0402921C RID: 168476
		[Token(Token = "0x402921C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_TryReadEvent;

		// Token: 0x0402921D RID: 168477
		[Token(Token = "0x402921D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_TryOpenTreasure;

		// Token: 0x0402921E RID: 168478
		[Token(Token = "0x402921E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_TryUnlockTech;

		// Token: 0x0402921F RID: 168479
		[Token(Token = "0x402921F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_TryReadStory;

		// Token: 0x04029220 RID: 168480
		[Token(Token = "0x4029220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_TrySelectChoice;

		// Token: 0x04029221 RID: 168481
		[Token(Token = "0x4029221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetSelectedNodeModel;

		// Token: 0x04029222 RID: 168482
		[Token(Token = "0x4029222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetSelectedPlaceModel;

		// Token: 0x04029223 RID: 168483
		[Token(Token = "0x4029223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_GetSelectedLockEventData;

		// Token: 0x04029224 RID: 168484
		[Token(Token = "0x4029224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_SetToolbarVisible;

		// Token: 0x04029225 RID: 168485
		[Token(Token = "0x4029225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_SelectZone;

		// Token: 0x04029226 RID: 168486
		[Token(Token = "0x4029226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__SwitchZoneWithAnim;

		// Token: 0x04029227 RID: 168487
		[Token(Token = "0x4029227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_HandlePushMsg;

		// Token: 0x04029228 RID: 168488
		[Token(Token = "0x4029228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200511D RID: 20765
		[Token(Token = "0x200511D")]
		public class Params : ICustomPageParam, IHotfixable
		{
			// Token: 0x0601EAD0 RID: 125648 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EAD0")]
			[Address(RVA = "0x1862F70", Offset = "0x1861B70", VA = "0x181862F70")]
			public string Serialize()
			{
				return null;
			}

			// Token: 0x0601EAD1 RID: 125649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EAD1")]
			[Address(RVA = "0x1862E20", Offset = "0x1861A20", VA = "0x181862E20")]
			public static DeepSeaRolePlayPage.Params Deserialize(string str)
			{
				return null;
			}

			// Token: 0x0601EAD2 RID: 125650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EAD2")]
			[Address(RVA = "0x1862FF0", Offset = "0x1861BF0", VA = "0x181862FF0")]
			public Params()
			{
			}

			// Token: 0x04029229 RID: 168489
			[Token(Token = "0x4029229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isRetro;

			// Token: 0x0402922A RID: 168490
			[Token(Token = "0x402922A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string groupId;

			// Token: 0x0402922B RID: 168491
			[Token(Token = "0x402922B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string zoneId;

			// Token: 0x0402922C RID: 168492
			[Token(Token = "0x402922C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string stageId;

			// Token: 0x0402922D RID: 168493
			[Token(Token = "0x402922D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isFromBattle;

			// Token: 0x0402922E RID: 168494
			[Token(Token = "0x402922E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public DeepSeaRolePlayPage.Params.AVGInfo avgInfo;

			// Token: 0x0402922F RID: 168495
			[Token(Token = "0x402922F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Serialize;

			// Token: 0x04029230 RID: 168496
			[Token(Token = "0x4029230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Deserialize;

			// Token: 0x04029231 RID: 168497
			[Token(Token = "0x4029231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200511E RID: 20766
			[Token(Token = "0x200511E")]
			public struct AVGInfo
			{
				// Token: 0x0601EAD3 RID: 125651 RVA: 0x000AF338 File Offset: 0x000AD538
				[Token(Token = "0x601EAD3")]
				[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
				public bool IsEmpty()
				{
					return default(bool);
				}

				// Token: 0x04029232 RID: 168498
				[Token(Token = "0x4029232")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string placeId;

				// Token: 0x04029233 RID: 168499
				[Token(Token = "0x4029233")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public bool showNodeDetail;
			}
		}
	}
}
