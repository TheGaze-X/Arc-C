using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Activity.VecBreakV2;
using Torappu.Resource;
using Torappu.UI.HotUpdate;
using Torappu.UI.Shop;
using XLua;

namespace Torappu.EventTrack
{
	// Token: 0x02001FD5 RID: 8149
	[Token(Token = "0x2001FD5")]
	[Hotfix(HotfixFlag.Stateless)]
	public class EventLogTrace : Singleton<EventLogTrace>
	{
		// Token: 0x0600CA57 RID: 51799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA57")]
		[Address(RVA = "0x34A8330", Offset = "0x34A6F30", VA = "0x1834A8330")]
		public void EventOnAct45SideLiveEntryClicked()
		{
		}

		// Token: 0x0600CA58 RID: 51800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA58")]
		[Address(RVA = "0x34A8450", Offset = "0x34A7050", VA = "0x1834A8450")]
		public void EventOnArtGalleryButtonClicked(EventLogTrace.ArtGalleryClickRank clickRank, [Optional] string clickPage, [Optional] string clickBtn, [Optional] string itemId, [Optional] string relateSet, [Optional] List<EventLogTrace.EventLogArtGalleryContext.CollectionRewardStatus> rewardStatus, int leafVersion = 0, bool isLeafTemplate = false)
		{
		}

		// Token: 0x0600CA59 RID: 51801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA59")]
		[Address(RVA = "0x34A86F0", Offset = "0x34A72F0", VA = "0x1834A86F0")]
		public void EventOnArtMagazineFirstRewardDialogOpen()
		{
		}

		// Token: 0x0600CA5A RID: 51802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA5A")]
		[Address(RVA = "0x34A8C80", Offset = "0x34A7880", VA = "0x1834A8C80")]
		public void EventOnBackflowTabClicked(string groupId, string tab)
		{
		}

		// Token: 0x0600CA5B RID: 51803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA5B")]
		[Address(RVA = "0x34A8B00", Offset = "0x34A7700", VA = "0x1834A8B00")]
		public void EventOnBackflowSpecialOpenJumpClicked(string groupId, EventLogTrace.EventLogBackflowTraceContext.BackflowSpecialOpenType type, bool unlocked)
		{
		}

		// Token: 0x0600CA5C RID: 51804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA5C")]
		[Address(RVA = "0x34A8980", Offset = "0x34A7580", VA = "0x1834A8980")]
		public void EventOnBackflowNewsJumpClicked(string groupId, EventLogTrace.EventLogBackflowTraceContext.BackflowNewsJumpType type, bool unlocked)
		{
		}

		// Token: 0x0600CA5D RID: 51805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA5D")]
		[Address(RVA = "0x34A8810", Offset = "0x34A7410", VA = "0x1834A8810")]
		public void EventOnBackflowHomePageShowed(string groupId, bool clicked)
		{
		}

		// Token: 0x0600CA5E RID: 51806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA5E")]
		[Address(RVA = "0x34ACA70", Offset = "0x34AB670", VA = "0x1834ACA70")]
		public void EventOnStartBuildingCharControl(string charId, bool isOwn, string roomSlotId)
		{
		}

		// Token: 0x0600CA5F RID: 51807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA5F")]
		[Address(RVA = "0x34A95D0", Offset = "0x34A81D0", VA = "0x1834A95D0")]
		public void EventOnEndBuildingCharControl(string charId, bool isOwn, string roomSlotId)
		{
		}

		// Token: 0x0600CA60 RID: 51808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA60")]
		[Address(RVA = "0x34A8DF0", Offset = "0x34A79F0", VA = "0x1834A8DF0")]
		public void EventOnBuildingSortClicked(string sortType, bool isInverse, string roomType, string roomProduct, string roomSlotId)
		{
		}

		// Token: 0x0600CA61 RID: 51809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA61")]
		[Address(RVA = "0x34A9020", Offset = "0x34A7C20", VA = "0x1834A9020")]
		public void EventOnCGGalleryEntryClicked(string storySetId)
		{
		}

		// Token: 0x0600CA62 RID: 51810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA62")]
		[Address(RVA = "0x34A9280", Offset = "0x34A7E80", VA = "0x1834A9280")]
		public void EventOnCGGalleryUnlockStatus(string storylineId, List<string> cgList)
		{
		}

		// Token: 0x0600CA63 RID: 51811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA63")]
		[Address(RVA = "0x34A9160", Offset = "0x34A7D60", VA = "0x1834A9160")]
		public void EventOnCGGalleryFavouriteModeClicked()
		{
		}

		// Token: 0x0600CA64 RID: 51812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA64")]
		[Address(RVA = "0x34A93F0", Offset = "0x34A7FF0", VA = "0x1834A93F0")]
		public void EventOnCheckinVideoBtnClicked(string actId, string btnType, int pageOrder, [Optional] string btnSubType)
		{
		}

		// Token: 0x0600CA65 RID: 51813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA65")]
		[Address(RVA = "0x34A9F00", Offset = "0x34A8B00", VA = "0x1834A9F00")]
		public void EventOnHomeActClicked(string actId, bool isClicked)
		{
		}

		// Token: 0x0600CA66 RID: 51814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA66")]
		[Address(RVA = "0x34A9CD0", Offset = "0x34A88D0", VA = "0x1834A9CD0")]
		public void EventOnEnemyDuelEmoteClicked(string actId, string sceneId, string modeId, bool emoteOn)
		{
		}

		// Token: 0x0600CA67 RID: 51815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA67")]
		[Address(RVA = "0x34A9760", Offset = "0x34A8360", VA = "0x1834A9760")]
		public void EventOnEnemyDuelAfterBattleToEntryClicked(string actId, string sceneId, string modeId)
		{
		}

		// Token: 0x0600CA68 RID: 51816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA68")]
		[Address(RVA = "0x34A9B00", Offset = "0x34A8700", VA = "0x1834A9B00")]
		public void EventOnEnemyDuelAfterBattleToRoomClicked(string actId, string sceneId, string modeId)
		{
		}

		// Token: 0x0600CA69 RID: 51817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA69")]
		[Address(RVA = "0x34A9930", Offset = "0x34A8530", VA = "0x1834A9930")]
		public void EventOnEnemyDuelAfterBattleToMatchClicked(string actId, string sceneId, string modeId)
		{
		}

		// Token: 0x0600CA6A RID: 51818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CA6A")]
		[Address(RVA = "0x34AF450", Offset = "0x34AE050", VA = "0x1834AF450")]
		private List<string> _GenPrefList()
		{
			return null;
		}

		// Token: 0x0600CA6B RID: 51819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA6B")]
		[Address(RVA = "0x34AA410", Offset = "0x34A9010", VA = "0x1834AA410")]
		public void EventOnHotUpdateDownloadStart(string versionId, long srcSize, bool isPreMain)
		{
		}

		// Token: 0x0600CA6C RID: 51820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA6C")]
		[Address(RVA = "0x34AA200", Offset = "0x34A8E00", VA = "0x1834AA200")]
		public void EventOnHotUpdateCheckConsistencyStart(ConsistencyChecker.CheckType checkType)
		{
		}

		// Token: 0x0600CA6D RID: 51821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA6D")]
		[Address(RVA = "0x34AE5C0", Offset = "0x34AD1C0", VA = "0x1834AE5C0")]
		public void RecordHotupdatePrecent(float percent)
		{
		}

		// Token: 0x0600CA6E RID: 51822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA6E")]
		[Address(RVA = "0x34AE400", Offset = "0x34AD000", VA = "0x1834AE400")]
		public void RecordHotupdateDownloadFinish(bool ispremain)
		{
		}

		// Token: 0x0600CA6F RID: 51823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA6F")]
		[Address(RVA = "0x34AE070", Offset = "0x34ACC70", VA = "0x1834AE070")]
		public void RecordCheckConsistencyFinish(ConsistencyChecker.CheckType checkType)
		{
		}

		// Token: 0x0600CA70 RID: 51824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA70")]
		[Address(RVA = "0x34AE230", Offset = "0x34ACE30", VA = "0x1834AE230")]
		public void RecordDownloadInterrupt(HotUpdater.LogTraceErrorCode info)
		{
		}

		// Token: 0x0600CA71 RID: 51825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA71")]
		[Address(RVA = "0x34ADEA0", Offset = "0x34ACAA0", VA = "0x1834ADEA0")]
		public void RecordCheckConsistencyFail(HotUpdater.LogTraceErrorCode info)
		{
		}

		// Token: 0x0600CA72 RID: 51826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA72")]
		[Address(RVA = "0x34AE820", Offset = "0x34AD420", VA = "0x1834AE820")]
		public void RecordSelectMainPackMode(HotUpdater.UpdatePreferenceType type, string size)
		{
		}

		// Token: 0x0600CA73 RID: 51827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA73")]
		[Address(RVA = "0x34AEB30", Offset = "0x34AD730", VA = "0x1834AEB30")]
		public void RecordUpdateVoiceLangMode(List<HotUpdateVoicePackItemViewModel> list)
		{
		}

		// Token: 0x0600CA74 RID: 51828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA74")]
		[Address(RVA = "0x34AE9C0", Offset = "0x34AD5C0", VA = "0x1834AE9C0")]
		public void RecordUpdateTypeList(IList<string> srcList)
		{
		}

		// Token: 0x0600CA75 RID: 51829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA75")]
		[Address(RVA = "0x34AAE20", Offset = "0x34A9A20", VA = "0x1834AAE20")]
		public void EventOnRoguelikeNodeChoiceBack(string choiceId, string nodeType)
		{
		}

		// Token: 0x0600CA76 RID: 51830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA76")]
		[Address(RVA = "0x34AA9A0", Offset = "0x34A95A0", VA = "0x1834AA9A0")]
		public void EventOnRoguelikeCopperBoxView()
		{
		}

		// Token: 0x0600CA77 RID: 51831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA77")]
		[Address(RVA = "0x34AAAC0", Offset = "0x34A96C0", VA = "0x1834AAAC0")]
		public void EventOnRoguelikeCopperInEffectView()
		{
		}

		// Token: 0x0600CA78 RID: 51832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA78")]
		[Address(RVA = "0x34AABE0", Offset = "0x34A97E0", VA = "0x1834AABE0")]
		public void EventOnRoguelikeCopperStepNumView()
		{
		}

		// Token: 0x0600CA79 RID: 51833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA79")]
		[Address(RVA = "0x34AAD00", Offset = "0x34A9900", VA = "0x1834AAD00")]
		public void EventOnRoguelikeCopperStoringRecruitView()
		{
		}

		// Token: 0x0600CA7A RID: 51834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA7A")]
		[Address(RVA = "0x34AB5A0", Offset = "0x34AA1A0", VA = "0x1834AB5A0")]
		public void EventOnShopEntryClicked()
		{
		}

		// Token: 0x0600CA7B RID: 51835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA7B")]
		[Address(RVA = "0x34AA070", Offset = "0x34A8C70", VA = "0x1834AA070")]
		public void EventOnHomeBannerClicked(EventLogTrace.EventLogShopContext.ShopClickRank rank, string clickBtn)
		{
		}

		// Token: 0x0600CA7C RID: 51836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA7C")]
		[Address(RVA = "0x34AB3A0", Offset = "0x34A9FA0", VA = "0x1834AB3A0")]
		public void EventOnShopClosureItemClicked(long enterTs, string viewTab, EventLogTrace.EventLogShopContext.ShopClickRank rank, string clickBtn)
		{
		}

		// Token: 0x0600CA7D RID: 51837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA7D")]
		[Address(RVA = "0x34AB230", Offset = "0x34A9E30", VA = "0x1834AB230")]
		public void EventOnShopCashTitleClicked()
		{
		}

		// Token: 0x0600CA7E RID: 51838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA7E")]
		[Address(RVA = "0x34AB710", Offset = "0x34AA310", VA = "0x1834AB710")]
		public void EventOnShopPackageClicked(long enterTs, string viewTab, EventLogTrace.EventLogShopContext.ShopClickRank rank, string clickBtn, ShopPage.Referrer clickRef = ShopPage.Referrer.NONE)
		{
		}

		// Token: 0x0600CA7F RID: 51839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA7F")]
		[Address(RVA = "0x34ABBA0", Offset = "0x34AA7A0", VA = "0x1834ABBA0")]
		public void EventOnShopSkinClicked(long enterTs, string viewTab, EventLogTrace.EventLogShopContext.ShopClickRank rank, string clickBtn, ShopPage.Referrer clickRef = ShopPage.Referrer.NONE)
		{
		}

		// Token: 0x0600CA80 RID: 51840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA80")]
		[Address(RVA = "0x34AAF80", Offset = "0x34A9B80", VA = "0x1834AAF80")]
		public void EventOnShopBlindBoxDetailClicked(long enterTs, string viewTab, EventLogTrace.EventLogShopContext.ShopClickRank rank, string clickBtn, List<string> skinBoxList, bool isObtainable, ShopPage.Referrer clickRef)
		{
		}

		// Token: 0x0600CA81 RID: 51841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA81")]
		[Address(RVA = "0x34AB970", Offset = "0x34AA570", VA = "0x1834AB970")]
		public void EventOnShopPackageShowed(long enterTs, string viewTab, string goodId, int remainCount, ShopPage.Referrer clickRef = ShopPage.Referrer.NONE)
		{
		}

		// Token: 0x0600CA82 RID: 51842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA82")]
		[Address(RVA = "0x34ABE00", Offset = "0x34AAA00", VA = "0x1834ABE00")]
		public void EventOnShopSkinShowed(long enterTs, string viewTab, string goodId, int remainCount, ShopPage.Referrer clickRef = ShopPage.Referrer.NONE)
		{
		}

		// Token: 0x0600CA83 RID: 51843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA83")]
		[Address(RVA = "0x34AC600", Offset = "0x34AB200", VA = "0x1834AC600")]
		public void EventOnSocialCardAlbumPageOpen(string friendUid, bool hasLeafData)
		{
		}

		// Token: 0x0600CA84 RID: 51844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA84")]
		[Address(RVA = "0x34AC450", Offset = "0x34AB050", VA = "0x1834AC450")]
		public void EventOnSocialCardAlbumLeafExpose(string friendUid, string leafId, int leafIndex)
		{
		}

		// Token: 0x0600CA85 RID: 51845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA85")]
		[Address(RVA = "0x34AC300", Offset = "0x34AAF00", VA = "0x1834AC300")]
		public void EventOnSoCharEnterSummary(string targetId, string charId)
		{
		}

		// Token: 0x0600CA86 RID: 51846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA86")]
		[Address(RVA = "0x34AC1B0", Offset = "0x34AADB0", VA = "0x1834AC1B0")]
		public void EventOnSoCharEnterLvlup(string targetId, string charId)
		{
		}

		// Token: 0x0600CA87 RID: 51847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA87")]
		[Address(RVA = "0x34AC030", Offset = "0x34AAC30", VA = "0x1834AC030")]
		public void EventOnSoCharEnterInfo(string targetId, string charId, string source)
		{
		}

		// Token: 0x0600CA88 RID: 51848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA88")]
		[Address(RVA = "0x34AC7A0", Offset = "0x34AB3A0", VA = "0x1834AC7A0")]
		public void EventOnSquadAssistApplyBtnClick(string uid, bool isStarFriend, bool isStarFriendFirst, SharedCharData assistChar, EventLogTrace.EventLogSquadContext.SquadAssistType assistType)
		{
		}

		// Token: 0x0600CA89 RID: 51849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA89")]
		[Address(RVA = "0x34AF910", Offset = "0x34AE510", VA = "0x1834AF910")]
		private EventLogTrace()
		{
		}

		// Token: 0x0600CA8A RID: 51850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA8A")]
		[Address(RVA = "0x34AF1B0", Offset = "0x34ADDB0", VA = "0x1834AF1B0")]
		public void SetStoryStartInfo(string storyId, bool isFirstTime)
		{
		}

		// Token: 0x0600CA8B RID: 51851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA8B")]
		[Address(RVA = "0x34AEE90", Offset = "0x34ADA90", VA = "0x1834AEE90")]
		public void SetHandbookInfo(string storyId)
		{
		}

		// Token: 0x0600CA8C RID: 51852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA8C")]
		[Address(RVA = "0x34AEFB0", Offset = "0x34ADBB0", VA = "0x1834AEFB0")]
		public void SetStoryReviewInfo(string storyId)
		{
		}

		// Token: 0x0600CA8D RID: 51853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA8D")]
		[Address(RVA = "0x34AED70", Offset = "0x34AD970", VA = "0x1834AED70")]
		public void SetCGGalleryInfo(string storyId)
		{
		}

		// Token: 0x0600CA8E RID: 51854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA8E")]
		[Address(RVA = "0x34AD9E0", Offset = "0x34AC5E0", VA = "0x1834AD9E0")]
		public void OnStoryBegin(string storyId)
		{
		}

		// Token: 0x0600CA8F RID: 51855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA8F")]
		[Address(RVA = "0x34ADBF0", Offset = "0x34AC7F0", VA = "0x1834ADBF0")]
		public void OnStoryEnd(string storyId, string errorMsg)
		{
		}

		// Token: 0x0600CA90 RID: 51856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA90")]
		[Address(RVA = "0x34AF7D0", Offset = "0x34AE3D0", VA = "0x1834AF7D0")]
		private void _LogToSDK(string eventName, object data)
		{
		}

		// Token: 0x0600CA91 RID: 51857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA91")]
		[Address(RVA = "0x34AA810", Offset = "0x34A9410", VA = "0x1834AA810")]
		public void EventOnRequestShareClicked(string actId, int metaCount, List<int> requestValue)
		{
		}

		// Token: 0x0600CA92 RID: 51858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA92")]
		[Address(RVA = "0x34ACC00", Offset = "0x34AB800", VA = "0x1834ACC00")]
		public void EventOnSwitchTabClicked(string actId, string tabId)
		{
		}

		// Token: 0x0600CA93 RID: 51859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA93")]
		[Address(RVA = "0x34AA680", Offset = "0x34A9280", VA = "0x1834AA680")]
		public void EventOnInviteClicked(string actId, string inviteId, int teamSize)
		{
		}

		// Token: 0x0600CA94 RID: 51860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA94")]
		[Address(RVA = "0x34AD3D0", Offset = "0x34ABFD0", VA = "0x1834AD3D0")]
		public void EventOnVecBreakV2EnterDefenseMain(string actId, string source)
		{
		}

		// Token: 0x0600CA95 RID: 51861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA95")]
		[Address(RVA = "0x34AD640", Offset = "0x34AC240", VA = "0x1834AD640")]
		public void EventOnVecBreakV2SquadChangeSquadBuff(string actId, ActVecBreakV2SquadBuffSelectViewModel model)
		{
		}

		// Token: 0x0600CA96 RID: 51862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA96")]
		[Address(RVA = "0x34AF300", Offset = "0x34ADF00", VA = "0x1834AF300")]
		private void _FetchPlayerBuffList(string actId, List<string> buffList)
		{
		}

		// Token: 0x0600CA97 RID: 51863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA97")]
		[Address(RVA = "0x34ACD70", Offset = "0x34AB970", VA = "0x1834ACD70")]
		public void EventOnVecBreakV2DefenseChangeBuff(string actId, ActVecBreakV2DefenseStageSelectViewModel model, List<string> buffList)
		{
		}

		// Token: 0x0600CA98 RID: 51864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA98")]
		[Address(RVA = "0x34AD520", Offset = "0x34AC120", VA = "0x1834AD520")]
		public void EventOnVecBreakV2EnterDefenseOverview(string actId)
		{
		}

		// Token: 0x0600CA99 RID: 51865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA99")]
		[Address(RVA = "0x34AD250", Offset = "0x34ABE50", VA = "0x1834AD250")]
		public void EventOnVecBreakV2DefenseOut(string actId, string source, List<EventLogTrace.EventLogVecBreakV2Context.DefenseStageInfo> defenseInfo)
		{
		}

		// Token: 0x0600CA9A RID: 51866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CA9A")]
		[Address(RVA = "0x34AD040", Offset = "0x34ABC40", VA = "0x1834AD040")]
		public void EventOnVecBreakV2DefenseOut(string actId, string source, string stageId, ActVecBreakV2DefenseStageDetailViewModel detailViewModel)
		{
		}

		// Token: 0x0400D2F4 RID: 54004
		[Token(Token = "0x400D2F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private EventLogTrace.EventLogHotUpdateContext m_context;

		// Token: 0x0400D2F5 RID: 54005
		[Token(Token = "0x400D2F5")]
		public const string EVENT_NAME_START = "story_read_start";

		// Token: 0x0400D2F6 RID: 54006
		[Token(Token = "0x400D2F6")]
		public const string EVENT_NAME_END = "story_read_end";

		// Token: 0x0400D2F7 RID: 54007
		[Token(Token = "0x400D2F7")]
		public const string STORY_ONLY_FIRST_ENTRANCE_NAME = "story_first";

		// Token: 0x0400D2F8 RID: 54008
		[Token(Token = "0x400D2F8")]
		public const string STORY_ONLY_REPEAT_ENTRANCE_NAME = "story_repeat";

		// Token: 0x0400D2F9 RID: 54009
		[Token(Token = "0x400D2F9")]
		public const string HANDBOOK_STORY_ENTRANCE_NAME = "handbook";

		// Token: 0x0400D2FA RID: 54010
		[Token(Token = "0x400D2FA")]
		public const string CG_GALLERY_ENTRANCE_NAME = "cggallery";

		// Token: 0x0400D2FB RID: 54011
		[Token(Token = "0x400D2FB")]
		public const string STORY_MINI_REVIEW = "retrospect";

		// Token: 0x0400D2FC RID: 54012
		[Token(Token = "0x400D2FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_needToLogAvgStartInfo;

		// Token: 0x0400D2FD RID: 54013
		[Token(Token = "0x400D2FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string m_avgEntryInfo;

		// Token: 0x0400D2FE RID: 54014
		[Token(Token = "0x400D2FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string m_avgStoryId;

		// Token: 0x0400D2FF RID: 54015
		[Token(Token = "0x400D2FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private long m_storyBeginTs;

		// Token: 0x0400D300 RID: 54016
		[Token(Token = "0x400D300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnAct45SideLiveEntryClicked;

		// Token: 0x0400D301 RID: 54017
		[Token(Token = "0x400D301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnArtGalleryButtonClicked;

		// Token: 0x0400D302 RID: 54018
		[Token(Token = "0x400D302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnArtMagazineFirstRewardDialogOpen;

		// Token: 0x0400D303 RID: 54019
		[Token(Token = "0x400D303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackflowTabClicked;

		// Token: 0x0400D304 RID: 54020
		[Token(Token = "0x400D304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBackflowSpecialOpenJumpClicked;

		// Token: 0x0400D305 RID: 54021
		[Token(Token = "0x400D305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBackflowNewsJumpClicked;

		// Token: 0x0400D306 RID: 54022
		[Token(Token = "0x400D306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBackflowHomePageShowed;

		// Token: 0x0400D307 RID: 54023
		[Token(Token = "0x400D307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnStartBuildingCharControl;

		// Token: 0x0400D308 RID: 54024
		[Token(Token = "0x400D308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnEndBuildingCharControl;

		// Token: 0x0400D309 RID: 54025
		[Token(Token = "0x400D309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnBuildingSortClicked;

		// Token: 0x0400D30A RID: 54026
		[Token(Token = "0x400D30A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnCGGalleryEntryClicked;

		// Token: 0x0400D30B RID: 54027
		[Token(Token = "0x400D30B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnCGGalleryUnlockStatus;

		// Token: 0x0400D30C RID: 54028
		[Token(Token = "0x400D30C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnCGGalleryFavouriteModeClicked;

		// Token: 0x0400D30D RID: 54029
		[Token(Token = "0x400D30D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnCheckinVideoBtnClicked;

		// Token: 0x0400D30E RID: 54030
		[Token(Token = "0x400D30E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnHomeActClicked;

		// Token: 0x0400D30F RID: 54031
		[Token(Token = "0x400D30F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnEnemyDuelEmoteClicked;

		// Token: 0x0400D310 RID: 54032
		[Token(Token = "0x400D310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnEnemyDuelAfterBattleToEntryClicked;

		// Token: 0x0400D311 RID: 54033
		[Token(Token = "0x400D311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnEnemyDuelAfterBattleToRoomClicked;

		// Token: 0x0400D312 RID: 54034
		[Token(Token = "0x400D312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnEnemyDuelAfterBattleToMatchClicked;

		// Token: 0x0400D313 RID: 54035
		[Token(Token = "0x400D313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GenPrefList;

		// Token: 0x0400D314 RID: 54036
		[Token(Token = "0x400D314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnHotUpdateDownloadStart;

		// Token: 0x0400D315 RID: 54037
		[Token(Token = "0x400D315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnHotUpdateCheckConsistencyStart;

		// Token: 0x0400D316 RID: 54038
		[Token(Token = "0x400D316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RecordHotupdatePrecent;

		// Token: 0x0400D317 RID: 54039
		[Token(Token = "0x400D317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_RecordHotupdateDownloadFinish;

		// Token: 0x0400D318 RID: 54040
		[Token(Token = "0x400D318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_RecordCheckConsistencyFinish;

		// Token: 0x0400D319 RID: 54041
		[Token(Token = "0x400D319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_RecordDownloadInterrupt;

		// Token: 0x0400D31A RID: 54042
		[Token(Token = "0x400D31A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_RecordCheckConsistencyFail;

		// Token: 0x0400D31B RID: 54043
		[Token(Token = "0x400D31B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_RecordSelectMainPackMode;

		// Token: 0x0400D31C RID: 54044
		[Token(Token = "0x400D31C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_RecordUpdateVoiceLangMode;

		// Token: 0x0400D31D RID: 54045
		[Token(Token = "0x400D31D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_RecordUpdateTypeList;

		// Token: 0x0400D31E RID: 54046
		[Token(Token = "0x400D31E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_EventOnRoguelikeNodeChoiceBack;

		// Token: 0x0400D31F RID: 54047
		[Token(Token = "0x400D31F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_EventOnRoguelikeCopperBoxView;

		// Token: 0x0400D320 RID: 54048
		[Token(Token = "0x400D320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_EventOnRoguelikeCopperInEffectView;

		// Token: 0x0400D321 RID: 54049
		[Token(Token = "0x400D321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_EventOnRoguelikeCopperStepNumView;

		// Token: 0x0400D322 RID: 54050
		[Token(Token = "0x400D322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_EventOnRoguelikeCopperStoringRecruitView;

		// Token: 0x0400D323 RID: 54051
		[Token(Token = "0x400D323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_EventOnShopEntryClicked;

		// Token: 0x0400D324 RID: 54052
		[Token(Token = "0x400D324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_EventOnHomeBannerClicked;

		// Token: 0x0400D325 RID: 54053
		[Token(Token = "0x400D325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_EventOnShopClosureItemClicked;

		// Token: 0x0400D326 RID: 54054
		[Token(Token = "0x400D326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_EventOnShopCashTitleClicked;

		// Token: 0x0400D327 RID: 54055
		[Token(Token = "0x400D327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_EventOnShopPackageClicked;

		// Token: 0x0400D328 RID: 54056
		[Token(Token = "0x400D328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_EventOnShopSkinClicked;

		// Token: 0x0400D329 RID: 54057
		[Token(Token = "0x400D329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_EventOnShopBlindBoxDetailClicked;

		// Token: 0x0400D32A RID: 54058
		[Token(Token = "0x400D32A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_EventOnShopPackageShowed;

		// Token: 0x0400D32B RID: 54059
		[Token(Token = "0x400D32B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_EventOnShopSkinShowed;

		// Token: 0x0400D32C RID: 54060
		[Token(Token = "0x400D32C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_EventOnSocialCardAlbumPageOpen;

		// Token: 0x0400D32D RID: 54061
		[Token(Token = "0x400D32D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_EventOnSocialCardAlbumLeafExpose;

		// Token: 0x0400D32E RID: 54062
		[Token(Token = "0x400D32E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_EventOnSoCharEnterSummary;

		// Token: 0x0400D32F RID: 54063
		[Token(Token = "0x400D32F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_EventOnSoCharEnterLvlup;

		// Token: 0x0400D330 RID: 54064
		[Token(Token = "0x400D330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_EventOnSoCharEnterInfo;

		// Token: 0x0400D331 RID: 54065
		[Token(Token = "0x400D331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_EventOnSquadAssistApplyBtnClick;

		// Token: 0x0400D332 RID: 54066
		[Token(Token = "0x400D332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400D333 RID: 54067
		[Token(Token = "0x400D333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_SetStoryStartInfo;

		// Token: 0x0400D334 RID: 54068
		[Token(Token = "0x400D334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_SetHandbookInfo;

		// Token: 0x0400D335 RID: 54069
		[Token(Token = "0x400D335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_SetStoryReviewInfo;

		// Token: 0x0400D336 RID: 54070
		[Token(Token = "0x400D336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_SetCGGalleryInfo;

		// Token: 0x0400D337 RID: 54071
		[Token(Token = "0x400D337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_OnStoryBegin;

		// Token: 0x0400D338 RID: 54072
		[Token(Token = "0x400D338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_OnStoryEnd;

		// Token: 0x0400D339 RID: 54073
		[Token(Token = "0x400D339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__LogToSDK;

		// Token: 0x0400D33A RID: 54074
		[Token(Token = "0x400D33A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_EventOnRequestShareClicked;

		// Token: 0x0400D33B RID: 54075
		[Token(Token = "0x400D33B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_EventOnSwitchTabClicked;

		// Token: 0x0400D33C RID: 54076
		[Token(Token = "0x400D33C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_EventOnInviteClicked;

		// Token: 0x0400D33D RID: 54077
		[Token(Token = "0x400D33D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_EventOnVecBreakV2EnterDefenseMain;

		// Token: 0x0400D33E RID: 54078
		[Token(Token = "0x400D33E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_EventOnVecBreakV2SquadChangeSquadBuff;

		// Token: 0x0400D33F RID: 54079
		[Token(Token = "0x400D33F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__FetchPlayerBuffList;

		// Token: 0x0400D340 RID: 54080
		[Token(Token = "0x400D340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_EventOnVecBreakV2DefenseChangeBuff;

		// Token: 0x0400D341 RID: 54081
		[Token(Token = "0x400D341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_EventOnVecBreakV2EnterDefenseOverview;

		// Token: 0x0400D342 RID: 54082
		[Token(Token = "0x400D342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_EventOnVecBreakV2DefenseOut;

		// Token: 0x0400D343 RID: 54083
		[Token(Token = "0x400D343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix1_EventOnVecBreakV2DefenseOut;

		// Token: 0x02001FD6 RID: 8150
		[Token(Token = "0x2001FD6")]
		public struct EventLogAct45SideLivePageContext
		{
			// Token: 0x0400D344 RID: 54084
			[Token(Token = "0x400D344")]
			public const string ACT45SIDE_ENTER_LIVE_PAGE = "act45side_hall_click";

			// Token: 0x02001FD7 RID: 8151
			[Token(Token = "0x2001FD7")]
			public struct Param
			{
				// Token: 0x0400D345 RID: 54085
				[Token(Token = "0x400D345")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string param;
			}
		}

		// Token: 0x02001FD8 RID: 8152
		[Token(Token = "0x2001FD8")]
		public enum ArtGalleryClickRank
		{
			// Token: 0x0400D347 RID: 54087
			[Token(Token = "0x400D347")]
			ENTRY = 1,
			// Token: 0x0400D348 RID: 54088
			[Token(Token = "0x400D348")]
			SUB_ENTRY,
			// Token: 0x0400D349 RID: 54089
			[Token(Token = "0x400D349")]
			LIST_TAB,
			// Token: 0x0400D34A RID: 54090
			[Token(Token = "0x400D34A")]
			DETAIL_VIEW
		}

		// Token: 0x02001FD9 RID: 8153
		[Token(Token = "0x2001FD9")]
		public struct EventLogArtGalleryContext
		{
			// Token: 0x0400D34B RID: 54091
			[Token(Token = "0x400D34B")]
			public const string ART_GALLERY_CLICK = "click_designs_collection";

			// Token: 0x0400D34C RID: 54092
			[Token(Token = "0x400D34C")]
			public const string ART_MAGAZINE_FIRST_REWARD = "view_magazine_rewards";

			// Token: 0x0400D34D RID: 54093
			[Token(Token = "0x400D34D")]
			public const string BUTTON_WARDROBE = "wardrobe";

			// Token: 0x0400D34E RID: 54094
			[Token(Token = "0x400D34E")]
			public const string BUTTON_DISPLAY = "display_list";

			// Token: 0x0400D34F RID: 54095
			[Token(Token = "0x400D34F")]
			public const string BUTTON_COLLECT = "collection";

			// Token: 0x0400D350 RID: 54096
			[Token(Token = "0x400D350")]
			public const string BUTTON_MAGAZINE = "diy_magazine";

			// Token: 0x0400D351 RID: 54097
			[Token(Token = "0x400D351")]
			public const string PAGE_DISPLAY_LIST = "display_list";

			// Token: 0x0400D352 RID: 54098
			[Token(Token = "0x400D352")]
			public const string BUTTON_DISPLAY_FILTER_ALL = "filter_all";

			// Token: 0x0400D353 RID: 54099
			[Token(Token = "0x400D353")]
			public const string BUTTON_DISPLAY_FILTER_GET = "filter_get";

			// Token: 0x0400D354 RID: 54100
			[Token(Token = "0x400D354")]
			public const string BUTTON_DISPLAY_FILTER_UNGET = "filter_unget";

			// Token: 0x0400D355 RID: 54101
			[Token(Token = "0x400D355")]
			public const string BUTTON_DISPLAY_ITEM = "item";

			// Token: 0x0400D356 RID: 54102
			[Token(Token = "0x400D356")]
			public const string BUTTON_DISPLAY_PREVIEW = "preview";

			// Token: 0x0400D357 RID: 54103
			[Token(Token = "0x400D357")]
			public const string PAGE_COLLECT_SET = "collection";

			// Token: 0x0400D358 RID: 54104
			[Token(Token = "0x400D358")]
			public const string BUTTON_COLLECT_SET = "set";

			// Token: 0x0400D359 RID: 54105
			[Token(Token = "0x400D359")]
			public const string BUTTON_COLLECT_ITEM = "item";

			// Token: 0x0400D35A RID: 54106
			[Token(Token = "0x400D35A")]
			public const string BUTTON_COLLECT_REWARD = "reward_check";

			// Token: 0x0400D35B RID: 54107
			[Token(Token = "0x400D35B")]
			public const string PAGE_MAGAZINE = "diy_magazine";

			// Token: 0x0400D35C RID: 54108
			[Token(Token = "0x400D35C")]
			public const string BUTTON_MAGAZINE_COVER_OVERVIEW = "page_summary";

			// Token: 0x0400D35D RID: 54109
			[Token(Token = "0x400D35D")]
			public const string BUTTON_MAGAZINE_LEAF_ITEM = "item";

			// Token: 0x0400D35E RID: 54110
			[Token(Token = "0x400D35E")]
			public const string BUTTON_MAGAZINE_DIY = "edit";

			// Token: 0x0400D35F RID: 54111
			[Token(Token = "0x400D35F")]
			public const string BUTTON_MAGAZINE_SAVE_LEAF = "save";

			// Token: 0x02001FDA RID: 8154
			[Token(Token = "0x2001FDA")]
			public struct Param
			{
				// Token: 0x0400D360 RID: 54112
				[Token(Token = "0x400D360")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string click_rank;

				// Token: 0x0400D361 RID: 54113
				[Token(Token = "0x400D361")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string click_page;

				// Token: 0x0400D362 RID: 54114
				[Token(Token = "0x400D362")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string click_button;

				// Token: 0x0400D363 RID: 54115
				[Token(Token = "0x400D363")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string click_item;

				// Token: 0x0400D364 RID: 54116
				[Token(Token = "0x400D364")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public List<EventLogTrace.EventLogArtGalleryContext.CollectionRewardStatus> collection_reward_status;

				// Token: 0x0400D365 RID: 54117
				[Token(Token = "0x400D365")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string collection_set;

				// Token: 0x0400D366 RID: 54118
				[Token(Token = "0x400D366")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public int leaf_version;

				// Token: 0x0400D367 RID: 54119
				[Token(Token = "0x400D367")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
				public bool if_magazine_default;
			}

			// Token: 0x02001FDB RID: 8155
			[Token(Token = "0x2001FDB")]
			public class CollectionRewardStatus
			{
				// Token: 0x0600CA9B RID: 51867 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600CA9B")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public CollectionRewardStatus()
				{
				}

				// Token: 0x0400D368 RID: 54120
				[Token(Token = "0x400D368")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string mission;

				// Token: 0x0400D369 RID: 54121
				[Token(Token = "0x400D369")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string status;
			}

			// Token: 0x02001FDC RID: 8156
			[Token(Token = "0x2001FDC")]
			public struct EmptyParam
			{
			}
		}

		// Token: 0x02001FDD RID: 8157
		[Token(Token = "0x2001FDD")]
		public struct EventLogBackflowTraceContext
		{
			// Token: 0x0400D36A RID: 54122
			[Token(Token = "0x400D36A")]
			public const string BACKFLOW_SWITCH_TAB = "backflow_switch_tab";

			// Token: 0x0400D36B RID: 54123
			[Token(Token = "0x400D36B")]
			public const string BACKFLOW_SPECIAL_OPEN_JUMP = "backflow_stage_jump";

			// Token: 0x0400D36C RID: 54124
			[Token(Token = "0x400D36C")]
			public const string BACKFLOW_NEWS_JUMP = "backflow_news_jump";

			// Token: 0x0400D36D RID: 54125
			[Token(Token = "0x400D36D")]
			public const string BACKFLOW_HOME_PAGE_VIEW = "backflow_homepage_view";

			// Token: 0x0400D36E RID: 54126
			[Token(Token = "0x400D36E")]
			public const string BACKFLOW_TAB_KEY_CHECKIN = "checkin";

			// Token: 0x0400D36F RID: 54127
			[Token(Token = "0x400D36F")]
			public const string BACKFLOW_TAB_KEY_MISSION = "mission";

			// Token: 0x0400D370 RID: 54128
			[Token(Token = "0x400D370")]
			public const string BACKFLOW_TAB_KEY_NEWS = "news";

			// Token: 0x0400D371 RID: 54129
			[Token(Token = "0x400D371")]
			public const string BACKFLOW_TAB_KEY_SPECIAL_OPEN = "limit";

			// Token: 0x0400D372 RID: 54130
			[Token(Token = "0x400D372")]
			public const string BACKFLOW_TAB_KEY_PACKAGE = "pack";

			// Token: 0x02001FDE RID: 8158
			[Token(Token = "0x2001FDE")]
			public enum BackflowSpecialOpenType
			{
				// Token: 0x0400D374 RID: 54132
				[Token(Token = "0x400D374")]
				NONE,
				// Token: 0x0400D375 RID: 54133
				[Token(Token = "0x400D375")]
				RESOURCE,
				// Token: 0x0400D376 RID: 54134
				[Token(Token = "0x400D376")]
				CAMPAIGN
			}

			// Token: 0x02001FDF RID: 8159
			[Token(Token = "0x2001FDF")]
			public enum BackflowNewsJumpType
			{
				// Token: 0x0400D378 RID: 54136
				[Token(Token = "0x400D378")]
				NONE,
				// Token: 0x0400D379 RID: 54137
				[Token(Token = "0x400D379")]
				MAIN,
				// Token: 0x0400D37A RID: 54138
				[Token(Token = "0x400D37A")]
				ROGUE,
				// Token: 0x0400D37B RID: 54139
				[Token(Token = "0x400D37B")]
				SANDBOX
			}

			// Token: 0x02001FE0 RID: 8160
			[Token(Token = "0x2001FE0")]
			public struct BackflowTabParam
			{
				// Token: 0x0400D37C RID: 54140
				[Token(Token = "0x400D37C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string bf_groupid;

				// Token: 0x0400D37D RID: 54141
				[Token(Token = "0x400D37D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string tab;
			}

			// Token: 0x02001FE1 RID: 8161
			[Token(Token = "0x2001FE1")]
			public struct BackflowSpecialOpenJumpParam
			{
				// Token: 0x0400D37E RID: 54142
				[Token(Token = "0x400D37E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string bf_groupid;

				// Token: 0x0400D37F RID: 54143
				[Token(Token = "0x400D37F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public int bf_stage_type;

				// Token: 0x0400D380 RID: 54144
				[Token(Token = "0x400D380")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public bool is_unlock;
			}

			// Token: 0x02001FE2 RID: 8162
			[Token(Token = "0x2001FE2")]
			public struct BackflowNewsJumpParam
			{
				// Token: 0x0400D381 RID: 54145
				[Token(Token = "0x400D381")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string bf_groupid;

				// Token: 0x0400D382 RID: 54146
				[Token(Token = "0x400D382")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public int bf_news_type;

				// Token: 0x0400D383 RID: 54147
				[Token(Token = "0x400D383")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public bool is_unlock;
			}

			// Token: 0x02001FE3 RID: 8163
			[Token(Token = "0x2001FE3")]
			public struct BackflowHomePageViewParam
			{
				// Token: 0x0400D384 RID: 54148
				[Token(Token = "0x400D384")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string bf_groupid;

				// Token: 0x0400D385 RID: 54149
				[Token(Token = "0x400D385")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public bool is_clicked;
			}
		}

		// Token: 0x02001FE4 RID: 8164
		[Token(Token = "0x2001FE4")]
		public struct EventLogBuildingContext
		{
			// Token: 0x0400D386 RID: 54150
			[Token(Token = "0x400D386")]
			public const string BUILDING_CHAR_START_CONTROL = "room_control_char_start";

			// Token: 0x0400D387 RID: 54151
			[Token(Token = "0x400D387")]
			public const string BUILDING_CHAR_END_CONTROL = "room_control_char_end";

			// Token: 0x02001FE5 RID: 8165
			[Token(Token = "0x2001FE5")]
			public struct BuildingCharParam
			{
				// Token: 0x0400D388 RID: 54152
				[Token(Token = "0x400D388")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string char_id;

				// Token: 0x0400D389 RID: 54153
				[Token(Token = "0x400D389")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public bool is_own;

				// Token: 0x0400D38A RID: 54154
				[Token(Token = "0x400D38A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string room_slot_id;
			}
		}

		// Token: 0x02001FE6 RID: 8166
		[Token(Token = "0x2001FE6")]
		public struct EventLogBuildingSortContext
		{
			// Token: 0x0400D38B RID: 54155
			[Token(Token = "0x400D38B")]
			public const string BUILDING_SORT_CONTROL = "room_sort_button_click";

			// Token: 0x0400D38C RID: 54156
			[Token(Token = "0x400D38C")]
			public const string DESC = "desc";

			// Token: 0x0400D38D RID: 54157
			[Token(Token = "0x400D38D")]
			public const string ASC = "asc";

			// Token: 0x02001FE7 RID: 8167
			[Token(Token = "0x2001FE7")]
			public struct BuildingSortParam
			{
				// Token: 0x0400D38E RID: 54158
				[Token(Token = "0x400D38E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string click_button;

				// Token: 0x0400D38F RID: 54159
				[Token(Token = "0x400D38F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string sort_order;

				// Token: 0x0400D390 RID: 54160
				[Token(Token = "0x400D390")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string room_type;

				// Token: 0x0400D391 RID: 54161
				[Token(Token = "0x400D391")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string room_product;

				// Token: 0x0400D392 RID: 54162
				[Token(Token = "0x400D392")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string room_slot_id;
			}
		}

		// Token: 0x02001FE8 RID: 8168
		[Token(Token = "0x2001FE8")]
		public struct EventLogCGGalleryEntryClickedContext
		{
			// Token: 0x0400D393 RID: 54163
			[Token(Token = "0x400D393")]
			public const string EVENT_NAME = "click_cg_collection";

			// Token: 0x02001FE9 RID: 8169
			[Token(Token = "0x2001FE9")]
			public struct Param
			{
				// Token: 0x0400D394 RID: 54164
				[Token(Token = "0x400D394")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string cg_type;
			}
		}

		// Token: 0x02001FEA RID: 8170
		[Token(Token = "0x2001FEA")]
		public struct EventLogCGGalleryUnlockStatusContext
		{
			// Token: 0x0400D395 RID: 54165
			[Token(Token = "0x400D395")]
			public const string EVENT_NAME = "show_cg_collection";

			// Token: 0x02001FEB RID: 8171
			[Token(Token = "0x2001FEB")]
			public struct Param
			{
				// Token: 0x0400D396 RID: 54166
				[Token(Token = "0x400D396")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string cg_type;

				// Token: 0x0400D397 RID: 54167
				[Token(Token = "0x400D397")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public List<string> cg_list;
			}
		}

		// Token: 0x02001FEC RID: 8172
		[Token(Token = "0x2001FEC")]
		public struct EventLogCGGalleryFavouriteModeClickedContext
		{
			// Token: 0x0400D398 RID: 54168
			[Token(Token = "0x400D398")]
			public const string EVENT_NAME = "click_cg_favourite";

			// Token: 0x02001FED RID: 8173
			[Token(Token = "0x2001FED")]
			public struct Param
			{
			}
		}

		// Token: 0x02001FEE RID: 8174
		[Token(Token = "0x2001FEE")]
		public struct EventLogCheckinVideoTraceContext
		{
			// Token: 0x0400D399 RID: 54169
			[Token(Token = "0x400D399")]
			public const string CLICK_ART_CHECK = "click_act_check";

			// Token: 0x0400D39A RID: 54170
			[Token(Token = "0x400D39A")]
			public const string BTN_MAIN = "main_icon";

			// Token: 0x0400D39B RID: 54171
			[Token(Token = "0x400D39B")]
			public const string BTN_REPLAY = "replay";

			// Token: 0x0400D39C RID: 54172
			[Token(Token = "0x400D39C")]
			public const string BTN_SHARE = "share";

			// Token: 0x0400D39D RID: 54173
			[Token(Token = "0x400D39D")]
			public const string BTN_JUMP = "jump";

			// Token: 0x0400D39E RID: 54174
			[Token(Token = "0x400D39E")]
			public const string MAIN_BTN_TYPE_PLAY = "play";

			// Token: 0x0400D39F RID: 54175
			[Token(Token = "0x400D39F")]
			public const string MAIN_BTN_TYPE_REWARD_GET = "reward_get";

			// Token: 0x02001FEF RID: 8175
			[Token(Token = "0x2001FEF")]
			public struct CheckinVideoBtnClickParam
			{
				// Token: 0x0400D3A0 RID: 54176
				[Token(Token = "0x400D3A0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string activity_id;

				// Token: 0x0400D3A1 RID: 54177
				[Token(Token = "0x400D3A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string click_button;

				// Token: 0x0400D3A2 RID: 54178
				[Token(Token = "0x400D3A2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string click_page;

				// Token: 0x0400D3A3 RID: 54179
				[Token(Token = "0x400D3A3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string click_type;
			}
		}

		// Token: 0x02001FF0 RID: 8176
		[Token(Token = "0x2001FF0")]
		public class EventLogActCommonTabContext
		{
			// Token: 0x0600CA9C RID: 51868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CA9C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EventLogActCommonTabContext()
			{
			}

			// Token: 0x0400D3A4 RID: 54180
			[Token(Token = "0x400D3A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool is_clicked;

			// Token: 0x0400D3A5 RID: 54181
			[Token(Token = "0x400D3A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string activity_id;

			// Token: 0x0400D3A6 RID: 54182
			[Token(Token = "0x400D3A6")]
			public const string id = "home_act_page_view";
		}

		// Token: 0x02001FF1 RID: 8177
		[Token(Token = "0x2001FF1")]
		public struct EventLogEnemyDuelContext
		{
			// Token: 0x0400D3A7 RID: 54183
			[Token(Token = "0x400D3A7")]
			public const string ENEMY_DUEL_CLICK_EMOTE = "act_enemyduel_emote_option";

			// Token: 0x0400D3A8 RID: 54184
			[Token(Token = "0x400D3A8")]
			public const string ENEMY_DUEL_CLICK_AFTER_BATTLE_CHOICE = "act_enemyduel_after_battle_choices";

			// Token: 0x02001FF2 RID: 8178
			[Token(Token = "0x2001FF2")]
			public struct EmoteParam
			{
				// Token: 0x0400D3A9 RID: 54185
				[Token(Token = "0x400D3A9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string activity_id;

				// Token: 0x0400D3AA RID: 54186
				[Token(Token = "0x400D3AA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string scene_id;

				// Token: 0x0400D3AB RID: 54187
				[Token(Token = "0x400D3AB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string mode_id;

				// Token: 0x0400D3AC RID: 54188
				[Token(Token = "0x400D3AC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string emote_setting;
			}

			// Token: 0x02001FF3 RID: 8179
			[Token(Token = "0x2001FF3")]
			public struct AfterBattleChoiceParam
			{
				// Token: 0x0400D3AD RID: 54189
				[Token(Token = "0x400D3AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string activity_id;

				// Token: 0x0400D3AE RID: 54190
				[Token(Token = "0x400D3AE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string scene_id;

				// Token: 0x0400D3AF RID: 54191
				[Token(Token = "0x400D3AF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string mode_id;

				// Token: 0x0400D3B0 RID: 54192
				[Token(Token = "0x400D3B0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string choice;
			}

			// Token: 0x02001FF4 RID: 8180
			[Token(Token = "0x2001FF4")]
			public enum AfterBattleRouteType
			{
				// Token: 0x0400D3B2 RID: 54194
				[Token(Token = "0x400D3B2")]
				ENTRY = 1,
				// Token: 0x0400D3B3 RID: 54195
				[Token(Token = "0x400D3B3")]
				ROOM,
				// Token: 0x0400D3B4 RID: 54196
				[Token(Token = "0x400D3B4")]
				CONTINUE_MATCH
			}

			// Token: 0x02001FF5 RID: 8181
			[Token(Token = "0x2001FF5")]
			public static class EmoteSetting
			{
				// Token: 0x0400D3B5 RID: 54197
				[Token(Token = "0x400D3B5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly string EMOTE_ON;

				// Token: 0x0400D3B6 RID: 54198
				[Token(Token = "0x400D3B6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static readonly string EMOTE_OFF;
			}
		}

		// Token: 0x02001FF6 RID: 8182
		[Token(Token = "0x2001FF6")]
		public struct EventLogHotUpdateContext
		{
			// Token: 0x0400D3B7 RID: 54199
			[Token(Token = "0x400D3B7")]
			public const string RES_PROCEDURE_START = "res_procedure_start";

			// Token: 0x0400D3B8 RID: 54200
			[Token(Token = "0x400D3B8")]
			public const string RES_PROCEDURE_CHECKPOINT = "res_procedure_checkpoint";

			// Token: 0x0400D3B9 RID: 54201
			[Token(Token = "0x400D3B9")]
			public const string RES_PROCEDURE_FINISH = "res_procedure_finish";

			// Token: 0x0400D3BA RID: 54202
			[Token(Token = "0x400D3BA")]
			public const string RES_PROCEDURE_FAIL = "res_procedure_fail";

			// Token: 0x0400D3BB RID: 54203
			[Token(Token = "0x400D3BB")]
			public const string MAIN_PACK_ACK = "main_pack_ack";

			// Token: 0x0400D3BC RID: 54204
			[Token(Token = "0x400D3BC")]
			public const string LANGUAGE_PACK_ACK = "language_pack_ack";

			// Token: 0x0400D3BD RID: 54205
			[Token(Token = "0x400D3BD")]
			public const string RES_PREFERENCE_UPDATE = "res_preference_update";

			// Token: 0x0400D3BE RID: 54206
			[Token(Token = "0x400D3BE")]
			public const string RES_PROCEDURE_TYPE_DOWNLOAD = "download";

			// Token: 0x0400D3BF RID: 54207
			[Token(Token = "0x400D3BF")]
			public const string RES_PROCEDURE_TYPE_CHECK_CONSISTENCY = "checkconsistency";

			// Token: 0x0400D3C0 RID: 54208
			[Token(Token = "0x400D3C0")]
			public const string RES_PROCEDURE_TYPE_DOWNLOAD_PREMAIN = "download_premain";

			// Token: 0x0400D3C1 RID: 54209
			[Token(Token = "0x400D3C1")]
			public const string RES_PROCEDURE_TYPE_CHECK_CONSISTENCY_PREMAIN = "checkconsistency_premain";

			// Token: 0x0400D3C2 RID: 54210
			[Token(Token = "0x400D3C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static float[] PROGRESS_PERCENT_LIST;

			// Token: 0x0400D3C3 RID: 54211
			[Token(Token = "0x400D3C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float cachedDownloadPercent;

			// Token: 0x0400D3C4 RID: 54212
			[Token(Token = "0x400D3C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string cachedVersionId;

			// Token: 0x0400D3C5 RID: 54213
			[Token(Token = "0x400D3C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long cachedDownloadStartTs;

			// Token: 0x0400D3C6 RID: 54214
			[Token(Token = "0x400D3C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public long cachedCheckConsistencyStartTs;

			// Token: 0x0400D3C7 RID: 54215
			[Token(Token = "0x400D3C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public long cachedDownloadSize;

			// Token: 0x0400D3C8 RID: 54216
			[Token(Token = "0x400D3C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<string> cachePrefList;

			// Token: 0x02001FF7 RID: 8183
			[Token(Token = "0x2001FF7")]
			public struct ResProcedureStartParam
			{
				// Token: 0x0400D3C9 RID: 54217
				[Token(Token = "0x400D3C9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string proc_type;

				// Token: 0x0400D3CA RID: 54218
				[Token(Token = "0x400D3CA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public long ts_start;

				// Token: 0x0400D3CB RID: 54219
				[Token(Token = "0x400D3CB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string src_version_id;

				// Token: 0x0400D3CC RID: 54220
				[Token(Token = "0x400D3CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public long src_size;

				// Token: 0x0400D3CD RID: 54221
				[Token(Token = "0x400D3CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public List<string> src_pref_list;
			}

			// Token: 0x02001FF8 RID: 8184
			[Token(Token = "0x2001FF8")]
			public struct ResProcedurePercentParam
			{
				// Token: 0x0400D3CE RID: 54222
				[Token(Token = "0x400D3CE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string proc_type;

				// Token: 0x0400D3CF RID: 54223
				[Token(Token = "0x400D3CF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float percent;

				// Token: 0x0400D3D0 RID: 54224
				[Token(Token = "0x400D3D0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public long ts_start;

				// Token: 0x0400D3D1 RID: 54225
				[Token(Token = "0x400D3D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public long src_size;
			}

			// Token: 0x02001FF9 RID: 8185
			[Token(Token = "0x2001FF9")]
			public struct ResProcedureFinishParam
			{
				// Token: 0x0400D3D2 RID: 54226
				[Token(Token = "0x400D3D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string proc_type;

				// Token: 0x0400D3D3 RID: 54227
				[Token(Token = "0x400D3D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public long ts_start;

				// Token: 0x0400D3D4 RID: 54228
				[Token(Token = "0x400D3D4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string src_version_id;

				// Token: 0x0400D3D5 RID: 54229
				[Token(Token = "0x400D3D5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public List<string> src_pref_list;
			}

			// Token: 0x02001FFA RID: 8186
			[Token(Token = "0x2001FFA")]
			public struct ResProcedureInterruptParam
			{
				// Token: 0x0400D3D6 RID: 54230
				[Token(Token = "0x400D3D6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string proc_type;

				// Token: 0x0400D3D7 RID: 54231
				[Token(Token = "0x400D3D7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public long ts_start;

				// Token: 0x0400D3D8 RID: 54232
				[Token(Token = "0x400D3D8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string reason;
			}

			// Token: 0x02001FFB RID: 8187
			[Token(Token = "0x2001FFB")]
			public struct ResProcedureSelectParam
			{
				// Token: 0x0400D3D9 RID: 54233
				[Token(Token = "0x400D3D9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string main_pack;

				// Token: 0x0400D3DA RID: 54234
				[Token(Token = "0x400D3DA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string pack_volume;
			}

			// Token: 0x02001FFC RID: 8188
			[Token(Token = "0x2001FFC")]
			public struct ResProcedureLangSelectParam
			{
				// Token: 0x0400D3DB RID: 54235
				[Token(Token = "0x400D3DB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public List<string> lang_pack_list;

				// Token: 0x0400D3DC RID: 54236
				[Token(Token = "0x400D3DC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public long pack_size;
			}

			// Token: 0x02001FFD RID: 8189
			[Token(Token = "0x2001FFD")]
			public struct ResProcedureUpdateParam
			{
				// Token: 0x0400D3DD RID: 54237
				[Token(Token = "0x400D3DD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public IList<string> src_type;
			}
		}

		// Token: 0x02001FFE RID: 8190
		[Token(Token = "0x2001FFE")]
		public struct EventLogRoguelikeContext
		{
			// Token: 0x0400D3DE RID: 54238
			[Token(Token = "0x400D3DE")]
			public const string ROGUELIKE_NODE_CHOICE_BACK = "roguelike_node_choice_back";

			// Token: 0x0400D3DF RID: 54239
			[Token(Token = "0x400D3DF")]
			public const string ROGUELIKE_COPPER_BOX_VIEW = "roguelike_copper_box_view";

			// Token: 0x0400D3E0 RID: 54240
			[Token(Token = "0x400D3E0")]
			public const string ROGUELIKE_COPPER_IN_EFFECT_VIEW = "roguelike_copper_in_effect_view";

			// Token: 0x0400D3E1 RID: 54241
			[Token(Token = "0x400D3E1")]
			public const string ROGUELIKE_STEP_NUM_VIEW = "roguelike_step_num_view";

			// Token: 0x0400D3E2 RID: 54242
			[Token(Token = "0x400D3E2")]
			public const string ROGUELIKE_STORING_RECRUIT_VIEW = "roguelike_storing_recruit_view";

			// Token: 0x02001FFF RID: 8191
			[Token(Token = "0x2001FFF")]
			public class InGameCommonParam
			{
				// Token: 0x0600CA9F RID: 51871 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600CA9F")]
				[Address(RVA = "0x34C7020", Offset = "0x34C5C20", VA = "0x1834C7020")]
				public static EventLogTrace.EventLogRoguelikeContext.InGameCommonParam CreateParamFromPlayerData()
				{
					return null;
				}

				// Token: 0x0600CAA0 RID: 51872 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600CAA0")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public InGameCommonParam()
				{
				}

				// Token: 0x0400D3E3 RID: 54243
				[Token(Token = "0x400D3E3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string game_id;

				// Token: 0x0400D3E4 RID: 54244
				[Token(Token = "0x400D3E4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string game_theme;

				// Token: 0x0400D3E5 RID: 54245
				[Token(Token = "0x400D3E5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public int zone_index;

				// Token: 0x0400D3E6 RID: 54246
				[Token(Token = "0x400D3E6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string zone_id;

				// Token: 0x0400D3E7 RID: 54247
				[Token(Token = "0x400D3E7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public int position_x;

				// Token: 0x0400D3E8 RID: 54248
				[Token(Token = "0x400D3E8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
				public int position_y;
			}

			// Token: 0x02002000 RID: 8192
			[Token(Token = "0x2002000")]
			public abstract class InGameBaseParam
			{
				// Token: 0x0600CAA1 RID: 51873 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600CAA1")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				protected InGameBaseParam()
				{
				}

				// Token: 0x0400D3E9 RID: 54249
				[Token(Token = "0x400D3E9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public EventLogTrace.EventLogRoguelikeContext.InGameCommonParam in_game_msg;
			}

			// Token: 0x02002001 RID: 8193
			[Token(Token = "0x2002001")]
			public class EmptyInGameParam : EventLogTrace.EventLogRoguelikeContext.InGameBaseParam
			{
				// Token: 0x0600CAA2 RID: 51874 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600CAA2")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public EmptyInGameParam()
				{
				}
			}

			// Token: 0x02002002 RID: 8194
			[Token(Token = "0x2002002")]
			public class NodeChoiceBackParam : EventLogTrace.EventLogRoguelikeContext.InGameBaseParam
			{
				// Token: 0x0600CAA3 RID: 51875 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600CAA3")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public NodeChoiceBackParam()
				{
				}

				// Token: 0x0400D3EA RID: 54250
				[Token(Token = "0x400D3EA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string choice_id;

				// Token: 0x0400D3EB RID: 54251
				[Token(Token = "0x400D3EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string node_type;
			}
		}

		// Token: 0x02002003 RID: 8195
		[Token(Token = "0x2002003")]
		public struct EventLogShopContext
		{
			// Token: 0x0400D3EC RID: 54252
			[Token(Token = "0x400D3EC")]
			public const string SHOP_CLICK_ENTER_STORE = "click_enter_store";

			// Token: 0x0400D3ED RID: 54253
			[Token(Token = "0x400D3ED")]
			public const string SHOP_CLICK_PACKAGE_STORE = "click_package_store";

			// Token: 0x0400D3EE RID: 54254
			[Token(Token = "0x400D3EE")]
			public const string SHOP_CLICK_DIAMOND_STORE = "click_diamond_store";

			// Token: 0x0400D3EF RID: 54255
			[Token(Token = "0x400D3EF")]
			public const string SHOP_CLICK_SKIN_STORE = "click_skin_store";

			// Token: 0x0400D3F0 RID: 54256
			[Token(Token = "0x400D3F0")]
			public const string SHOP_VIEW_SKIN_STORE = "view_skin_store";

			// Token: 0x0400D3F1 RID: 54257
			[Token(Token = "0x400D3F1")]
			public const string SHOP_VIEW_PACKAGE_STORE = "view_package_store";

			// Token: 0x0400D3F2 RID: 54258
			[Token(Token = "0x400D3F2")]
			public const string SHOP_CLICK_CLOSURE_STORE = "click_closure_store";

			// Token: 0x0400D3F3 RID: 54259
			[Token(Token = "0x400D3F3")]
			public const string SHOP_CLICK_BANNER_STORE = "click_banner_main";

			// Token: 0x0400D3F4 RID: 54260
			[Token(Token = "0x400D3F4")]
			public const string SHOP_SKIN_BTN_BUY = "buy";

			// Token: 0x02002004 RID: 8196
			[Token(Token = "0x2002004")]
			public struct ShopParam
			{
				// Token: 0x0400D3F5 RID: 54261
				[Token(Token = "0x400D3F5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string click_rank;

				// Token: 0x0400D3F6 RID: 54262
				[Token(Token = "0x400D3F6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string click_button;
			}

			// Token: 0x02002005 RID: 8197
			[Token(Token = "0x2002005")]
			public struct ShopItemParam
			{
				// Token: 0x0400D3F7 RID: 54263
				[Token(Token = "0x400D3F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string view_tab;

				// Token: 0x0400D3F8 RID: 54264
				[Token(Token = "0x400D3F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public long enter_ts;

				// Token: 0x0400D3F9 RID: 54265
				[Token(Token = "0x400D3F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string click_rank;

				// Token: 0x0400D3FA RID: 54266
				[Token(Token = "0x400D3FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string click_button;

				// Token: 0x0400D3FB RID: 54267
				[Token(Token = "0x400D3FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string referrer;

				// Token: 0x0400D3FC RID: 54268
				[Token(Token = "0x400D3FC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public List<string> skin_box_list;

				// Token: 0x0400D3FD RID: 54269
				[Token(Token = "0x400D3FD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public bool is_obtainable;
			}

			// Token: 0x02002006 RID: 8198
			[Token(Token = "0x2002006")]
			public struct ShopItemShowParam
			{
				// Token: 0x0400D3FE RID: 54270
				[Token(Token = "0x400D3FE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string view_tab;

				// Token: 0x0400D3FF RID: 54271
				[Token(Token = "0x400D3FF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string referrer;

				// Token: 0x0400D400 RID: 54272
				[Token(Token = "0x400D400")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string good_id;

				// Token: 0x0400D401 RID: 54273
				[Token(Token = "0x400D401")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public long enter_ts;

				// Token: 0x0400D402 RID: 54274
				[Token(Token = "0x400D402")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public int available_purchases;
			}

			// Token: 0x02002007 RID: 8199
			[Token(Token = "0x2002007")]
			public enum ShopClickRank
			{
				// Token: 0x0400D404 RID: 54276
				[Token(Token = "0x400D404")]
				LEVEL_0_ENTRANCE,
				// Token: 0x0400D405 RID: 54277
				[Token(Token = "0x400D405")]
				LEVEL_1_SHOP_TYPE,
				// Token: 0x0400D406 RID: 54278
				[Token(Token = "0x400D406")]
				LEVEL_2_GOOD_TYPE,
				// Token: 0x0400D407 RID: 54279
				[Token(Token = "0x400D407")]
				LEVEL_3_GOOD_ID,
				// Token: 0x0400D408 RID: 54280
				[Token(Token = "0x400D408")]
				LEVEL_4_GOOD_BUY
			}
		}

		// Token: 0x02002008 RID: 8200
		[Token(Token = "0x2002008")]
		public struct EventLogSocialCardAlbumContext
		{
			// Token: 0x0400D409 RID: 54281
			[Token(Token = "0x400D409")]
			public const string VIEW_SOCIAL_CARD_ALBUM = "view_cardboard";

			// Token: 0x0400D40A RID: 54282
			[Token(Token = "0x400D40A")]
			public const string VIEW_LEAF = "view_magazine_squad";

			// Token: 0x0400D40B RID: 54283
			[Token(Token = "0x400D40B")]
			public const string SOCIAL_CARD_WITHOUT_LEAF = "old";

			// Token: 0x0400D40C RID: 54284
			[Token(Token = "0x400D40C")]
			public const string SOCIAL_CARD_WITH_LEAF = "new";

			// Token: 0x02002009 RID: 8201
			[Token(Token = "0x2002009")]
			public struct SocialCardPageParam
			{
				// Token: 0x0400D40D RID: 54285
				[Token(Token = "0x400D40D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string from_uid;

				// Token: 0x0400D40E RID: 54286
				[Token(Token = "0x400D40E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string cardboard_type;
			}

			// Token: 0x0200200A RID: 8202
			[Token(Token = "0x200200A")]
			public struct SocialCardLeafParam
			{
				// Token: 0x0400D40F RID: 54287
				[Token(Token = "0x400D40F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string from_uid;

				// Token: 0x0400D410 RID: 54288
				[Token(Token = "0x400D410")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string leaf_id;

				// Token: 0x0400D411 RID: 54289
				[Token(Token = "0x400D411")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string leaf_index;
			}
		}

		// Token: 0x0200200B RID: 8203
		[Token(Token = "0x200200B")]
		public struct EventLogSoCharV2Context
		{
			// Token: 0x0400D412 RID: 54290
			[Token(Token = "0x400D412")]
			public const string ENTER_INFO_PAGE = "sp_operator_char_page";

			// Token: 0x0400D413 RID: 54291
			[Token(Token = "0x400D413")]
			public const string ENTER_SUMMARY_PAGE = "sp_operator_main_page_overview";

			// Token: 0x0400D414 RID: 54292
			[Token(Token = "0x400D414")]
			public const string ENTER_LVLUP_PAGE = "sp_operator_main_page_train";

			// Token: 0x0200200C RID: 8204
			[Token(Token = "0x200200C")]
			public static class EnterInfoSrc
			{
				// Token: 0x0400D415 RID: 54293
				[Token(Token = "0x400D415")]
				public const string SRC_LVLUP = "1";

				// Token: 0x0400D416 RID: 54294
				[Token(Token = "0x400D416")]
				public const string SRC_SUMMARY = "2";
			}

			// Token: 0x0200200D RID: 8205
			[Token(Token = "0x200200D")]
			public struct EnterInfoParam
			{
				// Token: 0x0400D417 RID: 54295
				[Token(Token = "0x400D417")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string act_id;

				// Token: 0x0400D418 RID: 54296
				[Token(Token = "0x400D418")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string sp_operator_id;

				// Token: 0x0400D419 RID: 54297
				[Token(Token = "0x400D419")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string source;
			}

			// Token: 0x0200200E RID: 8206
			[Token(Token = "0x200200E")]
			public struct EnterSummaryParam
			{
				// Token: 0x0400D41A RID: 54298
				[Token(Token = "0x400D41A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string act_id;

				// Token: 0x0400D41B RID: 54299
				[Token(Token = "0x400D41B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string sp_operator_id;
			}

			// Token: 0x0200200F RID: 8207
			[Token(Token = "0x200200F")]
			public struct EnterLvlupParam
			{
				// Token: 0x0400D41C RID: 54300
				[Token(Token = "0x400D41C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string act_id;

				// Token: 0x0400D41D RID: 54301
				[Token(Token = "0x400D41D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string sp_operator_id;
			}
		}

		// Token: 0x02002010 RID: 8208
		[Token(Token = "0x2002010")]
		public struct EventLogSquadContext
		{
			// Token: 0x0400D41E RID: 54302
			[Token(Token = "0x400D41E")]
			public const string SQUAD_ASSIST_CHAR_SELECT = "assist_char_select";

			// Token: 0x02002011 RID: 8209
			[Token(Token = "0x2002011")]
			public enum SquadAssistType
			{
				// Token: 0x0400D420 RID: 54304
				[Token(Token = "0x400D420")]
				NORMAL,
				// Token: 0x0400D421 RID: 54305
				[Token(Token = "0x400D421")]
				ROGUELIKE,
				// Token: 0x0400D422 RID: 54306
				[Token(Token = "0x400D422")]
				COMMON_SQUAD_ASSIST
			}

			// Token: 0x02002012 RID: 8210
			[Token(Token = "0x2002012")]
			[Serializable]
			public struct SquadAssistCharParam
			{
				// Token: 0x0400D423 RID: 54307
				[Token(Token = "0x400D423")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string assist_uid;

				// Token: 0x0400D424 RID: 54308
				[Token(Token = "0x400D424")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public bool is_star_friend;

				// Token: 0x0400D425 RID: 54309
				[Token(Token = "0x400D425")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
				public bool is_star_friend_switch_on;

				// Token: 0x0400D426 RID: 54310
				[Token(Token = "0x400D426")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public EventLogTrace.EventLogSquadContext.SquadCharacterCardParam assist_char_info;

				// Token: 0x0400D427 RID: 54311
				[Token(Token = "0x400D427")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public int assist_type;
			}

			// Token: 0x02002013 RID: 8211
			[Token(Token = "0x2002013")]
			[Serializable]
			public struct SquadCharacterCardParam
			{
				// Token: 0x0400D428 RID: 54312
				[Token(Token = "0x400D428")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string char_id;

				// Token: 0x0400D429 RID: 54313
				[Token(Token = "0x400D429")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string current_equip_id;

				// Token: 0x0400D42A RID: 54314
				[Token(Token = "0x400D42A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public int current_equip_level;

				// Token: 0x0400D42B RID: 54315
				[Token(Token = "0x400D42B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public int evolve_phase;

				// Token: 0x0400D42C RID: 54316
				[Token(Token = "0x400D42C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int level;

				// Token: 0x0400D42D RID: 54317
				[Token(Token = "0x400D42D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public int main_skill_level;

				// Token: 0x0400D42E RID: 54318
				[Token(Token = "0x400D42E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public int potential_rank;

				// Token: 0x0400D42F RID: 54319
				[Token(Token = "0x400D42F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				public int skill_index;
			}
		}

		// Token: 0x02002014 RID: 8212
		[Token(Token = "0x2002014")]
		[Serializable]
		public struct StartParam
		{
			// Token: 0x0400D430 RID: 54320
			[Token(Token = "0x400D430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string entrance;

			// Token: 0x0400D431 RID: 54321
			[Token(Token = "0x400D431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string story_id;
		}

		// Token: 0x02002015 RID: 8213
		[Token(Token = "0x2002015")]
		[Serializable]
		public struct EndParam
		{
			// Token: 0x0400D432 RID: 54322
			[Token(Token = "0x400D432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string entrance;

			// Token: 0x0400D433 RID: 54323
			[Token(Token = "0x400D433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string story_id;

			// Token: 0x0400D434 RID: 54324
			[Token(Token = "0x400D434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long use_time;

			// Token: 0x0400D435 RID: 54325
			[Token(Token = "0x400D435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool if_skip;
		}

		// Token: 0x02002016 RID: 8214
		[Token(Token = "0x2002016")]
		public struct EventLogTeamQuestContext
		{
			// Token: 0x0400D436 RID: 54326
			[Token(Token = "0x400D436")]
			public const string ON_REQUEST_SHARE = "act_teamquest_share";

			// Token: 0x0400D437 RID: 54327
			[Token(Token = "0x400D437")]
			public const string ON_SWITCH_TAB = "act_teamquest_switch_tab";

			// Token: 0x0400D438 RID: 54328
			[Token(Token = "0x400D438")]
			public const string ON_COPY_CODE = "act_teamquest_copy_code";

			// Token: 0x02002017 RID: 8215
			[Token(Token = "0x2002017")]
			public class RequestShare
			{
				// Token: 0x0600CAA4 RID: 51876 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600CAA4")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RequestShare()
				{
				}

				// Token: 0x0400D439 RID: 54329
				[Token(Token = "0x400D439")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public List<int> multi_share_data;

				// Token: 0x0400D43A RID: 54330
				[Token(Token = "0x400D43A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string activity_id;

				// Token: 0x0400D43B RID: 54331
				[Token(Token = "0x400D43B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public int team_size;
			}

			// Token: 0x02002018 RID: 8216
			[Token(Token = "0x2002018")]
			public class SwitchTab
			{
				// Token: 0x0600CAA5 RID: 51877 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600CAA5")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SwitchTab()
				{
				}

				// Token: 0x0400D43C RID: 54332
				[Token(Token = "0x400D43C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string tab;

				// Token: 0x0400D43D RID: 54333
				[Token(Token = "0x400D43D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string activity_id;
			}

			// Token: 0x02002019 RID: 8217
			[Token(Token = "0x2002019")]
			public class OnCopyCode
			{
				// Token: 0x0600CAA6 RID: 51878 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600CAA6")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public OnCopyCode()
				{
				}

				// Token: 0x0400D43E RID: 54334
				[Token(Token = "0x400D43E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string activity_id;

				// Token: 0x0400D43F RID: 54335
				[Token(Token = "0x400D43F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string invitation_code;

				// Token: 0x0400D440 RID: 54336
				[Token(Token = "0x400D440")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public int team_size;
			}
		}

		// Token: 0x0200201A RID: 8218
		[Token(Token = "0x200201A")]
		public struct EventLogVecBreakV2Context
		{
			// Token: 0x0400D441 RID: 54337
			[Token(Token = "0x400D441")]
			public const string VEC_BREAK_V2_ENTER_DEFENSE_MAIN = "vec_break_enter_buff_main";

			// Token: 0x0400D442 RID: 54338
			[Token(Token = "0x400D442")]
			public const string VEC_BREAK_V2_CHANGE_SQUAD_BUFF = "vec_break_buff_option";

			// Token: 0x0400D443 RID: 54339
			[Token(Token = "0x400D443")]
			public const string VEC_BREAK_V2_ENTER_DEFENSE_OVERVIEW = "vec_break_enter_buff_overview";

			// Token: 0x0400D444 RID: 54340
			[Token(Token = "0x400D444")]
			public const string VEC_BREAK_V2_DEFENSE_OUT = "vec_break_defend_out";

			// Token: 0x0200201B RID: 8219
			[Token(Token = "0x200201B")]
			public static class EnterSource
			{
				// Token: 0x0400D445 RID: 54341
				[Token(Token = "0x400D445")]
				public const string SOURCE_MAIN = "main";

				// Token: 0x0400D446 RID: 54342
				[Token(Token = "0x400D446")]
				public const string SOURCE_FORMATION = "formation";
			}

			// Token: 0x0200201C RID: 8220
			[Token(Token = "0x200201C")]
			public static class BuffChangeSource
			{
				// Token: 0x0400D447 RID: 54343
				[Token(Token = "0x400D447")]
				public const string SOURCE_MAIN = "main";

				// Token: 0x0400D448 RID: 54344
				[Token(Token = "0x400D448")]
				public const string SOURCE_FORMATION = "formation";
			}

			// Token: 0x0200201D RID: 8221
			[Token(Token = "0x200201D")]
			public static class DefendOutSource
			{
				// Token: 0x0400D449 RID: 54345
				[Token(Token = "0x400D449")]
				public const string SOURCE_BUFF_MAIN = "buff_main";

				// Token: 0x0400D44A RID: 54346
				[Token(Token = "0x400D44A")]
				public const string SOURCE_BUFF_OVERVIEW = "buff_overview";
			}

			// Token: 0x0200201E RID: 8222
			[Token(Token = "0x200201E")]
			public struct EnterDefenseMainParam
			{
				// Token: 0x0400D44B RID: 54347
				[Token(Token = "0x400D44B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string activity_id;

				// Token: 0x0400D44C RID: 54348
				[Token(Token = "0x400D44C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string source;
			}

			// Token: 0x0200201F RID: 8223
			[Token(Token = "0x200201F")]
			public struct ChangeSquadBuffParam
			{
				// Token: 0x0400D44D RID: 54349
				[Token(Token = "0x400D44D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string activity_id;

				// Token: 0x0400D44E RID: 54350
				[Token(Token = "0x400D44E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string source;

				// Token: 0x0400D44F RID: 54351
				[Token(Token = "0x400D44F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public List<string> buffs_selectable;

				// Token: 0x0400D450 RID: 54352
				[Token(Token = "0x400D450")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public List<string> buffs_after;

				// Token: 0x0400D451 RID: 54353
				[Token(Token = "0x400D451")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public List<string> buffs_before;
			}

			// Token: 0x02002020 RID: 8224
			[Token(Token = "0x2002020")]
			public struct EnterDefenseOverviewParam
			{
				// Token: 0x0400D452 RID: 54354
				[Token(Token = "0x400D452")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string activity_id;
			}

			// Token: 0x02002021 RID: 8225
			[Token(Token = "0x2002021")]
			public struct DefenseOutParam
			{
				// Token: 0x0400D453 RID: 54355
				[Token(Token = "0x400D453")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string activity_id;

				// Token: 0x0400D454 RID: 54356
				[Token(Token = "0x400D454")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string source;

				// Token: 0x0400D455 RID: 54357
				[Token(Token = "0x400D455")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public List<EventLogTrace.EventLogVecBreakV2Context.DefenseStageInfo> defend_out_info;
			}

			// Token: 0x02002022 RID: 8226
			[Token(Token = "0x2002022")]
			public class DefenseStageInfo
			{
				// Token: 0x0600CAA7 RID: 51879 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600CAA7")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public DefenseStageInfo()
				{
				}

				// Token: 0x0400D456 RID: 54358
				[Token(Token = "0x400D456")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string buff_id;

				// Token: 0x0400D457 RID: 54359
				[Token(Token = "0x400D457")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string stage_id;
			}
		}
	}
}
