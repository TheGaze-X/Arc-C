using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.SandboxPerm.SandboxV2;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B59 RID: 15193
	[Token(Token = "0x2003B59")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2TrackTriggerUtil
	{
		// Token: 0x06017D80 RID: 97664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D80")]
		[Address(RVA = "0x1019DD0", Offset = "0x10189D0", VA = "0x181019DD0")]
		public static void HandlePushMessage(SandboxV2TrackPushMsg pushMsg)
		{
		}

		// Token: 0x06017D81 RID: 97665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D81")]
		[Address(RVA = "0x101A160", Offset = "0x1018D60", VA = "0x18101A160")]
		private static string _GenerateSandboxV2InGameTrackPrefix(string topicId)
		{
			return null;
		}

		// Token: 0x06017D82 RID: 97666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D82")]
		[Address(RVA = "0x1019790", Offset = "0x1018390", VA = "0x181019790")]
		public static string GenerateRiftDiffNewUnlockTrackId(string topicId)
		{
			return null;
		}

		// Token: 0x06017D83 RID: 97667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D83")]
		[Address(RVA = "0x10196D0", Offset = "0x10182D0", VA = "0x1810196D0")]
		public static string GenerateRiftDiffLvNewUnlockTrackId(string topicId, string difficultyLvStr)
		{
			return null;
		}

		// Token: 0x06017D84 RID: 97668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D84")]
		[Address(RVA = "0x1019830", Offset = "0x1018430", VA = "0x181019830")]
		public static string GenerateShopInBarTrackId(string topicId)
		{
			return null;
		}

		// Token: 0x06017D85 RID: 97669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D85")]
		[Address(RVA = "0x1019970", Offset = "0x1018570", VA = "0x181019970")]
		public static string GenerateSupplyInCrossDayTrackId(string topicId)
		{
			return null;
		}

		// Token: 0x06017D86 RID: 97670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D86")]
		[Address(RVA = "0x10198D0", Offset = "0x10184D0", VA = "0x1810198D0")]
		public static string GenerateSupplyInBarTrackId(string topicId)
		{
			return null;
		}

		// Token: 0x06017D87 RID: 97671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D87")]
		[Address(RVA = "0x1019B90", Offset = "0x1018790", VA = "0x181019B90")]
		public static string GenerateWorkbenchInBarTrackId(string topicId)
		{
			return null;
		}

		// Token: 0x06017D88 RID: 97672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D88")]
		[Address(RVA = "0x1019C30", Offset = "0x1018830", VA = "0x181019C30")]
		public static string GenerateWorkbenchInTabTrackId(string topicId, SandboxV2AdminMainWorkbenchType workbenchType)
		{
			return null;
		}

		// Token: 0x06017D89 RID: 97673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D89")]
		[Address(RVA = "0x1019D10", Offset = "0x1018910", VA = "0x181019D10")]
		public static string GenerateWorkbenchItemTrackId(string topicId, string itemId)
		{
			return null;
		}

		// Token: 0x06017D8A RID: 97674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D8A")]
		[Address(RVA = "0x10194D0", Offset = "0x10180D0", VA = "0x1810194D0")]
		public static string GenerateCookInBarTrackId(string topicId)
		{
			return null;
		}

		// Token: 0x06017D8B RID: 97675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D8B")]
		[Address(RVA = "0x1019570", Offset = "0x1018170", VA = "0x181019570")]
		public static string GenerateCookInRecipeTabTrackId(string topicId)
		{
			return null;
		}

		// Token: 0x06017D8C RID: 97676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D8C")]
		[Address(RVA = "0x1019610", Offset = "0x1018210", VA = "0x181019610")]
		public static string GenerateCookRecipeItemTrackId(string topicId, string itemId)
		{
			return null;
		}

		// Token: 0x06017D8D RID: 97677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D8D")]
		[Address(RVA = "0x1019A10", Offset = "0x1018610", VA = "0x181019A10")]
		public static string GenerateTechInBarTrackId(string topicId)
		{
			return null;
		}

		// Token: 0x06017D8E RID: 97678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D8E")]
		[Address(RVA = "0x1019AB0", Offset = "0x10186B0", VA = "0x181019AB0")]
		public static string GenerateTechInTabTrackId(string topicId, SandboxV2DevelopmentType developmentType)
		{
			return null;
		}

		// Token: 0x06017D8F RID: 97679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D8F")]
		[Address(RVA = "0x101AC30", Offset = "0x1019830", VA = "0x18101AC30")]
		private static void _TriggerRiftUnlockNewDifficultyLvTrack(string topicId, List<string> extraInfos)
		{
		}

		// Token: 0x06017D90 RID: 97680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D90")]
		[Address(RVA = "0x101AED0", Offset = "0x1019AD0", VA = "0x18101AED0")]
		private static void _TriggerShopInBarTrack(string topicId)
		{
		}

		// Token: 0x06017D91 RID: 97681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D91")]
		[Address(RVA = "0x101B030", Offset = "0x1019C30", VA = "0x18101B030")]
		private static void _TriggerSupplyTrack(string topicId)
		{
		}

		// Token: 0x06017D92 RID: 97682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D92")]
		[Address(RVA = "0x101AFC0", Offset = "0x1019BC0", VA = "0x18101AFC0")]
		private static void _TriggerSupplyNewBlockTrack(string topicId)
		{
		}

		// Token: 0x06017D93 RID: 97683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D93")]
		[Address(RVA = "0x101B230", Offset = "0x1019E30", VA = "0x18101B230")]
		private static void _TriggerWorkbenchNewItemOrRecipeTrack(string topicId, List<string> extraInfos)
		{
		}

		// Token: 0x06017D94 RID: 97684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D94")]
		[Address(RVA = "0x101A900", Offset = "0x1019500", VA = "0x18101A900")]
		private static void _TriggerCookNewRecipeTrack(string topicId, List<string> extraInfos)
		{
		}

		// Token: 0x06017D95 RID: 97685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D95")]
		[Address(RVA = "0x101B140", Offset = "0x1019D40", VA = "0x18101B140")]
		private static void _TriggerTechNewNodeTrack(string topicId)
		{
		}

		// Token: 0x06017D96 RID: 97686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D96")]
		[Address(RVA = "0x101A6F0", Offset = "0x10192F0", VA = "0x18101A6F0")]
		private static void _TriggerArchiveQuestUnlock(string topicId, List<string> extraInfos)
		{
		}

		// Token: 0x06017D97 RID: 97687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D97")]
		[Address(RVA = "0x101A280", Offset = "0x1018E80", VA = "0x18101A280")]
		private static List<string> _GetSandboxV2ArchiveQuestItemIdList(string topicId, string questId)
		{
			return null;
		}

		// Token: 0x06017D98 RID: 97688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D98")]
		[Address(RVA = "0x101A560", Offset = "0x1019160", VA = "0x18101A560")]
		private static void _TriggerArchiveMusicUnlock(string topicId, List<string> extraInfos)
		{
		}

		// Token: 0x06017D99 RID: 97689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017D99")]
		[Address(RVA = "0x101A4F0", Offset = "0x10190F0", VA = "0x18101A4F0")]
		private static string _GetSandboxV2TrackType(string topicId)
		{
			return null;
		}

		// Token: 0x06017D9A RID: 97690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D9A")]
		[Address(RVA = "0x101A050", Offset = "0x1018C50", VA = "0x18101A050")]
		private static void _DoTrack(string topicId, string trackId)
		{
		}

		// Token: 0x0401CCD3 RID: 117971
		[Token(Token = "0x401CCD3")]
		private const string TRACK_ID_PREFIX = "ts{0}_{1}_{2}";

		// Token: 0x0401CCD4 RID: 117972
		[Token(Token = "0x401CCD4")]
		private const string KEY_TRACK_RIFT_NEW_DIFF_UNLOCK = "rift_new_diff_unlock";

		// Token: 0x0401CCD5 RID: 117973
		[Token(Token = "0x401CCD5")]
		private const string KEY_TRACK_RIFT_NEW_DIFF_LV_UNLOCK = "rift_new_diff_lv_unlock_{0}";

		// Token: 0x0401CCD6 RID: 117974
		[Token(Token = "0x401CCD6")]
		private const string KEY_TRACK_SHOP_IN_BAR = "shop_in_bar";

		// Token: 0x0401CCD7 RID: 117975
		[Token(Token = "0x401CCD7")]
		private const string KEY_TRACK_SUPPLY_UNLOCK_IN_BAR = "supply_unlock_in_bar";

		// Token: 0x0401CCD8 RID: 117976
		[Token(Token = "0x401CCD8")]
		private const string KEY_TRACK_SUPPLY_UNLOCK_IN_CROSS_DAY = "supply_unlock_in_cross_day";

		// Token: 0x0401CCD9 RID: 117977
		[Token(Token = "0x401CCD9")]
		private const string KEY_TRACK_WORKBENCH_IN_BAR = "workbench_in_bar";

		// Token: 0x0401CCDA RID: 117978
		[Token(Token = "0x401CCDA")]
		private const string KEY_TRACK_WORKBENCH_IN_TAB = "workbench_in_tab_{0}";

		// Token: 0x0401CCDB RID: 117979
		[Token(Token = "0x401CCDB")]
		private const string KEY_TRACK_WORKBENCH_NEW_ITEM = "workbench_new_item_{0}";

		// Token: 0x0401CCDC RID: 117980
		[Token(Token = "0x401CCDC")]
		private const string KEY_TRACK_COOK_NEW_RECIPE_IN_BAR = "cook_new_recipe_in_bar";

		// Token: 0x0401CCDD RID: 117981
		[Token(Token = "0x401CCDD")]
		private const string KEY_TRACK_COOK_NEW_RECIPE_IN_TAB = "cook_new_recipe_in_tab";

		// Token: 0x0401CCDE RID: 117982
		[Token(Token = "0x401CCDE")]
		private const string KEY_TRACK_COOK_NEW_RECIPE = "cook_new_recipe_{0}";

		// Token: 0x0401CCDF RID: 117983
		[Token(Token = "0x401CCDF")]
		private const string KEY_TRACK_TECH_NEW_NODE_IN_BAR = "tech_new_node_in_bar";

		// Token: 0x0401CCE0 RID: 117984
		[Token(Token = "0x401CCE0")]
		private const string KEY_TRACK_TECH_NEW_NODE_IN_TAB = "tech_new_node_in_tab_{0}";

		// Token: 0x0401CCE1 RID: 117985
		[Token(Token = "0x401CCE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandlePushMessage;

		// Token: 0x0401CCE2 RID: 117986
		[Token(Token = "0x401CCE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenerateSandboxV2InGameTrackPrefix;

		// Token: 0x0401CCE3 RID: 117987
		[Token(Token = "0x401CCE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateRiftDiffNewUnlockTrackId;

		// Token: 0x0401CCE4 RID: 117988
		[Token(Token = "0x401CCE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenerateRiftDiffLvNewUnlockTrackId;

		// Token: 0x0401CCE5 RID: 117989
		[Token(Token = "0x401CCE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GenerateShopInBarTrackId;

		// Token: 0x0401CCE6 RID: 117990
		[Token(Token = "0x401CCE6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GenerateSupplyInCrossDayTrackId;

		// Token: 0x0401CCE7 RID: 117991
		[Token(Token = "0x401CCE7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GenerateSupplyInBarTrackId;

		// Token: 0x0401CCE8 RID: 117992
		[Token(Token = "0x401CCE8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GenerateWorkbenchInBarTrackId;

		// Token: 0x0401CCE9 RID: 117993
		[Token(Token = "0x401CCE9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GenerateWorkbenchInTabTrackId;

		// Token: 0x0401CCEA RID: 117994
		[Token(Token = "0x401CCEA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GenerateWorkbenchItemTrackId;

		// Token: 0x0401CCEB RID: 117995
		[Token(Token = "0x401CCEB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GenerateCookInBarTrackId;

		// Token: 0x0401CCEC RID: 117996
		[Token(Token = "0x401CCEC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GenerateCookInRecipeTabTrackId;

		// Token: 0x0401CCED RID: 117997
		[Token(Token = "0x401CCED")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GenerateCookRecipeItemTrackId;

		// Token: 0x0401CCEE RID: 117998
		[Token(Token = "0x401CCEE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GenerateTechInBarTrackId;

		// Token: 0x0401CCEF RID: 117999
		[Token(Token = "0x401CCEF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GenerateTechInTabTrackId;

		// Token: 0x0401CCF0 RID: 118000
		[Token(Token = "0x401CCF0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TriggerRiftUnlockNewDifficultyLvTrack;

		// Token: 0x0401CCF1 RID: 118001
		[Token(Token = "0x401CCF1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TriggerShopInBarTrack;

		// Token: 0x0401CCF2 RID: 118002
		[Token(Token = "0x401CCF2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TriggerSupplyTrack;

		// Token: 0x0401CCF3 RID: 118003
		[Token(Token = "0x401CCF3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TriggerSupplyNewBlockTrack;

		// Token: 0x0401CCF4 RID: 118004
		[Token(Token = "0x401CCF4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TriggerWorkbenchNewItemOrRecipeTrack;

		// Token: 0x0401CCF5 RID: 118005
		[Token(Token = "0x401CCF5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__TriggerCookNewRecipeTrack;

		// Token: 0x0401CCF6 RID: 118006
		[Token(Token = "0x401CCF6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__TriggerTechNewNodeTrack;

		// Token: 0x0401CCF7 RID: 118007
		[Token(Token = "0x401CCF7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__TriggerArchiveQuestUnlock;

		// Token: 0x0401CCF8 RID: 118008
		[Token(Token = "0x401CCF8")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetSandboxV2ArchiveQuestItemIdList;

		// Token: 0x0401CCF9 RID: 118009
		[Token(Token = "0x401CCF9")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__TriggerArchiveMusicUnlock;

		// Token: 0x0401CCFA RID: 118010
		[Token(Token = "0x401CCFA")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__GetSandboxV2TrackType;

		// Token: 0x0401CCFB RID: 118011
		[Token(Token = "0x401CCFB")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__DoTrack;
	}
}
