using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048DF RID: 18655
	[Token(Token = "0x20048DF")]
	public class MiniActivityReviewState : PopupFadeState
	{
		// Token: 0x0601C242 RID: 115266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C242")]
		[Address(RVA = "0x159F1C0", Offset = "0x159DDC0", VA = "0x18159F1C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x170042D4 RID: 17108
		// (get) Token: 0x0601C243 RID: 115267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042D4")]
		public override IStateCacheHandler cacheHandler
		{
			[Token(Token = "0x601C243")]
			[Address(RVA = "0x15A2470", Offset = "0x15A1070", VA = "0x1815A2470", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C244 RID: 115268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C244")]
		[Address(RVA = "0x15A1C60", Offset = "0x15A0860", VA = "0x1815A1C60")]
		private void _SetViewAsTrail()
		{
		}

		// Token: 0x0601C245 RID: 115269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C245")]
		[Address(RVA = "0x15A1A90", Offset = "0x15A0690", VA = "0x1815A1A90")]
		private void _SetViewAsNormal()
		{
		}

		// Token: 0x0601C246 RID: 115270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C246")]
		[Address(RVA = "0x15A0150", Offset = "0x159ED50", VA = "0x1815A0150", Slot = "19")]
		protected override IEnumerator OnPreload()
		{
			return null;
		}

		// Token: 0x0601C247 RID: 115271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C247")]
		[Address(RVA = "0x15A0960", Offset = "0x159F560", VA = "0x1815A0960")]
		private void _InitPanelIfNot()
		{
		}

		// Token: 0x0601C248 RID: 115272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C248")]
		[Address(RVA = "0x159F220", Offset = "0x159DE20", VA = "0x18159F220", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C249 RID: 115273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C249")]
		[Address(RVA = "0x15A0360", Offset = "0x159EF60", VA = "0x1815A0360", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601C24A RID: 115274 RVA: 0x000A7640 File Offset: 0x000A5840
		[Token(Token = "0x601C24A")]
		[Address(RVA = "0x15A08F0", Offset = "0x159F4F0", VA = "0x1815A08F0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0601C24B RID: 115275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C24B")]
		[Address(RVA = "0x15A0200", Offset = "0x159EE00", VA = "0x1815A0200", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601C24C RID: 115276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C24C")]
		[Address(RVA = "0x15A1250", Offset = "0x159FE50", VA = "0x1815A1250")]
		private void _OnJumpBackFromMiniActivityDetailState(ActivityReviewDetailStateBean statebean)
		{
		}

		// Token: 0x0601C24D RID: 115277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C24D")]
		[Address(RVA = "0x15A12E0", Offset = "0x159FEE0", VA = "0x1815A12E0")]
		private void _OnJumpToActivityDetailState(ActivityReviewDetailStateBean targetBean)
		{
		}

		// Token: 0x0601C24E RID: 115278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C24E")]
		[Address(RVA = "0x15A20E0", Offset = "0x15A0CE0", VA = "0x1815A20E0")]
		private void _UpdateProp()
		{
		}

		// Token: 0x0601C24F RID: 115279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C24F")]
		[Address(RVA = "0x15A1EC0", Offset = "0x15A0AC0", VA = "0x1815A1EC0")]
		private void _UpdateCollectTrialTrackPoint()
		{
		}

		// Token: 0x0601C250 RID: 115280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C250")]
		[Address(RVA = "0x15A1920", Offset = "0x15A0520", VA = "0x1815A1920")]
		private void _SetAvailTrialVisited()
		{
		}

		// Token: 0x0601C251 RID: 115281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C251")]
		[Address(RVA = "0x15A0BE0", Offset = "0x159F7E0", VA = "0x1815A0BE0")]
		private void _OnBtnRule()
		{
		}

		// Token: 0x0601C252 RID: 115282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C252")]
		[Address(RVA = "0x15A0C70", Offset = "0x159F870", VA = "0x1815A0C70")]
		private void _OnBtnTrial()
		{
		}

		// Token: 0x0601C253 RID: 115283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C253")]
		[Address(RVA = "0x15A0B60", Offset = "0x159F760", VA = "0x1815A0B60")]
		private void _OnBtnReview()
		{
		}

		// Token: 0x0601C254 RID: 115284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C254")]
		[Address(RVA = "0x15A0A80", Offset = "0x159F680", VA = "0x1815A0A80")]
		private void _OnBackClick()
		{
		}

		// Token: 0x0601C255 RID: 115285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C255")]
		[Address(RVA = "0x15A1060", Offset = "0x159FC60", VA = "0x1815A1060")]
		private void _OnChapterClicked(string chapterId)
		{
		}

		// Token: 0x0601C256 RID: 115286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C256")]
		[Address(RVA = "0x15A1130", Offset = "0x159FD30", VA = "0x1815A1130")]
		private void _OnChapterRewardGain(string chapterId)
		{
		}

		// Token: 0x0601C257 RID: 115287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C257")]
		[Address(RVA = "0x15A1400", Offset = "0x15A0000", VA = "0x1815A1400")]
		private void _OnTrialRewardCollect(string storyId, List<string> rewardIdList)
		{
		}

		// Token: 0x0601C258 RID: 115288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C258")]
		[Address(RVA = "0x15A1640", Offset = "0x15A0240", VA = "0x1815A1640")]
		private void _SendCollectTrialReward(string groupId, List<string> rewardIdList, Action onSucc)
		{
		}

		// Token: 0x0601C259 RID: 115289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C259")]
		[Address(RVA = "0x15A14F0", Offset = "0x15A00F0", VA = "0x1815A14F0")]
		private static IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0601C25A RID: 115290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C25A")]
		[Address(RVA = "0x15A15A0", Offset = "0x15A01A0", VA = "0x1815A15A0")]
		private void _RefreshStoryReviewData()
		{
		}

		// Token: 0x0601C25B RID: 115291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C25B")]
		[Address(RVA = "0x15A2390", Offset = "0x15A0F90", VA = "0x1815A2390")]
		public MiniActivityReviewState()
		{
		}

		// Token: 0x0601C263 RID: 115299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C263")]
		[Address(RVA = "0x12DC030", Offset = "0x12DAC30", VA = "0x1812DC030")]
		private IStateCacheHandler <>xLuaBaseProxy_get_cacheHandler()
		{
			return null;
		}

		// Token: 0x0601C264 RID: 115300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C264")]
		[Address(RVA = "0x15A0840", Offset = "0x159F440", VA = "0x1815A0840")]
		private IEnumerator <>xLuaBaseProxy_OnPreload()
		{
			return null;
		}

		// Token: 0x0601C265 RID: 115301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C265")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601C266 RID: 115302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C266")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601C267 RID: 115303 RVA: 0x000A7658 File Offset: 0x000A5858
		[Token(Token = "0x601C267")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0601C268 RID: 115304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C268")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x04024CAE RID: 150702
		[Token(Token = "0x4024CAE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04024CAF RID: 150703
		[Token(Token = "0x4024CAF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _reviewPanelParent;

		// Token: 0x04024CB0 RID: 150704
		[Token(Token = "0x4024CB0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _trialPanelParent;

		// Token: 0x04024CB1 RID: 150705
		[Token(Token = "0x4024CB1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private MiniActDisplayBinderView _displayBinder;

		// Token: 0x04024CB2 RID: 150706
		[Token(Token = "0x4024CB2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private MiniActTrialBinderView _trailBinderViewPrefab;

		// Token: 0x04024CB3 RID: 150707
		[Token(Token = "0x4024CB3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private MiniActReviewBinderView _reviewBinderViewPrefab;

		// Token: 0x04024CB4 RID: 150708
		[Token(Token = "0x4024CB4")]
		[FieldOffset(Offset = "0xA0")]
		private MiniActReviewStateBean m_stateBean;

		// Token: 0x04024CB5 RID: 150709
		[Token(Token = "0x4024CB5")]
		[FieldOffset(Offset = "0xA8")]
		private MiniActReviewBinderView m_reviewBinderView;

		// Token: 0x04024CB6 RID: 150710
		[Token(Token = "0x4024CB6")]
		[FieldOffset(Offset = "0xB0")]
		private MiniActTrialBinderView m_trialBinderView;

		// Token: 0x04024CB7 RID: 150711
		[Token(Token = "0x4024CB7")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedChapterId;

		// Token: 0x04024CB8 RID: 150712
		[Token(Token = "0x4024CB8")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x04024CB9 RID: 150713
		[Token(Token = "0x4024CB9")]
		[FieldOffset(Offset = "0xC8")]
		private StateCacheHandler<MiniActivityReviewState.StateRuntime> m_cacheHandler;

		// Token: 0x04024CBA RID: 150714
		[Token(Token = "0x4024CBA")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_backToStage;

		// Token: 0x04024CBB RID: 150715
		[Token(Token = "0x4024CBB")]
		[FieldOffset(Offset = "0xD4")]
		private StoryReviewPage.FastExit m_fastExit;

		// Token: 0x04024CBC RID: 150716
		[Token(Token = "0x4024CBC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04024CBD RID: 150717
		[Token(Token = "0x4024CBD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cacheHandler;

		// Token: 0x04024CBE RID: 150718
		[Token(Token = "0x4024CBE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetViewAsTrail;

		// Token: 0x04024CBF RID: 150719
		[Token(Token = "0x4024CBF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetViewAsNormal;

		// Token: 0x04024CC0 RID: 150720
		[Token(Token = "0x4024CC0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPreload;

		// Token: 0x04024CC1 RID: 150721
		[Token(Token = "0x4024CC1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitPanelIfNot;

		// Token: 0x04024CC2 RID: 150722
		[Token(Token = "0x4024CC2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04024CC3 RID: 150723
		[Token(Token = "0x4024CC3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04024CC4 RID: 150724
		[Token(Token = "0x4024CC4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x04024CC5 RID: 150725
		[Token(Token = "0x4024CC5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x04024CC6 RID: 150726
		[Token(Token = "0x4024CC6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnJumpBackFromMiniActivityDetailState;

		// Token: 0x04024CC7 RID: 150727
		[Token(Token = "0x4024CC7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnJumpToActivityDetailState;

		// Token: 0x04024CC8 RID: 150728
		[Token(Token = "0x4024CC8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateProp;

		// Token: 0x04024CC9 RID: 150729
		[Token(Token = "0x4024CC9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateCollectTrialTrackPoint;

		// Token: 0x04024CCA RID: 150730
		[Token(Token = "0x4024CCA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetAvailTrialVisited;

		// Token: 0x04024CCB RID: 150731
		[Token(Token = "0x4024CCB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnBtnRule;

		// Token: 0x04024CCC RID: 150732
		[Token(Token = "0x4024CCC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnBtnTrial;

		// Token: 0x04024CCD RID: 150733
		[Token(Token = "0x4024CCD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnBtnReview;

		// Token: 0x04024CCE RID: 150734
		[Token(Token = "0x4024CCE")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnBackClick;

		// Token: 0x04024CCF RID: 150735
		[Token(Token = "0x4024CCF")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnChapterClicked;

		// Token: 0x04024CD0 RID: 150736
		[Token(Token = "0x4024CD0")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnChapterRewardGain;

		// Token: 0x04024CD1 RID: 150737
		[Token(Token = "0x4024CD1")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnTrialRewardCollect;

		// Token: 0x04024CD2 RID: 150738
		[Token(Token = "0x4024CD2")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SendCollectTrialReward;

		// Token: 0x04024CD3 RID: 150739
		[Token(Token = "0x4024CD3")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x04024CD4 RID: 150740
		[Token(Token = "0x4024CD4")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__RefreshStoryReviewData;

		// Token: 0x04024CD5 RID: 150741
		[Token(Token = "0x4024CD5")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020048E0 RID: 18656
		[Token(Token = "0x20048E0")]
		public struct StateRuntime
		{
			// Token: 0x04024CD6 RID: 150742
			[Token(Token = "0x4024CD6")]
			[FieldOffset(Offset = "0x0")]
			public StoryReviewEntryType entryType;

			// Token: 0x04024CD7 RID: 150743
			[Token(Token = "0x4024CD7")]
			[FieldOffset(Offset = "0x8")]
			public string activityId;

			// Token: 0x04024CD8 RID: 150744
			[Token(Token = "0x4024CD8")]
			[FieldOffset(Offset = "0x10")]
			public bool backToStage;

			// Token: 0x04024CD9 RID: 150745
			[Token(Token = "0x4024CD9")]
			[FieldOffset(Offset = "0x14")]
			public StoryReviewPage.FastExit fastExit;

			// Token: 0x04024CDA RID: 150746
			[Token(Token = "0x4024CDA")]
			[FieldOffset(Offset = "0x18")]
			public bool showTrail;
		}
	}
}
