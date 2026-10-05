using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200733A RID: 29498
	[Token(Token = "0x200733A")]
	public class Act42D0MapPage : StateEnginePage, IValueMsgReceiver
	{
		// Token: 0x17006281 RID: 25217
		// (get) Token: 0x06029B71 RID: 170865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006281")]
		public Act42d0AreaMapProperty mapProp
		{
			[Token(Token = "0x6029B71")]
			[Address(RVA = "0x250A550", Offset = "0x2509150", VA = "0x18250A550")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029B72 RID: 170866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B72")]
		[Address(RVA = "0x2507CF0", Offset = "0x25068F0", VA = "0x182507CF0")]
		private DataBundle _CreateRecoverDataBundleForBattle()
		{
			return null;
		}

		// Token: 0x06029B73 RID: 170867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B73")]
		[Address(RVA = "0x25078F0", Offset = "0x25064F0", VA = "0x1825078F0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06029B74 RID: 170868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B74")]
		[Address(RVA = "0x250A360", Offset = "0x2508F60", VA = "0x18250A360")]
		private void _TriggerTutorialAVG()
		{
		}

		// Token: 0x06029B75 RID: 170869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B75")]
		[Address(RVA = "0x25067A0", Offset = "0x25053A0", VA = "0x1825067A0", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x06029B76 RID: 170870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B76")]
		[Address(RVA = "0x2509E10", Offset = "0x2508A10", VA = "0x182509E10")]
		private void _OnEnterAnimComplete()
		{
		}

		// Token: 0x06029B77 RID: 170871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B77")]
		[Address(RVA = "0x2508160", Offset = "0x2506D60", VA = "0x182508160")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029B78 RID: 170872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B78")]
		[Address(RVA = "0x25082B0", Offset = "0x2506EB0", VA = "0x1825082B0")]
		private void _InitMap()
		{
		}

		// Token: 0x06029B79 RID: 170873 RVA: 0x000D64B8 File Offset: 0x000D46B8
		[Token(Token = "0x6029B79")]
		[Address(RVA = "0x2507A80", Offset = "0x2506680", VA = "0x182507A80")]
		private bool _CheckCachedEffectShow(string actId, string areaId, bool areaCanUseBuff)
		{
			return default(bool);
		}

		// Token: 0x06029B7A RID: 170874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B7A")]
		[Address(RVA = "0x2508CC0", Offset = "0x25078C0", VA = "0x182508CC0")]
		private void _OnBackClick()
		{
		}

		// Token: 0x06029B7B RID: 170875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B7B")]
		[Address(RVA = "0x2506F90", Offset = "0x2505B90", VA = "0x182506F90")]
		public void NotifyAreaUnlock(string areaId)
		{
		}

		// Token: 0x06029B7C RID: 170876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B7C")]
		[Address(RVA = "0x2506860", Offset = "0x2505460", VA = "0x182506860")]
		public void EventOnBackClick()
		{
		}

		// Token: 0x06029B7D RID: 170877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B7D")]
		[Address(RVA = "0x2506D10", Offset = "0x2505910", VA = "0x182506D10")]
		public void EventOnNextAreaClick()
		{
		}

		// Token: 0x06029B7E RID: 170878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B7E")]
		[Address(RVA = "0x2506E20", Offset = "0x2505A20", VA = "0x182506E20")]
		public void EventOnPrevAreaClick()
		{
		}

		// Token: 0x06029B7F RID: 170879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B7F")]
		[Address(RVA = "0x2506B30", Offset = "0x2505730", VA = "0x182506B30")]
		public void EventOnBossClick()
		{
		}

		// Token: 0x06029B80 RID: 170880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B80")]
		[Address(RVA = "0x2508750", Offset = "0x2507350", VA = "0x182508750")]
		private void _JumpToDiffGroup(Act42D0Data.Act42D0AreaDifficulty diff)
		{
		}

		// Token: 0x06029B81 RID: 170881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B81")]
		[Address(RVA = "0x2506A20", Offset = "0x2505620", VA = "0x182506A20")]
		public void EventOnBlanckClick()
		{
		}

		// Token: 0x06029B82 RID: 170882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B82")]
		[Address(RVA = "0x2506F30", Offset = "0x2505B30", VA = "0x182506F30")]
		public void EventOnRewardClick()
		{
		}

		// Token: 0x06029B83 RID: 170883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B83")]
		[Address(RVA = "0x2506BE0", Offset = "0x25057E0", VA = "0x182506BE0")]
		public void EventOnLastProgressClick()
		{
		}

		// Token: 0x06029B84 RID: 170884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B84")]
		[Address(RVA = "0x2507080", Offset = "0x2505C80", VA = "0x182507080", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06029B85 RID: 170885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B85")]
		[Address(RVA = "0x2509DB0", Offset = "0x25089B0", VA = "0x182509DB0")]
		private void _OnEffectViewShown()
		{
		}

		// Token: 0x06029B86 RID: 170886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B86")]
		[Address(RVA = "0x2508C60", Offset = "0x2507860", VA = "0x182508C60")]
		private void _OnAreaSelected()
		{
		}

		// Token: 0x06029B87 RID: 170887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B87")]
		[Address(RVA = "0x2509E80", Offset = "0x2508A80", VA = "0x182509E80")]
		private void _OnFirstStageSelected()
		{
		}

		// Token: 0x06029B88 RID: 170888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B88")]
		[Address(RVA = "0x2509B70", Offset = "0x2508770", VA = "0x182509B70")]
		private void _OnEffectSelectShow()
		{
		}

		// Token: 0x06029B89 RID: 170889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B89")]
		[Address(RVA = "0x250A290", Offset = "0x2508E90", VA = "0x18250A290")]
		private void _TriggerEffectTutorial()
		{
		}

		// Token: 0x06029B8A RID: 170890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B8A")]
		[Address(RVA = "0x2507F90", Offset = "0x2506B90", VA = "0x182507F90")]
		private void _EffectShowImpl()
		{
		}

		// Token: 0x06029B8B RID: 170891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B8B")]
		[Address(RVA = "0x2507EE0", Offset = "0x2506AE0", VA = "0x182507EE0")]
		private void _EffectHideImpl()
		{
		}

		// Token: 0x06029B8C RID: 170892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B8C")]
		[Address(RVA = "0x2509A90", Offset = "0x2508690", VA = "0x182509A90")]
		private void _OnEffectSelectHide()
		{
		}

		// Token: 0x06029B8D RID: 170893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B8D")]
		[Address(RVA = "0x2508820", Offset = "0x2507420", VA = "0x182508820")]
		private void _OnAddEffect(string effectId)
		{
		}

		// Token: 0x06029B8E RID: 170894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B8E")]
		[Address(RVA = "0x2509EE0", Offset = "0x2508AE0", VA = "0x182509EE0")]
		private void _OnRemoveEffect(string effectId)
		{
		}

		// Token: 0x06029B8F RID: 170895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B8F")]
		[Address(RVA = "0x25094D0", Offset = "0x25080D0", VA = "0x1825094D0")]
		private void _OnClearEffect()
		{
		}

		// Token: 0x06029B90 RID: 170896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B90")]
		[Address(RVA = "0x2508A30", Offset = "0x2507630", VA = "0x182508A30")]
		private void _OnAreaClick(string areaId)
		{
		}

		// Token: 0x06029B91 RID: 170897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B91")]
		[Address(RVA = "0x250A100", Offset = "0x2508D00", VA = "0x18250A100")]
		private void _OnSelectStage(int index)
		{
		}

		// Token: 0x06029B92 RID: 170898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B92")]
		[Address(RVA = "0x2509960", Offset = "0x2508560", VA = "0x182509960")]
		private void _OnClickMap(string stageId)
		{
		}

		// Token: 0x06029B93 RID: 170899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B93")]
		[Address(RVA = "0x2509840", Offset = "0x2508440", VA = "0x182509840")]
		private void _OnClickEnemy(string levelId)
		{
		}

		// Token: 0x06029B94 RID: 170900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B94")]
		[Address(RVA = "0x2509690", Offset = "0x2508290", VA = "0x182509690")]
		private void _OnClickBoss(string bossId)
		{
		}

		// Token: 0x06029B95 RID: 170901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B95")]
		[Address(RVA = "0x2508E40", Offset = "0x2507A40", VA = "0x182508E40")]
		private void _OnBattleStart()
		{
		}

		// Token: 0x06029B96 RID: 170902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B96")]
		[Address(RVA = "0x25095C0", Offset = "0x25081C0", VA = "0x1825095C0")]
		private void _OnClickBlank()
		{
		}

		// Token: 0x06029B97 RID: 170903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B97")]
		[Address(RVA = "0x250A050", Offset = "0x2508C50", VA = "0x18250A050")]
		private void _OnRewardClick()
		{
		}

		// Token: 0x06029B98 RID: 170904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B98")]
		[Address(RVA = "0x250A430", Offset = "0x2509030", VA = "0x18250A430")]
		public Act42D0MapPage()
		{
		}

		// Token: 0x06029B9A RID: 170906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B9A")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06029B9B RID: 170907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B9B")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0403BB4D RID: 244557
		[Token(Token = "0x403BB4D")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Act42d0MapView _mapView;

		// Token: 0x0403BB4E RID: 244558
		[Token(Token = "0x403BB4E")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403BB4F RID: 244559
		[Token(Token = "0x403BB4F")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Act42D0EffectRayCastBlockerView _effectRayCastBlocker;

		// Token: 0x0403BB50 RID: 244560
		[Token(Token = "0x403BB50")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Act42D0EffectView _effectViewPrefab;

		// Token: 0x0403BB51 RID: 244561
		[Token(Token = "0x403BB51")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Transform _effectContainer;

		// Token: 0x0403BB52 RID: 244562
		[Token(Token = "0x403BB52")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Act42D0MapAreaView _mapAreaView;

		// Token: 0x0403BB53 RID: 244563
		[Token(Token = "0x403BB53")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private RectTransform _rectMapAreaView;

		// Token: 0x0403BB54 RID: 244564
		[Token(Token = "0x403BB54")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private RectTransform _rectMapPreview;

		// Token: 0x0403BB55 RID: 244565
		[Token(Token = "0x403BB55")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private ActivityStageMapPreviewView _mapPreview;

		// Token: 0x0403BB56 RID: 244566
		[Token(Token = "0x403BB56")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403BB57 RID: 244567
		[Token(Token = "0x403BB57")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private GameObject _animPanel;

		// Token: 0x0403BB58 RID: 244568
		[Token(Token = "0x403BB58")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private UICommonPageEffectHolder[] _effectHolders;

		// Token: 0x0403BB59 RID: 244569
		[Token(Token = "0x403BB59")]
		public const string KEY_PARAM_BUNDLE = "key_act42d0_map_param";

		// Token: 0x0403BB5A RID: 244570
		[Token(Token = "0x403BB5A")]
		private const string SQUAD_SAVE_KEY = "act42d0_{0}_squad_save_key";

		// Token: 0x0403BB5B RID: 244571
		[Token(Token = "0x403BB5B")]
		[FieldOffset(Offset = "0x158")]
		private bool m_hasInited;

		// Token: 0x0403BB5C RID: 244572
		[Token(Token = "0x403BB5C")]
		[FieldOffset(Offset = "0x160")]
		private string m_actId;

		// Token: 0x0403BB5D RID: 244573
		[Token(Token = "0x403BB5D")]
		[FieldOffset(Offset = "0x168")]
		private Act42D0EffectProperty m_effectProp;

		// Token: 0x0403BB5E RID: 244574
		[Token(Token = "0x403BB5E")]
		[FieldOffset(Offset = "0x170")]
		private Act42d0AreaMapProperty m_mapProp;

		// Token: 0x0403BB5F RID: 244575
		[Token(Token = "0x403BB5F")]
		[FieldOffset(Offset = "0x178")]
		private Act42D0MapAreaView m_mapAreaView;

		// Token: 0x0403BB60 RID: 244576
		[Token(Token = "0x403BB60")]
		[FieldOffset(Offset = "0x180")]
		private ActivityStageMapPreviewView m_stageMapPreviewView;

		// Token: 0x0403BB61 RID: 244577
		[Token(Token = "0x403BB61")]
		[FieldOffset(Offset = "0x188")]
		private Act42D0EffectView m_effectView;

		// Token: 0x0403BB62 RID: 244578
		[Token(Token = "0x403BB62")]
		[FieldOffset(Offset = "0x190")]
		private Tween m_entryTw;

		// Token: 0x0403BB63 RID: 244579
		[Token(Token = "0x403BB63")]
		[NonSerialized]
		public const int MSG_ADD_EFFECT = 0;

		// Token: 0x0403BB64 RID: 244580
		[Token(Token = "0x403BB64")]
		[NonSerialized]
		public const int MSG_REMOVE_EFFECT = 1;

		// Token: 0x0403BB65 RID: 244581
		[Token(Token = "0x403BB65")]
		[NonSerialized]
		public const int MSG_CLEAR_EFFECT = 2;

		// Token: 0x0403BB66 RID: 244582
		[Token(Token = "0x403BB66")]
		[NonSerialized]
		public const int MSG_SHOW_EFFECT = 3;

		// Token: 0x0403BB67 RID: 244583
		[Token(Token = "0x403BB67")]
		[NonSerialized]
		public const int MSG_HIDE_EFFECT = 4;

		// Token: 0x0403BB68 RID: 244584
		[Token(Token = "0x403BB68")]
		[NonSerialized]
		public const int MSG_AREA_CLICK = 5;

		// Token: 0x0403BB69 RID: 244585
		[Token(Token = "0x403BB69")]
		[NonSerialized]
		public const int MSG_SELECT_STAGE = 6;

		// Token: 0x0403BB6A RID: 244586
		[Token(Token = "0x403BB6A")]
		[NonSerialized]
		public const int MSG_CLICK_MAP = 7;

		// Token: 0x0403BB6B RID: 244587
		[Token(Token = "0x403BB6B")]
		[NonSerialized]
		public const int MSG_CLICK_ENEMY = 8;

		// Token: 0x0403BB6C RID: 244588
		[Token(Token = "0x403BB6C")]
		[NonSerialized]
		public const int MSG_CLICK_BOSS = 9;

		// Token: 0x0403BB6D RID: 244589
		[Token(Token = "0x403BB6D")]
		[NonSerialized]
		public const int MSG_BATTLE_START = 10;

		// Token: 0x0403BB6E RID: 244590
		[Token(Token = "0x403BB6E")]
		[NonSerialized]
		public const int MSG_REWARD_CLICK = 11;

		// Token: 0x0403BB6F RID: 244591
		[Token(Token = "0x403BB6F")]
		[NonSerialized]
		public const int MSG_FIRST_STAGE_CLICK = 12;

		// Token: 0x0403BB70 RID: 244592
		[Token(Token = "0x403BB70")]
		[NonSerialized]
		public const int MSG_AREA_SELECTED = 13;

		// Token: 0x0403BB71 RID: 244593
		[Token(Token = "0x403BB71")]
		[NonSerialized]
		public const int MSG_EFFECT_VIEW_SHOWN = 14;

		// Token: 0x0403BB72 RID: 244594
		[Token(Token = "0x403BB72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mapProp;

		// Token: 0x0403BB73 RID: 244595
		[Token(Token = "0x403BB73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CreateRecoverDataBundleForBattle;

		// Token: 0x0403BB74 RID: 244596
		[Token(Token = "0x403BB74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0403BB75 RID: 244597
		[Token(Token = "0x403BB75")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TriggerTutorialAVG;

		// Token: 0x0403BB76 RID: 244598
		[Token(Token = "0x403BB76")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0403BB77 RID: 244599
		[Token(Token = "0x403BB77")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnEnterAnimComplete;

		// Token: 0x0403BB78 RID: 244600
		[Token(Token = "0x403BB78")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BB79 RID: 244601
		[Token(Token = "0x403BB79")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitMap;

		// Token: 0x0403BB7A RID: 244602
		[Token(Token = "0x403BB7A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckCachedEffectShow;

		// Token: 0x0403BB7B RID: 244603
		[Token(Token = "0x403BB7B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnBackClick;

		// Token: 0x0403BB7C RID: 244604
		[Token(Token = "0x403BB7C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_NotifyAreaUnlock;

		// Token: 0x0403BB7D RID: 244605
		[Token(Token = "0x403BB7D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnBackClick;

		// Token: 0x0403BB7E RID: 244606
		[Token(Token = "0x403BB7E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnNextAreaClick;

		// Token: 0x0403BB7F RID: 244607
		[Token(Token = "0x403BB7F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnPrevAreaClick;

		// Token: 0x0403BB80 RID: 244608
		[Token(Token = "0x403BB80")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnBossClick;

		// Token: 0x0403BB81 RID: 244609
		[Token(Token = "0x403BB81")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__JumpToDiffGroup;

		// Token: 0x0403BB82 RID: 244610
		[Token(Token = "0x403BB82")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnBlanckClick;

		// Token: 0x0403BB83 RID: 244611
		[Token(Token = "0x403BB83")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnRewardClick;

		// Token: 0x0403BB84 RID: 244612
		[Token(Token = "0x403BB84")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnLastProgressClick;

		// Token: 0x0403BB85 RID: 244613
		[Token(Token = "0x403BB85")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403BB86 RID: 244614
		[Token(Token = "0x403BB86")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnEffectViewShown;

		// Token: 0x0403BB87 RID: 244615
		[Token(Token = "0x403BB87")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnAreaSelected;

		// Token: 0x0403BB88 RID: 244616
		[Token(Token = "0x403BB88")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnFirstStageSelected;

		// Token: 0x0403BB89 RID: 244617
		[Token(Token = "0x403BB89")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnEffectSelectShow;

		// Token: 0x0403BB8A RID: 244618
		[Token(Token = "0x403BB8A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__TriggerEffectTutorial;

		// Token: 0x0403BB8B RID: 244619
		[Token(Token = "0x403BB8B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__EffectShowImpl;

		// Token: 0x0403BB8C RID: 244620
		[Token(Token = "0x403BB8C")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__EffectHideImpl;

		// Token: 0x0403BB8D RID: 244621
		[Token(Token = "0x403BB8D")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnEffectSelectHide;

		// Token: 0x0403BB8E RID: 244622
		[Token(Token = "0x403BB8E")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnAddEffect;

		// Token: 0x0403BB8F RID: 244623
		[Token(Token = "0x403BB8F")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnRemoveEffect;

		// Token: 0x0403BB90 RID: 244624
		[Token(Token = "0x403BB90")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnClearEffect;

		// Token: 0x0403BB91 RID: 244625
		[Token(Token = "0x403BB91")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OnAreaClick;

		// Token: 0x0403BB92 RID: 244626
		[Token(Token = "0x403BB92")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__OnSelectStage;

		// Token: 0x0403BB93 RID: 244627
		[Token(Token = "0x403BB93")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnClickMap;

		// Token: 0x0403BB94 RID: 244628
		[Token(Token = "0x403BB94")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__OnClickEnemy;

		// Token: 0x0403BB95 RID: 244629
		[Token(Token = "0x403BB95")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__OnClickBoss;

		// Token: 0x0403BB96 RID: 244630
		[Token(Token = "0x403BB96")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__OnBattleStart;

		// Token: 0x0403BB97 RID: 244631
		[Token(Token = "0x403BB97")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__OnClickBlank;

		// Token: 0x0403BB98 RID: 244632
		[Token(Token = "0x403BB98")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__OnRewardClick;

		// Token: 0x0403BB99 RID: 244633
		[Token(Token = "0x403BB99")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200733B RID: 29499
		[Token(Token = "0x200733B")]
		public class Param : ICustomPageParam, IHotfixable
		{
			// Token: 0x06029B9C RID: 170908 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029B9C")]
			[Address(RVA = "0x2567680", Offset = "0x2566280", VA = "0x182567680")]
			public string Serialize()
			{
				return null;
			}

			// Token: 0x06029B9D RID: 170909 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029B9D")]
			[Address(RVA = "0x2567530", Offset = "0x2566130", VA = "0x182567530")]
			public static Act42D0MapPage.Param Deserialize(string str)
			{
				return null;
			}

			// Token: 0x06029B9E RID: 170910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029B9E")]
			[Address(RVA = "0x2567700", Offset = "0x2566300", VA = "0x182567700")]
			public Param()
			{
			}

			// Token: 0x0403BB9A RID: 244634
			[Token(Token = "0x403BB9A")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403BB9B RID: 244635
			[Token(Token = "0x403BB9B")]
			[FieldOffset(Offset = "0x18")]
			public string areaId;

			// Token: 0x0403BB9C RID: 244636
			[Token(Token = "0x403BB9C")]
			[FieldOffset(Offset = "0x20")]
			public string stageId;

			// Token: 0x0403BB9D RID: 244637
			[Token(Token = "0x403BB9D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Serialize;

			// Token: 0x0403BB9E RID: 244638
			[Token(Token = "0x403BB9E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Deserialize;

			// Token: 0x0403BB9F RID: 244639
			[Token(Token = "0x403BB9F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
