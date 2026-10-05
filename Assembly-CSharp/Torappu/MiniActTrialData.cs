using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001391 RID: 5009
	[Token(Token = "0x2001391")]
	[Serializable]
	public class MiniActTrialData
	{
		// Token: 0x06007370 RID: 29552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007370")]
		[Address(RVA = "0x22086C0", Offset = "0x22072C0", VA = "0x1822086C0")]
		public MiniActTrialData()
		{
		}

		// Token: 0x04006F39 RID: 28473
		[Token(Token = "0x4006F39")]
		[FieldOffset(Offset = "0x10")]
		public int preShowDays;

		// Token: 0x04006F3A RID: 28474
		[Token(Token = "0x4006F3A")]
		[FieldOffset(Offset = "0x18")]
		public List<MiniActTrialData.RuleData> ruleDataList;

		// Token: 0x04006F3B RID: 28475
		[Token(Token = "0x4006F3B")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, MiniActTrialData.MiniActTrialSingleData> miniActTrialDataMap;

		// Token: 0x02001392 RID: 5010
		[Token(Token = "0x2001392")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum RuleType
		{
			// Token: 0x04006F3D RID: 28477
			[Token(Token = "0x4006F3D")]
			NONE,
			// Token: 0x04006F3E RID: 28478
			[Token(Token = "0x4006F3E")]
			TITLE,
			// Token: 0x04006F3F RID: 28479
			[Token(Token = "0x4006F3F")]
			CONTENT
		}

		// Token: 0x02001393 RID: 5011
		[Token(Token = "0x2001393")]
		[Serializable]
		public class RuleData
		{
			// Token: 0x06007371 RID: 29553 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007371")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RuleData()
			{
			}

			// Token: 0x04006F40 RID: 28480
			[Token(Token = "0x4006F40")]
			[FieldOffset(Offset = "0x10")]
			public MiniActTrialData.RuleType ruleType;

			// Token: 0x04006F41 RID: 28481
			[Token(Token = "0x4006F41")]
			[FieldOffset(Offset = "0x18")]
			public string ruleText;
		}

		// Token: 0x02001394 RID: 5012
		[Token(Token = "0x2001394")]
		[Serializable]
		public class MiniActTrialSingleData
		{
			// Token: 0x06007372 RID: 29554 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007372")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MiniActTrialSingleData()
			{
			}

			// Token: 0x04006F42 RID: 28482
			[Token(Token = "0x4006F42")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04006F43 RID: 28483
			[Token(Token = "0x4006F43")]
			[FieldOffset(Offset = "0x18")]
			public long rewardStartTime;

			// Token: 0x04006F44 RID: 28484
			[Token(Token = "0x4006F44")]
			[FieldOffset(Offset = "0x20")]
			public string themeColor;

			// Token: 0x04006F45 RID: 28485
			[Token(Token = "0x4006F45")]
			[FieldOffset(Offset = "0x28")]
			public List<MiniActTrialData.MiniActTrialRewardData> rewardList;
		}

		// Token: 0x02001395 RID: 5013
		[Token(Token = "0x2001395")]
		[Serializable]
		public class MiniActTrialRewardData
		{
			// Token: 0x06007373 RID: 29555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007373")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MiniActTrialRewardData()
			{
			}

			// Token: 0x04006F46 RID: 28486
			[Token(Token = "0x4006F46")]
			[FieldOffset(Offset = "0x10")]
			public string trialRewardId;

			// Token: 0x04006F47 RID: 28487
			[Token(Token = "0x4006F47")]
			[FieldOffset(Offset = "0x18")]
			public int orderId;

			// Token: 0x04006F48 RID: 28488
			[Token(Token = "0x4006F48")]
			[FieldOffset(Offset = "0x20")]
			public string actId;

			// Token: 0x04006F49 RID: 28489
			[Token(Token = "0x4006F49")]
			[FieldOffset(Offset = "0x28")]
			public int targetStoryCount;

			// Token: 0x04006F4A RID: 28490
			[Token(Token = "0x4006F4A")]
			[FieldOffset(Offset = "0x30")]
			public ItemBundle item;
		}
	}
}
