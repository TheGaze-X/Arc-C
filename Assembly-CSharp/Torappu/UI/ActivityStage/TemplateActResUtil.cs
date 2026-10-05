using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CBC RID: 27836
	[Token(Token = "0x2006CBC")]
	public class TemplateActResUtil : IHotfixable
	{
		// Token: 0x17005DCB RID: 24011
		// (get) Token: 0x06027B79 RID: 162681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DCB")]
		public static StateEngine floatStateEngine
		{
			[Token(Token = "0x6027B79")]
			[Address(RVA = "0x22D5FC0", Offset = "0x22D4BC0", VA = "0x1822D5FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027B7A RID: 162682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B7A")]
		[Address(RVA = "0x22D5C00", Offset = "0x22D4800", VA = "0x1822D5C00")]
		public static void SetFavorUpCharWatched(string actId, string charId)
		{
		}

		// Token: 0x06027B7B RID: 162683 RVA: 0x000CF210 File Offset: 0x000CD410
		[Token(Token = "0x6027B7B")]
		[Address(RVA = "0x22D5AD0", Offset = "0x22D46D0", VA = "0x1822D5AD0")]
		public static bool IsFavorUpCharWatched(string actId, string charId)
		{
			return default(bool);
		}

		// Token: 0x06027B7C RID: 162684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B7C")]
		[Address(RVA = "0x22D5E30", Offset = "0x22D4A30", VA = "0x1822D5E30")]
		public static void SetZoneAccessed(string actId, string zoneId)
		{
		}

		// Token: 0x06027B7D RID: 162685 RVA: 0x000CF228 File Offset: 0x000CD428
		[Token(Token = "0x6027B7D")]
		[Address(RVA = "0x22D6080", Offset = "0x22D4C80", VA = "0x1822D6080")]
		public static bool isZoneAccessed(string actId, string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06027B7E RID: 162686 RVA: 0x000CF240 File Offset: 0x000CD440
		[Token(Token = "0x6027B7E")]
		[Address(RVA = "0x22D5B70", Offset = "0x22D4770", VA = "0x1822D5B70")]
		public static bool IsStageAccessed(string activityId, string stageId)
		{
			return default(bool);
		}

		// Token: 0x06027B7F RID: 162687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B7F")]
		[Address(RVA = "0x22D5C90", Offset = "0x22D4890", VA = "0x1822D5C90")]
		public static void SetStageAccessed(string activityId, List<string> stageIdList)
		{
		}

		// Token: 0x06027B80 RID: 162688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027B80")]
		[Address(RVA = "0x22D5740", Offset = "0x22D4340", VA = "0x1822D5740")]
		public static Sprite GetAct9D0NewsContentImg(string actId, string newsPic)
		{
			return null;
		}

		// Token: 0x06027B81 RID: 162689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027B81")]
		[Address(RVA = "0x22D58F0", Offset = "0x22D44F0", VA = "0x1822D58F0")]
		public static Sprite GetAct9D0NewsTitleImg(string actId, string titlePic)
		{
			return null;
		}

		// Token: 0x06027B82 RID: 162690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027B82")]
		[Address(RVA = "0x22D57D0", Offset = "0x22D43D0", VA = "0x1822D57D0")]
		public static Sprite GetAct9D0NewsLogoImg(string actId, string logoPic)
		{
			return null;
		}

		// Token: 0x06027B83 RID: 162691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027B83")]
		[Address(RVA = "0x22D5860", Offset = "0x22D4460", VA = "0x1822D5860")]
		public static Sprite GetAct9D0NewsLogoLargeImg(string actId, string logoPic)
		{
			return null;
		}

		// Token: 0x06027B84 RID: 162692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027B84")]
		[Address(RVA = "0x22D5EC0", Offset = "0x22D4AC0", VA = "0x1822D5EC0")]
		private static string _GenerateActLocalCacheKey(string actId, string prefix, string id)
		{
			return null;
		}

		// Token: 0x06027B85 RID: 162693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027B85")]
		[Address(RVA = "0x22D5980", Offset = "0x22D4580", VA = "0x1822D5980")]
		public static MissionData GetMissionData(string missionID, string activityID)
		{
			return null;
		}

		// Token: 0x06027B86 RID: 162694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027B86")]
		[Address(RVA = "0x22D55F0", Offset = "0x22D41F0", VA = "0x1822D55F0")]
		public static CommonTopMenu CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x06027B87 RID: 162695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B87")]
		[Address(RVA = "0x22D5F60", Offset = "0x22D4B60", VA = "0x1822D5F60")]
		public TemplateActResUtil()
		{
		}

		// Token: 0x04038505 RID: 230661
		[Token(Token = "0x4038505")]
		public const string ACT_LOCAL_CACHE_PREFIX_WATCHED_FAVOR_UP_CHAR_ID = "watched_favor_up_char_id";

		// Token: 0x04038506 RID: 230662
		[Token(Token = "0x4038506")]
		public const string ACT_LOCAL_CACHE_PREFIX_ACCESSED_ZONE_ID = "accessed_zone_id";

		// Token: 0x04038507 RID: 230663
		[Token(Token = "0x4038507")]
		public const string ACT_LOCAL_CACHE_PREFIX_ACCESSED_STAGE_ID = "accessed_stage_id";

		// Token: 0x04038508 RID: 230664
		[Token(Token = "0x4038508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_floatStateEngine;

		// Token: 0x04038509 RID: 230665
		[Token(Token = "0x4038509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetFavorUpCharWatched;

		// Token: 0x0403850A RID: 230666
		[Token(Token = "0x403850A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsFavorUpCharWatched;

		// Token: 0x0403850B RID: 230667
		[Token(Token = "0x403850B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetZoneAccessed;

		// Token: 0x0403850C RID: 230668
		[Token(Token = "0x403850C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_isZoneAccessed;

		// Token: 0x0403850D RID: 230669
		[Token(Token = "0x403850D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsStageAccessed;

		// Token: 0x0403850E RID: 230670
		[Token(Token = "0x403850E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetStageAccessed;

		// Token: 0x0403850F RID: 230671
		[Token(Token = "0x403850F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetAct9D0NewsContentImg;

		// Token: 0x04038510 RID: 230672
		[Token(Token = "0x4038510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetAct9D0NewsTitleImg;

		// Token: 0x04038511 RID: 230673
		[Token(Token = "0x4038511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetAct9D0NewsLogoImg;

		// Token: 0x04038512 RID: 230674
		[Token(Token = "0x4038512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetAct9D0NewsLogoLargeImg;

		// Token: 0x04038513 RID: 230675
		[Token(Token = "0x4038513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GenerateActLocalCacheKey;

		// Token: 0x04038514 RID: 230676
		[Token(Token = "0x4038514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetMissionData;

		// Token: 0x04038515 RID: 230677
		[Token(Token = "0x4038515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x04038516 RID: 230678
		[Token(Token = "0x4038516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
