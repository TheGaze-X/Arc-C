using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using Torappu.UI.RoguelikeTopic.Ending;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052B5 RID: 21173
	[Token(Token = "0x20052B5")]
	public class RoguelikeClassicEndingMonthViewModel : RoguelikeClassicEndingPageViewModel
	{
		// Token: 0x0601F3B5 RID: 127925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3B5")]
		[Address(RVA = "0x18F4230", Offset = "0x18F2E30", VA = "0x1818F4230", Slot = "4")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result)
		{
		}

		// Token: 0x0601F3B6 RID: 127926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3B6")]
		[Address(RVA = "0x18F4370", Offset = "0x18F2F70", VA = "0x1818F4370", Slot = "5")]
		public override void LoadFromResponse(string topicId, RoguelikeTopicGameSettleResponse response)
		{
		}

		// Token: 0x0601F3B7 RID: 127927 RVA: 0x000B1420 File Offset: 0x000AF620
		[Token(Token = "0x601F3B7")]
		[Address(RVA = "0x18F4030", Offset = "0x18F2C30", VA = "0x1818F4030", Slot = "6")]
		public override bool CheckNeedBpView()
		{
			return default(bool);
		}

		// Token: 0x0601F3B8 RID: 127928 RVA: 0x000B1438 File Offset: 0x000AF638
		[Token(Token = "0x601F3B8")]
		[Address(RVA = "0x18F40B0", Offset = "0x18F2CB0", VA = "0x1818F40B0", Slot = "7")]
		public override RoguelikeTopicEndingBpAndGpView.Model GeneEndingBpAndGpViewModel()
		{
			return default(RoguelikeTopicEndingBpAndGpView.Model);
		}

		// Token: 0x0601F3B9 RID: 127929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F3B9")]
		[Address(RVA = "0x18F41C0", Offset = "0x18F2DC0", VA = "0x1818F41C0", Slot = "8")]
		public override List<ItemBundle> GetRewardItemList()
		{
			return null;
		}

		// Token: 0x0601F3BA RID: 127930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3BA")]
		[Address(RVA = "0x18F4490", Offset = "0x18F3090", VA = "0x1818F4490")]
		private static void _CalculateUnlockChatNum(RoguelikeClassicEndingMonthViewModel viewModel, RoguelikeTopicMonthSquadModel squadModel, out int unlockChatNum, out int chatCount)
		{
		}

		// Token: 0x0601F3BB RID: 127931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3BB")]
		[Address(RVA = "0x18F4780", Offset = "0x18F3380", VA = "0x1818F4780")]
		public RoguelikeClassicEndingMonthViewModel()
		{
		}

		// Token: 0x04029EF4 RID: 171764
		[Token(Token = "0x4029EF4")]
		[FieldOffset(Offset = "0x10")]
		public string theme;

		// Token: 0x04029EF5 RID: 171765
		[Token(Token = "0x4029EF5")]
		[FieldOffset(Offset = "0x18")]
		public string predefined;

		// Token: 0x04029EF6 RID: 171766
		[Token(Token = "0x4029EF6")]
		[FieldOffset(Offset = "0x20")]
		public bool isBpMax;

		// Token: 0x04029EF7 RID: 171767
		[Token(Token = "0x4029EF7")]
		[FieldOffset(Offset = "0x21")]
		public bool isAlreadyMax;

		// Token: 0x04029EF8 RID: 171768
		[Token(Token = "0x4029EF8")]
		[FieldOffset(Offset = "0x22")]
		public bool isFullStored;

		// Token: 0x04029EF9 RID: 171769
		[Token(Token = "0x4029EF9")]
		[FieldOffset(Offset = "0x24")]
		public int endFloor;

		// Token: 0x04029EFA RID: 171770
		[Token(Token = "0x4029EFA")]
		[FieldOffset(Offset = "0x28")]
		public GameSettleMonthTeam monthTeam;

		// Token: 0x04029EFB RID: 171771
		[Token(Token = "0x4029EFB")]
		[FieldOffset(Offset = "0x30")]
		public RoguelikeTopicMonthSquadModel squadModel;

		// Token: 0x04029EFC RID: 171772
		[Token(Token = "0x4029EFC")]
		[FieldOffset(Offset = "0x38")]
		public int unlockChatNum;

		// Token: 0x04029EFD RID: 171773
		[Token(Token = "0x4029EFD")]
		[FieldOffset(Offset = "0x3C")]
		public int totalChatNum;

		// Token: 0x04029EFE RID: 171774
		[Token(Token = "0x4029EFE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04029EFF RID: 171775
		[Token(Token = "0x4029EFF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadFromResponse;

		// Token: 0x04029F00 RID: 171776
		[Token(Token = "0x4029F00")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckNeedBpView;

		// Token: 0x04029F01 RID: 171777
		[Token(Token = "0x4029F01")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GeneEndingBpAndGpViewModel;

		// Token: 0x04029F02 RID: 171778
		[Token(Token = "0x4029F02")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetRewardItemList;

		// Token: 0x04029F03 RID: 171779
		[Token(Token = "0x4029F03")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CalculateUnlockChatNum;

		// Token: 0x04029F04 RID: 171780
		[Token(Token = "0x4029F04")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
