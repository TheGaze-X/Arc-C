using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042ED RID: 17133
	[Token(Token = "0x20042ED")]
	public class SandboxV2DungeonGameflowViewModel : IHotfixable
	{
		// Token: 0x0601A563 RID: 107875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A563")]
		[Address(RVA = "0x1343420", Offset = "0x1342020", VA = "0x181343420")]
		public void UpdateData(SandboxV2DungeonGameflowViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A564 RID: 107876 RVA: 0x000A15B0 File Offset: 0x0009F7B0
		[Token(Token = "0x601A564")]
		[Address(RVA = "0x1343E40", Offset = "0x1342A40", VA = "0x181343E40")]
		private int _GenBasementMaxLevel(SandboxV2DungeonGameflowViewModel.UpdateParam updateParam)
		{
			return 0;
		}

		// Token: 0x0601A565 RID: 107877 RVA: 0x000A15C8 File Offset: 0x0009F7C8
		[Token(Token = "0x601A565")]
		[Address(RVA = "0x1343C40", Offset = "0x1342840", VA = "0x181343C40")]
		private bool _CheckBasementUpgrade(SandboxV2DungeonGameflowViewModel.UpdateParam updateParam)
		{
			return default(bool);
		}

		// Token: 0x0601A566 RID: 107878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A566")]
		[Address(RVA = "0x1343F80", Offset = "0x1342B80", VA = "0x181343F80")]
		private void _LoadSeasonData(SandboxV2SeasonType currSeason, SandboxV2Data topicDetailData)
		{
		}

		// Token: 0x0601A567 RID: 107879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A567")]
		[Address(RVA = "0x1344080", Offset = "0x1342C80", VA = "0x181344080")]
		public SandboxV2DungeonGameflowViewModel()
		{
		}

		// Token: 0x04021679 RID: 136825
		[Token(Token = "0x4021679")]
		[FieldOffset(Offset = "0x10")]
		public bool isRift;

		// Token: 0x0402167A RID: 136826
		[Token(Token = "0x402167A")]
		[FieldOffset(Offset = "0x11")]
		public bool isGuide;

		// Token: 0x0402167B RID: 136827
		[Token(Token = "0x402167B")]
		[FieldOffset(Offset = "0x12")]
		public bool isChallenge;

		// Token: 0x0402167C RID: 136828
		[Token(Token = "0x402167C")]
		[FieldOffset(Offset = "0x14")]
		public PlayerSandboxV2.GameState state;

		// Token: 0x0402167D RID: 136829
		[Token(Token = "0x402167D")]
		[FieldOffset(Offset = "0x18")]
		public int day;

		// Token: 0x0402167E RID: 136830
		[Token(Token = "0x402167E")]
		[FieldOffset(Offset = "0x1C")]
		public int maxDay;

		// Token: 0x0402167F RID: 136831
		[Token(Token = "0x402167F")]
		[FieldOffset(Offset = "0x20")]
		public int currAp;

		// Token: 0x04021680 RID: 136832
		[Token(Token = "0x4021680")]
		[FieldOffset(Offset = "0x24")]
		public int maxAp;

		// Token: 0x04021681 RID: 136833
		[Token(Token = "0x4021681")]
		[FieldOffset(Offset = "0x28")]
		public SandboxV2SeasonType currSeason;

		// Token: 0x04021682 RID: 136834
		[Token(Token = "0x4021682")]
		[FieldOffset(Offset = "0x2C")]
		public int currSeasonRemainDays;

		// Token: 0x04021683 RID: 136835
		[Token(Token = "0x4021683")]
		[FieldOffset(Offset = "0x30")]
		public int daysBeforeAssessment;

		// Token: 0x04021684 RID: 136836
		[Token(Token = "0x4021684")]
		[FieldOffset(Offset = "0x34")]
		public int basementLevel;

		// Token: 0x04021685 RID: 136837
		[Token(Token = "0x4021685")]
		[FieldOffset(Offset = "0x38")]
		public int basementMaxLevel;

		// Token: 0x04021686 RID: 136838
		[Token(Token = "0x4021686")]
		[FieldOffset(Offset = "0x3C")]
		public bool basementCanUpgrade;

		// Token: 0x04021687 RID: 136839
		[Token(Token = "0x4021687")]
		[FieldOffset(Offset = "0x3D")]
		public bool portableConstructUnlocked;

		// Token: 0x04021688 RID: 136840
		[Token(Token = "0x4021688")]
		[FieldOffset(Offset = "0x3E")]
		public bool outpostConstructUnlocked;

		// Token: 0x04021689 RID: 136841
		[Token(Token = "0x4021689")]
		[FieldOffset(Offset = "0x3F")]
		public bool shopUnlocked;

		// Token: 0x0402168A RID: 136842
		[Token(Token = "0x402168A")]
		[FieldOffset(Offset = "0x40")]
		public bool isSettleDay;

		// Token: 0x0402168B RID: 136843
		[Token(Token = "0x402168B")]
		[FieldOffset(Offset = "0x41")]
		public bool isRiftReserved;

		// Token: 0x0402168C RID: 136844
		[Token(Token = "0x402168C")]
		[FieldOffset(Offset = "0x44")]
		public PlayerSandboxV2.RiftInfo.RiftGameStatus riftStatus;

		// Token: 0x0402168D RID: 136845
		[Token(Token = "0x402168D")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, int> playerTrapDeployLimit;

		// Token: 0x0402168E RID: 136846
		[Token(Token = "0x402168E")]
		[FieldOffset(Offset = "0x50")]
		public long readArchiveTs;

		// Token: 0x0402168F RID: 136847
		[Token(Token = "0x402168F")]
		[FieldOffset(Offset = "0x58")]
		public bool supplyUnlocked;

		// Token: 0x04021690 RID: 136848
		[Token(Token = "0x4021690")]
		[FieldOffset(Offset = "0x59")]
		public bool supplyActive;

		// Token: 0x04021691 RID: 136849
		[Token(Token = "0x4021691")]
		[FieldOffset(Offset = "0x5A")]
		public bool isRiftMainFail;

		// Token: 0x04021692 RID: 136850
		[Token(Token = "0x4021692")]
		[FieldOffset(Offset = "0x5B")]
		public bool isRiftMainFinish;

		// Token: 0x04021693 RID: 136851
		[Token(Token = "0x4021693")]
		[FieldOffset(Offset = "0x60")]
		public string currSeasonName;

		// Token: 0x04021694 RID: 136852
		[Token(Token = "0x4021694")]
		[FieldOffset(Offset = "0x68")]
		public string currSeasonColor;

		// Token: 0x04021695 RID: 136853
		[Token(Token = "0x4021695")]
		[FieldOffset(Offset = "0x70")]
		public string currSeasonDesc;

		// Token: 0x04021696 RID: 136854
		[Token(Token = "0x4021696")]
		[FieldOffset(Offset = "0x78")]
		public string currSeasonFunctionDesc;

		// Token: 0x04021697 RID: 136855
		[Token(Token = "0x4021697")]
		[FieldOffset(Offset = "0x80")]
		public PlayerSandboxV2.Challenge.ChallengeStatus challengeStatus;

		// Token: 0x04021698 RID: 136856
		[Token(Token = "0x4021698")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04021699 RID: 136857
		[Token(Token = "0x4021699")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenBasementMaxLevel;

		// Token: 0x0402169A RID: 136858
		[Token(Token = "0x402169A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckBasementUpgrade;

		// Token: 0x0402169B RID: 136859
		[Token(Token = "0x402169B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadSeasonData;

		// Token: 0x0402169C RID: 136860
		[Token(Token = "0x402169C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020042EE RID: 17134
		[Token(Token = "0x20042EE")]
		public struct UpdateParam
		{
			// Token: 0x0402169D RID: 136861
			[Token(Token = "0x402169D")]
			[FieldOffset(Offset = "0x0")]
			public SandboxV2Data topicDetailData;

			// Token: 0x0402169E RID: 136862
			[Token(Token = "0x402169E")]
			[FieldOffset(Offset = "0x8")]
			public PlayerSandboxV2 playerTopicData;

			// Token: 0x0402169F RID: 136863
			[Token(Token = "0x402169F")]
			[FieldOffset(Offset = "0x10")]
			public PlayerSandboxV2.Dungeon playerDungeonData;
		}
	}
}
