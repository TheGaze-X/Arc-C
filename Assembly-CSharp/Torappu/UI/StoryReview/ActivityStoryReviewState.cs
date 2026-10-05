using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048D8 RID: 18648
	[Token(Token = "0x20048D8")]
	public class ActivityStoryReviewState : PopupFadeState
	{
		// Token: 0x0601C20B RID: 115211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C20B")]
		[Address(RVA = "0x15938E0", Offset = "0x15924E0", VA = "0x1815938E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x170042D2 RID: 17106
		// (get) Token: 0x0601C20C RID: 115212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042D2")]
		public override IStateCacheHandler cacheHandler
		{
			[Token(Token = "0x601C20C")]
			[Address(RVA = "0x1594A70", Offset = "0x1593670", VA = "0x181594A70", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C20D RID: 115213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C20D")]
		[Address(RVA = "0x1593940", Offset = "0x1592540", VA = "0x181593940", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C20E RID: 115214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C20E")]
		[Address(RVA = "0x1593CA0", Offset = "0x15928A0", VA = "0x181593CA0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601C20F RID: 115215 RVA: 0x000A75C8 File Offset: 0x000A57C8
		[Token(Token = "0x601C20F")]
		[Address(RVA = "0x1594400", Offset = "0x1593000", VA = "0x181594400", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0601C210 RID: 115216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C210")]
		[Address(RVA = "0x1593B40", Offset = "0x1592740", VA = "0x181593B40", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601C211 RID: 115217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C211")]
		[Address(RVA = "0x1594870", Offset = "0x1593470", VA = "0x181594870")]
		private void _OnJumpToActivityDetailState(ActivityReviewDetailStateBean targetBean)
		{
		}

		// Token: 0x0601C212 RID: 115218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C212")]
		[Address(RVA = "0x1594720", Offset = "0x1593320", VA = "0x181594720")]
		private void _OnJumpBackFromMiniActivityDetailState(ActivityReviewDetailStateBean statebean)
		{
		}

		// Token: 0x0601C213 RID: 115219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C213")]
		[Address(RVA = "0x1594470", Offset = "0x1593070", VA = "0x181594470")]
		private void _OnBackClick()
		{
		}

		// Token: 0x0601C214 RID: 115220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C214")]
		[Address(RVA = "0x1594540", Offset = "0x1593140", VA = "0x181594540")]
		private void _OnChapterClicked(string chapterId)
		{
		}

		// Token: 0x0601C215 RID: 115221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C215")]
		[Address(RVA = "0x1594600", Offset = "0x1593200", VA = "0x181594600")]
		private void _OnChapterRewardGain(string chapterId)
		{
		}

		// Token: 0x0601C216 RID: 115222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C216")]
		[Address(RVA = "0x1594260", Offset = "0x1592E60", VA = "0x181594260")]
		private void _RefreshStoryReviewData()
		{
		}

		// Token: 0x0601C217 RID: 115223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C217")]
		[Address(RVA = "0x15949A0", Offset = "0x15935A0", VA = "0x1815949A0")]
		public ActivityStoryReviewState()
		{
		}

		// Token: 0x0601C21D RID: 115229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C21D")]
		[Address(RVA = "0x12DC030", Offset = "0x12DAC30", VA = "0x1812DC030")]
		private IStateCacheHandler <>xLuaBaseProxy_get_cacheHandler()
		{
			return null;
		}

		// Token: 0x0601C21E RID: 115230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C21E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601C21F RID: 115231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C21F")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601C220 RID: 115232 RVA: 0x000A75E0 File Offset: 0x000A57E0
		[Token(Token = "0x601C220")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0601C221 RID: 115233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C221")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x04024C68 RID: 150632
		[Token(Token = "0x4024C68")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04024C69 RID: 150633
		[Token(Token = "0x4024C69")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActivityReviewBinder _activityReviewBinder;

		// Token: 0x04024C6A RID: 150634
		[Token(Token = "0x4024C6A")]
		[FieldOffset(Offset = "0x80")]
		private StoryReviewStateBean m_stateBean;

		// Token: 0x04024C6B RID: 150635
		[Token(Token = "0x4024C6B")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedChapterId;

		// Token: 0x04024C6C RID: 150636
		[Token(Token = "0x4024C6C")]
		[FieldOffset(Offset = "0x90")]
		private StateCacheHandler<ActivityStoryReviewState.StateRuntime> m_cacheHandler;

		// Token: 0x04024C6D RID: 150637
		[Token(Token = "0x4024C6D")]
		[FieldOffset(Offset = "0x98")]
		private StoryReviewPage.FastExit m_fastExit;

		// Token: 0x04024C6E RID: 150638
		[Token(Token = "0x4024C6E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04024C6F RID: 150639
		[Token(Token = "0x4024C6F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cacheHandler;

		// Token: 0x04024C70 RID: 150640
		[Token(Token = "0x4024C70")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04024C71 RID: 150641
		[Token(Token = "0x4024C71")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04024C72 RID: 150642
		[Token(Token = "0x4024C72")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x04024C73 RID: 150643
		[Token(Token = "0x4024C73")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x04024C74 RID: 150644
		[Token(Token = "0x4024C74")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnJumpToActivityDetailState;

		// Token: 0x04024C75 RID: 150645
		[Token(Token = "0x4024C75")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpBackFromMiniActivityDetailState;

		// Token: 0x04024C76 RID: 150646
		[Token(Token = "0x4024C76")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBackClick;

		// Token: 0x04024C77 RID: 150647
		[Token(Token = "0x4024C77")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnChapterClicked;

		// Token: 0x04024C78 RID: 150648
		[Token(Token = "0x4024C78")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnChapterRewardGain;

		// Token: 0x04024C79 RID: 150649
		[Token(Token = "0x4024C79")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RefreshStoryReviewData;

		// Token: 0x04024C7A RID: 150650
		[Token(Token = "0x4024C7A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020048D9 RID: 18649
		[Token(Token = "0x20048D9")]
		public struct StateRuntime
		{
			// Token: 0x04024C7B RID: 150651
			[Token(Token = "0x4024C7B")]
			[FieldOffset(Offset = "0x0")]
			public StoryReviewEntryType entryType;

			// Token: 0x04024C7C RID: 150652
			[Token(Token = "0x4024C7C")]
			[FieldOffset(Offset = "0x8")]
			public string activityId;

			// Token: 0x04024C7D RID: 150653
			[Token(Token = "0x4024C7D")]
			[FieldOffset(Offset = "0x10")]
			public StoryReviewPage.FastExit fastExit;
		}
	}
}
