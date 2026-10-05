using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike;
using Torappu.UI.RoguelikeTopic.Ending;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044AC RID: 17580
	[Token(Token = "0x20044AC")]
	public class RoguelikeTopicChallengeEndingViewModel : RoguelikeClassicEndingPageViewModel
	{
		// Token: 0x0601ADB1 RID: 110001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADB1")]
		[Address(RVA = "0x1403D80", Offset = "0x1402980", VA = "0x181403D80", Slot = "4")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result)
		{
		}

		// Token: 0x0601ADB2 RID: 110002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADB2")]
		[Address(RVA = "0x1403E40", Offset = "0x1402A40", VA = "0x181403E40", Slot = "5")]
		public override void LoadFromResponse(string topicId, RoguelikeTopicGameSettleResponse response)
		{
		}

		// Token: 0x0601ADB3 RID: 110003 RVA: 0x000A37D0 File Offset: 0x000A19D0
		[Token(Token = "0x601ADB3")]
		[Address(RVA = "0x1403C10", Offset = "0x1402810", VA = "0x181403C10", Slot = "6")]
		public override bool CheckNeedBpView()
		{
			return default(bool);
		}

		// Token: 0x0601ADB4 RID: 110004 RVA: 0x000A37E8 File Offset: 0x000A19E8
		[Token(Token = "0x601ADB4")]
		[Address(RVA = "0x1403C70", Offset = "0x1402870", VA = "0x181403C70", Slot = "7")]
		public override RoguelikeTopicEndingBpAndGpView.Model GeneEndingBpAndGpViewModel()
		{
			return default(RoguelikeTopicEndingBpAndGpView.Model);
		}

		// Token: 0x0601ADB5 RID: 110005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ADB5")]
		[Address(RVA = "0x1403D10", Offset = "0x1402910", VA = "0x181403D10", Slot = "8")]
		public override List<ItemBundle> GetRewardItemList()
		{
			return null;
		}

		// Token: 0x0601ADB6 RID: 110006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADB6")]
		[Address(RVA = "0x1403EE0", Offset = "0x1402AE0", VA = "0x181403EE0")]
		public RoguelikeTopicChallengeEndingViewModel()
		{
		}

		// Token: 0x04022666 RID: 140902
		[Token(Token = "0x4022666")]
		[FieldOffset(Offset = "0x10")]
		public string theme;

		// Token: 0x04022667 RID: 140903
		[Token(Token = "0x4022667")]
		[FieldOffset(Offset = "0x18")]
		public string predefined;

		// Token: 0x04022668 RID: 140904
		[Token(Token = "0x4022668")]
		[FieldOffset(Offset = "0x20")]
		public GameSettleChallenge challenge;

		// Token: 0x04022669 RID: 140905
		[Token(Token = "0x4022669")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402266A RID: 140906
		[Token(Token = "0x402266A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadFromResponse;

		// Token: 0x0402266B RID: 140907
		[Token(Token = "0x402266B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckNeedBpView;

		// Token: 0x0402266C RID: 140908
		[Token(Token = "0x402266C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GeneEndingBpAndGpViewModel;

		// Token: 0x0402266D RID: 140909
		[Token(Token = "0x402266D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetRewardItemList;

		// Token: 0x0402266E RID: 140910
		[Token(Token = "0x402266E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
