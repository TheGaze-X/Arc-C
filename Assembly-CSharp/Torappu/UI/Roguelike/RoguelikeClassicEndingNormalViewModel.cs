using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using Torappu.UI.RoguelikeTopic.Ending;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052B9 RID: 21177
	[Token(Token = "0x20052B9")]
	public class RoguelikeClassicEndingNormalViewModel : RoguelikeClassicEndingPageViewModel
	{
		// Token: 0x0601F3BE RID: 127934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3BE")]
		[Address(RVA = "0x18F49F0", Offset = "0x18F35F0", VA = "0x1818F49F0", Slot = "4")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result)
		{
		}

		// Token: 0x0601F3BF RID: 127935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3BF")]
		[Address(RVA = "0x18F4CA0", Offset = "0x18F38A0", VA = "0x1818F4CA0", Slot = "5")]
		public override void LoadFromResponse(string topicId, RoguelikeTopicGameSettleResponse response)
		{
		}

		// Token: 0x0601F3C0 RID: 127936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F3C0")]
		[Address(RVA = "0x18F4ED0", Offset = "0x18F3AD0", VA = "0x1818F4ED0")]
		private RoguelikeTopicDifficulty _GetCurrentDifficultyModel(RoguelikeTopicDetail topicDetail, RoguelikeTopicMode mode, int modeGrade)
		{
			return null;
		}

		// Token: 0x0601F3C1 RID: 127937 RVA: 0x000B1450 File Offset: 0x000AF650
		[Token(Token = "0x601F3C1")]
		[Address(RVA = "0x18F4820", Offset = "0x18F3420", VA = "0x1818F4820", Slot = "6")]
		public override bool CheckNeedBpView()
		{
			return default(bool);
		}

		// Token: 0x0601F3C2 RID: 127938 RVA: 0x000B1468 File Offset: 0x000AF668
		[Token(Token = "0x601F3C2")]
		[Address(RVA = "0x18F48A0", Offset = "0x18F34A0", VA = "0x1818F48A0", Slot = "7")]
		public override RoguelikeTopicEndingBpAndGpView.Model GeneEndingBpAndGpViewModel()
		{
			return default(RoguelikeTopicEndingBpAndGpView.Model);
		}

		// Token: 0x0601F3C3 RID: 127939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F3C3")]
		[Address(RVA = "0x18F4990", Offset = "0x18F3590", VA = "0x1818F4990", Slot = "8")]
		public override List<ItemBundle> GetRewardItemList()
		{
			return null;
		}

		// Token: 0x0601F3C4 RID: 127940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3C4")]
		[Address(RVA = "0x18F4FE0", Offset = "0x18F3BE0", VA = "0x1818F4FE0")]
		public RoguelikeClassicEndingNormalViewModel()
		{
		}

		// Token: 0x04029F20 RID: 171808
		[Token(Token = "0x4029F20")]
		private const int DETAIL_COUNT = 7;

		// Token: 0x04029F21 RID: 171809
		[Token(Token = "0x4029F21")]
		[FieldOffset(Offset = "0x10")]
		public string theme;

		// Token: 0x04029F22 RID: 171810
		[Token(Token = "0x4029F22")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicMode mode;

		// Token: 0x04029F23 RID: 171811
		[Token(Token = "0x4029F23")]
		[FieldOffset(Offset = "0x1C")]
		public int modeGrade;

		// Token: 0x04029F24 RID: 171812
		[Token(Token = "0x4029F24")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTopicDifficulty difficulty;

		// Token: 0x04029F25 RID: 171813
		[Token(Token = "0x4029F25")]
		[FieldOffset(Offset = "0x28")]
		public int gpRatio;

		// Token: 0x04029F26 RID: 171814
		[Token(Token = "0x4029F26")]
		[FieldOffset(Offset = "0x30")]
		public RoguelikeEndingScoreViewModel scoreViewModel;

		// Token: 0x04029F27 RID: 171815
		[Token(Token = "0x4029F27")]
		[FieldOffset(Offset = "0x38")]
		public float scoreFactor;

		// Token: 0x04029F28 RID: 171816
		[Token(Token = "0x4029F28")]
		[FieldOffset(Offset = "0x3C")]
		public int totalScore;

		// Token: 0x04029F29 RID: 171817
		[Token(Token = "0x4029F29")]
		[FieldOffset(Offset = "0x40")]
		public int gpCount;

		// Token: 0x04029F2A RID: 171818
		[Token(Token = "0x4029F2A")]
		[FieldOffset(Offset = "0x44")]
		public float bpBuff;

		// Token: 0x04029F2B RID: 171819
		[Token(Token = "0x4029F2B")]
		[FieldOffset(Offset = "0x48")]
		public GameSettleBpInfo bpInfo;

		// Token: 0x04029F2C RID: 171820
		[Token(Token = "0x4029F2C")]
		[FieldOffset(Offset = "0x50")]
		public int[] accumulation;

		// Token: 0x04029F2D RID: 171821
		[Token(Token = "0x4029F2D")]
		[FieldOffset(Offset = "0x58")]
		public int maxAccumulation;

		// Token: 0x04029F2E RID: 171822
		[Token(Token = "0x4029F2E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04029F2F RID: 171823
		[Token(Token = "0x4029F2F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadFromResponse;

		// Token: 0x04029F30 RID: 171824
		[Token(Token = "0x4029F30")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetCurrentDifficultyModel;

		// Token: 0x04029F31 RID: 171825
		[Token(Token = "0x4029F31")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckNeedBpView;

		// Token: 0x04029F32 RID: 171826
		[Token(Token = "0x4029F32")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GeneEndingBpAndGpViewModel;

		// Token: 0x04029F33 RID: 171827
		[Token(Token = "0x4029F33")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetRewardItemList;

		// Token: 0x04029F34 RID: 171828
		[Token(Token = "0x4029F34")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
