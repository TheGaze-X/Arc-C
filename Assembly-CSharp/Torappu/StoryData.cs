using System;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using XLua;

namespace Torappu
{
	// Token: 0x02001373 RID: 4979
	[Token(Token = "0x2001373")]
	[Serializable]
	public class StoryData
	{
		// Token: 0x0600733E RID: 29502 RVA: 0x000332A0 File Offset: 0x000314A0
		[Token(Token = "0x600733E")]
		[Address(RVA = "0x22151E0", Offset = "0x2213DE0", VA = "0x1822151E0")]
		public bool CheckNeedCommit()
		{
			return default(bool);
		}

		// Token: 0x0600733F RID: 29503 RVA: 0x000332B8 File Offset: 0x000314B8
		[Token(Token = "0x600733F")]
		[Address(RVA = "0x2215170", Offset = "0x2213D70", VA = "0x182215170")]
		public bool CheckCommittedOrDontNeedCommit()
		{
			return default(bool);
		}

		// Token: 0x06007340 RID: 29504 RVA: 0x000332D0 File Offset: 0x000314D0
		[Token(Token = "0x6007340")]
		[Address(RVA = "0x22153A0", Offset = "0x2213FA0", VA = "0x1822153A0")]
		public bool NeedTrig(StoryData.Trigger.TriggerType type, string key)
		{
			return default(bool);
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x000332E8 File Offset: 0x000314E8
		[Token(Token = "0x6007341")]
		[Address(RVA = "0x22152D0", Offset = "0x2213ED0", VA = "0x1822152D0")]
		public bool NeedTrigWithoutCheckTrigger(bool forceRepeatableAndIgnoreStageCond = false)
		{
			return default(bool);
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x00033300 File Offset: 0x00031500
		[Token(Token = "0x6007342")]
		[Address(RVA = "0x2215200", Offset = "0x2213E00", VA = "0x182215200")]
		public bool NeedTrigCanIgnoreStageCond(bool IgnoreStageCond = false)
		{
			return default(bool);
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007343")]
		[Address(RVA = "0x22156A0", Offset = "0x22142A0", VA = "0x1822156A0")]
		public StoryData()
		{
		}

		// Token: 0x04006E6D RID: 28269
		[Token(Token = "0x4006E6D")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006E6E RID: 28270
		[Token(Token = "0x4006E6E")]
		[FieldOffset(Offset = "0x18")]
		public bool needCommit;

		// Token: 0x04006E6F RID: 28271
		[Token(Token = "0x4006E6F")]
		[FieldOffset(Offset = "0x19")]
		public bool repeatable;

		// Token: 0x04006E70 RID: 28272
		[Token(Token = "0x4006E70")]
		[FieldOffset(Offset = "0x1A")]
		public bool disabled;

		// Token: 0x04006E71 RID: 28273
		[Token(Token = "0x4006E71")]
		[FieldOffset(Offset = "0x1B")]
		public bool videoResource;

		// Token: 0x04006E72 RID: 28274
		[Token(Token = "0x4006E72")]
		[FieldOffset(Offset = "0x20")]
		public StoryData.Trigger trigger;

		// Token: 0x04006E73 RID: 28275
		[Token(Token = "0x4006E73")]
		[FieldOffset(Offset = "0x40")]
		public StoryData.Condition condition;

		// Token: 0x04006E74 RID: 28276
		[Token(Token = "0x4006E74")]
		[FieldOffset(Offset = "0x48")]
		public int setProgress;

		// Token: 0x04006E75 RID: 28277
		[Token(Token = "0x4006E75")]
		[FieldOffset(Offset = "0x50")]
		public string[] setFlags;

		// Token: 0x04006E76 RID: 28278
		[Token(Token = "0x4006E76")]
		[FieldOffset(Offset = "0x58")]
		public ItemBundle[] completedRewards;

		// Token: 0x04006E77 RID: 28279
		[Token(Token = "0x4006E77")]
		[FieldOffset(Offset = "0x60")]
		[JsonIgnore]
		public bool forceOmitCommit;

		// Token: 0x02001374 RID: 4980
		[Token(Token = "0x2001374")]
		[Serializable]
		public struct Trigger
		{
			// Token: 0x06007344 RID: 29508 RVA: 0x00033318 File Offset: 0x00031518
			[Token(Token = "0x6007344")]
			[Address(RVA = "0x2215D10", Offset = "0x2214910", VA = "0x182215D10")]
			public bool Check(StoryData.Trigger.TriggerType type, string key)
			{
				return default(bool);
			}

			// Token: 0x06007345 RID: 29509 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007345")]
			[Address(RVA = "0x2215E20", Offset = "0x2214A20", VA = "0x182215E20")]
			public void Normalize()
			{
			}

			// Token: 0x04006E78 RID: 28280
			[Token(Token = "0x4006E78")]
			[JsonIgnore]
			public const int TRIGGER_TYPE_NUM = 12;

			// Token: 0x04006E79 RID: 28281
			[Token(Token = "0x4006E79")]
			[FieldOffset(Offset = "0x0")]
			[JsonConverter(typeof(StringEnumConverter))]
			public StoryData.Trigger.TriggerType type;

			// Token: 0x04006E7A RID: 28282
			[Token(Token = "0x4006E7A")]
			[FieldOffset(Offset = "0x8")]
			public string key;

			// Token: 0x04006E7B RID: 28283
			[Token(Token = "0x4006E7B")]
			[FieldOffset(Offset = "0x10")]
			public bool useRegex;

			// Token: 0x04006E7C RID: 28284
			[Token(Token = "0x4006E7C")]
			[FieldOffset(Offset = "0x18")]
			[JsonIgnore]
			private Regex m_regex;

			// Token: 0x02001375 RID: 4981
			[Token(Token = "0x2001375")]
			public enum TriggerType
			{
				// Token: 0x04006E7E RID: 28286
				[Token(Token = "0x4006E7E")]
				GAME_START,
				// Token: 0x04006E7F RID: 28287
				[Token(Token = "0x4006E7F")]
				BEFORE_BATTLE,
				// Token: 0x04006E80 RID: 28288
				[Token(Token = "0x4006E80")]
				AFTER_BATTLE,
				// Token: 0x04006E81 RID: 28289
				[Token(Token = "0x4006E81")]
				SWITCH_TO_SCENE,
				// Token: 0x04006E82 RID: 28290
				[Token(Token = "0x4006E82")]
				PAGE_LOADED,
				// Token: 0x04006E83 RID: 28291
				[Token(Token = "0x4006E83")]
				STORY_FINISH,
				// Token: 0x04006E84 RID: 28292
				[Token(Token = "0x4006E84")]
				CUSTOM_OPERATION,
				// Token: 0x04006E85 RID: 28293
				[Token(Token = "0x4006E85")]
				STORY_FINISH_OR_PAGE_LOADED,
				// Token: 0x04006E86 RID: 28294
				[Token(Token = "0x4006E86")]
				ACTIVITY_LOADED,
				// Token: 0x04006E87 RID: 28295
				[Token(Token = "0x4006E87")]
				ACTIVITY_ANNOUNCE,
				// Token: 0x04006E88 RID: 28296
				[Token(Token = "0x4006E88")]
				CRISIS_SEASON_LOADED,
				// Token: 0x04006E89 RID: 28297
				[Token(Token = "0x4006E89")]
				STORY_FINISH_OR_CUSTOM_OPERATION,
				// Token: 0x04006E8A RID: 28298
				[Token(Token = "0x4006E8A")]
				E_NUM
			}
		}

		// Token: 0x02001376 RID: 4982
		[Token(Token = "0x2001376")]
		[Hotfix(HotfixFlag.Stateless)]
		[Serializable]
		public class Condition
		{
			// Token: 0x06007346 RID: 29510 RVA: 0x00033330 File Offset: 0x00031530
			[Token(Token = "0x6007346")]
			[Address(RVA = "0x2203AA0", Offset = "0x22026A0", VA = "0x182203AA0")]
			public bool Check(PlayerDataModel model, bool ignoreStageCond = false)
			{
				return default(bool);
			}

			// Token: 0x06007347 RID: 29511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007347")]
			[Address(RVA = "0x2203D00", Offset = "0x2202900", VA = "0x182203D00")]
			public Condition()
			{
			}

			// Token: 0x04006E8B RID: 28299
			[Token(Token = "0x4006E8B")]
			[FieldOffset(Offset = "0x10")]
			public int minProgress;

			// Token: 0x04006E8C RID: 28300
			[Token(Token = "0x4006E8C")]
			[FieldOffset(Offset = "0x14")]
			public int maxProgress;

			// Token: 0x04006E8D RID: 28301
			[Token(Token = "0x4006E8D")]
			[FieldOffset(Offset = "0x18")]
			public int minPlayerLevel;

			// Token: 0x04006E8E RID: 28302
			[Token(Token = "0x4006E8E")]
			[FieldOffset(Offset = "0x20")]
			public string[] requiredFlags;

			// Token: 0x04006E8F RID: 28303
			[Token(Token = "0x4006E8F")]
			[FieldOffset(Offset = "0x28")]
			public string[] excludedFlags;

			// Token: 0x04006E90 RID: 28304
			[Token(Token = "0x4006E90")]
			[FieldOffset(Offset = "0x30")]
			public StoryData.Condition.StageCondition[] requiredStages;

			// Token: 0x04006E91 RID: 28305
			[Token(Token = "0x4006E91")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Check;

			// Token: 0x04006E92 RID: 28306
			[Token(Token = "0x4006E92")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02001377 RID: 4983
			[Token(Token = "0x2001377")]
			[Serializable]
			public class StageCondition
			{
				// Token: 0x06007348 RID: 29512 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007348")]
				[Address(RVA = "0x2213980", Offset = "0x2212580", VA = "0x182213980")]
				public StageCondition()
				{
				}

				// Token: 0x06007349 RID: 29513 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6007349")]
				[Address(RVA = "0x2213920", Offset = "0x2212520", VA = "0x182213920")]
				public StageCondition(string stageId, PlayerStageState minState, PlayerStageState maxState = PlayerStageState.COMPLETE)
				{
				}

				// Token: 0x04006E93 RID: 28307
				[Token(Token = "0x4006E93")]
				[FieldOffset(Offset = "0x10")]
				public string stageId;

				// Token: 0x04006E94 RID: 28308
				[Token(Token = "0x4006E94")]
				[FieldOffset(Offset = "0x18")]
				public PlayerStageState minState;

				// Token: 0x04006E95 RID: 28309
				[Token(Token = "0x4006E95")]
				[FieldOffset(Offset = "0x1C")]
				public PlayerStageState maxState;
			}
		}
	}
}
