using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using Torappu;
using Torappu.UI.Shop;
using XLua;

namespace YostarTrace
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class YostarV2Trace
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x526AF0", Offset = "0x5256F0", VA = "0x180526AF0")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnCreateRole(string nickname, string uid)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x5274B0", Offset = "0x5260B0", VA = "0x1805274B0")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnLogin(string uid)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x528520", Offset = "0x527120", VA = "0x180528520")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnSendFriendRequest()
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x5299A0", Offset = "0x5285A0", VA = "0x1805299A0")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnStoryEnd(string storyId)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x526750", Offset = "0x525350", VA = "0x180526750")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnBattleEnd(string stageId, bool success, string reason)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x526C80", Offset = "0x525880", VA = "0x180526C80")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnEvolve(string charId, EvolvePhase evolvePhase)
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x5273E0", Offset = "0x525FE0", VA = "0x1805273E0")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnLevelUp(int level)
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x528430", Offset = "0x527030", VA = "0x180528430")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnRoomUpgraded(BuildingData.RoomType roomType, int roomLevel)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x526FC0", Offset = "0x525BC0", VA = "0x180526FC0")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnFetchGpShop(List<ShopGPCommonItemViewModel> gpItems)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x527240", Offset = "0x525E40", VA = "0x180527240")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnFetchSkinShop(List<ShopSkinItemViewModel> skinItems)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x526E50", Offset = "0x525A50", VA = "0x180526E50")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnFetchCashShop(List<CashShopObject> shopItems)
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x528CB0", Offset = "0x5278B0", VA = "0x180528CB0")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnShopTitleClicked(ShopType shopType, ShopPage.Referrer clickRef)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x528A00", Offset = "0x527600", VA = "0x180528A00")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnShopTabClicked(string viewTab, ShopPage.Referrer clickRef)
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x5285B0", Offset = "0x5271B0", VA = "0x1805285B0")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnShopItemClicked(string goodId)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x528740", Offset = "0x527340", VA = "0x180528740")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnShopItemShowed(string goodId, int remainCount)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x525820", Offset = "0x524420", VA = "0x180525820")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void ClearShopTraceCache()
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x527550", Offset = "0x526150", VA = "0x180527550")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnPurchaseClicked(string goodId)
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x527CC0", Offset = "0x5268C0", VA = "0x180527CC0")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnPurchaseCompleted(string goodId)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x5268B0", Offset = "0x5254B0", VA = "0x1805268B0")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnConfirmOrder(string orderId, string productId)
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x529C50", Offset = "0x528850", VA = "0x180529C50")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnVoucherPurchaseCompleted(string goodId)
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x529A90", Offset = "0x528690", VA = "0x180529A90")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnVoucherClicked(string goodId)
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x52A390", Offset = "0x528F90", VA = "0x18052A390")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void SetStoryStartInfo(string storyId, bool isFirstTime)
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x529FA0", Offset = "0x528BA0", VA = "0x180529FA0")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void SetHandbookInfo(string storyId)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x52A130", Offset = "0x528D30", VA = "0x18052A130")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void SetStoryReviewInfo(string storyId)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x529E10", Offset = "0x528A10", VA = "0x180529E10")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void SetCGGalleryInfo(string storyId)
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x528F50", Offset = "0x527B50", VA = "0x180528F50")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnStoryBegin(string storyId)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x529350", Offset = "0x527F50", VA = "0x180529350")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnStoryEnd(string storyId, string errorMsg)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x526480", Offset = "0x525080", VA = "0x180526480")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnBackflowTabClicked(string groupId, string tab)
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x5260B0", Offset = "0x524CB0", VA = "0x1805260B0")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnBackflowSpecialOpenJumpClicked(string groupId, int type, bool unlocked)
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x525CE0", Offset = "0x5248E0", VA = "0x180525CE0")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnBackflowNewsJumpClicked(string groupId, int type, bool unlocked)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x5259F0", Offset = "0x5245F0", VA = "0x1805259F0")]
		[Conditional("YOSTAR_SDK_V2")]
		public static void OnBackflowHomePageShowed(string groupId, bool isClicked)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x52AD50", Offset = "0x529950", VA = "0x18052AD50")]
		private static void _TraceShopPackageClicked(string clickRank, string clickButton, ShopPage.Referrer clickRef)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x52A860", Offset = "0x529460", VA = "0x18052A860")]
		private static void _TraceShopItemShowed(string eventName, string viewTab, string goodId, int remainCount, ShopPage.Referrer clickRef)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x52A620", Offset = "0x529220", VA = "0x18052A620")]
		private static void _SaveShopItemTraceData(string key, YostarV2Trace.ShopItemTraceData data)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x52B7E0", Offset = "0x52A3E0", VA = "0x18052B7E0")]
		private static bool _TryGetShopItemTraceData(string key, out YostarV2Trace.ShopItemTraceData data)
		{
			return default(bool);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x52A550", Offset = "0x529150", VA = "0x18052A550")]
		[Conditional("YOSTAR_SDK_V2")]
		private static void _OnTutorialComplete(int tutorialPhase)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x52B440", Offset = "0x52A040", VA = "0x18052B440")]
		[Conditional("YOSTAR_SDK_V2")]
		private static void _Trace(string eventName, [Optional] Dictionary<string, string> paramDict)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x52B230", Offset = "0x529E30", VA = "0x18052B230")]
		[Conditional("YOSTAR_SDK_V2")]
		private static void _TraceWithArgs(string eventName, params object[] args)
		{
		}

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		private const string YOSTAR_SDK_V2_DEFINE_SYMBOL = "YOSTAR_SDK_V2";

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		private const string YOSTAR_SDK_V2_EVENT_NAME = "eventName";

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		private const string YOSTAR_SDK_V2_EVENT_DATA = "eventData";

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ListDict<string, int> STORY_ID_TO_TUTORIAL_PHASE;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly ListDict<string, int> STAGE_ID_TO_TUTORIAL_PHASE;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static LocalGenericPool<YostarV2Trace.ShopItemTraceWrapper> s_itemTraceDataPool;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<string, YostarV2Trace.ShopItemTraceWrapper> s_goodIdToTraceDataMap;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool m_needToLogAvgStartInfo;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string m_avgEntryInfo;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string m_avgStoryId;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static long m_storyBeginTs;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static ListSet<string> m_shopGoodShowedSet;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static ShopType m_shopType;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static long m_shopEnterTs;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static string m_shopViewTab;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static ShopPage.Referrer m_shopClickRef;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnCreateRole;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnLogin;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnSendFriendRequest;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnStoryEnd;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnBattleEnd;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnEvolve;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnLevelUp;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnRoomUpgraded;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnFetchGpShop;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnFetchSkinShop;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnFetchCashShop;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnShopTitleClicked;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnShopTabClicked;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnShopItemClicked;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnShopItemShowed;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ClearShopTraceCache;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnPurchaseClicked;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnPurchaseCompleted;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnConfirmOrder;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnVoucherPurchaseCompleted;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnVoucherClicked;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_SetStoryStartInfo;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_SetHandbookInfo;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_SetStoryReviewInfo;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_SetCGGalleryInfo;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnStoryBegin;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix1_OnStoryEnd;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_OnBackflowTabClicked;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_OnBackflowSpecialOpenJumpClicked;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_OnBackflowNewsJumpClicked;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_OnBackflowHomePageShowed;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__TraceShopPackageClicked;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__TraceShopItemShowed;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__SaveShopItemTraceData;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__TryGetShopItemTraceData;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__OnTutorialComplete;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__Trace;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__TraceWithArgs;

		// Token: 0x0200007A RID: 122
		[Token(Token = "0x200007A")]
		private static class Consts
		{
			// Token: 0x04000225 RID: 549
			[Token(Token = "0x4000225")]
			public const string EVENT_ROLE_CREATE = "role_create";

			// Token: 0x04000226 RID: 550
			[Token(Token = "0x4000226")]
			public const string EVENT_ROLE_LOGIN = "role_login";

			// Token: 0x04000227 RID: 551
			[Token(Token = "0x4000227")]
			public const string EVENT_ADD_FRIEND = "add_friend";

			// Token: 0x04000228 RID: 552
			[Token(Token = "0x4000228")]
			public const string EVENT_PURCHASE_CLICK_ANY = "purchase_click";

			// Token: 0x04000229 RID: 553
			[Token(Token = "0x4000229")]
			public const string EVENT_PURCHASE_COMPLETE_ANY = "purchase_complete";

			// Token: 0x0400022A RID: 554
			[Token(Token = "0x400022A")]
			public const string EVENT_CONFIRM_ORDER = "confirm_order";

			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400022B")]
			public const string EVFORMAT_TUTORIAL_COMPLETE = "tutorial_complete_{0}";

			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400022C")]
			public const string EVFORMAT_STAGE_PASS = "chapter_{0}";

			// Token: 0x0400022D RID: 557
			[Token(Token = "0x400022D")]
			public const string EVFORMAT_CHAR_EVOLVE = "elite_{0}";

			// Token: 0x0400022E RID: 558
			[Token(Token = "0x400022E")]
			public const string EVFORMAT_ROLE_LEVEL = "role_level_{0}";

			// Token: 0x0400022F RID: 559
			[Token(Token = "0x400022F")]
			public const string EVFORMAT_CONTROL_UPGRADE = "control_center_level_{0}";

			// Token: 0x04000230 RID: 560
			[Token(Token = "0x4000230")]
			public const string EVFORMAT_PURCHASE_CLICK = "purchase_click_{0}";

			// Token: 0x04000231 RID: 561
			[Token(Token = "0x4000231")]
			public const string EVFORMAT_PURCHASE_COMPLETE = "purchase_complete_{0}";

			// Token: 0x04000232 RID: 562
			[Token(Token = "0x4000232")]
			public const string PARAM_UID = "uid";

			// Token: 0x04000233 RID: 563
			[Token(Token = "0x4000233")]
			public const string PARAM_NICKNAME = "nickname";

			// Token: 0x04000234 RID: 564
			[Token(Token = "0x4000234")]
			public const string PARAM_CHARID = "charid";

			// Token: 0x04000235 RID: 565
			[Token(Token = "0x4000235")]
			public const string PARAM_GOOD_ID = "goodid";

			// Token: 0x04000236 RID: 566
			[Token(Token = "0x4000236")]
			public const string PARAM_CASH_PRICE = "cashprice";

			// Token: 0x04000237 RID: 567
			[Token(Token = "0x4000237")]
			public const string PARAM_DIAMOND_PRICE = "diamondprice";

			// Token: 0x04000238 RID: 568
			[Token(Token = "0x4000238")]
			public const string PARAM_PRODUCT_ID = "productid";

			// Token: 0x04000239 RID: 569
			[Token(Token = "0x4000239")]
			public const string PARAM_ORDER_ID = "orderid";

			// Token: 0x0400023A RID: 570
			[Token(Token = "0x400023A")]
			public const string EVENT_NAME_START = "story_read_start";

			// Token: 0x0400023B RID: 571
			[Token(Token = "0x400023B")]
			public const string EVENT_NAME_END = "story_read_end";

			// Token: 0x0400023C RID: 572
			[Token(Token = "0x400023C")]
			public const string STORY_ONLY_FIRST_ENTRANCE_NAME = "story_first";

			// Token: 0x0400023D RID: 573
			[Token(Token = "0x400023D")]
			public const string STORY_ONLY_REPEAT_ENTRANCE_NAME = "story_repeat";

			// Token: 0x0400023E RID: 574
			[Token(Token = "0x400023E")]
			public const string HANDBOOK_STORY_ENTRANCE_NAME = "handbook";

			// Token: 0x0400023F RID: 575
			[Token(Token = "0x400023F")]
			public const string CG_GALLERY_ENTRANCE_NAME = "cggallery";

			// Token: 0x04000240 RID: 576
			[Token(Token = "0x4000240")]
			public const string STORY_MINI_REVIEW = "retrospect";

			// Token: 0x04000241 RID: 577
			[Token(Token = "0x4000241")]
			public const string STARTPARAM_ENTRANCE = "entrance";

			// Token: 0x04000242 RID: 578
			[Token(Token = "0x4000242")]
			public const string STARTPARAM_STORY_ID = "story_id";

			// Token: 0x04000243 RID: 579
			[Token(Token = "0x4000243")]
			public const string ENDPARAM_ENTRANCE = "entrance";

			// Token: 0x04000244 RID: 580
			[Token(Token = "0x4000244")]
			public const string ENDPARAM_STORY_ID = "story_id";

			// Token: 0x04000245 RID: 581
			[Token(Token = "0x4000245")]
			public const string ENDPARAM_USE_TIME = "use_time";

			// Token: 0x04000246 RID: 582
			[Token(Token = "0x4000246")]
			public const string ENDPARAM_IF_SKIP = "if_skip";

			// Token: 0x04000247 RID: 583
			[Token(Token = "0x4000247")]
			public const string BACKFLOW_SWITCH_TAB = "backflow_switch_tab";

			// Token: 0x04000248 RID: 584
			[Token(Token = "0x4000248")]
			public const string BACKFLOW_SPECIAL_OPEN_JUMP = "backflow_stage_jump";

			// Token: 0x04000249 RID: 585
			[Token(Token = "0x4000249")]
			public const string BACKFLOW_NEWS_JUMP = "backflow_news_jump";

			// Token: 0x0400024A RID: 586
			[Token(Token = "0x400024A")]
			public const string BACKFLOW_HOME_PAGE_VIEW = "backflow_homepage_view";

			// Token: 0x0400024B RID: 587
			[Token(Token = "0x400024B")]
			public const string BACKFLOW_PARAM_GROUP_ID = "bf_groupid";

			// Token: 0x0400024C RID: 588
			[Token(Token = "0x400024C")]
			public const string BACKFLOW_PARAM_TAB = "tab";

			// Token: 0x0400024D RID: 589
			[Token(Token = "0x400024D")]
			public const string BACKFLOW_PARAM_STAGE_TYPE = "bf_stage_type";

			// Token: 0x0400024E RID: 590
			[Token(Token = "0x400024E")]
			public const string BACKFLOW_PARAM_NEWS_TYPE = "bf_news_type";

			// Token: 0x0400024F RID: 591
			[Token(Token = "0x400024F")]
			public const string BACKFLOW_PARAM_IS_UNLOCK = "is_unlock";

			// Token: 0x04000250 RID: 592
			[Token(Token = "0x4000250")]
			public const string BACKFLOW_PARAM_IS_CLICKED = "is_clicked";

			// Token: 0x04000251 RID: 593
			[Token(Token = "0x4000251")]
			public const string SHOP_CLICK_PACKAGE_STORE = "click_package_store";

			// Token: 0x04000252 RID: 594
			[Token(Token = "0x4000252")]
			public const string SHOP_VIEW_PACKAGE_STORE = "view_package_store";

			// Token: 0x04000253 RID: 595
			[Token(Token = "0x4000253")]
			public const string SHOP_VIEW_SKIN_STORE = "view_skin_store";

			// Token: 0x04000254 RID: 596
			[Token(Token = "0x4000254")]
			public const string SHOP_PARAM_VIEW_TAB = "view_tab";

			// Token: 0x04000255 RID: 597
			[Token(Token = "0x4000255")]
			public const string SHOP_PARAM_ENTER_TS = "enter_ts";

			// Token: 0x04000256 RID: 598
			[Token(Token = "0x4000256")]
			public const string SHOP_PARAM_CLICK_RANK = "click_rank";

			// Token: 0x04000257 RID: 599
			[Token(Token = "0x4000257")]
			public const string SHOP_PARAM_CLICK_BUTTON = "click_button";

			// Token: 0x04000258 RID: 600
			[Token(Token = "0x4000258")]
			public const string SHOP_PARAM_REFERRER = "referrer";

			// Token: 0x04000259 RID: 601
			[Token(Token = "0x4000259")]
			public const string SHOP_PARAM_GOOD_ID = "good_id";

			// Token: 0x0400025A RID: 602
			[Token(Token = "0x400025A")]
			public const string SHOP_PARAM_AVAILABLE_PURCHASES = "available_purchases";

			// Token: 0x0400025B RID: 603
			[Token(Token = "0x400025B")]
			public const string SHOP_TAB_ALL = "all";
		}

		// Token: 0x0200007B RID: 123
		[Token(Token = "0x200007B")]
		public enum VoucherType
		{
			// Token: 0x0400025D RID: 605
			[Token(Token = "0x400025D")]
			SKINVOUCHER
		}

		// Token: 0x0200007C RID: 124
		[Token(Token = "0x200007C")]
		private struct ShopItemTraceData
		{
			// Token: 0x0400025E RID: 606
			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public YostarV2Trace.ShopItemTraceData.ItemType itemType;

			// Token: 0x0400025F RID: 607
			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int cashPrice;

			// Token: 0x04000260 RID: 608
			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int diamondPrice;

			// Token: 0x0200007D RID: 125
			[Token(Token = "0x200007D")]
			public enum ItemType
			{
				// Token: 0x04000262 RID: 610
				[Token(Token = "0x4000262")]
				CASH,
				// Token: 0x04000263 RID: 611
				[Token(Token = "0x4000263")]
				MONTLYCARD,
				// Token: 0x04000264 RID: 612
				[Token(Token = "0x4000264")]
				SKIN,
				// Token: 0x04000265 RID: 613
				[Token(Token = "0x4000265")]
				GP_MONTHLY,
				// Token: 0x04000266 RID: 614
				[Token(Token = "0x4000266")]
				GP_WEEKLY,
				// Token: 0x04000267 RID: 615
				[Token(Token = "0x4000267")]
				GP_ONCE,
				// Token: 0x04000268 RID: 616
				[Token(Token = "0x4000268")]
				GP_LEVEL
			}
		}

		// Token: 0x0200007E RID: 126
		[Token(Token = "0x200007E")]
		private class ShopItemTraceWrapper
		{
			// Token: 0x060001F9 RID: 505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ShopItemTraceWrapper()
			{
			}

			// Token: 0x04000269 RID: 617
			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public YostarV2Trace.ShopItemTraceData data;
		}
	}
}
