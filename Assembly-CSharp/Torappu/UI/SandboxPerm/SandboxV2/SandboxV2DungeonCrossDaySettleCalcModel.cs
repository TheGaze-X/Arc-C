using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041A1 RID: 16801
	[Token(Token = "0x20041A1")]
	public class SandboxV2DungeonCrossDaySettleCalcModel : IHotfixable
	{
		// Token: 0x06019E94 RID: 106132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E94")]
		[Address(RVA = "0x12D58F0", Offset = "0x12D44F0", VA = "0x1812D58F0")]
		public void LoadData(SandboxV2Data topicDetailData, PlayerSandboxV2.Dungeon playerDungeonData, PlayerSandboxV2.Tech techData)
		{
		}

		// Token: 0x06019E95 RID: 106133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E95")]
		[Address(RVA = "0x12D5AC0", Offset = "0x12D46C0", VA = "0x1812D5AC0")]
		private void _RefreshTechInfo(SandboxV2Data topicDetailData, PlayerSandboxV2.Tech techData, PlayerSandboxV2.Dungeon.ReportSettle settle)
		{
		}

		// Token: 0x06019E96 RID: 106134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E96")]
		[Address(RVA = "0x12D5CA0", Offset = "0x12D48A0", VA = "0x1812D5CA0")]
		public SandboxV2DungeonCrossDaySettleCalcModel()
		{
		}

		// Token: 0x0402099B RID: 133531
		[Token(Token = "0x402099B")]
		[FieldOffset(Offset = "0x10")]
		public string surviveTitle;

		// Token: 0x0402099C RID: 133532
		[Token(Token = "0x402099C")]
		[FieldOffset(Offset = "0x18")]
		public string surviveDayBetween;

		// Token: 0x0402099D RID: 133533
		[Token(Token = "0x402099D")]
		[FieldOffset(Offset = "0x20")]
		public int startDay;

		// Token: 0x0402099E RID: 133534
		[Token(Token = "0x402099E")]
		[FieldOffset(Offset = "0x24")]
		public int endDay;

		// Token: 0x0402099F RID: 133535
		[Token(Token = "0x402099F")]
		[FieldOffset(Offset = "0x28")]
		public string scoreTotalTitle;

		// Token: 0x040209A0 RID: 133536
		[Token(Token = "0x40209A0")]
		[FieldOffset(Offset = "0x30")]
		public int scoreTotal;

		// Token: 0x040209A1 RID: 133537
		[Token(Token = "0x40209A1")]
		[FieldOffset(Offset = "0x34")]
		public int techCurRoundScore;

		// Token: 0x040209A2 RID: 133538
		[Token(Token = "0x40209A2")]
		[FieldOffset(Offset = "0x38")]
		public bool isTechHasReachMax;

		// Token: 0x040209A3 RID: 133539
		[Token(Token = "0x40209A3")]
		[FieldOffset(Offset = "0x3C")]
		public float techProgressBefore;

		// Token: 0x040209A4 RID: 133540
		[Token(Token = "0x40209A4")]
		[FieldOffset(Offset = "0x40")]
		public float techProgressCurRound;

		// Token: 0x040209A5 RID: 133541
		[Token(Token = "0x40209A5")]
		[FieldOffset(Offset = "0x44")]
		public int shopCurRoundScore;

		// Token: 0x040209A6 RID: 133542
		[Token(Token = "0x40209A6")]
		[FieldOffset(Offset = "0x48")]
		public bool isShopReachMaxScore;

		// Token: 0x040209A7 RID: 133543
		[Token(Token = "0x40209A7")]
		private const string DAY_BETWEEN_FORMAT = "{0}-{1}";

		// Token: 0x040209A8 RID: 133544
		[Token(Token = "0x40209A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040209A9 RID: 133545
		[Token(Token = "0x40209A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RefreshTechInfo;

		// Token: 0x040209AA RID: 133546
		[Token(Token = "0x40209AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
