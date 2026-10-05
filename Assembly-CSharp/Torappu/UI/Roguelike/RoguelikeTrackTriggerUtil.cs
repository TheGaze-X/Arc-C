using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005450 RID: 21584
	[Token(Token = "0x2005450")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeTrackTriggerUtil
	{
		// Token: 0x0601FC1E RID: 130078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC1E")]
		[Address(RVA = "0x196F960", Offset = "0x196E560", VA = "0x18196F960")]
		public static void RecordTriggerOnPlayerDataChanged(PlayerRoguelikeV2.OuterData prevOuterData, PlayerRoguelikeV2.OuterData curOuterData, string topicId)
		{
		}

		// Token: 0x0601FC1F RID: 130079 RVA: 0x000B2FF8 File Offset: 0x000B11F8
		[Token(Token = "0x601FC1F")]
		[Address(RVA = "0x196F7D0", Offset = "0x196E3D0", VA = "0x18196F7D0")]
		public static bool ConsumeTrack(string topicId, string id)
		{
			return default(bool);
		}

		// Token: 0x0601FC20 RID: 130080 RVA: 0x000B3010 File Offset: 0x000B1210
		[Token(Token = "0x601FC20")]
		[Address(RVA = "0x196F280", Offset = "0x196DE80", VA = "0x18196F280")]
		public static bool CheckTrack(string topicId, string id)
		{
			return default(bool);
		}

		// Token: 0x0601FC21 RID: 130081 RVA: 0x000B3028 File Offset: 0x000B1228
		[Token(Token = "0x601FC21")]
		[Address(RVA = "0x196F0C0", Offset = "0x196DCC0", VA = "0x18196F0C0")]
		public static bool CheckBankRewardNew(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601FC22 RID: 130082 RVA: 0x000B3040 File Offset: 0x000B1240
		[Token(Token = "0x601FC22")]
		[Address(RVA = "0x196F610", Offset = "0x196E210", VA = "0x18196F610")]
		public static bool ConsumeBankRewardNew(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601FC23 RID: 130083 RVA: 0x000B3058 File Offset: 0x000B1258
		[Token(Token = "0x601FC23")]
		[Address(RVA = "0x196F210", Offset = "0x196DE10", VA = "0x18196F210")]
		public static bool CheckHardModeNew(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601FC24 RID: 130084 RVA: 0x000B3070 File Offset: 0x000B1270
		[Token(Token = "0x601FC24")]
		[Address(RVA = "0x196F760", Offset = "0x196E360", VA = "0x18196F760")]
		public static bool ConsumeHardModeNew(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601FC25 RID: 130085 RVA: 0x000B3088 File Offset: 0x000B1288
		[Token(Token = "0x601FC25")]
		[Address(RVA = "0x196F1A0", Offset = "0x196DDA0", VA = "0x18196F1A0")]
		public static bool CheckDiffGradeNew(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601FC26 RID: 130086 RVA: 0x000B30A0 File Offset: 0x000B12A0
		[Token(Token = "0x601FC26")]
		[Address(RVA = "0x196F6F0", Offset = "0x196E2F0", VA = "0x18196F6F0")]
		public static bool ConsumeDiffGradeNew(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601FC27 RID: 130087 RVA: 0x000B30B8 File Offset: 0x000B12B8
		[Token(Token = "0x601FC27")]
		[Address(RVA = "0x196F130", Offset = "0x196DD30", VA = "0x18196F130")]
		public static bool CheckDiffBuffNew(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601FC28 RID: 130088 RVA: 0x000B30D0 File Offset: 0x000B12D0
		[Token(Token = "0x601FC28")]
		[Address(RVA = "0x196F680", Offset = "0x196E280", VA = "0x18196F680")]
		public static bool ConsumeDiffBuffNew(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601FC29 RID: 130089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC29")]
		[Address(RVA = "0x196F880", Offset = "0x196E480", VA = "0x18196F880")]
		public static void RecordArchiveAvgTrigger(string topicId, string storyId)
		{
		}

		// Token: 0x0601FC2A RID: 130090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC2A")]
		[Address(RVA = "0x196F330", Offset = "0x196DF30", VA = "0x18196F330")]
		public static void CleanRoguelikeArchiveBuffTrackPointIfNeeded(string topicId)
		{
		}

		// Token: 0x0601FC2B RID: 130091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC2B")]
		[Address(RVA = "0x1973370", Offset = "0x1971F70", VA = "0x181973370")]
		private static string _TryGetArchiveAvgIdByStoryId(string storyId)
		{
			return null;
		}

		// Token: 0x0601FC2C RID: 130092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC2C")]
		[Address(RVA = "0x1970650", Offset = "0x196F250", VA = "0x181970650")]
		private static string _GetRoguelikeTriggerType(string topicId)
		{
			return null;
		}

		// Token: 0x0601FC2D RID: 130093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC2D")]
		[Address(RVA = "0x19709E0", Offset = "0x196F5E0", VA = "0x1819709E0")]
		private static void _RecordBankReward(PlayerRoguelikeV2.OuterData prevOuterData, PlayerRoguelikeV2.OuterData curOuterData, string type)
		{
		}

		// Token: 0x0601FC2E RID: 130094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC2E")]
		[Address(RVA = "0x19707F0", Offset = "0x196F3F0", VA = "0x1819707F0")]
		private static void _RecordBand(PlayerRoguelikeV2.OuterData prevOuterData, PlayerRoguelikeV2.OuterData curOuterData, string type)
		{
		}

		// Token: 0x0601FC2F RID: 130095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC2F")]
		[Address(RVA = "0x1970E00", Offset = "0x196FA00", VA = "0x181970E00")]
		private static void _RecordChallengeStory(PlayerRoguelikeV2.OuterData prevOuterData, PlayerRoguelikeV2.OuterData curOuterData, string type, string topicId)
		{
		}

		// Token: 0x0601FC30 RID: 130096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC30")]
		[Address(RVA = "0x1971820", Offset = "0x1970420", VA = "0x181971820")]
		private static void _RecordDiff(PlayerRoguelikeV2.OuterData prevOuterData, PlayerRoguelikeV2.OuterData curOuterData, string type, string topicId)
		{
		}

		// Token: 0x0601FC31 RID: 130097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC31")]
		[Address(RVA = "0x19724A0", Offset = "0x19710A0", VA = "0x1819724A0")]
		private static void _RecordItemUnlockInfoTrigger(Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> prevData, Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> currData, string type)
		{
		}

		// Token: 0x0601FC32 RID: 130098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC32")]
		[Address(RVA = "0x1972820", Offset = "0x1971420", VA = "0x181972820")]
		private static void _RecordRelicArchiveTrigger(Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> prevData, Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> currData, string type, string topicId)
		{
		}

		// Token: 0x0601FC33 RID: 130099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC33")]
		[Address(RVA = "0x1972F50", Offset = "0x1971B50", VA = "0x181972F50")]
		private static void _RecordTrapArchiveTrigger(Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> prevData, Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> currData, string type, string trapType, string topicId)
		{
		}

		// Token: 0x0601FC34 RID: 130100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC34")]
		[Address(RVA = "0x1972670", Offset = "0x1971270", VA = "0x181972670")]
		private static void _RecordNormalArchiveTrigger(Dictionary<string, int> prevData, Dictionary<string, int> currData, string type)
		{
		}

		// Token: 0x0601FC35 RID: 130101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC35")]
		[Address(RVA = "0x1971210", Offset = "0x196FE10", VA = "0x181971210")]
		private static void _RecordChatTrigger(PlayerRoguelikeV2.OuterData prevData, PlayerRoguelikeV2.OuterData currData, string type, string topicId)
		{
		}

		// Token: 0x0601FC36 RID: 130102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC36")]
		[Address(RVA = "0x1972E30", Offset = "0x1971A30", VA = "0x181972E30")]
		private static void _RecordTotemTrigger(PlayerRoguelikeV2.OuterData prevData, PlayerRoguelikeV2.OuterData currData, string type)
		{
		}

		// Token: 0x0601FC37 RID: 130103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC37")]
		[Address(RVA = "0x1971140", Offset = "0x196FD40", VA = "0x181971140")]
		private static void _RecordChaosTrigger(PlayerRoguelikeV2.OuterData prevData, PlayerRoguelikeV2.OuterData currData, string type)
		{
		}

		// Token: 0x0601FC38 RID: 130104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC38")]
		[Address(RVA = "0x1970CC0", Offset = "0x196F8C0", VA = "0x181970CC0")]
		private static void _RecordCapsuleUnlockInfoTrigger(Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> prevData, Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> currData, string type, string topicId)
		{
		}

		// Token: 0x0601FC39 RID: 130105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC39")]
		[Address(RVA = "0x1970B80", Offset = "0x196F780", VA = "0x181970B80")]
		private static void _RecordBuffUnlockInfoTrigger(Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> prevData, Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> currData, string type, string topicId)
		{
		}

		// Token: 0x0601FC3A RID: 130106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC3A")]
		[Address(RVA = "0x1971EB0", Offset = "0x1970AB0", VA = "0x181971EB0")]
		private static void _RecordEndbookUnlockInfoTrigger(Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> prevData, Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> currData, PlayerRoguelikeV2.OuterData.Record record, string type, string topicId)
		{
		}

		// Token: 0x0601FC3B RID: 130107 RVA: 0x000B30E8 File Offset: 0x000B12E8
		[Token(Token = "0x601FC3B")]
		[Address(RVA = "0x19706C0", Offset = "0x196F2C0", VA = "0x1819706C0")]
		private static int _GetUnlockChatNum(List<ActArchiveChatItemData> chatData, List<string> zoneIdList)
		{
			return 0;
		}

		// Token: 0x0601FC3C RID: 130108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC3C")]
		[Address(RVA = "0x19723D0", Offset = "0x1970FD0", VA = "0x1819723D0")]
		private static void _RecordFragmentTrigger(PlayerRoguelikeV2.OuterData prevOuterData, PlayerRoguelikeV2.OuterData curOuterData, string type)
		{
		}

		// Token: 0x0601FC3D RID: 130109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC3D")]
		[Address(RVA = "0x1971DE0", Offset = "0x19709E0", VA = "0x181971DE0")]
		private static void _RecordDisasterTrigger(PlayerRoguelikeV2.OuterData prevOuterData, PlayerRoguelikeV2.OuterData curOuterData, string type)
		{
		}

		// Token: 0x0601FC3E RID: 130110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC3E")]
		[Address(RVA = "0x19732A0", Offset = "0x1971EA0", VA = "0x1819732A0")]
		private static void _RecordWrathTrigger(PlayerRoguelikeV2.OuterData prevOuterData, PlayerRoguelikeV2.OuterData curOuterData, string type)
		{
		}

		// Token: 0x0601FC3F RID: 130111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC3F")]
		[Address(RVA = "0x1971530", Offset = "0x1970130", VA = "0x181971530")]
		private static void _RecordCopperTrigger(PlayerRoguelikeV2.OuterData prevOuterData, PlayerRoguelikeV2.OuterData curOuterData, string type, string topicId)
		{
		}

		// Token: 0x0601FC40 RID: 130112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC40")]
		[Address(RVA = "0x1970410", Offset = "0x196F010", VA = "0x181970410")]
		private static HashSet<string> _GetAttainedGild(PlayerRoguelikeV2.OuterData outerData, RoguelikeCopperModuleData copperModule)
		{
			return null;
		}

		// Token: 0x0402ACA9 RID: 175273
		[Token(Token = "0x402ACA9")]
		private const string ID_BANK_REWARD_NEW = "bank_reward_new";

		// Token: 0x0402ACAA RID: 175274
		[Token(Token = "0x402ACAA")]
		private const string ID_DIFF_HARD_NEW = "difficulty_hard_new";

		// Token: 0x0402ACAB RID: 175275
		[Token(Token = "0x402ACAB")]
		private const string ID_DIFF_GRADE_NEW = "difficulty_grade_new";

		// Token: 0x0402ACAC RID: 175276
		[Token(Token = "0x402ACAC")]
		private const string ID_DIFF_BUFF_NEW = "difficulty_buff_new";

		// Token: 0x0402ACAD RID: 175277
		[Token(Token = "0x402ACAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RecordTriggerOnPlayerDataChanged;

		// Token: 0x0402ACAE RID: 175278
		[Token(Token = "0x402ACAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ConsumeTrack;

		// Token: 0x0402ACAF RID: 175279
		[Token(Token = "0x402ACAF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckTrack;

		// Token: 0x0402ACB0 RID: 175280
		[Token(Token = "0x402ACB0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckBankRewardNew;

		// Token: 0x0402ACB1 RID: 175281
		[Token(Token = "0x402ACB1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConsumeBankRewardNew;

		// Token: 0x0402ACB2 RID: 175282
		[Token(Token = "0x402ACB2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckHardModeNew;

		// Token: 0x0402ACB3 RID: 175283
		[Token(Token = "0x402ACB3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ConsumeHardModeNew;

		// Token: 0x0402ACB4 RID: 175284
		[Token(Token = "0x402ACB4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckDiffGradeNew;

		// Token: 0x0402ACB5 RID: 175285
		[Token(Token = "0x402ACB5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ConsumeDiffGradeNew;

		// Token: 0x0402ACB6 RID: 175286
		[Token(Token = "0x402ACB6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckDiffBuffNew;

		// Token: 0x0402ACB7 RID: 175287
		[Token(Token = "0x402ACB7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ConsumeDiffBuffNew;

		// Token: 0x0402ACB8 RID: 175288
		[Token(Token = "0x402ACB8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RecordArchiveAvgTrigger;

		// Token: 0x0402ACB9 RID: 175289
		[Token(Token = "0x402ACB9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CleanRoguelikeArchiveBuffTrackPointIfNeeded;

		// Token: 0x0402ACBA RID: 175290
		[Token(Token = "0x402ACBA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryGetArchiveAvgIdByStoryId;

		// Token: 0x0402ACBB RID: 175291
		[Token(Token = "0x402ACBB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetRoguelikeTriggerType;

		// Token: 0x0402ACBC RID: 175292
		[Token(Token = "0x402ACBC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RecordBankReward;

		// Token: 0x0402ACBD RID: 175293
		[Token(Token = "0x402ACBD")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RecordBand;

		// Token: 0x0402ACBE RID: 175294
		[Token(Token = "0x402ACBE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RecordChallengeStory;

		// Token: 0x0402ACBF RID: 175295
		[Token(Token = "0x402ACBF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__RecordDiff;

		// Token: 0x0402ACC0 RID: 175296
		[Token(Token = "0x402ACC0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RecordItemUnlockInfoTrigger;

		// Token: 0x0402ACC1 RID: 175297
		[Token(Token = "0x402ACC1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__RecordRelicArchiveTrigger;

		// Token: 0x0402ACC2 RID: 175298
		[Token(Token = "0x402ACC2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__RecordTrapArchiveTrigger;

		// Token: 0x0402ACC3 RID: 175299
		[Token(Token = "0x402ACC3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__RecordNormalArchiveTrigger;

		// Token: 0x0402ACC4 RID: 175300
		[Token(Token = "0x402ACC4")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__RecordChatTrigger;

		// Token: 0x0402ACC5 RID: 175301
		[Token(Token = "0x402ACC5")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__RecordTotemTrigger;

		// Token: 0x0402ACC6 RID: 175302
		[Token(Token = "0x402ACC6")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__RecordChaosTrigger;

		// Token: 0x0402ACC7 RID: 175303
		[Token(Token = "0x402ACC7")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__RecordCapsuleUnlockInfoTrigger;

		// Token: 0x0402ACC8 RID: 175304
		[Token(Token = "0x402ACC8")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__RecordBuffUnlockInfoTrigger;

		// Token: 0x0402ACC9 RID: 175305
		[Token(Token = "0x402ACC9")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RecordEndbookUnlockInfoTrigger;

		// Token: 0x0402ACCA RID: 175306
		[Token(Token = "0x402ACCA")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__GetUnlockChatNum;

		// Token: 0x0402ACCB RID: 175307
		[Token(Token = "0x402ACCB")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__RecordFragmentTrigger;

		// Token: 0x0402ACCC RID: 175308
		[Token(Token = "0x402ACCC")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__RecordDisasterTrigger;

		// Token: 0x0402ACCD RID: 175309
		[Token(Token = "0x402ACCD")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__RecordWrathTrigger;

		// Token: 0x0402ACCE RID: 175310
		[Token(Token = "0x402ACCE")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__RecordCopperTrigger;

		// Token: 0x0402ACCF RID: 175311
		[Token(Token = "0x402ACCF")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__GetAttainedGild;
	}
}
