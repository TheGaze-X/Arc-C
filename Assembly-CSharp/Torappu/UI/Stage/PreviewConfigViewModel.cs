using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068AF RID: 26799
	[Token(Token = "0x20068AF")]
	public class PreviewConfigViewModel : IHotfixable
	{
		// Token: 0x17005A96 RID: 23190
		// (get) Token: 0x0602665C RID: 157276 RVA: 0x000CAD70 File Offset: 0x000C8F70
		[Token(Token = "0x17005A96")]
		public int apCost
		{
			[Token(Token = "0x602665C")]
			[Address(RVA = "0x217A900", Offset = "0x2179500", VA = "0x18217A900")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005A97 RID: 23191
		// (get) Token: 0x0602665D RID: 157277 RVA: 0x000CAD88 File Offset: 0x000C8F88
		[Token(Token = "0x17005A97")]
		public bool isMultipleBattle
		{
			[Token(Token = "0x602665D")]
			[Address(RVA = "0x217AA80", Offset = "0x2179680", VA = "0x18217AA80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005A98 RID: 23192
		// (get) Token: 0x0602665E RID: 157278 RVA: 0x000CADA0 File Offset: 0x000C8FA0
		[Token(Token = "0x17005A98")]
		public bool isMultipleBattleTwiceAndMore
		{
			[Token(Token = "0x602665E")]
			[Address(RVA = "0x217A9D0", Offset = "0x21795D0", VA = "0x18217A9D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602665F RID: 157279 RVA: 0x000CADB8 File Offset: 0x000C8FB8
		[Token(Token = "0x602665F")]
		[Address(RVA = "0x217A820", Offset = "0x2179420", VA = "0x18217A820")]
		public bool CheckIfToUseAutoBattle(bool isPratice)
		{
			return default(bool);
		}

		// Token: 0x06026660 RID: 157280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026660")]
		[Address(RVA = "0x217A8A0", Offset = "0x21794A0", VA = "0x18217A8A0")]
		public PreviewConfigViewModel()
		{
		}

		// Token: 0x04036150 RID: 221520
		[Token(Token = "0x4036150")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04036151 RID: 221521
		[Token(Token = "0x4036151")]
		[FieldOffset(Offset = "0x18")]
		public bool isAutoBattle;

		// Token: 0x04036152 RID: 221522
		[Token(Token = "0x4036152")]
		[FieldOffset(Offset = "0x19")]
		public bool canAutoBattle;

		// Token: 0x04036153 RID: 221523
		[Token(Token = "0x4036153")]
		[FieldOffset(Offset = "0x1A")]
		public bool shouldAutoBattleHidden;

		// Token: 0x04036154 RID: 221524
		[Token(Token = "0x4036154")]
		[FieldOffset(Offset = "0x1B")]
		public bool canPractice;

		// Token: 0x04036155 RID: 221525
		[Token(Token = "0x4036155")]
		[FieldOffset(Offset = "0x1C")]
		public bool canReplayStory;

		// Token: 0x04036156 RID: 221526
		[Token(Token = "0x4036156")]
		[FieldOffset(Offset = "0x1D")]
		public bool canHardBattle;

		// Token: 0x04036157 RID: 221527
		[Token(Token = "0x4036157")]
		[FieldOffset(Offset = "0x1E")]
		public bool canSixStarBattle;

		// Token: 0x04036158 RID: 221528
		[Token(Token = "0x4036158")]
		[FieldOffset(Offset = "0x1F")]
		public bool stageDiffGroupActive;

		// Token: 0x04036159 RID: 221529
		[Token(Token = "0x4036159")]
		[FieldOffset(Offset = "0x20")]
		public int baseApCost;

		// Token: 0x0403615A RID: 221530
		[Token(Token = "0x403615A")]
		[FieldOffset(Offset = "0x24")]
		public bool canMultipleBattle;

		// Token: 0x0403615B RID: 221531
		[Token(Token = "0x403615B")]
		[FieldOffset(Offset = "0x28")]
		public int multipleBattleTimes;

		// Token: 0x0403615C RID: 221532
		[Token(Token = "0x403615C")]
		[FieldOffset(Offset = "0x2C")]
		public bool hasHardToShow;

		// Token: 0x0403615D RID: 221533
		[Token(Token = "0x403615D")]
		[FieldOffset(Offset = "0x2D")]
		public bool hasSixStarToShow;

		// Token: 0x0403615E RID: 221534
		[Token(Token = "0x403615E")]
		[FieldOffset(Offset = "0x30")]
		public SpecialStageType stageSelectType;

		// Token: 0x0403615F RID: 221535
		[Token(Token = "0x403615F")]
		[FieldOffset(Offset = "0x34")]
		public bool isUsingEt;

		// Token: 0x04036160 RID: 221536
		[Token(Token = "0x4036160")]
		[FieldOffset(Offset = "0x38")]
		public OverrideDropInfo overrideDropInfo;

		// Token: 0x04036161 RID: 221537
		[Token(Token = "0x4036161")]
		[FieldOffset(Offset = "0x40")]
		public bool isSkillSelectablePredefined;

		// Token: 0x04036162 RID: 221538
		[Token(Token = "0x4036162")]
		[FieldOffset(Offset = "0x44")]
		public StageDiffGroup stageDiffGroup;

		// Token: 0x04036163 RID: 221539
		[Token(Token = "0x4036163")]
		[FieldOffset(Offset = "0x48")]
		public StageBattleDiffGroupInfo battleDiffGroupInfo;

		// Token: 0x04036164 RID: 221540
		[Token(Token = "0x4036164")]
		[FieldOffset(Offset = "0x50")]
		public string startBattleStyle;

		// Token: 0x04036165 RID: 221541
		[Token(Token = "0x4036165")]
		[FieldOffset(Offset = "0x58")]
		public int styleCost;

		// Token: 0x04036166 RID: 221542
		[Token(Token = "0x4036166")]
		[FieldOffset(Offset = "0x60")]
		public IPreviewConfigViewModelPlugin plugin;

		// Token: 0x04036167 RID: 221543
		[Token(Token = "0x4036167")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_apCost;

		// Token: 0x04036168 RID: 221544
		[Token(Token = "0x4036168")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isMultipleBattle;

		// Token: 0x04036169 RID: 221545
		[Token(Token = "0x4036169")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isMultipleBattleTwiceAndMore;

		// Token: 0x0403616A RID: 221546
		[Token(Token = "0x403616A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfToUseAutoBattle;

		// Token: 0x0403616B RID: 221547
		[Token(Token = "0x403616B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020068B0 RID: 26800
		[Token(Token = "0x20068B0")]
		public struct Config
		{
			// Token: 0x0403616C RID: 221548
			[Token(Token = "0x403616C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly PreviewConfigViewModel.Config DEFAULT;

			// Token: 0x0403616D RID: 221549
			[Token(Token = "0x403616D")]
			[FieldOffset(Offset = "0x0")]
			public bool showStoryReplayBtn;

			// Token: 0x0403616E RID: 221550
			[Token(Token = "0x403616E")]
			[FieldOffset(Offset = "0x1")]
			public bool isRetro;

			// Token: 0x0403616F RID: 221551
			[Token(Token = "0x403616F")]
			[FieldOffset(Offset = "0x8")]
			public IPreviewConfigViewModelPlugin plugin;
		}
	}
}
