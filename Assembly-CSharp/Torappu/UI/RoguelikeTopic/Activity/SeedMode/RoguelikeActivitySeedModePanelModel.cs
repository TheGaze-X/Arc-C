using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity.SeedMode
{
	// Token: 0x020046A2 RID: 18082
	[Token(Token = "0x20046A2")]
	public class RoguelikeActivitySeedModePanelModel : IHotfixable
	{
		// Token: 0x0601B6F0 RID: 112368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6F0")]
		[Address(RVA = "0x14D68A0", Offset = "0x14D54A0", VA = "0x1814D68A0")]
		public void InitModel(string inputTopicId, string inputRlActId)
		{
		}

		// Token: 0x0601B6F1 RID: 112369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6F1")]
		[Address(RVA = "0x14D6940", Offset = "0x14D5540", VA = "0x1814D6940")]
		public void UpdateModel()
		{
		}

		// Token: 0x0601B6F2 RID: 112370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6F2")]
		[Address(RVA = "0x14D6CB0", Offset = "0x14D58B0", VA = "0x1814D6CB0")]
		private void _UpdateGrade(PlayerRoguelikeV2.OuterData outer, RoguelikeTopicDetail detailData, RoguelikeActivityBasicData activityBasicData)
		{
		}

		// Token: 0x0601B6F3 RID: 112371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6F3")]
		[Address(RVA = "0x14D6F10", Offset = "0x14D5B10", VA = "0x1814D6F10")]
		public RoguelikeActivitySeedModePanelModel()
		{
		}

		// Token: 0x040237D7 RID: 145367
		[Token(Token = "0x40237D7")]
		private const string TIME_FORMAT = "yyyy.MM.dd";

		// Token: 0x040237D8 RID: 145368
		[Token(Token = "0x40237D8")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x040237D9 RID: 145369
		[Token(Token = "0x40237D9")]
		[FieldOffset(Offset = "0x18")]
		public string rlActId;

		// Token: 0x040237DA RID: 145370
		[Token(Token = "0x40237DA")]
		[FieldOffset(Offset = "0x20")]
		public string seedStr;

		// Token: 0x040237DB RID: 145371
		[Token(Token = "0x40237DB")]
		[FieldOffset(Offset = "0x28")]
		public int seedGrade;

		// Token: 0x040237DC RID: 145372
		[Token(Token = "0x40237DC")]
		[FieldOffset(Offset = "0x2C")]
		public RoguelikeTopicMode validMode;

		// Token: 0x040237DD RID: 145373
		[Token(Token = "0x40237DD")]
		[FieldOffset(Offset = "0x30")]
		public string seedGradeName;

		// Token: 0x040237DE RID: 145374
		[Token(Token = "0x40237DE")]
		[FieldOffset(Offset = "0x38")]
		public int curGrade;

		// Token: 0x040237DF RID: 145375
		[Token(Token = "0x40237DF")]
		[FieldOffset(Offset = "0x3C")]
		public bool isSeedGradeLock;

		// Token: 0x040237E0 RID: 145376
		[Token(Token = "0x40237E0")]
		[FieldOffset(Offset = "0x3D")]
		public bool isPlaying;

		// Token: 0x040237E1 RID: 145377
		[Token(Token = "0x40237E1")]
		[FieldOffset(Offset = "0x40")]
		public string seedTips;

		// Token: 0x040237E2 RID: 145378
		[Token(Token = "0x40237E2")]
		[FieldOffset(Offset = "0x48")]
		public string endTime;

		// Token: 0x040237E3 RID: 145379
		[Token(Token = "0x40237E3")]
		[FieldOffset(Offset = "0x50")]
		public RoguelikeActivitySeedModeData.RoguelikeActivitySeedModeConstData constData;

		// Token: 0x040237E4 RID: 145380
		[Token(Token = "0x40237E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModel;

		// Token: 0x040237E5 RID: 145381
		[Token(Token = "0x40237E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateModel;

		// Token: 0x040237E6 RID: 145382
		[Token(Token = "0x40237E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateGrade;

		// Token: 0x040237E7 RID: 145383
		[Token(Token = "0x40237E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
