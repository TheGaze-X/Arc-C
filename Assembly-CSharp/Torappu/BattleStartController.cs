using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.UI;
using Torappu.Network;
using Torappu.UI;
using Torappu.UI.BattleFinish;
using Torappu.UI.Squad;
using XLua;

namespace Torappu
{
	// Token: 0x02001404 RID: 5124
	[Token(Token = "0x2001404")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BattleStartController
	{
		// Token: 0x06007676 RID: 30326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007676")]
		[Address(RVA = "0x241B680", Offset = "0x241A280", VA = "0x18241B680")]
		public static BattleStartController.Handler StartBattle(BattleStartController.Param param, [Optional] BattleStartController.IPlugin plugin)
		{
			return null;
		}

		// Token: 0x06007677 RID: 30327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007677")]
		[Address(RVA = "0x241BB90", Offset = "0x241A790", VA = "0x18241BB90")]
		public static BattleStartController.Handler StartLocalBattle(BattleStartController.Param param, [Optional] BattleStartController.IPlugin plugin)
		{
			return null;
		}

		// Token: 0x06007678 RID: 30328 RVA: 0x00035088 File Offset: 0x00033288
		[Token(Token = "0x6007678")]
		[Address(RVA = "0x241CA10", Offset = "0x241B610", VA = "0x18241CA10")]
		private static bool _CheckAndBuildCurContext(BattleStartController.Param param, BattleStartController.IPlugin plugin)
		{
			return default(bool);
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007679")]
		[Address(RVA = "0x241E180", Offset = "0x241CD80", VA = "0x18241E180")]
		private static void _SendStoryOnlyRequest(string stageId, bool isRetro, Action<StoryOnlyStartBattleResponse> handler)
		{
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600767A")]
		[Address(RVA = "0x241D040", Offset = "0x241BC40", VA = "0x18241D040")]
		private static IEnumerator _FakeSendCoroutine(Action<StoryOnlyStartBattleResponse> handler)
		{
			return null;
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600767B")]
		[Address(RVA = "0x241DC10", Offset = "0x241C810", VA = "0x18241DC10")]
		private static UIPageControllerParam _SceneParamToStage(DataBundle bundleToStage)
		{
			return null;
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600767C")]
		[Address(RVA = "0x241BE40", Offset = "0x241AA40", VA = "0x18241BE40")]
		public static void StartStoryOnlyBattleRecoverWithParam(string stageId, Func<StoryOnlyStartBattleResponse, ISceneParam> paramFunc)
		{
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600767D")]
		[Address(RVA = "0x241C030", Offset = "0x241AC30", VA = "0x18241C030")]
		public static void StartStoryOnlyBattle(string stageId)
		{
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600767E")]
		[Address(RVA = "0x241B320", Offset = "0x2419F20", VA = "0x18241B320")]
		public static void StartAVGAndBackToStageWithParam(StoryData targetStory, ISceneParam sceneParam)
		{
		}

		// Token: 0x0600767F RID: 30335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600767F")]
		[Address(RVA = "0x241B470", Offset = "0x241A070", VA = "0x18241B470")]
		public static void StartAVGAndBackToStage(StoryData targetStory, DataBundle stageBundle)
		{
		}

		// Token: 0x06007680 RID: 30336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007680")]
		[Address(RVA = "0x241B8F0", Offset = "0x241A4F0", VA = "0x18241B8F0")]
		public static BattleStartController.Handler StartFastBattle(BattleStartController.Param param, [Optional] BattleStartController.IPlugin plugin)
		{
			return null;
		}

		// Token: 0x06007681 RID: 30337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007681")]
		[Address(RVA = "0x241E3F0", Offset = "0x241CFF0", VA = "0x18241E3F0")]
		private static IEnumerator _StartFastBattleImpl()
		{
			return null;
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007682")]
		[Address(RVA = "0x241D800", Offset = "0x241C400", VA = "0x18241D800")]
		private static void _OnSucceed()
		{
		}

		// Token: 0x06007683 RID: 30339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007683")]
		[Address(RVA = "0x241D660", Offset = "0x241C260", VA = "0x18241D660")]
		private static void _OnFailed()
		{
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007684")]
		[Address(RVA = "0x241DED0", Offset = "0x241CAD0", VA = "0x18241DED0")]
		private static void _SendStartBattleService()
		{
		}

		// Token: 0x06007685 RID: 30341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007685")]
		public static void StartBattleServiceConfig_SendService<TRequest, TResponse>(string serviceCode, TRequest request) where TResponse : CommonStartBattleResponse
		{
		}

		// Token: 0x06007686 RID: 30342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007686")]
		private static void _DoSendStartBattleService<TRequest, TResponse>(string serviceCode, TRequest request) where TResponse : CommonStartBattleResponse
		{
		}

		// Token: 0x06007687 RID: 30343 RVA: 0x000350A0 File Offset: 0x000332A0
		[Token(Token = "0x6007687")]
		[Address(RVA = "0x241D750", Offset = "0x241C350", VA = "0x18241D750")]
		private static bool _OnStartBattleFail(ResponseError error)
		{
			return default(bool);
		}

		// Token: 0x06007688 RID: 30344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007688")]
		private static void _OnStartBattleSucceed<TResponse>(TResponse response) where TResponse : CommonStartBattleResponse
		{
		}

		// Token: 0x06007689 RID: 30345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007689")]
		[Address(RVA = "0x241CEC0", Offset = "0x241BAC0", VA = "0x18241CEC0")]
		private static void _ClearSpritesInSquad()
		{
		}

		// Token: 0x0600768A RID: 30346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600768A")]
		private static void _ProcessStartBattleSucceed<TResponse>(TResponse response) where TResponse : CommonStartBattleResponse
		{
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x000350B8 File Offset: 0x000332B8
		[Token(Token = "0x600768B")]
		[Address(RVA = "0x241D1F0", Offset = "0x241BDF0", VA = "0x18241D1F0")]
		private static BattleStageInfo _LoadBattleStageInfo(BattleStartController.Param param)
		{
			return default(BattleStageInfo);
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600768C")]
		[Address(RVA = "0x241C3E0", Offset = "0x241AFE0", VA = "0x18241C3E0")]
		private static void _CacheBattleInfo(BattleStageInfo stageInfo, BattleStartController.Param param)
		{
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x000350D0 File Offset: 0x000332D0
		[Token(Token = "0x600768D")]
		[Address(RVA = "0x241B230", Offset = "0x2419E30", VA = "0x18241B230")]
		private static bool SkipRecordLastBattle(string stageId, BattleStageMeta.BusinessType type)
		{
			return default(bool);
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600768E")]
		[Address(RVA = "0x241C220", Offset = "0x241AE20", VA = "0x18241C220")]
		private static void _AlertAndReloginForMiscError(int serviceResult)
		{
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600768F")]
		[Address(RVA = "0x241B5D0", Offset = "0x241A1D0", VA = "0x18241B5D0")]
		private static IEnumerator StartBattleWhenAVGFinish()
		{
			return null;
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007690")]
		private static T _ParseCommonStartBattleRequest<T>() where T : CommonStartBattleRequest, new()
		{
			return null;
		}

		// Token: 0x06007691 RID: 30353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007691")]
		[Address(RVA = "0x241D980", Offset = "0x241C580", VA = "0x18241D980")]
		private static DefaultStartBattleRequest _ParseDefaultStartBattleRequest()
		{
			return null;
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007692")]
		[Address(RVA = "0x241D8F0", Offset = "0x241C4F0", VA = "0x18241D8F0")]
		private static CampaignStartBattleRequest _ParseCampaignStartBattleRequest()
		{
			return null;
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007693")]
		private static void _ProcessStartBattleSigned<TResponse>(TResponse rawResp) where TResponse : CommonStartBattleResponse
		{
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007694")]
		[Address(RVA = "0x241D100", Offset = "0x241BD00", VA = "0x18241D100")]
		private static string _GenStartBattleSeed()
		{
			return null;
		}

		// Token: 0x040073A0 RID: 29600
		[Token(Token = "0x40073A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ObscuredString START_BATTLE_SIGN_KEY;

		// Token: 0x040073A1 RID: 29601
		[Token(Token = "0x40073A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static BattleStartController.Cache m_cache;

		// Token: 0x040073A2 RID: 29602
		[Token(Token = "0x40073A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_StartBattle;

		// Token: 0x040073A3 RID: 29603
		[Token(Token = "0x40073A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_StartLocalBattle;

		// Token: 0x040073A4 RID: 29604
		[Token(Token = "0x40073A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0__CheckAndBuildCurContext;

		// Token: 0x040073A5 RID: 29605
		[Token(Token = "0x40073A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0__SendStoryOnlyRequest;

		// Token: 0x040073A6 RID: 29606
		[Token(Token = "0x40073A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0__FakeSendCoroutine;

		// Token: 0x040073A7 RID: 29607
		[Token(Token = "0x40073A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0__SceneParamToStage;

		// Token: 0x040073A8 RID: 29608
		[Token(Token = "0x40073A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_StartStoryOnlyBattleRecoverWithParam;

		// Token: 0x040073A9 RID: 29609
		[Token(Token = "0x40073A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_StartStoryOnlyBattle;

		// Token: 0x040073AA RID: 29610
		[Token(Token = "0x40073AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_StartAVGAndBackToStageWithParam;

		// Token: 0x040073AB RID: 29611
		[Token(Token = "0x40073AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_StartAVGAndBackToStage;

		// Token: 0x040073AC RID: 29612
		[Token(Token = "0x40073AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_StartFastBattle;

		// Token: 0x040073AD RID: 29613
		[Token(Token = "0x40073AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0__StartFastBattleImpl;

		// Token: 0x040073AE RID: 29614
		[Token(Token = "0x40073AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0__OnSucceed;

		// Token: 0x040073AF RID: 29615
		[Token(Token = "0x40073AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0__OnFailed;

		// Token: 0x040073B0 RID: 29616
		[Token(Token = "0x40073B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0__SendStartBattleService;

		// Token: 0x040073B1 RID: 29617
		[Token(Token = "0x40073B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_StartBattleServiceConfig_SendService;

		// Token: 0x040073B2 RID: 29618
		[Token(Token = "0x40073B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0__DoSendStartBattleService;

		// Token: 0x040073B3 RID: 29619
		[Token(Token = "0x40073B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0__OnStartBattleFail;

		// Token: 0x040073B4 RID: 29620
		[Token(Token = "0x40073B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0__OnStartBattleSucceed;

		// Token: 0x040073B5 RID: 29621
		[Token(Token = "0x40073B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0__ClearSpritesInSquad;

		// Token: 0x040073B6 RID: 29622
		[Token(Token = "0x40073B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0__ProcessStartBattleSucceed;

		// Token: 0x040073B7 RID: 29623
		[Token(Token = "0x40073B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0__LoadBattleStageInfo;

		// Token: 0x040073B8 RID: 29624
		[Token(Token = "0x40073B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0__CacheBattleInfo;

		// Token: 0x040073B9 RID: 29625
		[Token(Token = "0x40073B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_SkipRecordLastBattle;

		// Token: 0x040073BA RID: 29626
		[Token(Token = "0x40073BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0__AlertAndReloginForMiscError;

		// Token: 0x040073BB RID: 29627
		[Token(Token = "0x40073BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_StartBattleWhenAVGFinish;

		// Token: 0x040073BC RID: 29628
		[Token(Token = "0x40073BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0__ParseCommonStartBattleRequest;

		// Token: 0x040073BD RID: 29629
		[Token(Token = "0x40073BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0__ParseDefaultStartBattleRequest;

		// Token: 0x040073BE RID: 29630
		[Token(Token = "0x40073BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0__ParseCampaignStartBattleRequest;

		// Token: 0x040073BF RID: 29631
		[Token(Token = "0x40073BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0__ProcessStartBattleSigned;

		// Token: 0x040073C0 RID: 29632
		[Token(Token = "0x40073C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0__GenStartBattleSeed;

		// Token: 0x02001405 RID: 5125
		[Token(Token = "0x2001405")]
		public interface IPlugin
		{
			// Token: 0x06007696 RID: 30358
			[Token(Token = "0x6007696")]
			void OverrideInParams(ref BattleInOut.InParams inParams, CommonStartBattleResponse response);
		}

		// Token: 0x02001406 RID: 5126
		[Token(Token = "0x2001406")]
		public struct Param
		{
			// Token: 0x040073C1 RID: 29633
			[Token(Token = "0x40073C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string stageId;

			// Token: 0x040073C2 RID: 29634
			[Token(Token = "0x40073C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool isPractise;

			// Token: 0x040073C3 RID: 29635
			[Token(Token = "0x40073C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public bool isAutoBattle;

			// Token: 0x040073C4 RID: 29636
			[Token(Token = "0x40073C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public bool assistIsFriend;

			// Token: 0x040073C5 RID: 29637
			[Token(Token = "0x40073C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
			public bool assistIsPredefined;

			// Token: 0x040073C6 RID: 29638
			[Token(Token = "0x40073C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool isRetro;

			// Token: 0x040073C7 RID: 29639
			[Token(Token = "0x40073C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public StageDiffGroup diffGroup;

			// Token: 0x040073C8 RID: 29640
			[Token(Token = "0x40073C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int diffGroupPry;

			// Token: 0x040073C9 RID: 29641
			[Token(Token = "0x40073C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isSkillSelectable;

			// Token: 0x040073CA RID: 29642
			[Token(Token = "0x40073CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool isMultipleBattle;

			// Token: 0x040073CB RID: 29643
			[Token(Token = "0x40073CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int multipleBattleTimes;

			// Token: 0x040073CC RID: 29644
			[Token(Token = "0x40073CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CommonStartBattleRequest.SquadModel squadForRequest;

			// Token: 0x040073CD RID: 29645
			[Token(Token = "0x40073CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SquadFriendData assistFriend;

			// Token: 0x040073CE RID: 29646
			[Token(Token = "0x40073CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SquadItemStruct[] squadLocal;

			// Token: 0x040073CF RID: 29647
			[Token(Token = "0x40073CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public BattleFinishIllust finishIllust;

			// Token: 0x040073D0 RID: 29648
			[Token(Token = "0x40073D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public List<RuneTable.PackedRuneData> runeList;

			// Token: 0x040073D1 RID: 29649
			[Token(Token = "0x40073D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public string overrideBuffItemId;

			// Token: 0x040073D2 RID: 29650
			[Token(Token = "0x40073D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public string overrideLoadingPic;

			// Token: 0x040073D3 RID: 29651
			[Token(Token = "0x40073D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public string overrideBgmEvent;

			// Token: 0x040073D4 RID: 29652
			[Token(Token = "0x40073D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public BattleStageInfo overrideStageInfo;

			// Token: 0x040073D5 RID: 29653
			[Token(Token = "0x40073D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public BattlePlayerData overrideBattlePlayerData;

			// Token: 0x040073D6 RID: 29654
			[Token(Token = "0x40073D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public StageId overrideStageIdStruct;

			// Token: 0x040073D7 RID: 29655
			[Token(Token = "0x40073D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			public IStartBattleServiceConfig customizeStartService;

			// Token: 0x040073D8 RID: 29656
			[Token(Token = "0x40073D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			public IFinishBattleServiceConfig customizedFinishService;

			// Token: 0x040073D9 RID: 29657
			[Token(Token = "0x40073D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			public BattleActivityMeta actMeta;

			// Token: 0x040073DA RID: 29658
			[Token(Token = "0x40073DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			public BattleRoguelikeMeta roguelikeMeta;

			// Token: 0x040073DB RID: 29659
			[Token(Token = "0x40073DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			public BattleFinishIndexState.IPlugin battleFinishIndexPlugin;

			// Token: 0x040073DC RID: 29660
			[Token(Token = "0x40073DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			public bool skipBattleFinishWhenFailed;

			// Token: 0x040073DD RID: 29661
			[Token(Token = "0x40073DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			public BattleSysMenuStyle sysMenuStyle;

			// Token: 0x040073DE RID: 29662
			[Token(Token = "0x40073DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			public DataBundle bundleToJumpBack;

			// Token: 0x040073DF RID: 29663
			[Token(Token = "0x40073DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			public bool uploadBattleLog;

			// Token: 0x040073E0 RID: 29664
			[Token(Token = "0x40073E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			public BattleStageMeta stageMeta;

			// Token: 0x040073E1 RID: 29665
			[Token(Token = "0x40073E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			public BattleCharmMeta charmMeta;

			// Token: 0x040073E2 RID: 29666
			[Token(Token = "0x40073E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			public BattleTemplateTrapMeta templateTrapMeta;

			// Token: 0x040073E3 RID: 29667
			[Token(Token = "0x40073E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			public BattleTechMeta techMeta;

			// Token: 0x040073E4 RID: 29668
			[Token(Token = "0x40073E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			public BattleCartMeta cartMeta;

			// Token: 0x040073E5 RID: 29669
			[Token(Token = "0x40073E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			public BattleTrapToolMeta trapToolMeta;

			// Token: 0x040073E6 RID: 29670
			[Token(Token = "0x40073E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			public BattlePerformanceMeta battlePerformanceMeta;

			// Token: 0x040073E7 RID: 29671
			[Token(Token = "0x40073E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
			public BattleFireworkMeta battleFireworkMeta;

			// Token: 0x040073E8 RID: 29672
			[Token(Token = "0x40073E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
			public GameModeMeta gameModeMeta;

			// Token: 0x040073E9 RID: 29673
			[Token(Token = "0x40073E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
			public bool isOverrideBGM;

			// Token: 0x040073EA RID: 29674
			[Token(Token = "0x40073EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
			public FastBattleInfo fastBattleInfo;

			// Token: 0x040073EB RID: 29675
			[Token(Token = "0x40073EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
			public GameTagMeta gameTagMeta;

			// Token: 0x040073EC RID: 29676
			[Token(Token = "0x40073EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
			public DisplayMeta displayMeta;

			// Token: 0x040073ED RID: 29677
			[Token(Token = "0x40073ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
			public List<string> sixStarRuneIds;
		}

		// Token: 0x02001407 RID: 5127
		[Token(Token = "0x2001407")]
		public struct BattleStartOption
		{
			// Token: 0x040073EE RID: 29678
			[Token(Token = "0x40073EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SquadItemStruct[] squadSlots;

			// Token: 0x040073EF RID: 29679
			[Token(Token = "0x40073EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public SharedCharData assistCharData;

			// Token: 0x040073F0 RID: 29680
			[Token(Token = "0x40073F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LevelData levelData;

			// Token: 0x040073F1 RID: 29681
			[Token(Token = "0x40073F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LevelData.Difficulty difficulty;

			// Token: 0x040073F2 RID: 29682
			[Token(Token = "0x40073F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool isMemory;

			// Token: 0x040073F3 RID: 29683
			[Token(Token = "0x40073F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<BattleLogger.CharInfo> squad;

			// Token: 0x040073F4 RID: 29684
			[Token(Token = "0x40073F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isAutoBattle;

			// Token: 0x040073F5 RID: 29685
			[Token(Token = "0x40073F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool isSkillSelectablePredefined;

			// Token: 0x040073F6 RID: 29686
			[Token(Token = "0x40073F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
			public bool isPredefine;
		}

		// Token: 0x02001408 RID: 5128
		[Token(Token = "0x2001408")]
		public class Handler
		{
			// Token: 0x06007697 RID: 30359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007697")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Handler()
			{
			}

			// Token: 0x040073F7 RID: 29687
			[Token(Token = "0x40073F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action onProceed;

			// Token: 0x040073F8 RID: 29688
			[Token(Token = "0x40073F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action onBlock;
		}

		// Token: 0x02001409 RID: 5129
		[Token(Token = "0x2001409")]
		private struct Cache
		{
			// Token: 0x06007698 RID: 30360 RVA: 0x000350E8 File Offset: 0x000332E8
			[Token(Token = "0x6007698")]
			[Address(RVA = "0x1E424B0", Offset = "0x1E410B0", VA = "0x181E424B0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x040073F9 RID: 29689
			[Token(Token = "0x40073F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BattleStartController.Handler handler;

			// Token: 0x040073FA RID: 29690
			[Token(Token = "0x40073FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public BattleStartController.Param param;

			// Token: 0x040073FB RID: 29691
			[Token(Token = "0x40073FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
			public string seed;

			// Token: 0x040073FC RID: 29692
			[Token(Token = "0x40073FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
			public BattleStartController.IPlugin plugin;
		}
	}
}
