using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048EC RID: 18668
	[Token(Token = "0x20048EC")]
	public class StoryReviewPage : StateEnginePage, IHotfixable
	{
		// Token: 0x0601C2AA RID: 115370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C2AA")]
		[Address(RVA = "0x15A6800", Offset = "0x15A5400", VA = "0x1815A6800", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601C2AB RID: 115371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C2AB")]
		[Address(RVA = "0x15A6880", Offset = "0x15A5480", VA = "0x1815A6880", Slot = "9")]
		protected override void OnReuse(DataBundle savedInstance)
		{
		}

		// Token: 0x0601C2AC RID: 115372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2AC")]
		[Address(RVA = "0x15A6480", Offset = "0x15A5080", VA = "0x1815A6480", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601C2AD RID: 115373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2AD")]
		[Address(RVA = "0x15A7C30", Offset = "0x15A6830", VA = "0x1815A7C30")]
		private IEnumerator _SetStateViaParam(DataBundle param)
		{
			return null;
		}

		// Token: 0x0601C2AE RID: 115374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C2AE")]
		[Address(RVA = "0x15A7680", Offset = "0x15A6280", VA = "0x1815A7680")]
		private void _OnPageCreated(DataBundle savedInst)
		{
		}

		// Token: 0x0601C2AF RID: 115375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2AF")]
		[Address(RVA = "0x15A77D0", Offset = "0x15A63D0", VA = "0x1815A77D0")]
		private IEnumerator _RouteToEntryCoroutine(bool useFastMode = false)
		{
			return null;
		}

		// Token: 0x0601C2B0 RID: 115376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2B0")]
		[Address(RVA = "0x15A73A0", Offset = "0x15A5FA0", VA = "0x1815A73A0")]
		private IEnumerator _JumpToActivityState(DataBundle param)
		{
			return null;
		}

		// Token: 0x0601C2B1 RID: 115377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2B1")]
		[Address(RVA = "0x15A7470", Offset = "0x15A6070", VA = "0x1815A7470")]
		private IEnumerator _JumpToMiniState(DataBundle param)
		{
			return null;
		}

		// Token: 0x0601C2B2 RID: 115378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2B2")]
		[Address(RVA = "0x15A61C0", Offset = "0x15A4DC0", VA = "0x1815A61C0")]
		public string GetStoryBrief(string storyId)
		{
			return null;
		}

		// Token: 0x0601C2B3 RID: 115379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2B3")]
		[Address(RVA = "0x15A72D0", Offset = "0x15A5ED0", VA = "0x1815A72D0")]
		private string _GetStoryPath(string key)
		{
			return null;
		}

		// Token: 0x0601C2B4 RID: 115380 RVA: 0x000A7718 File Offset: 0x000A5918
		[Token(Token = "0x601C2B4")]
		[Address(RVA = "0x15A5F50", Offset = "0x15A4B50", VA = "0x1815A5F50")]
		public bool CheckIfDataTimeoutAndResync()
		{
			return default(bool);
		}

		// Token: 0x0601C2B5 RID: 115381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2B5")]
		[Address(RVA = "0x15A63F0", Offset = "0x15A4FF0", VA = "0x1815A63F0")]
		public PlayerStoryReview GetStoryReviewData()
		{
			return null;
		}

		// Token: 0x0601C2B6 RID: 115382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2B6")]
		[Address(RVA = "0x15A66A0", Offset = "0x15A52A0", VA = "0x1815A66A0")]
		public static Sprite LoadStoryReviewEntryImage(string storyEntryPicId, StoryReviewType reviewType)
		{
			return null;
		}

		// Token: 0x0601C2B7 RID: 115383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2B7")]
		[Address(RVA = "0x15A6530", Offset = "0x15A5130", VA = "0x1815A6530")]
		public static Sprite LoadMiniActTrialTitleSprite(string actId)
		{
			return null;
		}

		// Token: 0x0601C2B8 RID: 115384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2B8")]
		[Address(RVA = "0x15A7540", Offset = "0x15A6140", VA = "0x1815A7540")]
		private static Sprite _LoadAutoPackSprite(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0601C2B9 RID: 115385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2B9")]
		[Address(RVA = "0x15A6630", Offset = "0x15A5230", VA = "0x1815A6630")]
		public static Sprite LoadMiniStoryImage(string storyPicId)
		{
			return null;
		}

		// Token: 0x0601C2BA RID: 115386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2BA")]
		[Address(RVA = "0x15A65C0", Offset = "0x15A51C0", VA = "0x1815A65C0")]
		public static Sprite LoadMiniStoryCharImage(string miniStoryPicId)
		{
			return null;
		}

		// Token: 0x0601C2BB RID: 115387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C2BB")]
		[Address(RVA = "0x15A6E10", Offset = "0x15A5A10", VA = "0x1815A6E10")]
		public static void SendStoryReviewUnlock(StoryReviewViewModel viewModel, Action onSucc)
		{
		}

		// Token: 0x0601C2BC RID: 115388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C2BC")]
		[Address(RVA = "0x15A6BC0", Offset = "0x15A57C0", VA = "0x1815A6BC0")]
		public static void SendStoryReviewRead(string storyId, Action onSucc)
		{
		}

		// Token: 0x0601C2BD RID: 115389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C2BD")]
		[Address(RVA = "0x15A6910", Offset = "0x15A5510", VA = "0x1815A6910")]
		public static void SendRewardGain(StoryReviewChapterViewModel chapter, Action onSucc)
		{
		}

		// Token: 0x0601C2BE RID: 115390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2BE")]
		[Address(RVA = "0x15A7700", Offset = "0x15A6300", VA = "0x1815A7700")]
		private static IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onSuccess)
		{
			return null;
		}

		// Token: 0x0601C2BF RID: 115391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2BF")]
		[Address(RVA = "0x15A5FE0", Offset = "0x15A4BE0", VA = "0x1815A5FE0")]
		public static DataBundle DataBundleToStoryReviewDetail(StoryReviewEntryType entryType, string chapterId, float scrollPos, bool backToStage = false, bool exitOnReview = false, bool exitOnDetail = false, bool miniTrail = false)
		{
			return null;
		}

		// Token: 0x0601C2C0 RID: 115392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C2C0")]
		[Address(RVA = "0x15A7190", Offset = "0x15A5D90", VA = "0x1815A7190")]
		public static void StartAVGAndBackToStoryReview(StoryData targetStory, DataBundle stateBundle)
		{
		}

		// Token: 0x0601C2C1 RID: 115393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2C1")]
		[Address(RVA = "0x15A7890", Offset = "0x15A6490", VA = "0x1815A7890")]
		private static UIPageControllerParam _SceneParamToState(DataBundle bundleToState)
		{
			return null;
		}

		// Token: 0x0601C2C2 RID: 115394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C2C2")]
		[Address(RVA = "0x15A7D00", Offset = "0x15A6900", VA = "0x1815A7D00")]
		public StoryReviewPage()
		{
		}

		// Token: 0x0601C2C4 RID: 115396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C2C4")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601C2C5 RID: 115397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C2C5")]
		[Address(RVA = "0x1551CD0", Offset = "0x15508D0", VA = "0x181551CD0")]
		private void <>xLuaBaseProxy_OnReuse(DataBundle P0)
		{
		}

		// Token: 0x0601C2C6 RID: 115398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C2C6")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x04024D0E RID: 150798
		[Token(Token = "0x4024D0E")]
		[FieldOffset(Offset = "0xF0")]
		private DataBundle m_initBundle;

		// Token: 0x04024D0F RID: 150799
		[Token(Token = "0x4024D0F")]
		private const string STORY_FOLDER = "GameData/Story";

		// Token: 0x04024D10 RID: 150800
		[Token(Token = "0x4024D10")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04024D11 RID: 150801
		[Token(Token = "0x4024D11")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReuse;

		// Token: 0x04024D12 RID: 150802
		[Token(Token = "0x4024D12")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04024D13 RID: 150803
		[Token(Token = "0x4024D13")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetStateViaParam;

		// Token: 0x04024D14 RID: 150804
		[Token(Token = "0x4024D14")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnPageCreated;

		// Token: 0x04024D15 RID: 150805
		[Token(Token = "0x4024D15")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RouteToEntryCoroutine;

		// Token: 0x04024D16 RID: 150806
		[Token(Token = "0x4024D16")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__JumpToActivityState;

		// Token: 0x04024D17 RID: 150807
		[Token(Token = "0x4024D17")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__JumpToMiniState;

		// Token: 0x04024D18 RID: 150808
		[Token(Token = "0x4024D18")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetStoryBrief;

		// Token: 0x04024D19 RID: 150809
		[Token(Token = "0x4024D19")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetStoryPath;

		// Token: 0x04024D1A RID: 150810
		[Token(Token = "0x4024D1A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfDataTimeoutAndResync;

		// Token: 0x04024D1B RID: 150811
		[Token(Token = "0x4024D1B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetStoryReviewData;

		// Token: 0x04024D1C RID: 150812
		[Token(Token = "0x4024D1C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadStoryReviewEntryImage;

		// Token: 0x04024D1D RID: 150813
		[Token(Token = "0x4024D1D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadMiniActTrialTitleSprite;

		// Token: 0x04024D1E RID: 150814
		[Token(Token = "0x4024D1E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LoadAutoPackSprite;

		// Token: 0x04024D1F RID: 150815
		[Token(Token = "0x4024D1F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_LoadMiniStoryImage;

		// Token: 0x04024D20 RID: 150816
		[Token(Token = "0x4024D20")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadMiniStoryCharImage;

		// Token: 0x04024D21 RID: 150817
		[Token(Token = "0x4024D21")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SendStoryReviewUnlock;

		// Token: 0x04024D22 RID: 150818
		[Token(Token = "0x4024D22")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SendStoryReviewRead;

		// Token: 0x04024D23 RID: 150819
		[Token(Token = "0x4024D23")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SendRewardGain;

		// Token: 0x04024D24 RID: 150820
		[Token(Token = "0x4024D24")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x04024D25 RID: 150821
		[Token(Token = "0x4024D25")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_DataBundleToStoryReviewDetail;

		// Token: 0x04024D26 RID: 150822
		[Token(Token = "0x4024D26")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_StartAVGAndBackToStoryReview;

		// Token: 0x04024D27 RID: 150823
		[Token(Token = "0x4024D27")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__SceneParamToState;

		// Token: 0x04024D28 RID: 150824
		[Token(Token = "0x4024D28")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020048ED RID: 18669
		[Token(Token = "0x20048ED")]
		[Flags]
		public enum FastExit
		{
			// Token: 0x04024D2A RID: 150826
			[Token(Token = "0x4024D2A")]
			NONE = 0,
			// Token: 0x04024D2B RID: 150827
			[Token(Token = "0x4024D2B")]
			EXIT_ON_REVIEW = 1,
			// Token: 0x04024D2C RID: 150828
			[Token(Token = "0x4024D2C")]
			EXIT_ON_DETAIL = 2
		}
	}
}
