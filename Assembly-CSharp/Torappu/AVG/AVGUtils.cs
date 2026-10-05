using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E5E RID: 7774
	[Token(Token = "0x2001E5E")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class AVGUtils
	{
		// Token: 0x0600C0C8 RID: 49352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0C8")]
		[Address(RVA = "0x33E4560", Offset = "0x33E3160", VA = "0x1833E4560")]
		public static void SwapUnderSameParent(Transform lhs, Transform rhs)
		{
		}

		// Token: 0x0600C0C9 RID: 49353 RVA: 0x00046C50 File Offset: 0x00044E50
		[Token(Token = "0x600C0C9")]
		[Address(RVA = "0x33E47B0", Offset = "0x33E33B0", VA = "0x1833E47B0")]
		public static bool TrigCustomOperation(string operation)
		{
			return default(bool);
		}

		// Token: 0x0600C0CA RID: 49354 RVA: 0x00046C68 File Offset: 0x00044E68
		[Token(Token = "0x600C0CA")]
		[Address(RVA = "0x33E49D0", Offset = "0x33E35D0", VA = "0x1833E49D0")]
		public static bool TrigCustomOperation(string operation, Action<Story> onCompleted)
		{
			return default(bool);
		}

		// Token: 0x0600C0CB RID: 49355 RVA: 0x00046C80 File Offset: 0x00044E80
		[Token(Token = "0x600C0CB")]
		[Address(RVA = "0x33E59D0", Offset = "0x33E45D0", VA = "0x1833E59D0")]
		public static bool TriggerCustomOperation(string operation, Action<Story> onCompleted, Story.StoryParam param)
		{
			return default(bool);
		}

		// Token: 0x0600C0CC RID: 49356 RVA: 0x00046C98 File Offset: 0x00044E98
		[Token(Token = "0x600C0CC")]
		[Address(RVA = "0x33E3910", Offset = "0x33E2510", VA = "0x1833E3910")]
		public static bool FetchCustomOperationStory(string operation, out StoryData storyData)
		{
			return default(bool);
		}

		// Token: 0x0600C0CD RID: 49357 RVA: 0x00046CB0 File Offset: 0x00044EB0
		[Token(Token = "0x600C0CD")]
		[Address(RVA = "0x33E4CA0", Offset = "0x33E38A0", VA = "0x1833E4CA0")]
		public static bool TrigFirstStoryOnPageLoaded(AVGPageKey avgPage, bool forceRepeatableAndOmitCommit = false)
		{
			return default(bool);
		}

		// Token: 0x0600C0CE RID: 49358 RVA: 0x00046CC8 File Offset: 0x00044EC8
		[Token(Token = "0x600C0CE")]
		[Address(RVA = "0x33E4BA0", Offset = "0x33E37A0", VA = "0x1833E4BA0")]
		public static bool TrigFirstStoryOnActivityLoaded(string activityId, [Optional] Action<Story> onCompleted)
		{
			return default(bool);
		}

		// Token: 0x0600C0CF RID: 49359 RVA: 0x00046CE0 File Offset: 0x00044EE0
		[Token(Token = "0x600C0CF")]
		[Address(RVA = "0x33E4D90", Offset = "0x33E3990", VA = "0x1833E4D90")]
		public static bool TrigFirstVideoStoryOnActivityLoaded(string activityId, [Optional] Action<Story> onCompleted, bool forceRepeatable = false)
		{
			return default(bool);
		}

		// Token: 0x0600C0D0 RID: 49360 RVA: 0x00046CF8 File Offset: 0x00044EF8
		[Token(Token = "0x600C0D0")]
		[Address(RVA = "0x33E5770", Offset = "0x33E4370", VA = "0x1833E5770")]
		public static bool TriggerCustomOperationWithResCheck(string triggerKey, [Optional] Action<Story> onCompleted, bool forceRepeatable = false)
		{
			return default(bool);
		}

		// Token: 0x0600C0D1 RID: 49361 RVA: 0x00046D10 File Offset: 0x00044F10
		[Token(Token = "0x600C0D1")]
		[Address(RVA = "0x33E4FF0", Offset = "0x33E3BF0", VA = "0x1833E4FF0")]
		public static bool TrigHandBookAvg(string storyId, GameFlowController.Options returnOptions)
		{
			return default(bool);
		}

		// Token: 0x0600C0D2 RID: 49362 RVA: 0x00046D28 File Offset: 0x00044F28
		[Token(Token = "0x600C0D2")]
		[Address(RVA = "0x33E46B0", Offset = "0x33E32B0", VA = "0x1833E46B0")]
		public static bool TrigCrisisSeasonLoaded(string seasonId, [Optional] Action<Story> onCompleted)
		{
			return default(bool);
		}

		// Token: 0x0600C0D3 RID: 49363 RVA: 0x00046D40 File Offset: 0x00044F40
		[Token(Token = "0x600C0D3")]
		[Address(RVA = "0x33E5250", Offset = "0x33E3E50", VA = "0x1833E5250")]
		public static bool TrigRoguelikeTopicLoaded(string trigger, [Optional] Action<Story> onCompleted)
		{
			return default(bool);
		}

		// Token: 0x0600C0D4 RID: 49364 RVA: 0x00046D58 File Offset: 0x00044F58
		[Token(Token = "0x600C0D4")]
		[Address(RVA = "0x33E55A0", Offset = "0x33E41A0", VA = "0x1833E55A0")]
		public static bool TrigStoryInStandaloneScene(StoryData storyToTrig, GameFlowController.Options returnOptions)
		{
			return default(bool);
		}

		// Token: 0x0600C0D5 RID: 49365 RVA: 0x00046D70 File Offset: 0x00044F70
		[Token(Token = "0x600C0D5")]
		[Address(RVA = "0x33E5350", Offset = "0x33E3F50", VA = "0x1833E5350")]
		public static bool TrigStoryInStandaloneSceneWithResCheck(StoryData storyToTrig, GameFlowController.Options returnOptions, bool forceRepeatable = false)
		{
			return default(bool);
		}

		// Token: 0x0600C0D6 RID: 49366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0D6")]
		[Address(RVA = "0x33E6320", Offset = "0x33E4F20", VA = "0x1833E6320")]
		private static void _StartStoryWithoutParam(string storyId, [Optional] Action<Story> onStoryEnd)
		{
		}

		// Token: 0x0600C0D7 RID: 49367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0D7")]
		[Address(RVA = "0x33E61B0", Offset = "0x33E4DB0", VA = "0x1833E61B0")]
		private static void _StartStoryWithParam(string storyId, Action<Story> onStoryEnd, Story.StoryParam param)
		{
		}

		// Token: 0x0600C0D8 RID: 49368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0D8")]
		[Address(RVA = "0x33E60A0", Offset = "0x33E4CA0", VA = "0x1833E60A0")]
		private static void _StartStoryInternal(string storyId, Action<Story> onStoryEnd, Story.StoryParam param)
		{
		}

		// Token: 0x0600C0D9 RID: 49369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0D9")]
		[Address(RVA = "0x33E39F0", Offset = "0x33E25F0", VA = "0x1833E39F0")]
		public static void FinishStoryAndCommit(string storyId)
		{
		}

		// Token: 0x0600C0DA RID: 49370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0DA")]
		[Address(RVA = "0x33E3A80", Offset = "0x33E2680", VA = "0x1833E3A80")]
		public static void FinishStoryAndCommit(string storyId, Action<Story.StoryOutPut> proceedCallBack)
		{
		}

		// Token: 0x0600C0DB RID: 49371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0DB")]
		[Address(RVA = "0x33E37D0", Offset = "0x33E23D0", VA = "0x1833E37D0")]
		public static void FetchBattleStory(string stageId, out StoryData before, out StoryData after, bool forceRepeatableAndOmitCommitAndStageCond = true)
		{
		}

		// Token: 0x0600C0DC RID: 49372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0DC")]
		[Address(RVA = "0x33E36A0", Offset = "0x33E22A0", VA = "0x1833E36A0")]
		public static void FetchActivityAnnounceStory(string activityId, out string storyId)
		{
		}

		// Token: 0x0600C0DD RID: 49373 RVA: 0x00046D88 File Offset: 0x00044F88
		[Token(Token = "0x600C0DD")]
		[Address(RVA = "0x33E2D90", Offset = "0x33E1990", VA = "0x1833E2D90")]
		public static bool CheckFirstRead(string storyID)
		{
			return default(bool);
		}

		// Token: 0x0600C0DE RID: 49374 RVA: 0x00046DA0 File Offset: 0x00044FA0
		[Token(Token = "0x600C0DE")]
		[Address(RVA = "0x33E2CB0", Offset = "0x33E18B0", VA = "0x1833E2CB0")]
		public static bool CheckFirstReadByCustomOperation(string operation)
		{
			return default(bool);
		}

		// Token: 0x0600C0DF RID: 49375 RVA: 0x00046DB8 File Offset: 0x00044FB8
		[Token(Token = "0x600C0DF")]
		[Address(RVA = "0x33E2F90", Offset = "0x33E1B90", VA = "0x1833E2F90")]
		public static bool CheckMarkStoryAcceKnown()
		{
			return default(bool);
		}

		// Token: 0x0600C0E0 RID: 49376 RVA: 0x00046DD0 File Offset: 0x00044FD0
		[Token(Token = "0x600C0E0")]
		[Address(RVA = "0x33E2C20", Offset = "0x33E1820", VA = "0x1833E2C20")]
		public static bool CanQuickPlay(Story story)
		{
			return default(bool);
		}

		// Token: 0x0600C0E1 RID: 49377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C0E1")]
		[Address(RVA = "0x33E4260", Offset = "0x33E2E60", VA = "0x1833E4260")]
		public static string GetStoryIDFromPath(string path)
		{
			return null;
		}

		// Token: 0x0600C0E2 RID: 49378 RVA: 0x00046DE8 File Offset: 0x00044FE8
		[Token(Token = "0x600C0E2")]
		[Address(RVA = "0x33E2ED0", Offset = "0x33E1AD0", VA = "0x1833E2ED0")]
		public static bool CheckImageSrcInAtlas(Sprite imgSrc, out string errorInfo)
		{
			return default(bool);
		}

		// Token: 0x0600C0E3 RID: 49379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C0E3")]
		[Address(RVA = "0x33E3ED0", Offset = "0x33E2AD0", VA = "0x1833E3ED0")]
		public static Command GenerateEndtipCommand()
		{
			return null;
		}

		// Token: 0x0600C0E4 RID: 49380 RVA: 0x00046E00 File Offset: 0x00045000
		[Token(Token = "0x600C0E4")]
		[Address(RVA = "0x33E43D0", Offset = "0x33E2FD0", VA = "0x1833E43D0")]
		public static bool NeedSkipAnimation(float fadetime)
		{
			return default(bool);
		}

		// Token: 0x0600C0E5 RID: 49381 RVA: 0x00046E18 File Offset: 0x00045018
		[Token(Token = "0x600C0E5")]
		[Address(RVA = "0x33E2B70", Offset = "0x33E1770", VA = "0x1833E2B70")]
		public static float CalculateFadetime(float initialFadetime)
		{
			return 0f;
		}

		// Token: 0x0600C0E6 RID: 49382 RVA: 0x00046E30 File Offset: 0x00045030
		[Token(Token = "0x600C0E6")]
		[Address(RVA = "0x33E4480", Offset = "0x33E3080", VA = "0x1833E4480")]
		public static bool NeedSkipEffectFade()
		{
			return default(bool);
		}

		// Token: 0x0600C0E7 RID: 49383 RVA: 0x00046E48 File Offset: 0x00045048
		[Token(Token = "0x600C0E7")]
		[Address(RVA = "0x33E3D80", Offset = "0x33E2980", VA = "0x1833E3D80")]
		public static Color GenColorByRaw(string rawColor)
		{
			return default(Color);
		}

		// Token: 0x0600C0E8 RID: 49384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C0E8")]
		[Address(RVA = "0x33E3110", Offset = "0x33E1D10", VA = "0x1833E3110")]
		public static string Color2Str(Color color)
		{
			return null;
		}

		// Token: 0x0600C0E9 RID: 49385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C0E9")]
		[Address(RVA = "0x33E5B20", Offset = "0x33E4720", VA = "0x1833E5B20")]
		public static string Vector2Str(Vector2 vec)
		{
			return null;
		}

		// Token: 0x0600C0EA RID: 49386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C0EA")]
		[Address(RVA = "0x33E3390", Offset = "0x33E1F90", VA = "0x1833E3390")]
		public static Tweener CreateRotateTween(RectTransform rectTransform, float endAngle, float duration, bool counterClockwise = false, int circles = 0)
		{
			return null;
		}

		// Token: 0x0600C0EB RID: 49387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C0EB")]
		[Address(RVA = "0x33E3610", Offset = "0x33E2210", VA = "0x1833E3610")]
		public static AVGShaderProfile EnsureShaderProfile()
		{
			return null;
		}

		// Token: 0x0600C0EC RID: 49388 RVA: 0x00046E60 File Offset: 0x00045060
		[Token(Token = "0x600C0EC")]
		[Address(RVA = "0x33E40B0", Offset = "0x33E2CB0", VA = "0x1833E40B0")]
		public static Vector2 GetAdaptScreen(string screenAdaptMode, Vector2 target, Vector2 reference)
		{
			return default(Vector2);
		}

		// Token: 0x0600C0ED RID: 49389 RVA: 0x00046E78 File Offset: 0x00045078
		[Token(Token = "0x600C0ED")]
		[Address(RVA = "0x33E5FD0", Offset = "0x33E4BD0", VA = "0x1833E5FD0")]
		private static Vector2 _AdaptScreenWidth(Vector2 target, Vector2 reference)
		{
			return default(Vector2);
		}

		// Token: 0x0600C0EE RID: 49390 RVA: 0x00046E90 File Offset: 0x00045090
		[Token(Token = "0x600C0EE")]
		[Address(RVA = "0x33E5E00", Offset = "0x33E4A00", VA = "0x1833E5E00")]
		private static Vector2 _AdaptScreenHeight(Vector2 target, Vector2 reference)
		{
			return default(Vector2);
		}

		// Token: 0x0600C0EF RID: 49391 RVA: 0x00046EA8 File Offset: 0x000450A8
		[Token(Token = "0x600C0EF")]
		[Address(RVA = "0x33E5EC0", Offset = "0x33E4AC0", VA = "0x1833E5EC0")]
		private static Vector2 _AdaptScreenShowAll(Vector2 target, Vector2 reference)
		{
			return default(Vector2);
		}

		// Token: 0x0600C0F0 RID: 49392 RVA: 0x00046EC0 File Offset: 0x000450C0
		[Token(Token = "0x600C0F0")]
		[Address(RVA = "0x33E5C20", Offset = "0x33E4820", VA = "0x1833E5C20")]
		private static Vector2 _AdaptScreenCoverAll(Vector2 target, Vector2 reference)
		{
			return default(Vector2);
		}

		// Token: 0x0600C0F1 RID: 49393 RVA: 0x00046ED8 File Offset: 0x000450D8
		[Token(Token = "0x600C0F1")]
		[Address(RVA = "0x33E5D50", Offset = "0x33E4950", VA = "0x1833E5D50")]
		private static Vector2 _AdaptScreenFill(Vector2 target, Vector2 reference)
		{
			return default(Vector2);
		}

		// Token: 0x0400C241 RID: 49729
		[Token(Token = "0x400C241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, Func<Vector2, Vector2, Vector2>> SCREEN_ADAPT_FUNCTION_MAP;

		// Token: 0x0400C242 RID: 49730
		[Token(Token = "0x400C242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SwapUnderSameParent;

		// Token: 0x0400C243 RID: 49731
		[Token(Token = "0x400C243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TrigCustomOperation;

		// Token: 0x0400C244 RID: 49732
		[Token(Token = "0x400C244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_TrigCustomOperation;

		// Token: 0x0400C245 RID: 49733
		[Token(Token = "0x400C245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TriggerCustomOperation;

		// Token: 0x0400C246 RID: 49734
		[Token(Token = "0x400C246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FetchCustomOperationStory;

		// Token: 0x0400C247 RID: 49735
		[Token(Token = "0x400C247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TrigFirstStoryOnPageLoaded;

		// Token: 0x0400C248 RID: 49736
		[Token(Token = "0x400C248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TrigFirstStoryOnActivityLoaded;

		// Token: 0x0400C249 RID: 49737
		[Token(Token = "0x400C249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TrigFirstVideoStoryOnActivityLoaded;

		// Token: 0x0400C24A RID: 49738
		[Token(Token = "0x400C24A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TriggerCustomOperationWithResCheck;

		// Token: 0x0400C24B RID: 49739
		[Token(Token = "0x400C24B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TrigHandBookAvg;

		// Token: 0x0400C24C RID: 49740
		[Token(Token = "0x400C24C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TrigCrisisSeasonLoaded;

		// Token: 0x0400C24D RID: 49741
		[Token(Token = "0x400C24D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TrigRoguelikeTopicLoaded;

		// Token: 0x0400C24E RID: 49742
		[Token(Token = "0x400C24E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TrigStoryInStandaloneScene;

		// Token: 0x0400C24F RID: 49743
		[Token(Token = "0x400C24F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_TrigStoryInStandaloneSceneWithResCheck;

		// Token: 0x0400C250 RID: 49744
		[Token(Token = "0x400C250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__StartStoryWithoutParam;

		// Token: 0x0400C251 RID: 49745
		[Token(Token = "0x400C251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__StartStoryWithParam;

		// Token: 0x0400C252 RID: 49746
		[Token(Token = "0x400C252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__StartStoryInternal;

		// Token: 0x0400C253 RID: 49747
		[Token(Token = "0x400C253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_FinishStoryAndCommit;

		// Token: 0x0400C254 RID: 49748
		[Token(Token = "0x400C254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix1_FinishStoryAndCommit;

		// Token: 0x0400C255 RID: 49749
		[Token(Token = "0x400C255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_FetchBattleStory;

		// Token: 0x0400C256 RID: 49750
		[Token(Token = "0x400C256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_FetchActivityAnnounceStory;

		// Token: 0x0400C257 RID: 49751
		[Token(Token = "0x400C257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CheckFirstRead;

		// Token: 0x0400C258 RID: 49752
		[Token(Token = "0x400C258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CheckFirstReadByCustomOperation;

		// Token: 0x0400C259 RID: 49753
		[Token(Token = "0x400C259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CheckMarkStoryAcceKnown;

		// Token: 0x0400C25A RID: 49754
		[Token(Token = "0x400C25A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CanQuickPlay;

		// Token: 0x0400C25B RID: 49755
		[Token(Token = "0x400C25B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetStoryIDFromPath;

		// Token: 0x0400C25C RID: 49756
		[Token(Token = "0x400C25C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CheckImageSrcInAtlas;

		// Token: 0x0400C25D RID: 49757
		[Token(Token = "0x400C25D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GenerateEndtipCommand;

		// Token: 0x0400C25E RID: 49758
		[Token(Token = "0x400C25E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_NeedSkipAnimation;

		// Token: 0x0400C25F RID: 49759
		[Token(Token = "0x400C25F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CalculateFadetime;

		// Token: 0x0400C260 RID: 49760
		[Token(Token = "0x400C260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_NeedSkipEffectFade;

		// Token: 0x0400C261 RID: 49761
		[Token(Token = "0x400C261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GenColorByRaw;

		// Token: 0x0400C262 RID: 49762
		[Token(Token = "0x400C262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_Color2Str;

		// Token: 0x0400C263 RID: 49763
		[Token(Token = "0x400C263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_Vector2Str;

		// Token: 0x0400C264 RID: 49764
		[Token(Token = "0x400C264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CreateRotateTween;

		// Token: 0x0400C265 RID: 49765
		[Token(Token = "0x400C265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_EnsureShaderProfile;

		// Token: 0x0400C266 RID: 49766
		[Token(Token = "0x400C266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_GetAdaptScreen;

		// Token: 0x0400C267 RID: 49767
		[Token(Token = "0x400C267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__AdaptScreenWidth;

		// Token: 0x0400C268 RID: 49768
		[Token(Token = "0x400C268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__AdaptScreenHeight;

		// Token: 0x0400C269 RID: 49769
		[Token(Token = "0x400C269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__AdaptScreenShowAll;

		// Token: 0x0400C26A RID: 49770
		[Token(Token = "0x400C26A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__AdaptScreenCoverAll;

		// Token: 0x0400C26B RID: 49771
		[Token(Token = "0x400C26B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__AdaptScreenFill;
	}
}
