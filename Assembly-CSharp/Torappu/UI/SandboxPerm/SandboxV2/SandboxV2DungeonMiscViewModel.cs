using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042AB RID: 17067
	[Token(Token = "0x20042AB")]
	public class SandboxV2DungeonMiscViewModel : IHotfixable
	{
		// Token: 0x0601A467 RID: 107623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A467")]
		[Address(RVA = "0x1332570", Offset = "0x1331170", VA = "0x181332570")]
		public void UpdateData(SandboxV2DungeonMiscViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A468 RID: 107624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A468")]
		[Address(RVA = "0x1332A60", Offset = "0x1331660", VA = "0x181332A60")]
		private void _LoadRacingData(SandboxV2DungeonMiscViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A469 RID: 107625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A469")]
		[Address(RVA = "0x1332D00", Offset = "0x1331900", VA = "0x181332D00")]
		public SandboxV2DungeonMiscViewModel()
		{
		}

		// Token: 0x0402149F RID: 136351
		[Token(Token = "0x402149F")]
		[FieldOffset(Offset = "0x10")]
		public string topicName;

		// Token: 0x040214A0 RID: 136352
		[Token(Token = "0x40214A0")]
		[FieldOffset(Offset = "0x18")]
		public float daySeasonAngle;

		// Token: 0x040214A1 RID: 136353
		[Token(Token = "0x40214A1")]
		[FieldOffset(Offset = "0x20")]
		public long lastLoadArchiveCoolDownTime;

		// Token: 0x040214A2 RID: 136354
		[Token(Token = "0x40214A2")]
		[FieldOffset(Offset = "0x28")]
		public bool haveArchive;

		// Token: 0x040214A3 RID: 136355
		[Token(Token = "0x40214A3")]
		[FieldOffset(Offset = "0x30")]
		public string textSurviveDay;

		// Token: 0x040214A4 RID: 136356
		[Token(Token = "0x40214A4")]
		[FieldOffset(Offset = "0x38")]
		public int tempRacerTipLimit;

		// Token: 0x040214A5 RID: 136357
		[Token(Token = "0x40214A5")]
		[FieldOffset(Offset = "0x40")]
		public string tempRacerBagName;

		// Token: 0x040214A6 RID: 136358
		[Token(Token = "0x40214A6")]
		[FieldOffset(Offset = "0x48")]
		public bool showTempRacerTip;

		// Token: 0x040214A7 RID: 136359
		[Token(Token = "0x40214A7")]
		[FieldOffset(Offset = "0x50")]
		public SandboxV2DungeonMiscExpeditionViewModel expeditionViewModel;

		// Token: 0x040214A8 RID: 136360
		[Token(Token = "0x40214A8")]
		[FieldOffset(Offset = "0x58")]
		public SandboxV2DungeonMiscLogisticsEffectViewModel logisticsEffectViewModel;

		// Token: 0x040214A9 RID: 136361
		[Token(Token = "0x40214A9")]
		[FieldOffset(Offset = "0x60")]
		public SandboxV2DungeonMiscEventEffectViewModel eventEffectViewModel;

		// Token: 0x040214AA RID: 136362
		[Token(Token = "0x40214AA")]
		[FieldOffset(Offset = "0x68")]
		public SandboxV2DungeonMaterialViewModel materialViewModel;

		// Token: 0x040214AB RID: 136363
		[Token(Token = "0x40214AB")]
		[FieldOffset(Offset = "0x70")]
		public SandboxV2DungeonMiscRiftViewModel riftViewModel;

		// Token: 0x040214AC RID: 136364
		[Token(Token = "0x40214AC")]
		[FieldOffset(Offset = "0x78")]
		public SandboxV2DungeonMiscChallengeViewModel challengeViewModel;

		// Token: 0x040214AD RID: 136365
		[Token(Token = "0x40214AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040214AE RID: 136366
		[Token(Token = "0x40214AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadRacingData;

		// Token: 0x040214AF RID: 136367
		[Token(Token = "0x40214AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020042AC RID: 17068
		[Token(Token = "0x20042AC")]
		public struct UpdateParam
		{
			// Token: 0x040214B0 RID: 136368
			[Token(Token = "0x40214B0")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x040214B1 RID: 136369
			[Token(Token = "0x40214B1")]
			[FieldOffset(Offset = "0x8")]
			public SandboxV2Data topicDetailData;

			// Token: 0x040214B2 RID: 136370
			[Token(Token = "0x40214B2")]
			[FieldOffset(Offset = "0x10")]
			public PlayerSandboxV2 playerTopicData;

			// Token: 0x040214B3 RID: 136371
			[Token(Token = "0x40214B3")]
			[FieldOffset(Offset = "0x18")]
			public PlayerSandboxV2.Dungeon playerDungeonData;
		}
	}
}
