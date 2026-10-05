using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D44 RID: 27972
	[Token(Token = "0x2006D44")]
	[LuaCallCSharp(GenFlag.No)]
	public static class ActivityUtil
	{
		// Token: 0x06027DEE RID: 163310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DEE")]
		[Address(RVA = "0x22F6E30", Offset = "0x22F5A30", VA = "0x1822F6E30")]
		private static string _GenerateActLocalCacheKey(string activityId, string prefix, string id)
		{
			return null;
		}

		// Token: 0x06027DEF RID: 163311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DEF")]
		[Address(RVA = "0x22F6CB0", Offset = "0x22F58B0", VA = "0x1822F6CB0")]
		public static void SetFavorUpCharWatched(string actId, string charId)
		{
		}

		// Token: 0x06027DF0 RID: 163312 RVA: 0x000CFBB8 File Offset: 0x000CDDB8
		[Token(Token = "0x6027DF0")]
		[Address(RVA = "0x22F6F30", Offset = "0x22F5B30", VA = "0x1822F6F30")]
		public static bool isFavorUpCharWatched(string actId, string charId)
		{
			return default(bool);
		}

		// Token: 0x06027DF1 RID: 163313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DF1")]
		[Address(RVA = "0x22F6AC0", Offset = "0x22F56C0", VA = "0x1822F6AC0")]
		public static void DoShowGainedItems(List<RewardItemModel> items)
		{
		}

		// Token: 0x06027DF2 RID: 163314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DF2")]
		[Address(RVA = "0x22F6A40", Offset = "0x22F5640", VA = "0x1822F6A40")]
		public static void DoShowGainedItemsWithCallback(List<RewardItemModel> items, Action onAfterShowItems)
		{
		}

		// Token: 0x06027DF3 RID: 163315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DF3")]
		[Address(RVA = "0x22F68D0", Offset = "0x22F54D0", VA = "0x1822F68D0")]
		public static CommonTopMenu CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x06027DF4 RID: 163316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DF4")]
		[Address(RVA = "0x22F6B30", Offset = "0x22F5730", VA = "0x1822F6B30")]
		public static Sprite GetActivityKVImg(string actId, string kvId, int imgIndex)
		{
			return null;
		}

		// Token: 0x06027DF5 RID: 163317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DF5")]
		[Address(RVA = "0x22F6EA0", Offset = "0x22F5AA0", VA = "0x1822F6EA0")]
		private static IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, [Optional] Action onAfterShowItems)
		{
			return null;
		}

		// Token: 0x06027DF6 RID: 163318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DF6")]
		[Address(RVA = "0x22F6C30", Offset = "0x22F5830", VA = "0x1822F6C30")]
		public static void OpenActivityPage(string activityId, string actPageName, UIPageOption pageOption)
		{
		}

		// Token: 0x06027DF7 RID: 163319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DF7")]
		[Address(RVA = "0x22F6BE0", Offset = "0x22F57E0", VA = "0x1822F6BE0")]
		public static string GetActivityPageName(string activityId, string pageName)
		{
			return null;
		}

		// Token: 0x04038855 RID: 231509
		[Token(Token = "0x4038855")]
		public const string ACT_PARAM_IN_SAVEINST = "actId";

		// Token: 0x04038856 RID: 231510
		[Token(Token = "0x4038856")]
		public const string ACT_FROM_BATTLE_PARAM_IN_SAVEINST = "isFromBattle";

		// Token: 0x04038857 RID: 231511
		[Token(Token = "0x4038857")]
		public const string ACT_LOCAL_CACHE_PREFIX_WATCHED_FAVOR_UP_CHAR_ID = "watched_favor_up_char_id";

		// Token: 0x04038858 RID: 231512
		[Token(Token = "0x4038858")]
		public const float MISSION_REP_ITEM_TWEEN_DUR = 1.35f;
	}
}
