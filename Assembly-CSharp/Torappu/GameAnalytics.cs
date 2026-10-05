using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity.VecBreakV2;
using Torappu.EventTrack;
using Torappu.Resource;
using Torappu.UI.HotUpdate;
using Torappu.UI.Shop;
using XLua;

namespace Torappu
{
	// Token: 0x02000475 RID: 1141
	[Token(Token = "0x2000475")]
	public class GameAnalytics : PersistentSingleton<GameAnalytics>
	{
		// Token: 0x06004B86 RID: 19334 RVA: 0x0002CF28 File Offset: 0x0002B128
		[Token(Token = "0x6004B86")]
		[Address(RVA = "0x1682120", Offset = "0x1680D20", VA = "0x181682120")]
		public bool IsInited()
		{
			return default(bool);
		}

		// Token: 0x06004B87 RID: 19335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B87")]
		[Address(RVA = "0x1682040", Offset = "0x1680C40", VA = "0x181682040")]
		public void Init(string channel, string subChannel)
		{
		}

		// Token: 0x06004B88 RID: 19336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B88")]
		[Address(RVA = "0x1686370", Offset = "0x1684F70", VA = "0x181686370")]
		public void Register(string channelUid)
		{
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B89")]
		[Address(RVA = "0x1682180", Offset = "0x1680D80", VA = "0x181682180")]
		public void LoginAccount(string uid, string username)
		{
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8A")]
		[Address(RVA = "0x16823A0", Offset = "0x1680FA0", VA = "0x1816823A0")]
		public void LoginGame()
		{
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8B")]
		[Address(RVA = "0x1686480", Offset = "0x1685080", VA = "0x181686480")]
		public void StopGame()
		{
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8C")]
		[Address(RVA = "0x1683230", Offset = "0x1681E30", VA = "0x181683230")]
		public void OnSyncData()
		{
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8D")]
		[Address(RVA = "0x1682460", Offset = "0x1681060", VA = "0x181682460")]
		public void NewGuest(string channelUid)
		{
		}

		// Token: 0x06004B8E RID: 19342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8E")]
		[Address(RVA = "0x1681AE0", Offset = "0x16806E0", VA = "0x181681AE0")]
		public void CreateRole(string nickname, string uid)
		{
		}

		// Token: 0x06004B8F RID: 19343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8F")]
		[Address(RVA = "0x16863E0", Offset = "0x1684FE0", VA = "0x1816863E0")]
		public void SetLevel(int level)
		{
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B90")]
		[Address(RVA = "0x1682B40", Offset = "0x1681740", VA = "0x181682B40")]
		public void OnHotUpdateFinished()
		{
		}

		// Token: 0x06004B91 RID: 19345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B91")]
		[Address(RVA = "0x1682C20", Offset = "0x1681820", VA = "0x181682C20")]
		public void OnPaySucceed(string transactionId, string paymentType, float currencyAmount, string currencyType = "CNY")
		{
		}

		// Token: 0x06004B92 RID: 19346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B92")]
		[Address(RVA = "0x1682760", Offset = "0x1681360", VA = "0x181682760")]
		public void OnConfirmOrder(string orderId, string productId)
		{
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B93")]
		[Address(RVA = "0x1682810", Offset = "0x1681410", VA = "0x181682810")]
		public void OnCreateOrder(string transactionId, float currencyAmount, string currencyType = "CNY")
		{
		}

		// Token: 0x06004B94 RID: 19348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B94")]
		[Address(RVA = "0x16826E0", Offset = "0x16812E0", VA = "0x1816826E0")]
		public void OnBattleStart(string stageId)
		{
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B95")]
		[Address(RVA = "0x1682610", Offset = "0x1681210", VA = "0x181682610")]
		public void OnBattleEnd(string stageId, bool success, string reason = "")
		{
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B96")]
		[Address(RVA = "0x16824D0", Offset = "0x16810D0", VA = "0x1816824D0")]
		public void OnAdvancedGacha(string charId)
		{
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B97")]
		[Address(RVA = "0x1682BA0", Offset = "0x16817A0", VA = "0x181682BA0")]
		public void OnNormalGacha(string charId)
		{
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B98")]
		[Address(RVA = "0x16828A0", Offset = "0x16814A0", VA = "0x1816828A0")]
		public void OnEvolve(string charId, EvolvePhase phase)
		{
		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B99")]
		[Address(RVA = "0x1682D40", Offset = "0x1681940", VA = "0x181682D40")]
		public void OnPotentialBoost(string charId, int potentialRank, bool succeed)
		{
		}

		// Token: 0x06004B9A RID: 19354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B9A")]
		[Address(RVA = "0x1683050", Offset = "0x1681C50", VA = "0x181683050")]
		public void OnSkillMainLvlup(int charInstId, int skillIndex, int mainSkillLvl)
		{
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B9B")]
		[Address(RVA = "0x16830F0", Offset = "0x1681CF0", VA = "0x1816830F0")]
		public void OnSkillSpecializedUp(int charInstId, int skillIndex, int specializeLvl)
		{
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B9C")]
		[Address(RVA = "0x1683190", Offset = "0x1681D90", VA = "0x181683190")]
		public void OnStoryEnd(string storyId)
		{
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B9D")]
		[Address(RVA = "0x1682F20", Offset = "0x1681B20", VA = "0x181682F20")]
		public void OnRoomUpgraded(BuildingData.RoomType roomType, int roomLevel)
		{
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B9E")]
		[Address(RVA = "0x1682FD0", Offset = "0x1681BD0", VA = "0x181682FD0")]
		public void OnSendFriendRequest()
		{
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B9F")]
		[Address(RVA = "0x1682A00", Offset = "0x1681600", VA = "0x181682A00")]
		public void OnFetchGpShop(List<ShopGPCommonItemViewModel> gpItems)
		{
		}

		// Token: 0x06004BA0 RID: 19360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA0")]
		[Address(RVA = "0x1682AA0", Offset = "0x16816A0", VA = "0x181682AA0")]
		public void OnFetchSkinShop(List<ShopSkinItemViewModel> skinItems)
		{
		}

		// Token: 0x06004BA1 RID: 19361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA1")]
		[Address(RVA = "0x1682960", Offset = "0x1681560", VA = "0x181682960")]
		public void OnFetchCashShop(List<CashShopObject> cashItems)
		{
		}

		// Token: 0x06004BA2 RID: 19362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA2")]
		[Address(RVA = "0x1682DE0", Offset = "0x16819E0", VA = "0x181682DE0")]
		public void OnPurchaseClicked(string goodId)
		{
		}

		// Token: 0x06004BA3 RID: 19363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA3")]
		[Address(RVA = "0x1682E80", Offset = "0x1681A80", VA = "0x181682E80")]
		public void OnPurchaseCompleted(string goodId)
		{
		}

		// Token: 0x06004BA4 RID: 19364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA4")]
		[Address(RVA = "0x16832E0", Offset = "0x1681EE0", VA = "0x1816832E0")]
		public void OnVoucherClicked(string goodId)
		{
		}

		// Token: 0x06004BA5 RID: 19365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA5")]
		[Address(RVA = "0x1683380", Offset = "0x1681F80", VA = "0x181683380")]
		public void OnVoucherPurchaseCompleted(string goodId)
		{
		}

		// Token: 0x06004BA6 RID: 19366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA6")]
		[Address(RVA = "0x1682550", Offset = "0x1681150", VA = "0x181682550")]
		private void OnApplicationPause(bool pause)
		{
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA7")]
		[Address(RVA = "0x16825B0", Offset = "0x16811B0", VA = "0x1816825B0")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x0002CF40 File Offset: 0x0002B140
		[Token(Token = "0x6004BA8")]
		[Address(RVA = "0x16865E0", Offset = "0x16851E0", VA = "0x1816865E0")]
		private bool _CheckIfInited()
		{
			return default(bool);
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BA9")]
		[Address(RVA = "0x1686710", Offset = "0x1685310", VA = "0x181686710")]
		private string _GetChannel()
		{
			return null;
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAA")]
		[Address(RVA = "0x1686840", Offset = "0x1685440", VA = "0x181686840")]
		private string _GetSubChannel()
		{
			return null;
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x0002CF58 File Offset: 0x0002B158
		[Token(Token = "0x6004BAB")]
		[Address(RVA = "0x16868A0", Offset = "0x16854A0", VA = "0x1816868A0")]
		private bool _TryGetCharIdByInstId(int charInstId, out string charId)
		{
			return default(bool);
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAC")]
		[Address(RVA = "0x1681D50", Offset = "0x1680950", VA = "0x181681D50")]
		public static Dictionary<string, string> GetDeviceIdMap()
		{
			return null;
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAD")]
		[Address(RVA = "0x1681F50", Offset = "0x1680B50", VA = "0x181681F50")]
		public static string GetOfficialDeviceId()
		{
			return null;
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAE")]
		[Address(RVA = "0x1686770", Offset = "0x1685370", VA = "0x181686770")]
		private static string _GetPlatformStr()
		{
			return null;
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BAF")]
		[Address(RVA = "0x1685010", Offset = "0x1683C10", VA = "0x181685010")]
		public static void RecordReplayAvgLogClick(string storyId)
		{
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB0")]
		[Address(RVA = "0x1683D60", Offset = "0x1682960", VA = "0x181683D60")]
		public static void RecordBattleAvgLog(string storyId, bool isFirstTime = true)
		{
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB1")]
		[Address(RVA = "0x1684F60", Offset = "0x1683B60", VA = "0x181684F60")]
		public static void RecordMiniReviewClick(string storyId)
		{
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB2")]
		[Address(RVA = "0x1684A00", Offset = "0x1683600", VA = "0x181684A00")]
		public static void RecordHookBattleAvg(string storyId)
		{
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB3")]
		[Address(RVA = "0x1684800", Offset = "0x1683400", VA = "0x181684800")]
		public static void RecordHandbookStart(string storyId)
		{
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB4")]
		[Address(RVA = "0x16841D0", Offset = "0x1682DD0", VA = "0x1816841D0")]
		public static void RecordCGGalleryStartStory(string storyId)
		{
		}

		// Token: 0x06004BB5 RID: 19381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB5")]
		[Address(RVA = "0x1685DF0", Offset = "0x16849F0", VA = "0x181685DF0")]
		public static void RecordStartStory(string storyId)
		{
		}

		// Token: 0x06004BB6 RID: 19382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB6")]
		[Address(RVA = "0x1685EA0", Offset = "0x1684AA0", VA = "0x181685EA0")]
		public static void RecordStoryFinish(string storyId, string errorMsg)
		{
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB7")]
		[Address(RVA = "0x1684CF0", Offset = "0x16838F0", VA = "0x181684CF0")]
		public static void RecordHotUpdateDownloadStart(string srcList, long srcSize, bool isPreMain)
		{
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB8")]
		[Address(RVA = "0x1684BD0", Offset = "0x16837D0", VA = "0x181684BD0")]
		public static void RecordHotUpdateCheckConsistencyStart(ConsistencyChecker.CheckType checkType)
		{
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB9")]
		[Address(RVA = "0x1684ED0", Offset = "0x1683AD0", VA = "0x181684ED0")]
		public static void RecordHotupdatePrecent(float percent)
		{
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBA")]
		[Address(RVA = "0x1684C60", Offset = "0x1683860", VA = "0x181684C60")]
		public static void RecordHotUpdateDownloadFinish(bool isPreMain)
		{
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBB")]
		[Address(RVA = "0x1684B40", Offset = "0x1683740", VA = "0x181684B40")]
		public static void RecordHotUpdateCheckConsistencyFinish(ConsistencyChecker.CheckType checkType)
		{
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBC")]
		[Address(RVA = "0x1684DC0", Offset = "0x16839C0", VA = "0x181684DC0")]
		public static void RecordHotupdateDownloadError(HotUpdater.LogTraceErrorCode errorInfo)
		{
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBD")]
		[Address(RVA = "0x1684E50", Offset = "0x1683A50", VA = "0x181684E50")]
		public static void RecordHotupdateDownloadInterrupt()
		{
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBE")]
		[Address(RVA = "0x1684AC0", Offset = "0x16836C0", VA = "0x181684AC0")]
		public static void RecordHotUpdateCheckConsistencyError()
		{
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBF")]
		[Address(RVA = "0x1685400", Offset = "0x1684000", VA = "0x181685400")]
		public static void RecordSelectMainPackMode(HotUpdater.UpdatePreferenceType type, string size)
		{
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC0")]
		[Address(RVA = "0x1685F70", Offset = "0x1684B70", VA = "0x181685F70")]
		public static void RecordUpdateVoiceLangMode(List<HotUpdateVoicePackItemViewModel> list)
		{
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC1")]
		[Address(RVA = "0x16850D0", Offset = "0x1683CD0", VA = "0x1816850D0")]
		public static void RecordResTypeListChange(IList<string> typeList)
		{
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC2")]
		[Address(RVA = "0x1685570", Offset = "0x1684170", VA = "0x181685570")]
		public static void RecordShopEntryClick()
		{
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC3")]
		[Address(RVA = "0x16848B0", Offset = "0x16834B0", VA = "0x1816848B0")]
		public static void RecordHomeBannerClicked(ShopType shopType, string goodId)
		{
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0x16858C0", Offset = "0x16844C0", VA = "0x1816858C0")]
		public static void RecordShopTitleClicked(ShopType shopType, ShopPage.Referrer clickRef = ShopPage.Referrer.NONE)
		{
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC5")]
		[Address(RVA = "0x16855F0", Offset = "0x16841F0", VA = "0x1816855F0")]
		public static void RecordShopItemClicked(string goodId)
		{
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC6")]
		[Address(RVA = "0x16857F0", Offset = "0x16843F0", VA = "0x1816857F0")]
		public static void RecordShopTabClicked(string tabId, ShopPage.Referrer clickRef = ShopPage.Referrer.NONE)
		{
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC7")]
		[Address(RVA = "0x16856A0", Offset = "0x16842A0", VA = "0x1816856A0")]
		public static void RecordShopItemShowed(string goodId, int remainCount)
		{
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC8")]
		[Address(RVA = "0x1685770", Offset = "0x1684370", VA = "0x181685770")]
		public static void RecordShopSkinBuyClicked()
		{
		}

		// Token: 0x06004BC9 RID: 19401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC9")]
		[Address(RVA = "0x16854A0", Offset = "0x16840A0", VA = "0x1816854A0")]
		public static void RecordShopBlindBoxItemDetailClicked(List<string> skinBoxList, bool isObtainable, string boxId)
		{
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCA")]
		[Address(RVA = "0x1681CB0", Offset = "0x16808B0", VA = "0x181681CB0")]
		public static void ExitShop()
		{
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCB")]
		[Address(RVA = "0x1683F00", Offset = "0x1682B00", VA = "0x181683F00")]
		public static void RecordBuildingCharStartControl(string charId, bool isOwn, string roomSlotId)
		{
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCC")]
		[Address(RVA = "0x1683E30", Offset = "0x1682A30", VA = "0x181683E30")]
		public static void RecordBuildingCharEndControl(string charId, bool isOwn, string roomSlotId)
		{
		}

		// Token: 0x06004BCD RID: 19405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCD")]
		[Address(RVA = "0x1684730", Offset = "0x1683330", VA = "0x181684730")]
		public static void RecordEnemyDuelEmoteClicked(string actId, string sceneId, string modeId, bool emoteOn)
		{
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCE")]
		[Address(RVA = "0x16844C0", Offset = "0x16830C0", VA = "0x1816844C0")]
		public static void RecordEnemyDuelAfterBattleToEntryClicked(string actId, string sceneId, string modeId)
		{
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCF")]
		[Address(RVA = "0x1684660", Offset = "0x1683260", VA = "0x181684660")]
		public static void RecordEnemyDuelAfterBattleToRoomClicked(string actId, string sceneId, string modeId)
		{
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD0")]
		[Address(RVA = "0x1684590", Offset = "0x1683190", VA = "0x181684590")]
		public static void RecordEnemyDuelAfterBattleToMatchClicked(string actId, string sceneId, string modeId)
		{
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD1")]
		[Address(RVA = "0x16861A0", Offset = "0x1684DA0", VA = "0x1816861A0")]
		public static void RecordVecBreakV2EnterDefenseMain(string actId, string source)
		{
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD2")]
		[Address(RVA = "0x1686240", Offset = "0x1684E40", VA = "0x181686240")]
		public static void RecordVecBreakV2EnterDefenseOverview(string actId)
		{
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD3")]
		[Address(RVA = "0x16862D0", Offset = "0x1684ED0", VA = "0x1816862D0")]
		public static void RecordVecBreakV2SquadChangeBuff(string actId, ActVecBreakV2SquadBuffSelectViewModel model)
		{
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD4")]
		[Address(RVA = "0x1686000", Offset = "0x1684C00", VA = "0x181686000")]
		public static void RecordVecBreakV2DefenseChangeBuff(string actId, ActVecBreakV2DefenseStageSelectViewModel model, List<string> buffList)
		{
		}

		// Token: 0x06004BD5 RID: 19413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD5")]
		[Address(RVA = "0x16860D0", Offset = "0x1684CD0", VA = "0x1816860D0")]
		public static void RecordVecBreakV2DefenseOut(string actId, string source, string stageId, ActVecBreakV2DefenseStageDetailViewModel detailViewModel)
		{
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD6")]
		[Address(RVA = "0x1685990", Offset = "0x1684590", VA = "0x181685990")]
		public static void RecordSoCharInfoPageEnter(string targetId, string charId, string source)
		{
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD7")]
		[Address(RVA = "0x1685B00", Offset = "0x1684700", VA = "0x181685B00")]
		public static void RecordSoCharSummaryEnter(string targetId, string charId)
		{
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD8")]
		[Address(RVA = "0x1685A60", Offset = "0x1684660", VA = "0x181685A60")]
		public static void RecordSoCharLvlupEnter(string targetId, string charId)
		{
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD9")]
		[Address(RVA = "0x1685360", Offset = "0x1683F60", VA = "0x181685360")]
		public static void RecordRoguelikeNodeChoiceBack(string choiceId, string nodeType)
		{
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDA")]
		[Address(RVA = "0x1685160", Offset = "0x1683D60", VA = "0x181685160")]
		public static void RecordRoguelikeCopperBoxView()
		{
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDB")]
		[Address(RVA = "0x16851E0", Offset = "0x1683DE0", VA = "0x1816851E0")]
		public static void RecordRoguelikeCopperInEffectView()
		{
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDC")]
		[Address(RVA = "0x1685260", Offset = "0x1683E60", VA = "0x181685260")]
		public static void RecordRoguelikeCopperStepNumView()
		{
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDD")]
		[Address(RVA = "0x16852E0", Offset = "0x1683EE0", VA = "0x1816852E0")]
		public static void RecordRoguelikeCopperStoringRecruitView()
		{
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDE")]
		[Address(RVA = "0x1683FD0", Offset = "0x1682BD0", VA = "0x181683FD0")]
		public static void RecordBuildingSortControl(string sortType, bool isInverse, string roomType, string roomProduct, string roomSlotId)
		{
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDF")]
		[Address(RVA = "0x1685D10", Offset = "0x1684910", VA = "0x181685D10")]
		public static void RecordSquadAssistApplyBtnClick(string uid, bool isStarFriend, bool isStarFriendFirst, SharedCharData assistChar, EventLogTrace.EventLogSquadContext.SquadAssistType assistType)
		{
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE0")]
		[Address(RVA = "0x1683420", Offset = "0x1682020", VA = "0x181683420")]
		public static void RecordAct45SideLiveEntry()
		{
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE1")]
		[Address(RVA = "0x16834A0", Offset = "0x16820A0", VA = "0x1816834A0")]
		public static void RecordArtGalleryBtnClick(EventLogTrace.ArtGalleryClickRank clickRank, string clickBtn)
		{
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE2")]
		[Address(RVA = "0x1683660", Offset = "0x1682260", VA = "0x181683660")]
		public static void RecordArtGalleryDisplayPageBtnClick(EventLogTrace.ArtGalleryClickRank clickRank, string clickBtn, string itemId)
		{
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE3")]
		[Address(RVA = "0x1683560", Offset = "0x1682160", VA = "0x181683560")]
		public static void RecordArtGalleryCollectPageBtnClick(EventLogTrace.ArtGalleryClickRank clickRank, string clickBtn, string itemId, string relateSetId, List<EventLogTrace.EventLogArtGalleryContext.CollectionRewardStatus> statusList)
		{
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE4")]
		[Address(RVA = "0x1683840", Offset = "0x1682440", VA = "0x181683840")]
		public static void RecordArtMagazineFirstRewardDialogOpen()
		{
		}

		// Token: 0x06004BE5 RID: 19429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE5")]
		[Address(RVA = "0x1683750", Offset = "0x1682350", VA = "0x181683750")]
		public static void RecordArtMagazineButtonClicked(EventLogTrace.ArtGalleryClickRank clickRank, string clickBtn, string itemId)
		{
		}

		// Token: 0x06004BE6 RID: 19430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE6")]
		[Address(RVA = "0x16838C0", Offset = "0x16824C0", VA = "0x1816838C0")]
		public static void RecordArtMagazineLeafSaveSucc(EventLogTrace.ArtGalleryClickRank clickRank, string clickBtn, string itemId, int version, bool sameWithTemplate)
		{
		}

		// Token: 0x06004BE7 RID: 19431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE7")]
		[Address(RVA = "0x16840C0", Offset = "0x1682CC0", VA = "0x1816840C0")]
		public static void RecordCGGalleryEntryClicked(string storySetId)
		{
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE8")]
		[Address(RVA = "0x1684280", Offset = "0x1682E80", VA = "0x181684280")]
		public static void RecordCGGalleryUnlockStatus(string storySetId, List<string> cgList)
		{
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE9")]
		[Address(RVA = "0x1684150", Offset = "0x1682D50", VA = "0x181684150")]
		public static void RecordCGGalleryFavouriteModeClicked()
		{
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BEA")]
		[Address(RVA = "0x1685C70", Offset = "0x1684870", VA = "0x181685C70")]
		public static void RecordSocialCardAlbumPageOpen(string friendUid, bool hasLeafData)
		{
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BEB")]
		[Address(RVA = "0x1685BA0", Offset = "0x16847A0", VA = "0x181685BA0")]
		public static void RecordSocialCardAlbumLeafExpose(string friendUid, string leafId, int leafIndex)
		{
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BEC")]
		[Address(RVA = "0x1683C90", Offset = "0x1682890", VA = "0x181683C90")]
		public static void RecordBackflowTabClicked(string groupId, string tab)
		{
		}

		// Token: 0x06004BED RID: 19437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BED")]
		[Address(RVA = "0x1683B90", Offset = "0x1682790", VA = "0x181683B90")]
		public static void RecordBackflowSpecialOpenClicked(string groupId, EventLogTrace.EventLogBackflowTraceContext.BackflowSpecialOpenType type, bool unlocked)
		{
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BEE")]
		[Address(RVA = "0x1683A90", Offset = "0x1682690", VA = "0x181683A90")]
		public static void RecordBackflowNewsClicked(string groupId, EventLogTrace.EventLogBackflowTraceContext.BackflowNewsJumpType type, bool unlocked)
		{
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BEF")]
		[Address(RVA = "0x16839C0", Offset = "0x16825C0", VA = "0x1816839C0")]
		public static void RecordBackflowDlgShowed(string groupId, bool isClicked)
		{
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF0")]
		[Address(RVA = "0x16843F0", Offset = "0x1682FF0", VA = "0x1816843F0")]
		public static void RecordCheckinVideoReceiveBtnClicked(string actId, string type, int pageOrder, string clickType)
		{
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF1")]
		[Address(RVA = "0x1684320", Offset = "0x1682F20", VA = "0x181684320")]
		public static void RecordCheckinVideoBaseBtnClicked(string actId, string type, int pageOrder)
		{
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BF2")]
		[Address(RVA = "0x1686A20", Offset = "0x1685620", VA = "0x181686A20")]
		public GameAnalytics()
		{
		}

		// Token: 0x04000F45 RID: 3909
		[Token(Token = "0x4000F45")]
		[FieldOffset(Offset = "0x0")]
		private static string s_cachedPlatformStr;

		// Token: 0x04000F46 RID: 3910
		[Token(Token = "0x4000F46")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, string> s_cachedDeviceIdMap;

		// Token: 0x04000F47 RID: 3911
		[Token(Token = "0x4000F47")]
		private const string CHANNEL_OFFICIAL = "OFFICIAL";

		// Token: 0x04000F48 RID: 3912
		[Token(Token = "0x4000F48")]
		private const string CURRENCY_TYPE_CNY = "CNY";

		// Token: 0x04000F49 RID: 3913
		[Token(Token = "0x4000F49")]
		[FieldOffset(Offset = "0x18")]
		private string m_channel;

		// Token: 0x04000F4A RID: 3914
		[Token(Token = "0x4000F4A")]
		[FieldOffset(Offset = "0x20")]
		private string m_subChannel;

		// Token: 0x04000F4B RID: 3915
		[Token(Token = "0x4000F4B")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x04000F4C RID: 3916
		[Token(Token = "0x4000F4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsInited;

		// Token: 0x04000F4D RID: 3917
		[Token(Token = "0x4000F4D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04000F4E RID: 3918
		[Token(Token = "0x4000F4E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Register;

		// Token: 0x04000F4F RID: 3919
		[Token(Token = "0x4000F4F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoginAccount;

		// Token: 0x04000F50 RID: 3920
		[Token(Token = "0x4000F50")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoginGame;

		// Token: 0x04000F51 RID: 3921
		[Token(Token = "0x4000F51")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_StopGame;

		// Token: 0x04000F52 RID: 3922
		[Token(Token = "0x4000F52")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnSyncData;

		// Token: 0x04000F53 RID: 3923
		[Token(Token = "0x4000F53")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_NewGuest;

		// Token: 0x04000F54 RID: 3924
		[Token(Token = "0x4000F54")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CreateRole;

		// Token: 0x04000F55 RID: 3925
		[Token(Token = "0x4000F55")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetLevel;

		// Token: 0x04000F56 RID: 3926
		[Token(Token = "0x4000F56")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnHotUpdateFinished;

		// Token: 0x04000F57 RID: 3927
		[Token(Token = "0x4000F57")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnPaySucceed;

		// Token: 0x04000F58 RID: 3928
		[Token(Token = "0x4000F58")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnConfirmOrder;

		// Token: 0x04000F59 RID: 3929
		[Token(Token = "0x4000F59")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnCreateOrder;

		// Token: 0x04000F5A RID: 3930
		[Token(Token = "0x4000F5A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnBattleStart;

		// Token: 0x04000F5B RID: 3931
		[Token(Token = "0x4000F5B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnBattleEnd;

		// Token: 0x04000F5C RID: 3932
		[Token(Token = "0x4000F5C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnAdvancedGacha;

		// Token: 0x04000F5D RID: 3933
		[Token(Token = "0x4000F5D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnNormalGacha;

		// Token: 0x04000F5E RID: 3934
		[Token(Token = "0x4000F5E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnEvolve;

		// Token: 0x04000F5F RID: 3935
		[Token(Token = "0x4000F5F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnPotentialBoost;

		// Token: 0x04000F60 RID: 3936
		[Token(Token = "0x4000F60")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnSkillMainLvlup;

		// Token: 0x04000F61 RID: 3937
		[Token(Token = "0x4000F61")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnSkillSpecializedUp;

		// Token: 0x04000F62 RID: 3938
		[Token(Token = "0x4000F62")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnStoryEnd;

		// Token: 0x04000F63 RID: 3939
		[Token(Token = "0x4000F63")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnRoomUpgraded;

		// Token: 0x04000F64 RID: 3940
		[Token(Token = "0x4000F64")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnSendFriendRequest;

		// Token: 0x04000F65 RID: 3941
		[Token(Token = "0x4000F65")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnFetchGpShop;

		// Token: 0x04000F66 RID: 3942
		[Token(Token = "0x4000F66")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnFetchSkinShop;

		// Token: 0x04000F67 RID: 3943
		[Token(Token = "0x4000F67")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnFetchCashShop;

		// Token: 0x04000F68 RID: 3944
		[Token(Token = "0x4000F68")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnPurchaseClicked;

		// Token: 0x04000F69 RID: 3945
		[Token(Token = "0x4000F69")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnPurchaseCompleted;

		// Token: 0x04000F6A RID: 3946
		[Token(Token = "0x4000F6A")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnVoucherClicked;

		// Token: 0x04000F6B RID: 3947
		[Token(Token = "0x4000F6B")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnVoucherPurchaseCompleted;

		// Token: 0x04000F6C RID: 3948
		[Token(Token = "0x4000F6C")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnApplicationPause;

		// Token: 0x04000F6D RID: 3949
		[Token(Token = "0x4000F6D")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_OnApplicationQuit;

		// Token: 0x04000F6E RID: 3950
		[Token(Token = "0x4000F6E")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__CheckIfInited;

		// Token: 0x04000F6F RID: 3951
		[Token(Token = "0x4000F6F")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__GetChannel;

		// Token: 0x04000F70 RID: 3952
		[Token(Token = "0x4000F70")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__GetSubChannel;

		// Token: 0x04000F71 RID: 3953
		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__TryGetCharIdByInstId;

		// Token: 0x04000F72 RID: 3954
		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GetDeviceIdMap;

		// Token: 0x04000F73 RID: 3955
		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_GetOfficialDeviceId;

		// Token: 0x04000F74 RID: 3956
		[Token(Token = "0x4000F74")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__GetPlatformStr;

		// Token: 0x04000F75 RID: 3957
		[Token(Token = "0x4000F75")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_RecordReplayAvgLogClick;

		// Token: 0x04000F76 RID: 3958
		[Token(Token = "0x4000F76")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_RecordBattleAvgLog;

		// Token: 0x04000F77 RID: 3959
		[Token(Token = "0x4000F77")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_RecordMiniReviewClick;

		// Token: 0x04000F78 RID: 3960
		[Token(Token = "0x4000F78")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_RecordHookBattleAvg;

		// Token: 0x04000F79 RID: 3961
		[Token(Token = "0x4000F79")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_RecordHandbookStart;

		// Token: 0x04000F7A RID: 3962
		[Token(Token = "0x4000F7A")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_RecordCGGalleryStartStory;

		// Token: 0x04000F7B RID: 3963
		[Token(Token = "0x4000F7B")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_RecordStartStory;

		// Token: 0x04000F7C RID: 3964
		[Token(Token = "0x4000F7C")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_RecordStoryFinish;

		// Token: 0x04000F7D RID: 3965
		[Token(Token = "0x4000F7D")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_RecordHotUpdateDownloadStart;

		// Token: 0x04000F7E RID: 3966
		[Token(Token = "0x4000F7E")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_RecordHotUpdateCheckConsistencyStart;

		// Token: 0x04000F7F RID: 3967
		[Token(Token = "0x4000F7F")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_RecordHotupdatePrecent;

		// Token: 0x04000F80 RID: 3968
		[Token(Token = "0x4000F80")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_RecordHotUpdateDownloadFinish;

		// Token: 0x04000F81 RID: 3969
		[Token(Token = "0x4000F81")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_RecordHotUpdateCheckConsistencyFinish;

		// Token: 0x04000F82 RID: 3970
		[Token(Token = "0x4000F82")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_RecordHotupdateDownloadError;

		// Token: 0x04000F83 RID: 3971
		[Token(Token = "0x4000F83")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_RecordHotupdateDownloadInterrupt;

		// Token: 0x04000F84 RID: 3972
		[Token(Token = "0x4000F84")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_RecordHotUpdateCheckConsistencyError;

		// Token: 0x04000F85 RID: 3973
		[Token(Token = "0x4000F85")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_RecordSelectMainPackMode;

		// Token: 0x04000F86 RID: 3974
		[Token(Token = "0x4000F86")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_RecordUpdateVoiceLangMode;

		// Token: 0x04000F87 RID: 3975
		[Token(Token = "0x4000F87")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_RecordResTypeListChange;

		// Token: 0x04000F88 RID: 3976
		[Token(Token = "0x4000F88")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_RecordShopEntryClick;

		// Token: 0x04000F89 RID: 3977
		[Token(Token = "0x4000F89")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_RecordHomeBannerClicked;

		// Token: 0x04000F8A RID: 3978
		[Token(Token = "0x4000F8A")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_RecordShopTitleClicked;

		// Token: 0x04000F8B RID: 3979
		[Token(Token = "0x4000F8B")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_RecordShopItemClicked;

		// Token: 0x04000F8C RID: 3980
		[Token(Token = "0x4000F8C")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_RecordShopTabClicked;

		// Token: 0x04000F8D RID: 3981
		[Token(Token = "0x4000F8D")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_RecordShopItemShowed;

		// Token: 0x04000F8E RID: 3982
		[Token(Token = "0x4000F8E")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_RecordShopSkinBuyClicked;

		// Token: 0x04000F8F RID: 3983
		[Token(Token = "0x4000F8F")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_RecordShopBlindBoxItemDetailClicked;

		// Token: 0x04000F90 RID: 3984
		[Token(Token = "0x4000F90")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_ExitShop;

		// Token: 0x04000F91 RID: 3985
		[Token(Token = "0x4000F91")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_RecordBuildingCharStartControl;

		// Token: 0x04000F92 RID: 3986
		[Token(Token = "0x4000F92")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_RecordBuildingCharEndControl;

		// Token: 0x04000F93 RID: 3987
		[Token(Token = "0x4000F93")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_RecordEnemyDuelEmoteClicked;

		// Token: 0x04000F94 RID: 3988
		[Token(Token = "0x4000F94")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_RecordEnemyDuelAfterBattleToEntryClicked;

		// Token: 0x04000F95 RID: 3989
		[Token(Token = "0x4000F95")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_RecordEnemyDuelAfterBattleToRoomClicked;

		// Token: 0x04000F96 RID: 3990
		[Token(Token = "0x4000F96")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_RecordEnemyDuelAfterBattleToMatchClicked;

		// Token: 0x04000F97 RID: 3991
		[Token(Token = "0x4000F97")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_RecordVecBreakV2EnterDefenseMain;

		// Token: 0x04000F98 RID: 3992
		[Token(Token = "0x4000F98")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_RecordVecBreakV2EnterDefenseOverview;

		// Token: 0x04000F99 RID: 3993
		[Token(Token = "0x4000F99")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_RecordVecBreakV2SquadChangeBuff;

		// Token: 0x04000F9A RID: 3994
		[Token(Token = "0x4000F9A")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_RecordVecBreakV2DefenseChangeBuff;

		// Token: 0x04000F9B RID: 3995
		[Token(Token = "0x4000F9B")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_RecordVecBreakV2DefenseOut;

		// Token: 0x04000F9C RID: 3996
		[Token(Token = "0x4000F9C")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_RecordSoCharInfoPageEnter;

		// Token: 0x04000F9D RID: 3997
		[Token(Token = "0x4000F9D")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_RecordSoCharSummaryEnter;

		// Token: 0x04000F9E RID: 3998
		[Token(Token = "0x4000F9E")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_RecordSoCharLvlupEnter;

		// Token: 0x04000F9F RID: 3999
		[Token(Token = "0x4000F9F")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_RecordRoguelikeNodeChoiceBack;

		// Token: 0x04000FA0 RID: 4000
		[Token(Token = "0x4000FA0")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_RecordRoguelikeCopperBoxView;

		// Token: 0x04000FA1 RID: 4001
		[Token(Token = "0x4000FA1")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_RecordRoguelikeCopperInEffectView;

		// Token: 0x04000FA2 RID: 4002
		[Token(Token = "0x4000FA2")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_RecordRoguelikeCopperStepNumView;

		// Token: 0x04000FA3 RID: 4003
		[Token(Token = "0x4000FA3")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_RecordRoguelikeCopperStoringRecruitView;

		// Token: 0x04000FA4 RID: 4004
		[Token(Token = "0x4000FA4")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_RecordBuildingSortControl;

		// Token: 0x04000FA5 RID: 4005
		[Token(Token = "0x4000FA5")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_RecordSquadAssistApplyBtnClick;

		// Token: 0x04000FA6 RID: 4006
		[Token(Token = "0x4000FA6")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_RecordAct45SideLiveEntry;

		// Token: 0x04000FA7 RID: 4007
		[Token(Token = "0x4000FA7")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_RecordArtGalleryBtnClick;

		// Token: 0x04000FA8 RID: 4008
		[Token(Token = "0x4000FA8")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_RecordArtGalleryDisplayPageBtnClick;

		// Token: 0x04000FA9 RID: 4009
		[Token(Token = "0x4000FA9")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_RecordArtGalleryCollectPageBtnClick;

		// Token: 0x04000FAA RID: 4010
		[Token(Token = "0x4000FAA")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_RecordArtMagazineFirstRewardDialogOpen;

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4000FAB")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_RecordArtMagazineButtonClicked;

		// Token: 0x04000FAC RID: 4012
		[Token(Token = "0x4000FAC")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_RecordArtMagazineLeafSaveSucc;

		// Token: 0x04000FAD RID: 4013
		[Token(Token = "0x4000FAD")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_RecordCGGalleryEntryClicked;

		// Token: 0x04000FAE RID: 4014
		[Token(Token = "0x4000FAE")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_RecordCGGalleryUnlockStatus;

		// Token: 0x04000FAF RID: 4015
		[Token(Token = "0x4000FAF")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_RecordCGGalleryFavouriteModeClicked;

		// Token: 0x04000FB0 RID: 4016
		[Token(Token = "0x4000FB0")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_RecordSocialCardAlbumPageOpen;

		// Token: 0x04000FB1 RID: 4017
		[Token(Token = "0x4000FB1")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_RecordSocialCardAlbumLeafExpose;

		// Token: 0x04000FB2 RID: 4018
		[Token(Token = "0x4000FB2")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_RecordBackflowTabClicked;

		// Token: 0x04000FB3 RID: 4019
		[Token(Token = "0x4000FB3")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_RecordBackflowSpecialOpenClicked;

		// Token: 0x04000FB4 RID: 4020
		[Token(Token = "0x4000FB4")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_RecordBackflowNewsClicked;

		// Token: 0x04000FB5 RID: 4021
		[Token(Token = "0x4000FB5")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_RecordBackflowDlgShowed;

		// Token: 0x04000FB6 RID: 4022
		[Token(Token = "0x4000FB6")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_RecordCheckinVideoReceiveBtnClicked;

		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		[FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_RecordCheckinVideoBaseBtnClicked;

		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		[FieldOffset(Offset = "0x370")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000476 RID: 1142
		[Token(Token = "0x2000476")]
		public static class EventNames
		{
			// Token: 0x04000FB9 RID: 4025
			[Token(Token = "0x4000FB9")]
			public const string EVOLVE_F = "evolve_{0}";

			// Token: 0x04000FBA RID: 4026
			[Token(Token = "0x4000FBA")]
			public const string POTENTIAL_SUCC_F = "potential_succ_{0}";

			// Token: 0x04000FBB RID: 4027
			[Token(Token = "0x4000FBB")]
			public const string POTENTIAL_FAIL_F = "potential_fail_{0}";

			// Token: 0x04000FBC RID: 4028
			[Token(Token = "0x4000FBC")]
			public const string SKILL_MAINLVL_UP_F = "skill_mainlvlup_{0}";

			// Token: 0x04000FBD RID: 4029
			[Token(Token = "0x4000FBD")]
			public const string SKILL_SPECIALIZED_UP_F = "skill_specialized_{0}";

			// Token: 0x04000FBE RID: 4030
			[Token(Token = "0x4000FBE")]
			public const string ADVANCED_GACHA = "advanced_gacha";

			// Token: 0x04000FBF RID: 4031
			[Token(Token = "0x4000FBF")]
			public const string NORMAL_GACHA = "normal_gacha";
		}
	}
}
