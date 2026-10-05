using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.Stage.MixStory;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006880 RID: 26752
	[Token(Token = "0x2006880")]
	public class StageMixStoryBriefState : UIPopupState, IValueMsgReceiver
	{
		// Token: 0x0602650F RID: 156943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602650F")]
		[Address(RVA = "0x2162AB0", Offset = "0x21616B0", VA = "0x182162AB0", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06026510 RID: 156944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026510")]
		[Address(RVA = "0x2164EF0", Offset = "0x2163AF0", VA = "0x182164EF0")]
		private void _OnToStoriesEvent()
		{
		}

		// Token: 0x06026511 RID: 156945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026511")]
		[Address(RVA = "0x2164A10", Offset = "0x2163610", VA = "0x182164A10")]
		private void _OnToReopenActEvent()
		{
		}

		// Token: 0x06026512 RID: 156946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026512")]
		[Address(RVA = "0x2164C10", Offset = "0x2163810", VA = "0x182164C10")]
		private void _OnToRetroTrailEvent()
		{
		}

		// Token: 0x06026513 RID: 156947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026513")]
		[Address(RVA = "0x21657C0", Offset = "0x21643C0", VA = "0x1821657C0")]
		private void _OpenRetroTrailAsSS(StageStorylineSSViewModel model)
		{
		}

		// Token: 0x06026514 RID: 156948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026514")]
		[Address(RVA = "0x21656D0", Offset = "0x21642D0", VA = "0x1821656D0")]
		private void _OpenRetroTrailAsCollect(StageStorylineCollectViewModel model)
		{
		}

		// Token: 0x06026515 RID: 156949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026515")]
		[Address(RVA = "0x2165160", Offset = "0x2163D60", VA = "0x182165160")]
		private void _OnToZoneMapEvent()
		{
		}

		// Token: 0x06026516 RID: 156950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026516")]
		[Address(RVA = "0x21635F0", Offset = "0x21621F0", VA = "0x1821635F0")]
		private void ToMainlineZoneMap(MixStoryZoneGroupViewModel groupModel, StageStorylineMainlineViewModel selected)
		{
		}

		// Token: 0x06026517 RID: 156951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026517")]
		[Address(RVA = "0x2163950", Offset = "0x2162550", VA = "0x182163950")]
		private void ToSSZoneMap(MixStoryZoneGroupViewModel groupModel, StageStorylineSSViewModel selected)
		{
		}

		// Token: 0x06026518 RID: 156952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026518")]
		[Address(RVA = "0x21652F0", Offset = "0x2163EF0", VA = "0x1821652F0")]
		private void _OnUnlockRetro()
		{
		}

		// Token: 0x06026519 RID: 156953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026519")]
		[Address(RVA = "0x2165A50", Offset = "0x2164650", VA = "0x182165A50")]
		private void _SendUnlockRetroService()
		{
		}

		// Token: 0x0602651A RID: 156954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602651A")]
		[Address(RVA = "0x2166050", Offset = "0x2164C50", VA = "0x182166050")]
		private void _UnlockRetroServiceProceed(RetroUnlockRetroBlockResponse response)
		{
		}

		// Token: 0x0602651B RID: 156955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602651B")]
		[Address(RVA = "0x2164B50", Offset = "0x2163750", VA = "0x182164B50")]
		private void _OnToRetroCoinDetail()
		{
		}

		// Token: 0x0602651C RID: 156956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602651C")]
		[Address(RVA = "0x2164910", Offset = "0x2163510", VA = "0x182164910")]
		private void _OnSwitchRetro(string storySetId)
		{
		}

		// Token: 0x0602651D RID: 156957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602651D")]
		[Address(RVA = "0x2164670", Offset = "0x2163270", VA = "0x182164670")]
		private void _OnOpenGallery()
		{
		}

		// Token: 0x17005A7B RID: 23163
		// (get) Token: 0x0602651E RID: 156958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A7B")]
		public override IStateCacheHandler cacheHandler
		{
			[Token(Token = "0x602651E")]
			[Address(RVA = "0x2166270", Offset = "0x2164E70", VA = "0x182166270", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602651F RID: 156959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602651F")]
		[Address(RVA = "0x2163DE0", Offset = "0x21629E0", VA = "0x182163DE0")]
		private void _CacheHandleOnLoad(StageMixStoryBriefState.StateRuntime runtime)
		{
		}

		// Token: 0x06026520 RID: 156960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026520")]
		[Address(RVA = "0x21624C0", Offset = "0x21610C0", VA = "0x1821624C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06026521 RID: 156961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026521")]
		[Address(RVA = "0x2162780", Offset = "0x2161380", VA = "0x182162780", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026522 RID: 156962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026522")]
		[Address(RVA = "0x2163060", Offset = "0x2161C60", VA = "0x182163060", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06026523 RID: 156963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026523")]
		[Address(RVA = "0x2163170", Offset = "0x2161D70", VA = "0x182163170", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06026524 RID: 156964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026524")]
		[Address(RVA = "0x2163270", Offset = "0x2161E70", VA = "0x182163270", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06026525 RID: 156965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026525")]
		[Address(RVA = "0x21629C0", Offset = "0x21615C0", VA = "0x1821629C0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06026526 RID: 156966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026526")]
		[Address(RVA = "0x2163380", Offset = "0x2161F80", VA = "0x182163380", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06026527 RID: 156967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026527")]
		[Address(RVA = "0x2162520", Offset = "0x2161120", VA = "0x182162520", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06026528 RID: 156968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026528")]
		[Address(RVA = "0x21634C0", Offset = "0x21620C0", VA = "0x1821634C0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06026529 RID: 156969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026529")]
		[Address(RVA = "0x2162660", Offset = "0x2161260", VA = "0x182162660", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0602652A RID: 156970 RVA: 0x000CAA28 File Offset: 0x000C8C28
		[Token(Token = "0x602652A")]
		[Address(RVA = "0x2164200", Offset = "0x2162E00", VA = "0x182164200")]
		private long _GetBGMInstId()
		{
			return 0L;
		}

		// Token: 0x0602652B RID: 156971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602652B")]
		[Address(RVA = "0x21658B0", Offset = "0x21644B0", VA = "0x1821658B0")]
		private void _RefreshBGM()
		{
		}

		// Token: 0x0602652C RID: 156972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602652C")]
		[Address(RVA = "0x2163FD0", Offset = "0x2162BD0", VA = "0x182163FD0")]
		private void _ClearBGM()
		{
		}

		// Token: 0x0602652D RID: 156973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602652D")]
		[Address(RVA = "0x21640F0", Offset = "0x2162CF0", VA = "0x1821640F0")]
		private string _FindMusicId()
		{
			return null;
		}

		// Token: 0x0602652E RID: 156974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602652E")]
		[Address(RVA = "0x2164270", Offset = "0x2162E70", VA = "0x182164270")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602652F RID: 156975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602652F")]
		[Address(RVA = "0x2164060", Offset = "0x2162C60", VA = "0x182164060")]
		private void _EventOnBackBtnClicked()
		{
		}

		// Token: 0x06026530 RID: 156976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026530")]
		[Address(RVA = "0x2165E30", Offset = "0x2164A30", VA = "0x182165E30")]
		private void _Tutorial_RegisterGO()
		{
		}

		// Token: 0x06026531 RID: 156977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026531")]
		[Address(RVA = "0x2165CA0", Offset = "0x21648A0", VA = "0x182165CA0")]
		private void _TutorialTriggerSignalIfNeed()
		{
		}

		// Token: 0x06026532 RID: 156978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026532")]
		[Address(RVA = "0x2165FA0", Offset = "0x2164BA0", VA = "0x182165FA0")]
		private IEnumerator _Tutorial_WaitToTriggerSignal()
		{
			return null;
		}

		// Token: 0x06026533 RID: 156979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026533")]
		[Address(RVA = "0x2166210", Offset = "0x2164E10", VA = "0x182166210")]
		public StageMixStoryBriefState()
		{
		}

		// Token: 0x06026534 RID: 156980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026534")]
		[Address(RVA = "0x12DC030", Offset = "0x12DAC30", VA = "0x1812DC030")]
		private IStateCacheHandler <>xLuaBaseProxy_get_cacheHandler()
		{
			return null;
		}

		// Token: 0x06026535 RID: 156981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026535")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06026536 RID: 156982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026536")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x06026537 RID: 156983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026537")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06026538 RID: 156984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026538")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06026539 RID: 156985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026539")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04035F91 RID: 221073
		[Token(Token = "0x4035F91")]
		private const float FADE_DURATION = 0.23f;

		// Token: 0x04035F92 RID: 221074
		[Token(Token = "0x4035F92")]
		[NonSerialized]
		public const int MSG_TO_STORIES = 0;

		// Token: 0x04035F93 RID: 221075
		[Token(Token = "0x4035F93")]
		[NonSerialized]
		public const int MSG_TO_REOPEN_ACT = 1;

		// Token: 0x04035F94 RID: 221076
		[Token(Token = "0x4035F94")]
		[NonSerialized]
		public const int MSG_TO_RETRO_TRAIL = 2;

		// Token: 0x04035F95 RID: 221077
		[Token(Token = "0x4035F95")]
		[NonSerialized]
		public const int MSG_TO_ZONE_MAP = 3;

		// Token: 0x04035F96 RID: 221078
		[Token(Token = "0x4035F96")]
		[NonSerialized]
		public const int MSG_UNLOCK_RETRO = 4;

		// Token: 0x04035F97 RID: 221079
		[Token(Token = "0x4035F97")]
		[NonSerialized]
		public const int MSG_TO_RETRO_COIN_DETAIL = 5;

		// Token: 0x04035F98 RID: 221080
		[Token(Token = "0x4035F98")]
		[NonSerialized]
		public const int MSG_SWITCH_TARGET = 6;

		// Token: 0x04035F99 RID: 221081
		[Token(Token = "0x4035F99")]
		[NonSerialized]
		public const int MSG_OPEN_CG_GALLERY = 7;

		// Token: 0x04035F9A RID: 221082
		[Token(Token = "0x4035F9A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StageMixStoryBriefView _view;

		// Token: 0x04035F9B RID: 221083
		[Token(Token = "0x4035F9B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x04035F9C RID: 221084
		[Token(Token = "0x4035F9C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _inAnimation;

		// Token: 0x04035F9D RID: 221085
		[Token(Token = "0x4035F9D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _tutorialEntrancePanel;

		// Token: 0x04035F9E RID: 221086
		[Token(Token = "0x4035F9E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _tutorialContentPanel;

		// Token: 0x04035F9F RID: 221087
		[Token(Token = "0x4035F9F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _tutorialSwitchPanel;

		// Token: 0x04035FA0 RID: 221088
		[Token(Token = "0x4035FA0")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04035FA1 RID: 221089
		[Token(Token = "0x4035FA1")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x04035FA2 RID: 221090
		[Token(Token = "0x4035FA2")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04035FA3 RID: 221091
		[Token(Token = "0x4035FA3")]
		[FieldOffset(Offset = "0xB8")]
		private StageStateBean m_stageStateBean;

		// Token: 0x04035FA4 RID: 221092
		[Token(Token = "0x4035FA4")]
		[FieldOffset(Offset = "0xC0")]
		private StagePageGameMusicController m_musicController;

		// Token: 0x04035FA5 RID: 221093
		[Token(Token = "0x4035FA5")]
		[FieldOffset(Offset = "0xC8")]
		private MixStoryGroupViewProperty m_mixStoryProperty;

		// Token: 0x04035FA6 RID: 221094
		[Token(Token = "0x4035FA6")]
		[FieldOffset(Offset = "0xD0")]
		private AnimationSwitchTween m_inTween;

		// Token: 0x04035FA7 RID: 221095
		[Token(Token = "0x4035FA7")]
		[FieldOffset(Offset = "0xD8")]
		private StageStorylineSSViewModel m_cachedUnlockRetroModel;

		// Token: 0x04035FA8 RID: 221096
		[Token(Token = "0x4035FA8")]
		[FieldOffset(Offset = "0xE0")]
		private StateCacheHandler<StageMixStoryBriefState.StateRuntime> m_cacheHandler;

		// Token: 0x04035FA9 RID: 221097
		[Token(Token = "0x4035FA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04035FAA RID: 221098
		[Token(Token = "0x4035FAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnToStoriesEvent;

		// Token: 0x04035FAB RID: 221099
		[Token(Token = "0x4035FAB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnToReopenActEvent;

		// Token: 0x04035FAC RID: 221100
		[Token(Token = "0x4035FAC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnToRetroTrailEvent;

		// Token: 0x04035FAD RID: 221101
		[Token(Token = "0x4035FAD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OpenRetroTrailAsSS;

		// Token: 0x04035FAE RID: 221102
		[Token(Token = "0x4035FAE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OpenRetroTrailAsCollect;

		// Token: 0x04035FAF RID: 221103
		[Token(Token = "0x4035FAF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnToZoneMapEvent;

		// Token: 0x04035FB0 RID: 221104
		[Token(Token = "0x4035FB0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ToMainlineZoneMap;

		// Token: 0x04035FB1 RID: 221105
		[Token(Token = "0x4035FB1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ToSSZoneMap;

		// Token: 0x04035FB2 RID: 221106
		[Token(Token = "0x4035FB2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnUnlockRetro;

		// Token: 0x04035FB3 RID: 221107
		[Token(Token = "0x4035FB3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SendUnlockRetroService;

		// Token: 0x04035FB4 RID: 221108
		[Token(Token = "0x4035FB4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UnlockRetroServiceProceed;

		// Token: 0x04035FB5 RID: 221109
		[Token(Token = "0x4035FB5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnToRetroCoinDetail;

		// Token: 0x04035FB6 RID: 221110
		[Token(Token = "0x4035FB6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnSwitchRetro;

		// Token: 0x04035FB7 RID: 221111
		[Token(Token = "0x4035FB7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnOpenGallery;

		// Token: 0x04035FB8 RID: 221112
		[Token(Token = "0x4035FB8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_cacheHandler;

		// Token: 0x04035FB9 RID: 221113
		[Token(Token = "0x4035FB9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CacheHandleOnLoad;

		// Token: 0x04035FBA RID: 221114
		[Token(Token = "0x4035FBA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04035FBB RID: 221115
		[Token(Token = "0x4035FBB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04035FBC RID: 221116
		[Token(Token = "0x4035FBC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04035FBD RID: 221117
		[Token(Token = "0x4035FBD")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04035FBE RID: 221118
		[Token(Token = "0x4035FBE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04035FBF RID: 221119
		[Token(Token = "0x4035FBF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04035FC0 RID: 221120
		[Token(Token = "0x4035FC0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04035FC1 RID: 221121
		[Token(Token = "0x4035FC1")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04035FC2 RID: 221122
		[Token(Token = "0x4035FC2")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04035FC3 RID: 221123
		[Token(Token = "0x4035FC3")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04035FC4 RID: 221124
		[Token(Token = "0x4035FC4")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__GetBGMInstId;

		// Token: 0x04035FC5 RID: 221125
		[Token(Token = "0x4035FC5")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RefreshBGM;

		// Token: 0x04035FC6 RID: 221126
		[Token(Token = "0x4035FC6")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ClearBGM;

		// Token: 0x04035FC7 RID: 221127
		[Token(Token = "0x4035FC7")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__FindMusicId;

		// Token: 0x04035FC8 RID: 221128
		[Token(Token = "0x4035FC8")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035FC9 RID: 221129
		[Token(Token = "0x4035FC9")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__EventOnBackBtnClicked;

		// Token: 0x04035FCA RID: 221130
		[Token(Token = "0x4035FCA")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__Tutorial_RegisterGO;

		// Token: 0x04035FCB RID: 221131
		[Token(Token = "0x4035FCB")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__TutorialTriggerSignalIfNeed;

		// Token: 0x04035FCC RID: 221132
		[Token(Token = "0x4035FCC")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__Tutorial_WaitToTriggerSignal;

		// Token: 0x04035FCD RID: 221133
		[Token(Token = "0x4035FCD")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006881 RID: 26753
		[Token(Token = "0x2006881")]
		public struct StateRuntime
		{
			// Token: 0x04035FCE RID: 221134
			[Token(Token = "0x4035FCE")]
			[FieldOffset(Offset = "0x0")]
			public string selectedBriefZoneId;

			// Token: 0x04035FCF RID: 221135
			[Token(Token = "0x4035FCF")]
			[FieldOffset(Offset = "0x8")]
			public string selectedBriefRelevantActId;

			// Token: 0x04035FD0 RID: 221136
			[Token(Token = "0x4035FD0")]
			[FieldOffset(Offset = "0x10")]
			public string selectedBriefStorySetId;
		}
	}
}
